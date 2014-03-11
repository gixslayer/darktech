using System;
using System.Collections.Generic;
using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.PAK
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
            PakStream pakStream = new PakStream(stream, entry.Offset, entry.Size);

            switch (entry.Flags)
            {
                case PakEntryFlags.None:
                    return pakStream;

                default:
                    throw new InvalidOperationException("Unknown pak entry flags");
            }
        }

        /*
        public bool Extract(string name, out byte[] dest)
        {
            // TODO: Compression support.

            dest = null;

            if (!HasEntry(name))
            {
                return false;
            }

            PakEntry entry = GetEntry(name);

            stream.Position = entry.Offset;

            dest = new byte[entry.Size];
            long remainder = entry.Size;
            int offset = 0;
            int bytesToRead;

            while (remainder > 0)
            {
                bytesToRead = remainder > 4096 ? 4096 : (int)remainder;

                stream.Read(dest, offset, bytesToRead);

                offset += bytesToRead;
                remainder -= bytesToRead;
            }

            return true;
        }

        public bool Extract(string name, byte[] dest, int offset)
        {
            // TODO: Compression support.

            if (!HasEntry(name))
            {
                return false;
            }

            PakEntry entry = GetEntry(name);

            if (offset + entry.Size > dest.Length)
            {
                return false;
            }

            stream.Position = entry.Offset;

            long remainder = entry.Size;
            int bytesToRead;

            while (remainder > 0)
            {
                bytesToRead = remainder > 4096 ? 4096 : (int)remainder;

                stream.Read(dest, offset, bytesToRead);

                offset += bytesToRead;
                remainder -= bytesToRead;
            }

            return true;
        }

        public bool Extract(string name, Stream dest)
        {
            if (!HasEntry(name))
            {
                return false;
            }

            PakEntry entry = GetEntry(name);

            stream.Position = entry.Offset;

            byte[] buffer = new byte[4096];
            long remainder = entry.Size;
            int bytesToRead;

            while (remainder > 0)
            {
                bytesToRead = remainder > buffer.Length ? buffer.Length : (int)remainder;

                if (!stream.SaveRead(buffer, 0, bytesToRead))
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
