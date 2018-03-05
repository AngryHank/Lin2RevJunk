using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildRecordListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\ClanDonations.txt", true))
            using (StreamWriter fileStream2 = new StreamWriter(@"Output\ClanDonations.csv", true))
            using (StreamWriter fileStream3 = new StreamWriter(@"Output\ClanRecords.txt", true))
            {
                if (fileStream2.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("Time,Name,Amount,Item");
                }

                packet.Skip(2);
                UInt16 RecordNumber = packet.ReadUInt16();
                for (int j = 0; j < RecordNumber; j++)
                {
                    UInt64 RecordID = packet.ReadUInt64();
                    byte GroupType = packet.ReadByte();
                    byte RecordType = packet.ReadByte();
                    string Name = packet.ReadString();
                    string Text1 = packet.ReadString();
                    string Text2 = packet.ReadString();
                    string Text3 = packet.ReadString();
                    System.DateTime dTime = packet.ReadDate();
                    string ResultText = CusEnum.ClanRecordType.Enum(RecordType, Text1, Text2, Text3);
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

