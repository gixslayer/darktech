namespace DarkTech.Engine.Logging
{
    public interface ILogReceiver : System.IDisposable
    {
        bool Initialize(LogChannel rootChannel);
        void WriteLine(LogChannel channel, string message);
    }
}
