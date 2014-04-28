namespace DarkTech.Common.PAK
{
    public enum PakEntryFlags : byte
    {
        None = 0,
        GZip = 1,
        Deflate = 2,
        Removed = 4,
        Padded = 8
    }
}
