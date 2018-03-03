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
        private static IEnumerable<guildLevelUpheader> _records;
        public static UInt32 guildLevelUpExp(UInt32 Lv)
        {
            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\GuildLevelUp.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<guildLevelUpheader>().ToList();
                }
            }

            foreach (var r in _records)
            {
                if (r.Lv == Lv)
                {
                    return Convert.ToUInt32(r.NextLevelNeedExp);
                }
            }

            return 0;
        }

    }

}
