using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockCharArray : BlockArray<char>
    {
        public BlockCharArray() : this(0) { }
        public BlockCharArray(int length) : base(BlockType.CharArray, length) { }

        protected override void SerializeElement(Stream stream, char element)
        {
            stream.WriteChar(element);
        }

        protected override char DeserializeElement(Stream stream)
        {
            return stream.ReadChar();
        }
    }
}
