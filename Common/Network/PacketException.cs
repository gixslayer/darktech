using System;

namespace DarkTech.Common.Network
{
    public class PacketException : Exception
    {
        public PacketException(string message) : base(message) { }
    }
}
