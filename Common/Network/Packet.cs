using System;
using System.Collections.Generic;

using DarkTech.Common.Utils;

namespace DarkTech.Common.Network
{
    public abstract class Packet
    {
        public const int HEADER_SIZE = 8;
        public const int MAX_PACKET_SIZE = 32768; // 32Kb.

        public ushort Type { get; private set; }
        public PacketFlags Flags { get; private set; }
        public uint Id { get; private set; }

        public Packet(ushort type) : this(type, PacketFlags.None) { }

        public Packet(ushort type, PacketFlags flags)
        {
            this.Type = type;
            this.Flags = flags;
        }

        public bool HasFlag(PacketFlags flag)
        {
            return (Flags & flag) == flag;
        }

        public void SetFlag(PacketFlags flag)
        {
            Flags |= flag;
        }

        public void ClearFlag(PacketFlags flag)
        {
            Flags &= ~flag;
        }

        public byte[] Serialize()
        {
            int predictedDataSize = GetPredictedDataSize();

            if (predictedDataSize < 0)
                throw new InvalidOperationException("predictedDataSize cannot be negative");

            DataBuffer buffer = new DataBuffer(HEADER_SIZE + predictedDataSize);

            buffer.Write(Type); // Packet type, 2 bytes.
            buffer.Write((ushort)Flags); // Packet flags, 2 bytes.
            //buffer.Write(ID_GENERATOR.Next()); // Packet id (unique), 4 bytes.
            // Local time?

            SerializeData(buffer);

            if (buffer.Length > MAX_PACKET_SIZE)
                throw new PacketException("Serialized packet data cannot exceed MAX_PACKET_SIZE");

            return buffer.BackBuffer;
        }

        protected abstract int GetPredictedDataSize();
        protected abstract void SerializeData(DataBuffer buffer);
        protected abstract void DeserializeData(DataBuffer buffer);

        #region Deserialize
        private static readonly Dictionary<ushort, Type> TYPE_MAPPING = new Dictionary<ushort, Type>();

        public static Packet Deserialize(byte[] buffer, int offset, int count)
        {
            try
            {
                DataBuffer dataBuffer = new DataBuffer(buffer, offset, count, DataBufferMode.Read);

                ushort type = dataBuffer.ReadUShort();

                Packet packet = CreatePacketFromType(type);

                packet.Type = type;
                packet.Flags = (PacketFlags)dataBuffer.ReadUShort();
                packet.Id = dataBuffer.ReadUInt();
                // Time?

                packet.DeserializeData(dataBuffer);

                return packet;
            }
            catch (PacketException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new PacketException(e.Message);
            }
        }

        public static void RegisterPacketType<T>(ushort type) where T : Packet, new() 
        {
            if (TYPE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Duplicate type entry", "type");

            TYPE_MAPPING.Add(type, typeof(T));
        }

        private static Packet CreatePacketFromType(ushort type)
        {
            if (!TYPE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Unknown packet type", "type");

            Type packetType = TYPE_MAPPING[type];

            return (Packet)Activator.CreateInstance(packetType, true);
        }
        #endregion
    }
}
