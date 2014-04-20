using System;
using System.Runtime.InteropServices;

namespace DarkTech.Common.Math
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

        public Vector2f XY { get { return new Vector2f(x, y); } }
        public Vector2f YZ { get { return new Vector2f(y, z); } }
        public Vector2f ZW { get { return new Vector2f(z, w); } }
        public Vector3f XYZ { get { return new Vector3f(x, y, z); } }
        public Vector3f YZW { get { return new Vector3f(y, z, w); } }
        
        public Vector4f(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector4f(Vector2f vec, float z, float w)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = z;
            this.w = w;
        }

        public Vector4f(Vector2f xy, Vector2f zw)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        public Vector4f(Vector3f vec, float w)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
            this.w = w;
        }

        public Vector4f(Vector4f vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
            this.w = vec.w;
        }

        public float Length()
        {
            return MathHelper.Sqrt(x * x + y * y + z * z + w * w);
        }

        public float LengthSquared()
        {
            return x * x + y * y + z * z + w * w;
        }

        public float Dot(ref Vector4f vec)
        {
            return x * vec.x + y * vec.y + z * vec.z + w * vec.w;
        }

        public Vector4f Normalize()
        {
            Vector4f result = new Vector4f();

            Normalize(ref this, ref result);

            return result;
        }

        public Vector4f Abs()
        {
            Vector4f result = new Vector4f();

            result.x = MathHelper.Abs(x);
            result.y = MathHelper.Abs(y);
            result.z = MathHelper.Abs(z);
            result.w = MathHelper.Abs(w);

            return result;
        }

        public Vector4f Clamp(ref Vector4f min, ref Vector4f max)
        {
            Vector4f result = new Vector4f();

            Clamp(ref this, ref min, ref max, ref result);

            return result;
        }

        public Vector4f Clone()
        {
            return new Vector4f(this);
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
        
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", x, y, z, w);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector4f)
            {
                return this == (Vector4f)obj;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
        }

        #region Operators
        public static unsafe implicit operator float*(Vector4f vec)
        {
            return &vec.x;
        }

        public static implicit operator Vector2f(Vector4f vec)
        {
            return new Vector2f(vec);
        }

        public static implicit operator Vector3f(Vector4f vec)
        {
            return new Vector3f(vec);
        }

        public static Vector4f operator +(Vector4f a, Vector4f b)
        {
            Add(ref a, ref b, ref a);

            return a;
        }

        public static Vector4f operator -(Vector4f a, Vector4f b)
        {
            Sub(ref a, ref b, ref a);

            return a;
        }

        public static Vector4f operator -(Vector4f vec)
        {
            return new Vector4f(-vec.x, -vec.y, -vec.z, -vec.w);
        }

        public static Vector4f operator *(Vector4f a, Vector4f b)
        {
            Mul(ref a, ref b, ref a);

            return a;
        }

        public static Vector4f operator *(Vector4f vec, float scalar)
        {
            Mul(ref vec, scalar, ref vec);

            return vec;
        }

        public static Vector4f operator /(Vector4f a, Vector4f b)
        {
            Div(ref a, ref b, ref a);

            return a;
        }

        public static Vector4f operator /(Vector4f vec, float scalar)
        {
            Div(ref vec, scalar, ref vec);

            return vec;
        }

        public static bool operator ==(Vector4f a, Vector4f b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
        }

        public static bool operator !=(Vector4f a, Vector4f b)
        {
            return !(a == b);
        }
        #endregion

        #region Static Math
        public static void Add(ref Vector4f a, ref Vector4f b, ref Vector4f res)
        {
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            res.w = a.w + b.w;
        }

        public static void Sub(ref Vector4f a, ref Vector4f b, ref Vector4f res)
        {
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
            res.w = a.w - b.w;
        }

        public static void Mul(ref Vector4f a, ref Vector4f b, ref Vector4f res)
        {
            res.x = a.x * b.x;
            res.y = a.y * b.y;
            res.z = a.z * b.z;
            res.w = a.w * b.w;
        }

        public static void Mul(ref Vector4f vec, float scalar, ref Vector4f res)
        {
            res.x = vec.x * scalar;
            res.y = vec.y * scalar;
            res.z = vec.z * scalar;
            res.w = vec.w * scalar;
        }

        public static void Div(ref Vector4f a, ref Vector4f b, ref Vector4f res)
        {
            if (b.x == 0)
                throw new ArgumentException("X component cannot be zero", "b");
            if (b.y == 0)
                throw new ArgumentException("Y component cannot be zero", "b");
            if (b.z == 0)
                throw new ArgumentException("Z component cannot be zero", "b");
            if (b.w == 0)
                throw new ArgumentException("W component cannot be zero", "b");

            res.x = a.x / b.x;
            res.y = a.y / b.y;
            res.z = a.z / b.z;
            res.w = a.w / b.w;
        }

        public static void Div(ref Vector4f vec, float scalar, ref Vector4f res)
        {
            if (scalar == 0)
                throw new ArgumentException("Scalar cannot be zero", "scalar");

            res.x = vec.x / scalar;
            res.y = vec.y / scalar;
            res.z = vec.z / scalar;
            res.w = vec.w / scalar;
        }

        public static void Normalize(ref Vector4f vec, ref Vector4f result)
        {
            float length = vec.Length();

            // TODO: Properly handle zero length vectors.
            result = length == 0 ? vec : vec / length;
        }

        public static void Clamp(ref Vector4f vec, ref Vector4f min, ref Vector4f max, ref Vector4f result)
        {
            // Component based clamp.
            result.x = MathHelper.Clamp(vec.x, min.x, max.x);
            result.y = MathHelper.Clamp(vec.y, min.y, max.y);
            result.z = MathHelper.Clamp(vec.z, min.z, max.z);
            result.w = MathHelper.Clamp(vec.w, min.w, max.w);
        }
        #endregion
    }
}
