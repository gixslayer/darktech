using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockUShortArray : BlockArray<ushort>
    {
        public BlockUShortArray() : this(0) { }
        public BlockUShortArray(int length) : base(BlockType.UShortArray, length) { }

        protected override void SerializeElement(Stream stream, ushort element)
        {
            stream.WriteUShort(element);
        }

        protected override ushort DeserializeElement(Stream stream)
        {
            return stream.ReadUShort();
        }
    }
}
