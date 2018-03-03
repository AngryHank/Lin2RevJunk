using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktBagListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktBagListReadresult.csv", true))
            {
                packet.Skip(2);
                UInt16 BagNumber = packet.ReadUInt16();
                byte Unk0 = packet.ReadByte();
                UInt16 MaxInvenSize = packet.ReadUInt16();
                UInt16 ExpInvenSize = packet.ReadUInt16(); 
                UInt16 UsedInvenSize = packet.ReadUInt16(); 

                fileStream.WriteLine("Bag Number, Unk0, Max Inv Size, Expanded Inv Size, Filled Inv Size");
                fileStream.WriteLine(BagNumber + "," + Unk0 + "," + MaxInvenSize + "," + ExpInvenSize + "," + UsedInvenSize + "\n");

                //Writes header for the PktBagListReadresult
                fileStream.WriteLine("UItemID,ItemID,ItemType,Exp,Level,EnchantLevel,LimitBreakCount,LimitBreakAddRate,Count,Liked," +
                    "TimeLooted,BasicOptionLength,Unk1[0],ItemOption[0],IOvalue[0],Unk2[0],Unk1[1],ItemOption[1],IOvalue[1]," +
                    "Unk2[1],Unk1[2],ItemOption[2],IOvalue[2],Unk2[2],Unk3,SocketListLength,Unk5[0],SocketID[0],SocketName[0]," +
                    "SocketCount[0],Unk5[1],SocketID[1],SocketName[1],SocketCount[1],Unk5[2],SocketID[2]," +
                    "SocketName[2],SocketCount[2],Unk5[3],SocketID[3],SocketName[3],SocketCount[3],Unk5[4]," + 
                    "SocketID[4],SocketName[4],SocketCount[4],Unk5[5],SocketID[5],SocketName[5],SocketCount[5]," +
                    "Unk6,Bind,AbilityLevel,AbilityUpgradeAddRate,CraftFlag");


                for (int j = 0; j < UsedInvenSize; j++) {
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
                    byte BasicOptionLength = packet.ReadByte();
                    string[] BasicOption = { ",,,", ",,,", ",,," };
                    for (int k = 0; BasicOptionLength > k; k++)
                    {
                        byte Unk1 = packet.ReadByte();
                        string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
                        UInt16 IOvalue = packet.ReadUInt16();
                        byte Unk2 = packet.ReadByte();
                        BasicOption[k] = Unk1 + ",\"" + ItemOption + "\",+" + IOvalue + "," + Unk2;
                    }
                    byte Unk3 = packet.ReadByte();
                    byte SocketListLength = packet.ReadByte();
                    string[] SocketList = { ",,,", ",,,", ",,,", ",,,", ",,,", ",,," };
                    for (int k = 0; SocketListLength > k; k++)
                    {
                        byte Unk5 = packet.ReadByte();
                        SocketList[k] = Unk5 + ",";
                        UInt64 SocketID = packet.ReadUInt64();
                        SocketList[k] += SocketID + ",\"";
                        string SocketName = CusEnum.Item.Enum(packet.ReadUInt32());
                        packet.Skip(4);
                        SocketList[k] += SocketName + "\",";
                        UInt16 SocketCount = packet.ReadUInt16();
                        SocketList[k] += SocketCount;
                    }
                    byte Unk6 = packet.ReadByte();
                    byte Bind = packet.ReadByte();
                    byte AbilityLevel = packet.ReadByte();
                    UInt16 AbilityUpgradeAddRate = packet.ReadUInt16();
                    byte CraftFlag = packet.ReadByte();

                    fileStream.WriteLine(UItemID + "," + ItemID + "," + Exp + "," + Level + "," + 
                        EnchantLevel + "," + LimitBreakCount + "," + LimitBreakAddRate + "," + Count + 
                        "," + Liked + "," + TimeLooted + "," + BasicOptionLength + "," + BasicOption[0] + 
                        "," + BasicOption[1] + "," + BasicOption[2] + "," + Unk3 + "," + SocketListLength + 
                        "," + SocketList[0] + "," + SocketList[1] + "," + SocketList[2] + "," + SocketList[3] + 
                        "," + SocketList[4] + "," + SocketList[5] + "," + Unk6 + "," + Bind + "," + 
                        AbilityLevel + "," + AbilityUpgradeAddRate + "," + CraftFlag);

                }


            }
        }
    }
}
