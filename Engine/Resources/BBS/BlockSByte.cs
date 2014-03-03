using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockSByte : BlockData<sbyte>
    {
        public BlockSByte() : this(0) {}
        public BlockSByte(sbyte defaultValue) : base(BlockType.SByte, defaultValue) {}

        public override bool Serialize(Stream stream)
        {
            stream.WriteByte((byte)Value);

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

            Value = (sbyte)iByte;

            return true;
        }
    }
}
