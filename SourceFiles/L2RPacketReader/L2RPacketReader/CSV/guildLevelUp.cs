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

    class guildLevelUpheader
    {
        public int Lv { get; set; }
        public int MaximumGuildMemberCount { get; set; }
        public int GuildWarehouseCount { get; set; }
        public string NextLevelNeedExp { get; set; }
        public int AssignableAssistantMaster { get; set; }
        public int AssignableKnightsLeader { get; set; }
        public int AssignableRoyalGuardLeader { get; set; }
        public int PresentCount { get; set; }
        public int PrizeCount { get; set; }
    }

    class guildLevelUp
    {
        private static UInt32 result;
        public static UInt32 guildLevelUpExp(UInt32 Lv)
        {
            
            using (var sr = new StreamReader(@"CSV\GuildLevelUp.csv"))
            {
                var csv = new CsvReader(sr);
                var record = new guildLevelUpheader();
                var records = csv.EnumerateRecords(record);
                foreach (var r in records)
                {
                    if (r.Lv == Lv)
                    {
                        result = Convert.ToUInt32(r.NextLevelNeedExp);
                        break;
                    }
                }

            }

            return result;

        }

    }

}
