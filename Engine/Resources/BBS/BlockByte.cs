using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
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
    }
}
