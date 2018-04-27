using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class pktPartyEmblem
    {
        public static void Packet(PacketReader packet)
        {

            string PartyName = packet.ReadString();
            byte Bool = packet.ReadByte();
 
        }
    }
}