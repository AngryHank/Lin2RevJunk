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

    class worldheader
    {
        public String Id { get; set; }
        public String Name { get; set; }
    }

    class world
    {
        private static IEnumerable<worldheader> _records;
        public static string worldName(int intID)
        {
            string result = "";
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\World_Name.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<worldheader>().ToList();
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
