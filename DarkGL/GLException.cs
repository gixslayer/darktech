using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Graphics library exception
    /// </summary>
    public class GLException : Exception
    {
        public GLException(string message, Exception innerException) : base(message, innerException) { }
        public GLException(string message) : base(message) { }
    }
}
