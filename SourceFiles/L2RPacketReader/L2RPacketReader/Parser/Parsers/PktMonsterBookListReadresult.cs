using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktMonsterBookListReadresult
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktMonsterBookListReadresult.csv", true))
            {

                //how to call
                // PktMonsterBookListReadresult.Packet(packetData, packetLength);


                // Header for top line only
                int i = 2;

                UInt16 TotalCodex = BitConverter.ToUInt16(packetData, i);
                fileStream.WriteLine("Codex Entries: " + TotalCodex);
                fileStream.WriteLine("\nCodexID,Cores,Level,Unk1");
                i += 2;
                for (int j = 0; j < TotalCodex; j++)
                {
                    UInt16 CodexID = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Cores = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Level = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Unk1 = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    fileStream.WriteLine(CodexID + "," + Cores + "," + Level + "," + Unk1);
                }
                UInt16 TotalCodexGroup = BitConverter.ToUInt16(packetData, i);
                i += 2;
                fileStream.WriteLine("Codex Pages: " + TotalCodexGroup);
                for (int j = 0; j < TotalCodexGroup; j++)
                {
                    UInt16 Unk1 = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 CodexGroup = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    byte spacer = packetData[i];
                    i++;
                    UInt16 Unk2 = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Unk3 = BitConverter.ToUInt16(packetData, i);
                    i += 2;

                }
                
            }
        }
    }
}