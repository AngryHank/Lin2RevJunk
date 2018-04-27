using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktAchievementListReadResult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\Achievements.csv", true))
            {
                stm.WriteLine("Name,Group,Desc,Count");

                packet.Skip(2);
                UInt16 AchievementCount = packet.ReadUInt16();
                for (int i = 0; i < AchievementCount; i++)
                {
                    // PktAchievement
                    byte EAchievementType = packet.ReadByte(); // 0 = In Progress, 2 = Completed
                    UInt32 AchievementInfoID = packet.ReadUInt32();
                    string AchievementName = CSV.achievement.achievementName(AchievementInfoID);
                    string AchievementDesc = CSV.achievement.achievementDesc(AchievementInfoID);
                    string AchievementTaskCount = CSV.achievement.achievementTaskCount(AchievementInfoID);
                    string AchievementGroupType = CSV.achievement.achievementGroupType(AchievementInfoID);
                    byte EAchievementState = packet.ReadByte();
                    UInt32 TaskParam = packet.ReadUInt32();
                    stm.WriteLine("\"" + AchievementName + "\",\"" + AchievementGroupType + "\",\"" + AchievementDesc + "\",\"" + TaskParam + " / " + AchievementTaskCount + "\"");
                }
               
                UInt32 AchievementPoints = packet.ReadUInt32();
                UInt32 HeroicLevel = packet.ReadUInt32();
                byte HeroicLevelReward = packet.ReadByte();
                UInt64 RewardremainTimeSeconds = packet.ReadUInt64();

                stm.WriteLine("\n\nHeroic Level, Achievement Points, Heroic Level Reward, Reward Remain Time");
                stm.WriteLine(HeroicLevel + "," + AchievementPoints + "," + HeroicLevelReward + "," + RewardremainTimeSeconds+"\n\n");

            }
        }
    }
}