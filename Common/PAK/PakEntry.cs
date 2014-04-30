using System.IO;
using System.IO.Compression;
using System.Text;

using DarkTech.Common.IO;

namespace DarkTech.Common.PAK
{
    /// <summary>
    /// Represents an entry within a <see cref="PakFile"/>.
    /// </summary>
    public sealed class PakEntry
    {
        /// <summary>
        /// The encoding used for the <see cref="Name"/>.
        /// </summary>
        public static readonly Encoding ENCODING = Encoding.UTF8;

        private const byte PADDING = 0x0;

        /// <summary>
        /// The name of the package entry.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The bitwise flags of the package entry.
        /// </summary>
        public PakEntryFlags Flags { get; private set; }
        /// <summary>
        /// The size of the package entry data.
        /// </summary>
        /// <remarks>
        /// If the entry is compressed this represents the size of the compressed data.
        /// </remarks>
        public long Size { get; private set; }
        /// <summary>
        /// The offset to the start of the package entry data.
        /// </summary>
        public long Offset { get; private set; }

        private PakEntry(string name, PakEntryFlags flags, long size, long offset) 
        {
            this.Name = name;
            this.Flags = flags;
            this.Size = size;
            this.Offset = offset;
        }

        /// <summary>Checks if the bitwise combination of flags in <paramref name="flag"/> is set to the on state.</summary>
        /// <param name="flag">The bitwise combination of flags to test.</param>
        /// <returns>Returns <c>true</c> if the bitwise combination of flags in <paramref name="flag"/> is currently set, otherwise <c>false</c> is returned.</returns>
        public bool HasFlag(PakEntryFlags flag)
        {
            return (Flags & flag) == flag;
        }

        /// <summary>
        /// Sets the bitwise combination of flags in <paramref name="flag"/> to the on state.
        /// </summary>
        /// <param name="flag">The bitwise combination of flags to set.</param>
        public void SetFlag(PakEntryFlags flag)
        {
            Flags |= flag;
        }

        /// <summary>
        /// Sets the bitwise combination of flags in <paramref name="flag"/> to the off state.
        /// </summary>
        /// <param name="flag">The bitwise combination of flags to clear.</param>
        public void ClearFlag(PakEntryFlags flag)
        {
            Flags &= ~flag;
        }

        /// <summary>
        /// De-serializes a package entry from a stream and advances past the entry data.
        /// </summary>
        /// <param name="stream">The stream to deserialize from.</param>
        /// <returns>Returns a new <see cref="PakEntry"/> deserialized from the <paramref name="stream"/>.</returns>
        /// <remarks>
        /// Exceptions should be caught by the caller.
        /// </remarks>
        public static PakEntry Deserialize(Stream stream)
        {
            ushort nameLength = stream.ReadUShort();

            if (nameLength == 0)
                throw new PakException("Pak entry name cannot be 0 bytes long");

            byte[] nameBuffer = new byte[nameLength];

            if (!stream.SaveRead(nameBuffer))
                throw PakException.UNEXPECTED_EOS;

            string name = ENCODING.GetString(nameBuffer);
            PakEntryFlags flags = (PakEntryFlags)stream.ReadByteEx();
            long size = stream.ReadUInt();
            long offset = stream.Position;

            if (size < 0)
                throw new PakException("Pak entry size must be at least 0 bytes long");
            if (offset + size > stream.Length)
                throw new PakException("Pak entry size cannot exceed stream size");

            // Advance past the actual data.
            stream.Seek(size, SeekOrigin.Current);

            return new PakEntry(name, flags, size, offset);
        }

        /// <summary>
        /// Serializes a package entry to a stream.
        /// </summary>
        /// <param name="stream">The stream to serialize to.</param>
        /// <param name="source">The stream that contains the package entry data.</param>
        /// <param name="name">The name of the package entry.</param>
        /// <param name="flags">The flags of the package entry.</param>
        public static void Serialize(Stream stream, Stream source, string name, PakEntryFlags flags)
        {
            byte[] nameBuffer = ENCODING.GetBytes(name);

            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);
            stream.WriteByte((byte)flags);

            long sizeOffset = stream.Position;

            // Fill in the bytes so they can be overwritten later on.
            stream.WriteUInt(0);

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
