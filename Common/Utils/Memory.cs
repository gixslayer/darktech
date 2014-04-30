namespace DarkTech.Common.Utils
{
    /// <summary>
    /// Provides access to several methods to handle pointer related code.
    /// </summary>
    public static unsafe class Memory
    {
        /// <summary>
        /// Copies <paramref name="count"/> bytes of data from <paramref name="source"/> to <paramref name="dest"/>.
        /// </summary>
        /// <param name="source">The source pointer.</param>
        /// <param name="dest">The destination pointer.</param>
        /// <param name="count">The amount of bytes to copy.</param>
        public static void Copy(void* source, void* dest, uint count)
        {
            byte* ptrSource = (byte*)source;
            byte* ptrDest = (byte*)dest;

            for (uint i = 0; i < count; i++)
            {
                *(ptrSource++) = *(ptrDest++);
            }
        }

        /// <summary>
        /// Copies <paramref name="count"/> bytes of data from <paramref name="source"/> offset by <paramref name="sourceOffset"/> bytes to <paramref name="dest"/> offset by <paramref name="destOffset"/> bytes.
        /// </summary>
        /// <param name="source">The source pointer.</param>
        /// <param name="sourceOffset">The offset to the source pointer in bytes.</param>
        /// <param name="dest">The destination pointer.</param>
        /// <param name="destOffset">The offset to the destination pointer in bytes.</param>
        /// <param name="count">The amount of bytes to copy.</param>
        public static void Copy(void* source, int sourceOffset, void* dest, int destOffset, uint count)
        {
            byte* ptrSource = (byte*)source;
            byte* ptrDest = (byte*)dest;

            ptrSource += sourceOffset;
            ptrDest += destOffset;

            for (uint i = 0; i < count; i++)
            {
                *(ptrSource++) = *(ptrDest++);
            }
        }

        /// <summary>
        /// Writes <paramref name="count"/> bytes of <paramref name="value"/> to the pointer starting at <paramref name="buffer"/>.
        /// </summary>
        /// <param name="buffer">The address to begin writing at.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="count">The amount of times to write the value.</param>
        public static void Set(void* buffer, byte value, uint count)
        {
            byte* ptrBuffer = (byte*)buffer;

            for (uint i = 0; i < count; i++)
            {
                *(ptrBuffer++) = value;
            }
        }

        /// <summary>
        /// Writes <paramref name="count"/> bytes of <paramref name="value"/> to the pointer starting at <paramref name="buffer"/> offset by <paramref name="offset"/> bytes.
        /// </summary>
        /// <param name="buffer">The address to begin writing at.</param>
        /// <param name="offset">The offset to the buffer in bytes.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="count">The amount of times to write the value.</param>
        public static void Set(void* buffer, int offset, byte value, uint count)
        {
            byte* ptrBuffer = (byte*)buffer;

            ptrBuffer += offset;

            for (uint i = 0; i < count; i++)
            {
                *(ptrBuffer++) = value;
            }
        }

        /// <param name="a">A pointer to data.</param>
        /// <param name="b">A pointer to data.</param>
        /// <param name="count">The amount of bytes to compare.</param>
        /// <returns>Returns a boolean value that indicates if the <paramref name="count"/> bytes starting at <paramref name="a"/> and <paramref name="b"/> are equal.</returns>
        public static bool Compare(void* a, void* b, uint count)
        {
            byte* ptrA = (byte*)a;
            byte* ptrB = (byte*)b;

            for (uint i = 0; i < count; i++)
            {
                if (*(ptrA++) != *(ptrB++))
                {
                    return false;
                }
            }

            return true;
        }

        /// <param name="a"></param>
        /// <param name="aOffset"></param>
        /// <param name="b"></param>
        /// <param name="bOffset"></param>
        /// <param name="count"></param>
        /// <returns>Returns a boolean value that indicates if the <paramref name="count"/> bytes starting at <paramref name="a"/> offset by <paramref name="aOffset"/> bytes and <paramref name="b"/> offset by <paramref name="bOffset"/> are equal.</returns>
        public static bool Compare(void* a, int aOffset, void* b, int bOffset, uint count)
        {
            byte* ptrA = (byte*)a;
            byte* ptrB = (byte*)b;

            ptrA += aOffset;
            ptrB += bOffset;

            for (uint i = 0; i < count; i++)
            {
                if (*(ptrA++) != *(ptrB++))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
