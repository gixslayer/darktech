namespace DarkTech.Engine.Sound.Mixing
{
    internal abstract class Effect
    {
        protected readonly SampleBuffer outputBuffer;

        public Effect(SampleBuffer outputBuffer)
        {
            this.outputBuffer = outputBuffer;
        }

        public abstract void Process(ref Sample sample);
        public abstract bool Apply();
    }
}
