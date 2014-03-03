using System;
using System.Runtime.InteropServices;

namespace DarkTech.Engine.Math
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
    public unsafe struct Vector4f : IComparable<Vector4f>
    {
        public static readonly Vector4f ZERO = new Vector4f(0f, 0f, 0f, 0f);
        public static readonly Vector4f ONE = new Vector4f(1f, 1f, 1f, 1f);
        public static readonly Vector4f MINUS_ONE = new Vector4f(-1f, -1f, -1f, -1f);
        public static readonly Vector4f MIN = new Vector4f(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        public static readonly Vector4f MAX = new Vector4f(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);

        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4f(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public int CompareTo(Vector4f other)
        {
            if (this.x < other.x) return -1;
            if (this.x > other.x) return 1;
            if (this.y < other.y) return -1;
            if (this.y > other.y) return 1;
            if (this.z < other.z) return -1;
            if (this.z > other.z) return 1;
            if (this.w < other.w) return -1;
            if (this.w > other.w) return 1;

            return 0;
        }
    }
}
