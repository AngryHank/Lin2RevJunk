using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace L2RPacketReader.Parser.Parsers
{
    class PktChatPromoListReadresult
    {
        public static void Packet(PacketReader packet)
        {
            var list = new List<UInt32>();
            /* East Talking Island */
                //list.Add(100001);//	Black Fang  13  9500
                //list.Add(100004);//	Urca        13  9500
                //list.Add(100005);//	Kobaka      13  9500
                //list.Add(100002);//	Silverhorn  13  9500
                list.Add(100003);//	Queen Sylop     13  9500
            /* West Talking Island */
                //list.Add(100006);//	Sting       20  15600
                //list.Add(100007);//	Red Rouse   18  13300
                //list.Add(100008);//	Taarka      20  15600
                //list.Add(100009);//	Bane King   20  15600
                list.Add(201001);//	Spirit Shepherd 20  15600
            /* Elven Ruins 1 */
                //list.Add(100010);//	Horror Wing 20  15600
                //list.Add(100011);//	Ryukaon         20  15600
                //list.Add(100012);//	Arachne         25  24200
            /* Elven Ruins 2 */
                //list.Add(100013);//	Maniskull       27  29100
                list.Add(100014);//	Felix           29  34200
                //list.Add(100015);//	Death Gazer 31  43100
                list.Add(100016);//	Necross         35  62100
            /* Gludin Highway */
                list.Add(101001);//	Canine          21  16900
                list.Add(101002);//	Freki           21  16900
                list.Add(101003);//	Melville        22  18900
                //list.Add(101004);//	Moretti     24  22300
                list.Add(101005);//	Olvar           25  24200
                list.Add(101006);//	Alle            26  26200
                list.Add(201002);//	Zodiac          29  34200
            /* Gludio Plains */
                list.Add(101010);//	Cotous          36  67900
                //list.Add(101012);//	Turekka     38  73300
                list.Add(101007);//	Bighand         31  43100
                list.Add(101008);//	Doom Skull      32  50800
                list.Add(101009);//	Kactoose        30  37000
                list.Add(101011);//	Cox             36  67900
                list.Add(201003);//	Silverbeard     40  80200
            /* Windawood Manor */ 
                list.Add(101013);//	Shadow Wing     38  73300
                //list.Add(101016);//	Hucca       46  99900
                //list.Add(101017);//	Gnasher     48  105600
                //list.Add(101018);//	Troka       48  105600
                list.Add(101014);//	Ruins Wanderer  41  83000
                list.Add(101015);//	Sabretooth      44  93900
                list.Add(201004);//	Vapar           52  119100
            /* Wasteland */
                list.Add(101019);//	Sand Eye        50  112900
                list.Add(101020);//	Red Lock        52  119100
                list.Add(101021);//	Pointer         52  119100
                list.Add(101022);//	Grinder         54  124600
                list.Add(101023);//	Sand Lurker     54  124600
                list.Add(101024);//	Stone Haftz     58  134600
                list.Add(101025);//	Sand Haftz      58  134600
                list.Add(201005);//	Kazir           62  146000
            /* Ant Nest 1 */ 
                list.Add(101026);//	Reaver          40  80200
                //list.Add(101027);//	Ant Nest Foreman    54  124600
            /* Ant Nest 2 */
            /*
                list.Add(101028);//	Ant Nest Royal Guard Captain    78  184000
                list.Add(101029);//	Spawning Ground Keeper  84  197100
            /* Plains of Dion */
                list.Add(102001);//	Bulc            62  146000
                list.Add(102002);//	Baroque         62  146000
                list.Add(102003);//	Moke            70  165000
                list.Add(102004);//	Thrush          62  146000
                list.Add(102005);//	Krush           66  155600
                list.Add(102006);//	Varash          62  146000
                list.Add(102007);//	Screash         66  155600

            /*    list.Add(202001);//	Flagon          104 241900
            /* Cruma Swamp */
            /*
                list.Add(102008);//	Liam            78  184000
                list.Add(102009);//	Ronde           78  184000
                list.Add(102010);//	Morgan          84  197100
                list.Add(102011);//	Zyrnna          84  197100
                list.Add(102012);//	Arcane          90  208700
                list.Add(202002);//	Sina            120 290900
            /* Summit of Dissonance */
            /*
                list.Add(102013);//	Summit Attacker 90  208700
                list.Add(102017);//	Ol B'Khan       100 232300
                list.Add(102014);//	Tartan          90  208700
                list.Add(102015);//	Thaartan        94  217700
                list.Add(102016);//	Tutan           90  208700
                list.Add(202003);//	Amadeus         136 349100
            /* Shrieking Hallows */
            /*
                list.Add(102018);//	Screamer        104 241900
                list.Add(102019);//	Flora           104 241900
                list.Add(102020);//	Jonadan         112 265900
                list.Add(102022);//	Cowboy          112 265900
                list.Add(102023);//	Seamstress      116 278400
                list.Add(102024);//	Balthazar       116 278400
                list.Add(102021);//	Shrieking Treant    112 265900
                list.Add(301001);//	Guillotine of Death	198	579500
            /* Cruma Tower Floor 2 */
            /*
                list.Add(102025);//	Mystique        84  197100
                list.Add(102026);//	Stelos          90  208700
                list.Add(102027);//	Master Mordeo   94  217700
                list.Add(102028);//	Serbo Prime     108 254100
            /* Cruma Tower Floor 3 */
            /*
                list.Add(102029);//	Greezo          112 265900
                list.Add(102030);//	Julius          120 290900
                list.Add(102031);//	Magnus          128 319300
            /* Giran Dominion */
            /* 
                list.Add(103001);//	Ellen           124 265900
                list.Add(103006);//	Luce            132 265900
                list.Add(103002);//	Vir             124 265900
                list.Add(103003);//	Tess            132 265900
                list.Add(103004);//	Rashkos         132 265900
                list.Add(103005);//	Shakos          132 265900
                list.Add(103007);//	Thox            132 265900
                list.Add(203001);//	Stenoa	        198	334700
            /* Deathly Fog Shores */
            /*
                list.Add(103008);//	Lulani          136 278400
                list.Add(103009);//	Alfonso         140 290900
                list.Add(103010);//	Holst           140 304600
                list.Add(103011);//	Medes           140 319300
                list.Add(103012);//	Luka            146 334700
                list.Add(103013);//	Hector          146 349100
                list.Add(203002);//	Marsha	        230	398200
            /* Devil's Isle */
            /*
                list.Add(103014);//	Rua	            150	364200
                list.Add(103015);//	Bornesting	    156	364200
                list.Add(103016);//	Albert	        156	398200
                list.Add(103017);//	Jeff	        156	384600
            /* Haunted Necropolis */
            /* 
                list.Add(103019);//	Verock	        162	438300
                list.Add(103020);//	Jason	        174	438300
                list.Add(103024);//	Wilhelm	        162	438300
                list.Add(103018);//	Gorokk	        162	438300
                list.Add(103021);//	Oomba	        168	438300
                list.Add(103022);//	Agarez	        168	438300
                list.Add(103023);//	Ravolas	        174	438300
                                // Marlox ????
            /* Ivory Tower Floor 1 */
            /*
                list.Add(103027);//	Preta	        146	393800
                list.Add(103025);//	Mesheemp        128 326200
                list.Add(103026);//	Corepio         136 356400
            /* Ivory Tower Floor 2 */
            /*
                list.Add(103028);//	Vulture	        150	407700
                list.Add(103029);//	Gargu	        156	429400
                list.Add(103030);//	Morpheus	    162	448700
            /* Ivory Tower Floor 3 */
            /*
                list.Add(103031);//	Skullchaser	    168	467600
                list.Add(103032);//	Creatus	        174	485900
                list.Add(103033);//	Sandstorm	    182	537300

            /* Oren */
            /*
                                 
            /* Northwind Plateau */
            /*
                list.Add(104003);//	Silenos	        198	710700
                list.Add(104004);//	Toruq	        198	710700
                list.Add(104005);//	Karix	        198	710700
                list.Add(104001);//	Bear Grylle	    182	537300
                list.Add(104002);//	Gaytin	        182	537300
                list.Add(104006);//	Xeno	        190	667100
            /* Eternal Lands */
            /*
                list.Add(104009);//	Host Fungus	    206	740100
                list.Add(104007);//	Larva	        230	847600
                list.Add(104008);//	Reba	        214	773200
                list.Add(104010);//	Herven	        222	807500
                list.Add(104011);//	Shadow	        214	773200
            /* Ivory Tower Conquered Territory */
            /*
                list.Add(104015);//	Morta	        248	951000
                list.Add(104016);//	Mita	        248	951000
                list.Add(104012);//	Tarba	        236	878200
                list.Add(104013);//	Marata	        242	914300
                list.Add(104014);//	Kreta	        242	914300
                list.Add(104018);//	Defender	    254	990200
                list.Add(104017);//	Arita	        254	990200
            /* Forest of Secrets Canopy */
            /*
                list.Add(104019);//	Argos	        182	537300
                list.Add(104020);//	Helissa	        222	807500
                list.Add(104021);//	Sling	        190	667100
            /* Forest of Secrets Understory */
            /*
                list.Add(104022);//	Vanuk	        236	878200
                list.Add(104023);//	Cailyn	        262	1037500
                list.Add(104024);//	Veiloss	        268	1077600
            /* Forest of Secrets Site of Slaughter */
            /*
                list.Add(104025);//	Intrepidez	    262	1037500
                list.Add(104026);//	Avetura	        268	1077600
                list.Add(104027);//	Gari	        274	1113800
                list.Add(104028);//	Alkaios	        282	1158500*/
            packet.Skip(packet.Remaining - 4);
            UInt32 value = packet.ReadUInt32();

            if (list.Contains(value))
            {
                FileStream fs = new FileStream(@"c:\slide.wav", FileMode.Open, FileAccess.Read);
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(fs);
                sp.Play();
            }
            if (value > 0)
                Console.WriteLine("/n" + value);
        }
    }
}
