using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.IO
{
    public static class StreamExtensions
    {
        public static bool SaveRead(this Stream stream, byte[] buffer)
        {
            return stream.Read(buffer, 0, buffer.Length) == buffer.Length;
        }

        public static bool SaveRead(this Stream stream, byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count) == count;
        }

        public static void Write(this Stream stream, byte[] buffer)
        {
            stream.Write(buffer, 0, buffer.Length);
        }

        public static byte[] ReadBytes(this Stream stream, int count)
        {
            if (count < 0)
                throw new System.ArgumentOutOfRangeException("count");

            byte[] buffer = new byte[count];

            if (!SaveRead(stream, buffer))
                throw StreamException.UNEXPECTED_EOS;

            return buffer;
        }

        public static byte ReadByteEx(this Stream stream)
        {
            int iByte = stream.ReadByte();

            if (iByte == -1)
                throw StreamException.UNEXPECTED_EOS;

            return (byte)iByte;
        }

        public static sbyte ReadSByte(this Stream stream)
        {
            return (sbyte)stream.ReadByteEx();
        }

        public static short ReadShort(this Stream stream)
        {
            byte[] buffer = new byte[2];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToShort(buffer, 0);
        }

        public static ushort ReadUShort(this Stream stream)
        {
            byte[] buffer = new byte[2];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToUShort(buffer, 0);
        }

        public static int ReadInt(this Stream stream)
        {
            byte[] buffer = new byte[4];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToInt(buffer, 0);
        }

        public static uint ReadUInt(this Stream stream)
        {
            byte[] buffer = new byte[4];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToUInt(buffer, 0);
        }

        public static long ReadLong(this Stream stream)
        {
            byte[] buffer = new byte[8];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToLong(buffer, 0);
        }

        public static ulong ReadULong(this Stream stream)
        {
            byte[] buffer = new byte[8];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToULong(buffer, 0);
        }

        public static float ReadFloat(this Stream stream)
        {
            byte[] buffer = new byte[4];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToFloat(buffer, 0);
        }

        public static double ReadDouble(this Stream stream)
        {
            byte[] buffer = new byte[8];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToDouble(buffer, 0);
        }

        public static bool ReadBool(this Stream stream)
        {
            byte b = stream.ReadByteEx();

            return ByteConverter.ToBool(new byte[] { b }, 0);
        }

        public static char ReadChar(this Stream stream)
        {
            byte[] buffer = new byte[2];

            if (!stream.SaveRead(buffer))
                throw StreamException.UNEXPECTED_EOS;

            return ByteConverter.ToChar(buffer, 0);
        }

        public static void WriteSByte(this Stream stream, sbyte value)
        {
            stream.WriteByte((byte)value);
        }

        public static void WriteBool(this Stream stream, bool value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteChar(this Stream stream, char value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteShort(this Stream stream, short value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteUShort(this Stream stream, ushort value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteInt(this Stream stream, int value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteUInt(this Stream stream, uint value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteLong(this Stream stream, long value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteULong(this Stream stream, ulong value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteFloat(this Stream stream, float value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        public static void WriteDouble(this Stream stream, double value)
        {
            stream.Write(ByteConverter.GetBytes(value));
        }

        /*public static uint CopyToEx(this Stream stream, Stream dest)
        {
            uint bytesWritten = 0;
            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                dest.Write(buffer, 0, bytesRead);

                bytesWritten += (uint)bytesRead;
            }

            return bytesWritten;
        }*/
    }
}
