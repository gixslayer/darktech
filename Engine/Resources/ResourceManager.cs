using System;
using Stream = System.IO.Stream;
using System.Collections.Generic;

using DarkTech.Common.PAK;
using DarkTech.Engine.FileSystem;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceManager
    {
        private readonly Dictionary<string, Stack<PakFile>> pakMapping;
        private readonly Dictionary<string, PakFile> loadedPaks;
        private readonly Dictionary<Type, Dictionary<string, IResourceLoader>> resourceLoaders;
        private readonly Dictionary<string, Resource> resourceCache;
        private readonly object disposeSync;

        internal ResourceManager()
        {
            this.pakMapping = new Dictionary<string, Stack<PakFile>>();
            this.loadedPaks = new Dictionary<string, PakFile>();
            this.resourceLoaders = new Dictionary<Type, Dictionary<string, IResourceLoader>>();
            this.resourceCache = new Dictionary<string, Resource>();
            this.disposeSync = new object();
        }

        internal void Dispose()
        {
            lock (disposeSync)
            {
                foreach (PakFile pakFile in loadedPaks.Values)
                {
                    pakFile.Close();
                }

                foreach (Resource resource in resourceCache.Values)
                {
                    resource.Dispose();
                }

                foreach (Type type in resourceLoaders.Keys)
                {
                    foreach (IResourceLoader loader in resourceLoaders[type].Values)
                    {
                        loader.Dispose();
                    }
                }

                pakMapping.Clear();
                loadedPaks.Clear();
                resourceCache.Clear();
                resourceLoaders.Clear();
            }
        }

        internal void DisposeCategory(ResourceCategory category)
        {
            lock (disposeSync)
            {
                List<string> disposedResourceNames = new List<string>();

                foreach (KeyValuePair<string, Resource> resource in resourceCache)
                {
                    if (resource.Value.Category != category)
                        continue;

                    resource.Value.Dispose();
                    disposedResourceNames.Add(resource.Key);
                }

                foreach (string resourceName in disposedResourceNames)
                {
                    resourceCache.Remove(resourceName);
                }
            }
        }

        #region Pak
        public bool LoadPak(string path)
        {
            File file;
            PakFile pakFile;

            if (loadedPaks.ContainsKey(path))
            {
                Engine.Warningf("Pak {0} is already loaded", path);

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
            catch (PakException e)
            {
                Engine.Errorf("Could not open pak file {0} > {1}", path, e.Message);

                return false;
            }

            // Pak file successfully loaded at this point. Add it to the map of open pak files.
            loadedPaks.Add(path, pakFile);

            // Map all entries in the pak file.
            foreach (PakEntry entry in pakFile.Entries)
            {
                if (!pakMapping.ContainsKey(entry.Name))
                {
                    pakMapping.Add(entry.Name, new Stack<PakFile>());
                }

                pakMapping[entry.Name].Push(pakFile);
            }

            return true;
        }

        public void UnloadPak(string path)
        {
            if (!loadedPaks.ContainsKey(path))
            {
                return;
            }

            PakFile pakFile = loadedPaks[path];

            // Upmap all entries in the pak file.
            foreach (PakEntry entry in pakFile.Entries)
            {
                if (pakMapping[entry.Name].Peek().Equals(pakFile))
                {
                    // Entry is on top of the stack, simply pop it off.
                    pakMapping[entry.Name].Pop();
                }
                else
                {
                    // Entry is somewhere in the stack, inefficient method to remove it and preserve the stack order, but required to properly unmap the entry.
                    // Add all entries to a new temporary stack unless it's the entry to remove
                    // then clear the original stack and push every entry in the temp stack back to the original stack.
                    Stack<PakFile> temp = new Stack<PakFile>();
                    Stack<PakFile> mapping = pakMapping[entry.Name];

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

        private Stream GetResourceStream(string name)
        {
            return pakMapping[name].Peek().GetEntryStream(name);
        }
        #endregion

        #region Resource
        public T GetResource<T>(string name) where T : Resource
        {
            // Ensure requested resource is cached.
            if (!IsResourceCached(name))
            {
                if (!CacheResource<T>(name))
                {
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
                Engine.Warningf("Duplicate resource cache for {0}", name);

                return true;
            }

            T resource;

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

            Stream resourceStream = GetResourceStream(name);

            foreach (IResourceLoader loader in resourceLoaders[typeof(T)].Values)
            {
                if (!loader.ShoudLoad(name, resourceStream))
                    continue;

                ResourceLoader<T> loaderImp = (ResourceLoader<T>)loader;

                try 
                {
                    result = loaderImp.Load(name, resourceStream);

                    return true;
                }
                catch(ResourceLoaderException e) 
                {
                    Engine.Errorf("Failed to load resource {0} with loader {1} -> {2}", name, loader.Name, e.Message);
                }
            }

            Engine.Errorf("Failed to load resource {0} -> No working loader found", name);

            return false;
        }
        #endregion

        #region Resource loaders
        public bool HasResourceLoader<T>() where T : Resource
        {
            return resourceLoaders.ContainsKey(typeof(T));
        }

        public bool HasResourceLoader<T>(string name) where T : Resource
        {
            if (!HasResourceLoader<T>())
            {
                return false;
            }

            return resourceLoaders[typeof(T)].ContainsKey(name);
        }

        public void RegisterResourceLoader<T>(ResourceLoader<T> loader) where T : Resource
        {
            if (loader == null)
                throw new ArgumentNullException("loader");

            if (HasResourceLoader<T>(loader.Name))
            {
                Engine.Warningf("Duplicate resource loader registration -> {0}", loader.Name);

                return;
            }

            Type type = typeof(T);

            if (!resourceLoaders.ContainsKey(type))
            {
                resourceLoaders.Add(type, new Dictionary<string, IResourceLoader>());
            }

            resourceLoaders[type].Add(loader.Name, loader);
        }

        public void UnregisterResourceLoader<T>(string name) where T : Resource
        {
            if (!HasResourceLoader<T>(name))
            {
                return;
            }

            Type type = typeof(T);

            IResourceLoader loader = resourceLoaders[type][name];

            loader.Dispose();

            resourceLoaders[type].Remove(name);
        }
        #endregion
    }
}
