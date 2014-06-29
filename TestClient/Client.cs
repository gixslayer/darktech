using DarkTech.Engine;

namespace TestClient
{
    public class Client : IClient
    {
        public string Name { get { return "Test client"; } }
        public string Author { get { return "DarkTech"; } }
        public string Version { get { return "1.0"; } }

        public bool Initialize() { return true; }
        public void Update(float dt) { }
        public void Render() { }
        public void Dispose() { }
    }
}
