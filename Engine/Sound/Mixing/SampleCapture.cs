namespace DarkTech.Engine.Sound.Mixing
{
    internal sealed class SampleCapture : ISampleConsumer
    {
        public Sample LastCapturedSample { get; private set; }
        public bool CapturedNewSample { get; private set; }

        internal SampleCapture()
        {
            this.CapturedNewSample = false;
        }

        public void Process(ref Sample sample)
        {
            LastCapturedSample = sample;
            CapturedNewSample = true;
        }

        public void MarkRead()
        {
            CapturedNewSample = false;
        }
    }
}
