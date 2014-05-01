using System.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockStringExArray : BlockArray<BlockStringEx>
    {
        public BlockStringExArray() : this(0) { }
        public BlockStringExArray(int length) : base(BlockType.StringExArray, length) { }
        public BlockStringExArray(BlockStringEx[] defaultValue) : base(BlockType.StringExArray, defaultValue) { }

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

        public override Block Clone()
        {
            return new BlockStringExArray(Value);
        }
    }
}
