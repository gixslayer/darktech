using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BBSException : StreamException
    {
        public BBSException(string message) : base(message) { }
    }
}
