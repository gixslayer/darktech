using System;

namespace DarkTech.Engine.Logging
{
    public sealed class ConsoleLogWriter : ILogReceiver
    {
        public bool Initialize()
        {
            return true;
        }

        public void WriteLine(string channel, string message)
        {
            Console.WriteLine("[{0}] {1}", channel, message);
        }

        public void Dispose() { }
    }
}
