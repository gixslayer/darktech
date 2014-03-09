using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
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
