using System;
using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.IO
{
    /// <summary>
    /// Provides a class to read/write primitive data types from a stream.
    /// </summary>
    public sealed class DataStream
    {
        private readonly Stream stream;

        /// <summary>
        /// The underlying stream from which data is read or written to.
        /// </summary>
        public Stream Stream
        {
            get { return stream; }
        }

        /// <summary>
        /// Gets or sets the position within the underlying stream.
        /// </summary>
        public long Position
        {
            get { return stream.Position; }
            set { stream.Position = value; }
        }

        /// <summary>
        /// Gets the length in bytes of the underlying stream.
        /// </summary>
        public long Length
        {
            get { return stream.Length; }
        }

        /// <summary>
        /// Creates a new DataStream object around a stream.
        /// </summary>
        /// <param name="stream">The underlying stream for the DataStream.</param>
        /// <remarks>
        /// The <paramref name="stream"/> cannot be null.
        /// The <paramref name="stream"/> isn't checked for the possibility to read/write before reading/writing.
        /// </remarks>
        public DataStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;
        }

        #region Read
        /// <summary>
        /// Reads the specified number of bytes into the buffer.
        /// </summary>
        /// <param name="buffer">The buffer to store the read bytes.</param>
        /// <param name="offset">The offset within the buffer to begin storing read bytes.</param>
        /// <param name="count">The number of bytes to read.</param>
        public void ReadBytes(byte[] buffer, int offset, int count)
        {
            int bytesRead = stream.Read(buffer, offset, count);

            // stream.Read returns an integer that specifies how many bytes were actually read.
            // This number does not have to match the number of bytes requested by the count parameter.
            // If there is a discrepancy then throw an exception to notify the user the stream might be corrupted.
            if (bytesRead != count)
            {
                throw DataStreamException.UnexpectedEOS(count, bytesRead);
            }
        }

        /// <summary>
        /// Reads the specified number of bytes into the buffer.
        /// </summary>
        /// <param name="buffer">The buffer to store the read bytes.</param>
        /// <param name="count">The number of bytes to read.</param>
        /// <remarks>
        /// This is identical to calling ReadBytes(buffer, 0, buffer.Length).
        /// </remarks>
        public void ReadBytes(byte[] buffer, int count)
        {
            ReadBytes(buffer, 0, count);
        }

        /// <summary>
        /// Reads the buffers length worth of bytes into the buffer.
        /// </summary>
        /// <param name="buffer">The buffer to store the read bytes.</param>
        /// <remarks>
        /// This is identical to calling ReadBytes(buffer, buffer.Length).
        /// </remarks>
        public void ReadBytes(byte[] buffer)
        {
            ReadBytes(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Reads the specified number of bytes into a newly allocated buffer and returns that buffer.
        /// </summary>
        /// <param name="count">The number of bytes to read.</param>
        /// <returns>A newly allocated buffer containing the read bytes.</returns>
        public byte[] ReadBytes(int count)
        {
            byte[] buffer = new byte[count];

            ReadBytes(buffer);

            return buffer;
        }

        /// <summary>
        /// Reads an unsigned byte from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public byte ReadByte()
        {
            int byteRead = stream.ReadByte();

            // If an attempt is made to read a byte at the end of the stream -1 is returned.
            if (byteRead == -1)
            {
                throw DataStreamException.UnexpectedEOS(1, 0);
            }

            return (byte)byteRead;
        }

        /// <summary>
        /// Reads a signed byte from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public sbyte ReadSByte()
        {
            return (sbyte)ReadByte();
        }

        /// <summary>
        /// Reads an boolean from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public bool ReadBool()
        {
            byte b = ReadByte();

            return b == ByteConverter.BOOL_TRUE;
        }

        /// <summary>
        /// Reads a signed short from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public short ReadShort()
        {
            return ByteConverter.ToShort(ReadBytes(2), 0);
        }

        /// <summary>
        /// Reads an unsigned short from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public ushort ReadUShort()
        {
            return ByteConverter.ToUShort(ReadBytes(2), 0);
        }

        /// <summary>
        /// Reads a character from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public char ReadChar()
        {
            return ByteConverter.ToChar(ReadBytes(2), 0);
        }

        /// <summary>
        /// Reads a float from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public float ReadFloat()
        {
            return ByteConverter.ToFloat(ReadBytes(4), 0);
        }

        /// <summary>
        /// Reads a signed int from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public int ReadInt()
        {
            return ByteConverter.ToInt(ReadBytes(4), 0);
        }

        /// <summary>
        /// Reads an unsigned byte from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public uint ReadUInt()
        {
            return ByteConverter.ToUInt(ReadBytes(4), 0);
        }

        /// <summary>
        /// Reads a double from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public double ReadDouble()
        {
            return ByteConverter.ToDouble(ReadBytes(8), 0);
        }

        /// <summary>
        /// Reads a signed long from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public long ReadLong()
        {
            return ByteConverter.ToLong(ReadBytes(8), 0);
        }

        /// <summary>
        /// Reads an unsigned long from the underlying stream.
        /// </summary>
        /// <returns>The value read from the underlying stream.</returns>
        public ulong ReadULong()
        {
            return ByteConverter.ToULong(ReadBytes(8), 0);
        }

        /// <summary>
        /// Reads a generic data type from the underlying stream.
        /// </summary>
        /// <typeparam name="T">The generic data type to read.</typeparam>
        /// <returns>The value read from the underlying stream.</returns>
        /// <remarks>
        /// The generic type must be registered in the static ByteConverter class to prevent throwing an ArgumentException.
        /// </remarks>
        public T Read<T>()
        {
            // GetSize<T> will throw an exception if no size
            // is registered for the generic type argument.
            int size = ByteConverter.GetSize<T>();
            byte[] buffer = ReadBytes(size);

            // To<T> will throw an exception if no conversion
            // delegate is registered for the generic type argument.
            return ByteConverter.To<T>(buffer, 0);
        }
        #endregion

        #region Write
        /// <summary>
        /// Writes the content of the specified buffer to the underlying stream.
        /// </summary>
        /// <param name="buffer">The buffer that contains the data to be written.</param>
        /// <param name="offset">The offset within the buffer to begin writing from.</param>
        /// <param name="count">The number of bytes to write to the underlying stream.</param>
        public void WriteBytes(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
        }

        /// <summary>
        /// Writes the content of the specified buffer to the underlying stream.
        /// </summary>
        /// <param name="buffer">The buffer that contains the data to be written.</param>
        /// <param name="count">The number of bytes to write to the underlying stream.</param>
        public void WriteBytes(byte[] buffer, int count)
        {
            WriteBytes(buffer, 0, count);
        }

        /// <summary>
        /// Writes the content of the specified buffer to the underlying stream.
        /// </summary>
        /// <param name="buffer">The buffer that contains the data to be written.</param>
        public void WriteBytes(byte[] buffer)
        {
            WriteBytes(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Writes an unsigned byte to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteByte(byte value)
        {
            stream.WriteByte(value);
        }

        /// <summary>
        /// Writes an signed byte to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteSByte(sbyte value)
        {
            WriteByte((byte)value);
        }

        /// <summary>
        /// Writes a boolean to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteBool(bool value)
        {
            WriteByte(value ? ByteConverter.BOOL_TRUE : ByteConverter.BOOL_FALSE);
        }

        /// <summary>
        /// Writes a signed short to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteShort(short value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes an unsigned short to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteUShort(ushort value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a character to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteChar(char value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a signed int to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteInt(int value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes an unsigned int to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteUInt(uint value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a float to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteFloat(float value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a signed long to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteLong(long value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes an unsigned long to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteULong(ulong value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a double to the underlying stream.
        /// </summary>
        /// <param name="value">The value to write to the underlying stream.</param>
        public void WriteDouble(double value)
        {
            WriteBytes(ByteConverter.GetBytes(value));
        }

        /// <summary>
        /// Writes a generic type to the underlying stream.
        /// </summary>
        /// <typeparam name="T">The generic type of the value to write.</typeparam>
        /// <param name="value">The value to write to the underlying stream.</param>
        /// <remarks>
        /// The generic type must be registered in the static ByteConverter class to prevent throwing an ArgumentException.
        /// </remarks>
        public void Write<T>(T value)
        {
            // ByteConverter.GetBytes<T> will throw an exception 
            // if no valid conversion delegate is registered.
            WriteBytes(ByteConverter.GetBytes<T>(value));
        }
        #endregion

        /// <summary>
        /// Disposes the underlying stream.
        /// </summary>
        public void Dispose()
        {
            stream.Dispose();
        }
    }
}
