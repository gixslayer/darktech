namespace DarkTech.Engine.FileSystem
{
    public sealed class DirectoryNotFoundException : FileSystemException
    {
        public DirectoryNotFoundException(string message) : base(message) { }
    }
}
