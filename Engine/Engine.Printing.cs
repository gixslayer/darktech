using System.IO;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static List<TextWriter> printStreams = new List<TextWriter>();

        public static void AttachPrintStream(TextWriter printStream)
        {
            printStreams.Add(printStream);
        }

        public static void AttachPrintStream(params TextWriter[] args)
        {
            foreach (TextWriter arg in args)
            {
                AttachPrintStream(arg);
            }
        }

        public static void DetachPrintStream(TextWriter printStream)
        {
            printStreams.Remove(printStream);
        }

        public static void DetachPrintStream(params TextWriter[] args)
        {
            foreach (TextWriter arg in args)
            {
                DetachPrintStream(arg);
            }
        }

        public static void Print(string text)
        {
            foreach (TextWriter printStream in printStreams)
            {
                printStream.WriteLine(text);
            }
        }

        public static void Printf(string format, params object[] args)
        {
            Print(string.Format(format, args));
        }

        public static void PrintDebug(string text)
        {
            // TODO: Check if debug mode is enabled.
            Printf(">>DEBUG {0}", text);
        }

        public static void PrintDebugf(string format, params object[] args)
        {
            PrintDebug(string.Format(format, args));
        }

        public static void Warning(string text)
        {
            Printf("!!!WARNING!!! {0}", text);
        }

        public static void Warningf(string format, params object[] args)
        {
            Warning(string.Format(format, args));
        }

        public static void Error(string text)
        {
            Printf("!!!ERROR!!! {0}", text);
        }

        public static void Errorf(string format, params object[] args)
        {
            Error(string.Format(format, args));
        }

        public static void FatalError(string text)
        {
            Printf("!!!FATAL ERROR!!! {0}", text);
            Printf("Stack trace: {0}", System.Environment.StackTrace);

            Shutdown();
        }

        public static void FatalErrorf(string format, params object[] args)
        {
            FatalError(string.Format(format, args));
        }
    }
}
