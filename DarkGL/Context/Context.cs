using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Provides an abstract context base which should serve for platform independent context creation.
    /// </summary>
    public abstract class Context : IDisposable
    {
        /// <summary>
        /// The context settings.
        /// </summary>
        public ContextSettings Settings { get; set; }

        /// <summary>
        /// Disposes the context.
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// Makes the context current.
        /// </summary>
        public abstract void MakeCurrent();

        /// <summary>
        /// Releases the current context.
        /// </summary>
        public abstract void UnmakeCurrent();

        /// <summary>
        /// Swaps the front and back buffers.
        /// </summary>
        public abstract void SwapBuffers();

        /// <summary>
        /// Creates a context using the default settings.
        /// </summary>
        /// <param name="hWnd">The window handle to create the context on.</param>  
        /// <returns>A platform specific implementation of a context.</returns>
        public static Context CreateContext(IntPtr hWnd)
        {
            return CreateContext(hWnd, ContextSettings.DEFAULT);
        }

        /// <summary>
        /// Creates a context using custom settings.
        /// </summary>
        /// <param name="hWnd">The window handle to create the context on.</param>  
        /// <param name="settings">The custom context settings.</param>
        /// <returns>Context</returns>
        public static Context CreateContext(IntPtr hWnd, ContextSettings settings)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32Windows: 
                    return ContextWin.CreateContext(hWnd, settings);

                default:
                    throw new PlatformNotSupportedException();
            }
        }
    }
}
