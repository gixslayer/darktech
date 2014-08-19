namespace DarkTech.Engine.Sound.Mixing
{
    /// <summary>
    /// Provides a channel implementation for sounds that are played at a dynamic location.
    /// </summary>
    internal sealed class DynamicChannel : Channel
    {
        private readonly Listener listener;

        public DynamicChannel(Listener listener, SampleBuffer outputBuffer)
            : base(outputBuffer)
        {
            this.listener = listener;
        }

        protected override void Spatialize(ref Sample sample)
        {
            throw new System.NotImplementedException();
        }
    }
}
