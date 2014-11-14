using DarkTech.Common.Containers;

namespace DarkTech.Engine.Sound.Mixing
{
    internal sealed class MixingSystem
    {
        private readonly IList<SampleProvider> activeProviders;
        private readonly IList<SampleProvider> stoppedProviders;
        private readonly IList<Channel> activeChannels;
        private readonly IList<Channel> stoppedChannels;
        private readonly SampleBuffer masterBuffer;
        private readonly OpenALVoice openALVoice;
        private readonly Listener listener;

        internal MixingSystem()
        {
            this.activeProviders = new LinkedList<SampleProvider>();
            this.stoppedProviders = new ArrayList<SampleProvider>(8);
            this.activeChannels = new LinkedList<Channel>();
            this.stoppedChannels = new ArrayList<Channel>(8);
            this.masterBuffer = new SampleBuffer(64);
            this.openALVoice = new OpenALVoice();
            this.listener = new Listener();
        }

        public void Process(IQueue<Command> commands, int samples)
        {
            // Process all commands in the queue.
            while (commands.Count != 0)
            {
                ProcessCommand(commands.Dequeue());
            }
            
            // process 'samples' amount of samples.
            for (int i = 0; i < samples; i++)
            {
                ProcessSample();
            }
        }

        private void ProcessCommand(Command command)
        {
            switch (command.Type)
            {
                case CommandType.NOP:
                    break;

                case CommandType.PlaySound:
                    PlaySound((CommandPlaySound)command);
                    break;

                case CommandType.PlaySoundAt:
                    PlaySoundAt((CommandPlaySoundAt)command);
                    break;

                case CommandType.PlaySoundAtEntity:
                    PlaySoundAtEntity((CommandPlaySoundAtEntity)command);
                    break;

                case CommandType.UpdateListener:
                    UpdateListener((CommandUpdateListener)command);
                    break;

                default:
                    Engine.Errorf("Unknown sound command {0} (command dropped)", command.Type.ToString());
                    break;
            }
        }

        private void PlaySound(CommandPlaySound command)
        {
            /*SamplePlayer player = new SamplePlayer(command.SoundDefinition);
            MixerChannel channel = command.MixerChannelIndex == -1 ? mixer.Master : mixer[command.MixerChannelIndex];

            player.Output = command.EffectChain;
            command.EffectChain.Output = channel;

            activeProviders.Add(player);*/
        }

        private void PlaySoundAt(CommandPlaySoundAt command)
        {
            /*SamplePlayer player = new SamplePlayer(command.SoundDefinition);
            MixerChannel channel = command.MixerChannelIndex == -1 ? mixer.Master : mixer[command.MixerChannelIndex];

            player.Output = command.EffectChain;
            command.EffectChain.Output = channel;

            // Add positional filter after effect chain

            activeProviders.Add(player);*/
        }

        private void PlaySoundAtEntity(CommandPlaySoundAtEntity command)
        {
            /*SamplePlayer player = new SamplePlayer(command.SoundDefinition);
            MixerChannel channel = command.MixerChannelIndex == -1 ? mixer.Master : mixer[command.MixerChannelIndex];

            player.Output = command.EffectChain;
            command.EffectChain.Output = channel;

            // Add positional filter after effect chain

            activeProviders.Add(player);

            // Register trackedActiveSound*/
        }

        private void UpdateListener(CommandUpdateListener command)
        {
            listener.Update(command.Listener);
        }

        private void ProcessSample()
        {
            // Enumerate all active providers.
            foreach (SampleProvider provider in activeProviders)
            {
                // Let the provider process one sample.
                provider.Process();

                // If the provider has stopped mark it for removal.
                if (provider.State == SampleProviderState.Stopped)
                {
                    stoppedProviders.Add(provider);
                }
            }

            // Enumerate all active channels.
            foreach (Channel channel in activeChannels)
            {
                // Let the channel mix all buffered samples and apply the effect chain to the mixed sample.
                // All the generated samples are buffered into the master buffer.
                if (!channel.Mix())
                {
                    // If the channel did not mix anything mark it for removal.
                    stoppedChannels.Add(channel);
                }
            }

            // Mix all the buffered samples in the master buffer.
            Sample finalSample = new Sample(0f, 0f);

            foreach (Sample sample in masterBuffer)
            {
                finalSample.left += sample.left;
                finalSample.right += sample.right;
            }

            // Send the final mixed sample to the OpenAL voice.
            openALVoice.Process(ref finalSample);

            // Remove all the marked providers.
            if (stoppedProviders.Count != 0)
            {
                foreach (SampleProvider provider in stoppedProviders)
                {
                    activeProviders.Remove(provider);
                }

                stoppedProviders.Clear();
            }

            // Remove all the marked channels.
            if (stoppedChannels.Count != 0)
            {
                foreach (Channel channel in stoppedChannels)
                {
                    activeChannels.Remove(channel);
                }

                stoppedChannels.Clear();
            }

            listener.IsDirty = false;
            masterBuffer.Clear();
        }
    }
}
