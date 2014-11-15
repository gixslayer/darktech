using System;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceLoaderNotFoundException : ResourceException
    {
        public ResourceLoaderNotFoundException(Type type) : base("Could not find resource loader for type {0}", type.Name) { }
    }
}
