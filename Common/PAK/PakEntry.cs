using System.IO;
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

        /// <summary>
        /// The name of the package entry.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The size of the package entry data.
        /// </summary>
        public long Size { get; private set; }
        /// <summary>
        /// The offset to the start of the package entry data.
        /// </summary>
        public long Offset { get; private set; }

        private PakEntry(string name, long size, long offset) 
        {
            this.Name = name;
            this.Size = size;
            this.Offset = offset;
        }

        /// <summary>
        /// De-serializes a package entry from a stream and advances past the entry data.
        /// </summary>
        /// <param name="stream">The stream to deserialize from.</param>
        /// <returns>Returns a new <see cref="PakEntry"/> deserialized from the <paramref name="stream"/>.</returns>
        /// <remarks>
        /// Exceptions should be caught by the caller.
        /// </remarks>
        public static PakEntry Deserialize(DataStream stream)
        {
            // Read the length of the encoded name data.
            ushort nameLength = stream.ReadUShort();

            // Validate the name data is at least one byte long.
            if (nameLength == 0)
                throw new PakException("Pak entry name cannot be 0 bytes long");

            // Read the encoded name data.
            byte[] nameBuffer = stream.ReadBytes(nameLength);

            // Decode the name and set/read the rest of the properties.
            string name = ENCODING.GetString(nameBuffer);
            long size = stream.ReadUInt();
            long offset = stream.Position;

            // Validate that the entry data does not exceed the stream.
            if (offset + size > stream.Length)
                throw new PakException("Pak entry size cannot exceed stream size");

            // Advance past the actual entry data.
            stream.Position += size;

            return new PakEntry(name, size, offset);
        }

        /// <summary>
        /// Serializes a package entry to a stream.
        /// </summary>
        /// <param name="stream">The stream to serialize to.</param>
        /// <param name="source">The stream that contains the package entry data.</param>
        /// <param name="name">The name of the package entry.</param>
        public static void Serialize(DataStream stream, Stream source, string name)
        {
            // Encode the name to a buffer.
            byte[] nameBuffer = ENCODING.GetBytes(name);

            // Write the name buffer to the output stream.
            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);

            // Write the entry size to the output stream.
            stream.WriteUInt((uint)source.Length);

            // Copy the source data to the output stream.
            source.CopyTo(stream.Stream);
        }
    }
}
