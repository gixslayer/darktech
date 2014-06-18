using System;

namespace DarkTech.Engine.Sound
{
    public sealed class Mixer : ISampleProvider
    {
        private readonly MixerChannel[] channels;

        public MixerChannel Master { get; set; }
        public ISampleConsumer Output 
        {
            get { return Master.Output; }
            set { Master.Output = value; }
        }
        public int Channels 
        { 
            get { return channels.Length;}
        }

        public Mixer(int channels)
        {
            this.channels = new MixerChannel[channels];
            this.Master = new MixerChannel("Master", Output);

            for (int i = 0; i < Channels; i++)
            {
                this.channels[i] = new MixerChannel(string.Format("Channel {0}", i), Master);
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
            set
            {
                if (index < 0 || index >= Channels)
                    throw new ArgumentOutOfRangeException("index");

                channels[index] = value;
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
