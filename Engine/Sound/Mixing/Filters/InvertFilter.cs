namespace DarkTech.Engine.Sound.Mixing.Filters
{
    public sealed class InvertFilter : SampleTransformer
    {
        protected override bool Transform(ref Sample input)
        {
            input.left = -input.left;
            input.right = -input.right;

            return true;
        }
    }
}
