using System;
using System.Runtime.InteropServices;

using DarkTech.NativeWin32.Gdi32;

namespace DarkTech.DarkGL
{
    public partial class wgl
    {
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglChoosePixelFormat")]
        public static extern int ChoosePixelFormat(IntPtr hDc, ref PixelFormatDescriptor pfd);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglCopyContext")]
        public static extern bool CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglCreateContext")]
        public static extern IntPtr CreateContext(IntPtr hDc);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglCreateLayerContext")]
        public static extern IntPtr CreateLayerContext(IntPtr hDc, int level);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglDeleteContext")]
        public static extern bool DeleteContext(IntPtr oldContext);
        //[DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglDescribeLayerPlane")]
        //public static extern bool DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, [In, MarshalAs(UnmanagedType.LPStruct)]LayerPlaneDescriptor plpd);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetCurrentDC")]
        public static extern IntPtr GetCurrentDC();
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetDefaultProcAddress")]
        public static extern IntPtr GetDefaultProcAddress(string lpszProc);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetLayerPaletteEntries")]
        public static extern int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint[] pcr);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetPixelFormat")]
        public static extern int GetPixelFormat(IntPtr hdc);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglGetProcAddress")]
        public static extern IntPtr GetProcAddress(string lpszProc);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglMakeCurrent")]
        public static extern bool MakeCurrent(IntPtr hDc, IntPtr newContext);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglRealizeLayerPalette")]
        public static extern bool RealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglSetLayerPaletteEntries")]
        public static extern int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint[] pcr);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglSetPixelFormat")]
        public static extern bool SetPixelFormat(IntPtr hdc, int ipfd, ref PixelFormatDescriptor pfd);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglShareLists")]
        public static extern bool ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglSwapBuffers")]
        public static extern bool SwapBuffers(IntPtr hdc);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglSwapLayerBuffers")]
        public static extern bool SwapLayerBuffers(IntPtr hdc, uint fuFlags);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglUseFontBitmapsA")]
        public static extern bool UseFontBitmapsA(IntPtr hDC, uint first, uint count, uint listBase);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglUseFontBitmapsW")]
        public static extern bool UseFontBitmapsW(IntPtr hDC, uint first, uint count, uint listBase);
        [DllImport(LoadingProviderWin.OPENGL32DLL, EntryPoint = "wglDescribePixelFormat")]
        public static extern int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, ref PixelFormatDescriptor pfd);
    }

    /*public class LayerPlaneDescriptor
    {
        public ushort nSize;
        public ushort nVersion;
        public uint dwFlags;
        public byte iPixelType;
        public byte cColorBits;
        public byte cRedBits;
        public byte cRedShift;
        public byte cGreenBits;
        public byte cGreenShift;
        public byte cBlueBits;
        public byte cBlueShift;
        public byte cAlphaBits;
        public byte cAlphaShift;
        public byte cAccumBits;
        public byte cAccumRedBits;
        public byte cAccumGreenBits;
        public byte cAccumBlueBits;
        public byte cAccumAlphaBits;
        public byte cDepthBits;
        public byte cStencilBits;
        public byte cAuxBuffers;
        public byte iLayerType;
        public byte bReserved;
        public uint crTransparent;
    }*/
}
