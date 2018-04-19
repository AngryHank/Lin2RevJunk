using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktChatGuildWriteResult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\GuildChat.csv", true))
            {
                if (stm.BaseStream.Length < 1)
                {
                    stm.WriteLine("Time,Name,Message,type,unk1,unk2,unk3,unk4,unk5,unk6");
                }

                packet.Skip(10);
                
                UInt16 numMessages = packet.ReadUInt16();

                for (int i = 0; i < numMessages; i++)
                {
                    UInt64 unk1 = packet.ReadUInt64();
                    UInt64 PlayerID = packet.ReadUInt64();
                    string PlayerName = packet.ReadString();
                    UInt32 unk2 = packet.ReadUInt32();
                    UInt32 unk3 = packet.ReadUInt32();
                    DateTime MessageTime = packet.ReadDate();
                    string Message = packet.ReadString();
                    UInt32 unk4 = packet.ReadUInt32();
                    packet.Skip(27);
                    Byte unk5 = packet.ReadByte();
                    Byte unk6 = packet.ReadByte();
                    stm.WriteLine(MessageTime + "," + PlayerName + "," + Message + ",GuildWrite," + unk1 + "," + unk2 + "," + unk3 + "," + unk4 + "," + unk5 + "," + unk6);
                }
            }
        }
    }
}
