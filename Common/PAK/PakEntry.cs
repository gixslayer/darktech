using System.IO;
using System.IO.Compression;
using System.Text;

using DarkTech.Common.Utils;

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
            long size = stream.ReadUInt();
            long offset = stream.Position;

            if (size == 0)
                throw new PakException("Pak entry size must be at least 0 bytes long");
            if (offset + size > stream.Length)
                throw new PakException("Pak entry size cannot exceed stream size");

            return new PakEntry(name, flags, size, offset);
        }

        public static void Serialize(Stream stream, Stream source, string name, PakEntryFlags flags)
        {
            byte[] buffer = new byte[4096];
            byte[] nameBuffer = Encoding.UTF8.GetBytes(name);

            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);
            stream.WriteByte((byte)flags);

            long sizeOffset = stream.Position;
            Stream destStream;

            if (flags.HasFlag(PakEntryFlags.Deflate))
            {
                destStream = new DeflateStream(new SubStream(stream, stream.Position), CompressionLevel.Optimal, true);
            }
            else if (flags.HasFlag(PakEntryFlags.GZip))
            {
                destStream = new GZipStream(new SubStream(stream, stream.Position), CompressionLevel.Optimal, true);
            }
            else
            {
                destStream = stream;
            }

            uint size = source.CopyToEx(destStream);

            stream.Position = sizeOffset;
            stream.WriteUInt(size);

            if (destStream != stream)
            {
                destStream.Dispose();
            }
        }
    }
}
