using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkGL
{
    public partial class wgl
    {
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglChoosePixelFormat")]
        public static extern int ChoosePixelFormat(IntPtr hDc, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pPfd);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglCopyContext")]
        public static extern bool CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglCreateContext")]
        public static extern IntPtr CreateContext(IntPtr hDc);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglCreateLayerContext")]
        public static extern IntPtr CreateLayerContext(IntPtr hDc, int level);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglDeleteContext")]
        public static extern bool DeleteContext(IntPtr oldContext);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglDescribeLayerPlane")]
        public static extern bool DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, [In, MarshalAs(UnmanagedType.LPStruct)]LayerPlaneDescriptor plpd);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetCurrentDC")]
        public static extern IntPtr GetCurrentDC();
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetDefaultProcAddress")]
        public static extern IntPtr GetDefaultProcAddress(string lpszProc);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetLayerPaletteEntries")]
        public static extern int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint[] pcr);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetPixelFormat")]
        public static extern int GetPixelFormat(IntPtr hdc);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglGetProcAddress")]
        public static extern IntPtr GetProcAddress(string lpszProc);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglMakeCurrent")]
        public static extern bool MakeCurrent(IntPtr hDc, IntPtr newContext);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglRealizeLayerPalette")]
        public static extern bool RealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglSetLayerPaletteEntries")]
        public static extern int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint[] pcr);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglSetPixelFormat")]
        public static extern bool SetPixelFormat(IntPtr hdc, int ipfd, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor ppfd);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglShareLists")]
        public static extern bool ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglSwapBuffers")]
        public static extern bool SwapBuffers(IntPtr hdc);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglSwapLayerBuffers")]
        public static extern bool SwapLayerBuffers(IntPtr hdc, uint fuFlags);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglUseFontBitmapsA")]
        public static extern bool UseFontBitmapsA(IntPtr hDC, uint first, uint count, uint listBase);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglUseFontBitmapsW")]
        public static extern bool UseFontBitmapsW(IntPtr hDC, uint first, uint count, uint listBase);
        [DllImport(LoadingProviderWin.GLLibName, EntryPoint = "wglDescribePixelFormat")]
        public static extern int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor ppfd);
    }
}
