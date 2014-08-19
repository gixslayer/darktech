using DarkTech.Common.Math;

namespace DarkTech.Engine.Sound.Mixing
{
    /// <summary>
    /// Provides a channel implementation for sounds that are played at a static location.
    /// </summary>
    internal sealed class StaticChannel : Channel
    {
        private readonly Vector3f location;
        private readonly Listener listener;

        public StaticChannel(Vector3f location, Listener listener, SampleBuffer outputBuffer) 
            : base(outputBuffer)
        {
            this.location = location;
            this.listener = listener;
        }

        protected override void Spatialize(ref Sample sample)
        {
            throw new System.NotImplementedException();
        }
    }
}
