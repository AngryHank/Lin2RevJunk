using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktLinkDungeon
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 WorldID = packet.ReadUInt64();
            UInt32 SummonGemID = packet.ReadUInt32();
        }
    }
}