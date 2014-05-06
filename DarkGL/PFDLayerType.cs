using System;

namespace DarkTech.DarkGL
{
    [Flags]
    public enum PFDLayerType : byte 
    { 
        MAIN_PLANE = 0, 
        OVERLAY_PLANE = 1, 
        UDERLAY_PLANE = 255 
    }
}
