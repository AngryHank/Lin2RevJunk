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
                returnTime += Timevalue / 86400 + "Day(s) ";
                Timevalue = Timevalue % 86400;
            }
            if (Timevalue / 3600 > 1)
            {
                returnTime += Timevalue / 3600 + "Hours(s) ";
                Timevalue = Timevalue % 3600;
            }
            if (Timevalue / 60 > 1)
            {
                returnTime += Timevalue / 60 + "Minutes(s) ";
                Timevalue = Timevalue % 60;
            }
            if (Timevalue / 1 > 1)
            {
                returnTime += Timevalue + "Seconds(s) ";
            }



            return returnTime;
        }
    }
}
