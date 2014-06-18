using DarkTech.Engine;

namespace TestServer
{
    public class Server : IServer
    {
        public string Name { get { return "Test server"; } }
        public string Author { get { return "DarkTech"; } }
        public string Version { get { return "1.0"; } }

        public bool Initialize()
        {
            Engine.Print("Server init");

            return true;
        }

        public void Update(float dt) { }
        public void Dispose() { }
    }
}
