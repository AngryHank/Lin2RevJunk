using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildRecommendationListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildRankings.csv", true))
            {
                packet.Skip(2);

                UInt16 NumberofGuilds = packet.ReadUInt16();

                fileStream.WriteLine("Ranking,Name,Leader,Level,Exp,Reputation,Members,ClanCP,Wins,Draws,Losses,LevelReq,Closed,Intro");

                for (int j = 0; j < NumberofGuilds; j++)
                {
                    UInt64 ClanID = packet.ReadUInt64();
                    string Name = packet.ReadString();
                    UInt32 Unk1 = packet.ReadUInt32();
                    UInt32 Unk2 = packet.ReadUInt32();
                    string Intro = packet.ReadString();
                    UInt16 Level = packet.ReadUInt16();
                    UInt32 Exp = packet.ReadUInt32();
                    UInt32 Reputation = packet.ReadUInt32();
                    UInt32 Ranking = packet.ReadUInt32();
                    UInt32 Unk3 = packet.ReadUInt32();
                    UInt16 Members = packet.ReadUInt16();
                    string Leader = packet.ReadString();
                    UInt32 Unk4 = packet.ReadUInt32();
                    UInt32 Unk5 = packet.ReadUInt32();
                    byte Closed = packet.ReadByte();
                    UInt16 LevelReq = packet.ReadUInt16();
                    UInt16 Wins = packet.ReadUInt16();
                    UInt16 Draws = packet.ReadUInt16();
                    UInt16 Losses = packet.ReadUInt16();
                    UInt32 ClanCP = packet.ReadUInt32();
                    UInt32 Unk7 = packet.ReadUInt32();
                    UInt32 Unk8 = packet.ReadUInt32();
                    UInt32 Unk9 = packet.ReadUInt32();
                    byte Spacer = packet.ReadByte();

                    fileStream.WriteLine(Ranking + "," + Name + "," + Leader + "," + Level + "," +
                        Exp + "," + Reputation + "," + Members + "," + ClanCP + "," + Wins + "," +
                        Draws + "," + Losses + "," + LevelReq + "," + Closed + "," + Intro);

                }
            }
        }
    }
}
