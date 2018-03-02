using System;
using System.IO;
using System.Text;
using L2RPacketReader.CusEnum;
using L2RPacketReader.Misc;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildDungeonParticipateresultClean
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\ClanDungeonResults.csv", true))
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
                string[] ItemID = new string[itemCount];
                int[] ItemCount = new int[itemCount];
                for (int l = 0; l < itemCount; l++) {
                    Unk1[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    Unk2[l] = BitConverter.ToInt32(packetData, i);
                    i += 4;
                    ItemID[l] = CusEnum.Item.Enum(BitConverter.ToUInt32(packetData, i));
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

                fileStream.WriteLine("\nItem ID, Item Count");
                for (int l = 0; l < itemCount; l++)
                {
                    fileStream.WriteLine(ItemID[l] + "," + ItemCount[l]);
                }

                fileStream.WriteLine("\nPlayer ID,Name,Damage");
                for (int l = 0; l < PlayerCount; l++)
                {
                    fileStream.WriteLine(PlayerID[l] + "," + Name[l] + "," + Damage[l] + "%");
                }
                fileStream.WriteLine("\n\n");
             
            }
        }
    }
}
