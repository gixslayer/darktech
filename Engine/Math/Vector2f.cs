using System;
using System.Runtime.InteropServices;

namespace DarkTech.Engine.Math
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
    public unsafe struct Vector2f : IComparable<Vector2f>
    {
        public static readonly Vector2f ZERO = new Vector2f(0f, 0f);
        public static readonly Vector2f ONE = new Vector2f(1f, 1f);
        public static readonly Vector2f MINUS_ONE = new Vector2f(-1f, -1f);
        public static readonly Vector2f MIN = new Vector2f(float.MinValue, float.MinValue);
        public static readonly Vector2f MAX = new Vector2f(float.MaxValue, float.MaxValue);

        public float x;
        public float y;

        public Vector2f(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Vector2f other)
        {
            if (this.x < other.x) return -1;
            if (this.x > other.x) return 1;
            if (this.y < other.y) return -1;
            if (this.y > other.y) return 1;

            return 0;
        }
    }
}
