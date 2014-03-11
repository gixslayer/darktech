using System.IO;
using System.Text;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.PAK
{
    public sealed class PakEntry
    {
        public string Name { get; private set; }
        public PakEntryFlags Flags { get; private set; }
        public long Size { get; private set; }
        public long Offset { get; private set; }

        private PakEntry(string name, PakEntryFlags flags, long size, long offset) 
        {
            this.Name = name;
            this.Flags = flags;
            this.Size = size;
            this.Offset = offset;
        }

        /*
        private void Serialize(Stream stream)
        {
            byte[] nameBuffer = Encoding.UTF8.GetBytes(Name);

            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);
            stream.WriteByte((byte)Flags);
            stream.WriteUInt((uint)Size);
        }
        */

        public static PakEntry Deserialize(Stream stream)
        {
            ushort nameLength = stream.ReadUShort();

            if (nameLength == 0)
                throw new PakException("Pak entry name cannot be 0 bytes long");

            byte[] nameBuffer = new byte[nameLength];

            if (!stream.SaveRead(nameBuffer))
                throw PakException.UNEXPECTED_EOS;

            string name = Encoding.UTF8.GetString(nameBuffer);
            PakEntryFlags flags = (PakEntryFlags)stream.ReadByteEx();
            long size = stream.ReadUInt();
            long offset = stream.Position;

            if (size == 0)
                throw new PakException("Pak entry size must be at least 0 bytes long");
            if (offset + size > stream.Length)
                throw new PakException("Pak entry size cannot exceed stream size");

            return new PakEntry(name, flags, size, offset);
        }

        /*
        public static void Serialize(Stream stream, Stream source, string name, PakEntryFlags flags)
        {
            // TODO: Compression support.

            PakEntry entry = new PakEntry();
            byte[] buffer = new byte[4096];

            entry.Name = name;
            entry.Flags = flags;
            entry.Size = source.Length;

            entry.Serialize(stream);

            while (source.Position < source.Length)
            {
                int bytesRead = source.Read(buffer, 0, buffer.Length);

                stream.Write(buffer, 0, bytesRead);
            }
        }

        public static bool StreamCopy(Stream source, Stream dest)
        {
            PakEntry entry;

            if (!Deserialize(source, out entry))
            {
                return false;
            }

            entry.Serialize(dest);

            byte[] buffer = new byte[4096];
            long remainder = entry.Size;
            int bytesToRead;

            while (remainder > 0)
            {
                bytesToRead = remainder > buffer.Length ? buffer.Length : (int)remainder;

                if (!source.SaveRead(buffer, 0, bytesToRead))
                {
                    return false;
                }

                dest.Write(buffer, 0, bytesToRead);

                remainder -= bytesToRead;
            }

            return true;
        }
        */
    }
}
