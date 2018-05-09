using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktProjectileInfo
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 ProjectileUID = packet.ReadUInt64();
            UInt32 ProjectileID = packet.ReadUInt32();
            UInt32 SkillInfoID = packet.ReadUInt32();
            UInt64 OwnerUID = packet.ReadUInt64();
            float CurrentXPos = packet.ReadSingle();
            float CurrentYPos = packet.ReadSingle();
            float DestinationXPos = packet.ReadSingle();
            float DestinationYPos = packet.ReadSingle();
            float Speed = packet.ReadSingle();
            float Direction1 = packet.ReadSingle(); // Supposed to be direction
            float Direction2 = packet.ReadSingle(); // but I dont understand it.
            UInt64 TargetUID = packet.ReadUInt64();
            UInt32 HitRemaiNtime = packet.ReadUInt32();
        }
    }
}