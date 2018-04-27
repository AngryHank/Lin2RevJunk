using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktSkillStartResult
    {
        public static void Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktSkillStartResult.csv", true))
            {

                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("TID,SkillInfoID,MP,TargetPosX,TargetPosY,ComboCount,HitList,HitActorID,CritHit,Damage,ParryingDamage,ActorHP,MPDamage,MissList,MissActorID,MissType,Junk");
                }

                packet.Skip(2);
                byte TID = packet.ReadByte();
                String SkillInfoID = CSV.skill.skillName(packet.ReadInt32());
                UInt32 MP = packet.ReadUInt32();
                Single TargetPosX = packet.ReadSingle();
                Single TargetPosY = packet.ReadSingle();
                UInt16 ComboCount = packet.ReadUInt16();
                UInt16 HitList = packet.ReadUInt16();
                UInt64[] HitActorID = new UInt64[HitList];
                byte[] CritHit = new byte[HitList];
                Int32[] Damage = new Int32[HitList];
                Int32[] ParryingDamage = new Int32[HitList];
                UInt32[] ActorHP = new UInt32[HitList];
                UInt32[] MPDamage = new UInt32[HitList];

                for (int j = 0; j < HitList; j++)
                {
                    HitActorID[j] = packet.ReadUInt64();
                    CritHit[j] = packet.ReadByte();
                    Damage[j] = packet.ReadInt32();
                    ParryingDamage[j] = packet.ReadInt32();
                    ActorHP[j] = packet.ReadUInt32();
                    MPDamage[j] = packet.ReadUInt32();

                }

                UInt16 MissList = packet.ReadUInt16();
                UInt64[] MissActorID = new UInt64[MissList];
                byte[] MissType = new byte[MissList];

                for (int j = 0; j < MissList; j++)
                {
                    MissActorID[j] = packet.ReadUInt64();
                    MissType[j] = packet.ReadByte();
                }

                byte[] junkdata = packet.ReadBytes(packet.Remaining);

                /* Commented out until I figure this part out
                UInt16 PullList = packet.ReadUInt16();
                for (int j = 0; j < PullList; j++)
                {
                UInt64[] PullActorID = new UInt64[PullList];

                }
                
                UInt16 KBList = packet.ReadUInt16();
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
                    fileStream.Write(TID + "," + SkillInfoID + "," + MP + "," + TargetPosX + "," + TargetPosY + "," + ComboCount + "," + HitList + ",");
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
                    fileStream.Write(string.Join(",", junkdata) + "\n");
                }



            }
        }
    }
}