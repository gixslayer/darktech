using System.Runtime.InteropServices;

namespace DarkTech.Engine.Sound
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
    public struct Sample
    {
        public float left;
        public float right;

        public Sample(float left, float right)
        {
            this.left = left;
            this.right = right;
        }

        public Sample Clone()
        {
            return new Sample(left, right);
        }

        public static unsafe implicit operator float*(Sample sample) 
        {
            return &sample.left;
        }
    }
}
