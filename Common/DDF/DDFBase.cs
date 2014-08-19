using DarkTech.Common.IO;

namespace DarkTech.Common.DDF
{
    public abstract class DDFBase
    {
        private readonly DDFType type;

        public DDFType Type
        {
            get { return type; }
        }

        public DDFBase(DDFType type)
        {
            this.type = type;
        }

        public abstract void Serialize(DataStream dataStream);
        public abstract void Deserialize(DataStream dataStream);
    }
}
