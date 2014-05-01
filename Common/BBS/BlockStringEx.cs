using System.IO;
using System.Text;

using DarkTech.Common.IO;
using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockStringEx : BlockData<string>
    {
        private const byte ENCODING_UNKNOWN = 255;
        private static readonly LinkedMap<byte, Encoding> ENCODING_MAP = new LinkedMap<byte, Encoding>();

        static BlockStringEx()
        {
            ENCODING_MAP.Add(0, Encoding.ASCII);
            ENCODING_MAP.Add(1, Encoding.BigEndianUnicode);
            ENCODING_MAP.Add(2, Encoding.Unicode);
            ENCODING_MAP.Add(3, Encoding.UTF32);
            ENCODING_MAP.Add(4, Encoding.UTF7);
            ENCODING_MAP.Add(5, Encoding.UTF8);
        }

        public Encoding Encoding { get; set; }

        public BlockStringEx() : this(string.Empty, Encoding.UTF8) {}
        public BlockStringEx(string defaultValue) : this(defaultValue, Encoding.UTF8) {}

        public BlockStringEx(string defaultValue, Encoding encoding)
            : base(BlockType.StringEx, defaultValue)
        {
            this.Encoding = encoding;
        }

        public override void Serialize(Stream stream)
        {
            byte encoding = EncodingToByte(Encoding);

            if (encoding == ENCODING_UNKNOWN)
                throw new BBSException("Unknown encoding");

            byte[] buffer = Encoding.GetBytes(Value);

            int length = buffer.Length > ushort.MaxValue ? ushort.MaxValue : buffer.Length;

            stream.WriteByte(encoding);
            stream.WriteUShort((ushort)length);
            stream.Write(buffer, 0, length);
        }

        public override void Deserialize(Stream stream)
        {
            Encoding = ByteToEncoding(stream.ReadByteEx());

            if (Encoding == null)
                throw new BBSException("Unknown encoding");

            ushort length = stream.ReadUShort();
            byte[] buffer = new byte[length];

            if (!stream.SaveRead(buffer))
                throw BBSException.UNEXPECTED_EOS;

            Value = Encoding.GetString(buffer);
        }

        public override Block Clone()
        {
            return new BlockStringEx(Value);
        }

        private static byte EncodingToByte(Encoding encoding)
        {
            return ENCODING_MAP.ContainsValue(encoding) ? ENCODING_MAP.GetByValue(encoding) : ENCODING_UNKNOWN;
        }

        private static Encoding ByteToEncoding(byte value)
        {
            return ENCODING_MAP.ContainsKey(value) ? ENCODING_MAP.GetByKey(value) : null;
        }
    }
}
