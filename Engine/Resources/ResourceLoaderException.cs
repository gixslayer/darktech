using System;

namespace DarkTech.Engine.Resources
{
    public class ResourceLoaderException : Exception
    {
        public ResourceLoaderException(string message) : base(message) { }
    }
}
