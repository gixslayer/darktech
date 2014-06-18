using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkAL
{
    public static class ALC
    {
        public const int FALSE = 0x0;
        public const int TRUE = 0x1;
        public const int FREQUENCY = 0x1007;
        public const int REFRESH = 0x1008;
        public const int SYNC = 0x1009;
        public const int MONO_SOURCES = 0x1010;
        public const int STEREO_SOURCES = 0x1011;
        public const int NO_ERROR = FALSE;
        public const int INVALID_DEVICE = 0xA001;
        public const int INVALID_CONTEXT = 0xA002;
        public const int INVALID_ENUM = 0xA003;
        public const int INVALID_VALUE = 0xA004;
        public const int OUT_OF_MEMORY = 0xA005;
        public const int DEFAULT_DEVICE_SPECIFIER = 0x1004;
        public const int DEVICE_SPECIFIER = 0x1005;
        public const int EXTENSIONS = 0x1006;
        public const int MAJOR_VERSION = 0x1000;
        public const int MINOR_VERSION = 0x1001;
        public const int ATTRIBUTES_SIZE = 0x1002;
        public const int ALL_ATTRIBUTES = 0x1003;
        public const int DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
        public const int ALL_DEVICES_SPECIFIER = 0x1013;
        public const int CAPTURE_DEVICE_SPECIFIER = 0x310;
        public const int CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311;
        public const int CAPTURE_SAMPLES = 0x312;
    }
}
