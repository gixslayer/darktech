using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockListArray : BlockArray<BlockList>
    {
        public BlockListArray() : this(0) { }
        public BlockListArray(int length) : base(BlockType.ListArray, length) { }

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
    }
}
