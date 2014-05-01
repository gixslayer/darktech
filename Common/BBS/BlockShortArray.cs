using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockShortArray : BlockArray<short>
    {
        public BlockShortArray() : this(0) { }
        public BlockShortArray(int length) : base(BlockType.ShortArray, length) { }
        public BlockShortArray(short[] defaultValue) : base(BlockType.ShortArray, defaultValue)  { }

        protected override void SerializeElement(Stream stream, short element)
        {
            stream.WriteShort(element);
        }

        protected override short DeserializeElement(Stream stream)
        {
            return stream.ReadShort();
        }

        public override Block Clone()
        {
            return new BlockShortArray(Value);
        }
    }
}
