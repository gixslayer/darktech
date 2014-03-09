using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockUIntArray : BlockArray<uint>
    {
        public BlockUIntArray() : this(0) { }
        public BlockUIntArray(int length) : base(BlockType.UIntArray, length) { }

        protected override void SerializeElement(Stream stream, uint element)
        {
            stream.WriteUInt(element);
        }

        protected override uint DeserializeElement(Stream stream)
        {
            return stream.ReadUInt();
        }
    }
}
