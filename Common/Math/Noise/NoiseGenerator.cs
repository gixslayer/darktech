namespace DarkTech.Common.Math.Noise
{
    public abstract class NoiseGenerator
    {
        protected int seed;

        public NoiseGenerator(int seed)
        {
            this.seed = seed;
        }

        public abstract float Generate(int x);
    }
}
