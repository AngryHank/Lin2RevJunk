using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktMonsterBookListReadresultClean
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            if (File.Exists(@"Data\Codex.txt"))
                File.Delete(@"Data\Codex.txt");

            using (StreamWriter fileStream = new StreamWriter(@"Data\Codex.txt", true))
            {

                //how to call
                // PktMonsterBookListReadresult.Packet(packetData, packetLength);



                // Header for top line only
                int i = 2;
                // sloppy as hell but it works.
                UInt16[,] codexArray = new UInt16[121, 4] { {1,0,0,0},
                    {2,0,0,0},
                    {3,0,0,0},
                    {4,0,0,0},
                    {5,0,0,0},
                    {10,0,0,0},
                    {11,0,0,0},
                    {12,0,0,0},
                    {13,0,0,0},
                    {14,0,0,0},
                    {20,0,0,0},
                    {21,0,0,0},
                    {22,0,0,0},
                    {30,0,0,0},
                    {31,0,0,0},
                    {32,0,0,0},
                    {33,0,0,0},
                    {34,0,0,0},
                    {40,0,0,0},
                    {41,0,0,0},
                    {42,0,0,0},
                    {43,0,0,0},
                    {44,0,0,0},
                    {45,0,0,0},
                    {46,0,0,0},
                    {50,0,0,0},
                    {51,0,0,0},
                    {52,0,0,0},
                    {53,0,0,0},
                    {54,0,0,0},
                    {55,0,0,0},
                    {56,0,0,0},
                    {60,0,0,0},
                    {61,0,0,0},
                    {62,0,0,0},
                    {63,0,0,0},
                    {64,0,0,0},
                    {65,0,0,0},
                    {66,0,0,0},
                    {70,0,0,0},
                    {71,0,0,0},
                    {72,0,0,0},
                    {73,0,0,0},
                    {74,0,0,0},
                    {75,0,0,0},
                    {76,0,0,0},
                    {77,0,0,0},
                    {80,0,0,0},
                    {81,0,0,0},
                    {82,0,0,0},
                    {83,0,0,0},
                    {84,0,0,0},
                    {90,0,0,0},
                    {91,0,0,0},
                    {92,0,0,0},
                    {93,0,0,0},
                    {94,0,0,0},
                    {95,0,0,0},
                    {96,0,0,0},
                    {97,0,0,0},
                    {100,0,0,0},
                    {101,0,0,0},
                    {102,0,0,0},
                    {103,0,0,0},
                    {104,0,0,0},
                    {105,0,0,0},
                    {110,0,0,0},
                    {111,0,0,0},
                    {112,0,0,0},
                    {113,0,0,0},
                    {114,0,0,0},
                    {115,0,0,0},
                    {120,0,0,0},
                    {121,0,0,0},
                    {122,0,0,0},
                    {123,0,0,0},
                    {124,0,0,0},
                    {125,0,0,0},
                    {126,0,0,0},
                    {130,0,0,0},
                    {131,0,0,0},
                    {132,0,0,0},
                    {133,0,0,0},
                    {140,0,0,0},
                    {141,0,0,0},
                    {142,0,0,0},
                    {150,0,0,0},
                    {151,0,0,0},
                    {152,0,0,0},
                    {153,0,0,0},
                    {154,0,0,0},
                    {155,0,0,0},
                    {156,0,0,0},
                    {157,0,0,0},
                    {160,0,0,0},
                    {161,0,0,0},
                    {162,0,0,0},
                    {163,0,0,0},
                    {164,0,0,0},
                    {165,0,0,0},
                    {166,0,0,0},
                    {170,0,0,0},
                    {171,0,0,0},
                    {172,0,0,0},
                    {173,0,0,0},
                    {180,0,0,0},
                    {181,0,0,0},
                    {182,0,0,0},
                    {183,0,0,0},
                    {184,0,0,0},
                    {185,0,0,0},
                    {187,0,0,0},
                    {190,0,0,0},
                    {191,0,0,0},
                    {192,0,0,0},
                    {200,0,0,0},
                    {201,0,0,0},
                    {202,0,0,0},
                    {210,0,0,0},
                    {211,0,0,0},
                    {212,0,0,0} };

                UInt16 TotalCodex = BitConverter.ToUInt16(packetData, i);
                i += 2;
                for (UInt16 j = 0; j < TotalCodex; j++)
                {
                    UInt16 CodexID = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Cores = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Level = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt16 Unk1 = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    for (UInt16 k = 0; k < 120; k++)
                    {
                        if (codexArray[k,0] == CodexID)
                        {
                            codexArray[k, 1] = Cores;
                            codexArray[k, 2] = Level;
                            codexArray[k, 3] = Unk1;
                            break;
                        }

                    }        
                }

                for (UInt16 k = 0; k < 120; k++)
                {

                    for (UInt16 j = 0; j < codexArray[k, 2]; j++)
                    { fileStream.Write("\t"); }
                    if (codexArray[k, 2] < 10)
                    {
                        int CoresNeeded = CSV.monsterBook.monsterBookCores(codexArray[k, 0], codexArray[k, 2]) - codexArray[k, 1];
                        fileStream.Write(CoresNeeded);
                    }
                    for (int j = codexArray[k, 2] + 1; j < 10; j++)
                    { fileStream.Write("\t" + CSV.monsterBook.monsterBookCores(codexArray[k, 0], Convert.ToUInt16(j))); }
                    fileStream.Write("\n");
                }

            }
                
            }
        }
    }
