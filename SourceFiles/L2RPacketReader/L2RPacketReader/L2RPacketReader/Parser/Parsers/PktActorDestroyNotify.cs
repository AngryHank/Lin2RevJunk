using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktActorDestroyNotify
    {
        public static void Packet(PacketReader packet)
        {
            using (FileStream fileStream = new FileStream(@"Packets\ADN(" + packet.Remaining + ").dat", FileMode.Append, FileAccess.Write, FileShare.Write))
                {
                    for (int j = 0; j < packet.Remaining;)
                    {
                        fileStream.WriteByte(packet.ReadByte());
                    }
                }
        }

    }
}
