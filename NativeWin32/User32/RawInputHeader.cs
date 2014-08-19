using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        public RawInputType dwType;
        public uint dwSize;
        public IntPtr hDevice;
        public IntPtr wParam;
    }
}
