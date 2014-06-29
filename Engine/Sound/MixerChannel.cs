using DarkTech.Engine.Sound.Filters;

namespace DarkTech.Engine.Sound
{
    public sealed class MixerChannel : ISampleConsumer, ISampleProvider
    {
        private readonly SampleBuffer buffer;
        private readonly GainFilter gainFilter;
        private readonly PanFilter panFilter;

        public string Name { get; set; }
        public ISampleConsumer Output { get; set; }
        public float Gain
        {
            get { return gainFilter.Gain; }
            set
            {
                gainFilter.Gain = value;
                gainFilter.Bypass = FloatEqual(value, 1f);
            }
        }
        public float Balance
        {
            get { return panFilter.Balance; }
            set 
            { 
                panFilter.Balance = value;
                panFilter.Bypass = FloatEqual(value, 0f);
            }
        }

        public MixerChannel(ISampleConsumer output, string name = null)
        {
            this.Name = name;
            this.Output = output;
            this.buffer = new SampleBuffer();
            this.gainFilter = new GainFilter();
            this.panFilter = new PanFilter();

            Gain = 1f;
            Balance = 0f;

            gainFilter.Output = panFilter;
            panFilter.Output = buffer;
        }

        public void Process()
        {
            Sample sample = new Sample();

            for (int i = 0; i < buffer.Count; i++)
            {
                Sample bufferedSample = buffer[i];

                sample.left += bufferedSample.left;
                sample.right += bufferedSample.right;
            }

            buffer.Clear();

            Output.Process(ref sample);
        }

        public void Process(ref Sample input)
        {
            gainFilter.Process(ref input);
        }

        private static bool FloatEqual(float left, float right, float margin = 0.001f)
        {
            // Calculate difference.
            float diff = left - right;

            // ABS difference.
            if (diff < 0f) diff = -diff;

            // Test against the margin.
            return diff <= margin;
        }
    }
}
