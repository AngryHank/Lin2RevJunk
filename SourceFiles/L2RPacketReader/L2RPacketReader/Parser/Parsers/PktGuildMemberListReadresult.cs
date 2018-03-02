using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildMemberListReadresult
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktGuildMemberListReadresult.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                int i = 2;
                UInt64 ClanID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 MemberCount = BitConverter.ToUInt16(packetData, i);
                i += 2;

                //Writes header for the PktGuildMemberListReadresult
                fileStream.WriteLine("ClanID, MemberCount\n" + ClanID + "," + MemberCount + "\n");
                fileStream.WriteLine("PlayerID," + "NameLength," + "PlayerName," + "ClanRole," + 
                    "Race," + "PlayerClass," + "UnkA," + "UnkB," + "Level," + "Offline," + 
                    "Contribution," + "TotalContribution" +
                    "IGreet," + "TheyGreet," + "Checkin," + "PlayerCP," + 
                    "Unk1," + "RewardCount," + "WorldID," + "Unk2," + "introLength," + "Introduction");
                

                // Parses the PktGuildMemberListReadresult
                while ( i < (packetLength))
                {
                    UInt64 PlayerID = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    UInt16 NameLength = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string PlayerName = Encoding.UTF8.GetString(packetData, i, NameLength);
                    i += NameLength;
                    string ClanRole = CSV.guildMemberGrade.guildMemberGradeName(packetData[i]);
                    i += 1;
                    string Race = CSV.race.RaceName(BitConverter.ToUInt16(packetData, i));
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
                    fileStream.WriteLine(PlayerID + "," + NameLength + "," + PlayerName + "," + ClanRole + "," +
                        Race + "," + PlayerClass + "," + UnkA + "," + UnkB + "," + Level + "," + Offline + "," +
                        Contribution + "," + TotalContribution +"," +
                        IGreet + "," + TheyGreet + "," + Checkin + "," + PlayerCP + "," +
                        Unk1 + "," + RewardCount + "," + WorldID + "," + introLength + "," + Introduction);
                }
                fileStream.WriteLine("\n\n");
            }
        }
    }
}
