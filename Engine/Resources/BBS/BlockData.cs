using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public abstract class BlockData<T> : Block
    {
        public T Value { get; set; }

        public BlockData(BlockType type, T defaultValue)
            : base(type)
        {
            this.Value = defaultValue;
        }

        public override bool Equals(object obj)
        {
            if (obj is T)
            {
                return obj.Equals(Value);
            }
            if (obj is BlockData<T>)
            {
                return ((BlockData<T>)obj).Value.Equals(Value);
            }

            return base.Equals(obj);
        }

        public static implicit operator T(BlockData<T> block)
        {
            return block.Value;
        }
    }
}
