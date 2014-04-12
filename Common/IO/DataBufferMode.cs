namespace DarkTech.Common.Network
{
    /// <summary>
    /// Determines how the data buffer can be used.
    /// </summary>
    public enum DataBufferMode
    {
        /// <summary>
        /// The buffer can only be read. Attempting to write to the buffer will throw an exception.
        /// </summary>
        Read,
        /// <summary>
        /// The buffer can only be written. Attempting to read from the buffer will throw an exception.
        /// </summary>
        Write,
        /// <summary>
        /// The buffer can be read and written.
        /// </summary>
        Mixed
    }
}
