using DarkTech.Engine.Resources;

namespace DarkTech.Engine.Sound.Mixing
{
    public sealed class SamplePlayer : SampleProvider
    {
        public delegate Sample InterpolateDelegate(ref Sample a, ref Sample b, float f);

        public static InterpolateDelegate InterpolationModel { get; internal set; }

        private readonly SoundData source;
        private float balance;
        private float gain;
        private float leftGain;
        private float rightGain;
        private float index;

        public float Pitch { get; set; }
        public bool Loop { get; set; }
        public float Gain
        {
            get { return gain; }
            set
            {
                gain = value;

                // Compute left/right gain.
                ComputeGain();
            }
        }
        public float Balance
        {
            get { return balance; }
            set
            {
                balance = value;

                // Compute left/right gain.
                ComputeGain();
            }
        }

        public SamplePlayer(SoundDefinition soundDefinition)
        {
            this.source = soundDefinition.SoundData;
            this.balance = soundDefinition.Balance;
            this.gain = soundDefinition.Gain;
            this.index = 0f;
            this.State = SampleProviderState.Playing;
            this.Pitch = soundDefinition.Pitch;
            this.Loop = soundDefinition.Loop;

            // Compute left/right gain.
            ComputeGain();
        }

        protected Sample NextSample()
        {
            // Compute the integer and fraction components.
            int intIndex = (int)index;
            float fraction = index - intIndex;

            // Compute the output sample.
            Sample outputSample;

            if (intIndex + 1 == source.SampleCount)
            {
                // Last sample so no interpolation can be done.
                // Clone the last sample and use that instead.
                outputSample = source[intIndex].Clone();
            }
            else
            {
                // Get the two samples around the current index.
                Sample baseSample = source[intIndex];
                Sample nextSample = source[intIndex + 1];

                // Interpolate between the samples based on the fraction.
                outputSample = InterpolationModel(ref baseSample, ref nextSample, fraction);
            }

            // Apply gain to the output sample.
            outputSample.left *= leftGain;
            outputSample.right *= rightGain;

            // Update the index according to the pitch.
            index += Pitch;

            if (index >= source.SampleCount)
            {
                // If the current index is outside of the source data and the sample player is set to loop then wrap around the source data.
                if (Loop)
                {
                    index %= source.SampleCount;
                }
                else // Else the end of the source data is reached.
                {
                    State = SampleProviderState.Stopped;
                }
            }

            return outputSample;
        }

        private void ComputeGain()
        {
            leftGain = balance > 0 ? (1f - balance) * gain : gain;
            rightGain = balance < 0 ? (1f + balance) * gain : gain;
        }

        #region Interpolation models
        public static Sample LerpModel(ref Sample a, ref Sample b, float f)
        {
            Sample result = new Sample();

            result.left = (1.0f - f) * a.left + f * b.left;
            result.right = (1.0f - f) * a.right + f * b.right;

            return result;
        }
        #endregion
    }
}
