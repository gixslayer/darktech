using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BBSException : StreamException
    {
        public BBSException(string message) : base(message) { }
    }
}
