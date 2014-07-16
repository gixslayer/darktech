using System;

using DarkTech.Common.Containers;

namespace DarkTech.Engine.Sound.Mixing
{
    public sealed class SampleBuffer : ISampleConsumer
    {
        private readonly IList<Sample> samples;

        public int Count { get { return samples.Count; } }

        public SampleBuffer(int initialCapacity = 8)
        {
            this.samples = new ArrayList<Sample>(initialCapacity);
        }

        public Sample this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException("index");

                return samples[index];
            }
            set
            {
                if(index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException("index");

                samples[index] = value;
            }
        }

        public void Process(ref Sample input)
        {
            samples.Add(input);
        }

        public void Clear()
        {
            samples.Clear();
        }
    }
}
