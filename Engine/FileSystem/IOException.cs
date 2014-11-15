namespace DarkTech.Engine.FileSystem
{
    public sealed class IOException : FileSystemException
    {
        public IOException(string message) : base(message) { }
        public IOException(string format, params object[] args) : base(format, args) { }
    }
}
