using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RPacketReader.CusEnum
{
    class ClanRecordType
    {
        public static string Enum(byte CEValue, string Param1, string Param2, string Param3)
        {
            switch (CEValue)
            {
                case 0:
                    return "Clan member " + Param1 + " donated " + Param2 + " Adena.";
                case 1:
                    return Param1 + " donated " + Param2 + " Proof of Blood(s).";
                case 2:
                    return "Clan Buff " + Param1 + " has reached level " + Param2 + " .";
                case 3:
                    return "Clan has reached level " + Param1 + " .";
                case 4:
                    return "A war has been declared on " + Param1 + " .";
                case 6:
                    return "Established an alliance with clan " + Param1 + " .";
                case 7:
                    return "The alliance with " + Param1 + " has been disbanded.";
                case 8:
                    return "Clan member " + Param1 + " has become " + Param2 + " .";
                case 9:
                    return Param1 + " automatically appointed " + Param2 + " as the new Lord.";
                case 10:
                    return Param1 + " has joined the clan.";
                case 11:
                    return Param1 + " has left the clan.";
                case 12:
                    return Param1 + " has levied " + Param2 + " Diamond Box(es) as the tax.";
                case 13:
                    return "Successfully cleared Clan Dungeon " + Param1 + " .";
                case 14:
                    return "Successfully achieved clan achievement " + Param1 + " .";
                case 15:
                    return "You’ve become the ruler of " + Param1 + " .";
                case 16:
                    return "CastleAcquired";
                case 17:
                    return "Gifted " + Param3 + " " + Param2 + " (s) to " + Param1 + " clan member(s).";
                case 18:
                    return "Gave " + Param2 + " x" + Param3 + " prize to " + Param1 + " clan member.";
                case 19:
                    return "Rewarded " + Param1 + " x" + Param2 + " to all clan members.";
                case 20:
                    return "Won the war against clan " + Param1 + " .";
                case 21:
                    return "Lost the war against clan " + Param1 + " .";
                case 22:
                    return "Fought to a standstill in the war against clan " + Param1 + " .";
                case 23:
                    return "Lord " + Param1 + " purchased " + Param2 + " from the Castle Siege Store.";
                case 24:
                    return "Clan member " + Param1 + " donated " + Param2 + " Red Starstone(s).";
                case 25:
                    return "You have purchased a Clan Hall.";
                case 26:
                    return "The Clan Hall has reached Level " + Param1 + " .";
                case 27:
                    return "The Crystal of Unity has reached Level " + Param1 + " .";
                case 28:
                    return "Will give up ownership of " + Param1 + " .";
                case 29:
                    return "Haven given up ownership of " + Param1 + " .";
                case 30:
                    return "War against clan " + Param1 + " has terminated under settlement.";
                default:
                    return "Unknown Value";
            }
        }
    }
}
