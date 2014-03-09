using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockDoubleArray : BlockArray<double>
    {
        public BlockDoubleArray() : this(0) { }
        public BlockDoubleArray(int length) : base(BlockType.DoubleArray, length) { }

        protected override void SerializeElement(Stream stream, double element)
        {
            stream.WriteDouble(element);
        }

        protected override double DeserializeElement(Stream stream)
        {
            return stream.ReadDouble();
        }
    }
}
