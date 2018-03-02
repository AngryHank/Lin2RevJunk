using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktPlayerMoveListNotify
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktPlayerMoveListNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("PlayerID,Move Type,Destination X Coord,Destination Y Coord");

                int i = 0;
                UInt64 PlayerID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                UInt16 movetype = BitConverter.ToUInt16(packetData, i);
                i += 2;
                Single dxpos = BitConverter.ToSingle(packetData, i);
                i += 4;
                Single dypos = BitConverter.ToSingle(packetData, i);
                i += 4;

                fileStream.WriteLine(PlayerID + "," + movetype + "," + dxpos + "," + dypos);
            
            }
        }
    }
}