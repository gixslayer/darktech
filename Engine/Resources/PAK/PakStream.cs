using System;
using System.IO;

namespace DarkTech.Engine.Resources.PAK
{
    public class PakStream : Stream
    {
        private Stream baseStream;
        private long offset;
        private long length;
        private long position;

        internal PakStream(Stream baseStream, long offset, long length)
        {
            if (!baseStream.CanRead || !baseStream.CanSeek)
            {
                throw new ArgumentException("Base stream must be able to read and seek", "baseStream");
            }

            this.baseStream = baseStream;
            this.baseStream.Position = offset;
            this.offset = offset;
            this.length = length;
            this.position = 0L;
        }

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

        public override void Flush()
        {
        }

        public override long Length
        {
            get { return length; }
        }

        public override long Position
        {
            get { return position;  }
            set 
            {
                if (value < 0 || value >= length)
                {
                    throw new ArgumentOutOfRangeException("Position", "Position must be between 0 and the length of the pak stream");
                }

                position = value;

                baseStream.Position = offset + position;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (position + count > length)
            {
                throw new ArgumentOutOfRangeException("count", "Can not read past the pak stream");
            }

            return baseStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            long basePosition;

            switch(origin)
            {
                case SeekOrigin.Begin:
                    basePosition = 0;
                    break;

                case SeekOrigin.Current:
                    basePosition = position;
                    break;

                case SeekOrigin.End:
                    basePosition = length - 1;
                    break;

                default:
                    throw new ArgumentException("Unknown origin type");
            }

            Position = basePosition + offset;

            return position;
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException("Can not set the length of a pak stream");
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException("Can not write to a pak stream");
        }
    }
}
