using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Pkt
{
    class PktCharacterStatChangeNotify
    {
        public static void Packet(PacketReader packet)
        {

            //1.04.16

            packet.Skip(2);
            UInt64 CharacterUID = packet.ReadUInt64();
            UInt16 ActorStatCount = packet.ReadUInt16();
            for (int i = 0; i < ActorStatCount; i++) {
                //PktActorStatList
                byte StatType = packet.ReadByte();
                int Change = packet.ReadInt32();
                int Value = packet.ReadInt32();
            }

        }

    }
}
