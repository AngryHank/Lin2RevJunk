using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktBuffInfo
    {
        public static void Packet(PacketReader packet)
        {
            // All of this is wrong but works to get past it.
            UInt64 SkillUID = packet.ReadUInt64();
            UInt32 SkillID = packet.ReadUInt32();
            UInt32 BuffID = packet.ReadUInt32();
            UInt32 BuffLv = packet.ReadUInt32();
            UInt16 StackCount = packet.ReadUInt16();
            UInt64 EndTime = packet.ReadUInt64();
          
        }
    }
}