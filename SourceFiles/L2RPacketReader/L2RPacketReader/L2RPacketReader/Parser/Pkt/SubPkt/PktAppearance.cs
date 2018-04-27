using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktAppearance
    {
        public static void Packet(PacketReader packet)
        {
            byte HairID = packet.ReadByte();
        }
    }
}