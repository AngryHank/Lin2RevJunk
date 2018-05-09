using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktBagListReadResult
    {
        public static void Packet(PacketReader packet)
        {

            //1.04.16

            packet.Skip(2);

            UInt16 BagCount = packet.ReadUInt16();
            for (int i = 0; i < BagCount; i++)
            {
                PktBagInfo.Packet(packet);
            }

            

        }
    }
}
