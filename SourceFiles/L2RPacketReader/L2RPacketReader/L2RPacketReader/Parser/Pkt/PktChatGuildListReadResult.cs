using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktChatGuildListReadResult
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16
                
            packet.Skip(2);

            byte IsPrevMessage = packet.ReadByte();
            UInt64 LastChatID = packet.ReadUInt64();
            UInt16 numMessages = packet.ReadUInt16();

            for (int i = 0; i < numMessages; i++)
            {
                Parser.Pkt.PktChat.Packet(packet);
            }
        }
    }
}
