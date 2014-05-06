namespace DarkTech.DarkGL
{
    public static class PFD
    {
        /* pixel types */
        public static byte TYPE_RGBA = 0;
        public static byte TYPE_COLORINDEX = 1;

        /* layer types */
        public static int MAIN_PLANE = 0;
        public static int OVERLAY_PLANE = 1;
        public static int UNDERLAY_PLANE = (-1);

        /* PIXELFORMATDESCRIPTOR flags */
        public static uint DOUBLEBUFFER = 0x00000001;
        public static uint STEREO = 0x00000002;
        public static uint DRAW_TO_WINDOW = 0x00000004;
        public static uint DRAW_TO_BITMAP = 0x00000008;
        public static uint SUPPORT_GDI = 0x00000010;
        public static uint SUPPORT_OPENGL = 0x00000020;
        public static uint GENERIC_FORMAT = 0x00000040;
        public static uint NEED_PALETTE = 0x00000080;
        public static uint NEED_SYSTEM_PALETTE = 0x00000100;
        public static uint SWAP_EXCHANGE = 0x00000200;
        public static uint SWAP_COPY = 0x00000400;
        public static uint SWAP_LAYER_BUFFERS = 0x00000800;
        public static uint GENERIC_ACCELERATED = 0x00001000;
        public static uint SUPPORT_DIRECTDRAW = 0x00002000;

        /* PIXELFORMATDESCRIPTOR flags for use in ChoosePixelFormat only */
        public static uint DEPTH_DONTCARE = 0x20000000;
        public static uint DOUBLEBUFFER_DONTCARE = 0x40000000;
        public static uint STEREO_DONTCARE = 0x80000000;
    }
}
