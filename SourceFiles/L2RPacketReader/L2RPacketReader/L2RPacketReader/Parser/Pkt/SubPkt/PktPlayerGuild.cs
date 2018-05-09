using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktPlayerGuild
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 GuildID = packet.ReadUInt64();
            byte GuildMembersGrade = packet.ReadByte();

            string GuildName = packet.ReadString();
            UInt32 EmblemSymbolInfoID = packet.ReadUInt32();
            UInt32 EmblemBackgroundInfoID = packet.ReadUInt32();
            UInt32 OccupyTitleInfoID = packet.ReadUInt32();
            byte CastleType = packet.ReadByte();
    
        }
    }
}