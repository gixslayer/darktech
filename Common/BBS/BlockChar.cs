using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockChar : BlockData<char>
    {
        private const char DEFAULT_VALUE = '\x0';

        public BlockChar() : this(DEFAULT_VALUE) {}
        public BlockChar(char defaultValue) : base(BlockType.Char, defaultValue) {}

        public override void Serialize(Stream stream)
        {
            stream.WriteChar(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadChar();
        }
    }
}
