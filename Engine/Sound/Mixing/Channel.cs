namespace DarkTech.Engine.Sound.Mixing
{
    internal abstract class Channel
    {
        private readonly SampleBuffer buffer;
        private readonly EffectChain effectChain;
        private float gain;

        public float Gain
        {
            get { return gain; }
            set { gain = value; }
        }

        public Channel(SampleBuffer outputBuffer)
        {
            this.buffer = new SampleBuffer(4);
            this.effectChain = new EffectChain(outputBuffer);
            this.gain = 1f;
        }

        public void Process(ref Sample sample)
        {
            buffer.Add(ref sample);
        }

        public bool Mix()
        {
            if (buffer.Count != 0)
            {
                // Mix all buffered samples.
                Sample mixedSample = new Sample(0f, 0f);

                foreach (Sample sample in buffer)
                {
                    mixedSample.left += sample.left;
                    mixedSample.right += sample.right;
                }

                // Apply the channel gain to the mixed sample.
                mixedSample.left *= gain;
                mixedSample.right *= gain;

                // Spatialize the mixed sample.
                Spatialize(ref mixedSample);

                // Send the mixed sample to the effect chain.
                effectChain.Process(ref mixedSample);

                // Clear the sample buffer as all samples have been processed.
                buffer.Clear();
            }

            // Apply the effect chain.
            // The return value is used to determine if a sample was generated and send to the master buffer.
            return effectChain.Apply();
        }

        protected abstract void Spatialize(ref Sample sample);
    }
}
