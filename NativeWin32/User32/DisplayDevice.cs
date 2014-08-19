using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DisplayDevice
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string deviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string deviceString;
        [MarshalAs(UnmanagedType.U4)]
        public DisplayDeviceStateFlags stateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string deviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string deviceKey;
    }
}
