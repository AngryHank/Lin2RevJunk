using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktItemLootNotify
    {
        public static void Packet(PacketReader packet)
        {
            String itemlist = "";
            packet.Skip(2);
            UInt16 ComplexCounter = packet.ReadUInt16();
            for (int j = 0; j < ComplexCounter; j++)
            {
                UInt64 UItemID = packet.ReadUInt64();
                string ItemID = CusEnum.Item.Enum(packet.ReadUInt32());
                packet.Skip(4);//Junk
                UInt32 Count = packet.ReadUInt32();
                byte Unknown = packet.ReadByte();
                packet.Skip(2);//Junk?
                DateTime LootTime = packet.ReadDate();
                packet.Skip(2);//Junk?
                UInt16 UnkCounter = packet.ReadUInt16(); // All data seems blank
                for (int i = 0; i < UnkCounter; i++)
                {
                    packet.Skip(19);
                }
                byte UnkBool1 = packet.ReadByte();//One of these must be bind
                byte UnkBool2 = packet.ReadByte();
                packet.Skip(7);

                itemlist += ",\"" + ItemID + "\"," + Count;
            }
            UInt16 SimpleCounter = packet.ReadUInt16();
            for (int j = 0; j < SimpleCounter; j++)
            {
                UInt64 UItemID = packet.ReadUInt64();
                string ItemID = CusEnum.Item.Enum(packet.ReadUInt32());
                UInt16 Count = packet.ReadUInt16();
                DateTime LootTime = packet.ReadDate();
                byte Bind = packet.ReadByte();//One of these must be bind
                UInt32 EventPeriodID = packet.ReadUInt32();

                itemlist += ",\"" + ItemID + "\"," + Count;
            }
            UInt16 MultiCounter = packet.ReadUInt16();
            for (int j = 0; j < MultiCounter; j++)
            {
                UInt64 UItemID = packet.ReadUInt64();
                UInt16 Count = packet.ReadUInt16();
                UInt16 Stack = packet.ReadUInt16();
                itemlist += "," + UItemID + " (" + Stack  + ")," + Count;
            }
            packet.Skip(2);
            byte LooterType = packet.ReadByte();
            UInt32 NPCInfoID = packet.ReadUInt32();
            using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLootedTest.csv", true))
            {
                if (Globals.lootIndex == 1)
                    fileStream.Write(",");
                fileStream.Write("," + NPCInfoID + "," + itemlist);

            }


            }

            }

    }
