using System;

namespace DarkTech.Engine.Sound
{
    public sealed class SamplePlayer : ISampleProvider
    {
        public delegate Sample Interpolate(ref Sample a, ref Sample b, float f);

        private float index;

        public ISampleConsumer Output { get; set; }
        public float Pitch { get; set; }
        public Sample[] Source { get; set; }
        public Interpolate Interpolation { get; set; }
        public bool Loop { get; set; }

        public SamplePlayer()
        {
            index = 0f;
        }

        public void Process()
        {
            if (index >= Source.Length) return;

            int intIndex = (int)index;
            float fraction = index - intIndex;

            if (intIndex + 1 == Source.Length)
            {
                // Last sample so no interpolation can be done.
                Sample sample = Source[intIndex].Clone();

                Output.Process(ref sample);
            }
            else
            {
                Sample baseSample = Source[intIndex];
                Sample nextSample = Source[intIndex + 1];

                Sample interpolatedSample = Interpolation(ref baseSample, ref nextSample, fraction);

                Output.Process(ref interpolatedSample);
            }

            index += Pitch;

            if (Loop && index >= Source.Length) index = 0f;
        }

        public static Sample Lerp(ref Sample a, ref Sample b, float f)
        {
            Sample result = new Sample();

            result.left = (1.0f - f) * a.left + f * b.left;
            result.right = (1.0f - f) * a.right + f * b.right;

            return result;
        }
    }
}
