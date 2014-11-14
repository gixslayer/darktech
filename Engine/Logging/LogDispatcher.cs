using DarkTech.Common.Containers;

namespace DarkTech.Engine.Logging
{
    public sealed class LogDispatcher : System.IDisposable
    {
        private readonly IList<ILogReceiver> receivers;
        private bool disposed;

        public LogDispatcher()
        {
            this.receivers = new LinkedList<ILogReceiver>();
            this.disposed = false;
        }

        ~LogDispatcher()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                foreach (ILogReceiver receiver in receivers)
                {
                    UnregisterReceiver(receiver);
                }

                receivers.Clear();
                disposed = true;
            }
        }

        public void RegisterReceiver(ILogReceiver receiver)
        {
            if (!receiver.Initialize(RootChannel))
            {
                Error("Failed to initialize log receiver");
            }
            else
            {
                receivers.Add(receiver);
            }
        }

        public void UnregisterReceiver(ILogReceiver receiver)
        {
            if (receivers.Contains(receiver))
            {
                receivers.Remove(receiver);
                receiver.Dispose();
            }
        }

        public void WriteLine(string channel, string format, params object[] args)
        {
            WriteLine(channel, string.Format(format, args));
        }

        public void WriteLine(string channel, string message)
        {
            foreach (ILogReceiver receiver in receivers)
            {
                receiver.WriteLine(channel, message);
            }
        }
    }
}
