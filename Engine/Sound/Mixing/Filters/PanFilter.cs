namespace DarkTech.Engine.Sound.Mixing.Filters
{
    public sealed class PanFilter : SampleTransformer
    {
        public float Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                leftGain = value < 0f ? 1f : 1f - value;
                rightGain = value > 0f ? 1f : 1f + value;
            }
        }

        private float balance;
        private float leftGain;
        private float rightGain;

        protected override bool Transform(ref Sample input)
        {
            input.left *= leftGain;
            input.right *= rightGain;

            return true;
        }
    }
}
