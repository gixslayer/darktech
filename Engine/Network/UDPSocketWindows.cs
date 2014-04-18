using System.Net;
using System.Net.Sockets;

namespace DarkTech.Engine.Network
{
    public class UDPSocketWindows : UDPSocket
    {
        private Socket socket;

        public UDPSocketWindows(EndPoint remoteEP) : base(remoteEP)
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.socket.Blocking = false;
        }

        public override void Send(byte[] buffer, int offset, int size)
        {
            this.socket.SendTo(buffer, offset, size, SocketFlags.None, remoteEP);
        }

        public override int Receive(byte[] buffer, ref EndPoint remoteEP)
        {
            return this.socket.ReceiveFrom(buffer, ref remoteEP);
        }
    }
}
