using System.IO;

namespace DarkTech.Engine.Utils
{
    public static class StreamExtensions
    {
        public static bool SaveRead(this Stream stream, byte[] buffer)
        {
            return stream.Read(buffer, 0, buffer.Length) == buffer.Length;
        }

        public static bool SaveRead(this Stream stream, byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count) == count;
        }
    }
}
