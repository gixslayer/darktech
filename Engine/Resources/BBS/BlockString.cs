using System.IO;
using System.Text;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockString : BlockData<string>
    {
        public BlockString() : this(string.Empty) {}
        public BlockString(string defaultValue) : base(BlockType.String, defaultValue) {}

        public override bool Serialize(Stream stream)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(Value);
            int length = buffer.Length > 255 ? 255 : buffer.Length;

            stream.WriteByte((byte)length);
            stream.Write(buffer, 0, length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            int length = stream.ReadByte();

            if (length == -1)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            byte[] buffer = new byte[length];

            if (stream.Read(buffer, 0, length) != length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = Encoding.UTF8.GetString(buffer);

            return true;
        }
    }
}
