using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockULongArray : BlockArray<ulong>
    {
        public BlockULongArray() : this(0) { }
        public BlockULongArray(int length) : base(BlockType.ULongArray, length) { }
        public BlockULongArray(ulong[] defaultValue) : base(BlockType.ULongArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, ulong element)
        {
            stream.WriteULong(element);
        }

        protected override ulong DeserializeElement(Stream stream)
        {
            return stream.ReadULong();
        }

        public override Block Clone()
        {
            return new BlockULongArray(Value);
        }
    }
}
