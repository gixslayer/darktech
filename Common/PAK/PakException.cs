using System;

namespace DarkTech.Common.PAK
{
    /// <summary>
    /// Represents errors that occur during package loading.
    /// </summary>
    public sealed class PakException : Exception
    {
        /// <summary>
        /// Represents a <see cref="PakException"/> that occurs when a duplicate package entry is detected.
        /// </summary>
        public static readonly PakException DUPLICATE_ENTRY = new PakException("Duplicate package entry");

        /// <summary>
        /// Initializes a new instance of the <see cref="PakException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public PakException(string message) : base(message) { }
    }
}
