using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockBoolArray : BlockArray<bool>
    {
        public BlockBoolArray() : this(0) { }
        public BlockBoolArray(int length) : base(BlockType.BoolArray, length) { }

        protected override void SerializeElement(Stream stream, bool element)
        {
            stream.WriteBool(element);
        }

        protected override bool DeserializeElement(Stream stream)
        {
            return stream.ReadBool();
        }
    }
}
