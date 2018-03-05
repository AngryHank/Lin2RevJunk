using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RPacketReader.CusEnum
{
    class QuestState
    {
        public static string Enum(byte value)
        {
            switch (value)
            {
                case 0: return "Not Taken";
                case 1: return "In Progress";
                case 3: return "Complete";
                default: return "Unknown: " + value;
            }
        }
    }
}
