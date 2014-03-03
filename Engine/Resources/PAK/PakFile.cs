using System.Collections.Generic;
using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.PAK
{
    public sealed class PakFile
    {
        private readonly Dictionary<string, PakEntry> entries;
        private Stream stream;

        public int EntryCount { get { return entries.Count; } }

        public PakFile()
        {
            this.entries = new Dictionary<string, PakEntry>();
        }

        public bool Load(Stream stream)
        {
            entries.Clear();
            this.stream = stream;

            while (stream.Position < stream.Length)
            {
                PakEntry entry;

                if (!PakEntry.Deserialize(stream, out entry))
                {
                    return false;
                }

                // Duplicate entry names are not allowed.
                if (entries.ContainsKey(entry.Name))
                {
                    return false;
                }

                // Advance past the actual data to potentially reach the next entry.
                stream.Seek(entry.Size, SeekOrigin.Current);

                entries.Add(entry.Name, entry);
            }

            return true;
        }

        public void Close()
        {
            if (stream != null)
            {
                stream.Close();
                stream.Dispose();
            }
        }

        public bool HasEntry(string name)
        {
            return entries.ContainsKey(name);
        }

        public PakEntry GetEntry(string name)
        {
            if (!HasEntry(name))
            {
                return null;
            }

            return entries[name];
        }

        public string[] GetEntryNames()
        {
            string[] buffer = new string[entries.Count];

            entries.Keys.CopyTo(buffer, 0);

            return buffer;
        }

        public PakEntry[] GetEntries()
        {
            PakEntry[] buffer = new PakEntry[entries.Count];

            entries.Values.CopyTo(buffer, 0);

            return buffer;
        }

        public PakStream GetEntryStream(string name)
        {
            if (!HasEntry(name))
            {
                return null;
            }

            PakEntry entry = GetEntry(name);

            return new PakStream(stream, entry.Offset, entry.Size);
        }

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
    }
}
