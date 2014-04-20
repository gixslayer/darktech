namespace DarkTech.Common.Math.Noise
{
    public class FractalNoise
    {
        private readonly InterpolatedNoise interp;
        private readonly float p; // persistence
        private readonly int o; // octaves
        private readonly int samples;

        public FractalNoise(InterpolatedNoise interp, float p, int o, int samples)
        {
            this.interp = interp;
            this.p = p;
            this.o = o;
            this.samples = samples;
        }

        public float Generate(float x)
        {
            float r = 0f;

            for (int i = 0; i < o; i++)
            {
                float f = MathHelper.Pow(2, i);
                float a = MathHelper.Pow(p, i);

                r += interp.Generate(x * f % samples) * a;
            }

            return r;
        }
    }
}
