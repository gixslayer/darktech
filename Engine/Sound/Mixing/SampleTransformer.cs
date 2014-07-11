namespace DarkTech.Engine.Sound
{
    public abstract class SampleTransformer : ISampleProvider, ISampleConsumer
    {
        public ISampleConsumer Output { get; set; }
        public bool Bypass { get; set; }

        public abstract void Process();

        protected abstract bool Transform(ref Sample input);

        public virtual void Process(ref Sample input)
        {
            if (Bypass) return;

            if (Transform(ref input))
            {
                Output.Process(ref input);
            }
        }
    }
}
