using System.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockListArray : BlockArray<BlockList>
    {
        public BlockListArray() : this(0) { }
        public BlockListArray(int length) : base(BlockType.ListArray, length) { }
        public BlockListArray(BlockList[] defaultValue) : base(BlockType.ListArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, BlockList element)
        {
            element.Serialize(stream);
        }

        protected override BlockList DeserializeElement(Stream stream)
        {
            BlockList block = new BlockList();

            block.Deserialize(stream);

            return block;
        }

        public override Block Clone()
        {
            return new BlockListArray(Value);
        }
    }
}
