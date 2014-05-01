using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockUIntArray : BlockArray<uint>
    {
        public BlockUIntArray() : this(0) { }
        public BlockUIntArray(int length) : base(BlockType.UIntArray, length) { }
        public BlockUIntArray(uint[] defaultValue) : base(BlockType.UInt, defaultValue) { }

        protected override void SerializeElement(Stream stream, uint element)
        {
            stream.WriteUInt(element);
        }

        protected override uint DeserializeElement(Stream stream)
        {
            return stream.ReadUInt();
        }

        public override Block Clone()
        {
            return new BlockUIntArray(Value);
        }
    }
}
