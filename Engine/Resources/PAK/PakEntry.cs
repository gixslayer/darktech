using System.IO;
using System.Text;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.PAK
{
    /// <summary>
    /// An entry in a <see cref="PakFile"/>.
    /// </summary>
    public sealed class PakEntry
    {
        /// <summary>
        /// The unique name of the pak entry (a full relative path to the root of the pak file).
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The flags of the pak entry.
        /// </summary>
        public PakEntryFlags Flags { get; private set; }
        /// <summary>
        /// The size of the pak entry data (this excludes the meta-data described in the <see cref="PakEntry"/> class).
        /// </summary>
        public long Size { get; private set; }
        /// <summary>
        /// The offset within the source stream to the start of the data.
        /// </summary>
        public long Offset { get; private set; }

        private PakEntry() { }

        private void Serialize(Stream stream)
        {
            byte[] nameBuffer = Encoding.UTF8.GetBytes(Name);
            byte[] nameLengthBuffer = ByteConverter.GetBytes((ushort)nameBuffer.Length);
            byte[] sizeBuffer = ByteConverter.GetBytes((uint)Size);

            stream.Write(nameLengthBuffer, 0, nameLengthBuffer.Length);
            stream.Write(nameBuffer, 0, nameBuffer.Length);
            stream.WriteByte((byte)Flags);
            stream.Write(sizeBuffer, 0, sizeBuffer.Length);
        }

        public static bool Deserialize(Stream stream, out PakEntry entry)
        {
            entry = new PakEntry();

            // Deserialize the name.
            byte[] nameLengthBuffer = new byte[2];

            if (!stream.SaveRead(nameLengthBuffer))
            {
                return false;
            }

            ushort nameLength = ByteConverter.ToUShort(nameLengthBuffer, 0);

            // The name must be at least one character long.
            if (nameLength == 0)
            {
                return false;
            }

            byte[] nameBuffer = new byte[nameLength];

            if (!stream.SaveRead(nameBuffer))
            {
                return false;
            }

            entry.Name = Encoding.UTF8.GetString(nameBuffer);

            // Deserialize the flags.
            int iFlags = stream.ReadByte();

            if (iFlags == -1)
            {
                return false;
            }

            entry.Flags = (PakEntryFlags)iFlags;

            // Deserialize the size.
            byte[] sizeBuffer = new byte[4];

            if (!stream.SaveRead(sizeBuffer))
            {
                return false;
            }

            entry.Size = ByteConverter.ToUInt(sizeBuffer, 0);

            // Make sure the entry size is actually valid (must be at least one byte and lie within the source stream).
            if (entry.Size == 0 || stream.Position + entry.Size > stream.Length)
            {
                return false;
            }

            // Set the data offset to the current stream position.
            entry.Offset = stream.Position;

            return true;
        }

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
    }
}
