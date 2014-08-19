using System;

namespace DarkTech.Common.IO
{
    public sealed class DataStreamException : Exception
    {
        public DataStreamException(string message) : base(message) { }

        internal static DataStreamException UnexpectedEOS(int expected, int found)
        {
            string msgPrefix = "Unexpected end of stream. Tried to read ";
            string msgBytes = expected == 1 ? "byte" : "bytes";
            string msgSuffix = " but only found ";

            return new DataStreamException(string.Concat(msgPrefix, expected, msgBytes, msgSuffix, found));
        }
    }
}
