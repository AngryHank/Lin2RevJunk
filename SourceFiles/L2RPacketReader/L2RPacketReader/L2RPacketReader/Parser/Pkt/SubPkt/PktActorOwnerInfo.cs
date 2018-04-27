using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktActorOwnerInfo
    {
        public static void Packet(PacketReader packet)
        {
            string OwnerNamer = packet.ReadString();
            byte ActorType = packet.ReadByte(); // Could be UInt
            UInt64 ActorUID = packet.ReadUInt64();
        }
    }
}