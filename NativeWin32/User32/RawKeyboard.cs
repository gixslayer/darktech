using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        public ushort MakeCode;
        public RawKeyboardFlags Flags;
        public ushort Reserved;
        public ushort VKey;
        public WindowMessage Message;
        public uint ExtraInformation;
    }
}
