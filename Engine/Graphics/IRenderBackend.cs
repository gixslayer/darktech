using System;

namespace DarkTech.Engine.Graphics
{
    public interface IRenderBackend
    {
        bool CreateContext();
        void Initialize();
        void Start();
        void Stop();
        void Process();
    }
}
