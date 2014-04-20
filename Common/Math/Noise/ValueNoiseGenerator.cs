using System;

namespace DarkTech.Common.Math.Noise
{
    public class ValueNoiseGenerator : NoiseGenerator
    {
        private readonly Random random;
        private float[] cache;

        public ValueNoiseGenerator(int seed, int samples) : base(seed) 
        {
            this.random = new Random(seed);
            this.cache = new float[samples];

            for (int i = 0; i < cache.Length; i++)
            {
                cache[i] = (float)random.NextDouble();
            }
        }

        public override float Generate(int x)
        {
            while (x >= cache.Length)
            {
                int newLength = cache.Length * 2;
                float[] newCache = new float[newLength];

                Buffer.BlockCopy(cache, 0, newCache, 0, cache.Length);

                for (int i = cache.Length; i < newLength; i++)
                {
                    newCache[i] = (float)random.NextDouble();
                }

                cache = newCache;
            }

            return cache[x];
        }
    }
}
