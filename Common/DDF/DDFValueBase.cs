namespace DarkTech.Common.DDF
{
    public abstract class DDFValueBase<T> : DDFBase
    {
        public T Value { get; set; }

        public DDFValueBase(DDFType type)
            : base(type)
        {
            this.Value = default(T);
        }

        public static implicit operator T(DDFValueBase<T> value)
        {
            return value.Value;
        }
    }
}
