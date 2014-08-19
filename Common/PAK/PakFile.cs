using System;
using System.IO;
using System.IO.Compression;

using DarkTech.Common.Containers;
using DarkTech.Common.IO;

namespace DarkTech.Common.PAK
{
    /// <summary>
    /// Provides access to a package.
    /// </summary>
    public sealed class PakFile
    {
        private readonly IMap<string, PakEntry> map;
        private readonly IList<PakEntry> entries;
        private readonly Stream stream;

        /// <summary>
        /// The amount of entries within the package file.
        /// </summary>
        public int EntryCount { get { return map.Count; } }
        /// <summary>
        /// The list of <see cref="PakEntry"/> entries within the package file.
        /// </summary>
        public IList<PakEntry> Entries { get { return entries; } }

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
            this.map = new HashMap<string, PakEntry>();
            this.entries = new ArrayList<PakEntry>();

            PakEntry entry;
            DataStream dataStream = new DataStream(stream);

            while (stream.Position < stream.Length)
            {
                try
                {
                    entry = PakEntry.Deserialize(dataStream);
                }
                catch (Exception e)
                {
                    throw new PakException(e.Message);
                }
            }
        }

        /// <summary>Returns the <see cref=" PakEntry"/> that is linked to the specified <paramref name="name"/>.</summary>
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

        /// <summary>Checks if an entry with the specified <paramref name="name"/> exists within the package.</summary>
        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns <c>true</c> if an entry with the specified <paramref name="name"/> exists within the package, otherwise <c>false</c> is returned./</returns>
        public bool HasEntry(string name)
        {
            return map.Contains(name);
        }

        /// <summary>Returns the <see cref="PakEntry"/> that is linked to the specified <paramref name="name"/>.</summary>
        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns the <see cref="PakEntry"/> that is linked to the specified <paramref name="name"/>.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="name"/> could not be found.
        /// </exception>
        public PakEntry GetEntry(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            return map[name];
        }

        /// <summary>Returns a stream that provides access to the package entry data.</summary>
        /// <param name="name">The name of the package entry.</param>
        /// <returns>Returns a stream that provides access to the package entry data.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="name"/> could not be found.
        /// </exception>
        public SubStream GetEntryStream(string name)
        {
            if (!HasEntry(name))
                throw new ArgumentException("Could not find entry", "name");

            PakEntry entry = GetEntry(name);

            return new SubStream(stream, entry.Offset, entry.Size);
        }

        /// <summary>Returns a list of all entries found within the <paramref name="stream"/>.</summary>
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
        public static IList<PakEntry> GetEntries(Stream stream)
        {
            IList<PakEntry> entries = new ArrayList<PakEntry>();
            DataStream dataStream = new DataStream(stream);

            while (stream.Position < stream.Length)
            {
                try
                {
                    entries.Add(PakEntry.Deserialize(dataStream));
                }
                catch (Exception e)
                {
                    throw new PakException(e.Message);
                }
            }

            return entries;
        }
    }
}
