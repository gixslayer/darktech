using System;
using System.IO;

namespace DarkTech.Engine.FileSystem
{
    /// <summary>
    /// Provides access to a file.
    /// </summary>
    public sealed class File : FileInfo, IDisposable
    {
        private readonly Stream stream;
        private bool disposed;

        /// <summary>
        /// The current position within the file.
        /// </summary>
        public long Position { get { return stream.Position; } }
        /// <summary>
        /// The underlying stream.
        /// </summary>
        public Stream Stream { get { return stream; } }

        internal File(FileInfo fileInfo, Stream stream) : this(fileInfo.Name, fileInfo.Extension, fileInfo.ParentPath, fileInfo.Size, stream) { }
        internal File(string name, string extension, string parentPath, long size, Stream stream) 
            : base(name, extension, parentPath, size)
        {
            this.stream = stream;
            this.disposed = false;
        }

        ~File()
        {
            Dispose();
        }

        /// <summary>
        /// Close the file and dispose all associated resources.
        /// </summary>
        public void Dispose()
        {
            if (!disposed)
            {
                GC.SuppressFinalize(this);

                stream.Dispose();

                disposed = true;
            }
        }

        /// <summary>
        /// Reads a sequence of bytes from the file and advances the position within the file by the number of bytes read.
        /// </summary>
        /// <param name="buffer">The buffer to store the read data.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to begin storing data.</param>
        /// <param name="count">The maximum amount of bytes to read.</param>
        /// <returns>Returns the actual number of bytes read.</returns>
        public int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }

        /// <summary>
        /// Writes a sequence of bytes to the file and advances the position within the file by the number of bytes written.
        /// </summary>
        /// <param name="buffer">The buffer that contains the data to write.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to begin writing data from.</param>
        /// <param name="count">The amount of bytes to write.</param>
        public void Write(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
        }

        /// <summary>
        /// Sets the position within the file.
        /// </summary>
        /// <param name="position">The byte position in the file.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the specified <paramref name="position"/> is below zero or higher than <see cref="Size"/>.</exception>
        public void Seek(long position)
        {
            if (position < 0 || position > Size)
                throw new ArgumentOutOfRangeException("position");

            stream.Seek(0, SeekOrigin.Begin);
        }

        public static implicit operator Stream(File file)
        {
            return file.stream;
        }
    }
}
