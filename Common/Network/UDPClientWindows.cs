using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DarkTech.Common.Network
{
    public sealed class UDPClientWindows : UDPClient
    {
        private Socket socket;
        private byte[] buffer;
        private bool disposed;
        private Thread receiveThread;
        private volatile bool keepReceiving;

        public UDPClientWindows(string ip, int port) : base(ip, port) 
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.buffer = new byte[Packet.MAX_PACKET_SIZE];
            this.disposed = false;
            this.keepReceiving = true;

            socket.Bind(new IPEndPoint(IPAddress.Any, port));

            // Start the receive thread.
            new Thread(new ThreadStart(Receive)).Start();
        }

        ~UDPClientWindows()
        {
            Dispose();
        }

        public override void Send(Packet packet)
        {
            socket.SendTo(packet.Serialize(), endpoint);
        }

        public override void Dispose()
        {
            if (!disposed)
            {
                keepReceiving = false;

                socket.Dispose();
            }
        }

        private void Receive()
        {
            while (keepReceiving)
            {

            }
        }
    }
}
