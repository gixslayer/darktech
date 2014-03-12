using System.IO;

namespace DarkTech.Common.BBS
{
    public abstract class BlockData<T> : Block
    {
        public T Value { get; set; }

        public BlockData(BlockType type, T defaultValue)
            : base(type)
        {
            this.Value = defaultValue;
        }

        public static implicit operator T(BlockData<T> block)
        {
            return block.Value;
        }
    }
}
