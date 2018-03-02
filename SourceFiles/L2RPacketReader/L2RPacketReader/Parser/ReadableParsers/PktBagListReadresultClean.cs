using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktBagListReadresultClean
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\Inventory.csv", true))
            {
                int i = 2;
                
                UInt16 BagNumber = BitConverter.ToUInt16(packetData, i);
                i += 2;
                byte Unk0 = packetData[i];
                i++;
                UInt16 MaxInvenSize = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 ExpInvenSize = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 UsedInvenSize = BitConverter.ToUInt16(packetData, i);
                i += 2;

                fileStream.WriteLine("Bag Number, Max Inv Size, Expanded Inv Size, Filled Inv Size");
                fileStream.WriteLine(BagNumber +  "," + MaxInvenSize + "," + ExpInvenSize + "," + UsedInvenSize + "\n");

                //Writes header for the PktBagListReadresult
                fileStream.WriteLine("UItemID,Time Looted,Name,Type,Level,Exp,Count,Liked," +
                    "Bind,Item Option,Item Option,Item Option,Socket 1," +
                    "Socket 2,Socket 3,Socket 4, Socket 5,Socket 6," +
                    "Limit Break Count,Limit Break Add Rate,Ability Level,Ability Upgrade Add Rate");

                for (int j = 0; j < UsedInvenSize; j++) { 
                    UInt64 UItemID = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    string ItemID = CusEnum.Item.Enum(BitConverter.ToUInt32(packetData, i));
                    i += 4;
                    UInt32 Exp = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    byte Level = packetData[i];
                    i++;
                    byte EnchantLevel = packetData[i];
                    i++;
                    byte LimitBreakCount = packetData[i];
                    i++;
                    byte LimitBreakAddRate = packetData[i];
                    i++;
                    UInt16 Count = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    byte Liked = packetData[i];
                    i++;
                    Double TimeLooted = Convert.ToDouble(BitConverter.ToUInt64(packetData, i));
                    if (TimeLooted > 0)
                        TimeLooted = TimeLooted / 60 / 60 / 24 + 25569 - (5 / 24);
                    i += 8;
                    byte BasicOptionLength = packetData[i];
                    i++;
                    string[] BasicOption = { "", "", "" };
                    for (int k = 0; BasicOptionLength > k; k++) {
                        byte Unk1 = packetData[i];
                        i++;
                        string ItemOption = CSV.itemOption.itemOptionName(BitConverter.ToInt32(packetData, i));
                        i += 4;
                        UInt16 IOvalue = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        byte Unk2 = packetData[i];
                        i++;
                        BasicOption[k] = "\"" + ItemOption + "\"";
                    }
                    byte Unk3 = packetData[i];
                    i++;
                    byte SocketListLength = packetData[i];
                    i++;
                    string[] SocketList = { "", "", "", "", "", "" };
                    for (int k = 0; SocketListLength > k; k++)
                    {
                        byte Unk5 = packetData[i];
                        i++;
                        UInt64 SocketID = BitConverter.ToUInt64(packetData, i);
                        i += 8;
                        string SocketName = CusEnum.Item.Enum(BitConverter.ToUInt32(packetData, i));
                        i += 8;
                        SocketList[k] = "\"" + SocketName + "\"";
                        UInt16 SocketCount = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                    }
                    byte Unk6 = packetData[i];
                    i++;
                    byte Bind = packetData[i];
                    i++;
                    byte AbilityLevel = packetData[i];
                    i++;
                    UInt16 AbilityUpgradeAddRate = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    byte CraftFlag = packetData[i];
                    i++;

                    string EnchantLevelPlus = "";

                    if (EnchantLevel > 0)
                        EnchantLevelPlus = "+" + EnchantLevel+" ";
                    

                    fileStream.WriteLine(UItemID + TimeLooted + "," + EnchantLevelPlus + ItemID + "," + Level + "," + Exp + "," +
                        Count + "," + Liked + "," + Bind + "," +  BasicOption[0] + 
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
