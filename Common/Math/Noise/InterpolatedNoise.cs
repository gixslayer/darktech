using DarkTech.Common.Math;

namespace DarkTech.Common.Math.Noise
{
    public class InterpolatedNoise
    {
        private readonly float[] source;
        private readonly NoiseGenerator generator;

        public InterpolatedNoise(NoiseGenerator generator)
        {
            this.generator = generator;
        }

        public InterpolatedNoise(float[] source)
        {
            this.source = source;
        }

        public float Generate(float x)
        {
            int xInt = MathHelper.Floor(x);
            float xFrac = MathHelper.Fract(x);

            //return MathHelper.Lerp(generator.Generate(xInt), generator.Generate(xInt + 1), xFrac);
            return MathHelper.Cerp(generator.Generate(xInt), generator.Generate(xInt + 1), xFrac);
            //return MathHelper.Lerp(source[xInt % source.Length], source[(xInt + 1) % source.Length], xFrac);
        }
    }
}
