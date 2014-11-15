namespace DarkTech.Engine.FileSystem
{
    public sealed class SecurityException : FileSystemException
    {
        public SecurityException(string message) : base(message) { }
        public SecurityException(string format, params object[] args) : base(format, args) { }
    }
}
