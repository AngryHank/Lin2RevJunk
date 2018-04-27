using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktGroundObjectInfo
    {
        public static void Packet(PacketReader packet)
        {
            UInt64 GroundObjectUID = packet.ReadUInt64();
            UInt32 GroundObjectID = packet.ReadUInt32();
            UInt32 SkillInfoID = packet.ReadUInt32();
            UInt64 OwnerUID = packet.ReadUInt64();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            UInt32 ElapsedTime = packet.ReadUInt32();
        }
    }
}