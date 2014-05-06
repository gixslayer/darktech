using System;
using System.Runtime.InteropServices;

namespace DarkTech.DarkAL
{
    public static class al
    {
        private const string LIBRARY = "OpenAL32.dll";
        private const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alEnable")]
        public static extern void Enable(int capability);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDisable")]
        public static extern void Disable(int capability);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alIsEnabled")]
        public static extern bool IsEnabled(int capability);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetString")]
        public static extern IntPtr GetString(int param);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBooleanv")]
        public static extern void GetBooleanv(int param, bool[] data);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetIntegerv")]
        public static extern void GetIntegerv(int param, int[] data);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetFloatv")]
        public static extern void GetFloatv(int param, float[] data);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetDoublev")]
        public static extern void GetDoublev(int param, double[] data);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBoolean")]
        public static extern bool GetBoolean(int param);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetInteger")]
        public static extern int GetInteger(int param);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetFloat")]
        public static extern float GetFloat(int param);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetDouble")]
        public static extern double GetDouble(int param);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetError")]
        public static extern int GetError();
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alIsExtensionPresent")]
        public static extern bool IsExtensionPresent(string extname);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetProcAddress")]
        public static extern IntPtr GetProcAddress(string fname);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetEnumValue")]
        public static extern int GetEnumValue(string ename);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListenerf")]
        public static extern void Listenerf(int param, float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListener3f")]
        public static extern void Listener3f(int param, float value1, float value2, float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListenerfv")]
        public static extern void Listenerfv(int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListeneri")]
        public static extern void Listeneri(int param, int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListener3i")]
        public static extern void Listener3i(int param, int value1, int value2, int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alListeneriv")]
        public static extern void Listeneriv(int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListenerf")]
        public static extern void GetListenerf(int param, out float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListener3f")]
        public static extern void GetListener3f(int param, out float value1, out float value2, out float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListenerfv")]
        public static extern void GetListenerfv(int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListeneri")]
        public static extern void GetListeneri(int param, out int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListener3i")]
        public static extern void GetListener3i(int param, out int value1, out int value2, out int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetListeneriv")]
        public static extern void GetListeneriv(int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGenSources")]
        public static extern void GenSources(int n, uint[] sources);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDeleteSources")]
        public static extern void DeleteSources(int n, uint[] sources);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alIsSource")]
        public static extern bool IsSource(uint sid);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcef")]
        public static extern void Sourcef(uint sid, int param, float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSource3f")]
        public static extern void Source3f(uint sid, int param, float value1, float value2, float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcefv")]
        public static extern void Sourcefv(uint sid, int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcei")]
        public static extern void Sourcei(uint sid, int param, int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSource3i")]
        public static extern void Source3i(uint sid, int param, int value1, int value2, int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceiv")]
        public static extern void Sourceiv(uint sid, int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSourcef")]
        public static extern void GetSourcef(uint sid, int param, out float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSource3f")]
        public static extern void GetSource3f(uint sid, int param, out float value1, out float value2, out float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSourcefv")]
        public static extern void GetSourcefv(uint sid, int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSourcei")]
        public static extern void GetSourcei(uint sid, int param, out int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSource3i")]
        public static extern void GetSource3i(uint sid, int param, out int value1, out int value2, out int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetSourceiv")]
        public static extern void GetSourceiv(uint sid, int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcePlayv")]
        public static extern void SourcePlayv(int ns, uint[] sids);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceStopv")]
        public static extern void SourceStopv(int ns, uint[] sids);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceRewindv")]
        public static extern void SourceRewindv(int ns, uint[] sids);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcePausev")]
        public static extern void SourcePausev(int ns, uint[] sids);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcePlay")]
        public static extern void SourcePlay(uint sid);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceStop")]
        public static extern void SourceStop(uint sid);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceRewind")]
        public static extern void SourceRewind(uint sid);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourcePause")]
        public static extern void SourcePause(uint sid);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceQueueBuffers")]
        public static extern void SourceQueueBuffers(uint sid, int numEntries, uint[] bids);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSourceUnqueueBuffers")]
        public static extern void SourceUnqueueBuffers(uint sid, int numEntries, uint[] bids);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGenBuffers")]
        public static extern void GenBuffers(int n, uint[] buffers);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDeleteBuffers")]
        public static extern void DeleteBuffers(int n, uint[] buffers);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alIsBuffer")]
        public static extern bool IsBuffer(uint bid);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBufferData")]
        public static extern void BufferData(uint bid, int format, byte[] data, int size, int freq); // byte[] data -> byte*/IntPtr?

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBufferf")]
        public static extern void Bufferf(uint bid, int param, float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBuffer3f")]
        public static extern void Buffer3f(uint bid, int param, float value1, float value2, float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBufferfv")]
        public static extern void Bufferfv(uint bid, int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBufferi")]
        public static extern void Bufferi(uint bid, int param, int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBuffer3i")]
        public static extern void Buffer3i(uint bid, int param, int value1, int value2, int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alBufferiv")]
        public static extern void Bufferiv(uint bid, int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBufferf")]
        public static extern void GetBufferf(uint bid, int param, out float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBuffer3f")]
        public static extern void GetBuffer3f(uint bid, int param, out float value1, out float value2, out float value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBufferfv")]
        public static extern void GetBufferfv(uint bid, int param, float[] values);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBufferi")]
        public static extern void GetBufferi(uint bid, int param, out int value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBuffer3i")]
        public static extern void GetBuffer3i(uint bid, int param, out int value1, out int value2, out int value3);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alGetBufferiv")]
        public static extern void GetBufferiv(uint bid, int param, int[] values);

        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDopplerFactor")]
        public static extern void DopplerFactor(float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDopplerVelocity")]
        public static extern void DopplerVelocity(float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alSpeedOfSound")]
        public static extern void SpeedOfSound(float value);
        [DllImport(LIBRARY, CallingConvention = CALLING_CONVENTION, EntryPoint = "alDistanceModel")]
        public static extern void DistanceModel(int distanceModel);
    }
}
