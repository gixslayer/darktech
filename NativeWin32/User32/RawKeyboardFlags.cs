using System;

namespace DarkTech.NativeWin32.User32
{
    [Flags]
    public enum RawKeyboardFlags : ushort
    {
        Make = 0,
        Break = 1,
        E0 = 2,
        E1 = 4
    }
}
