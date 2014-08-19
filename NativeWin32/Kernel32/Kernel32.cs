using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.Kernel32
{
    public static class Kernel32
    {
        public const string KERNEL32DLL = "kernel32.dll";

        [DllImport(KERNEL32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        [DllImport(KERNEL32DLL, SetLastError = true)]
        public static extern int FormatMessage([In] FormatMessageFlags dwFlags, [In] IntPtr lpSource, [In] uint dwMessageId, [In] uint dwLanguageId, out IntPtr lpBuffer, [In] uint nSize, [In] IntPtr Arguments);

        [DllImport(KERNEL32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();

        [DllImport(KERNEL32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary([In] IntPtr hModule);

        // Wrapper around the marshal version as opposed to a native import.
        public static uint GetLastError()
        {
            // Cast to an unsigned int as the native GetLastError returns a DWORD (which is unsigned).
            return (uint)Marshal.GetLastWin32Error();
        }

        /// <summary>
        /// Returns the last error code in a formatted message.
        /// </summary>
        public static string GetLastErrorMsg()
        {
            try
            {
                IntPtr lpMsgBuf = IntPtr.Zero;
                uint errorCode = GetLastError();
                FormatMessageFlags dwFlags = FormatMessageFlags.AllocateBuffer | FormatMessageFlags.FromSystem | FormatMessageFlags.IgnoreInserts;

                if (FormatMessage(dwFlags, IntPtr.Zero, errorCode, 0, out lpMsgBuf, 0, IntPtr.Zero) == 0)
                {
                    return string.Format("Failed to get error message from system ({0})", GetLastError());
                }

                string result = Marshal.PtrToStringAnsi(lpMsgBuf);

                lpMsgBuf = LocalFree(lpMsgBuf);

                return result;
            }
            catch (Exception e)
            {
                return string.Format("Failed to get error message from system, ex ({0})", e.Message);
            }
        }

        [DllImport(KERNEL32DLL, SetLastError = true)]
        public static extern IntPtr GetProcAddress([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        [DllImport(KERNEL32DLL, SetLastError = true)]
        public static extern IntPtr LoadLibrary([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        [DllImport(KERNEL32DLL, SetLastError = true)]
        public static extern IntPtr LocalFree([In] IntPtr hMem);
    }
}
