using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockByte : BlockData<byte>
    {
        public BlockByte() : this(0) {}
        public BlockByte(byte defaultValue) : base(BlockType.Byte, defaultValue) {}

        public override void Serialize(Stream stream)
        {
            stream.WriteByte(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadByteEx();
        }

        public override Block Clone()
        {
            return new BlockByte(Value);
        }
    }
}
