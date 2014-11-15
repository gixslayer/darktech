using System;

namespace DarkTech.Engine
{
    public interface IClient : IDisposable
    {
        string Name { get; }
        string Author { get; }
        string Version { get; }

        /// <summary>
        /// Initial startup. Register/set cvars/commands before full engine startup.
        /// If the dll experiences an unrecoverable error during init it must throw an InitializeException.
        /// </summary>
        void Initialize();
        void Load();

        void Update(float dt);
        void Render();
    }
}
