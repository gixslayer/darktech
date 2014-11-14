﻿using System;

using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine
{
    internal static class Platform
    {
        public static bool IsSupported()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return true;
                default:
                    return false;
            }
        }

        public static IFileSystem CreateFileSystem()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return new FileSystemWin();
                default:
                    throw new PlatformNotSupportedException("Could not create IFileSystem implementation for current platform");
            }
        }

        public static ITimer CreateTimer()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return new TimerWin();
                default:
                    throw new PlatformNotSupportedException("Could not create ITimer implementation for current platform");
            }
        }
    }
}
