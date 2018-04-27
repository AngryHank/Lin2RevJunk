using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktPKMode
    {
        public static void Packet(PacketReader packet)
        {
            byte PkStatus = packet.ReadByte();
            byte Monster = packet.ReadByte();
            byte Guild = packet.ReadByte();
            byte Alliance = packet.ReadByte();
            byte Friends = packet.ReadByte();
            byte EtcPlayer = packet.ReadByte();
            byte BadPlayer = packet.ReadByte();
        }
    }
}