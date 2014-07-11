namespace DarkTech.Engine.Sound.Filters
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

        public override void Process() { }

        protected override bool Transform(ref Sample input)
        {
            input.left *= leftGain;
            input.right *= rightGain;

            return true;
        }
    }
}
