using System;
using System.IO;

namespace DarkTech.Engine.Resources
{
    public interface IResourceLoader : IDisposable
    {
        string Name { get; }
        string Author { get; }
        string Version { get; }

        // Any resource loader can read/seek in the stream but must ensure the position is set to zero once the method returns.
        bool ShoudLoad(string resourceName, Stream stream);
    }
}
