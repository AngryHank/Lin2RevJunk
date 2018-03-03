using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildRecordListReadresultClean
    {
        public static void Packet(byte[] packetData)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\ClanDonations.txt", true))
            using (StreamWriter fileStream2 = new StreamWriter(@"Output\ClanDonations.csv", true))
            using (StreamWriter fileStream3 = new StreamWriter(@"Output\ClanRecords.txt", true))
            {
                if (fileStream2.BaseStream.Length < 1)
                    fileStream.WriteLine("Time,Name,Ammount,Item");

                int i = 2;
                UInt16 RecordNumber = BitConverter.ToUInt16(packetData, i);
                i += 2;
                for (int j = 0; j < RecordNumber; j++)
                {
                    UInt64 RecordID = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    byte GroupType = packetData[i];
                    i++;
                    byte RecordType = packetData[i];
                    i++;
                    UInt16 NameLength = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Name = Encoding.UTF8.GetString(packetData, i, NameLength);
                    i += NameLength;
                    UInt16 Text1Length = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Text1 = Encoding.UTF8.GetString(packetData, i, Text1Length);
                    i += Text1Length;
                    UInt16 Text2Length = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Text2 = Encoding.UTF8.GetString(packetData, i, Text2Length);
                    i += Text2Length;
                    UInt16 Text3Length = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Text3 = Encoding.UTF8.GetString(packetData, i, Text3Length);
                    i += Text3Length;
                    UInt64 tTime = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    tTime -= 18000;
                    System.DateTime dTime = new System.DateTime(1970, 1, 1).AddSeconds(tTime);
                    string ResultText = CusEnum.ClanRecordType.Enum(RecordType,Text1,Text2,Text3);
                    string ResultTextSimple = CusEnum.ClanRecordTypeSimple.Enum(RecordType);

                    if (GroupType == 2)
                    {
                        fileStream.WriteLine(dTime + ": " + Name + " - " + ResultText);
                        fileStream2.WriteLine(dTime + "," + Name + "," + Text2 + "," + ResultTextSimple);
                    }
                    fileStream3.WriteLine(dTime + ": " + Name + " - " + ResultText);

                }
            }
        }
    }
}
   
