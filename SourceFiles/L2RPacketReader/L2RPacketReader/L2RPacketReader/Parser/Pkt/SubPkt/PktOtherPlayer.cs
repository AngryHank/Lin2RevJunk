using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktOtherPlayer
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 PlayerUID = packet.ReadUInt64();
            string PlayerName = packet.ReadString();
            UInt32 Race = packet.ReadUInt32();
            UInt32 Class = packet.ReadUInt32();
            UInt16 Level = packet.ReadUInt16();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            UInt32 CurHP = packet.ReadUInt32();
            UInt32 MaxHP = packet.ReadUInt32();
            UInt32 MoveSpeed = packet.ReadUInt32();
    
    
            UInt16 BuffCount = packet.ReadUInt16();
            // PktBuffInfo
            for (int i = 0;i<BuffCount;i++)
            {
                PktBuffInfo.Packet(packet);
            }
    
            byte CombatMode = packet.ReadByte();
            byte SoulShotEnabled = packet.ReadByte();
            byte PKStatus = packet.ReadByte();
            byte PKAttackState = packet.ReadByte();
            UInt32 PKPoint = packet.ReadUInt32();

            // PktAppearance
            PktAppearance.Packet(packet);


            UInt16 EquipCount = packet.ReadUInt16();
            // PktSimpleEquipment
            for (int i=0;i<EquipCount;i++)
            {
                PktSimpleEquipment.Packet(packet);
            }
    
    
            UInt64 TeamID = packet.ReadUInt64();
            UInt64 ControlGadgetID = packet.ReadUInt64();
    
            byte Guilded = packet.ReadByte();
            // PktPlayerGuild
            if (Guilded > 0)
            {
                PktPlayerGuild.Packet(packet);
            }
    
            UInt32 RidingPetInfoID = packet.ReadUInt32();
            UInt16 RidingPetLevel = packet.ReadUInt16();
            byte RidingPetGrade = packet.ReadByte();
    
            UInt32 EquippedTitleInfoID = packet.ReadUInt32();
    
            //pktPartyEmblem
            byte SetEmblem = packet.ReadByte();
            if (SetEmblem > 0)
                {
                    pktPartyEmblem.Packet(packet);
                }

            //PktSimpleCape
            PktSimpleCape.Packet(packet);

            //PktPKMode
            PktPKMode.Packet(packet);

            UInt32 CurBarrier = packet.ReadUInt32();
            UInt32 MaxBarrier = packet.ReadUInt32();
            byte IsCostumeHidden = packet.ReadByte();
        }
    }
}