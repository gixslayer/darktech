using System;
using System.Net;

namespace DarkTech.Common.Network
{
    public delegate void PacketReceivedHandler(Packet packet);

    public abstract class UDPClient : IDisposable
    {
        protected IPEndPoint endpoint;

        public event PacketReceivedHandler PacketReceived = delegate { };

        public UDPClient(string ip, int port)
        {
            IPAddress address;

            if (!IPAddress.TryParse(ip, out address))
                throw new ArgumentException("Failed to parse ip", "ip");
            if (port < 0 || port > 65535)
                throw new ArgumentOutOfRangeException("port");

            this.endpoint = new IPEndPoint(address, port);
        }

        public abstract void Send(Packet packet);
        public abstract void Dispose();
    }
}
