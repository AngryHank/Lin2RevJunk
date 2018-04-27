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

    class rankingheader
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public string Unit { get; set; }
    }

    class Ranking
    {
        private static IEnumerable<rankingheader> _records;
        public static string rankingName(Int32 intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\Ranking_Name.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<rankingheader>().ToList();
                }
            }

        IDSearch:
            foreach (var r in _records)
            {
                if (r.Id == id)
                {
                    result = r.Name;
                    break;
                }
            }

            if (result.Length > 0 && result.Substring(0, 1) == "@")
            {
                id = (result.Substring(1, (result.Length - 1)));
                goto IDSearch;
            }
            return result;

        }

    }

}
