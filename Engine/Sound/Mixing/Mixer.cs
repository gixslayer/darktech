using System;

namespace DarkTech.Engine.Sound.Mixing
{
    public sealed class Mixer
    {
        private readonly MixerChannel[] channels;

        public MixerChannel Master { get; private set; }
        public int Channels 
        { 
            get { return channels.Length;}
        }

        internal Mixer(int channels, ISampleConsumer masterOutput)
        {
            this.channels = new MixerChannel[channels];
            this.Master = new MixerChannel(masterOutput);

            for (int i = 0; i < Channels; i++)
            {
                this.channels[i] = new MixerChannel(Master);
            }
        }

        public MixerChannel this[int index]
        {
            get
            {
                if (index < 0 || index >= Channels)
                    throw new ArgumentOutOfRangeException("index");

                return channels[index];
            }
        }

        public void Process()
        {
            for (int i = 0; i < channels.Length; i++)
            {
                channels[i].Process();
            }

            Master.Process();
        }
    }
}
