using DarkTech.Engine.FileSystem;

using DateTime = System.DateTime;
using StreamWriter = System.IO.StreamWriter;

namespace DarkTech.Engine.Logging
{
    public sealed class LogWriter : ILogReceiver
    {
        private readonly string path;
        private bool disposed;
        private File file;
        private StreamWriter writer;

        public LogWriter(string path)
        {
            this.path = path;
            this.disposed = false;
        }

        ~LogWriter()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                if (file != null)
                {
                    writer.Flush();
                    writer.Dispose();
                    file.Dispose();
                }

                disposed = true;
            }
        }

        public bool Initialize()
        {
            if (!Engine.FileSystem.OpenFile(path, FileMode.Append, FileAccess.Write, out file))
            {
                return false;
            }

            writer = new StreamWriter(file.Stream, System.Text.Encoding.UTF8);

            return true;
        }

        public void WriteLine(string channel, string message)
        {
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            writer.WriteLine("[{0}] {1} {2}", dateTime, channel, message);
        }
    }
}
