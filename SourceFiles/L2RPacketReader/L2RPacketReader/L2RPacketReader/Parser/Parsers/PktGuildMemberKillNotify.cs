using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildMemberKillNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStreamer = new StreamWriter(@"Output\GuildPvp.Txt", true))
            {

                string ClanName = packet.ReadString();
                string PlayerName = packet.ReadString();
                string Clan2Name = packet.ReadString();
                string Player2Name = packet.ReadString();
                // Unknown Int32, Unknown byte
                fileStreamer.WriteLine(PlayerName + "(" + ClanName + ") Killed " + Player2Name + "(" + Clan2Name + ").");
            }
        }
    }
}
