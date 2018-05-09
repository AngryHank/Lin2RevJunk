using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktBagInfo
    {
        public static void Packet(PacketReader packet)
        {
            
            //1.04.16
            
            byte Type = packet.ReadByte();
            UInt16 EnabledSlotCount = packet.ReadUInt16();
            UInt16 ExpandedCount = packet.ReadUInt16();

            UInt16 ItemCount = packet.ReadUInt16();
            for (int j = 0; j < ItemCount; j++)
            {
                PktItem.Packet(packet);
            }
        }

    }
}