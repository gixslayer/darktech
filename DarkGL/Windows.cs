using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkGL
{
    // TODO: Move?
    [StructLayout(LayoutKind.Sequential)]
    public struct CharSize
    {
        public long cx;
        public long cy;
    }

    public class Windows
    {
        public const int WM_PAINT = 0x000F;

        [DllImport("User32")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        [DllImport("GDI32")]
        public static extern int ChoosePixelFormat(IntPtr dc, [In] IntPtr pfd);
        public static int ChoosePixelFormat(IntPtr dc, PixelFormatDescriptor pfd)
        {
            int pixelformat = 0;
            GCHandle pfd_ptr = GCHandle.Alloc(pfd, GCHandleType.Pinned);
            try
            {
                pixelformat = Windows.ChoosePixelFormat(dc, pfd_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pfd_ptr.Free();
            }
            return pixelformat;
        }
        
        [DllImport("GDI32")]
        public static extern int DescribePixelFormat(IntPtr dc, int format, uint nBytes, [In]IntPtr pfd);
        public static int DescribePixelFormat(IntPtr dc, int format, PixelFormatDescriptor pfd)
        {
            int pixelformat = 0;
            GCHandle pfd_ptr = GCHandle.Alloc(pfd, GCHandleType.Pinned);

            try
            {
                pixelformat = Windows.DescribePixelFormat(dc, format, (uint)pfd.Size, pfd_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pfd_ptr.Free();
            }

            return pixelformat;
        }
        
        [DllImport("GDI32", EntryPoint = "SetPixelFormat")]
        static extern bool _SetPixelFormat(IntPtr dc, int format, [In, MarshalAs(UnmanagedType.LPStruct)] PixelFormatDescriptor pfd);
        public static bool SetPixelFormat(IntPtr dc, int format, PixelFormatDescriptor pfd)
        {
            LoadLibrary("opengl32.dll");

            return _SetPixelFormat(dc, format, pfd);
        }
        
        [DllImport("GDI32")]
        public static extern void SwapBuffers(IntPtr dc);

        [DllImport("Kernel32")]
        public static extern IntPtr GetProcAddress(IntPtr handle, String funcname);

        [DllImport("Kernel32")]
        public static extern IntPtr LoadLibrary(String funcname);
        
        [DllImport("Kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr handle);
        
        [DllImport("GDI32")]
        public static extern IntPtr SelectObject(IntPtr dc, IntPtr obj);
        
        [DllImport("GDI32")]
        public static extern bool DeleteObject(IntPtr objectHandle);
        
        [DllImport("GDI32")]
        public static extern IntPtr GetStockObject(IntPtr obj);
        
        [DllImport("GDI32")]
        public static extern IntPtr CreateFont(int height, int width, int esc, int orientation, int fnwidth, int italic, int underline, int strikeout, int charset, int precision, int clipprecision, int quality, int pitch, string face);
        
        [DllImport("GDI32")]
        public static extern bool GetTextExtentPoint32(IntPtr dc, string text, int length, out CharSize result);
        
        [DllImport("Kernel32")]
        public static extern int GetLastError();
    }
}
