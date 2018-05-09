using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktChat
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 ChatUID = packet.ReadUInt64();
            UInt64 PlayerUID = packet.ReadUInt64();
            String PlayerName = packet.ReadString();
            String Race = CSV.race.RaceName(packet.ReadInt32());
            String PlayerClass = CSV.Class.className(packet.ReadUInt32());
            DateTime MsgTime = packet.ReadDate();
            String Message = packet.ReadString();
            UInt16 Level = packet.ReadUInt16();
            UInt32 EmblemSymbolID = packet.ReadUInt32();
            UInt32 EmblemBackgroundID = packet.ReadUInt32();

            UInt32 LinkWorldBossID = packet.ReadUInt32();
            UInt32 LinkWorldBossDieID = packet.ReadUInt32();
            UInt32 LinkWorldBossDespawnID = packet.ReadUInt32();

            UInt16 LinkItem = packet.ReadUInt16();
            if (LinkItem > 0) Parser.Pkt.PktLinkItem.Packet(packet);
            UInt16 LinkDungeon = packet.ReadUInt16();
            if (LinkDungeon > 0) Parser.Pkt.PktLinkDungeon.Packet(packet);
            UInt16 LinkGuildDungeon = packet.ReadUInt16();
            if (LinkGuildDungeon > 0) Parser.Pkt.PktLinkGuildDungeon.Packet(packet);

            String LinkVoice = packet.ReadString();
            Byte LinkType = packet.ReadByte();
            UInt32 LinkSpotID = packet.ReadUInt32();
            Byte LanguageType = packet.ReadByte();

        }
    }
}