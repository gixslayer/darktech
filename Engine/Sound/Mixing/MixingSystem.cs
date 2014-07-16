using DarkTech.Common.Containers;
using DarkTech.Common.Utils;

namespace DarkTech.Engine.Sound.Mixing
{
    internal sealed class MixingSystem
    {
        private readonly IList<SamplePlayer> activePlayers;
        private readonly IList<SamplePlayer> stoppedPlayers;
        private readonly OpenALVoice openALVoice;
        private readonly Mixer mixer;
        private readonly SharedReference<Listener> listener;

        internal MixingSystem()
        {
            int mixerChannels = Engine.ScriptingInterface.GetCvarValue<int>("snd_mixerChannels");

            this.activePlayers = new LinkedList<SamplePlayer>();
            this.stoppedPlayers = new ArrayList<SamplePlayer>(8);
            this.openALVoice = new OpenALVoice();
            this.mixer = new Mixer(mixerChannels, openALVoice);
            this.listener = new SharedReference<Listener>(null);

            mixer.Master.Gain = Engine.ScriptingInterface.GetCvarValue<float>("snd_volume");
            mixer.Master.Balance = Engine.ScriptingInterface.GetCvarValue<float>("snd_balance");

            for (int i = 0; i < mixerChannels; i++)
            {
                mixer[i].Gain = Engine.ScriptingInterface.GetCvarValue<float>(string.Format("snd_mixerChannel{0}_gain", i));
                mixer[i].Balance = Engine.ScriptingInterface.GetCvarValue<float>(string.Format("snd_mixerChannel{0}_balance", i));
            }
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
            SamplePlayer player = new SamplePlayer(command.SoundDefinition);
            MixerChannel channel = command.MixerChannelIndex == -1 ? mixer.Master : mixer[command.MixerChannelIndex];

            player.Output = command.EffectChain;
            command.EffectChain.Output = channel;

            activePlayers.Add(player);
        }

        private void PlaySoundAt(CommandPlaySoundAt command)
        {
            SamplePlayer player = new SamplePlayer(command.SoundDefinition);
            MixerChannel channel = command.MixerChannelIndex == -1 ? mixer.Master : mixer[command.MixerChannelIndex];

            player.Output = command.EffectChain;
            command.EffectChain.Output = channel;

            // Add positional filter after effect chain

            activePlayers.Add(player);
        }

        private void UpdateListener(CommandUpdateListener command)
        {
            command.Listener.IsDirty = true;

            listener.UpdateReference(command.Listener);
        }

        private void ProcessSample()
        {
            foreach (SamplePlayer player in activePlayers)
            {
                player.Process();

                if (player.State == SamplePlayerState.Stopped)
                {
                    stoppedPlayers.Add(player);
                }
            }

            mixer.Process();
            openALVoice.Process();

            if (stoppedPlayers.Count != 0)
            {
                foreach (SamplePlayer player in stoppedPlayers)
                {
                    activePlayers.Remove(player);
                }

                stoppedPlayers.Clear();
            }

            listener.Value.IsDirty = false;
        }
    }
}
