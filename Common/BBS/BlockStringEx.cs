using System.IO;
using System.Text;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockStringEx : BlockData<string>
    {
        private const byte ENCODING_UNKNOWN = 255;

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

            stream.WriteByte(encoding);
            stream.WriteUShort((ushort)buffer.Length);
            stream.Write(buffer);
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

        // TODO: Fix this ugly code.
        private static byte EncodingToByte(Encoding encoding)
        {
            if(encoding == Encoding.ASCII) 
            {
                return 0;
            }
            else if (encoding == Encoding.BigEndianUnicode)
            {
                return 1;
            }
            else if (encoding == Encoding.Unicode)
            {
                return 2;
            }
            else if (encoding == Encoding.UTF32)
            {
                return 3;
            }
            else if (encoding == Encoding.UTF7)
            {
                return 4;
            }
            else if (encoding == Encoding.UTF8)
            {
                return 5;
            }

            // Unknown encoding.
            return ENCODING_UNKNOWN;
        }

        // TODO: Fix this ugly code.
        private static Encoding ByteToEncoding(byte value)
        {
            switch (value)
            {
                case 0:
                    return Encoding.ASCII;

                case 1:
                    return Encoding.BigEndianUnicode;

                case 2:
                    return Encoding.Unicode;

                case 3:
                    return Encoding.UTF32;

                case 4:
                    return Encoding.UTF7;

                case 5:
                    return Encoding.UTF8;

                default:
                    // Unknown encoding.
                    return null;
            }
        }
    }
}
