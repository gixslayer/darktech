using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockFloatArray : BlockArray<float>
    {
        public BlockFloatArray() : this(0) { }
        public BlockFloatArray(int length) : base(BlockType.FloatArray, length) { }

        protected override void SerializeElement(Stream stream, float element)
        {
            stream.WriteFloat(element);
        }

        protected override float DeserializeElement(Stream stream)
        {
            return stream.ReadFloat();
        }
    }
}
