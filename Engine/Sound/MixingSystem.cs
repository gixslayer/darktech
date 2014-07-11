using DarkTech.Common.Containers;

namespace DarkTech.Engine.Sound
{
    internal sealed class MixingSystem
    {
        public void Process(IQueue<SoundCommand> commands, int samples)
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

        private void ProcessCommand(SoundCommand command)
        {

        }

        private void ProcessSample()
        {

        }
    }
}
