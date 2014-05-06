using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DarkTech.DarkAL
{
    /// <summary>
    /// Provides several utility methods to interact with the DarkAL library.
    /// </summary>
    public static class ALUtils
    {
        private static readonly string[] EMPTY_ARRAY = new string[0];
        private const char CHAR_NULL = '\0';

        /// <summary>
        /// Returns an array of capture device names detected.
        /// </summary>
        /// <returns>Returns an array of capture device names detected.</returns>
        public static string[] GetCaptureDevices()
        {
            return IntPtrToStrings(alc.GetString(IntPtr.Zero, ALC.CAPTURE_DEVICE_SPECIFIER));
        }

        /// <summary>
        /// Returns an array of playback device names detected.
        /// </summary>
        /// <returns>Returns an array of playback device names detected.</returns>
        public static string[] GetPlaybackDevices()
        {
            if (alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATE_ALL_EXT"))
                return IntPtrToStrings(alc.GetString(IntPtr.Zero, ALC.ALL_DEVICES_SPECIFIER));
            else if (alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
                return IntPtrToStrings(alc.GetString(IntPtr.Zero, ALC.DEVICE_SPECIFIER));
            else
                return EMPTY_ARRAY;
        }

        /// <summary>
        /// Converts a native memory location to a managed array of strings.
        /// </summary>
        /// <param name="location">The native memory location.</param>
        /// <returns>Returns a managed array of strings from the unmanaged data read at <paramref name="location"/>.</returns>
        public static string[] IntPtrToStrings(IntPtr location)
        {
            List<string> result = new List<string>();
            int offset = 0;
            bool prevNull = false;

            while (true)
            {
                byte character = Marshal.ReadByte(location, offset);

                if (character == CHAR_NULL)
                {
                    if (prevNull)
                        break;

                    prevNull = true;

                    result.Add(Marshal.PtrToStringAnsi(location, offset));
                    location += offset + 1;
                    offset = 0;
                }
                else
                {
                    prevNull = false;
                    offset++;
                }
            }

            return result.ToArray();
        }
    }
}
