using System.IO;

namespace DarkTech.Engine.Resources
{
    public sealed class File : FileInfo
    {
        private Stream stream;

        public long Position { get { return stream.Position; } }
        public Stream Stream { get { return stream; } }

        internal File(string name, string extension, string parentPath, long size, Stream stream) 
            : base(name, extension, parentPath, size)
        {
            this.stream = stream;
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
        }

        public void Seek(long position)
        {
            if (position < 0 || position >= Size)
            {
                // Error: Invalid position
            }

            stream.Position = position;
        }

        public static implicit operator Stream(File file)
        {
            return file.stream;
        }
    }
}
