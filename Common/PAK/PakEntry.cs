using System.IO;
using System.IO.Compression;
using System.Text;

using DarkTech.Common.Utils;
using DarkTech.Common.IO;

namespace DarkTech.Common.PAK
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

            // Read the padding (if any).
            if (flags.HasFlag(PakEntryFlags.Padded))
            {
                ReadPadding(stream);
            }

            long size = stream.ReadUInt();
            long offset = stream.Position;

            if (size < 0)
                throw new PakException("Pak entry size must be at least 0 bytes long");
            if (offset + size > stream.Length)
                throw new PakException("Pak entry size cannot exceed stream size");

            return new PakEntry(name, flags, size, offset);
        }

        private static void ReadPadding(Stream stream)
        {
            byte lowByte = stream.ReadByteEx();

            if (lowByte == 0)
            {
                return;
            }

            byte highByte = stream.ReadByteEx();

            int paddingLength = lowByte + highByte * 256;
        }

        private static void WritePadding(Stream stream, int padding)
        {
            if (padding <= 0)
                throw new System.ArgumentOutOfRangeException("padding");

            if (padding <= 256)
            {
                int zeroPadding = padding - 1;

                // Write how many zero bytes padding follow (0-255).
                stream.WriteByte((byte)zeroPadding);

                for (int i = 0; i < zeroPadding; i++)
                {
                    stream.WriteByte(0);
                }
            }
        }

        public static void Serialize(Stream stream, Stream source, string name, PakEntryFlags flags)
        {
            byte[] buffer = new byte[4096];
            byte[] nameBuffer = Encoding.UTF8.GetBytes(name);

            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);
            stream.WriteByte((byte)flags);

            long sizeOffset = stream.Position;

            stream.WriteUInt(0); // Fill in the bytes so they can be overwritten later on.

            Stream dest = CreateDestStream(stream, flags);

            source.CopyTo(dest);

            // If a compression stream was used make sure it is flushed and closed properly.
            if (dest != stream)
            {
                dest.Flush();
                dest.Close();
                dest.Dispose();
            }

            // Calculate how many bytes were written to the stream.
            uint size = (uint)(stream.Position - (sizeOffset + 4));

            // Write the correct size.
            stream.Position = sizeOffset;
            stream.WriteUInt(size);
            stream.Position = stream.Length;
        }

        private static Stream CreateDestStream(Stream stream, PakEntryFlags flags)
        {
            if (flags.HasFlag(PakEntryFlags.Deflate))
            {
                return new DeflateStream(stream, CompressionLevel.Optimal, true);
            }
            else if (flags.HasFlag(PakEntryFlags.GZip))
            {
                return new GZipStream(stream, CompressionLevel.Optimal, true);
            }
            else
            {
                return stream;
            }
        }
    }
}
