using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktRankingListRead
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktRankingListRead.csv", true))
            {


//                fileStream.WriteLine("RankID, Page, Total, Unk1, Unk2, Unk3, Unk4, Unk5, Unk6, Unk7, Unk8, Unk9, NumberOfRanks");

                packet.Skip(2);
                String RankID = CSV.Ranking.rankingName(packet.ReadInt32());
                UInt32 Page = packet.ReadUInt32();
                UInt32 Total = packet.ReadUInt32();

                UInt32 Rank = packet.ReadUInt32();
                UInt32 Stat = packet.ReadUInt32();
                UInt64 UID = packet.ReadUInt64();
                string Name = packet.ReadString();
                string Race = CSV.race.RaceName(packet.ReadInt32());
                string Class = CSV.Class.className(packet.ReadUInt16());
                packet.Skip(2);
                UInt16 Level = packet.ReadUInt16();
                UInt32 Unk14 = packet.ReadUInt32();
                UInt64 ClanUID = packet.ReadUInt64();
                string ClanName = packet.ReadString();
                UInt32 Unk15 = packet.ReadUInt32();
                UInt32 RankID1 = packet.ReadUInt32();
                UInt32 Unk16 = packet.ReadUInt32();
                UInt16 Unk17 = packet.ReadUInt16();
                UInt16 Unk18 = packet.ReadUInt16();
                UInt32 Unk21 = packet.ReadUInt32();
                UInt32 Unk22 = packet.ReadUInt32();
                UInt32 Unk23 = packet.ReadUInt32();
                UInt32 Unk24 = packet.ReadUInt32();
                

                UInt32 Unk1 = packet.ReadUInt32();
                UInt32 Unk2 = packet.ReadUInt32();
                UInt32 Unk3 = packet.ReadUInt32();
                UInt32 Unk4 = packet.ReadUInt32();
                UInt32 Unk5 = packet.ReadUInt32();
                UInt32 Unk6 = packet.ReadUInt32();
                UInt16 Unk7 = packet.ReadUInt16();
                UInt32 Unk8 = packet.ReadUInt32();
                UInt16 Unk9 = packet.ReadUInt16();
                UInt16 NumberOfRanks = packet.ReadUInt16();

 //               fileStream.WriteLine(RankID + "," + Page + "," + Total + "," + Unk1 + "," + Unk2 + "," + Unk3 + "," + Unk4 + "," + Unk5 + "," + Unk6 + "," + Unk7 + "," + Unk8 + "," + Unk9 + "," + NumberOfRanks);

                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("RankID1,Rank,Stat,Name,ClanName,Class");
                }
//                fileStream.WriteLine("RankID1,Rank,Stat,UID,Name,ClanUID,ClanName,Race,Class,Level,Unk14,Unk15,Unk16,Unk17,Unk18,Unk21,Unk22,Unk23,Unk24");

 //               fileStream.WriteLine(RankID1 + "," + Rank + "," + Stat + "," + UID + "," + Name + "," + ClanUID + "," + ClanName + "," + Race + "," + Class + "," + Level + "," + Unk14 + "," + Unk15 + "," + Unk16 + "," + Unk17 + "," + Unk18 + "," + Unk21 + "," + Unk22 + "," + Unk23 + "," + Unk24);


                for (int j = 0; j < NumberOfRanks; j++)
                {
                    Rank = packet.ReadUInt32();
                    Stat = packet.ReadUInt32();
                    UID = packet.ReadUInt64();
                    Name = packet.ReadString();

                    Race = CSV.race.RaceName(packet.ReadInt32());
                    Class = CSV.Class.className(packet.ReadUInt16());
                    packet.Skip(2);
                    Level = packet.ReadUInt16();
                    Unk14 = packet.ReadUInt32();
                    ClanUID = packet.ReadUInt64();
                    ClanName = packet.ReadString();


                    Unk15 = packet.ReadUInt32();
                    RankID1 = packet.ReadUInt32();
                    Unk16 = packet.ReadUInt32();
                    Unk17 = packet.ReadUInt16();
                    Unk18 = packet.ReadUInt16();
                    Unk21 = packet.ReadUInt32();
                    Unk22 = packet.ReadUInt32();
                    Unk23 = packet.ReadUInt32();
                    Unk24 = packet.ReadUInt32();
 //                   fileStream.WriteLine(RankID1 + "," + Rank + "," + Stat + "," + UID + "," + Name + "," + ClanUID + "," + ClanName + "," + Race + "," + Class + "," + Level + "," + Unk14 + "," + Unk15 + "," + Unk16 + "," + Unk17 + "," + Unk18 + "," + Unk21 + "," + Unk22 + "," + Unk23 + "," + Unk24);
                    fileStream.WriteLine( "," + Rank + "," + Stat + "," + Name + "," + ClanName + "," + Class);
                }


            }
        }
    }
}