using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktNpcMoveNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktNpcMoveNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("NPCID,X Coord, Y Coord, Unk1, Unk2, Move Type,Destination X Coord, Destination Y Coord");
                }

                UInt64 NPCID = packet.ReadUInt64();
                Single xpos = packet.ReadSingle();
                Single ypos = packet.ReadSingle();
                Single unk1 = packet.ReadSingle();
                Single unk2 = packet.ReadSingle();
                UInt16 movetype = packet.ReadUInt16();
                Single dxpos = packet.ReadSingle();
                Single dypos = packet.ReadSingle();

                fileStream.WriteLine(NPCID + "," + xpos + "," + ypos + "," + unk1 + "," + unk2 + "," + movetype + "," + dxpos + "," + dypos);

            }
        }
    }
}