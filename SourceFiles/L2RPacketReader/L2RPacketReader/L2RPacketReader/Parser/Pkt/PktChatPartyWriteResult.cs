using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktChatPartyWriteResult
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            //packet.Skip(2);

            UInt16 numMessages = packet.ReadUInt16();

            for (int i = 0; i < numMessages; i++)
            {
                Parser.Pkt.PktChat.Packet(packet);
            }
        }
    }
}
