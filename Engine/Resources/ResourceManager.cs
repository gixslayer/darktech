using System;
using System.IO;
using System.Collections.Generic;

using DarkTech.Common.PAK;
using DarkTech.Common.Utils;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceManager
    {
        private readonly Dictionary<string, Stack<PakFile>> pakMapping;
        private readonly Dictionary<string, PakFile> loadedPaks;
        private readonly Dictionary<Type, ResourceLoader> resourceLoaders;
        private readonly Dictionary<string, Resource> resourceCache;

        public ResourceManager()
        {
            this.pakMapping = new Dictionary<string, Stack<PakFile>>();
            this.loadedPaks = new Dictionary<string, PakFile>();
            this.resourceLoaders = new Dictionary<Type, ResourceLoader>();
            this.resourceCache = new Dictionary<string, Resource>();
        }

        public void Dispose()
        {
            foreach (PakFile pakFile in loadedPaks.Values)
            {
                pakFile.Close();
            }

            foreach (Resource resource in resourceCache.Values)
            {
                resource.Dispose();
            }

            pakMapping.Clear();
            loadedPaks.Clear();
            resourceCache.Clear();
            resourceLoaders.Clear();
        }

        public bool LoadPak(string path)
        {
            File file;
            PakFile pakFile;

            if (loadedPaks.ContainsKey(path))
            {
                Engine.PrintDebugf("Pak {0} is already loaded", path);

                return true;
            }

            if (!Engine.FileSystem.OpenFile(path, FileMode.Open, FileAccess.Read, out file))
            {
                return false;
            }

            // Load the pak file.
            try
            {
                pakFile = new PakFile(file);
            }
            catch (StreamException e)
            {
                Engine.Errorf("Could not open pak file {0} > ", path, e.Message);

                return false;
            }

            // Pak file successfully loaded at this point. Add it to the map of open pak files.
            loadedPaks.Add(path, pakFile);

            // Map all entries in the pak file.
            foreach (string entry in pakFile.EntryNames)
            {
                if (!pakMapping.ContainsKey(entry))
                {
                    pakMapping.Add(entry, new Stack<PakFile>());
                }

                pakMapping[entry].Push(pakFile);
            }

            return true;
        }

        public void UnloadPak(string path)
        {
            if (!loadedPaks.ContainsKey(path))
            {
                Engine.PrintDebugf("Pak {0} isn't loaded", path);

                return;
            }

            PakFile pakFile = loadedPaks[path];

            // Upmap all entries in the pak file.
            foreach (string entry in pakFile.EntryNames)
            {
                if (pakMapping[entry].Peek().Equals(pakFile))
                {
                    // Entry is on top of the stack, simply pop it off.
                    pakMapping[entry].Pop();
                }
                else
                {
                    // Entry is somewhere in the stack, inefficient method to remove it and preserve the stack order, but required to properly unmap the entry.
                    // Add all entries to a new temporary stack unless it's the entry to remove
                    // then clear the original stack and push every entry in the temp stack back to the original stack.
                    Stack<PakFile> temp = new Stack<PakFile>();
                    Stack<PakFile> mapping = pakMapping[entry];

                    while (mapping.Count != 0)
                    {
                        PakFile pakFileEntry = mapping.Pop();

                        if (!pakFileEntry.Equals(pakFile))
                        {
                            temp.Push(pakFileEntry);
                        }
                    }

                    mapping.Clear();

                    while (temp.Count != 0)
                    {
                        mapping.Push(temp.Pop());
                    }
                }
            }

            // Close the pak file and the underlying stream.
            pakFile.Close();

            loadedPaks.Remove(path);
        }

        public bool HasResource(string name)
        {
            return pakMapping.ContainsKey(name);
        }

        public T GetResource<T>(string name) where T : Resource
        {
            // Ensure requested resource is cached.
            if (!IsResourceCached(name))
            {
                if (!CacheResource<T>(name))
                {
                    Engine.Errorf("Failed to cache resource {0}", name);

                    return null;
                }
            }

            Resource resource = resourceCache[name];

            // Ensure resource can be converted to requested generic type.
            if (!typeof(T).IsAssignableFrom(resource.GetType()))
                throw new ArgumentException("Resource type mismatch", "T");

            return resource as T;
        }

        public bool CacheResource<T>(string name) where T : Resource
        {
            if (IsResourceCached(name))
            {
                Engine.Warningf("Duplicate resource cache entry for {0}", name);

                DisposeResource(name);
            }

            T resource;

            // LoadResource should print information in case it fails to load the resource.
            if (!LoadResource<T>(name, out resource))
            {
                return false;
            }

            resourceCache.Add(name, resource);

            return true;
        }

        public bool IsResourceCached(string name)
        {
            return resourceCache.ContainsKey(name);
        }

        public void DisposeResource(string name)
        {
            if (IsResourceCached(name))
            {
                resourceCache[name].Dispose();
                resourceCache.Remove(name);
            }
        }

        public bool HasResourceLoader<T>() where T : Resource
        {
            return resourceLoaders.ContainsKey(typeof(T));
        }

        public void RegisterResourceLoader<T>(ResourceLoader<T> loader) where T : Resource
        {
            if (HasResourceLoader<T>())
            {
                Engine.Warningf("Duplicate resource loader registration for type {0}", typeof(T).FullName);

                UnregisterResourceLoader<T>();
            }

            resourceLoaders.Add(typeof(T), loader);
        }

        public void UnregisterResourceLoader<T>() where T : Resource
        {
            if (HasResourceLoader<T>())
            {
                resourceLoaders.Remove(typeof(T));
            }
        }

        private bool LoadResource<T>(string name, out T result) where T : Resource
        {
            result = null;

            if (!HasResource(name))
            {
                Engine.Errorf("Could not find resource {0}", name);

                return false;
            }

            if (!HasResourceLoader<T>())
            {
                Engine.Errorf("Missing resource loader for type {0}", typeof(T).FullName);

                return false;
            }

            // The resource loader will always be of type ResourceLoader<T>.
            ResourceLoader<T> loader = resourceLoaders[typeof(T)] as ResourceLoader<T>;
            Stream stream = GetResourceStream(name);

            // The resource loader should print information in case it fails to load the resource.
            return loader.Load(stream, out result);
        }

        private Stream GetResourceStream(string name)
        {
            return pakMapping[name].Peek().GetEntryStream(name);
        }
    }
}
