namespace DarkTech.Engine.Sound
{
    internal sealed class SoundSystem : ISoundSystem
    {
        private readonly BackEnd backEnd;

        public SoundSystem()
        {
            this.backEnd = new BackEnd();
        }

        public bool Initialize()
        {
            return backEnd.Initialize();
        }

        public void Start()
        {
            // Signal the back-end to start processing on its dedicated thread.
            backEnd.Start();
        }

        public void Restart()
        {
            // Signal the back-end to restart.
            // Will block until the restart has completed.
            backEnd.Restart();
        }

        public void Dispose()
        {
            backEnd.Dispose();
        }
    }
}
