using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildInfoReadresultClean
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\DetailedGuildInfo.csv", true))
            {
                // First two bytes are not used.
                int i = 2;
                //Writes header for the PktGuildInfoReadresult
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("ID,Ranking,Name,Leader,Level,Exp,As Percentage, Reputation,Combat Power,Adena," +
                        "Proof of Blood,Red Star Stone,Members,Checked in Yesterday,Checked in Today," +
                        "Fortress Owned,Fortress Occupy Date,Wins,Draws,Losses,Require Approval," +
                        "Level Requirement,Intro,Notice");

                UInt64 ID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 NameLength = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Name = Encoding.UTF8.GetString(packetData, i, NameLength);
                i += NameLength;
                UInt32 EmblemSymbolID = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 EmblemBackgroundID = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 Level = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt32 Exp = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt64 Adena = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt64 BloodCrystal = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 IntroLength = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Intro = Encoding.UTF8.GetString(packetData, i, IntroLength);
                i += IntroLength;
                UInt16 NoticeLength = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Notice = Encoding.UTF8.GetString(packetData, i, NoticeLength);
                i += NoticeLength;
                byte IsPublic = packetData[i];
                i++;
                UInt32 Ranking = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 RankingTotal = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 Reputation = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 LeaderNameLength = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string LeaderName = Encoding.UTF8.GetString(packetData, i, LeaderNameLength);
                i += LeaderNameLength;
                UInt16 SquireCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 GuardCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 KnightCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 CaptainCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 ElderCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                byte RequireApproval = packetData[i];
                i++;
                UInt16 LevelRequirement = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt32 CastleOwned = BitConverter.ToUInt32(packetData, i);
                i += 4;
                string FortressOwned = CSV.fortress.fortressName(BitConverter.ToInt32(packetData, i));
                i += 4;
                UInt32 RedStarStone = BitConverter.ToUInt32(packetData, i);
                i += 4;
                i += 100; // Junk Data
                UInt32 PacketID2 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt64 ID2 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 Name2Length = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Name2 = Encoding.UTF8.GetString(packetData, i, Name2Length);
                i += Name2Length;
                UInt32 Emblem2SymbolID = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 Emblem2BackgroundID = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 Intro2Length = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Intro2 = Encoding.UTF8.GetString(packetData, i, Intro2Length);
                i += Intro2Length;
                UInt16 Level2 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt32 Exp2 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt64 Reputation2 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt32 Spacer = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 Members = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Leader2NameLength = BitConverter.ToUInt16(packetData, i);
                i += 2;
                string Leader2Name = Encoding.UTF8.GetString(packetData, i, Leader2NameLength);
                i += Leader2NameLength;
                UInt64 Adena2 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                byte RequireApproval2 = packetData[i];
                i++;
                UInt16 LevelRequirement2 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Wins = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Draws = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Losses = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt64 CombatPower2 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt64 Unk3 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                byte Unk4 = packetData[i];
                i++;
                Double FortressOccupyDate = Convert.ToDouble(BitConverter.ToUInt64(packetData, i));
                if (FortressOccupyDate>0)
                    FortressOccupyDate = FortressOccupyDate / 60 / 60 / 24 + 25569 - (5 / 24);
                i += 8;
                byte Unk5 = packetData[i];
                i++;
                UInt64 Unk6 = BitConverter.ToUInt64(packetData, i);
                i += 8;
                byte Unk7 = packetData[i];
                i++;
                UInt16 Four = BitConverter.ToUInt16(packetData, i);
                i += 2;
                byte Unk8 = packetData[i];
                i++;
                // DateTime SiegeDate = DateTime.FromBinary(BitConverter.ToUInt64(packetData, i));
                //UInt64 SiegeDate = BitConverter.ToUInt64(packetData, i);
                Double SiegeDate = Convert.ToDouble(BitConverter.ToUInt64(packetData, i));
                SiegeDate = SiegeDate / 60 / 60 / 24 + 25569 - (5 / 24);
                i += 8;
                //UInt64 BidDate = BitConverter.ToUInt64(packetData, i);
                Double BidDate = Convert.ToDouble(BitConverter.ToUInt64(packetData, i));
                BidDate = BidDate / 60 / 60 / 24 + 25569 - (5 / 24);
                i += 8;
                UInt64 CombatPower = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt32 Seven = BitConverter.ToUInt32(packetData, i);
                i += 4;
                byte Unk9 = packetData[i];
                i++;
                //UInt32 Unk10 = BitConverter.ToUInt32(packetData, i);

                Double CastleDate = Convert.ToDouble(BitConverter.ToUInt32(packetData, i));
                CastleDate = CastleDate / 60 / 60 / 24 + 25569 - (5 / 24);
                i += 4;
                UInt16 Unk11 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                byte Unk12 = packetData[i];
                i ++;
                byte Unk13 = packetData[i];
                i++;
                byte Unk14 = packetData[i];
                i++;
                byte Unk14_2 = packetData[i];
                i++;
                UInt32 Unk15 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 Unk15_2 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 CheckinYesterday = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 CheckinToday = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk17 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt32 Unk18 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 Unk18_2 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt16 Unk20 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk21 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk22 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk23 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk24 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk25 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk26 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk27 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk28 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk29 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 Unk30 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                byte Unk32 = packetData[i];

                // Calculates Total Members from Data given for all Clans
                int TMembers = SquireCount + GuardCount + KnightCount + CaptainCount + ElderCount + 1;
                // Calculates Percentage to next level.
                double ExpPer = Convert.ToDouble(CSV.guildLevelUp.guildLevelUpExp(Level));
                ExpPer = Exp / ExpPer * 100;
                
                fileStream.Write(ID + "," + Ranking + "," + Name + "," + LeaderName + "," + Level + "," + Exp + "," + ExpPer + "%," +
                    Reputation + "," + CombatPower + "," + Adena + "," + BloodCrystal + "," + RedStarStone + "," +
                     TMembers + "," + CheckinYesterday + "," + CheckinToday + "," +
                    FortressOwned + ",");
                if (FortressOccupyDate > 0)
                { fileStream.Write(FortressOccupyDate + "," + Wins + "," + Draws + "," + Losses + ","); }
                else
                { fileStream.Write(",,,,"); }
                fileStream.Write(RequireApproval + "," + LevelRequirement + ",\"" + Intro + "\",\"" + Notice + "\"\n");
            }
        }
    }
}
