namespace DarkTech.Engine.Sound.Filters
{
    public sealed class SwapFilter : SampleTransformer
    {
        public override void Process() { }

        protected override Sample Transform(ref Sample input)
        {
            float left = input.left;

            input.left = input.right;
            input.right = left;

            return input;
        }
    }
}
