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

    class itemheader
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String TypeDesc { get; set; }
        public String UsingDesc { get; set; }
        public String ReplaceString1 { get; set; }
        public String ReplaceString2 { get; set; }
        public String Desc { get; set; }
    }

    class item
    { 
        private static string result;
        public static string itemName(int intID)
        {

            string id = intID.ToString();
            
        IDSearch:

            using (var sr = new StreamReader(@"CSV\Item_Name.csv"))
            {
                var csv = new CsvReader(sr);
                var record = new skillheader();
                var records = csv.EnumerateRecords(record);
                foreach (var r in records)
                {
                    if (r.Id == id)
                    {
                        result = r.Name;
                        break;
                    }
                }

            }
            if (result.Length > 0 & result.Substring(0, 1) == "@")
            {
                id = (result.Substring(1, (result.Length - 1)));
                goto IDSearch;
            }
            return result;

        }

    }

}
