using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktNpc
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 NPCUID = packet.ReadUInt64();
            UInt32 NPCID = packet.ReadUInt32();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            UInt32 CurrentHP = packet.ReadUInt32();
            UInt32 MaxHP = packet.ReadUInt32();
            UInt32 MoveSpeed = packet.ReadUInt32();

            UInt16 BuffCount = packet.ReadUInt16();
            // PktBuffInfo
            for (int i = 0; i < BuffCount; i++)
            {
                PktBuffInfo.Packet(packet);
            }

            byte CombatMode = packet.ReadByte();
            UInt32 SpawnInfoId = packet.ReadUInt32();
            UInt64 TeamID = packet.ReadUInt64();
        }
    }
}