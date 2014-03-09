using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockStringArray : BlockArray<BlockString>
    {
        public BlockStringArray() : this(0) { }
        public BlockStringArray(int length) : base(BlockType.StringArray, length) { }

        protected override void SerializeElement(Stream stream, BlockString element)
        {
            element.Serialize(stream);
        }

        protected override BlockString DeserializeElement(Stream stream)
        {
            BlockString block = new BlockString();

            block.Deserialize(stream);

            return block;
        }
    }
}
