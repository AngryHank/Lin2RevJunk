using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktPlayerMoveListNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktPlayerMoveListNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("PlayerID,Move Type,Destination X Coord,Destination Y Coord");
                }

                UInt64 PlayerID = packet.ReadUInt64();
                UInt16 movetype = packet.ReadUInt16();
                Single dxpos = packet.ReadSingle();
                Single dypos = packet.ReadSingle();

                fileStream.WriteLine(PlayerID + "," + movetype + "," + dxpos + "," + dypos);

            }
        }
    }
}