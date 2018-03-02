using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktSkillHitNotify
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktSkillHitNotify.csv", true))
            {

                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("ActorID,SkillInfoID,ComboCount,HitList,HitActorID,CritHit,Damage,ParryingDamage,ActorHP,MPDamage,MissList,MissActorID,MissType,Junk");

                int i = 0;
                UInt64 ActorID = BitConverter.ToUInt64(packetData, i);
                i += 8;
                String SkillInfoID = CSV.skill.skillName(BitConverter.ToInt32(packetData, i));
                i += 4;
                UInt16 ComboCount = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt16 HitList = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt64 [] HitActorID = new UInt64[HitList];
                byte[] CritHit = new byte[HitList];
                UInt32[] Damage = new UInt32[HitList];
                UInt32[] ParryingDamage = new UInt32[HitList];
                UInt32[] ActorHP = new UInt32[HitList];
                UInt32[] MPDamage = new UInt32[HitList];

                for (int j = 0; j < HitList; j++)
                {
                    HitActorID[j] = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    CritHit[j] = packetData[i];
                    i++;
                    Damage[j] = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    ParryingDamage[j] = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    ActorHP[j] = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    MPDamage[j] = BitConverter.ToUInt32(packetData, i);
                    i += 4;

                }

                UInt16 MissList = BitConverter.ToUInt16(packetData, i);
                i += 2;
                UInt64[] MissActorID = new UInt64[MissList];
                byte[] MissType = new byte[MissList];

                for (int j = 0; j < MissList; j++)
                {
                    MissActorID[j] = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    MissType[j]= packetData[i];
                    i++;

                }

                byte[] junkdata = new byte[packetLength-i];
                for (int j = 0; i < (packetLength); j++)
                {

                    junkdata[j] = packetData[i];
                    i++;
                }

                /* Commented out until I figure this part out
                UInt16 PullList = BitConverter.ToUInt16(packetData, i);
                i += 2;
                for (int j = 0; j < PullList; j++)
                {
                UInt64[] PullActorID = new UInt64[PullList];

                }
                
                UInt16 KBList = BitConverter.ToUInt16(packetData, i);
                i += 2;
                for (int j = 0; j < KBList; j++)
                {
                UInt64[] PullActorID = new UInt64[KBList];

                }
                }*/

                UInt16 MaxArray = Math.Max(HitList, MissList);
                // MaxArray = Math.Max(MaxArray, PullList);
                // MaxArray = Math.Max(MaxArray, KBList);

                for (int j = 0; j < MaxArray; j++)
                {
                    fileStream.Write(ActorID + "," + SkillInfoID + "," + ComboCount + "," + HitList + ",");
                    if (HitList < MaxArray)
                    {
                        fileStream.Write(",,,,,,");
                    }
                    else
                    {
                        fileStream.Write(HitActorID[j] + "," + CritHit[j] + "," + Damage[j] + "," + ParryingDamage[j] + "," + ActorHP[j] + "," + MPDamage[j] + ",");
                    }
                    fileStream.Write(MissList + ",");
                    if (MissList < MaxArray)
                    {
                        fileStream.Write(",,");
                    }
                    else
                    {
                        fileStream.Write(MissActorID[j] + "," + MissType[j] + ",");
                    }
                    fileStream.Write(string.Join(",", junkdata)+"\n");
                }
            


            }
        }
    }
}