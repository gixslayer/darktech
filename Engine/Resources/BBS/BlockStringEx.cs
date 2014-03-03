using System.IO;
using System.Text;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
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

        public override bool Serialize(Stream stream)
        {
            byte encoding = EncodingToByte(Encoding);

            if (encoding == ENCODING_UNKNOWN)
            {
                Block.ErrorMessage = "Unknown encoding type";

                return false;
            }

            byte[] buffer = Encoding.GetBytes(Value);
            byte[] lengthBuffer = ByteConverter.GetBytes((ushort)buffer.Length);

            stream.WriteByte(encoding);
            stream.Write(lengthBuffer, 0, lengthBuffer.Length);
            stream.Write(buffer, 0, buffer.Length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            int encodingByte = stream.ReadByte();

            if (encodingByte == -1)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Encoding = ByteToEncoding((byte)encodingByte);

            if (Encoding == null)
            {
                Block.ErrorMessage = "Unknown encoding type";

                return false;
            }

            byte[] lengthBuffer = new byte[2];

            if (stream.Read(lengthBuffer, 0, lengthBuffer.Length) != lengthBuffer.Length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            ushort length = ByteConverter.ToUShort(lengthBuffer, 0);

            byte[] buffer = new byte[length];

            if (stream.Read(buffer, 0, length) != length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = Encoding.GetString(buffer);

            return true;
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
