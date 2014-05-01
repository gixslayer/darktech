using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockSByteArray : BlockArray<sbyte>
    {
        public BlockSByteArray() : this(0) { }
        public BlockSByteArray(int length) : base(BlockType.SByteArray, length) { }
        public BlockSByteArray(sbyte[] defaultValue) : base(BlockType.SByteArray, defaultValue) { }

        protected override void SerializeElement(Stream stream, sbyte element)
        {
            stream.WriteSByte(element);
        }

        protected override sbyte DeserializeElement(Stream stream)
        {
            return stream.ReadSByte();
        }

        public override Block Clone()
        {
            return new BlockSByteArray(Value);
        }
    }
}
