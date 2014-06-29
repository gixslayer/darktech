namespace DarkTech.Engine.Sound
{
    internal sealed class DummySoundSystem : ISoundSystem
    {
        public bool Initialize() { return true; }
        public void Start() { }
        public void Restart() { }
        public void Dispose() { }
    }
}
