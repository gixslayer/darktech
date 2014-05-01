using System.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockNodeArray : BlockArray<BlockNode>
    {
        public BlockNodeArray() : this(0) { }
        public BlockNodeArray(int length) : base(BlockType.NodeArray, length) { }
        public BlockNodeArray(BlockNode[] defaultValue) : base(BlockType.NodeArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, BlockNode element)
        {
            element.Serialize(stream);
        }

        protected override BlockNode DeserializeElement(Stream stream)
        {
            BlockNode block = new BlockNode();

            block.Deserialize(stream);

            return block;
        }

        public override Block Clone()
        {
            return new BlockNodeArray(Value);
        }
    }
}
