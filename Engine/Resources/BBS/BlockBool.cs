using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockBool : BlockData<bool>
    {
        public BlockBool() : this(false) {}
        public BlockBool(bool defafultValue) : base(BlockType.Bool, defafultValue) {}

        public override bool Serialize(Stream stream)
        {
            byte[] buffer = ByteConverter.GetBytes(Value);

            stream.Write(buffer, 0, buffer.Length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            byte[] buffer = new byte[1];

            if (stream.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = ByteConverter.ToBool(buffer, 0);

            return true;
        }
    }
}
