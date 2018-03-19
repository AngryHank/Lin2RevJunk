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

    class MonsterBookheader
    {
       
        public String Id { get; set; }
        public String BookLevel { get; set; }
        public String GroupId { get; set; }
        public String MonsterId { get; set; }
        public String CardBorder { get; set; }
        public String SlotImage { get; set; }
        public String BeadImage { get; set; }
        public String UseLargeBeadImage { get; set; }
        public String CardImage { get; set; }
        public String MonsterCoreItemId { get; set; }
        public String RequiredQuantity { get; set; }
        public String StatusIcon { get; set; }
        public String EffectType2 { get; set; }
        public String EffectParam { get; set; }
        public String HuntType { get; set; }
        public String HuntingSpotId { get; set; }
        public String NameDirection { get; set; }
    }

    class MonsterBook
    {
        private static IEnumerable<MonsterBookheader> _records;
        public static String MonsterBookCores(UInt16 intID, UInt16 intLevel)
        {
            string result = string.Empty;
            string id = intID.ToString();
            string level = intLevel.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\MonsterBook.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<MonsterBookheader>().ToList();
                }
            }

            IDSearch:
            foreach (var r in _records)
            {
                if (r.Id == id & r.BookLevel == level)
                {
                    result = r.RequiredQuantity;
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
