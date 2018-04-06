using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktItemLootNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (FileStream fileStream = new FileStream(@"Packets\" + packet.Remaining + "loot.dat", FileMode.Append, FileAccess.Write, FileShare.Write))
            {
                for (int i = 0; i < packet.Remaining; i++)
                {
                    fileStream.WriteByte(packet.ReadByte());
                }
            }
        }

    }
}
