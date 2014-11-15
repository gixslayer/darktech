using System;
using Stream = System.IO.Stream;

using DarkTech.Common.Containers;
using DarkTech.Common.PAK;
using DarkTech.Engine.FileSystem;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceManager
    {
        private readonly IMap<string, IStack<PakFile>> packageMapping;
        private readonly IMap<string, PakFile> linkedPackages;
        private readonly IMap<Type, IList<IResourceLoader>> resourceLoaders;
        private readonly IMap<string, Resource> resourceCache;

        internal ResourceManager()
        {
            this.packageMapping = new HashMap<string, IStack<PakFile>>();
            this.linkedPackages = new HashMap<string, PakFile>();
            this.resourceLoaders = new HashMap<Type, IList<IResourceLoader>>();
            this.resourceCache = new HashMap<string, Resource>();
        }

        internal void Dispose()
        {
            foreach (KeyValuePair<string, PakFile> packageLink in linkedPackages)
            {
                packageLink.Value.Close();
            }

            foreach (KeyValuePair<string, Resource> resourceEntry in resourceCache)
            {
                resourceEntry.Value.Dispose();
            }

            foreach (KeyValuePair<Type, IList<IResourceLoader>> resourceLoaderType in resourceLoaders)
            {
                foreach (IResourceLoader loader in resourceLoaderType.Value)
                {
                    loader.Dispose();
                }
            }

            packageMapping.Clear();
            linkedPackages.Clear();
            resourceCache.Clear();
            resourceLoaders.Clear();
        }

        #region Package
        public bool LinkPackage(string path)
        {
            // Prevent linking the same package twice.
            if (linkedPackages.Contains(path))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Package {0} is already loaded", path);

                return true;
            }

            try
            {
                // Begin loading the package file.
                File file = Engine.FileSystem.OpenFile(path, FileMode.Open, FileAccess.Read);
                PakFile pakFile = new PakFile(file);

                // Package file successfully loaded at this point. Add it to the map of linked packages.
                linkedPackages.Add(path, pakFile);

                // Map all entries in the package.
                foreach (PakEntry entry in pakFile.Entries)
                {
                    // If no previous mapping exist for the entry create a new mapping.
                    if (!packageMapping.Contains(entry.Name))
                    {
                        packageMapping.Add(entry.Name, new ArrayStack<PakFile>(4));
                    }

                    // Push the entry on top of the current mapping stack.
                    packageMapping[entry.Name].Push(pakFile);
                }

                return true;
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Could not open file {0} ({1})", path, e.Message);

                return false;
            }
            catch (PakException e)
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Could not open package file {0} ({1})", path, e.Message);

                return false;
            }
        }

        public void UnlinkPackage(string path)
        {
            // Make sure the package is actually linked.
            if (!linkedPackages.Contains(path))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Tried to unlink non existing package {0}", path);

                return;
            }

            // Get the package to unlink from the linked packages map.
            PakFile pakFile = linkedPackages[path];

            // Upmap all entries in the package.
            foreach (PakEntry entry in pakFile.Entries)
            {
                if (packageMapping[entry.Name].Peek().Equals(pakFile))
                {
                    // Entry is on top of the stack, simply pop it off.
                    packageMapping[entry.Name].Pop();
                }
                else
                {
                    // Entry is somewhere in the stack, inefficient method to remove it and preserve the stack order, but required to properly unmap the entry.
                    // Add all entries to a new temporary stack unless it's the entry to remove
                    // then clear the original stack and push every entry in the temp stack back to the original stack.
                    IStack<PakFile> mapping = packageMapping[entry.Name];
                    IStack<PakFile> temp = new ArrayStack<PakFile>(mapping.Count);

                    while (mapping.Count != 0)
                    {
                        PakFile pakFileEntry = mapping.Pop();

                        if (!pakFileEntry.Equals(pakFile))
                        {
                            temp.Push(pakFileEntry);
                        }
                    }

                    while (temp.Count != 0)
                    {
                        mapping.Push(temp.Pop());
                    }
                }
            }

            // Close the package and the underlying stream.
            pakFile.Close();

            // Remove the package from the linked packages map as it's now completely unlinked.
            linkedPackages.Remove(path);
        }
        
        private Stream GetResourceStream(string name)
        {
            return packageMapping[name].Peek().GetEntryStream(name);
        }
        #endregion

        #region Resource
        public bool HasResource(string name)
        {
            return resourceCache.Contains(name);
        }

        public bool HasResource<T>(string name) where T : Resource
        {
            if (!resourceCache.Contains(name))
                return false;

            return resourceCache[name].GetType().Equals(typeof(T));
        }

        public T GetResource<T>(string name) where T : Resource
        {
            if (!HasResource<T>(name))
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Could not find resource {0} of type {1}", name, typeof(T));

                throw new ResourceNotFoundException(name, typeof(T));
            }

            return resourceCache[name] as T;
        }

        public T LoadResource<T>(string name) where T : Resource
        {
            // Prevent loading the resource again if it already exists as the same type.
            if (HasResource<T>(name))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Tried to load already loaded resource {0}", name);

                return GetResource<T>(name);
            }

            // Prevent loading the resource if it already exists as another type.
            if (HasResource(name))
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Resource {0} is already loaded as another type", name);

                throw new DuplicateResourceException(name);
            }

            T resource = LoadResourceInternal<T>(name);

            resourceCache.Add(name, resource);

            return resource;
        }

        public void DisposeResource(string name)
        {
            // Don't try to dispose a non existing resource.
            if (!HasResource(name))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Tried to dispose non existing resource {0}", name);

                return;
            }

            resourceCache[name].Dispose();
            resourceCache.Remove(name);
        }

        private T LoadResourceInternal<T>(string name) where T : Resource
        {
            if (!packageMapping.Contains(name))
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Could not find resource {0}", name);

                throw new ResourceNotFoundException(name);
            }

            if (!HasResourceLoader<T>())
            {
                Engine.Log.WriteLine("error/system/resourcemanager", "Could not find resource loader for type {0}", typeof(T).Name);

                throw new ResourceLoaderNotFoundException(typeof(T));
            }

            Stream resourceStream = GetResourceStream(name);

            foreach (IResourceLoader loader in resourceLoaders[typeof(T)])
            {
                if (!loader.ShoudLoad(name, resourceStream))
                    continue;

                ResourceLoader<T> loaderImp = (ResourceLoader<T>)loader;

                try 
                {
                    return loaderImp.Load(name, resourceStream);
                }
                catch(ResourceLoaderException e) 
                {
                    Engine.Log.WriteLine("error/system/resourcemanager", "Failed to load resource {0} with loader {1} ({2})", name, loader.Name, e.Message);
                }
            }

            Engine.Log.WriteLine("error/system/resourcemanager", "Failed to load resource {0} (No working loader)", name);

            throw new LoadResourceException("No working loader found for resource {0}", name);
        }
        #endregion

        #region Resource loaders
        public bool HasResourceLoader<T>() where T : Resource
        {
            return resourceLoaders.Contains(typeof(T));
        }

        public bool HasResourceLoader<T>(string name) where T : Resource
        {
            if (!HasResourceLoader<T>())
            {
                return false;
            }

            foreach (IResourceLoader resourceLoader in resourceLoaders[typeof(T)])
            {
                if (resourceLoader.Name == name)
                    return true;
            }

            return false;
        }

        public void RegisterResourceLoader<T>(ResourceLoader<T> loader) where T : Resource
        {
            if (loader == null)
                throw new ArgumentNullException("loader");

            if (HasResourceLoader<T>(loader.Name))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Tried to register already registered resource loader {0}", loader.Name);

                return;
            }

            Type type = typeof(T);

            if (!resourceLoaders.Contains(type))
            {
                resourceLoaders.Add(type, new ArrayList<IResourceLoader>());
            }

            resourceLoaders[type].Add(loader);
        }

        public void UnregisterResourceLoader<T>(string name) where T : Resource
        {
            if (!HasResourceLoader<T>(name))
            {
                Engine.Log.WriteLine("warning/system/resourcemanager", "Tried to unregister non existing resource loader {0}", name);

                return;
            }

            Type type = typeof(T);
            IResourceLoader targetLoader = null;

            foreach (IResourceLoader loader in resourceLoaders[type])
            {
                if (loader.Name == name)
                {
                    targetLoader = loader;

                    loader.Dispose();
                }
            }

            resourceLoaders[type].Remove(targetLoader);
        }
        #endregion
    }
}
