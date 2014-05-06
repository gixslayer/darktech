namespace DarkTech.Engine.FileSystem
{
    /// <summary>
    /// Specifies the I/O access a file requests.
    /// </summary>
    public enum FileAccess
    {
        /// <summary>
        /// Read only access.
        /// </summary>
        Read = 1,
        /// <summary>
        /// Write only access.
        /// </summary>
        Write = 2,
        /// <summary>
        /// Both read and write access.
        /// </summary>
        ReadWrite = 3
    }
}
