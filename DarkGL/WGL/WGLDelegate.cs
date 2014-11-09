using System;
using System.Text;

namespace DarkTech.DarkGL
{
    public static class WGLDelegate
    {
        #region ARB
        public delegate bool BindTexImage(IntPtr hPbuffer, int iBuffer);
        public delegate bool ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, uint[] nNumFormats);
        public delegate IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, uint uType);
        public delegate IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList);
        public delegate IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList);
        public delegate void DeleteBufferRegion(IntPtr hRegion);
        public delegate bool DestroyPbuffer(IntPtr hPbuffer);
        public delegate IntPtr GetCurrentReadDC();
        public delegate StringBuilder GetExtensionsString(IntPtr hdc);
        public delegate IntPtr GetExtensionsString_W(IntPtr hdc);
        public delegate IntPtr GetPbufferDC(IntPtr hPbuffer);
        public delegate bool GetPixelFormatAttribfv(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, float[] pfValues);
        public delegate bool GetPixelFormatAttribiv(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues);
        public delegate bool MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
        public delegate bool QueryPbuffer(IntPtr hPbuffer, int iAttribute, int[] piValue);
        public delegate int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC);
        public delegate bool ReleaseTexImage(IntPtr hPbuffer, int iBuffer);
        public delegate bool RestoreBufferRegion(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
        public delegate bool SaveBufferRegion(IntPtr hRegion, int x, int y, int width, int height);
        public delegate bool SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList);
        #endregion

        #region EXT
        public delegate bool BindDisplayColorTable(ushort id);
        // Function ChoosePixelFormatEXT is alias for ChoosePixelFormatARB.
        public delegate bool CreateDisplayColorTable(ushort id);
        // Function CreatePbufferEXT is alias for CreatePbufferARB.
        public delegate void DestroyDisplayColorTable(ushort id);
        // Function DestroyPbufferEXT is alias for DestroyPbufferARB.
        // Function GetCurrentReadDCEXT is alias for GetCurrentReadDCARB.
        public delegate StringBuilder GetExtensionsStringEXT();
        public delegate IntPtr GetExtensionsStringEXT_W();
        // Function GetPbufferDCEXT is alias for GetPbufferDCARB.
        // Function GetPixelFormatAttribfvEXT is alias for GetPixelFormatAttribfvARB.
        // Function GetPixelFormatAttribivEXT is alias for GetPixelFormatAttribivARB.
        public delegate int GetSwapInterval();
        public delegate bool LoadDisplayColorTable(ushort[] table, uint length);
        // Function MakeContextCurrentEXT is alias for MakeContextCurrentARB.
        // Function QueryPbufferEXT is alias for QueryPbufferARB.
        // Function ReleasePbufferDCEXT is alias for ReleasePbufferDCARB.
        public delegate bool SwapInterval(int interval);
        #endregion

        #region NV
        public delegate IntPtr AllocateMemory(int size, float readfreq, float writefreq, float priority);
        public delegate bool BindSwapBarrier(uint group, uint barrier);
        public delegate bool BindVideoCaptureDevice(uint uVideoSlot, IntPtr hDevice);
        public delegate bool BindVideoDevice(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int[] piAttribList);
        public delegate bool BindVideoImage(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);
        public delegate bool CopyImageSubData(IntPtr hSrcRC, uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
        public delegate IntPtr CreateAffinityDC(IntPtr[] phGpuList);
        public delegate bool DeleteDC(IntPtr hdc);
        public delegate bool DXCloseDevice(IntPtr hDevice);
        public delegate bool DXLockObjects(IntPtr hDevice, int count, IntPtr[] hObjects);
        public delegate bool DXObjectAccess(IntPtr hObject, int access);
        public delegate IntPtr DXOpenDevice(IntPtr dxDevice);
        public delegate IntPtr DXRegisterObject(IntPtr hDevice, IntPtr dxObject, uint name, int type, int access);
        public delegate bool DXSetResourceShareHandle(IntPtr dxObject, IntPtr shareHandle);
        public delegate bool DXUnlockObjects(IntPtr hDevice, int count, IntPtr[] hObjects);
        public delegate bool DXUnregisterObject(IntPtr hDevice, IntPtr hObject);
        public delegate uint EnumerateVideoCaptureDevices(IntPtr hDc, IntPtr[] phDeviceList);
        public delegate int EnumerateVideoDevices(IntPtr hDC, IntPtr[] phDeviceList);
        public delegate bool EnumGpuDevices(IntPtr hGpu, uint iDeviceIndex, IntPtr lpGpuDevice);
        public delegate bool EnumGpus(uint iGpuIndex, IntPtr[] phGpu);
        public delegate bool EnumGpusFromAffinityDC(IntPtr hAffinityDC, uint iGpuIndex, IntPtr[] hGpu);
        public delegate void FreeMemory(IntPtr pointer);
        public delegate bool GetVideoDevice(IntPtr hDC, int numDevices, IntPtr[] hVideoDevice);
        public delegate bool GetVideoInfo(IntPtr hpVideoDevice, ulong[] pulCounterOutputPbuffer, ulong[] pulCounterOutputVideo);
        public delegate bool JoinSwapGroup(IntPtr hDC, uint group);
        public delegate bool LockVideoCaptureDevice(IntPtr hDc, IntPtr hDevice);
        public delegate bool QueryCurrentContext(int iAttribute, int[] piValue);
        public delegate bool QueryFrameCount(IntPtr hDC, uint[] count);
        public delegate bool QueryMaxSwapGroups(IntPtr hDC, uint[] maxGroups, uint[] maxBarriers);
        public delegate bool QuerySwapGroup(IntPtr hDC, uint[] group, uint[] barrier);
        public delegate bool QueryVideoCaptureDevice(IntPtr hDc, IntPtr hDevice, int iAttribute, int[] piValue);
        public delegate bool ReleaseVideoCaptureDevice(IntPtr hDc, IntPtr hDevice);
        public delegate bool ReleaseVideoDevice(IntPtr hVideoDevice);
        public delegate bool ReleaseVideoImage(IntPtr hPbuffer, int iVideoBuffer);
        public delegate bool ResetFrameCount(IntPtr hDC);
        public delegate bool SendPbufferToVideo(IntPtr hPbuffer, int iBufferType, ulong[] pulCounterPbuffer, bool bBlock);
        #endregion

        #region OML
        public delegate bool GetMscRate(IntPtr hdc, int[] numerator, int[] denominator);
        public delegate bool GetSyncValues(IntPtr hdc, long[] ust, long[] msc, long[] sbc);
        public delegate long SwapBuffersMsc(IntPtr hdc, long target_msc, long divisor, long remainder);
        public delegate long SwapLayerBuffersMsc(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder);
        public delegate bool WaitForMsc(IntPtr hdc, long target_msc, long divisor, long remainder, long[] ust, long[] msc, long[] sbc);
        public delegate bool WaitForSbc(IntPtr hdc, long target_sbc, long[] ust, long[] msc, long[] sbc);
        #endregion

        #region I3D
        public delegate bool AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, uint[] pSize, uint count);
        public delegate bool BeginFrameTracking();
        public delegate IntPtr CreateImageBuffer(IntPtr hDC, uint dwSize, uint uFlags);
        public delegate bool DestroyImageBuffer(IntPtr hDC, IntPtr pAddress);
        public delegate bool DisableFrameLock();
        public delegate bool DisableGenlock(IntPtr hDC);
        public delegate bool EnableFrameLock();
        public delegate bool EnableGenlock(IntPtr hDC);
        public delegate bool EndFrameTracking();
        public delegate bool GenlockSampleRate(IntPtr hDC, uint uRate);
        public delegate bool GenlockSource(IntPtr hDC, uint uSource);
        public delegate bool GenlockSourceDelay(IntPtr hDC, uint uDelay);
        public delegate bool GenlockSourceEdge(IntPtr hDC, uint uEdge);
        public delegate bool GetDigitalVideoParameters(IntPtr hDC, int iAttribute, int[] piValue);
        public delegate bool GetFrameUsage(float[] pUsage);
        public delegate bool GetGammaTable(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue);
        public delegate bool GetGammaTableParameters(IntPtr hDC, int iAttribute, int[] piValue);
        public delegate bool GetGenlockSampleRate(IntPtr hDC, uint[] uRate);
        public delegate bool GetGenlockSource(IntPtr hDC, uint[] uSource);
        public delegate bool GetGenlockSourceDelay(IntPtr hDC, uint[] uDelay);
        public delegate bool GetGenlockSourceEdge(IntPtr hDC, uint[] uEdge);
        public delegate bool IsEnabledFrameLock(bool[] pFlag);
        public delegate bool IsEnabledGenlock(IntPtr hDC, bool[] pFlag);
        public delegate bool QueryFrameLockMaster(bool[] pFlag);
        public delegate bool QueryFrameTracking(uint[] pFrameCount, uint[] pMissedFrames, float[] pLastMissedUsage);
        public delegate bool QueryGenlockMaxSourceDelay(IntPtr hDC, uint[] uMaxLineDelay, uint[] uMaxPixelDelay);
        public delegate bool ReleaseImageBufferEvents(IntPtr hDC, IntPtr[] pAddress, uint count);
        public delegate bool SetDigitalVideoParameters(IntPtr hDC, int iAttribute, int[] piValue);
        public delegate bool SetGammaTable(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue);
        public delegate bool SetGammaTableParameters(IntPtr hDC, int iAttribute, int[] piValue);
        #endregion

        #region 3DL
        public delegate bool SetStereoEmitterState(IntPtr hDC, uint uState);
        #endregion

        #region AMD
        public delegate void BlitContextFramebuffer(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
        public delegate IntPtr CreateAssociatedContext(uint id);
        public delegate IntPtr CreateAssociatedContextAttribs(uint id, IntPtr hShareContext, int[] attribList);
        public delegate bool DeleteAssociatedContext(IntPtr hglrc);
        public delegate uint GetContextGPUID(IntPtr hglrc);
        public delegate IntPtr GetCurrentAssociatedContext();
        public delegate uint GetGPUIDs(uint maxCount, uint[] ids);
        public delegate int GetGPUInfo(uint id, int property, int dataType, uint size, IntPtr data);
        public delegate bool MakeAssociatedContextCurrent(IntPtr hglrc);
        #endregion
    }
}
