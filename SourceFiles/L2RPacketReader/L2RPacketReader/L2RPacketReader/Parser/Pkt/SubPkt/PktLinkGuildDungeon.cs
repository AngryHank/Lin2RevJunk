using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktLinkGuildDungeon
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 DungeonInfoID = packet.ReadUInt64();
            UInt32 GuildUID = packet.ReadUInt32();
        }
    }
}