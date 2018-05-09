using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktItemSocket

    {
        public static void Packet(PacketReader packet)
        {
            
            // 1.04.16

            UInt64 SoulCrystalID = packet.ReadUInt64();
            string SoulCrystalName = CusEnum.Item.Enum(packet.ReadUInt32());
            Int32 SoulCrystalEXP = packet.ReadInt32();
            byte SoulCrystalLevel = packet.ReadByte();
            UInt16 SocketCount = packet.ReadUInt16();
            for (int i = 0; i < SocketCount; i++) {
                PktItemOption.Packet(packet);
            }            
                    
        }
    }
}