namespace DarkTech.Engine.FileSystem
{
    /// <summary>
    /// Provides basic file information.
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
        /// The full path of the parent directory relative to the root of the file system.
        /// </summary>
        public string ParentPath { get; internal set; }
        /// <summary>
        /// The size of the file in bytes.
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
