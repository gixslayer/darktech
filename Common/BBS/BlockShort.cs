using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockShort : BlockData<short>
    {
        public BlockShort() : this(0) { }
        public BlockShort(short defaultValue) : base(BlockType.Short, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteShort(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadShort();
        }

        public override Block Clone()
        {
            return new BlockShort(Value);
        }
    }
}
