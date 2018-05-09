using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktAppearance
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            byte HairID = packet.ReadByte();
            byte HairStyleID = packet.ReadByte();
            byte HairColorID = packet.ReadByte();
        }
    }
}