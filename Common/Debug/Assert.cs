using System;
using System.Diagnostics;

namespace DarkTech.Common.Debug
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void IsNull(object obj, string message)
        {
            if (obj != null)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }
        
        [Conditional("DEBUG")]
        public static void IsNotNull(object obj, string message)
        {
            if (obj == null)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void True(bool condition, string message)
        {
            if (!condition)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void False(bool condition, string message)
        {
            if (condition)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void ReferenceEquals(object a, object b, string message)
        {
            if (!object.ReferenceEquals(a, b))
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void Equals<T>(T a, T b, string message) where T : IComparable
        {
            if (a.CompareTo(b) != 0)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void Greater<T>(T a, T b, string message) where T : IComparable
        {
            if (a.CompareTo(b) <= 0)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void GreaterOrEqual<T>(T a, T b, string message) where T : IComparable
        {
            if (a.CompareTo(b) < 0)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void Less<T>(T a, T b, string message) where T : IComparable
        {
            if (a.CompareTo(b) >= 0)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }
        
        [Conditional("DEBUG")]
        public static void LessOrEqual<T>(T a, T b, string message) where T : IComparable
        {
            if (a.CompareTo(b) > 0)
            {
                Trace.TraceError(message);

                Debugger.Break();
            }
        }

        [Conditional("DEBUG")]
        public static void Fail(string message)
        {
            Trace.TraceError(message);

            Debugger.Break();
        }
    }
}
