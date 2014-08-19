using DarkTech.Common.IO;
using DarkTech.Common.Utils;

namespace DarkTech.Common.DDF
{
    public abstract class DDFPrimitiveBase<T> : DDFValueBase<T>
    {
        public DDFPrimitiveBase(DDFType type)
            : base(type)
        {

        }

        public override void Serialize(DataStream dataStream)
        {
            dataStream.Write<T>(Value);
        }

        public override void Deserialize(DataStream dataStream)
        {
            Value = dataStream.Read<T>();
        }
    }
}
