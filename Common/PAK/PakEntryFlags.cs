namespace DarkTech.Common.PAK
{
    /// <summary>
    /// The bitwise flags that provide additional information for a <see cref="PakEntry"/> instance.
    /// </summary>
    public enum PakEntryFlags : byte
    {
        /// <summary>
        /// No additional information.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates the package entry data is compressed using GZip.
        /// </summary>
        /// <remarks>
        /// This flag cannot be using in combination with <see cref="PakEntryFlags.Deflate"/>.
        /// </remarks>
        GZip = 1,
        /// <summary>
        /// Indicates the package entry data is compressed using Deflate.
        /// </summary>
        /// <remarks>
        /// This flag cannot be using in combination with <see cref="PakEntryFlags.GZip"/>.
        /// </remarks>
        Deflate = 2,
        /// <summary>
        /// Indicates the package entry is removed and should be ignored while loading a package.
        /// </summary>
        Removed = 4,
    }
}
