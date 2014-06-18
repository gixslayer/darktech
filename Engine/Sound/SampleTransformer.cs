namespace DarkTech.Engine.Sound
{
    public abstract class SampleTransformer : ISampleProvider, ISampleConsumer
    {
        public ISampleConsumer Output { get; set; }
        public bool Bypass { get; set; }

        public abstract void Process();

        protected abstract Sample Transform(ref Sample input);

        public virtual void Process(ref Sample input)
        {
            Sample temp = Bypass ? input : Transform(ref input);

            Output.Process(ref temp);
        }
    }
}
