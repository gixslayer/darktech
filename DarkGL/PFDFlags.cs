﻿using System;

namespace DarkTech.DarkGL
{
    [Flags]
    public enum PFDFlags : uint
    {
        DOUBLEBUFFER = 0x00000001, 
        STEREO = 0x00000002, 
        DRAW_TO_WINDOW = 0x00000004, 
        DRAW_TO_BITMAP = 0x00000008,
        SUPPORT_GDI = 0x00000010, 
        SUPPORT_OPENGL = 0x00000020, 
        GENERIC_FORMAT = 0x00000040,
        NEED_PALETTE = 0x00000080, 
        NEED_SYSTEM_PALETTE = 0x00000100,
        SWAP_EXCHANGE = 0x00000200, 
        SWAP_COPY = 0x00000400, 
        SWAP_LAYER_BUFFERS = 0x00000800,
        GENERIC_ACCELERATED = 0x00001000, 
        SUPPORT_DIRECTDRAW = 0x00002000,
        DEPTH_DONTCARE = 0x20000000, 
        DOUBLEBUFFER_DONTCARE = 0x40000000, 
        STEREO_DONTCARE = 0x80000000
    }
}