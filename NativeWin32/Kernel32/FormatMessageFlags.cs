using System;

namespace DarkTech.NativeWin32.Kernel32
{
    [Flags]
    public enum FormatMessageFlags : uint
    {
        AllocateBuffer = 0x00000100,
        IgnoreInserts = 0x00000200,
        FromSystem = 0x00001000,
        ArgumentArray = 0x00002000,
        FromHModule = 0x00000800,
        FromString = 0x00000400,
    }
}
