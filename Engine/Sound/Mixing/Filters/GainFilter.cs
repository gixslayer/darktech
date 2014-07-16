namespace DarkTech.Engine.Sound.Mixing.Filters
{
    public sealed class GainFilter : SampleTransformer
    {
        public float Gain { get; set; }

        protected override bool Transform(ref Sample input)
        {
            input.left *= Gain;
            input.right *= Gain;

            return true;
        }
    }
}
