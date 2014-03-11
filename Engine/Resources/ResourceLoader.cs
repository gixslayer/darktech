using System.IO;

namespace DarkTech.Engine.Resources
{
    public abstract class ResourceLoader { }

    public abstract class ResourceLoader<T> : ResourceLoader where T : Resource
    {
        // Implementations should call Engine.Error(f) with an error message if they fail to load the resource.
        public abstract bool Load(Stream stream, out T result);
    }
}
