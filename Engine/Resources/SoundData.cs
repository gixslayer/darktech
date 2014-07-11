using System;

using DarkTech.Engine.Sound;

namespace DarkTech.Engine.Resources
{
    public sealed class SoundData : Resource
    {
        public int SampleCount { get; private set; }

        private readonly Sample[] samples;

        public SoundData(Sample[] samples)
            : base(ResourceCategory.Sound)
        {
            this.samples = samples;
            this.SampleCount = samples.Length;
        }

        public Sample this[int index]
        {
            get
            {
                if (index < 0 || index >= SampleCount)
                    throw new ArgumentOutOfRangeException("index");

                return samples[index];
            }
        }

        public override void Dispose() { }
    }
}
