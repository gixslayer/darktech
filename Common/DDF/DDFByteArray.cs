using DarkTech.Common.IO;

namespace DarkTech.Common.DDF
{
    public sealed class DDFByteArray : DDFValueBase<byte[]>
    {
        public DDFByteArray(byte[] value = null) 
            : base(DDFType.ByteArray)
        {
            this.Value = value;
        }

        public override void Serialize(DataStream dataStream)
        {
            dataStream.WriteUInt((uint)Value.Length);
            dataStream.WriteBytes(Value);
        }

        public override void Deserialize(DataStream dataStream)
        {
            uint length = dataStream.ReadUInt();
            Value = dataStream.ReadBytes((int)length);
        }
    }
}
