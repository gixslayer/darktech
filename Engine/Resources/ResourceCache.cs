using System;
using System.Collections.Generic;

namespace DarkTech.Engine.Resources
{
    internal abstract class ResourceCache { }

    internal sealed class ResourceCache<T> : ResourceCache where T : IResource
    {
        private readonly Dictionary<string, T> cache;

        public ResourceCache()
        {
            this.cache = new Dictionary<string, T>();
        }

        public T this[string name]
        {
            get
            {
                if (!HasResource(name))
                    throw new ArgumentException("Resource is not cached", "name");

                return cache[name];
            }
        }

        public bool HasResource(string name)
        {
            return cache.ContainsKey(name);
        }

        public void CacheResource(string name, T resource)
        {
            if (HasResource(name))
                throw new ArgumentException("Duplicate resource cache entry", "name");

            cache.Add(name, resource);
        }

        public void DisposeResource(string name)
        {
            if (HasResource(name))
            {
                T resource = cache[name];

                resource.Dispose();

                cache.Remove(name);
            }
        }

        public void Dispose()
        {
            foreach (T resource in cache.Values)
            {
                resource.Dispose();
            }

            cache.Clear();
        }
    }
}
