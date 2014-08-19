using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInput
    {
        public RawInputHeader header;
        public Union data;

        [StructLayout(LayoutKind.Explicit)]
        public struct Union
        {
            [FieldOffset(0)]
            public RawMouse mouse;
            [FieldOffset(0)]
            public RawKeyboard keyboard;
            [FieldOffset(0)]
            public RawHID hid;
        }
    }
}
