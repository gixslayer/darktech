using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockFloat : BlockData<float>
    {
        public BlockFloat() : this(0f) { }
        public BlockFloat(float defaultValue) : base(BlockType.Float, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteFloat(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadFloat();
        }

        public override Block Clone()
        {
            return new BlockFloat(Value);
        }
    }
}
