namespace DarkTech.Engine.FileSystem
{
    public sealed class InvalidPathException : FileSystemException
    {
        public InvalidPathException(string path) : base("Invalid path {0}", path) { }
    }
}
