using System;

namespace DarkTech.NativeWin32.User32
{
    [Flags]
    public enum RawMouseFlags : ushort
    {
        Relative = 0,
        Absolute = 1,
        VirtualDesktop = 2,
        AttributesChanged = 4
    }
}
