namespace DarkTech.Engine.Sound.Mixing.Filters
{
    public sealed class SwapFilter : SampleTransformer
    {
        protected override bool Transform(ref Sample input)
        {
            float left = input.left;

            input.left = input.right;
            input.right = left;

            return true;
        }
    }
}
