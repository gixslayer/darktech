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

        public Vector2f XY { get { return new Vector2f(x, y); } }
        public Vector2f YZ { get { return new Vector2f(y, z); } }

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3f(Vector2f vec, float z)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = z;
        }

        public Vector3f(Vector3f vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
        }

        public Vector3f(Vector4f vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
        }

        public float Length()
        {
            return MathHelper.Sqrt(x * x + y * y + z * z);
        }

        public float LengthSquared()
        {
            return x * x + y * y + z * z;
        }

        public float Dot(ref Vector3f vec)
        {
            return x * vec.x + y * vec.y + z * vec.z;
        }

        public Vector3f Normalize()
        {
            Vector3f result = new Vector3f();

            Normalize(ref this, ref result);

            return result;
        }

        public Vector3f Abs()
        {
            Vector3f result = new Vector3f();

            result.x = MathHelper.Abs(x);
            result.y = MathHelper.Abs(y);
            result.z = MathHelper.Abs(z);

            return result;
        }

        public Vector3f Clamp(ref Vector3f min, ref Vector3f max)
        {
            Vector3f result = new Vector3f();

            Clamp(ref this, ref min, ref max, ref result);

            return result;
        }

        public Vector3f Clone()
        {
            return new Vector3f(this);
        }

        public Vector3f Cross(ref Vector3f vec)
        {
            Vector3f result = new Vector3f();

            Cross(ref this, ref vec, ref result);

            return result;
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

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", x, y, z);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector3f)
            {
                return this == (Vector3f)obj;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
        }

        #region Operators
        public static unsafe implicit operator float*(Vector3f vec)
        {
            return &vec.x;
        }

        public static implicit operator Vector2f(Vector3f vec)
        {
            return new Vector2f(vec);
        }

        public static Vector3f operator +(Vector3f a, Vector3f b)
        {
            Add(ref a, ref b, ref a);

            return a;
        }

        public static Vector3f operator -(Vector3f a, Vector3f b)
        {
            Sub(ref a, ref b, ref a);

            return a;
        }

        public static Vector3f operator -(Vector3f vec)
        {
            return new Vector3f(-vec.x, -vec.y, -vec.z);
        }

        public static Vector3f operator *(Vector3f a, Vector3f b)
        {
            Mul(ref a, ref b, ref a);

            return a;
        }

        public static Vector3f operator *(Vector3f vec, float scalar)
        {
            Mul(ref vec, scalar, ref vec);

            return vec;
        }

        public static Vector3f operator /(Vector3f a, Vector3f b)
        {
            Div(ref a, ref b, ref a);

            return a;
        }

        public static Vector3f operator /(Vector3f vec, float scalar)
        {
            Div(ref vec, scalar, ref vec);

            return vec;
        }

        public static bool operator ==(Vector3f a, Vector3f b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }

        public static bool operator !=(Vector3f a, Vector3f b)
        {
            return !(a == b);
        }
        #endregion

        #region Static Math
        public static void Add(ref Vector3f a, ref Vector3f b, ref Vector3f res)
        {
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
        }

        public static void Sub(ref Vector3f a, ref Vector3f b, ref Vector3f res)
        {
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
        }

        public static void Mul(ref Vector3f a, ref Vector3f b, ref Vector3f res)
        {
            res.x = a.x * b.x;
            res.y = a.y * b.y;
            res.z = a.z * b.z;
        }

        public static void Mul(ref Vector3f vec, float scalar, ref Vector3f res)
        {
            res.x = vec.x * scalar;
            res.y = vec.y * scalar;
            res.z = vec.z * scalar;
        }

        public static void Div(ref Vector3f a, ref Vector3f b, ref Vector3f res)
        {
            if (b.x == 0)
                throw new ArgumentException("X component cannot be zero", "b");
            if (b.y == 0)
                throw new ArgumentException("Y component cannot be zero", "b");
            if (b.z == 0)
                throw new ArgumentException("Z component cannot be zero", "b");

            res.x = a.x / b.x;
            res.y = a.y / b.y;
            res.z = a.z / b.z;
        }

        public static void Div(ref Vector3f vec, float scalar, ref Vector3f res)
        {
            if (scalar == 0)
                throw new ArgumentException("Scalar cannot be zero", "scalar");

            res.x = vec.x / scalar;
            res.y = vec.y / scalar;
            res.z = vec.z / scalar;
        }

        public static void Normalize(ref Vector3f vec, ref Vector3f result)
        {
            float length = vec.Length();

            // TODO: Properly handle zero length vectors.
            result = length == 0 ? vec : vec / length;
        }

        public static void Clamp(ref Vector3f vec, ref Vector3f min, ref Vector3f max, ref Vector3f result)
        {
            // Component based clamp.
            result.x = MathHelper.Clamp(vec.x, min.x, max.x);
            result.y = MathHelper.Clamp(vec.y, min.y, max.y);
            result.z = MathHelper.Clamp(vec.z, min.z, max.z);
        }

        public static void Cross(ref Vector3f a, ref Vector3f b, ref Vector3f result)
        {
            result.x = a.y * b.z - a.z * b.y;
            result.y = a.z * b.x - a.x * b.z;
            result.z = a.x * b.y - a.y * b.x;
        }
        #endregion
    }
}
