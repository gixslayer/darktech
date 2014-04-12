using System;
using System.Collections.Generic;

namespace DarkTech.Common.Utils
{
    public unsafe class ByteConverter
    {
        public const byte BOOL_TRUE = 0xff;
        public const byte BOOL_FALSE = 0x0;

        private static readonly Dictionary<Type, Delegate> DELEGATE_MAPPING = new Dictionary<Type, Delegate>();
        private static readonly Dictionary<Type, int> SIZE_MAPPING = new Dictionary<Type, int>();

        private delegate T ToDelegate<T>(byte[] buffer, int offset);

        static ByteConverter()
        {
            DELEGATE_MAPPING.Add(typeof(bool), new ToDelegate<bool>(ToBool));
            DELEGATE_MAPPING.Add(typeof(char), new ToDelegate<char>(ToChar));
            DELEGATE_MAPPING.Add(typeof(short), new ToDelegate<short>(ToShort));
            DELEGATE_MAPPING.Add(typeof(ushort), new ToDelegate<ushort>(ToUShort));
            DELEGATE_MAPPING.Add(typeof(int), new ToDelegate<int>(ToInt));
            DELEGATE_MAPPING.Add(typeof(uint), new ToDelegate<uint>(ToUInt));
            DELEGATE_MAPPING.Add(typeof(float), new ToDelegate<float>(ToFloat));
            DELEGATE_MAPPING.Add(typeof(long), new ToDelegate<long>(ToLong));
            DELEGATE_MAPPING.Add(typeof(ulong), new ToDelegate<ulong>(ToULong));
            DELEGATE_MAPPING.Add(typeof(double), new ToDelegate<double>(ToDouble));

            SIZE_MAPPING.Add(typeof(byte), 1);
            SIZE_MAPPING.Add(typeof(sbyte), 1);
            SIZE_MAPPING.Add(typeof(bool), 1);
            SIZE_MAPPING.Add(typeof(char), 2);
            SIZE_MAPPING.Add(typeof(short), 2);
            SIZE_MAPPING.Add(typeof(ushort), 2);
            SIZE_MAPPING.Add(typeof(int), 4);
            SIZE_MAPPING.Add(typeof(uint), 4);
            SIZE_MAPPING.Add(typeof(float), 4);
            SIZE_MAPPING.Add(typeof(long), 8);
            SIZE_MAPPING.Add(typeof(ulong), 8);
            SIZE_MAPPING.Add(typeof(double), 8);
        }

        public static int GetSize<T>() where T : struct
        {
            if (!SIZE_MAPPING.ContainsKey(typeof(T)))
                throw new ArgumentException("Could not find size mapping for generic type");

            return SIZE_MAPPING[typeof(T)];
        }

