using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockChar : BlockData<char>
    {
        private const char DEFAULT_VALUE = '\x0';

        public BlockChar() : this(DEFAULT_VALUE) {}
        public BlockChar(char defaultValue) : base(BlockType.Char, defaultValue) {}

        public override bool Serialize(Stream stream)
        {
            byte[] buffer = ByteConverter.GetBytes(Value);

            stream.Write(buffer, 0, buffer.Length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            byte[] buffer = new byte[2];

            if (stream.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = ByteConverter.ToChar(buffer, 0);

            return true;
        }
    }
}
