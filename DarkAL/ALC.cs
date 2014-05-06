using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkAL
{
    public static class alc
    {
        private const string LIBRARY = "OpenAL32.dll";
        private const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCreateContext")]
        public static extern IntPtr CreateContext(IntPtr device, IntPtr attrlist);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcMakeContextCurrent")]
        public static extern bool MakeContextCurrent(IntPtr context);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcProcessContext")]
        public static extern void ProcessContext(IntPtr context);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcSuspendContext")]
        public static extern void SuspendContext(IntPtr context);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcDestroyContext")]
        public static extern void DestroyContext(IntPtr context);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetContextsDevice")]
        public static extern IntPtr GetContextsDevice(IntPtr context);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcOpenDevice")]
        public static extern IntPtr OpenDevice(string devicename);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCloseDevice")]
        public static extern bool CloseDevice(IntPtr device);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetError")]
        public static extern int GetError(IntPtr device);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcIsExtensionPresent")]
        public static extern bool IsExtensionPresent(IntPtr device, string extname);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetProcAddress")]
        public static extern IntPtr GetProcAddress(IntPtr device, string funcname);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetEnumValue")]
        public static extern int GetEnumValue(IntPtr device, string enumname);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetString")]
        public static extern IntPtr GetString([In] IntPtr device, int param);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcGetIntegerv")]
        public static extern void GetIntegerv(IntPtr device, int param, int size, out int data);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCaptureOpenDevice")]
        public static extern IntPtr CaptureOpenDevice(string devicename, uint frequency, int format, int buffersize);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCaptureCloseDevice")]
        public static extern bool CaptureCloseDevice(IntPtr device);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCaptureStart")]
        public static extern void CaptureStart(IntPtr device);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCaptureStop")]
        public static extern void CaptureStop(IntPtr device);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alcCaptureSamples")]
        public static extern void CaptureSamples(IntPtr device, IntPtr buffer, int samples);
    }
}
