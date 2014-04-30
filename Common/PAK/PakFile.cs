using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

using DarkTech.Common.IO;

namespace DarkTech.Common.PAK
{
    /// <summary>
    /// Provides access to a package.
    /// </summary>
    public sealed class PakFile
    {
        private readonly Dictionary<string, PakEntry> entries;
        private readonly Stream stream;

        /// <summary>
        /// The amount of entries within the package file.
        /// </summary>
        public int EntryCount { get { return entries.Count; } }
        /// <summary>
        /// The collection of entry names within the package file.
        /// </summary>
        public Dictionary<string, PakEntry>.KeyCollection EntryNames { get { return entries.Keys; } }
        /// <summary>
        /// The collection of <see cref="PakEntry"/> entries within the package files.
        /// </summary>
        public Dictionary<string, PakEntry>.ValueCollection Entries { get { return entries.Values; } }

        /// <summary>
        /// Creates a new <see cref="PakFile"/> instance and loads the package from the source stream.
        /// </summary>
        /// <param name="stream">The source stream that contains the package data.</param>
        /// <exception cref="PakException">
        /// Thrown when the specified <paramref name="stream"/> could not be loaded.
        /// </exception>
        /// <remarks>
        /// The source stream must support the ability to read and seek.
        /// </remarks>
        public PakFile(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanRead)
                throw new ArgumentException("Stream must be able to read", "stream");
            if (!stream.CanSeek)
                throw new ArgumentException("Stream must be able to seek", "stream");

            this.stream = stream;
            this.entries = new Dictionary<string, PakEntry>();

            PakEntry entry;

            while (stream.Position < stream.Length)
            {
                try
                {
                    entry = PakEntry.Deserialize(stream);
                }
                catch (PakException e)
                {
                    throw e;
                }
                catch (StreamException e)
                {
                    throw new PakException(e.Message);
                }
                catch (Exception e)
                {
                    throw new PakException(e.Message);
                }

                // Only add the entry if it isn't marked as removed.
                if (!entry.Flags.HasFlag(PakEntryFlags.Removed))
                {
                    if (entries.ContainsKey(entry.Name))
                        throw PakException.DUPLICATE_ENTRY;

                    entries.Add(entry.Name, entry);
                }
            }
        }

        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns the <see cref="PakEntry"/> that is linked to the specified <paramref name="name"/>.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="name"/> could not be found.
        /// </exception>
        public PakEntry this[string name]
        {
            get { return GetEntry(name); }
        }

        /// <summary>
        /// Closes the package by disposing the underlying stream.
        /// </summary>
        /// <remarks>
        /// After this method is called no further calls should be made to <see cref="GetEntryStream(string)"/>.
        /// </remarks>
        public void Close()
        {
            stream.Dispose();
        }

        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns a boolean value that indicates if an entry with the name <paramref name="name"/> exists within the package./</returns>
        public bool HasEntry(string name)
        {
            return entries.ContainsKey(name);
        }

        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns the <see cref="PakEntry"/> that is linked to the specified <paramref name="name"/>.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="name"/> could not be found.
        /// </exception>
        public PakEntry GetEntry(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            return entries[name];
        }

        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns a stream that provides access to the package entry data.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="name"/> could not be found.
        /// </exception>
        /// <remarks>
        /// Depending on the <see cref="PakEntryFlags"/> the stream type returned can be a compression stream such as <see cref="DeflateStream"/> and <see cref="GZipStream"/>.
        /// </remarks>
        public Stream GetEntryStream(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            PakEntry entry = GetEntry(name);
            SubStream pakStream = new SubStream(stream, entry.Offset, entry.Size);

            return GetStreamForEntry(pakStream, entry);
        }

        /// <param name="stream">The source stream that contains the package data.</param>
        /// <exception cref="PakException">
        /// Thrown when the specified <paramref name="stream"/> could not be loaded.
        /// </exception>
        /// <remarks>
        /// The source stream must support the ability to read and seek.
        /// </remarks>
        /// <returns>
        /// Returns a list of all entries found within the <paramref name="stream"/>.
        /// </returns>
        public static List<PakEntry> GetEntries(Stream stream)
        {
            List<PakEntry> entries = new List<PakEntry>();

            while (stream.Position < stream.Length)
            {
                try
                {
                    entries.Add(PakEntry.Deserialize(stream));
                }
                catch (Exception e)
                {
                    throw new PakException(e.Message);
                }
            }

            return entries;
        }

        private static Stream GetStreamForEntry(SubStream stream, PakEntry entry)
        {
            if (entry.Flags.HasFlag(PakEntryFlags.Deflate))
            {
                return new DeflateStream(stream, CompressionMode.Decompress, true);
            }
            else if (entry.Flags.HasFlag(PakEntryFlags.GZip))
            {
                return new GZipStream(stream, CompressionMode.Decompress, true);
            }
            else
            {
                return stream;
            }
        }
    }
}
