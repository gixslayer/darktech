using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawHID
    {
        public uint dwSizeHid;
        public uint dwCount;
        public IntPtr bRawData;
    }
}
