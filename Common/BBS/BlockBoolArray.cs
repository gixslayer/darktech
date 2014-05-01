using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockBoolArray : BlockArray<bool>
    {
        public BlockBoolArray() : this(0) { }
        public BlockBoolArray(int length) : base(BlockType.BoolArray, length) { }
        public BlockBoolArray(bool[] defaultValue) : base(BlockType.BoolArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, bool element)
        {
            stream.WriteBool(element);
        }

        protected override bool DeserializeElement(Stream stream)
        {
            return stream.ReadBool();
        }

        public override Block Clone()
        {
            return new BlockBoolArray(Value);
        }
    }
}
