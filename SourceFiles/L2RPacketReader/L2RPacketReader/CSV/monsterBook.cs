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

    class monsterBookheader
    {



        public Int16 Id { get; set; }
        public Int16 BookLevel { get; set; }
        public String GroupId { get; set; }
        public String MonsterId { get; set; }
        public String CardBorder { get; set; }
        public String SlotImage { get; set; }
        public String BeadImage { get; set; }
        public String UseLargeBeadImage { get; set; }
        public String CardImage { get; set; }
        public String MonsterCoreItemId { get; set; }
        public Int16 RequiredQuantity { get; set; }
        public String StatusIcon { get; set; }
        public String EffectType2 { get; set; }
        public String EffectParam { get; set; }
        public String HuntType { get; set; }
        public String HuntingSpotId { get; set; }
        public String NameDirection { get; set; }
    }

    class monsterBook
    {
        private static Int16 result = 0;
        public static Int16 monsterBookCores(UInt16 ID, UInt16 Level)
        {
            using (var sr = new StreamReader(@"CSV\MonsterBook.csv"))
            {
                var csv = new CsvReader(sr);
                var record = new monsterBookheader();
                var records = csv.EnumerateRecords(record);
                foreach (var r in records)
                {
                    if (r.Id == ID & r.BookLevel == Level)
                    {
                        result = r.RequiredQuantity;
                        break;
                    }
                }

            }
            return result;
        }

    }

}
