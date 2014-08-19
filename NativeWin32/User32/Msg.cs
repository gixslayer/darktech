using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Msg
    {
        public IntPtr hWnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public Point pt;
    }

}
