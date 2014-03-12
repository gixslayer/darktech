using DarkTech.Common.Utils;

namespace DarkTech.Common.PAK
{
    public sealed class PakException : StreamException
    {
        public PakException(string message) : base(message) { }
    }
}
