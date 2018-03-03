using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktNpcMoveNotify
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktNpcMoveNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("NPCID,X Coord, Y Coord, Unk1, Unk2, Move Type,Destination X Coord, Destination Y Coord");

                int i = 0;
                UInt64 NPCID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                Single xpos = BitConverter.ToSingle(packetData, i);
                i += 4;
                Single ypos = BitConverter.ToSingle(packetData, i);
                i += 4;
                Single unk1 = BitConverter.ToSingle(packetData, i);
                i += 4;
                Single unk2 = BitConverter.ToSingle(packetData, i);
                i += 4;
                UInt16 movetype = BitConverter.ToUInt16(packetData, i);
                i += 2;
                Single dxpos = BitConverter.ToSingle(packetData, i);
                i += 4;
                Single dypos = BitConverter.ToSingle(packetData, i);
                i += 4;

                fileStream.WriteLine(NPCID + "," + xpos + "," + ypos + "," + unk1 + "," + unk2 + "," + movetype + "," + dxpos + "," + dypos);
            
            }
        }
    }
}