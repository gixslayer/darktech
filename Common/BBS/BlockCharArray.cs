using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockCharArray : BlockArray<char>
    {
        public BlockCharArray() : this(0) { }
        public BlockCharArray(int length) : base(BlockType.CharArray, length) { }
        public BlockCharArray(char[] defaultValue) : base(BlockType.CharArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, char element)
        {
            stream.WriteChar(element);
        }

        protected override char DeserializeElement(Stream stream)
        {
            return stream.ReadChar();
        }

        public override Block Clone()
        {
            return new BlockCharArray(Value);
        }
    }
}
