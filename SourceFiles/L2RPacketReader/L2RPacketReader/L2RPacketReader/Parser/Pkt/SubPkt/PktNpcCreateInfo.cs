using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktNpcCreateInfo
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            PktNpc.Packet(packet);

            UInt16 NPCMoving = packet.ReadUInt16();
            // PktNpcMoveInfo
            for (int i = 0; i < NPCMoving; i++)
            {
                PktNpcMoveInfo.Packet(packet);
            }

            
            string OwnerName = packet.ReadString();

            UInt64 TargetID = packet.ReadUInt64();
        }
    }
}