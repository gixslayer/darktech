namespace DarkTech.Engine.Sound.Mixing
{
    internal abstract class SampleProvider
    {
        public SampleProviderState State { get; protected set; }
        public Channel Output { get; set; }

        public void Process()
        {
            if (State != SampleProviderState.Playing)
            {
                return;
            }

            Sample sample = NextSample();

            Output.Process(ref sample);
        }

        protected abstract Sample NextSample();
    }
}
