using DarkTech.Common.Containers;

namespace DarkTech.Engine.Logging
{
    public sealed class LogDispatcher : System.IDisposable
    {
        public LogChannel RootChannel { get; private set; }
        public LogChannel InfoChannel { get; private set; }
        public LogChannel ErrorChannel { get; private set; }
        public LogChannel WarningChannel { get; private set; }

        private readonly IList<ILogReceiver> receivers;
        private bool disposed;

        public LogDispatcher()
        {
            this.receivers = new LinkedList<ILogReceiver>();
            this.disposed = false;
            this.RootChannel = new LogChannel("root", null);
            this.InfoChannel = new LogChannel("info", RootChannel);
            this.ErrorChannel = new LogChannel("error", RootChannel);
            this.WarningChannel = new LogChannel("warning", RootChannel);

            RootChannel.Children.Add(InfoChannel);
            RootChannel.Children.Add(ErrorChannel);
            RootChannel.Children.Add(WarningChannel);
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

        public void Info(string message)
        {
            WriteLine(InfoChannel, message);
        }

        public void Info(string format, params object[] args)
        {
            WriteLine(InfoChannel, format, args);
        }

        public void Warning(string message)
        {
            WriteLine(WarningChannel, message);
        }

        public void Warning(string format, params object[] args)
        {
            WriteLine(WarningChannel, format, args);
        }

        public void Error(string message)
        {
            WriteLine(ErrorChannel, message);
        }

        public void Error(string format, params object[] args)
        {
            WriteLine(ErrorChannel, format, args);
        }

        public void WriteLine(LogChannel channel)
        {
            WriteLine(channel, string.Empty);
        }

        public void WriteLine(LogChannel channel, string format, params object[] args)
        {
            WriteLine(channel, string.Format(format, args));
        }

        public void WriteLine(LogChannel channel, string message)
        {
            foreach (ILogReceiver receiver in receivers)
            {
                receiver.WriteLine(channel, message);
            }
        }
    }
}
