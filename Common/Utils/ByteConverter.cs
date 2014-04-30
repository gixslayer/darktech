using System;
using System.Collections.Generic;

namespace DarkTech.Common.Utils
{
    /// <summary>
    /// Decodes a value in <paramref name="buffer"/> starting at <paramref name="offset"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value to decode.</typeparam>
    /// <param name="buffer">The buffer that contains the encoded data.</param>
    /// <param name="offset">The offset within the buffer to begin decoding from.</param>
    /// <returns>Returns the decoded value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
    public delegate T ConvertToDelegate<T>(byte[] buffer, int offset);

    /// <summary>
    /// Encodes a value in <paramref name="buffer"/> starting at <paramref name="offset"/>.
    /// </summary>
    /// <typeparam name="T">The type of value to encode.</typeparam>
    /// <param name="value">The value to encode.</param>
    /// <param name="buffer">The buffer to encode the value to.</param>
    /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
    public delegate void GetBytesDelegate<T>(T value, byte[] buffer, int offset);

    /// <summary>
    /// Provides methods to convert data types to and from bytes in little-endian order.
    /// </summary>
    public unsafe class ByteConverter
    {
        /// <summary>
        /// The byte used to indicate a true boolean value.
        /// </summary>
        public const byte BOOL_TRUE = 0xff;
        /// <summary>
        /// The byte used to indicate a false boolean value.
        /// </summary>
        public const byte BOOL_FALSE = 0x0;

        private static readonly Dictionary<Type, Delegate> CONVERT_TO_DELEGATE_MAPPING = new Dictionary<Type, Delegate>();
        private static readonly Dictionary<Type, Delegate> GET_BYTES_DELEGATE_MAPPING = new Dictionary<Type, Delegate>();
        private static readonly Dictionary<Type, int> SIZE_MAPPING = new Dictionary<Type, int>();

        static ByteConverter()
        {
            RegisterConvertToDelegate<bool>(ToBool);
            RegisterConvertToDelegate<char>(ToChar);
            RegisterConvertToDelegate<short>(ToShort);
            RegisterConvertToDelegate<ushort>(ToUShort);
            RegisterConvertToDelegate<int>(ToInt);
            RegisterConvertToDelegate<uint>(ToUInt);
            RegisterConvertToDelegate<float>(ToFloat);
            RegisterConvertToDelegate<long>(ToLong);
            RegisterConvertToDelegate<ulong>(ToULong);
            RegisterConvertToDelegate<double>(ToDouble);

            RegisterGetBytesDelegate<bool>(GetBytes);
            RegisterGetBytesDelegate<char>(GetBytes);
            RegisterGetBytesDelegate<short>(GetBytes);
            RegisterGetBytesDelegate<ushort>(GetBytes);
            RegisterGetBytesDelegate<int>(GetBytes);
            RegisterGetBytesDelegate<uint>(GetBytes);
            RegisterGetBytesDelegate<float>(GetBytes);
            RegisterGetBytesDelegate<long>(GetBytes);
            RegisterGetBytesDelegate<ulong>(GetBytes);
            RegisterGetBytesDelegate<double>(GetBytes);

            RegisterSize<byte>(1);
            RegisterSize<sbyte>(1);
            RegisterSize<bool>(1);
            RegisterSize<char>(2);
            RegisterSize<short>(2);
            RegisterSize<ushort>(2);
            RegisterSize<int>(4);
            RegisterSize<uint>(4);
            RegisterSize<float>(4);
            RegisterSize<long>(8);
            RegisterSize<ulong>(8);
            RegisterSize<double>(8);
        }

