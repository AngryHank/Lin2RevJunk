using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RPacketReader.CusEnum
{
    class Template
    {
        public static string Enum(byte CEValue)
        {
            switch (CEValue)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                default:
                    return "Unknown Value";

            }
        }
    }
}
