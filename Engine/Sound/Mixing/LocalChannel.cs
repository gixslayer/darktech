namespace DarkTech.Engine.Sound.Mixing
{
    /// <summary>
    /// Provides a channel implementation for sounds local to the listener (no spatialization)
    /// </summary>
    internal sealed class LocalChannel : Channel
    {
        public LocalChannel(SampleBuffer outputBuffer)
            : base(outputBuffer)
        {

        }

        protected override void Spatialize(ref Sample sample) { }
    }
}
