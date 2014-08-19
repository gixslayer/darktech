using DarkTech.Common.Containers;

namespace DarkTech.Engine.Sound.Mixing
{
    internal sealed class EffectChain
    {
        private readonly SampleBuffer outputBuffer;
        private readonly DoubleLinkedList<Effect> effects;

        public EffectChain(SampleBuffer outputBuffer)
        {
            this.outputBuffer = outputBuffer;
            this.effects = new DoubleLinkedList<Effect>();
        }

        public void Process(ref Sample sample)
        {
            foreach (Effect effect in effects)
            {
                effect.Process(ref sample);
            }
        }

        public bool Apply()
        {
            bool result = false;

            foreach (Effect effect in effects)
            {
                if (effect.Apply())
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
