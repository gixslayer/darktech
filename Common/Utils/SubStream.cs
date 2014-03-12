using System;
using System.IO;

namespace DarkTech.Common.Utils
{
    public class SubStream : Stream
    {
        private readonly Stream baseStream;
        private readonly bool readOnly;
        private readonly long offset;
        private long position;
        private long length;

        public Stream BaseStream { get { return baseStream; } }
 
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
            get { return !readOnly; }
        }

        public override long Length
        {
            get { return length; }
        }

        public override long Position
        {
            get
            {
                return position;
            }
            set
            {
                position = Seek(value, SeekOrigin.Begin);
            }
        }

        public SubStream(Stream stream, long offset)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanSeek)
                throw new ArgumentException("Stream must be able to seek", "stream");
            if (!stream.CanWrite)
                throw new ArgumentException("Stream must be able to write", "stream");
            if (!stream.CanRead)
                throw new ArgumentException("Stream must be able to read", "stream");
            if (offset < 0 || offset >= stream.Length)
                throw new ArgumentOutOfRangeException("offset");

            this.baseStream = stream;
            this.offset = offset;
            this.position = 0;
            this.readOnly = false;
            this.length = stream.Length - offset;
        }

        public SubStream(Stream stream, long offset, long length)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanSeek)
                throw new ArgumentException("Stream must be able to seek", "stream");
            if (!stream.CanRead)
                throw new ArgumentException("Stream must be able to read", "stream");
            if (offset < 0 || offset >= stream.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (length < 0 || offset + length > stream.Length)
                throw new ArgumentOutOfRangeException("length");

            this.baseStream = stream;
            this.offset = offset;
            this.position = 0;
            this.readOnly = true;
            this.length = length;
        }

        public override void Flush()
        {
            baseStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (count < 0 || position + count > length)
                throw new ArgumentOutOfRangeException("count");

            int bytesRead = baseStream.Read(buffer, offset, count);

            position = baseStream.Position - offset;

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    if (offset < 0)
                        throw new ArgumentOutOfRangeException("offset");
                    if (offset >= length && readOnly)
                        throw new ArgumentOutOfRangeException("offset", "Cannot seek past a read only stream");

                    position = offset;
                    break;

                case SeekOrigin.Current:
                    if (position + offset < 0)
                        throw new ArgumentOutOfRangeException("offset");
                    if(position + offset >= length && readOnly)
                        throw new ArgumentOutOfRangeException("offset", "Cannot seek past a read only stream");

                    position += offset;
                    break;

                case SeekOrigin.End:
                    if (length + offset < 0)
                        throw new ArgumentOutOfRangeException("offset");
                    if (length + offset >= length && readOnly)
                        throw new ArgumentOutOfRangeException("offset", "Cannot seek past a read only stream");

                    position = length + offset;
                    break;
                    
            }

            baseStream.Position = offset + position;
            length = baseStream.Length - offset;

            return position;
        }

        public override void SetLength(long value)
        {
            if (readOnly)
                throw new InvalidOperationException("Stream is read only");
            if (value < 0 || value < offset)
                throw new ArgumentOutOfRangeException("value");

            baseStream.SetLength(offset + value);

            length = baseStream.Length - offset;
            position = baseStream.Position - offset;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (readOnly)
                throw new InvalidOperationException("Stream is read only");

            baseStream.Write(buffer, offset, count);

            length = baseStream.Length - offset;
            position = baseStream.Position - offset;
        }
    }
}
