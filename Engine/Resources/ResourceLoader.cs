using DarkTech.Engine.Resources.PAK;

namespace DarkTech.Engine.Resources
{
    public abstract class ResourceLoader { }

    public abstract class ResourceLoader<T> : ResourceLoader where T : IResource
    {
        // Implementations should call Engine.Error(f) with a reason if they fail to load the resource.
        public abstract bool Load(PakStream stream, out T result);
    }
}
