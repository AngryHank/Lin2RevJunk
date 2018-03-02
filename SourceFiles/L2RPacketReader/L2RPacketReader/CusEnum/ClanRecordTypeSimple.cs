using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RPacketReader.CusEnum
{
    class ClanRecordTypeSimple
    {
        public static string Enum(byte CEValue)
        {
            switch (CEValue)
            {
                case 0:
                    return "Adena";
                case 1:
                    return "Proof of Blood";
                case 24:
                    return "Red Starstone";
                default:
                    return "Unknown Value";
            }
        }
    }
}
