using System;

namespace DarkTech.Engine.Sound
{
    public interface ISoundSystem : IDisposable
    {
        bool Initialize();
        void Start();
        void Restart();
    }
}
