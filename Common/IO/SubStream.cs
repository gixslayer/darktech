using System;
using System.IO;

namespace DarkTech.Common.IO
{
    public class SubStream : Stream
    {
        private readonly Stream baseStream; // Source stream.
        private readonly long offset; // Offset within source stream.
        private readonly long length; // Length of the sub stream.
        private long position; // Position within the sub stream.

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override long Length
        {
            get { return length; }
        }

        public override long Position
        {
            get { return position; }
            set { position = Seek(value, SeekOrigin.Begin); }
        }

        public SubStream(Stream stream, long offset, long length)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanRead)
                throw new ArgumentException("Cannot read stream", "stream");
            if (!stream.CanSeek)
                throw new ArgumentException("Cannot seek stream", "stream");
            if (offset < 0 || offset > stream.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (length < 0 || offset + length > stream.Length)
                throw new ArgumentOutOfRangeException("length");

            this.baseStream = stream;
            this.offset = offset;
            this.length = length;
            this.position = 0;

            // Make sure the base stream is at the correct position.
            this.baseStream.Position = offset;
        }

        public override void Flush()
        {
            // TODO: Should a read only stream throw an exception for trying to flush?
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (offset < 0 || offset >= buffer.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (count < 0 || offset + count > buffer.Length)
                throw new ArgumentOutOfRangeException("count");

            // Clamp count so it does not exceed the sub stream region.
            if (position + count > length)
            {
                count = (int)(length - position);
            }

            int bytesRead = baseStream.Read(buffer, offset, count);

            position += bytesRead;

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            long newPosition = -1;

            switch (origin)
            {
                case SeekOrigin.Begin:
                    newPosition = offset;
                    break;

                case SeekOrigin.Current:
                    newPosition = position + offset;
                    break;

                case SeekOrigin.End:
                    newPosition = length + offset;
                    break;
            }

            if (newPosition < 0 || newPosition > length)
                throw new ArgumentOutOfRangeException("offset");

            position = newPosition;
            baseStream.Position = offset + newPosition;

            return position;
        }

        public override void SetLength(long value)
        {
            throw new InvalidOperationException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new InvalidOperationException();
        }
    }
}
