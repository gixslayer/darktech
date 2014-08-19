using System;
using System.Runtime.InteropServices;

using DarkTech.Common.Containers;
using DarkTech.NativeWin32.User32;

namespace DarkTech.DisplayLib
{
    public static class Display
    {
        public static int GetWidth()
        {
            return User32.GetSystemMetrics(SystemMetric.CXScreen);
        }

        public static int GetHeight()
        {
            return User32.GetSystemMetrics(SystemMetric.CYScreen);
        }

        public static void SetDisplayMode(DisplayMode displayMode)
        {
            DevMode devMode = new DevMode();
            devMode.dmSize = (short)Marshal.SizeOf(devMode);
            devMode.dmBitsPerPel = displayMode.BitsPerPixels;
            devMode.dmPelsWidth = displayMode.Width;
            devMode.dmPelsHeight = displayMode.Height;
            devMode.dmDisplayFrequency = displayMode.Frequency;
            devMode.dmFields = DM.BitsPerPixel | DM.DisplayFrequency | DM.PelsHeight | DM.PelsWidth;

            DisplayChange result = User32.ChangeDisplaySettings(ref devMode, ChangeDisplaySettingsFlags.FullScreen);
        }

        public static void SetDisplayMode(string deviceName, DisplayMode displayMode)
        {
            DevMode devMode = new DevMode();
            devMode.dmSize = (short)Marshal.SizeOf(devMode);
            devMode.dmBitsPerPel = displayMode.BitsPerPixels;
            devMode.dmPelsWidth = displayMode.Width;
            devMode.dmPelsHeight = displayMode.Height;
            devMode.dmDisplayFrequency = displayMode.Frequency;
            devMode.dmFields = DM.BitsPerPixel | DM.DisplayFrequency | DM.PelsHeight | DM.PelsWidth;

            DisplayChange result = User32.ChangeDisplaySettingsEx(deviceName, ref devMode, IntPtr.Zero, ChangeDisplaySettingsFlags.FullScreen, IntPtr.Zero);
        }

        public static void ResetDisplayMode()
        {
            DisplayChange result = User32.ChangeDisplaySettings(IntPtr.Zero, ChangeDisplaySettingsFlags.None);
        }

        public static void ResetDisplayMode(string deviceName)
        {
            DisplayChange result = User32.ChangeDisplaySettingsEx(deviceName, IntPtr.Zero, IntPtr.Zero, ChangeDisplaySettingsFlags.None, IntPtr.Zero);
        }

        public static IList<string> GetDisplayDevices()
        {
            IList<string> result = new ArrayList<string>(2);

            DisplayDevice displayDevice = new DisplayDevice();
            displayDevice.cb = Marshal.SizeOf(displayDevice);

            for (uint id = 0; User32.EnumDisplayDevices(null, id, ref displayDevice, 0); id++)
            {
                result.Add(displayDevice.deviceName);
            }

            return result;
        }

        public static IList<DisplayMode> GetDisplayModes(string deviceName = null)
        {
            IList<DisplayMode> result = new ArrayList<DisplayMode>();

            int i = 0;
            DevMode devMode = new DevMode();
            devMode.dmSize = (short)Marshal.SizeOf(devMode);

            while (User32.EnumDisplaySettings(deviceName, i++, ref devMode))
            {
                DisplayMode displayMode = new DisplayMode();

                displayMode.BitsPerPixels = devMode.dmBitsPerPel;
                displayMode.Frequency = devMode.dmDisplayFrequency;
                displayMode.Height = devMode.dmPelsHeight;
                displayMode.Width = devMode.dmPelsWidth;

                result.Add(displayMode);
            }

            return result;
        }

        public static DisplayMode GetCurrentDisplayMode(string deviceName = null)
        {
            DisplayMode displayMode = new DisplayMode();
            DevMode devMode = new DevMode();
            devMode.dmSize = (short)Marshal.SizeOf(devMode);

            User32.EnumDisplaySettings(deviceName, User32.ENUM_CURRENT_SETTINGS, ref devMode);

            displayMode.BitsPerPixels = devMode.dmBitsPerPel;
            displayMode.Frequency = devMode.dmDisplayFrequency;
            displayMode.Height = devMode.dmPelsHeight;
            displayMode.Width = devMode.dmPelsWidth;

            return displayMode;
        }
    }
}
