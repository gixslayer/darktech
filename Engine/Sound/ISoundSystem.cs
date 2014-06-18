using System;

namespace DarkTech.Engine.Sound
{
    public interface ISoundSystem : IDisposable
    {
        bool CreateContext();
        void Initialize();
        void Start();
    }
}
