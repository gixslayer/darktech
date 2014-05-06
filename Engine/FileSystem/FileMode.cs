namespace DarkTech.Engine.FileSystem
{
    /// <summary>
    /// Specifies how a file should be opened.
    /// </summary>
    public enum FileMode
    {
        /// <summary>
        /// Open an existing file. If the file doesn't exist the opening will fail.
        /// </summary>
        Open = 1,
        /// <summary>
        /// Create a new file. This requires Write access. If the file already exists the creation will fail.
        /// </summary>
        Create = 2,
        /// <summary>
        /// If the file exists it will be overwritten, else a new file is created.
        /// </summary>
        OpenOrCreate = 3,
        /// <summary>
        /// Creates a new file or opens an existing file and seeks to the end. The file will be write only and any attempts to read or seek before the end of the file will fail. This can only be used with Write access.
        /// </summary>
        Append = 4
    }
}
