using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktChatPartyWriteNotify
    {
        public static void Packet(PacketReader packet)
        {

                // 1.04.16

            //Packet.skip(2);
           Parser.Pkt.PktChat.Packet(packet);
        }
    }
}
