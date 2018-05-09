using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktLinkItem
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16
            
            byte Level = packet.ReadByte();
            byte EnchantLevel = packet.ReadByte();
            byte LimitBreakCount = packet.ReadByte();
            UInt16 Count = packet.ReadUInt16();
            UInt16 BasicOptionLength = packet.ReadUInt16();
            string[] BasicOption = { "", "", "" };
            for (int k = 0; BasicOptionLength > k; k++)
            {
                PktItemOption.Packet(packet);
            }
            byte Bind = packet.ReadByte();
            byte AbilityLevel = packet.ReadByte();
        }
    }
}