using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockULong : BlockData<ulong>
    {
        public BlockULong() : this(0uL) { }
        public BlockULong(ulong defaultValue) : base(BlockType.ULong, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteULong(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadULong();
        }
    }
}
