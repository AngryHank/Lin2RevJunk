using System;
using System.IO;

namespace L2RPacketReader.Parser.Parsers
{
    class PktChatWorldWriteResult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\PartyChat.csv", true))
            {
                if (stm.BaseStream.Length < 1)
                {
                    stm.WriteLine("Time,Name,Message,type,unk1,unk2,unk3,unk4,unk5,unk6,unk7,unk8");
                }

                    packet.Skip(2);
                

                    UInt64 unk1 = packet.ReadUInt64();
                    UInt64 PlayerID = packet.ReadUInt64();
                    string PlayerName = packet.ReadString();
                    UInt32 unk2 = packet.ReadUInt32();
                    UInt32 unk3 = packet.ReadUInt32();
                    DateTime MessageTime = packet.ReadDate();
                    string Message = packet.ReadString();
                    UInt16 unk4 = packet.ReadUInt16();
                    UInt32 unk5 = packet.ReadUInt32();
                    UInt32 unk6 = packet.ReadUInt32();
                    packet.Skip(21);
                    Byte unk7 = packet.ReadByte();
                    Byte unk8 = packet.ReadByte();
                    stm.WriteLine(MessageTime + "," + PlayerName + "," + Message + ",WorldNotify," + unk1 + "," + unk2 + "," + unk3 + "," + unk4 + "," + unk5 + "," + unk6 + "," + unk7 + "," + unk8);

            }
        }
    }
}
