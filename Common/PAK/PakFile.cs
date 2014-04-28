using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

using DarkTech.Common.Utils;
using DarkTech.Common.IO;

namespace DarkTech.Common.PAK
{
    public sealed class PakFile
    {
        private readonly Dictionary<string, PakEntry> entries;
        private readonly Stream stream;

        public int EntryCount { get { return entries.Count; } }
        public Dictionary<string, PakEntry>.KeyCollection EntryNames { get { return entries.Keys; } }
        public Dictionary<string, PakEntry>.ValueCollection Entries { get { return entries.Values; } }

        public PakFile(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");

            this.stream = stream;
            this.entries = new Dictionary<string, PakEntry>();

            while (stream.Position < stream.Length)
            {
                PakEntry entry = PakEntry.Deserialize(stream);

                if (entries.ContainsKey(entry.Name))
                    throw new PakException("Duplicate pak entry");

                entries.Add(entry.Name, entry);

                // Advance past the actual data to reach the next entry/end of stream.
                stream.Seek(entry.Size, SeekOrigin.Current);
            }
        }

        public void Close()
        {
            stream.Close();
            stream.Dispose();
        }

        public bool HasEntry(string name)
        {
            return entries.ContainsKey(name);
        }

        public PakEntry GetEntry(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            return entries[name];
        }

        public Stream GetEntryStream(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            PakEntry entry = GetEntry(name);
            SubStream pakStream = new SubStream(stream, entry.Offset, entry.Size);

            if (entry.Flags.HasFlag(PakEntryFlags.Deflate))
            {
                return new DeflateStream(pakStream, CompressionMode.Decompress, true);
            }
            else if (entry.Flags.HasFlag(PakEntryFlags.GZip))
            {
                return new GZipStream(pakStream, CompressionMode.Decompress, true);
            }
            else
            {
                return pakStream;
            }
        }

        public void Extract(PakEntry entry, Stream dest)
        {
            stream.Position = entry.Offset;
            byte[] buffer = new byte[4096];
            long bytesRemaining = entry.Size;

            while (bytesRemaining > 0)
            {
                int bytesToRead = bytesRemaining < buffer.Length ? (int)bytesRemaining : buffer.Length;

                stream.Read(buffer, 0, bytesToRead);

                dest.Write(buffer, 0, bytesToRead);

                bytesRemaining -= bytesToRead;
            }
        }
    }
}
