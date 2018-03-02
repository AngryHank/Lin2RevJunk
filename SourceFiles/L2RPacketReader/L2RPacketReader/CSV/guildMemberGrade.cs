using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using CsvHelper;

namespace L2RPacketReader.CSV
{

    class guildMemberGradeheader
    {
        public int Grade { get; set; }
        public String Name { get; set; }
    }

    class guildMemberGrade
    {
        private static String result;
        public static String guildMemberGradeName(byte Grade)
        {
            
            using (var sr = new StreamReader(@"CSV\GuildMemberGrade_Name.csv"))
            {
                var csv = new CsvReader(sr);
                var record = new guildMemberGradeheader();
                var records = csv.EnumerateRecords(record);
                foreach (var r in records)
                {
                    if (r.Grade == Grade)
                    {
                        result = r.Name;
                        break;
                    }
                }

            }

            return result;

        }

    }

}
