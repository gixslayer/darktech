using System;

using DarkTech.Engine.Resources;

namespace DarkTech.Engine
{
    internal static class Platform
    {
        public static FileSystem CreateFileSystem()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    return new FileSystemWindows();
                default:
                    throw new PlatformNotSupportedException("Could not create FileSystem implementation for current platform");
            }
        }
    }
}
