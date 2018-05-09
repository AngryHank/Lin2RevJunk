using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktPktExpDisplayNotify
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16
            
            UInt32 Exp = packet.ReadUInt32();
            UInt32 Bonus = packet.ReadUInt32();
        }
    }
}
