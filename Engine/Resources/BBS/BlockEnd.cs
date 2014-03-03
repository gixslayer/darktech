using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockEnd : Block
    {
        public BlockEnd() : base(BlockType.End) { }

        public override bool Serialize(Stream stream)
        {
            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            return true;
        }
    }
}
