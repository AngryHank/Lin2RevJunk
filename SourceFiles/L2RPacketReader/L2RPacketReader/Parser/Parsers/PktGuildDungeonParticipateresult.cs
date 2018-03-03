using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildDungeonParticipateresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktGuildDungeonParticipateresult.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                packet.Skip(2);
                UInt16 itemCount = packet.ReadUInt16();

                // Doing Items as sloppy as I know how!
                int[] Unk1 = new int[itemCount];
                int[] Unk2 = new int[itemCount];
                int[] Unk3 = new int[itemCount];
                int[] Unk4 = new int[itemCount];
                byte[] Unk5 = new byte[itemCount];
                int[] ItemID = new int[itemCount];
                int[] ItemCount = new int[itemCount];
                for (int l = 0; l < itemCount; l++) {
                    Unk1[l] = packet.ReadInt32();
                    Unk2[l] = packet.ReadInt32();
                    ItemID[l] = packet.ReadInt32();
                    ItemCount[l] = packet.ReadInt16();
                    Unk3[l] = packet.ReadInt32();
                    Unk4[l] = packet.ReadInt32();
                    Unk5[l] = packet.ReadByte();
                }

                UInt16 PlayerCount = packet.ReadUInt16();
                // Doing it again for the players!
                long[] PlayerID = new long[PlayerCount];
                string[] Name = new string[PlayerCount];
                double[] Damage = new double[PlayerCount];
                byte[] Unk6 = new byte[PlayerCount];
                for (int l = 0; l < PlayerCount; l++)
                {
                    PlayerID[l] = packet.ReadInt64();
                    Name[l] = packet.ReadString();
                    Damage[l] = Convert.ToDouble(packet.ReadInt32());
                    Damage[l] = Damage[l] / 100;
                    Unk6[l] = packet.ReadByte();
                }

                UInt16 unk7 = packet.ReadUInt16();
                UInt32 unk8 = packet.ReadUInt32();
                String Time = Misc.Misc.CalcTime(packet.ReadUInt32());
                UInt32 unk9 = packet.ReadUInt32();

                //Write
                fileStream.WriteLine("Time: " + Time);
                fileStream.WriteLine("PlayerCount: " + PlayerCount);
                fileStream.WriteLine("itemCount: " + itemCount);
                fileStream.WriteLine("unk7: " + unk7);
                fileStream.WriteLine("unk8: " + unk8);
                fileStream.WriteLine("unk9: " + unk9);

                fileStream.WriteLine("\nUnk1, Unk2, ItemID, ItemCount, Unk3, Unk4, Unk5");
                for (int l = 0; l < itemCount; l++)
                {
                    fileStream.WriteLine(Unk1[l] + "," + Unk2[l] + "," + ItemID[l] + "," +
                        ItemCount[l] + "," + Unk3[l] + "," + Unk4[l] + "," + Unk5[l]);
                }

                fileStream.WriteLine("\nPlayerID,Name,Damage,Unk6");
                for (int l = 0; l < PlayerCount; l++)
                {
                    fileStream.WriteLine(PlayerID[l] + "," + 
                        Name[l] + "," + Damage[l] + "%," + Unk6[l]);
                }
                fileStream.WriteLine("\n\n");
             
            }
        }
    }
}
