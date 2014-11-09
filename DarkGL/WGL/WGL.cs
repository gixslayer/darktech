using System;
using System.Text;

namespace DarkTech.DarkGL
{
    public partial class wgl
    {
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindTexImageARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        [GLEntry("BindTexImageARB", Category = "ARB")]
        public static WGLDelegate.BindTexImage _BindTexImage = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindTexImageARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        public static bool BindTexImage(IntPtr hPbuffer, int iBuffer)
        {
            if (wgl._BindTexImage != null) return wgl._BindTexImage(hPbuffer, iBuffer);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ChoosePixelFormatARB</para>
        /// <para>Aliases: ChoosePixelFormatEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        [GLEntry("ChoosePixelFormatARB", Category = "ARB", Alias = "ChoosePixelFormatEXT ")]
        public static WGLDelegate.ChoosePixelFormat _ChoosePixelFormat = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ChoosePixelFormatARB</para>
        /// <para>Aliases: ChoosePixelFormatEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        public static bool ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, uint[] nNumFormats)
        {
            if (wgl._ChoosePixelFormat != null) return wgl._ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        [GLEntry("CreateBufferRegionARB", Category = "ARB")]
        public static WGLDelegate.CreateBufferRegion _CreateBufferRegion = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        public static IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, uint uType)
        {
            if (wgl._CreateBufferRegion != null) return wgl._CreateBufferRegion(hDC, iLayerPlane, uType);
            else return (IntPtr)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateContextAttribsARB</para>
        /// <para>Extensions: ARB_create_context</para>
        /// </summary>
        [GLEntry("CreateContextAttribsARB", Category = "ARB")]
        public static WGLDelegate.CreateContextAttribs _CreateContextAttribs = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateContextAttribsARB</para>
        /// <para>Extensions: ARB_create_context</para>
        /// </summary>
        public static IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList)
        {
            if (wgl._CreateContextAttribs != null) return wgl._CreateContextAttribs(hDC, hShareContext, attribList);
            else return (IntPtr)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreatePbufferARB</para>
        /// <para>Aliases: CreatePbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        [GLEntry("CreatePbufferARB", Category = "ARB", Alias = "CreatePbufferEXT ")]
        public static WGLDelegate.CreatePbuffer _CreatePbuffer = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreatePbufferARB</para>
        /// <para>Aliases: CreatePbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        public static IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
        {
            if (wgl._CreatePbuffer != null) return wgl._CreatePbuffer(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
            else return (IntPtr)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DeleteBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        [GLEntry("DeleteBufferRegionARB", Category = "ARB")]
        public static WGLDelegate.DeleteBufferRegion _DeleteBufferRegion = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DeleteBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        public static void DeleteBufferRegion(IntPtr hRegion)
        {
            if (wgl._DeleteBufferRegion != null) wgl._DeleteBufferRegion(hRegion);
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DestroyPbufferARB</para>
        /// <para>Aliases: DestroyPbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        [GLEntry("DestroyPbufferARB", Category = "ARB", Alias = "DestroyPbufferEXT ")]
        public static WGLDelegate.DestroyPbuffer _DestroyPbuffer = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DestroyPbufferARB</para>
        /// <para>Aliases: DestroyPbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        public static bool DestroyPbuffer(IntPtr hPbuffer)
        {
            if (wgl._DestroyPbuffer != null) return wgl._DestroyPbuffer(hPbuffer);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetCurrentReadDCARB</para>
        /// <para>Aliases: GetCurrentReadDCEXT</para>
        /// <para>Extensions: ARB_make_current_read EXT_make_current_read</para>
        /// </summary>
        [GLEntry("GetCurrentReadDCARB", Category = "ARB", Alias = "GetCurrentReadDCEXT ")]
        public static WGLDelegate.GetCurrentReadDC _GetCurrentReadDC = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetCurrentReadDCARB</para>
        /// <para>Aliases: GetCurrentReadDCEXT</para>
        /// <para>Extensions: ARB_make_current_read EXT_make_current_read</para>
        /// </summary>
        public static IntPtr GetCurrentReadDC()
        {
            if (wgl._GetCurrentReadDC != null) return wgl._GetCurrentReadDC();
            else return (IntPtr)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetExtensionsStringARB</para>
        /// <para>Extensions: ARB_extensions_string</para>
        /// </summary>
        [GLEntry("GetExtensionsStringARB", Category = "ARB")]
        public static WGLDelegate.GetExtensionsString _GetExtensionsString = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetExtensionsStringARB</para>
        /// <para>Extensions: ARB_extensions_string</para>
        /// </summary>
        public static StringBuilder GetExtensionsString(IntPtr hdc)
        {
            if (wgl._GetExtensionsString != null) return wgl._GetExtensionsString(hdc);
            else return new StringBuilder();
        }
        
        [GLEntry("GetExtensionsStringAARB", Category = "ARB")]
        public static WGLDelegate.GetExtensionsString_W _GetExtensionsString_W = null;

        public static string GetExensionsString_W(IntPtr hdc)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(wgl._GetExtensionsString_W(hdc));
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetPbufferDCARB</para>
        /// <para>Aliases: GetPbufferDCEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        [GLEntry("GetPbufferDCARB", Category = "ARB", Alias = "GetPbufferDCEXT ")]
        public static WGLDelegate.GetPbufferDC _GetPbufferDC = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetPbufferDCARB</para>
        /// <para>Aliases: GetPbufferDCEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        public static IntPtr GetPbufferDC(IntPtr hPbuffer)
        {
            if (wgl._GetPbufferDC != null) return wgl._GetPbufferDC(hPbuffer);
            else return (IntPtr)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetPixelFormatAttribfvARB</para>
        /// <para>Aliases: GetPixelFormatAttribfvEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        [GLEntry("GetPixelFormatAttribfvARB", Category = "ARB", Alias = "GetPixelFormatAttribfvEXT ")]
        public static WGLDelegate.GetPixelFormatAttribfv _GetPixelFormatAttribfv = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetPixelFormatAttribfvARB</para>
        /// <para>Aliases: GetPixelFormatAttribfvEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        public static bool GetPixelFormatAttribfv(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, float[] pfValues)
        {
            if (wgl._GetPixelFormatAttribfv != null) return wgl._GetPixelFormatAttribfv(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetPixelFormatAttribivARB</para>
        /// <para>Aliases: GetPixelFormatAttribivEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        [GLEntry("GetPixelFormatAttribivARB", Category = "ARB", Alias = "GetPixelFormatAttribivEXT ")]
        public static WGLDelegate.GetPixelFormatAttribiv _GetPixelFormatAttribiv = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetPixelFormatAttribivARB</para>
        /// <para>Aliases: GetPixelFormatAttribivEXT</para>
        /// <para>Extensions: ARB_pixel_format EXT_pixel_format</para>
        /// </summary>
        public static bool GetPixelFormatAttribiv(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues)
        {
            if (wgl._GetPixelFormatAttribiv != null) return wgl._GetPixelFormatAttribiv(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: MakeContextCurrentARB</para>
        /// <para>Aliases: MakeContextCurrentEXT</para>
        /// <para>Extensions: ARB_make_current_read EXT_make_current_read</para>
        /// </summary>
        [GLEntry("MakeContextCurrentARB", Category = "ARB", Alias = "MakeContextCurrentEXT ")]
        public static WGLDelegate.MakeContextCurrent _MakeContextCurrent = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: MakeContextCurrentARB</para>
        /// <para>Aliases: MakeContextCurrentEXT</para>
        /// <para>Extensions: ARB_make_current_read EXT_make_current_read</para>
        /// </summary>
        public static bool MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            if (wgl._MakeContextCurrent != null) return wgl._MakeContextCurrent(hDrawDC, hReadDC, hglrc);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryPbufferARB</para>
        /// <para>Aliases: QueryPbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        [GLEntry("QueryPbufferARB", Category = "ARB", Alias = "QueryPbufferEXT ")]
        public static WGLDelegate.QueryPbuffer _QueryPbuffer = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryPbufferARB</para>
        /// <para>Aliases: QueryPbufferEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        public static bool QueryPbuffer(IntPtr hPbuffer, int iAttribute, int[] piValue)
        {
            if (wgl._QueryPbuffer != null) return wgl._QueryPbuffer(hPbuffer, iAttribute, piValue);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleasePbufferDCARB</para>
        /// <para>Aliases: ReleasePbufferDCEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        [GLEntry("ReleasePbufferDCARB", Category = "ARB", Alias = "ReleasePbufferDCEXT ")]
        public static WGLDelegate.ReleasePbufferDC _ReleasePbufferDC = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleasePbufferDCARB</para>
        /// <para>Aliases: ReleasePbufferDCEXT</para>
        /// <para>Extensions: ARB_pbuffer EXT_pbuffer</para>
        /// </summary>
        public static int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
        {
            if (wgl._ReleasePbufferDC != null) return wgl._ReleasePbufferDC(hPbuffer, hDC);
            else return (int)0;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleaseTexImageARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        [GLEntry("ReleaseTexImageARB", Category = "ARB")]
        public static WGLDelegate.ReleaseTexImage _ReleaseTexImage = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleaseTexImageARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        public static bool ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
        {
            if (wgl._ReleaseTexImage != null) return wgl._ReleaseTexImage(hPbuffer, iBuffer);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: RestoreBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        [GLEntry("RestoreBufferRegionARB", Category = "ARB")]
        public static WGLDelegate.RestoreBufferRegion _RestoreBufferRegion = null;
        
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: RestoreBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        public static bool RestoreBufferRegion(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
        {
            if (wgl._RestoreBufferRegion != null) return wgl._RestoreBufferRegion(hRegion, x, y, width, height, xSrc, ySrc);
            else return false;
        }
        
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SaveBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        [GLEntry("SaveBufferRegionARB", Category = "ARB")]
        public static WGLDelegate.SaveBufferRegion _SaveBufferRegion = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SaveBufferRegionARB</para>
        /// <para>Extensions: ARB_buffer_region</para>
        /// </summary>
        public static bool SaveBufferRegion(IntPtr hRegion, int x, int y, int width, int height)
        {
            if (wgl._SaveBufferRegion != null) return wgl._SaveBufferRegion(hRegion, x, y, width, height);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SetPbufferAttribARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        [GLEntry("SetPbufferAttribARB", Category = "ARB")]
        public static WGLDelegate.SetPbufferAttrib _SetPbufferAttrib = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SetPbufferAttribARB</para>
        /// <para>Extensions: ARB_render_texture</para>
        /// </summary>
        public static bool SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList)
        {
            if (wgl._SetPbufferAttrib != null) return wgl._SetPbufferAttrib(hPbuffer, piAttribList);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        [GLEntry("BindDisplayColorTableEXT", Category = "EXT")]
        public static WGLDelegate.BindDisplayColorTable _BindDisplayColorTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        public static bool BindDisplayColorTable(ushort id)
        {
            if (wgl._BindDisplayColorTable != null) return wgl._BindDisplayColorTable(id);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        [GLEntry("CreateDisplayColorTableEXT", Category = "EXT")]
        public static WGLDelegate.CreateDisplayColorTable _CreateDisplayColorTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        public static bool CreateDisplayColorTable(ushort id)
        {
            if (wgl._CreateDisplayColorTable != null) return wgl._CreateDisplayColorTable(id);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DestroyDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        [GLEntry("DestroyDisplayColorTableEXT", Category = "EXT")]
        public static WGLDelegate.DestroyDisplayColorTable _DestroyDisplayColorTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DestroyDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        public static void DestroyDisplayColorTable(ushort id)
        {
            if (wgl._DestroyDisplayColorTable != null) wgl._DestroyDisplayColorTable(id);
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetExtensionsStringEXT</para>
        /// <para>Extensions: EXT_extensions_string</para>
        /// </summary>
        [GLEntry("GetExtensionsStringEXT", Category = "EXT")]
        public static WGLDelegate.GetExtensionsStringEXT _GetExtensionsStringEXT = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetExtensionsStringEXT</para>
        /// <para>Extensions: EXT_extensions_string</para>
        /// </summary>
        public static StringBuilder GetExtensionsStringEXT()
        {
            if (wgl._GetExtensionsStringEXT != null) return wgl._GetExtensionsStringEXT();
            else return new StringBuilder();
        }

        [GLEntry("GetExtensionsStringEXT", Category = "EXT")]
        public static WGLDelegate.GetExtensionsStringEXT_W _GetExtensionsStringEXT_W = null;

        public static string GetExtensionsStringEXT_W()
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(wgl._GetExtensionsStringEXT_W());
        }

        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetSwapIntervalEXT</para>
        /// <para>Extensions: EXT_swap_control</para>
        /// </summary>
        [GLEntry("GetSwapIntervalEXT", Category = "EXT")]
        public static WGLDelegate.GetSwapInterval _GetSwapInterval = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetSwapIntervalEXT</para>
        /// <para>Extensions: EXT_swap_control</para>
        /// </summary>
        public static int GetSwapInterval()
        {
            if (wgl._GetSwapInterval != null) return wgl._GetSwapInterval();
            else return (int)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: LoadDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        [GLEntry("LoadDisplayColorTableEXT", Category = "EXT")]
        public static WGLDelegate.LoadDisplayColorTable _LoadDisplayColorTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: LoadDisplayColorTableEXT</para>
        /// <para>Extensions: EXT_display_color_table</para>
        /// </summary>
        public static bool LoadDisplayColorTable(ushort[] table, uint length)
        {
            if (wgl._LoadDisplayColorTable != null) return wgl._LoadDisplayColorTable(table, length);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SwapIntervalEXT</para>
        /// <para>Extensions: EXT_swap_control</para>
        /// </summary>
        [GLEntry("SwapIntervalEXT", Category = "EXT")]
        public static WGLDelegate.SwapInterval _SwapInterval = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SwapIntervalEXT</para>
        /// <para>Extensions: EXT_swap_control</para>
        /// </summary>
        public static bool SwapInterval(int interval)
        {
            if (wgl._SwapInterval != null) return wgl._SwapInterval(interval);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: AllocateMemoryNV</para>
        /// <para>Extensions: NV_vertex_array_range</para>
        /// </summary>
        [GLEntry("AllocateMemoryNV", Category = "NV")]
        public static WGLDelegate.AllocateMemory _AllocateMemory = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: AllocateMemoryNV</para>
        /// <para>Extensions: NV_vertex_array_range</para>
        /// </summary>
        public static IntPtr AllocateMemory(int size, float readfreq, float writefreq, float priority)
        {
            if (wgl._AllocateMemory != null) return wgl._AllocateMemory(size, readfreq, writefreq, priority);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindSwapBarrierNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("BindSwapBarrierNV", Category = "NV")]
        public static WGLDelegate.BindSwapBarrier _BindSwapBarrier = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindSwapBarrierNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool BindSwapBarrier(uint group, uint barrier)
        {
            if (wgl._BindSwapBarrier != null) return wgl._BindSwapBarrier(group, barrier);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        [GLEntry("BindVideoCaptureDeviceNV", Category = "NV")]
        public static WGLDelegate.BindVideoCaptureDevice _BindVideoCaptureDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        public static bool BindVideoCaptureDevice(uint uVideoSlot, IntPtr hDevice)
        {
            if (wgl._BindVideoCaptureDevice != null) return wgl._BindVideoCaptureDevice(uVideoSlot, hDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindVideoDeviceNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        [GLEntry("BindVideoDeviceNV", Category = "NV")]
        public static WGLDelegate.BindVideoDevice _BindVideoDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindVideoDeviceNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        public static bool BindVideoDevice(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int[] piAttribList)
        {
            if (wgl._BindVideoDevice != null) return wgl._BindVideoDevice(hDC, uVideoSlot, hVideoDevice, piAttribList);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BindVideoImageNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("BindVideoImageNV", Category = "NV")]
        public static WGLDelegate.BindVideoImage _BindVideoImage = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BindVideoImageNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool BindVideoImage(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer)
        {
            if (wgl._BindVideoImage != null) return wgl._BindVideoImage(hVideoDevice, hPbuffer, iVideoBuffer);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CopyImageSubDataNV</para>
        /// <para>Extensions: NV_copy_image</para>
        /// </summary>
        [GLEntry("CopyImageSubDataNV", Category = "NV")]
        public static WGLDelegate.CopyImageSubData _CopyImageSubData = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CopyImageSubDataNV</para>
        /// <para>Extensions: NV_copy_image</para>
        /// </summary>
        public static bool CopyImageSubData(IntPtr hSrcRC, uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            if (wgl._CopyImageSubData != null) return wgl._CopyImageSubData(hSrcRC, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateAffinityDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        [GLEntry("CreateAffinityDCNV", Category = "NV")]
        public static WGLDelegate.CreateAffinityDC _CreateAffinityDC = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateAffinityDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        public static IntPtr CreateAffinityDC(IntPtr[] phGpuList)
        {
            if (wgl._CreateAffinityDC != null) return wgl._CreateAffinityDC(phGpuList);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DeleteDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        [GLEntry("DeleteDCNV", Category = "NV")]
        public static WGLDelegate.DeleteDC _DeleteDC = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DeleteDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        public static bool DeleteDC(IntPtr hdc)
        {
            if (wgl._DeleteDC != null) return wgl._DeleteDC(hdc);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXCloseDeviceNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXCloseDeviceNV", Category = "NV")]
        public static WGLDelegate.DXCloseDevice _DXCloseDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXCloseDeviceNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXCloseDevice(IntPtr hDevice)
        {
            if (wgl._DXCloseDevice != null) return wgl._DXCloseDevice(hDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXLockObjectsNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXLockObjectsNV", Category = "NV")]
        public static WGLDelegate.DXLockObjects _DXLockObjects = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXLockObjectsNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXLockObjects(IntPtr hDevice, int count, IntPtr[] hObjects)
        {
            if (wgl._DXLockObjects != null) return wgl._DXLockObjects(hDevice, count, hObjects);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXObjectAccessNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXObjectAccessNV", Category = "NV")]
        public static WGLDelegate.DXObjectAccess _DXObjectAccess = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXObjectAccessNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXObjectAccess(IntPtr hObject, int access)
        {
            if (wgl._DXObjectAccess != null) return wgl._DXObjectAccess(hObject, access);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXOpenDeviceNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXOpenDeviceNV", Category = "NV")]
        public static WGLDelegate.DXOpenDevice _DXOpenDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXOpenDeviceNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static IntPtr DXOpenDevice(IntPtr dxDevice)
        {
            if (wgl._DXOpenDevice != null) return wgl._DXOpenDevice(dxDevice);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXRegisterObjectNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXRegisterObjectNV", Category = "NV")]
        public static WGLDelegate.DXRegisterObject _DXRegisterObject = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXRegisterObjectNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static IntPtr DXRegisterObject(IntPtr hDevice, IntPtr dxObject, uint name, int type, int access)
        {
            if (wgl._DXRegisterObject != null) return wgl._DXRegisterObject(hDevice, dxObject, name, type, access);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXSetResourceShareHandleNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXSetResourceShareHandleNV", Category = "NV")]
        public static WGLDelegate.DXSetResourceShareHandle _DXSetResourceShareHandle = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXSetResourceShareHandleNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXSetResourceShareHandle(IntPtr dxObject, IntPtr shareHandle)
        {
            if (wgl._DXSetResourceShareHandle != null) return wgl._DXSetResourceShareHandle(dxObject, shareHandle);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXUnlockObjectsNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXUnlockObjectsNV", Category = "NV")]
        public static WGLDelegate.DXUnlockObjects _DXUnlockObjects = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXUnlockObjectsNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXUnlockObjects(IntPtr hDevice, int count, IntPtr[] hObjects)
        {
            if (wgl._DXUnlockObjects != null) return wgl._DXUnlockObjects(hDevice, count, hObjects);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DXUnregisterObjectNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        [GLEntry("DXUnregisterObjectNV", Category = "NV")]
        public static WGLDelegate.DXUnregisterObject _DXUnregisterObject = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DXUnregisterObjectNV</para>
        /// <para>Extensions: NV_DX_interop</para>
        /// </summary>
        public static bool DXUnregisterObject(IntPtr hDevice, IntPtr hObject)
        {
            if (wgl._DXUnregisterObject != null) return wgl._DXUnregisterObject(hDevice, hObject);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnumerateVideoCaptureDevicesNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        [GLEntry("EnumerateVideoCaptureDevicesNV", Category = "NV")]
        public static WGLDelegate.EnumerateVideoCaptureDevices _EnumerateVideoCaptureDevices = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnumerateVideoCaptureDevicesNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        public static uint EnumerateVideoCaptureDevices(IntPtr hDc, IntPtr[] phDeviceList)
        {
            if (wgl._EnumerateVideoCaptureDevices != null) return wgl._EnumerateVideoCaptureDevices(hDc, phDeviceList);
            else return (uint)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnumerateVideoDevicesNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        [GLEntry("EnumerateVideoDevicesNV", Category = "NV")]
        public static WGLDelegate.EnumerateVideoDevices _EnumerateVideoDevices = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnumerateVideoDevicesNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        public static int EnumerateVideoDevices(IntPtr hDC, IntPtr[] phDeviceList)
        {
            if (wgl._EnumerateVideoDevices != null) return wgl._EnumerateVideoDevices(hDC, phDeviceList);
            else return (int)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnumGpuDevicesNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        [GLEntry("EnumGpuDevicesNV", Category = "NV")]
        public static WGLDelegate.EnumGpuDevices _EnumGpuDevices = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnumGpuDevicesNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        public static bool EnumGpuDevices(IntPtr hGpu, uint iDeviceIndex, IntPtr lpGpuDevice)
        {
            if (wgl._EnumGpuDevices != null) return wgl._EnumGpuDevices(hGpu, iDeviceIndex, lpGpuDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnumGpusNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        [GLEntry("EnumGpusNV", Category = "NV")]
        public static WGLDelegate.EnumGpus _EnumGpus = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnumGpusNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        public static bool EnumGpus(uint iGpuIndex, IntPtr[] phGpu)
        {
            if (wgl._EnumGpus != null) return wgl._EnumGpus(iGpuIndex, phGpu);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnumGpusFromAffinityDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        [GLEntry("EnumGpusFromAffinityDCNV", Category = "NV")]
        public static WGLDelegate.EnumGpusFromAffinityDC _EnumGpusFromAffinityDC = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnumGpusFromAffinityDCNV</para>
        /// <para>Extensions: NV_gpu_affinity</para>
        /// </summary>
        public static bool EnumGpusFromAffinityDC(IntPtr hAffinityDC, uint iGpuIndex, IntPtr[] hGpu)
        {
            if (wgl._EnumGpusFromAffinityDC != null) return wgl._EnumGpusFromAffinityDC(hAffinityDC, iGpuIndex, hGpu);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: FreeMemoryNV</para>
        /// <para>Extensions: NV_vertex_array_range</para>
        /// </summary>
        [GLEntry("FreeMemoryNV", Category = "NV")]
        public static WGLDelegate.FreeMemory _FreeMemory = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: FreeMemoryNV</para>
        /// <para>Extensions: NV_vertex_array_range</para>
        /// </summary>
        public static void FreeMemory(IntPtr pointer)
        {
            if (wgl._FreeMemory != null) wgl._FreeMemory(pointer);
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetVideoDeviceNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("GetVideoDeviceNV", Category = "NV")]
        public static WGLDelegate.GetVideoDevice _GetVideoDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetVideoDeviceNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool GetVideoDevice(IntPtr hDC, int numDevices, IntPtr[] hVideoDevice)
        {
            if (wgl._GetVideoDevice != null) return wgl._GetVideoDevice(hDC, numDevices, hVideoDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetVideoInfoNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("GetVideoInfoNV", Category = "NV")]
        public static WGLDelegate.GetVideoInfo _GetVideoInfo = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetVideoInfoNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool GetVideoInfo(IntPtr hpVideoDevice, ulong[] pulCounterOutputPbuffer, ulong[] pulCounterOutputVideo)
        {
            if (wgl._GetVideoInfo != null) return wgl._GetVideoInfo(hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: JoinSwapGroupNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("JoinSwapGroupNV", Category = "NV")]
        public static WGLDelegate.JoinSwapGroup _JoinSwapGroup = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: JoinSwapGroupNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool JoinSwapGroup(IntPtr hDC, uint group)
        {
            if (wgl._JoinSwapGroup != null) return wgl._JoinSwapGroup(hDC, group);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: LockVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        [GLEntry("LockVideoCaptureDeviceNV", Category = "NV")]
        public static WGLDelegate.LockVideoCaptureDevice _LockVideoCaptureDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: LockVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        public static bool LockVideoCaptureDevice(IntPtr hDc, IntPtr hDevice)
        {
            if (wgl._LockVideoCaptureDevice != null) return wgl._LockVideoCaptureDevice(hDc, hDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryCurrentContextNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        [GLEntry("QueryCurrentContextNV", Category = "NV")]
        public static WGLDelegate.QueryCurrentContext _QueryCurrentContext = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryCurrentContextNV</para>
        /// <para>Extensions: NV_present_video</para>
        /// </summary>
        public static bool QueryCurrentContext(int iAttribute, int[] piValue)
        {
            if (wgl._QueryCurrentContext != null) return wgl._QueryCurrentContext(iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryFrameCountNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("QueryFrameCountNV", Category = "NV")]
        public static WGLDelegate.QueryFrameCount _QueryFrameCount = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryFrameCountNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool QueryFrameCount(IntPtr hDC, uint[] count)
        {
            if (wgl._QueryFrameCount != null) return wgl._QueryFrameCount(hDC, count);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryMaxSwapGroupsNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("QueryMaxSwapGroupsNV", Category = "NV")]
        public static WGLDelegate.QueryMaxSwapGroups _QueryMaxSwapGroups = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryMaxSwapGroupsNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool QueryMaxSwapGroups(IntPtr hDC, uint[] maxGroups, uint[] maxBarriers)
        {
            if (wgl._QueryMaxSwapGroups != null) return wgl._QueryMaxSwapGroups(hDC, maxGroups, maxBarriers);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QuerySwapGroupNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("QuerySwapGroupNV", Category = "NV")]
        public static WGLDelegate.QuerySwapGroup _QuerySwapGroup = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QuerySwapGroupNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool QuerySwapGroup(IntPtr hDC, uint[] group, uint[] barrier)
        {
            if (wgl._QuerySwapGroup != null) return wgl._QuerySwapGroup(hDC, group, barrier);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        [GLEntry("QueryVideoCaptureDeviceNV", Category = "NV")]
        public static WGLDelegate.QueryVideoCaptureDevice _QueryVideoCaptureDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        public static bool QueryVideoCaptureDevice(IntPtr hDc, IntPtr hDevice, int iAttribute, int[] piValue)
        {
            if (wgl._QueryVideoCaptureDevice != null) return wgl._QueryVideoCaptureDevice(hDc, hDevice, iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleaseVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        [GLEntry("ReleaseVideoCaptureDeviceNV", Category = "NV")]
        public static WGLDelegate.ReleaseVideoCaptureDevice _ReleaseVideoCaptureDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleaseVideoCaptureDeviceNV</para>
        /// <para>Extensions: NV_video_capture</para>
        /// </summary>
        public static bool ReleaseVideoCaptureDevice(IntPtr hDc, IntPtr hDevice)
        {
            if (wgl._ReleaseVideoCaptureDevice != null) return wgl._ReleaseVideoCaptureDevice(hDc, hDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleaseVideoDeviceNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("ReleaseVideoDeviceNV", Category = "NV")]
        public static WGLDelegate.ReleaseVideoDevice _ReleaseVideoDevice = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleaseVideoDeviceNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool ReleaseVideoDevice(IntPtr hVideoDevice)
        {
            if (wgl._ReleaseVideoDevice != null) return wgl._ReleaseVideoDevice(hVideoDevice);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleaseVideoImageNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("ReleaseVideoImageNV", Category = "NV")]
        public static WGLDelegate.ReleaseVideoImage _ReleaseVideoImage = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleaseVideoImageNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool ReleaseVideoImage(IntPtr hPbuffer, int iVideoBuffer)
        {
            if (wgl._ReleaseVideoImage != null) return wgl._ReleaseVideoImage(hPbuffer, iVideoBuffer);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ResetFrameCountNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        [GLEntry("ResetFrameCountNV", Category = "NV")]
        public static WGLDelegate.ResetFrameCount _ResetFrameCount = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ResetFrameCountNV</para>
        /// <para>Extensions: NV_swap_group</para>
        /// </summary>
        public static bool ResetFrameCount(IntPtr hDC)
        {
            if (wgl._ResetFrameCount != null) return wgl._ResetFrameCount(hDC);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SendPbufferToVideoNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        [GLEntry("SendPbufferToVideoNV", Category = "NV")]
        public static WGLDelegate.SendPbufferToVideo _SendPbufferToVideo = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SendPbufferToVideoNV</para>
        /// <para>Extensions: NV_video_output</para>
        /// </summary>
        public static bool SendPbufferToVideo(IntPtr hPbuffer, int iBufferType, ulong[] pulCounterPbuffer, bool bBlock)
        {
            if (wgl._SendPbufferToVideo != null) return wgl._SendPbufferToVideo(hPbuffer, iBufferType, pulCounterPbuffer, bBlock);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetMscRateOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("GetMscRateOML", Category = "OML")]
        public static WGLDelegate.GetMscRate _GetMscRate = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetMscRateOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static bool GetMscRate(IntPtr hdc, int[] numerator, int[] denominator)
        {
            if (wgl._GetMscRate != null) return wgl._GetMscRate(hdc, numerator, denominator);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetSyncValuesOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("GetSyncValuesOML", Category = "OML")]
        public static WGLDelegate.GetSyncValues _GetSyncValues = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetSyncValuesOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static bool GetSyncValues(IntPtr hdc, long[] ust, long[] msc, long[] sbc)
        {
            if (wgl._GetSyncValues != null) return wgl._GetSyncValues(hdc, ust, msc, sbc);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SwapBuffersMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("SwapBuffersMscOML", Category = "OML")]
        public static WGLDelegate.SwapBuffersMsc _SwapBuffersMsc = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SwapBuffersMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static long SwapBuffersMsc(IntPtr hdc, long target_msc, long divisor, long remainder)
        {
            if (wgl._SwapBuffersMsc != null) return wgl._SwapBuffersMsc(hdc, target_msc, divisor, remainder);
            else return (long)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SwapLayerBuffersMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("SwapLayerBuffersMscOML", Category = "OML")]
        public static WGLDelegate.SwapLayerBuffersMsc _SwapLayerBuffersMsc = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SwapLayerBuffersMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static long SwapLayerBuffersMsc(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder)
        {
            if (wgl._SwapLayerBuffersMsc != null) return wgl._SwapLayerBuffersMsc(hdc, fuPlanes, target_msc, divisor, remainder);
            else return (long)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: WaitForMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("WaitForMscOML", Category = "OML")]
        public static WGLDelegate.WaitForMsc _WaitForMsc = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: WaitForMscOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static bool WaitForMsc(IntPtr hdc, long target_msc, long divisor, long remainder, long[] ust, long[] msc, long[] sbc)
        {
            if (wgl._WaitForMsc != null) return wgl._WaitForMsc(hdc, target_msc, divisor, remainder, ust, msc, sbc);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: WaitForSbcOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        [GLEntry("WaitForSbcOML", Category = "OML")]
        public static WGLDelegate.WaitForSbc _WaitForSbc = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: WaitForSbcOML</para>
        /// <para>Extensions: OML_sync_control</para>
        /// </summary>
        public static bool WaitForSbc(IntPtr hdc, long target_sbc, long[] ust, long[] msc, long[] sbc)
        {
            if (wgl._WaitForSbc != null) return wgl._WaitForSbc(hdc, target_sbc, ust, msc, sbc);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: AssociateImageBufferEventsI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        [GLEntry("AssociateImageBufferEventsI3D", Category = "I3D")]
        public static WGLDelegate.AssociateImageBufferEvents _AssociateImageBufferEvents = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: AssociateImageBufferEventsI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        public static bool AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, uint[] pSize, uint count)
        {
            if (wgl._AssociateImageBufferEvents != null) return wgl._AssociateImageBufferEvents(hDC, pEvent, pAddress, pSize, count);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BeginFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        [GLEntry("BeginFrameTrackingI3D", Category = "I3D")]
        public static WGLDelegate.BeginFrameTracking _BeginFrameTracking = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BeginFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        public static bool BeginFrameTracking()
        {
            if (wgl._BeginFrameTracking != null) return wgl._BeginFrameTracking();
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateImageBufferI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        [GLEntry("CreateImageBufferI3D", Category = "I3D")]
        public static WGLDelegate.CreateImageBuffer _CreateImageBuffer = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateImageBufferI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        public static IntPtr CreateImageBuffer(IntPtr hDC, uint dwSize, uint uFlags)
        {
            if (wgl._CreateImageBuffer != null) return wgl._CreateImageBuffer(hDC, dwSize, uFlags);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DestroyImageBufferI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        [GLEntry("DestroyImageBufferI3D", Category = "I3D")]
        public static WGLDelegate.DestroyImageBuffer _DestroyImageBuffer = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DestroyImageBufferI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        public static bool DestroyImageBuffer(IntPtr hDC, IntPtr pAddress)
        {
            if (wgl._DestroyImageBuffer != null) return wgl._DestroyImageBuffer(hDC, pAddress);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DisableFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        [GLEntry("DisableFrameLockI3D", Category = "I3D")]
        public static WGLDelegate.DisableFrameLock _DisableFrameLock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DisableFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        public static bool DisableFrameLock()
        {
            if (wgl._DisableFrameLock != null) return wgl._DisableFrameLock();
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DisableGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("DisableGenlockI3D", Category = "I3D")]
        public static WGLDelegate.DisableGenlock _DisableGenlock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DisableGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool DisableGenlock(IntPtr hDC)
        {
            if (wgl._DisableGenlock != null) return wgl._DisableGenlock(hDC);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnableFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        [GLEntry("EnableFrameLockI3D", Category = "I3D")]
        public static WGLDelegate.EnableFrameLock _EnableFrameLock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnableFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        public static bool EnableFrameLock()
        {
            if (wgl._EnableFrameLock != null) return wgl._EnableFrameLock();
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EnableGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("EnableGenlockI3D", Category = "I3D")]
        public static WGLDelegate.EnableGenlock _EnableGenlock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EnableGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool EnableGenlock(IntPtr hDC)
        {
            if (wgl._EnableGenlock != null) return wgl._EnableGenlock(hDC);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: EndFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        [GLEntry("EndFrameTrackingI3D", Category = "I3D")]
        public static WGLDelegate.EndFrameTracking _EndFrameTracking = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: EndFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        public static bool EndFrameTracking()
        {
            if (wgl._EndFrameTracking != null) return wgl._EndFrameTracking();
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GenlockSampleRateI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GenlockSampleRateI3D", Category = "I3D")]
        public static WGLDelegate.GenlockSampleRate _GenlockSampleRate = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GenlockSampleRateI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GenlockSampleRate(IntPtr hDC, uint uRate)
        {
            if (wgl._GenlockSampleRate != null) return wgl._GenlockSampleRate(hDC, uRate);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GenlockSourceI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GenlockSourceI3D", Category = "I3D")]
        public static WGLDelegate.GenlockSource _GenlockSource = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GenlockSourceI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GenlockSource(IntPtr hDC, uint uSource)
        {
            if (wgl._GenlockSource != null) return wgl._GenlockSource(hDC, uSource);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GenlockSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GenlockSourceDelayI3D", Category = "I3D")]
        public static WGLDelegate.GenlockSourceDelay _GenlockSourceDelay = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GenlockSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GenlockSourceDelay(IntPtr hDC, uint uDelay)
        {
            if (wgl._GenlockSourceDelay != null) return wgl._GenlockSourceDelay(hDC, uDelay);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GenlockSourceEdgeI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GenlockSourceEdgeI3D", Category = "I3D")]
        public static WGLDelegate.GenlockSourceEdge _GenlockSourceEdge = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GenlockSourceEdgeI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GenlockSourceEdge(IntPtr hDC, uint uEdge)
        {
            if (wgl._GenlockSourceEdge != null) return wgl._GenlockSourceEdge(hDC, uEdge);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetDigitalVideoParametersI3D</para>
        /// <para>Extensions: I3D_digital_video_control</para>
        /// </summary>
        [GLEntry("GetDigitalVideoParametersI3D", Category = "I3D")]
        public static WGLDelegate.GetDigitalVideoParameters _GetDigitalVideoParameters = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetDigitalVideoParametersI3D</para>
        /// <para>Extensions: I3D_digital_video_control</para>
        /// </summary>
        public static bool GetDigitalVideoParameters(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wgl._GetDigitalVideoParameters != null) return wgl._GetDigitalVideoParameters(hDC, iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetFrameUsageI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        [GLEntry("GetFrameUsageI3D", Category = "I3D")]
        public static WGLDelegate.GetFrameUsage _GetFrameUsage = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetFrameUsageI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        public static bool GetFrameUsage(float[] pUsage)
        {
            if (wgl._GetFrameUsage != null) return wgl._GetFrameUsage(pUsage);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGammaTableI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        [GLEntry("GetGammaTableI3D", Category = "I3D")]
        public static WGLDelegate.GetGammaTable _GetGammaTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGammaTableI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        public static bool GetGammaTable(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
        {
            if (wgl._GetGammaTable != null) return wgl._GetGammaTable(hDC, iEntries, puRed, puGreen, puBlue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGammaTableParametersI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        [GLEntry("GetGammaTableParametersI3D", Category = "I3D")]
        public static WGLDelegate.GetGammaTableParameters _GetGammaTableParameters = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGammaTableParametersI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        public static bool GetGammaTableParameters(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wgl._GetGammaTableParameters != null) return wgl._GetGammaTableParameters(hDC, iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGenlockSampleRateI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GetGenlockSampleRateI3D", Category = "I3D")]
        public static WGLDelegate.GetGenlockSampleRate _GetGenlockSampleRate = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGenlockSampleRateI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GetGenlockSampleRate(IntPtr hDC, uint[] uRate)
        {
            if (wgl._GetGenlockSampleRate != null) return wgl._GetGenlockSampleRate(hDC, uRate);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGenlockSourceI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GetGenlockSourceI3D", Category = "I3D")]
        public static WGLDelegate.GetGenlockSource _GetGenlockSource = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGenlockSourceI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GetGenlockSource(IntPtr hDC, uint[] uSource)
        {
            if (wgl._GetGenlockSource != null) return wgl._GetGenlockSource(hDC, uSource);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGenlockSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GetGenlockSourceDelayI3D", Category = "I3D")]
        public static WGLDelegate.GetGenlockSourceDelay _GetGenlockSourceDelay = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGenlockSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GetGenlockSourceDelay(IntPtr hDC, uint[] uDelay)
        {
            if (wgl._GetGenlockSourceDelay != null) return wgl._GetGenlockSourceDelay(hDC, uDelay);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGenlockSourceEdgeI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("GetGenlockSourceEdgeI3D", Category = "I3D")]
        public static WGLDelegate.GetGenlockSourceEdge _GetGenlockSourceEdge = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGenlockSourceEdgeI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool GetGenlockSourceEdge(IntPtr hDC, uint[] uEdge)
        {
            if (wgl._GetGenlockSourceEdge != null) return wgl._GetGenlockSourceEdge(hDC, uEdge);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: IsEnabledFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        [GLEntry("IsEnabledFrameLockI3D", Category = "I3D")]
        public static WGLDelegate.IsEnabledFrameLock _IsEnabledFrameLock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: IsEnabledFrameLockI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        public static bool IsEnabledFrameLock(bool[] pFlag)
        {
            if (wgl._IsEnabledFrameLock != null) return wgl._IsEnabledFrameLock(pFlag);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: IsEnabledGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("IsEnabledGenlockI3D", Category = "I3D")]
        public static WGLDelegate.IsEnabledGenlock _IsEnabledGenlock = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: IsEnabledGenlockI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool IsEnabledGenlock(IntPtr hDC, bool[] pFlag)
        {
            if (wgl._IsEnabledGenlock != null) return wgl._IsEnabledGenlock(hDC, pFlag);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryFrameLockMasterI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        [GLEntry("QueryFrameLockMasterI3D", Category = "I3D")]
        public static WGLDelegate.QueryFrameLockMaster _QueryFrameLockMaster = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryFrameLockMasterI3D</para>
        /// <para>Extensions: I3D_swap_frame_lock</para>
        /// </summary>
        public static bool QueryFrameLockMaster(bool[] pFlag)
        {
            if (wgl._QueryFrameLockMaster != null) return wgl._QueryFrameLockMaster(pFlag);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        [GLEntry("QueryFrameTrackingI3D", Category = "I3D")]
        public static WGLDelegate.QueryFrameTracking _QueryFrameTracking = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryFrameTrackingI3D</para>
        /// <para>Extensions: I3D_swap_frame_usage</para>
        /// </summary>
        public static bool QueryFrameTracking(uint[] pFrameCount, uint[] pMissedFrames, float[] pLastMissedUsage)
        {
            if (wgl._QueryFrameTracking != null) return wgl._QueryFrameTracking(pFrameCount, pMissedFrames, pLastMissedUsage);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: QueryGenlockMaxSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        [GLEntry("QueryGenlockMaxSourceDelayI3D", Category = "I3D")]
        public static WGLDelegate.QueryGenlockMaxSourceDelay _QueryGenlockMaxSourceDelay = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: QueryGenlockMaxSourceDelayI3D</para>
        /// <para>Extensions: I3D_genlock</para>
        /// </summary>
        public static bool QueryGenlockMaxSourceDelay(IntPtr hDC, uint[] uMaxLineDelay, uint[] uMaxPixelDelay)
        {
            if (wgl._QueryGenlockMaxSourceDelay != null) return wgl._QueryGenlockMaxSourceDelay(hDC, uMaxLineDelay, uMaxPixelDelay);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: ReleaseImageBufferEventsI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        [GLEntry("ReleaseImageBufferEventsI3D", Category = "I3D")]
        public static WGLDelegate.ReleaseImageBufferEvents _ReleaseImageBufferEvents = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: ReleaseImageBufferEventsI3D</para>
        /// <para>Extensions: I3D_image_buffer</para>
        /// </summary>
        public static bool ReleaseImageBufferEvents(IntPtr hDC, IntPtr[] pAddress, uint count)
        {
            if (wgl._ReleaseImageBufferEvents != null) return wgl._ReleaseImageBufferEvents(hDC, pAddress, count);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SetDigitalVideoParametersI3D</para>
        /// <para>Extensions: I3D_digital_video_control</para>
        /// </summary>
        [GLEntry("SetDigitalVideoParametersI3D", Category = "I3D")]
        public static WGLDelegate.SetDigitalVideoParameters _SetDigitalVideoParameters = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SetDigitalVideoParametersI3D</para>
        /// <para>Extensions: I3D_digital_video_control</para>
        /// </summary>
        public static bool SetDigitalVideoParameters(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wgl._SetDigitalVideoParameters != null) return wgl._SetDigitalVideoParameters(hDC, iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SetGammaTableI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        [GLEntry("SetGammaTableI3D", Category = "I3D")]
        public static WGLDelegate.SetGammaTable _SetGammaTable = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SetGammaTableI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        public static bool SetGammaTable(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
        {
            if (wgl._SetGammaTable != null) return wgl._SetGammaTable(hDC, iEntries, puRed, puGreen, puBlue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SetGammaTableParametersI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        [GLEntry("SetGammaTableParametersI3D", Category = "I3D")]
        public static WGLDelegate.SetGammaTableParameters _SetGammaTableParameters = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SetGammaTableParametersI3D</para>
        /// <para>Extensions: I3D_gamma</para>
        /// </summary>
        public static bool SetGammaTableParameters(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wgl._SetGammaTableParameters != null) return wgl._SetGammaTableParameters(hDC, iAttribute, piValue);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: SetStereoEmitterState3DL</para>
        /// <para>Extensions: 3DL_stereo_control</para>
        /// </summary>
        [GLEntry("SetStereoEmitterState3DL", Category = "3DL")]
        public static WGLDelegate.SetStereoEmitterState _SetStereoEmitterState = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: SetStereoEmitterState3DL</para>
        /// <para>Extensions: 3DL_stereo_control</para>
        /// </summary>
        public static bool SetStereoEmitterState(IntPtr hDC, uint uState)
        {
            if (wgl._SetStereoEmitterState != null) return wgl._SetStereoEmitterState(hDC, uState);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: BlitContextFramebufferAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("BlitContextFramebufferAMD", Category = "AMD")]
        public static WGLDelegate.BlitContextFramebuffer _BlitContextFramebuffer = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: BlitContextFramebufferAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static void BlitContextFramebuffer(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter)
        {
            if (wgl._BlitContextFramebuffer != null) wgl._BlitContextFramebuffer(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("CreateAssociatedContextAMD", Category = "AMD")]
        public static WGLDelegate.CreateAssociatedContext _CreateAssociatedContext = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static IntPtr CreateAssociatedContext(uint id)
        {
            if (wgl._CreateAssociatedContext != null) return wgl._CreateAssociatedContext(id);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: CreateAssociatedContextAttribsAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("CreateAssociatedContextAttribsAMD", Category = "AMD")]
        public static WGLDelegate.CreateAssociatedContextAttribs _CreateAssociatedContextAttribs = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: CreateAssociatedContextAttribsAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static IntPtr CreateAssociatedContextAttribs(uint id, IntPtr hShareContext, int[] attribList)
        {
            if (wgl._CreateAssociatedContextAttribs != null) return wgl._CreateAssociatedContextAttribs(id, hShareContext, attribList);
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: DeleteAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("DeleteAssociatedContextAMD", Category = "AMD")]
        public static WGLDelegate.DeleteAssociatedContext _DeleteAssociatedContext = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: DeleteAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static bool DeleteAssociatedContext(IntPtr hglrc)
        {
            if (wgl._DeleteAssociatedContext != null) return wgl._DeleteAssociatedContext(hglrc);
            else return false;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetContextGPUIDAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("GetContextGPUIDAMD", Category = "AMD")]
        public static WGLDelegate.GetContextGPUID _GetContextGPUID = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetContextGPUIDAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static uint GetContextGPUID(IntPtr hglrc)
        {
            if (wgl._GetContextGPUID != null) return wgl._GetContextGPUID(hglrc);
            else return (uint)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetCurrentAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("GetCurrentAssociatedContextAMD", Category = "AMD")]
        public static WGLDelegate.GetCurrentAssociatedContext _GetCurrentAssociatedContext = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetCurrentAssociatedContextAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static IntPtr GetCurrentAssociatedContext()
        {
            if (wgl._GetCurrentAssociatedContext != null) return wgl._GetCurrentAssociatedContext();
            else return (IntPtr)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGPUIDsAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("GetGPUIDsAMD", Category = "AMD")]
        public static WGLDelegate.GetGPUIDs _GetGPUIDs = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGPUIDsAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static uint GetGPUIDs(uint maxCount, uint[] ids)
        {
            if (wgl._GetGPUIDs != null) return wgl._GetGPUIDs(maxCount, ids);
            else return (uint)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: GetGPUInfoAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("GetGPUInfoAMD", Category = "AMD")]
        public static WGLDelegate.GetGPUInfo _GetGPUInfo = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: GetGPUInfoAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static int GetGPUInfo(uint id, int property, int dataType, uint size, IntPtr data)
        {
            if (wgl._GetGPUInfo != null) return wgl._GetGPUInfo(id, property, dataType, size, data);
            else return (int)0;
        }
        /// <summary>
        /// <para>Direct call of gl function. If the function is not provided by the GL, the NullReferenceException occurs.</para>
        /// <para>Fullname: MakeAssociatedContextCurrentAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        [GLEntry("MakeAssociatedContextCurrentAMD", Category = "AMD")]
        public static WGLDelegate.MakeAssociatedContextCurrent _MakeAssociatedContextCurrent = null;
        /// <summary>
        /// <para>Wrapped gl function. If the function is not provided by the WGL, nothing happens.</para>
        /// <para>Fullname: MakeAssociatedContextCurrentAMD</para>
        /// <para>Extensions: AMD_gpu_association</para>
        /// </summary>
        public static bool MakeAssociatedContextCurrent(IntPtr hglrc)
        {
            if (wgl._MakeAssociatedContextCurrent != null) return wgl._MakeAssociatedContextCurrent(hglrc);
            else return false;
        }
    }
}
