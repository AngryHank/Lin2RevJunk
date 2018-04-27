using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktAchievementListReadResult
    {
        public static void Packet(PacketReader packet)
        {
            packet.Skip(2);
            UInt16 AchievementCount = packet.ReadUInt16();
            for (int i = 0; i < AchievementCount; i++) {
                PktAchievement.Packet(packet);
            }
            UInt32 AchievementPoints = packet.ReadUInt32();
            UInt32 HeroicLevel = packet.ReadUInt32();
            byte HeroicLevelReward = packet.ReadByte();
            UInt64 RewardremainTimeSeconds = packet.ReadUInt64();
        }
    }
}