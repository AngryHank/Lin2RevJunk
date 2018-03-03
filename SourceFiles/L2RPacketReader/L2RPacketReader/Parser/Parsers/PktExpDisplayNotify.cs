using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktPktExpDisplayNotify
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktExpDisplayNotify.csv", true))
            {
                int i = 0;
                //Writes header for the PktGuildInfoReadresult
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("Exp,Bonus Exp");
                UInt32 Exp = BitConverter.ToUInt32(packetData, i);
                i += 4;
                UInt32 Bonus = BitConverter.ToUInt32(packetData, i);
                i += 4;
                fileStream.WriteLine(Exp + "," + Bonus);
            }
        }
    }
}
