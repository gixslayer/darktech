namespace DarkTech.Common.Utils
{
    public sealed class UIntGenerator : NumberGenerator<uint>
    {
        public UIntGenerator(OverflowMode overflowMode) : base(uint.MinValue, uint.MaxValue, overflowMode) { }

        protected override uint Increment(uint value)
        {
            return value++;
        }
    }
}
