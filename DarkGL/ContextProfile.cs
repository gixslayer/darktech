namespace DarkTech.DarkGL
{
    /// <summary>
    /// Enumeration for Profile setting (OpenGL >3.0)
    /// </summary>
    public enum ContextProfile
    {
        None = 0,
        /// <summary>
        ///  If the WGL_CONTEXT_CORE_PROFILE_BIT_ARB bit is set in the attribute value,
        ///  then a context implementing the core profile of OpenGL is
        ///  returned. 
        /// </summary>
        Core = WGL.CONTEXT_CORE_PROFILE_BIT_ARB,
        /// <summary>
        /// If the WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB bit is
        /// set, then a context implementing the compatibility profile is
        /// returned.
        /// </summary>
        Compatibility = WGL.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB
    }
}
