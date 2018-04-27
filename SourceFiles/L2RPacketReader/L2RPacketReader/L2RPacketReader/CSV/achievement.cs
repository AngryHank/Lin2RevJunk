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

    class achievementheader
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Desc { get; set; }
        public String RequiredId { get; set; }
        public String GroupType { get; set; }
        public String Param1 { get; set; }
        public String TaskType { get; set; }
        public String TaskCondition { get; set; }
        public String CompleteNotifyType { get; set; }
        public String AchievementGroupId { get; set; }
        public String TaskCount { get; set; }
        public String RewardPoint { get; set; }
        public String Reward { get; set; }
}

    class achievement
    {
        private static IEnumerable<achievementheader> _records;

        // Grab Name
        public static string achievementName(UInt32 intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
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

        // Grab Desc
        public static string achievementDesc(UInt32 intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

            IDSearch:
            foreach (var r in _records)
            {
                if (r.Id == id)
                {
                    result = r.Desc;
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

        // Grab TaskCount
        public static string achievementTaskCount(UInt32 intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

            IDSearch:
            foreach (var r in _records)
            {
                if (r.Id == id)
                {
                    result = r.TaskCount;
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

        // Grab Grouptype
        public static string achievementGroupType(UInt32 intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (var sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    var csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

            IDSearch:
            foreach (var r in _records)
            {
                if (r.Id == id)
                {
                    result = r.GroupType;
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