        /// <summary>
        /// Returns the encoded size of the <paramref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>Returns the encoded size of the <paramref name="T"/> type.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="T"/> has no associated mapping.
        /// </exception>
        public static int GetSize<T>()
        {
            Type type = typeof(T);

            if (!SIZE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Could not find size mapping for generic type");

            return SIZE_MAPPING[type];
        }

        #region Mapping
        /// <summary>
        /// Registers a <see cref="ConvertToDelegate{T}"/> for the <paramref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="convertToDelegate">The delegate that decodes the <paramref name="T"/> type.</param>
        /// <exception cref="ArgumentNullException">Thrown when the specified <paramref name="convertToDelegate"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="T"/> is already registered.</exception>
        public static void RegisterConvertToDelegate<T>(ConvertToDelegate<T> convertToDelegate)
        {
            if (convertToDelegate == null)
                throw new ArgumentNullException("convertToDelegate");

            Type type = typeof(T);

            if (CONVERT_TO_DELEGATE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Duplicate delegate registration for generic type");

            CONVERT_TO_DELEGATE_MAPPING.Add(type, convertToDelegate);
        }

        /// <summary>
        /// Registers a <see cref="GetBytesDelegate{T}"/> for the <paramref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="getBytesDelegate">The delegate that encodes the <paramref name="T"/> type.</param>
        /// /// <exception cref="ArgumentNullException">Thrown when the specified <paramref name="getBytesDelegate"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="T"/> is already registered.</exception>
        public static void RegisterGetBytesDelegate<T>(GetBytesDelegate<T> getBytesDelegate)
        {
            if (getBytesDelegate == null)
                throw new ArgumentNullException("getBytesDelegate");

            Type type = typeof(T);

            if (GET_BYTES_DELEGATE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Duplicate delegate registration for generic type");

            GET_BYTES_DELEGATE_MAPPING.Add(type, getBytesDelegate);
        }

        /// <summary>
        /// Registers the encoded size for the <paramref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="size">The encoded size in bytes for the <paramref name="T"/> type.</param>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="T"/> is already registered.</exception>
        public static void RegisterSize<T>(int size)
        {
            Type type = typeof(T);

            if (SIZE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Duplicate size registration for generic type");

            SIZE_MAPPING.Add(type, size);
        }

        /// <summary>
        /// Checks if the specified <paramref name="T"/> contains a delegate mapping.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <returns>Returns <c>true</c> if the specified <paramref name="T"/> contains a delegate mapping, otherwise <c>false</c> is returned.</returns>
        public static bool HasConvertToDelegate<T>()
        {
            return CONVERT_TO_DELEGATE_MAPPING.ContainsKey(typeof(T));
        }

        /// <summary>
        /// Checks if the specified <paramref name="T"/> contains a delegate mapping.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <returns>Returns <c>true</c> if the specified <paramref name="T"/> contains a delegate mapping, otherwise <c>false</c> is returned.</returns>
        public static bool HasGetBytesDelegate<T>()
        {
            return GET_BYTES_DELEGATE_MAPPING.ContainsKey(typeof(T));
        }

        /// <summary>
        /// Checks if the specified <paramref name="T"/> contains a size mapping.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <returns>Returns <c>true</c> if the specified <paramref name="T"/> contains a size mapping, otherwise <c>false</c> is returned.</returns>
        public static bool HasSize<T>()
        {
            return SIZE_MAPPING.ContainsKey(typeof(T));
        }
        #endregion

        #region GetBytes
        #region Return
        /// <summary>
        /// Encodes a <c>bool</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(bool value)
        {
            byte[] buffer = new byte[1];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        /// <summary>
        /// Encodes a <c>char</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(char value)
        {
            return GetBytes(*(ushort*)&value);
        }

        /// <summary>
        /// Encodes a <c>short</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(short value)
        {
            return GetBytes(*(ushort*)&value);
        }

        /// <summary>
        /// Encodes a <c>ushort</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(ushort value)
        {
            byte[] buffer = new byte[2];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        /// <summary>
        /// Encodes a <c>float</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(float value)
        {
            return GetBytes(*(uint*)&value);
        }

        /// <summary>
        /// Encodes a <c>int</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(int value)
        {
            return GetBytes(*(uint*)&value);
        }

        /// <summary>
        /// Encodes a <c>uint</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(uint value)
        {
            byte[] buffer = new byte[4];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        /// <summary>
        /// Encodes a <c>double</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(double value)
        {
            return GetBytes(*(ulong*)&value);
        }

        /// <summary>
        /// Encodes a <c>long</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(long value)
        {
            return GetBytes(*(ulong*)&value);
        }

        /// <summary>
        /// Encodes a <c>ulong</c> value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        public static byte[] GetBytes(ulong value)
        {
            byte[] buffer = new byte[8];

            GetBytes(value, buffer, 0);

            return buffer;
        }

        /// <summary>
        /// Encodes a value and returns the result in a <c>byte[]</c>.
        /// </summary>
        /// <typeparam name="T">The type of the value to encode.</typeparam>
        /// <param name="value">The value to encode.</param>
        /// <returns>Returns a <c>byte[]</c> containing the encoded value.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="T"/> has no associated mapping.</exception>
        public static byte[] GetBytes<T>(T value)
        {
            Type type = typeof(T);

            if (!SIZE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Could not find size mapping for generic type");

            byte[] buffer = new byte[SIZE_MAPPING[type]];

            GetBytes<T>(value, buffer, 0);

            return buffer;
        }
        #endregion

        #region Buffer
        /// <summary>
        /// Encodes a <c>bool</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(bool value, byte[] buffer, int offset)
        {
            buffer[offset] = value ? BOOL_TRUE : BOOL_FALSE;
        }

        /// <summary>
        /// Encodes a <c>char</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(char value, byte[] buffer, int offset)
        {
            GetBytes(*(ushort*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>short</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(short value, byte[] buffer, int offset)
        {
            GetBytes(*(ushort*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>ushort</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(ushort value, byte[] buffer, int offset)
        {
            buffer[offset++] = (byte)(value & 0xff);
            buffer[offset] = (byte)(value >> 8);
        }

        /// <summary>
        /// Encodes a <c>float</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(float value, byte[] buffer, int offset)
        {
            GetBytes(*(uint*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>int</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(int value, byte[] buffer, int offset)
        {
            GetBytes(*(uint*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>uint</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(uint value, byte[] buffer, int offset)
        {
            buffer[offset++] = (byte)(value & 0xff);
            buffer[offset++] = (byte)((value >> 8) & 0xff);
            buffer[offset++] = (byte)((value >> 16) & 0xff);
            buffer[offset++] = (byte)(value >> 24);
        }

        /// <summary>
        /// Encodes a <c>double</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(double value, byte[] buffer, int offset)
        {
            GetBytes(*(ulong*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>long</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        public static void GetBytes(long value, byte[] buffer, int offset)
        {
            GetBytes(*(ulong*)&value, buffer, offset);
        }

        /// <summary>
        /// Encodes a <c>ulong</c> value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
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

        /// <summary>
        /// Encodes a value to <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value to encode.</typeparam>
        /// <param name="value">The value to encode.</param>
        /// <param name="buffer">The buffer to encode to.</param>
        /// <param name="offset">The offset within the <paramref name="buffer"/> to encode to.</param>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="T"/> has no associated mapping.</exception>
        public static void GetBytes<T>(T value, byte[] buffer, int offset)
        {
            Type type = typeof(T);

            if (!GET_BYTES_DELEGATE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Could not find delegate mapping for generic type");

            GetBytesDelegate<T> getBytesDelegate = (GetBytesDelegate<T>)GET_BYTES_DELEGATE_MAPPING[type];

            getBytesDelegate(value, buffer, offset);
        }
        #endregion
        #endregion

        #region To
        /// <summary>Decodes a <c>bool</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>bool</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static bool ToBool(byte[] buffer, int offset)
        {
            return buffer[offset] == BOOL_TRUE;
        }

        /// <summary>Decodes a <c>char</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>char</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static char ToChar(byte[] buffer, int offset)
        {
            ushort temp = ToUShort(buffer, offset);

            return *(char*)&temp;
        }

        /// <summary>Decodes a <c>short</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>short</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static short ToShort(byte[] buffer, int offset)
        {
            ushort temp = ToUShort(buffer, offset);

            return *(short*)&temp;
        }

        /// <summary>Decodes a <c>ushort</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>ushort</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static ushort ToUShort(byte[] buffer, int offset)
        {
            ushort value = 0;

            value |= buffer[offset++];
            value |= (ushort)(buffer[offset] << 8);

            return value;
        }

        /// <summary>Decodes a <c>float</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>float</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static float ToFloat(byte[] buffer, int offset)
        {
            uint temp = ToUInt(buffer, offset);

            return *(float*)&temp;
        }

        /// <summary>Decodes a <c>int</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>int</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static int ToInt(byte[] buffer, int offset)
        {
            uint temp = ToUInt(buffer, offset);

            return *(int*)&temp;
        }

        /// <summary>Decodes a <c>uint</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>uint</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static uint ToUInt(byte[] buffer, int offset)
        {
            uint value = 0;

            value |= buffer[offset++];
            value |= (uint)buffer[offset++] << 8;
            value |= (uint)buffer[offset++] << 16;
            value |= (uint)buffer[offset] << 24;

            return value;
        }

        /// <summary>Decodes a <c>double</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>double</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static double ToDouble(byte[] buffer, int offset)
        {
            ulong temp = ToULong(buffer, offset);

            return *(double*)&temp;
        }

        /// <summary>Decodes a <c>long</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>long</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        public static long ToLong(byte[] buffer, int offset)
        {
            ulong temp = ToULong(buffer, offset);

            return *(long*)&temp;
        }

        /// <summary>Decodes a <c>ulong</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</summary>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded <c>ulong</c> value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
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

        /// <summary>
        /// Decodes a value in <paramref name="buffer"/> starting at <paramref name="offset"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value to decode.</typeparam>
        /// <param name="buffer">The buffer that contains the encoded data.</param>
        /// <param name="offset">The offset within the buffer to begin decoding from.</param>
        /// <returns>Returns the decoded value in <paramref name="buffer"/> starting at <paramref name="offset"/>.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="T"/> has no associated mapping.
        /// </exception>
        public static T To<T>(byte[] buffer, int offset)
        {
            Type type = typeof(T);

            if (!CONVERT_TO_DELEGATE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Could not find delegate mapping for generic type");

            ConvertToDelegate<T> convertDelegate = (ConvertToDelegate<T>)CONVERT_TO_DELEGATE_MAPPING[type];

            return convertDelegate(buffer, offset);
        }
        #endregion
    }
}
