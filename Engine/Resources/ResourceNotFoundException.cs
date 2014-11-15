using System;

namespace DarkTech.Engine.Resources
{
    public sealed class ResourceNotFoundException : EngineException
    {
        public ResourceNotFoundException(string name) : base("Could not find resource {0}", name) { }
        public ResourceNotFoundException(string name, Type type) : base("Could not find resource {0} of type {1}", name, type.Name) { }
    }
}
