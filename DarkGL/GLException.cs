using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Graphics library exception
    /// </summary>
    public sealed class GLException : Exception
    {
        public GLException(string message) : base(message) { }
    }
}
