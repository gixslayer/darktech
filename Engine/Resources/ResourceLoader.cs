using System.IO;

namespace DarkTech.Engine.Resources
{
    public abstract class ResourceLoader<T> : IResourceLoader where T : Resource
    {
        public abstract string Name { get; }
        public abstract string Author { get; }
        public abstract string Version { get; }

        public abstract T Load(string resourceName, Stream stream);
        public abstract bool ShoudLoad(string resourceName, Stream stream);
        public abstract void Dispose();
    }
}
