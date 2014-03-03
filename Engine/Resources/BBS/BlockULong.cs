using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockULong : BlockData<ulong>
    {
        public BlockULong() : this(0) { }
        public BlockULong(ulong defaultValue) : base(BlockType.ULong, defaultValue) { }

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

            Value = ByteConverter.ToULong(buffer, 0);

            return true;
        }
    }
}
