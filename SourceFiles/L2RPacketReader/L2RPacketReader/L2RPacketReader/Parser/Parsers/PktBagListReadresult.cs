using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktBagListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            
            using (StreamWriter fileStream = new StreamWriter(@"Output\Inventory.csv", true))
            {
                packet.Skip(2);

                UInt16 BagNumber = packet.ReadUInt16();
                byte Unk0 = packet.ReadByte();
                UInt16 MaxInvenSize = packet.ReadUInt16();
                UInt16 ExpInvenSize = packet.ReadUInt16();
                UInt16 UsedInvenSize = packet.ReadUInt16();

                fileStream.WriteLine("Bag Number, Max Inv Size, Expanded Inv Size, Filled Inv Size");
                fileStream.WriteLine(BagNumber + "," + MaxInvenSize + "," + ExpInvenSize + "," + UsedInvenSize + "\n");

                //Writes header for the PktBagListReadresult
                fileStream.WriteLine("UItemID,Time Looted,Name,Type,Level,Exp,Count,Liked," +
                    "Bind,Item Option,Item Option,Item Option,Socket 1," +
                    "Socket 2,Socket 3,Socket 4, Socket 5,Socket 6," +
                    "Limit Break Count,Limit Break Add Rate,Ability Level,Ability Upgrade Add Rate");

                for (int j = 0; j < UsedInvenSize; j++)
                {
                    UInt64 UItemID = packet.ReadUInt64();
                    string ItemID = CusEnum.Item.Enum(packet.ReadUInt32());
                    UInt32 Exp = packet.ReadUInt32();
                    byte Level = packet.ReadByte();
                    byte EnchantLevel = packet.ReadByte();
                    byte LimitBreakCount = packet.ReadByte();
                    byte LimitBreakAddRate = packet.ReadByte();
                    UInt16 Count = packet.ReadUInt16();
                    byte Liked = packet.ReadByte();
                    Double TimeLooted = Convert.ToDouble(packet.ReadUInt64());
                    if (TimeLooted > 0)
                    {
                        TimeLooted = TimeLooted / 60 / 60 / 24 + 25569 - (5 / 24);
                    }
                    UInt16 BasicOptionLength = packet.ReadUInt16();
                    string[] BasicOption = { "", "", "" };
                    for (int k = 0; BasicOptionLength > k; k++)
                    {
                        string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
                        UInt32 IOvalue = packet.ReadUInt32();
                        BasicOption[k] = "\"" + ItemOption + "(+" + IOvalue + ")\"";
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
                    UInt16 CraftFlag = packet.ReadUInt16();
                    UInt16 EventPeriodID = packet.ReadUInt16();
                    if (EventPeriodID == 0)
                        packet.Skip(1);

                    string EnchantLevelPlus = "";

                    if (EnchantLevel > 0)
                        EnchantLevelPlus = "+" + EnchantLevel + " ";


                    fileStream.WriteLine(UItemID + "," + TimeLooted + "," + EnchantLevelPlus + ItemID + "," + Level + "," + Exp + "," +
                        Count + "," + Liked + "," + Bind + "," + BasicOption[0] +
                        "," + BasicOption[1] + "," + BasicOption[2] +
                        "," + SocketList[0] + "," + SocketList[1] + "," + SocketList[2] + "," + SocketList[3] +
                        "," + SocketList[4] + "," + SocketList[5] + "," + LimitBreakCount + "," + LimitBreakAddRate + "," +
                        AbilityLevel + "," + AbilityUpgradeAddRate);

                }
                fileStream.WriteLine("\n\n");
            }

        }
    }
}
