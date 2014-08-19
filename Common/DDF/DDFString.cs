using DarkTech.Common.IO;
using DarkTech.Common.Utils;

using System.Text;

namespace DarkTech.Common.DDF
{
    public sealed class DDFString : DDFValueBase<string>
    {
        private static readonly Encoding ENCODING = Encoding.UTF8;

        public DDFString(string value = null)
            : base(DDFType.String)
        {
            this.Value = value;
        }

        public override void Serialize(DataStream dataStream)
        {
            byte[] data = ENCODING.GetBytes(Value);
            ushort length = (ushort)data.Length;

            dataStream.WriteUShort(length);
            dataStream.WriteBytes(data);
        }

        public override void Deserialize(DataStream dataStream)
        {
            ushort length = dataStream.ReadUShort();
            byte[] data = dataStream.ReadBytes(length);

            Value = ENCODING.GetString(data);
        }
    }
}
