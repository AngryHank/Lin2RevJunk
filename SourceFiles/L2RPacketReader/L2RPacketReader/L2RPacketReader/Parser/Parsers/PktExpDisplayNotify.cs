using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktPktExpDisplayNotify
    {
        public static void Packet(PacketReader packet)
        {
            Globals.lootIndex = 1;
            using (StreamWriter fileStreamer = new StreamWriter(@"Output\ItemsLootedTest.csv", true))
            {

                UInt32 Exp = packet.ReadUInt32();
                UInt32 Bonus = packet.ReadUInt32();
                fileStreamer.Write("\n" + Exp + "," + Bonus);
            }
        }
    }
}
