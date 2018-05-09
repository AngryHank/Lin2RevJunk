using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktGadget
    {
        public static void Packet(PacketReader packet)
        {

            // 1.04.16

            UInt64 GadgetUID = packet.ReadUInt64();
            UInt32 GadgetID = packet.ReadUInt32();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            byte Active = packet.ReadByte();
            string OwnerName = packet.ReadString();//This is a guess
            UInt32 RemainCount = packet.ReadUInt32();
        }
    }
}