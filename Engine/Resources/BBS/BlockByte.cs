using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockByte : BlockData<byte>
    {
        public BlockByte() : this(0) {}
        public BlockByte(byte defaultValue) : base(BlockType.Byte, defaultValue) {}

        public override bool Serialize(Stream stream)
        {
            stream.WriteByte(Value);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            int iByte = stream.ReadByte();

            if (iByte == -1)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = (byte)iByte;

            return true;
        }
    }
}
