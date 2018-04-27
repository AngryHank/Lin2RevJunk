using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktNpcMoveInfo
    {
        public static void Packet(PacketReader packet)
        {
            float DestinationXPos = packet.ReadSingle();
            float DestinationYPos = packet.ReadSingle();
        }
    }
}