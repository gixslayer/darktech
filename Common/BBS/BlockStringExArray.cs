using System.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockStringExArray : BlockArray<BlockStringEx>
    {
        public BlockStringExArray() : this(0) { }
        public BlockStringExArray(int length) : base(BlockType.StringExArray, length) { }

        protected override void SerializeElement(Stream stream, BlockStringEx element)
        {
            element.Serialize(stream);
        }

        protected override BlockStringEx DeserializeElement(Stream stream)
        {
            BlockStringEx block = new BlockStringEx();

            block.Deserialize(stream);

            return block;
        }
    }
}
