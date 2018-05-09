using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktChatWorldWriteNotify
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            //packet.Skip(2);

                Parser.Pkt.PktChat.Packet(packet);
        }
    }
}
