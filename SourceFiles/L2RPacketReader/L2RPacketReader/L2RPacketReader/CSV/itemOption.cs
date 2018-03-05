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

    class itemOptionheader
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Desc { get; set; }
    }

    class itemOption
    {
        private static List<itemOptionheader> _records;
        public static string itemOptionName(int intID)
        {
            string id = intID.ToString();
            string result = string.Empty;

        IDSearch:

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\ItemOption_Name.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<itemOptionheader>().ToList();
                }
            }

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
