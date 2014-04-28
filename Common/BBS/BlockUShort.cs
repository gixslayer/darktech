using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockUShort : BlockData<ushort>
    {
        public BlockUShort() : this(0) { }
        public BlockUShort(ushort defaultValue) : base(BlockType.UShort, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteUShort(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadUShort();
        }
    }
}
