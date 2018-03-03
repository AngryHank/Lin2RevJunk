using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildMemberListReadresultClean
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildMemberList.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                int i = 2;
                UInt64 ClanID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 MemberCount = BitConverter.ToUInt16(packetData, i);
                i += 2;

                //Writes header for the PktGuildMemberListReadresult
                fileStream.WriteLine("Clan ID,Name,Member Count\n" + ClanID + ",\"=VLOOKUP(OFFSET(INDIRECT(ADDRESS(ROW(), COLUMN())),0,-1),DetailedGuildInfo!A:C,3,FALSE)\"," + MemberCount + "\n");
                fileStream.WriteLine("Player ID," + "Player Name," + "Level," + "Combat Power," + 
                    "Role," + "Class," + "Offline," + "Contribution," + "Total Contributions," + 
                    "Checked in," + "Rewards Count," + "World,"  + "Introduction");
                

                // Parses the PktGuildMemberListReadresult
                while ( i < (packetData.Length))
                {
                    UInt64 PlayerID = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    UInt16 NameLength = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string PlayerName = Encoding.UTF8.GetString(packetData, i, NameLength);
                    i += NameLength;
                    string ClanRole = CSV.guildMemberGrade.guildMemberGradeName(packetData[i]);
                    i += 1;
                    string Race = CSV.race.RaceName(BitConverter.ToInt32(packetData, i));
                    i += 4;
                    string PlayerClass = CSV.Class.className(BitConverter.ToUInt16(packetData, i));
                    i += 2;
                    byte UnkA = packetData[i];
                    i++;
                    byte UnkB = 0;
                    if (packetData[i] <= 255)
                    {
                        UnkB = packetData[i];
                        i++;
                    }
                    UInt16 Level = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    String Offline = Misc.Misc.CalcTime(BitConverter.ToUInt64(packetData, i));
                    i += 8; ;
                    UInt32 Contribution = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    UInt32 TotalContribution = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    byte IGreet = packetData[i];
                    i++;
                    byte TheyGreet = packetData[i];
                    i++;
                    byte Checkin = packetData[i];
                    i++;
                    UInt32 PlayerCP = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    UInt32 Unk1 = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    byte RewardCount = packetData[i];
                    i++;
                    string WorldID = CSV.world.worldName(BitConverter.ToUInt16(packetData, i));
                    i += 4;
                    UInt16 introLength = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Introduction = "";
                    if (introLength > 0)
                    {
                        Introduction = Encoding.UTF8.GetString(packetData, i, introLength);
                    }


                    i += introLength;
                    fileStream.WriteLine(PlayerID + "," + PlayerName + "," + Level + "," + PlayerCP + "," +
                        ClanRole + "," + PlayerClass + "," + Offline + "," + Contribution + "," + TotalContribution + ", " +  
                        Checkin + "," + RewardCount + "," + WorldID + "," + Introduction);

                }
                fileStream.WriteLine("\n\n");
            }
        }
    }
}
