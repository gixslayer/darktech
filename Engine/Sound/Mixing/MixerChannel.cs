using System;

using DarkTech.Engine.Sound.Mixing.Filters;

namespace DarkTech.Engine.Sound.Mixing
{
    public sealed class MixerChannel : ISampleConsumer, ISampleProvider
    {
        private readonly SampleBuffer buffer;
        private readonly GainBalanceFilter filter;
        private readonly EffectChain effectChain;
        private readonly ISampleConsumer output;

        public ISampleConsumer Output 
        {
            get { return output; }
            set { throw new NotSupportedException(); }
        }
        public EffectChain EffectChain 
        { 
            get { return effectChain; }
        }
        public float Gain
        {
            get { return filter.Gain; }
            set { filter.Gain = value; }
        }
        public float Balance
        {
            get { return filter.Balance; }
            set { filter.Balance = value; }
        }
        
        internal MixerChannel(ISampleConsumer output)
        {
            this.buffer = new SampleBuffer();
            this.filter = new GainBalanceFilter();
            this.effectChain = new EffectChain();
            this.output = output;

            filter.Output = effectChain;
            effectChain.Output = buffer;
        }

        public void Process()
        {
            // If no samples are buffered don't attempt to mix and output anything to the output.
            if (buffer.Count == 0)
            {
                return;
            }

            // At least one sample in the buffer.
            Sample sample = buffer[0];

            // Mix any additional samples in the buffer.
            for (int i = 1; i < buffer.Count; i++)
            {
                Sample bufferedSample = buffer[i];

                sample.left += bufferedSample.left;
                sample.right += bufferedSample.right;
            }

            // Clear the buffer.
            buffer.Clear();

            // Pass the mixed sample to the output.
            output.Process(ref sample);
        }

        public void Process(ref Sample input)
        {
            filter.Process(ref input);
        }
    }
}
