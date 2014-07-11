namespace DarkTech.Engine.Sound.Filters
{
    public sealed class GainFilter : SampleTransformer
    {
        public float Gain { get; set; }

        public override void Process() { }

        protected override bool Transform(ref Sample input)
        {
            input.left *= Gain;
            input.right *= Gain;

            return true;
        }
    }
}
