using System;

namespace DarkTech.Engine.Timing
{
    public interface ITimer : IDisposable
    {
        float ElapsedTime { get; }
        long TicksPerSecond { get; }

        bool Initialize();
        void Split();
        long CurrentTick();
    }
}
