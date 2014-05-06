using System.Runtime.InteropServices;

namespace DarkTech.DarkGL
{
    [StructLayout(LayoutKind.Sequential)]
    public class PixelFormatDescriptor
    {
        public short Size = 40;
        public short Version = 1;
        public PFDFlags Flags = PFDFlags.DOUBLEBUFFER | PFDFlags.DRAW_TO_WINDOW | PFDFlags.SUPPORT_OPENGL;
        public PFDPixelType PixelType;
        public byte ColorBits = 32;
        public byte RedBits;
        public byte RedShift;
        public byte GreenBits;
        public byte GreenShift;
        public byte BlueBits;
        public byte BlueShift;
        public byte AlphaBits = 8;
        public byte AlphaShift;
        public byte AccumBits;
        public byte AccumRedBits;
        public byte AccumGreenBits;
        public byte AccumBlueBits;
        public byte AccumAlphaBits;
        public byte DepthBits = 24;
        public byte StencilBits = 8;
        public byte AuxBuffers;
        public PFDLayerType LayerType;
        public byte Reserved;
        public int dwLayerMask;
        public int dwVisibleMask;
        public int dwDamageMask;
    }
}
