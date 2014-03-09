using System.IO;
using System.Text;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockString : BlockData<string>
    {
        public BlockString() : this(string.Empty) {}
        public BlockString(string defaultValue) : base(BlockType.String, defaultValue) {}

        public override void Serialize(Stream stream)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(Value);
            int length = buffer.Length > byte.MaxValue ? byte.MaxValue : buffer.Length;

            stream.WriteByte((byte)length);
            stream.Write(buffer, 0, length);
        }

        public override void Deserialize(Stream stream)
        {
            byte length = stream.ReadByteEx();
            byte[] buffer = new byte[length];

            if (!stream.SaveRead(buffer))
                throw BBSException.UNEXPECTED_EOS;

            Value = Encoding.UTF8.GetString(buffer);
        }
    }
}
