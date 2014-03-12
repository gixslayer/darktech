using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockInt : BlockData<int>
    {
        public BlockInt() : this(0) { }
        public BlockInt(int defaultValue) : base(BlockType.Int, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteInt(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadInt();
        }
    }
}
