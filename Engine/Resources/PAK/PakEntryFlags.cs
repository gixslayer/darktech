namespace DarkTech.Engine.Resources.PAK
{
    /// <summary>
    /// Defines the flags that can be set on pak entries.
    /// </summary>
    public enum PakEntryFlags : byte
    {
        /// <summary>
        /// Specifies no special behavior. Pak entries are stored in raw uncompressed format.
        /// </summary>
        None = 0
        // TODO: Add compression mode flags.
    }
}
