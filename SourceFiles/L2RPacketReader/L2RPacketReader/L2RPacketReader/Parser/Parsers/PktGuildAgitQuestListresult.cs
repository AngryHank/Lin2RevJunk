using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktGuildAgitQuestListresult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\QuestList.csv", true))
            {
                stm.WriteLine("QuestId,State,PlayerId,Player,Rank,CompletedAt");

                packet.Skip(2);

                byte[] unkHeader = packet.ReadBytes(4);
                UInt32 numQuests = packet.ReadUInt16();

                for (int i = 0; i < numQuests; i++)
                {
                    UInt32 questId = packet.ReadUInt32();

                    byte[] unk = packet.ReadBytes(4);

                    string state = CusEnum.QuestState.Enum(packet.ReadByte());
                    UInt64 playerId = packet.ReadUInt64();
                    string player = packet.ReadString();
                    string rank = CSV.guildMemberGrade.guildMemberGradeName(packet.ReadByte());
                    DateTime completedTime = packet.ReadDate();

                    stm.WriteLine(questId + "," + state + "," + playerId + "," + player + "," + rank + "," + completedTime);
                }
            }
        }
    }
}
