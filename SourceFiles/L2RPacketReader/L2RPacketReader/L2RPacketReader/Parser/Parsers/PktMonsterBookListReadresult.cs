using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktMonsterBookListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktMonsterBookListReadresult.csv", true))
            {
                packet.Skip(2);

                UInt16 TotalCodex = packet.ReadUInt16();
                fileStream.WriteLine("Codex Entries: " + TotalCodex);
                fileStream.WriteLine("\nCodexID,Unk1,Level,Cores");

                for (int j = 0; j < TotalCodex; j++)
                {
                    UInt16 CodexID = packet.ReadUInt16();
                    UInt16 Cores = packet.ReadUInt16();
                    UInt16 Level = packet.ReadUInt16();
                    UInt16 Unk1 = packet.ReadUInt16();
                    fileStream.WriteLine(CodexID + "," + Cores + "," + Level + "," + Unk1);
                }

                UInt16 TotalCodexGroup = packet.ReadUInt16();
                fileStream.WriteLine("Codex Pages: " + TotalCodexGroup);
                for (int j = 0; j < TotalCodexGroup; j++)
                {
                    UInt16 Unk1 = packet.ReadUInt16();
                    UInt16 CodexGroup = packet.ReadUInt16();
                    byte spacer = packet.ReadByte();
                    UInt16 Unk2 = packet.ReadUInt16();
                    UInt16 Unk3 = packet.ReadUInt16();
                }
            }
        }
    }
}