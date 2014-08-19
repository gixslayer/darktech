using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.Gdi32
{
    public static class Gdi32
    {
        public const string GDI32DLL = "gdi32.dll";

       // [DllImport(GDI32DLL, SetLastError = true)]
      //  public static extern int ChoosePixelFormat([In] IntPtr hDC, [In] ref PixelFormatDescriptor pdf);

       // [DllImport(GDI32DLL, SetLastError = true)]
       // public static extern int DescribePixelFormat([In] IntPtr hDC, [In] int format, [In] uint nBytes, [In] ref PixelFormatDescriptor pdf);

        [DllImport(GDI32DLL)]
        public static extern IntPtr GetStockObject([In] StockObjects fnObject);

        [DllImport(GDI32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat([In] IntPtr hDC, [In] int format, [In] ref PixelFormatDescriptor pdf);

        [DllImport(GDI32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapBuffers([In] IntPtr hDC);
    }
}
