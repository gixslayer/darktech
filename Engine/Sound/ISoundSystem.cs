using System;

namespace DarkTech.Engine.Sound
{
    public interface ISoundSystem : IDisposable
    {
        void Initialize();
        void Start();
        void Restart();
    }
}
