using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildInfoReadresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\DetailedGuildInfo.csv", true))
            {
                // First two bytes are not used.
                packet.Skip(2);

                //Writes header for the PktGuildInfoReadresult
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("ID,Ranking,Name,Leader,Level,Exp,As Percentage, Reputation,Combat Power,Adena," +
                        "Proof of Blood,Red Star Stone,Members,Checked in Yesterday,Checked in Today," +
                        "Fortress Owned,Fortress Occupy Date,Wins,Draws,Losses,Require Approval," +
                        "Level Requirement,Intro,Notice");

                UInt64 ID = packet.ReadUInt64();
                string Name = packet.ReadString();
                UInt32 EmblemSymbolID = packet.ReadUInt32();
                UInt32 EmblemBackgroundID = packet.ReadUInt32();
                UInt16 Level = packet.ReadUInt16();
                UInt32 Exp = packet.ReadUInt32();
                UInt64 Adena = packet.ReadUInt64();
                UInt64 BloodCrystal = packet.ReadUInt64();
                string Intro = packet.ReadString();
                string Notice = packet.ReadString();
                byte IsPublic = packet.ReadByte();
                UInt32 Ranking = packet.ReadUInt32();
                UInt32 RankingTotal = packet.ReadUInt32();
                UInt32 Reputation = packet.ReadUInt32();
                string LeaderName = packet.ReadString();
                UInt16 SquireCount = packet.ReadUInt16();
                UInt16 GuardCount = packet.ReadUInt16();
                UInt16 KnightCount = packet.ReadUInt16();
                UInt16 CaptainCount = packet.ReadUInt16();
                UInt16 ElderCount = packet.ReadUInt16();
                byte RequireApproval = packet.ReadByte();
                UInt16 LevelRequirement = packet.ReadUInt16();
                UInt32 CastleOwned = packet.ReadUInt32();
                string FortressOwned = CSV.fortress.fortressName(packet.ReadInt32());
                UInt32 RedStarStone = packet.ReadUInt32();
                packet.Skip(100); // Junk Data
                UInt32 PacketID2 = packet.ReadUInt32();
                UInt64 ID2 = packet.ReadUInt64();
                string Name2 = packet.ReadString();
                UInt32 Emblem2SymbolID = packet.ReadUInt32();
                UInt32 Emblem2BackgroundID = packet.ReadUInt32();
                string Intro2 = packet.ReadString();
                UInt16 Level2 = packet.ReadUInt16();
                UInt32 Exp2 = packet.ReadUInt32();
                UInt64 Reputation2 = packet.ReadUInt64();
                UInt32 Spacer = packet.ReadUInt32();
                UInt16 Members = packet.ReadUInt16();
                string Leader2Name = packet.ReadString();
                UInt64 Adena2 = packet.ReadUInt64();
                byte RequireApproval2 = packet.ReadByte();
                UInt16 LevelRequirement2 = packet.ReadUInt16();
                UInt16 Wins = packet.ReadUInt16();
                UInt16 Draws = packet.ReadUInt16();
                UInt16 Losses = packet.ReadUInt16();
                UInt64 CombatPower2 = packet.ReadUInt64();
                UInt64 Unk3 = packet.ReadUInt64();
                byte Unk4 = packet.ReadByte();
                Double FortressOccupyDate = Convert.ToDouble(packet.ReadUInt64());
                if (FortressOccupyDate > 0)
                {
                    FortressOccupyDate = FortressOccupyDate / 60 / 60 / 24 + 25569 - (5 / 24);
                }
                byte Unk5 = packet.ReadByte();
                UInt64 Unk6 = packet.ReadUInt64();
                byte Unk7 = packet.ReadByte();
                UInt16 Four = packet.ReadUInt16();
                byte Unk8 = packet.ReadByte();
                Double SiegeDate = Convert.ToDouble(packet.ReadUInt64());
                SiegeDate = SiegeDate / 60 / 60 / 24 + 25569 - (5 / 24);
                Double BidDate = Convert.ToDouble(packet.ReadUInt64());
                BidDate = BidDate / 60 / 60 / 24 + 25569 - (5 / 24);
                UInt64 CombatPower = packet.ReadUInt64();
                UInt32 Seven = packet.ReadUInt32();
                byte Unk9 = packet.ReadByte();

                Double CastleDate = Convert.ToDouble(packet.ReadUInt32());
                CastleDate = CastleDate / 60 / 60 / 24 + 25569 - (5 / 24);
                UInt16 Unk11 = packet.ReadUInt16();
                byte Unk12 = packet.ReadByte();
                byte Unk13 = packet.ReadByte();
                byte Unk14 = packet.ReadByte();
                byte Unk14_2 = packet.ReadByte();
                UInt32 Unk15 = packet.ReadUInt32();
                UInt32 Unk15_2 = packet.ReadUInt32();
                UInt16 CheckinYesterday = packet.ReadUInt16();
                UInt16 CheckinToday = packet.ReadUInt16();
                UInt16 Unk17 = packet.ReadUInt16();
                UInt32 Unk18 = packet.ReadUInt32();
                UInt32 Unk18_2 = packet.ReadUInt32();
                UInt16 Unk20 = packet.ReadUInt16();
                UInt16 Unk21 = packet.ReadUInt16();
                UInt16 Unk22 = packet.ReadUInt16();
                UInt16 Unk23 = packet.ReadUInt16();
                UInt16 Unk24 = packet.ReadUInt16();
                UInt16 Unk25 = packet.ReadUInt16();
                UInt16 Unk26 = packet.ReadUInt16();
                UInt16 Unk27 = packet.ReadUInt16();
                UInt16 Unk28 = packet.ReadUInt16();
                UInt16 Unk29 = packet.ReadUInt16();
                UInt16 Unk30 = packet.ReadUInt16();
                byte Unk32 = packet.ReadByte();

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
