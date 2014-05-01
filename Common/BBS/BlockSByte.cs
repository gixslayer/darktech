using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockSByte : BlockData<sbyte>
    {
        public BlockSByte() : this(0) {}
        public BlockSByte(sbyte defaultValue) : base(BlockType.SByte, defaultValue) {}

        public override void Serialize(Stream stream)
        {
            stream.WriteSByte(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadSByte();
        }

        public override Block Clone()
        {
            return new BlockSByte(Value);
        }
    }
}
