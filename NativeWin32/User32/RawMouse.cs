using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RawMouse
    {
        [FieldOffset(0)]
        public RawMouseFlags usFlags;

        [FieldOffset(4)]
        public uint ulButtons;

        [FieldOffset(4)]
        public RawMouseButtonFlags usButtonFlags;
        [FieldOffset(6)]
        public ushort usButtonData;

        [FieldOffset(8)]
        public uint ulRawButtons;
        [FieldOffset(12)]
        public int lLastX;
        [FieldOffset(16)]
        public int lLastY;
        [FieldOffset(20)]
        public uint ulExtraInformation;
    }
}
