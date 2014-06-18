using System.Runtime.InteropServices;

namespace DarkTech.Engine.Timing
{
    internal sealed class TimerWin : ITimer
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool QueryPerformanceFrequency(out long frequency);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        private long frequency;
        private long lastCounter;
        private long newCounter;
        private float elapsedTime;

        public float ElapsedTime { get { return elapsedTime; } }
        public long TicksPerSecond { get { return frequency; } }

        public TimerWin()
        {
            frequency = 0;
            lastCounter = 0;
            newCounter = 0;
            elapsedTime = 0;
        }

        public bool Initialize()
        {
            if (!QueryPerformanceFrequency(out frequency))
                return false;

            return QueryPerformanceCounter(out lastCounter);
        }

        public void Split()
        {
            QueryPerformanceCounter(out newCounter);

            elapsedTime = (float)(newCounter - lastCounter) / frequency;

            lastCounter = newCounter;
        }

        public long CurrentTick()
        {
            long result;

            QueryPerformanceCounter(out result);

            return result;
        }

        public void Dispose() { }
    }
}
