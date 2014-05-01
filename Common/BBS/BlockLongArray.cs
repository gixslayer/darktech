using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockLongArray : BlockArray<long>
    {
        public BlockLongArray() : this(0) { }
        public BlockLongArray(int length) : base(BlockType.LongArray, length) { }
        public BlockLongArray(long[] defaultValue) : base(BlockType.LongArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, long element)
        {
            stream.WriteLong(element);
        }

        protected override long DeserializeElement(Stream stream)
        {
            return stream.ReadLong();
        }

        public override Block Clone()
        {
            return new BlockLongArray(Value);
        }
    }
}
