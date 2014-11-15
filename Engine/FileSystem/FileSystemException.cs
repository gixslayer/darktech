namespace DarkTech.Engine.FileSystem
{
    public sealed class FileSystemException : EngineException
    {
        public FileSystemException(string message) : base(message) { }
        public FileSystemException(string format, params object[] args) : base(string.Format(format, args)) { }
    }
}
