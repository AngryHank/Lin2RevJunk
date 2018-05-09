using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktItemOption
    
    {
        public static void Packet(PacketReader packet)
        {
            
            // 1.04.16

            string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
            UInt32 IOvalue = packet.ReadUInt32();
 
            
                    
        }
    }
}