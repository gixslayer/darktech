namespace DarkTech.Common.BBS
{
    public abstract class BlockData<T> : Block
    {
        public T Value { get; set; }

        public BlockData(BlockType blockType) : this(blockType, default(T)) { }

        public BlockData(BlockType blockType, T defaultValue)
            : base(blockType)
        {
            this.Value = defaultValue;
        }

        public override string ToString()
        {
            return Value == null ? string.Empty : Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BlockData<T>))
            {
                return false;
            }

            BlockData<T> other = obj as BlockData<T>;

            return this.Value.Equals(other.Value);
        }

        public override int GetHashCode()
        {
            return Value == null ? 0 : Value.GetHashCode();
        }

        public static implicit operator T(BlockData<T> block)
        {
            return block.Value;
        }

        public static bool operator ==(BlockData<T> a, BlockData<T> b)
        {
            if (a == null && b == null)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(BlockData<T> a, BlockData<T> b)
        {
            return !(a == b);
        }
    }
}