        #region GetBytes
        #region Return
        public static byte[] GetBytes(bool value)
        {
            byte[] buffer = new byte[1];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        public static byte[] GetBytes(char value)
        {
            return GetBytes(*(ushort*)&value);
        }

        public static byte[] GetBytes(short value)
        {
            return GetBytes(*(ushort*)&value);
        }

        public static byte[] GetBytes(ushort value)
        {
            byte[] buffer = new byte[2];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        public static byte[] GetBytes(float value)
        {
            return GetBytes(*(uint*)&value);
        }

        public static byte[] GetBytes(int value)
        {
            return GetBytes(*(uint*)&value);
        }

        public static byte[] GetBytes(uint value)
        {
            byte[] buffer = new byte[4];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        public static byte[] GetBytes(double value)
        {
            return GetBytes(*(ulong*)&value);
        }

        public static byte[] GetBytes(long value)
        {
            return GetBytes(*(ulong*)&value);
        }

        public static byte[] GetBytes(ulong value)
        {
            byte[] buffer = new byte[8];

            GetBytes(value, buffer, 0);

            return buffer;
        }
        #endregion

        #region Buffer
        public static void GetBytes(bool value, byte[] buffer, int offset)
        {
            buffer[offset] = value ? BOOL_TRUE : BOOL_FALSE;
        }

        public static void GetBytes(char value, byte[] buffer, int offset)
        {
            GetBytes(*(ushort*)&value, buffer, offset);
        }

        public static void GetBytes(short value, byte[] buffer, int offset)
        {
            GetBytes(*(ushort*)&value, buffer, offset);
        }

        public static void GetBytes(ushort value, byte[] buffer, int offset)
        {
            buffer[offset++] = (byte)(value & 0xff);
            buffer[offset] = (byte)(value >> 8);
        }

        public static void GetBytes(float value, byte[] buffer, int offset)
        {
            GetBytes(*(uint*)&value, buffer, offset);
        }

        public static void GetBytes(int value, byte[] buffer, int offset)
        {
            GetBytes(*(uint*)&value, buffer, offset);
        }

        public static void GetBytes(uint value, byte[] buffer, int offset)
        {
            buffer[offset++] = (byte)(value & 0xff);
            buffer[offset++] = (byte)((value >> 8) & 0xff);
            buffer[offset++] = (byte)((value >> 16) & 0xff);
            buffer[offset++] = (byte)(value >> 24);
        }

        public static void GetBytes(double value, byte[] buffer, int offset)
        {
            GetBytes(*(ulong*)&value, buffer, offset);
        }

        public static void GetBytes(long value, byte[] buffer, int offset)
        {
            GetBytes(*(ulong*)&value, buffer, offset);
        }

        public static void GetBytes(ulong value, byte[] buffer, int offset)
        {
            buffer[offset++] = (byte)(value & 0xff);
            buffer[offset++] = (byte)((value >> 8) & 0xff);
            buffer[offset++] = (byte)((value >> 16) & 0xff);
            buffer[offset++] = (byte)((value >> 24) & 0xff);
            buffer[offset++] = (byte)((value >> 32) & 0xff);
            buffer[offset++] = (byte)((value >> 40) & 0xff);
            buffer[offset++] = (byte)((value >> 48) & 0xff);
            buffer[offset++] = (byte)(value >> 56);
        }
        #endregion
        #endregion

        #region To
        public static bool ToBool(byte[] buffer, int offset)
        {
            return buffer[offset] == BOOL_TRUE;
        }

        public static char ToChar(byte[] buffer, int offset)
        {
            ushort temp = ToUShort(buffer, offset);

            return *(char*)&temp;
        }

        public static short ToShort(byte[] buffer, int offset)
        {
            ushort temp = ToUShort(buffer, offset);

            return *(short*)&temp;
        }

        public static ushort ToUShort(byte[] buffer, int offset)
        {
            ushort value = 0;

            value |= buffer[offset++];
            value |= (ushort)(buffer[offset] << 8);

            return value;
        }

        public static float ToFloat(byte[] buffer, int offset)
        {
            uint temp = ToUInt(buffer, offset);

            return *(float*)&temp;
        }

        public static int ToInt(byte[] buffer, int offset)
        {
            uint temp = ToUInt(buffer, offset);

            return *(int*)&temp;
        }

        public static uint ToUInt(byte[] buffer, int offset)
        {
            uint value = 0;

            value |= buffer[offset++];
            value |= (uint)buffer[offset++] << 8;
            value |= (uint)buffer[offset++] << 16;
            value |= (uint)buffer[offset] << 24;

            return value;
        }

        public static double ToDouble(byte[] buffer, int offset)
        {
            ulong temp = ToULong(buffer, offset);

            return *(double*)&temp;
        }

        public static long ToLong(byte[] buffer, int offset)
        {
            ulong temp = ToULong(buffer, offset);

            return *(long*)&temp;
        }

        public static ulong ToULong(byte[] buffer, int offset)
        {
            ulong value = 0;

            value |= buffer[offset++];
            value |= (ulong)buffer[offset++] << 8;
            value |= (ulong)buffer[offset++] << 16;
            value |= (ulong)buffer[offset++] << 24;
            value |= (ulong)buffer[offset++] << 32;
            value |= (ulong)buffer[offset++] << 40;
            value |= (ulong)buffer[offset++] << 48;
            value |= (ulong)buffer[offset] << 56;

            return value;
        }

        public static T To<T>(byte[] buffer, int offset) where T : struct
        {
            if (!DELEGATE_MAPPING.ContainsKey(typeof(T)))
                throw new ArgumentException("Could not find delegate mapping for generic type");

            ToDelegate<T> del = (ToDelegate<T>)DELEGATE_MAPPING[typeof(T)];

            return del(buffer, offset);
        }
        #endregion
    }
}
