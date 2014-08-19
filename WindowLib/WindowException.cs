using System;

using DarkTech.NativeWin32.Kernel32;

namespace DarkTech.WindowLib
{
    public sealed class WindowException : Exception
    {
        public WindowException(string message)
            : base(string.Format("{0}: {1} ({2})", message, Kernel32.GetLastErrorMsg(), Kernel32.GetLastError()))
        {

        }
    }
}
