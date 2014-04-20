using System;
using System.Runtime.InteropServices;

namespace DarkTech.Common.Math
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

        public Vector2f(Vector2f vec)
        {
            this.x = vec.x;
            this.y = vec.y;
        }

        public Vector2f(Vector3f vec)
        {
            this.x = vec.x;
            this.y = vec.y;
        }

        public Vector2f(Vector4f vec) 
        {
            this.x = vec.x;
            this.y = vec.y;
        }

        public float Length()
        {
            return MathHelper.Sqrt(x * x + y * y);
        }

        public float LengthSquared()
        {
            return x * x + y * y;
        }

        public float Dot(ref Vector2f vec)
        {
            return x * vec.x + y * vec.y;
        }

        public Vector2f Normalize()
        {
            Vector2f result = new Vector2f();

            Normalize(ref this, ref result);

            return result;
        }

        public Vector2f Abs()
        {
            Vector2f result = new Vector2f();

            result.x = MathHelper.Abs(x);
            result.y = MathHelper.Abs(y);

            return result;
        }

        public Vector2f Clamp(ref Vector2f min, ref Vector2f max)
        {
            Vector2f result = new Vector2f();

            Clamp(ref this, ref min, ref max, ref result);

            return result;
        }

        public Vector2f Clone()
        {
            return new Vector2f(this);
        }

        public int CompareTo(Vector2f other)
        {
            if (this.x < other.x) return -1;
            if (this.x > other.x) return 1;
            if (this.y < other.y) return -1;
            if (this.y > other.y) return 1;

            return 0;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2f)
            {
                return this == (Vector2f)obj;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        #region Operators
        public static unsafe implicit operator float*(Vector2f vec)
        {
            return &vec.x;
        }

        public static Vector2f operator +(Vector2f a, Vector2f b)
        {
            Add(ref a, ref b, ref a);

            return a;
        }

        public static Vector2f operator -(Vector2f a, Vector2f b)
        {
            Sub(ref a, ref b, ref a);

            return a;
        }

        public static Vector2f operator -(Vector2f vec)
        {
            return new Vector2f(-vec.x, -vec.y);
        }

        public static Vector2f operator *(Vector2f a, Vector2f b)
        {
            Mul(ref a, ref b, ref a);

            return a;
        }

        public static Vector2f operator *(Vector2f vec, float scalar)
        {
            Mul(ref vec, scalar, ref vec);

            return vec;
        }

        public static Vector2f operator /(Vector2f a, Vector2f b)
        {
            Div(ref a, ref b, ref a);

            return a;
        }

        public static Vector2f operator /(Vector2f vec, float scalar)
        {
            Div(ref vec, scalar, ref vec);

            return vec;
        }

        public static bool operator ==(Vector2f a, Vector2f b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vector2f a, Vector2f b)
        {
            return !(a == b);
        }
        #endregion

        #region Static Math
        public static void Add(ref Vector2f a, ref Vector2f b, ref Vector2f res)
        {
            res.x = a.x + b.x;
            res.y = a.y + b.y;
        }

        public static void Sub(ref Vector2f a, ref Vector2f b, ref Vector2f res)
        {
            res.x = a.x - b.x;
            res.y = a.y - b.y;
        }

        public static void Mul(ref Vector2f a, ref Vector2f b, ref Vector2f res)
        {
            res.x = a.x * b.x;
            res.y = a.y * b.y;
        }

        public static void Mul(ref Vector2f vec, float scalar, ref Vector2f res)
        {
            res.x = vec.x * scalar;
            res.y = vec.y * scalar;
        }

        public static void Div(ref Vector2f a, ref Vector2f b, ref Vector2f res)
        {
            if (b.x == 0)
                throw new ArgumentException("X component cannot be zero", "b");
            if (b.y == 0)
                throw new ArgumentException("Y component cannot be zero", "b");

            res.x = a.x / b.x;
            res.y = a.y / b.y;
        }

        public static void Div(ref Vector2f vec, float scalar, ref Vector2f res)
        {
            if (scalar == 0)
                throw new ArgumentException("Scalar cannot be zero", "scalar");

            res.x = vec.x / scalar;
            res.y = vec.y / scalar;
        }

        public static void Normalize(ref Vector2f vec, ref Vector2f result)
        {
            float length = vec.Length();

            // TODO: Properly handle zero length vectors.
            result = length == 0 ? vec : vec / length;
        }

        public static void Clamp(ref Vector2f vec, ref Vector2f min, ref Vector2f max, ref Vector2f result)
        {
            // Component based clamp.
            result.x = MathHelper.Clamp(vec.x, min.x, max.x);
            result.y = MathHelper.Clamp(vec.y, min.y, max.y);
        }
        #endregion
    }
}
