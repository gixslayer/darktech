using System;

namespace DarkTech.Engine.Logging
{
    public sealed class ConsoleLogWriter : ILogReceiver
    {
        public bool Initialize(LogChannel rootChannel)
        {
            return true;
        }

        public void WriteLine(LogChannel channel, string message)
        {
            Console.WriteLine("[{0}] {1}", channel.GetFullName(), message);
        }

        public void Dispose() { }
    }
}
