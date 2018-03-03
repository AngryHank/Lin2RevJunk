using System;

namespace L2RPacketReader.Misc
{
    class Misc
    {
        public static string CalcTime(UInt64 Timevalue)
        {
            string returnTime = "";
            if (Timevalue < 1)
            {
                returnTime += "Online";
            }
            if (Timevalue / 86400 > 1)
            {
                returnTime += Timevalue / 86400 + "d ";
                Timevalue = Timevalue % 86400;
            }
            if (Timevalue / 3600 > 1)
            {
                returnTime += Timevalue / 3600 + "h ";
                Timevalue = Timevalue % 3600;
            }
            if (Timevalue / 60 > 1)
            {
                returnTime += Timevalue / 60 + "m ";
                Timevalue = Timevalue % 60;
            }
            if (Timevalue / 1 > 1)
            {
                returnTime += Timevalue + "s";
            }



            return returnTime;
        }
    }
}
