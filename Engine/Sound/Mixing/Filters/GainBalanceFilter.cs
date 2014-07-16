namespace DarkTech.Engine.Sound.Mixing.Filters
{
    public sealed class GainBalanceFilter : SampleTransformer
    {
        private float gain;
        private float balance;
        private float leftMultiplier;
        private float rightMultiplier;

        public float Gain
        {
            get { return gain; }
            set 
            { 
                gain = value;
                ComputeMultipliers();
            }
        }
        public float Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                ComputeMultipliers();
            }
        }

        public GainBalanceFilter(float gain = 1f, float balance = 0f)
        {
            this.gain = gain;
            this.balance = balance;

            ComputeMultipliers();
        }

        protected override bool Transform(ref Sample input)
        {
            input.left *= leftMultiplier;
            input.right *= rightMultiplier;

            return true;
        }

        private void ComputeMultipliers()
        {
            leftMultiplier = balance < 0f ? gain : (1f - balance) * gain;
            rightMultiplier = balance > 0f ? gain : (1f + balance) * gain;
        }
    }
}
