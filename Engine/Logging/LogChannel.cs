using DarkTech.Common.Containers;

using System.Text;

namespace DarkTech.Engine.Logging
{
    public sealed class LogChannel
    {
        public string Name { get; private set; }
        public LogChannel Parent { get; private set; }
        public IList<LogChannel> Children { get; private set; }

        public LogChannel(string name, LogChannel parent)
        {
            this.Name = name;
            this.Parent = parent;
            this.Children = new ArrayList<LogChannel>();
        }

        public string GetFullName()
        {
            StringBuilder stringBuilder = new StringBuilder(Name, 32);

            for (LogChannel parent = Parent; parent != null; parent = parent.Parent)
            {
                stringBuilder.Append('/');
                stringBuilder.Append(parent.Name);
            }

            return stringBuilder.ToString();
        }
    }
}
