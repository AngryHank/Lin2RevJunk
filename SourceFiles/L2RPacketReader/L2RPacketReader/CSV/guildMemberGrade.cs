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
        private static IEnumerable<guildMemberGradeheader> _records;
        public static String guildMemberGradeName(byte Grade)
        {
            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\GuildMemberGrade_Name.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<guildMemberGradeheader>().ToList();
                }
            }

            foreach (var r in _records)
            {
                if (r.Grade == Grade)
                {
                    return r.Name;
                }
            }

            return string.Empty;

        }

    }

}
