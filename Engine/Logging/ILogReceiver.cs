namespace DarkTech.Engine.Logging
{
    public interface ILogReceiver : System.IDisposable
    {
        bool Initialize();
        void WriteLine(string channel, string message);
    }
}
