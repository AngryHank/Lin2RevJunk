using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktItem
    
    {
        public static void Packet(PacketReader packet)
        {
            
            // 1.04.16

            UInt64 UItemID = packet.ReadUInt64();
            string ItemID = CusEnum.Item.Enum(packet.ReadUInt32());
            UInt32 Exp = packet.ReadUInt32();
            byte Level = packet.ReadByte();
            byte EnchantLevel = packet.ReadByte();
            byte LimitBreakCount = packet.ReadByte();
            byte LimitBreakAddRate = packet.ReadByte();
            UInt16 Count = packet.ReadUInt16();
            byte Liked = packet.ReadByte();
            DateTime LootedTime = packet.ReadDate();
            UInt16 BasicOptionLength = packet.ReadUInt16();
            string[] BasicOption = { "", "", "" };
            for (int k = 0; BasicOptionLength > k; k++)
            {
                PktItemOption.Packet(packet);
            }
            UInt16 SocketListLength = packet.ReadUInt16();
            string[] SocketList = { "", "", "", "", "", "" };
            for (int k = 0; SocketListLength > k; k++)
            {
                UInt64 SocketID = packet.ReadUInt64();
                string SocketName = CusEnum.Item.Enum(packet.ReadUInt32());
                packet.Skip(4);
                SocketList[k] = "\"" + SocketName + "\"";
                UInt16 SocketCount = packet.ReadUInt16();
                packet.Skip(1);
            }
            byte Bind = packet.ReadByte();
            byte AbilityLevel = packet.ReadByte();
            UInt16 AbilityUpgradeAddRate = packet.ReadUInt16();
            byte CraftFlag = packet.ReadByte();
            UInt32 EventPeriodID = packet.ReadUInt32();
            UInt64 ExpireTime = packet.ReadUInt64();

            
                    
                }
            }

        }