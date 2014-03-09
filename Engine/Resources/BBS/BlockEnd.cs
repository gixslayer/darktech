using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockEnd : Block
    {
        public static readonly BlockEnd INSTANCE = new BlockEnd();

        public BlockEnd() : base(BlockType.End) { }

        public override void Serialize(Stream stream) { }

        public override void Deserialize(Stream stream) { }
    }
}
