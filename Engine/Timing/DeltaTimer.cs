namespace DarkTech.Engine.Timing
{
    public sealed class DeltaTimer
    {
        public float Timestep { get; set; }
        public bool HasNextFrame
        {
            get { return accumilator >= Timestep; }
        }

        private readonly ITimer timer;
        private readonly float timerFrequency;
        private long lastTick;
        private float accumilator;

        public DeltaTimer(ITimer timer, float timestep)
        {
            this.Timestep = timestep;
            this.timer = timer;
            this.timerFrequency = (float)timer.TicksPerSecond;
            this.lastTick = timer.CurrentTick();
            this.accumilator = 0f;
        }

        public void Update()
        {
            long currentTick = timer.CurrentTick();
            float elapsed = (currentTick - lastTick) / timerFrequency;
            lastTick = currentTick;

            accumilator += elapsed;
        }

        public void RanFrame()
        {
            accumilator -= Timestep;
        }

        public void ResetAccumilator()
        {
            accumilator = 0f;
        }
    }
}
