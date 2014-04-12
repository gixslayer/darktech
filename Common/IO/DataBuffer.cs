using System;

using DarkTech.Common.Utils;

namespace DarkTech.Common.Network
{
    public class DataBuffer
    {
        private byte[] buffer;
        private int offset;
        private DataBufferMode mode;

        public byte[] BackBuffer { get { return buffer; } }
        public int Offset { get { return offset; } set { Seek(value);} }
        public int Length { get { return buffer.Length; } }
        public DataBufferMode Mode { get { return mode; } }
        public bool ReadOnly { get { return mode == DataBufferMode.Read; } }
        public bool WriteOnly { get { return mode == DataBufferMode.Write; } }

        #region Constructors
        public DataBuffer(int capacity) : this(capacity, DataBufferMode.Write) { }

        public DataBuffer(int capacity, DataBufferMode mode)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity", "Initial capacity cannot be negative");

            this.buffer = new byte[capacity];
            this.offset = 0;
            this.mode = mode;
        }

        public DataBuffer(byte[] buffer) : this(buffer, DataBufferMode.Read) { }

        public DataBuffer(byte[] buffer, DataBufferMode mode)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");

            this.buffer = buffer;
            this.offset = 0;
            this.mode = mode;
        }

        public DataBuffer(byte[] buffer, int offset, int count) : this(buffer, offset, count, DataBufferMode.Read) { }

        public DataBuffer(byte[] buffer, int offset, int count, DataBufferMode mode)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (offset < 0 || offset > buffer.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (offset + count > buffer.Length)
                throw new ArgumentOutOfRangeException("count");

            this.buffer = new byte[count];
            this.offset = 0;
            this.mode = mode;

            Buffer.BlockCopy(buffer, offset, this.buffer, 0, count);
        }
        #endregion

        public void EnsureAvailable(int amount)
        {
            EnsureAvailable(amount, true);
        }

        public void EnsureAvailable(int amount, bool allowResize)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount", "Amount cannot be negative");

            if (offset + amount > buffer.Length)
            {
                if (ReadOnly || !allowResize)
                    throw new DataBufferException(string.Format("Unexpected end of buffer, expected {0} bytes but only found {1}", offset + amount, buffer.Length));

                // Create new buffer with the increased size and copy the old data.
                byte[] newBuffer = new byte[offset + amount];

                Buffer.BlockCopy(buffer, 0, newBuffer, 0, buffer.Length);

                buffer = newBuffer;
            }
        }

        public void Seek(int offset)
        {
            if (offset < 0 || offset > buffer.Length)
                throw new ArgumentOutOfRangeException("offset");

            this.offset = offset;
        }

        public void SeekRelative(int offset)
        {
            if (this.offset + offset < 0 || this.offset + offset > buffer.Length)
                throw new ArgumentOutOfRangeException("offset");

            this.offset += offset;
        }

        #region Write
        public void Write(byte[] buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");

            Write(buffer, 0, buffer.Length);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (offset < 0 || offset > buffer.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (count < 0 || offset + count > buffer.Length)
                throw new ArgumentOutOfRangeException("count");
            if (ReadOnly)
                throw new InvalidOperationException("Buffer is read only");

            EnsureAvailable(count);

            Buffer.BlockCopy(buffer, offset, this.buffer, this.offset, count);
            this.offset += count;
        }

        public void Write(byte value)
        {
            if (ReadOnly)
                throw new InvalidOperationException("Buffer is read only");

            EnsureAvailable(1);

            buffer[offset] = value;
            offset++;
        }

        public void Write(sbyte value)
        {
            Write((byte)value);
        }

        public void Write(bool value)
        {
            Write(value ? ByteConverter.BOOL_TRUE : ByteConverter.BOOL_FALSE);
        }

        public void Write(ushort value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(short value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(char value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(uint value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(int value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(float value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(ulong value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(long value)
        {
            Write(ByteConverter.GetBytes(value));
        }

        public void Write(double value)
        {
            Write(ByteConverter.GetBytes(value));
        }
        #endregion

        #region Read
        private T Read<T>() where T : struct
        {
            int size = ByteConverter.GetSize<T>();

            EnsureAvailable(size, false);

            T value = ByteConverter.To<T>(buffer, offset);

            offset += size;

            return value;
        }

        public byte ReadByte()
        {
            EnsureAvailable(1, false);

            return buffer[offset++];
        }

        public byte[] ReadBytes(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount", "Amount cannot be negative");

            EnsureAvailable(amount, false);

            byte[] result = new byte[amount];

            Buffer.BlockCopy(buffer, offset, result, 0, amount);

            offset += amount;

            return result;
        }

        public sbyte ReadSByte()
        {
            return (sbyte)ReadByte();
        }

        public bool ReadBool()
        {
            return ReadByte() == ByteConverter.BOOL_TRUE;
        }

        public ushort ReadUShort()
        {
            return Read<ushort>();
        }

        public short ReadShort()
        {
            return Read<short>();
        }

        public char ReadChar()
        {
            return Read<char>();
        }

        public int ReadInt()
        {
            return Read<int>();
        }

        public uint ReadUInt()
        {
            return Read<uint>();
        }

        public float ReadFloat()
        {
            return Read<float>();
        }

        public long ReadLong()
        {
            return Read<long>();
        }

        public ulong ReadULong()
        {
            return Read<ulong>();
        }

        public double ReadDouble()
        {
            return Read<double>();
        }
        #endregion

        public static implicit operator byte[](DataBuffer dataBuffer)
        {
            return dataBuffer.buffer;
        }
    }
}
