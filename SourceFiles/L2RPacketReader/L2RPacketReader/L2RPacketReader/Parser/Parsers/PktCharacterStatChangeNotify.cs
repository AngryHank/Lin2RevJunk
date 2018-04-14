using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktCharacterStatChangeNotify
    {
        public static void Packet(PacketReader packet)
        {
            if (packet.Remaining == 46)
            {
                using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLootedTest.csv", true))
                {
                    packet.Skip(38);
                    fileStream.Write("," + packet.ReadUInt32());
                    Globals.lootIndex = 2;
                }
            }
            else if(packet.Remaining == 37)
            {
                using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLootedTest.csv", true))
                {
                    packet.Skip(29);
                    fileStream.Write("," + packet.ReadUInt32());
                    Globals.lootIndex = 2;
                }
            }
            else
            {
 /*               using (FileStream fileStream = new FileStream(@"Packets\CSC(" + packet.Remaining + ").dat", FileMode.Append, FileAccess.Write, FileShare.Write))
                {
                    for (int j = 0; j < packet.Remaining;)
                    {
                        fileStream.WriteByte(packet.ReadByte());
                    }
                }*/
            }
        }

    }
}
