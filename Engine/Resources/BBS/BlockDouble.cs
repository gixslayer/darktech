using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockDouble : BlockData<double>
    {
        public BlockDouble() : this(0) { }
        public BlockDouble(double defaultValue) : base(BlockType.Double, defaultValue) { }

        public override bool Serialize(Stream stream)
        {
            byte[] buffer = ByteConverter.GetBytes(Value);

            stream.Write(buffer, 0, buffer.Length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            byte[] buffer = new byte[8];

            if (stream.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = ByteConverter.ToDouble(buffer, 0);

            return true;
        }
    }
}
