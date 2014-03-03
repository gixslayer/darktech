namespace DarkTech.Engine.Resources
{
    /// <summary>
    /// Basic file information for a file in the file system.
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        /// The name of the file (including extension).
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The extension of the file.
        /// </summary>
        public string Extension { get; private set; }
        /// <summary>
        /// The parent directory of the file. This will always end with a directory separator unless the directory is the root directory (in which case the value will be string.Empty).
        /// /// </summary>
        public string ParentPath { get; private set; }
        /// <summary>
        /// The size of the file.
        /// </summary>
        public long Size { get; private set; }

        internal FileInfo(string name, string extension, string parentPath, long size)
        {
            this.Name = name;
            this.Extension = extension;
            this.ParentPath = parentPath;
            this.Size = size;
        }
    }
}
