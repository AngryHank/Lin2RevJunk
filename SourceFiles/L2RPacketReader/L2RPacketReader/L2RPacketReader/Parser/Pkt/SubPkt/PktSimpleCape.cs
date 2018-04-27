using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktSimpleCape
    {
        public static void Packet(PacketReader packet)
        {
            UInt32 CapeInfoID = packet.ReadUInt32();
            UInt16 CapeLevel = packet.ReadUInt16();
            UInt32 ColorSymbolInfoID = packet.ReadUInt32();
            UInt32 ColorBackgroundInfoID = packet.ReadUInt32();
        }
    }
}