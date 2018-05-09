using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktActorOwnerInfo
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 ActorUID = packet.ReadUInt64();
            byte ActorType = packet.ReadByte(); // Could be UInt
            string OwnerNamer = packet.ReadString();
        }
    }
}