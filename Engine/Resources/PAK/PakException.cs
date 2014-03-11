using System;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.PAK
{
    public sealed class PakException : StreamException
    {
        public PakException(string message) : base(message) { }
    }
}
