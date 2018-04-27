using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktAchievement
    {
        public static void Packet(PacketReader packet)
        {
            byte EAchievementType = packet.ReadByte();
            UInt32 AchievementInfoID = packet.ReadUInt32();
            byte EAchievementState = packet.ReadByte();
            UInt32 TaskParam = packet.ReadUInt32();
        }
    }
}