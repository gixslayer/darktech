using System;
using System.Runtime.InteropServices;

namespace DarkTech.Engine.Math
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
    public unsafe struct Vector3f : IComparable<Vector3f>
    {
        public static readonly Vector3f ZERO = new Vector3f(0f, 0f, 0f);
        public static readonly Vector3f ONE = new Vector3f(1f, 1f, 1f);
        public static readonly Vector3f MINUS_ONE = new Vector3f(-1f, -1f, -1f);
        public static readonly Vector3f MIN = new Vector3f(float.MinValue, float.MinValue, float.MinValue);
        public static readonly Vector3f MAX = new Vector3f(float.MaxValue, float.MaxValue, float.MaxValue);

        public float x;
        public float y;
        public float z;

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int CompareTo(Vector3f other)
        {
            if (this.x < other.x) return -1;
            if (this.x > other.x) return 1;
            if (this.y < other.y) return -1;
            if (this.y > other.y) return 1;
            if (this.z < other.z) return -1;
            if (this.z > other.z) return 1;

            return 0;
        }
    }
}
