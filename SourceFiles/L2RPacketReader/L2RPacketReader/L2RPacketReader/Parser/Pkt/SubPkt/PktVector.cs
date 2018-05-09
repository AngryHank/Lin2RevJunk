using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktVector
    {

        // 1.04.16

        public static void Packet(PacketReader packet)
        {
            float DestinationXPos = packet.ReadSingle();
            float DestinationYPos = packet.ReadSingle();
        }
    }
}