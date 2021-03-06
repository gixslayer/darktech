﻿using System;
using System.Diagnostics;

namespace DarkTech.Engine.Debug
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void Fail(string message = "")
        {
            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void True(bool condition, string message = "")
        {
            if (condition) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: {0}", true);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", condition);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void False(bool condition, string message = "")
        {
            if (!condition) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: {0}", false);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", condition);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void Null(object obj, string message = "")
        {
            if (obj == null) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "obj != null");

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void NotNull(object obj, string message = "")
        {
            if (obj != null) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "obj == null");

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void ReferenceEqual(object expected, object actual, string message = "")
        {
            if (object.ReferenceEquals(expected, actual)) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "expected != actual");

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void ReferenceNotEqual(object expected, object actual, string message = "")
        {
            if (!object.ReferenceEquals(expected, actual)) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "expected == actual");

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void Equal<T>(T expected, T actual, string message = "") where T : IComparable<T>
        {
            if (expected != null && actual != null)
            {
                if (expected.CompareTo(actual) == 0) return;
            }

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void Less<T>(T expected, T actual, string message = "") where T : IComparable<T>
        {
            // Assert actual < expected
            if (expected != null && actual != null)
            {
                if (expected.CompareTo(actual) > 0) return;
            }

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: < {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void LessEqual<T>(T expected, T actual, string message = "") where T : IComparable<T>
        {
            // Assert actual <= expected
            if (expected != null && actual != null)
            {
                if (expected.CompareTo(actual) >= 0) return;
            }

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: <= {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void Greater<T>(T expected, T actual, string message = "") where T : IComparable<T>
        {
            // Assert actual > expected
            if (expected != null && actual != null)
            {
                if (expected.CompareTo(actual) < 0) return;
            }

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: > {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void GreaterEqual<T>(T expected, T actual, string message = "") where T : IComparable<T>
        {
            // Assert actual >= expected
            if (expected != null && actual != null)
            {
                if (expected.CompareTo(actual) <= 0) return;
            }

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: >= {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void FloatEqual(float expected, float actual, float margin, string message = "")
        {
            if (DarkTech.Common.Math.MathHelper.Abs(expected - actual) <= margin) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);
            Engine.Log.WriteLine("debug/assert", "Margin: {0}", margin);

            FailInternal();
        }

        [Conditional("DEBUG")]
        public static void DoubleEqual(double expected, double actual, double margin, string message = "")
        {
            if (DarkTech.Common.Math.MathHelper.Abs(expected - actual) <= margin) return;

            Engine.Log.WriteLine("debug/assert", "Assert failed: {0}", message);
            Engine.Log.WriteLine("debug/assert", "Expected: {0}", expected);
            Engine.Log.WriteLine("debug/assert", "Actual: {0}", actual);
            Engine.Log.WriteLine("debug/assert", "Margin: {0}", margin);

            FailInternal();
        }

        private static void FailInternal()
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
        }
    }
}
