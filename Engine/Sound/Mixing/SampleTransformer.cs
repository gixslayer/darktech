namespace DarkTech.Engine.Sound.Mixing
{
    public abstract class SampleTransformer : ISampleProvider, ISampleConsumer
    {
        public ISampleConsumer Output { get; set; }
        public bool Bypass { get; set; }

        public virtual void Process() { }

        public virtual void Process(ref Sample input)
        {
            if (Bypass) return;

            if (Transform(ref input))
            {
                Output.Process(ref input);
            }
        }

        protected abstract bool Transform(ref Sample input);
    }
}
