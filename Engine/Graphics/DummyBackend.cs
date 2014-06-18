namespace DarkTech.Engine.Graphics
{
    internal sealed class DummyBackend : IRenderBackend
    {
        public bool CreateContext() { return true; }
        public void Initialize() { }
        public void Start() { }
        public void Stop() { }
        public void Process() { }
    }
}
