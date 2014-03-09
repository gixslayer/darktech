﻿using SMath = System.Math;

namespace DarkTech.Engine.Math
{
    public static class MathHelper
    {
        public static float Sqrt(float value)
        {
            return (float)SMath.Sqrt(value);
        }

        public static float Sin(float rad)
        {
            return (float)SMath.Sin(rad);
        }

        public static float Cos(float rad)
        {
            return (float)SMath.Cos(rad);
        }

        public static float Tan(float rad)
        {
            return (float)SMath.Tan(rad);
        }

        public static float Sinh(float value)
        {
            return (float)SMath.Sinh(value);
        }

        public static float Cosh(float value)
        {
            return (float)SMath.Cosh(value);
        }

        public static float Tanh(float value)
        {
            return (float)SMath.Tanh(value);
        }

        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        public static float Min(float a, float b)
        {
            return a < b ? a : b;
        }

        public static int Min(params int[] args)
        {
            int min = int.MaxValue;

            foreach (int i in args)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        public static float Min(params float[] args)
        {
            float min = float.MaxValue;

            foreach (float f in args)
            {
                if (f < min)
                {
                    min = f;
                }
            }

            return min;
        }

        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static float Max(float a, float b)
        {
            return a > b ? a : b;
        }

        public static int Max(params int[] args)
        {
            int max = int.MinValue;

            foreach (int i in args)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }

        public static float Max(params float[] args)
        {
            float max = float.MinValue;

            foreach (float f in args)
            {
                if (f > max)
                {
                    max = f;
                }
            }

            return max;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;

            return value;
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;

            return value;
        }

        public static int Abs(int value)
        {
            return value < 0 ? -value : value;
        }

        public static float Abs(float value)
        {
            return value < 0f ? -value : value;
        }

        public static float Pow(float val, float pow)
        {
            return (float)SMath.Pow(val, pow);
        }
    }
}
