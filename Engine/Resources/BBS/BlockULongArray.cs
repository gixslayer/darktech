using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockULongArray : BlockArray<ulong>
    {
        public BlockULongArray() : this(0) { }
        public BlockULongArray(int length) : base(BlockType.ULongArray, length) { }

        protected override void SerializeElement(Stream stream, ulong element)
        {
            stream.WriteULong(element);
        }

        protected override ulong DeserializeElement(Stream stream)
        {
            return stream.ReadULong();
        }
    }
}
