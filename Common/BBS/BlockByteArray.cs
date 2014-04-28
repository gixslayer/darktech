using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockByteArray : BlockArray<byte>
    {
        public BlockByteArray() : this(0) { }
        public BlockByteArray(int length) : base(BlockType.ByteArray, length) { }

        protected override void SerializeElement(Stream stream, byte element)
        {
            stream.WriteByte(element);
        }

        protected override byte DeserializeElement(Stream stream)
        {
            return stream.ReadByteEx();
        }
    }
}
