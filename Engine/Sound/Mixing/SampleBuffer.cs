using System;
using System.Collections.Generic;

namespace DarkTech.Engine.Sound
{
    public sealed class SampleBuffer : ISampleConsumer
    {
        private readonly List<Sample> samples;

        public int Count { get { return samples.Count; } }

        public SampleBuffer()
        {
            this.samples = new List<Sample>();
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
