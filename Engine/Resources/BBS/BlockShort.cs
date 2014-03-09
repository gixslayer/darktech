using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
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
    }
}
