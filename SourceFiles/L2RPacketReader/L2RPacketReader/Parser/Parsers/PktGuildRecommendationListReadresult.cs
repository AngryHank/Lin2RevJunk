using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildRecommendationListReadresult
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktGuildRecommendationListReadresult.csv", true))
            {

                    int i = 2;
                    
                    UInt16 NumberofGuilds = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                fileStream.WriteLine("NumberofGuilds:" + NumberofGuilds);
                fileStream.WriteLine("ClanID,NameLength,Name,Unk1,Unk2,IntroLength,Intro,Level,Exp,Reputation," +
                    "Ranking,Unk3,Members,LeaderLength,Leader,Unk4,Unk5,Closed,LevelReq,Wins,Draws,Losses,ClanCP," +
                    "Unk7,Unk8,Unk9,Spacer");

                for (int j = 0; j < NumberofGuilds; j++)
                    {
                        UInt64 ClanID = BitConverter.ToUInt64(packetData, i);
                        i += 8;
                        UInt16 NameLength = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        string Name = Encoding.UTF8.GetString(packetData, i, NameLength);
                        i += NameLength;
                        UInt32 Unk1 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk2 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt16 IntroLength = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        string Intro = Encoding.UTF8.GetString(packetData, i, IntroLength);
                        i += IntroLength;
                        UInt16 Level = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt32 Exp = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Reputation = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Ranking = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk3 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt16 Members = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt16 LeaderLength = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        string Leader = Encoding.UTF8.GetString(packetData, i, LeaderLength);
                        i += LeaderLength;
                        UInt32 Unk4 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk5 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        byte Closed = packetData[i];
                        i++;
                        UInt16 LevelReq = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt16 Wins = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt16 Draws = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt16 Losses = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        UInt32 ClanCP = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk7 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk8 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        UInt32 Unk9 = BitConverter.ToUInt32(packetData, i);
                        i += 4;
                        byte Spacer = packetData[i];
                        i++;
                    
                    fileStream.WriteLine(ClanID + "," + NameLength + "," + Name + "," + 
                        Unk1 + "," + Unk2 + "," + IntroLength + ",\"" + Intro + "\"," + Level + "," + Exp + "," + 
                        Reputation + "," + Ranking + "," + Unk3 + "," + Members + "," + LeaderLength + "," + 
                        Leader + "," + Unk4 + "," + Unk5 + "," + Closed + "," + LevelReq + "," + Wins + "," + 
                        Draws + "," + Losses + "," + ClanCP + "," + Unk7 + "," + Unk8 + "," + Unk9 + "," + Spacer);

                }
            }
        }
    }
}
