using System;
using System.Collections.Generic;

using DarkTech.Engine.Resources.PAK;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceManager
    {
        private Dictionary<string, Stack<PakFile>> pakMapping;
        private Dictionary<string, PakFile> loadedPaks;
        private Dictionary<Type, ResourceCache> resourceCaches;
        private Dictionary<Type, ResourceLoader> resourceLoaders;

        public ResourceManager()
        {
            this.pakMapping = new Dictionary<string, Stack<PakFile>>();
            this.loadedPaks = new Dictionary<string, PakFile>();
            this.resourceCaches = new Dictionary<Type, ResourceCache>();
            this.resourceLoaders = new Dictionary<Type, ResourceLoader>();
        }

        public void Dispose()
        {
            foreach (PakFile pakFile in loadedPaks.Values)
            {
                pakFile.Close();
            }

            foreach (ResourceCache<IResource> resourceCache in resourceCaches.Values)
            {
                resourceCache.Dispose();
            }

            pakMapping.Clear();
            loadedPaks.Clear();
            resourceCaches.Clear();
            resourceLoaders.Clear();
        }

        public bool LoadPak(string path)
        {
            if (loadedPaks.ContainsKey(path))
            {
                Engine.Warningf("Pak {0} is already loaded", path);

                return true;
            }

            PakFile pakFile = new PakFile();

            File file = Engine.FileSystem.OpenFile(path, FileMode.Open, FileAccess.Read);

            if(file == null) 
            {
                return false;
            }

            if (!pakFile.Load(file))
            {
                Engine.Errorf("Could not open pak file {0}", path);

                return false;
            }

            loadedPaks.Add(path, pakFile);

            foreach (string entry in pakFile.GetEntryNames())
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
                Engine.Warningf("Pak {0} isn't loaded", path);

                return;
            }

            PakFile pakFile = loadedPaks[path];

            // Upmap all entries in the pak file.
            foreach (string entry in pakFile.GetEntryNames())
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

        public T GetResource<T>(string name) where T : IResource
        {
            if (!IsResourceCached<T>(name))
            {
                if (!CacheResource<T>(name))
                {
                    Engine.Errorf("Failed to cache resource {0} of type {1}", name, typeof(T).FullName);

                    return default(T);
                }
            }

            return GetResourceCache<T>()[name];
        }

        public bool CacheResource<T>(string name) where T : IResource
        {
            if (IsResourceCached<T>(name))
            {
                Engine.Warningf("Duplicate resource cache entry for {0} of type {1}", name, typeof(T).FullName);

                DisposeResource<T>(name);
            }

            T resource;

            if (!LoadResource<T>(name, out resource))
            {
                return false;
            }

            if (!resourceCaches.ContainsKey(typeof(T)))
            {
                resourceCaches.Add(typeof(T), new ResourceCache<T>());
            }

            GetResourceCache<T>().CacheResource(name, resource);

            return true;
        }

        public bool IsResourceCached<T>(string name) where T : IResource
        {
            if (!resourceCaches.ContainsKey(typeof(T)))
            {
                return false;
            }

            return GetResourceCache<T>().HasResource(name);
        }

        public void DisposeResource<T>(string name) where T : IResource
        {
            if (IsResourceCached<T>(name))
            {
                GetResourceCache<T>().DisposeResource(name);
            }
        }

        public bool HasResourceLoader<T>() where T : IResource
        {
            return resourceLoaders.ContainsKey(typeof(T));
        }

        public void RegisterResourceLoader<T>(ResourceLoader<T> loader) where T : IResource
        {
            if (HasResourceLoader<T>())
            {
                Engine.Warningf("Duplicate resource loader registration for type {0}", typeof(T).FullName);

                UnregisterResourceLoader<T>();
            }

            resourceLoaders.Add(typeof(T), loader);
        }

        public void UnregisterResourceLoader<T>() where T : IResource
        {
            if (HasResourceLoader<T>())
            {
                resourceLoaders.Remove(typeof(T));
            }
        }

        private bool LoadResource<T>(string name, out T result) where T : IResource
        {
            result = default(T);

            if (!HasResource(name))
            {
                Engine.Errorf("Could not find resource {0}", name);

                return false;
            }

            PakStream stream = GetResourceStream(name);

            if (!HasResourceLoader<T>())
            {
                Engine.Errorf("Missing resource loader for type {0}", typeof(T).FullName);

                return false;
            }

            // The resource loader will always be of type ResourceLoader<T>.
            ResourceLoader<T> loader = resourceLoaders[typeof(T)] as ResourceLoader<T>;

            return loader.Load(stream, out result);
        }

        private PakStream GetResourceStream(string name)
        {
            if (!HasResource(name))
                throw new ArgumentException("Resource does not exist", "name");

            return pakMapping[name].Peek().GetEntryStream(name);
        }

        private ResourceCache<T> GetResourceCache<T>() where T : IResource
        {
            return resourceCaches[typeof(T)] as ResourceCache<T>;
        }
    }
}
