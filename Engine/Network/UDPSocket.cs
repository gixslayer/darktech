using System.Net;

namespace DarkTech.Engine.Network
{
    public abstract class UDPSocket
    {
        protected readonly EndPoint remoteEP;

        public UDPSocket(EndPoint remoteEP)
        {
            this.remoteEP = remoteEP;
        }

        public abstract void Send(byte[] buffer, int offset, int count);
        public abstract int Receive(byte[] buffer, ref EndPoint remoteEP);
    }
}
