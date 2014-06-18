namespace DarkTech.Engine
{
    internal sealed class DummyClient : IClient
    {
        public string Name { get { return "Dummy client"; } }
        public string Author { get { return "DarkTeck"; } }
        public string Version { get { return "1.0"; } }

        public bool Initialize()
        {
            return true;
        }

        public void Update(float dt) { }
        public void Render() { }
        public void Dispose() { }
    }
}
