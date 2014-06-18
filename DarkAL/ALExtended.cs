using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkAL
{
    public partial class al
    {

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGenSources")]
        public static extern void GenSources(int n, out uint source);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDeleteSources")]
        public static extern void DeleteSources(int n, uint source);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcei")]
        public static extern void Sourcei(uint sid, int param, uint value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSource3i")]
        public static extern void Source3i(uint sid, int param, uint value1, uint value2, uint value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceiv")]
        public static extern void Sourceiv(uint sid, int param, uint[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGenBuffers")]
        public static extern void GenBuffers(int n, out uint buffer);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDeleteBuffers")]
        public static extern void DeleteBuffers(int n, uint buffer);
    }
}
