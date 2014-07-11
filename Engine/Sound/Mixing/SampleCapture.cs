namespace DarkTech.Engine.Sound
{
    public sealed class SampleCapture : ISampleConsumer
    {
        public Sample LastCapturedSample { get; private set; }
        public bool CapturedNewSample { get; private set; }

        public SampleCapture()
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
