namespace DarkTech.Engine.FileSystem
{
    public sealed class FileNotFoundException : FileSystemException
    {
        public FileNotFoundException(string message) : base(message) { }
    }
}
