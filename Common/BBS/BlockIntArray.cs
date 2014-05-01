using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockIntArray : BlockArray<int>
    {
        public BlockIntArray() : this(0) { }
        public BlockIntArray(int length) : base(BlockType.IntArray, length) { }
        public BlockIntArray(int[] defaultValue) : base(BlockType.IntArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, int element)
        {
            stream.WriteInt(element);
        }

        protected override int DeserializeElement(Stream stream)
        {
            return stream.ReadInt();
        }

        public override Block Clone()
        {
            return new BlockIntArray(Value);
        }
    }
}
