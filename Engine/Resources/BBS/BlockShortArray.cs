using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockShortArray : BlockArray<short>
    {
        public BlockShortArray() : this(0) { }
        public BlockShortArray(int length) : base(BlockType.ShortArray, length) { }

        protected override void SerializeElement(Stream stream, short element)
        {
            stream.WriteShort(element);
        }

        protected override short DeserializeElement(Stream stream)
        {
            return stream.ReadShort();
        }
    }
}
