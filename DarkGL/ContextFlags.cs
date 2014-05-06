using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Enumeration for Context setting (OpenGL >3.0)
    /// </summary>
    [Flags]
    public enum ContextFlags
    {
        None = 0,
        /// <summary>
        /// If the WGL_CONTEXT_DEBUG_BIT_ARB flag bit is set in 
        /// WGL_CONTEXT_FLAGS_ARB, then a debug context will be created. Debug
        /// contexts are intended for use during application development, and
        /// provide additional runtime checking, validation, and logging
        /// functionality while possibly incurring performance penalties. The
        /// additional functionality provided by debug contexts may vary
        /// according to the implementation(fn). In some cases a debug context
        /// may be identical to a non-debug context.
        /// </summary>
        Debug = WGL.CONTEXT_DEBUG_BIT_ARB,
        /// <summary>
        /// If the WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB is set in
        /// WGL_CONTEXT_FLAGS_ARB, then a forward-compatible context will be
        /// created. Forward-compatible contexts are defined only for OpenGL
        /// versions 3.0 and later. They must not support functionality marked
        /// as deprecated by that version of the API, while a
        /// non-forward-compatible context must support all functionality in
        /// that version, deprecated or not.
        /// </summary>
        ForwardCompatible = WGL.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB
    }
}
