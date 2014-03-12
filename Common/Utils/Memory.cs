namespace DarkTech.Common.Utils
{
    public static unsafe class Memory
    {
        public static void Copy(void* source, void* dest, uint count)
        {
            byte* ptrSource = (byte*)source;
            byte* ptrDest = (byte*)dest;

            for (uint i = 0; i < count; i++)
            {
                *(ptrSource++) = *(ptrDest++);
            }
        }

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

        public static void Set(void* buffer, byte value, uint count)
        {
            byte* ptrBuffer = (byte*)buffer;

            for (uint i = 0; i < count; i++)
            {
                *(ptrBuffer++) = value;
            }
        }

        public static void Set(void* buffer, int offset, byte value, uint count)
        {
            byte* ptrBuffer = (byte*)buffer;

            ptrBuffer += offset;

            for (uint i = 0; i < count; i++)
            {
                *(ptrBuffer++) = value;
            }
        }

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
