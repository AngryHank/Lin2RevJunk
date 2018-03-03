using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktBagListReadresult
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktBagListReadresult.csv", true))
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

                fileStream.WriteLine("Bag Number, Unk0, Max Inv Size, Expanded Inv Size, Filled Inv Size");
                fileStream.WriteLine(BagNumber + "," + Unk0 + "," + MaxInvenSize + "," + ExpInvenSize + "," + UsedInvenSize + "\n");

                //Writes header for the PktBagListReadresult
                fileStream.WriteLine("UItemID,ItemID,Exp,Level,EnchantLevel,LimitBreakCount,LimitBreakAddRate,Count,Liked," +
                    "TimeLooted,BasicOptionLength,Unk1[0],ItemOption[0],IOvalue[0],Unk2[0],Unk1[1],ItemOption[1],IOvalue[1]," +
                    "Unk2[1],Unk1[2],ItemOption[2],IOvalue[2],Unk2[2],Unk3,SocketListLength,Unk4,SocketID[0],SocketName[0]," +
                    "SocketCount[0],Unk5[0],SocketID[1],SocketName[1],SocketCount[1],Unk5[1],SocketID[2]," +
                    "SocketName[2],SocketCount[2],Unk5[2],SocketID[3],SocketName[3],SocketCount[3],Unk5[3]," + 
                    "SocketID[4],SocketName[4],SocketCount[4],Unk5[4],SocketID[5],SocketName[5],SocketCount[5]," +
                    "Unk5[5],Unk6,Bind,AbilityLevel,AbilityUpgradeAddRate,CraftFlag");


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
                    string[] BasicOption = { ",,,", ",,,", ",,," };
                    for (int k = 0; BasicOptionLength > k; k++) {
                        byte Unk1 = packetData[i];
                        i++;
                        string ItemOption = CSV.itemOption.itemOptionName(BitConverter.ToInt32(packetData, i));
                        i += 4;
                        UInt16 IOvalue = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        byte Unk2 = packetData[i];
                        i++;
                        BasicOption[k] = Unk1 + ",\"" + ItemOption + "\",+" + IOvalue + "," + Unk2;
                    }
                    byte Unk3 = packetData[i];
                    i++;
                    byte SocketListLength = packetData[i];
                    i++;
                    string[] SocketList = { ",,,", ",,,", ",,,", ",,,", ",,,", ",,," };
                    for (int k = 0; SocketListLength > k; k++)
                    {
                        byte Unk5 = packetData[i];
                        i++;
                        SocketList[k] = Unk5 + ",";
                        UInt64 SocketID = BitConverter.ToUInt64(packetData, i);
                        i += 8;
                        SocketList[k] += SocketID + ",\"";
                        string SocketName = CusEnum.Item.Enum(BitConverter.ToUInt32(packetData, i));
                        i += 8;
                        SocketList[k] += SocketName + "\",";
                        UInt16 SocketCount = BitConverter.ToUInt16(packetData, i);
                        i += 2;
                        SocketList[k] += SocketCount;
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
