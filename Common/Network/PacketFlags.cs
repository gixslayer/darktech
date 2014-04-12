namespace DarkTech.Common.Network
{
    public enum PacketFlags : ushort
    {
        None = 0x0,
        /// <summary>
        /// The packet arrival must be validated by sending back an acknowledgment.
        /// </summary>
        Validate = 0x1
    }
}
