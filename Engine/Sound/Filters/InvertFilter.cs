namespace DarkTech.Engine.Sound.Filters
{
    public sealed class InvertFilter : SampleTransformer
    {
        public override void Process() { }

        protected override bool Transform(ref Sample input)
        {
            input.left = -input.left;
            input.right = -input.right;

            return true;
        }
    }
}
