using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockLong : BlockData<long>
    {
        public BlockLong() : this(0L) { }
        public BlockLong(long defaultValue) : base(BlockType.Long, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteLong(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadLong();
        }
    }
}
