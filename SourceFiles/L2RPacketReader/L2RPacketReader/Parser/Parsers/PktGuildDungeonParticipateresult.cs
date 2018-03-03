using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildDungeonParticipateresult
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktGuildDungeonParticipateresult.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                int i = 2;
                UInt16 itemCount = BitConverter.ToUInt16(packetData, i);
                i += 2;

                // Doing Items as sloppy as I know how!
                int[] Unk1 = new int[itemCount] ;
                int[] Unk2 = new int[itemCount];
                int[] Unk3 = new int[itemCount];
                int[] Unk4 = new int[itemCount];
                byte[] Unk5 = new byte[itemCount];
                int[] ItemID = new int[itemCount];
                int[] ItemCount = new int[itemCount];
                for (int l = 0; l < itemCount; l++) {
                    Unk1[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    Unk2[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    ItemID[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    ItemCount[l] = BitConverter.ToInt16(packetData, i);
                    i += 2;
                    Unk3[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    Unk4[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    Unk5[l] = packetData[i];
                    i += 1;
                }

                UInt16 PlayerCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                // Doing it again for the players!
                long[] PlayerID = new long[PlayerCount];
                short[] NameLength = new short[PlayerCount];
                string[] Name = new string[PlayerCount];
                double[] Damage = new double[PlayerCount];
                byte[] Unk6 = new byte[PlayerCount];
                for (int l = 0; l < PlayerCount; l++)
                {
                    PlayerID[l] = BitConverter.ToInt64(packetData, i);
                    i += 8;
                    NameLength[l] = BitConverter.ToInt16(packetData, i);
                    i += 2;
                    Name[l] = Encoding.UTF8.GetString(packetData, i, NameLength[l]);
                    i += NameLength[l];
                    Damage[l] = Convert.ToDouble(BitConverter.ToInt32(packetData, i));
                    Damage[l] = Damage[l] / 100;
                    i += 4;
                    Unk6[l] = packetData[i];
                    i += 1;
                }

                UInt16 unk7 = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt32 unk8 = BitConverter.ToUInt32(packetData, i);
                i += 4;
                String Time = Misc.Misc.CalcTime(BitConverter.ToUInt32(packetData, i));
                i += 4;
                UInt32 unk9 = BitConverter.ToUInt32(packetData, i);
                i += 4;

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

                fileStream.WriteLine("\nPlayerID,NameLength,Name,Damage,Unk6");
                for (int l = 0; l < PlayerCount; l++)
                {
                    fileStream.WriteLine(PlayerID[l] + "," + NameLength[l] + "," + 
                        Name[l] + "," + Damage[l] + "%," + Unk6[l]);
                }
                fileStream.WriteLine("\n\n");
             
            }
        }
    }
}
