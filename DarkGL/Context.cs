using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Abstract context. Should serve for platform independent context creation. Currently only Win32 platform is supported.
    /// </summary>
    public abstract class Context : IDisposable
    {
        /// <summary>
        /// Context setting.
        /// </summary>
        public ContextSetting Setting { get; set; }

        public abstract void Dispose();

        /// <summary>
        /// Makes the context current.
        /// </summary>
        public abstract void MakeCurrent();

        /// <summary>
        /// Makes the zero context current.
        /// </summary>
        public abstract void UnmakeCurrent();

        /// <summary>
        /// Swaps the front and back buffers.
        /// </summary>
        public abstract void SwapBuffers();

        /// <summary>
        /// Create context using the default setting.
        /// </summary>
        /// <param name="c">Control to host the context</param>
        /// <returns>Context</returns>
        public static Context CreateContext(IntPtr hWnd)
        {
            return CreateContext(hWnd, ContextSetting.DEFAULT);
        }

        /// <summary>
        /// Create context using user setting.
        /// </summary>
        /// <param name="c">Control to host the context</param>
        /// <param name="setting">Context setting parameters</param>
        /// <returns>Context</returns>
        public static Context CreateContext(IntPtr hWnd, ContextSetting setting)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32Windows: 
                    return ContextWin.CreateContext(hWnd, setting);

                default: 
                    throw new GLException("Running on unsupported platform");
            }
        }
    }
}
