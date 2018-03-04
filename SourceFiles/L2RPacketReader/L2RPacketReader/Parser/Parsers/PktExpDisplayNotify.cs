using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktPktExpDisplayNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktExpDisplayNotify.csv", true))
            {
                //Writes header for the PktGuildInfoReadresult
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("Exp,Bonus Exp");
                }

                UInt32 Exp = packet.ReadUInt32();
                UInt32 Bonus = packet.ReadUInt32();
                fileStream.WriteLine(Exp + "," + Bonus);
            }
        }
    }
}
