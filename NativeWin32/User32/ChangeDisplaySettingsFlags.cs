using System;

namespace DarkTech.NativeWin32.User32
{
    [Flags]
    public enum ChangeDisplaySettingsFlags : uint
    {
        None = 0,
        UpdateRegistry = 0x00000001,
        Test = 0x00000002,
        FullScreen = 0x00000004,
        Global = 0x00000008,
        SetPrimary = 0x00000010,
        VideoParameters = 0x00000020,
        EnableUnsafeModes = 0x00000100,
        DisableUnsafeModes = 0x00000200,
        Reset = 0x40000000,
        ResetEx = 0x20000000,
        NoReset = 0x10000000
    }
}
