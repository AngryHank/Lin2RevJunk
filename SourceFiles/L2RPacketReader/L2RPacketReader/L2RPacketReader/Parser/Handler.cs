using System;
using System.IO;
using L2RPacketReader.Parser.Parsers;

namespace L2RPacketReader.Parser
{
    class Handler
    {
        public static void Parse(PacketReader packet, ushort packetID)
        {
            string result;
            Console.Write("PacketID: " + packetID.ToString("X") + "\tLength: " + packet.Remaining);
            //Packet Handler for PacketID
            switch (packetID)
            {

                case 0x1:   //1
                    result = "PktVersionResult";
                    break;
                case 0x2:   //2
                    result = "PktLogin";
                    break;
                case 0x3:   //3
                    result = "PktLoginResult";
                    break;
                case 0x4:   //4
                    result = "PktLogout";
                    break;
                case 0x5:   //5
                    result = "PktLogoutResult";
                    break;
                case 0x6:   //6
                    result = "PktKeyChangeNotify";
                    break;
                case 0x7:   //7
                    result = "PktKeyChanged";
                    break;
                case 0x8:   //8
                    result = "PktKeyChangedResult";
                    break;
                case 0x9:   //9
                    result = "PktWithdrawUser";
                    break;
                case 0xA:   //10
                    result = "PktWithdrawUserResult";
                    break;
                case 0xB:   //11
                    result = "PktTimeSync";
                    break;
                case 0xC:   //12
                    result = "PktTimeSyncResult";
                    break;
                case 0xD:   //13
                    result = "PktKickout";
                    break;
                case 0xE:   //14
                    result = "PktKickoutNotify";
                    break;
                case 0xF:   //15
                    result = "PktKickoutResult";
                    break;
                case 0x10:  //16
                    result = "PktWaitingNumUpdateNotify";
                    break;
                case 0x11:  //17
                    result = "PktWaitingOverNotify";
                    break;
                case 0x12:  //18
                    result = "PktPlayerListRead";
                    break;
                case 0x13:  //19
                    result = "PktPlayerListReadResult";
                    break;
                case 0x14:  //20
                    result = "PktPlayerCreate";
                    break;
                case 0x15:  //21
                    result = "PktPlayerCreateResult";
                    break;
                case 0x16:  //22
                    result = "PktPlayerDelete";
                    break;
                case 0x17:  //23
                    result = "PktPlayerDeleteResult";
                    break;
                case 0x18:  //24
                    result = "PktPlayerSelect";
                    break;
                case 0x19:  //25
                    result = "PktPlayerSelectResult";
                    break;
                case 0x1A:  //26
                    result = "PktSystemTutorialStart";
                    break;
                case 0x1B:  //27
                    result = "PktSystemTutorialStartResult";
                    break;
                case 0x1C:  //28
                    result = "PktMoveToSelectCharacter";
                    break;
                case 0x1D:  //29
                    result = "PktMoveToSelectCharacterResult";
                    break;
                case 0x1E:  //30
                    result = "PktNoticeListRead";
                    break;
                case 0x1F:  //31
                    result = "PktNoticeListReadResult";
                    break;
                case 0x20:  //32
                    result = "PktPopupNoticeListRead";
                    break;
                case 0x21:  //33
                    result = "PktPopupNoticeListReadResult";
                    break;
                case 0x22:  //34
                    result = "PktPopupNoticeChangeNotify";
                    break;
                case 0x23:  //35
                    result = "PktRollNoticeNotify";
                    break;
                case 0x24:  //36
                    result = "PktConfineUserNotify";
                    break;
                case 0x25:  //37
                    result = "PktConfineUserKick";
                    break;
                case 0x26:  //38
                    result = "PktConfineUserKickResult";
                    break;
                case 0x27:  //39
                    result = "PktNoticeNotify";
                    break;
                case 0x28:  //40
                    result = "PktVersion2";
                    break;
                case 0x29:  //41
                    result = "PktVersion2Result";
                    break;
                case 0x2A:  //42
                    result = "PktAccountLinkInfo";
                    break;
                case 0x2B:  //43
                    result = "PktAccountLinkInfoResult";
                    break;
                case 0x2C:  //44
                    result = "PktAccountLinkReward";
                    break;
                case 0x2D:  //45
                    result = "PktAccountLinkRewardResult";
                    break;
                case 0x2E:  //46
                    result = "PktNicknameCheck";
                    break;
                case 0x2F:  //47
                    result = "PktNicknameCheckResult";
                    break;
                case 0x64:  //100
                    result = "PktWorldMoveReserve";
                    break;
                case 0x65:  //101
                    result = "PktWorldMoveReserveResult";
                    break;
                case 0x66:  //102
                    result = "PktWorldMoveStart";
                    break;
                case 0x67:  //103
                    result = "PktWorldMoveStartResult";
                    break;
                case 0x68:  //104
                    result = "PktWorldMoveFinish";
                    break;
                case 0x69:  //105
                    result = "PktWorldMoveFinishResult";
                    break;
                case 0x6A:  //106
                    result = "PktWorldChannelList";
                    break;
                case 0x6B:  //107
                    result = "PktWorldChannelListResult";
                    break;
                case 0x6C:  //108
                    result = "PktWorldChannelMoveReserve";
                    break;
                case 0x6D:  //109
                    result = "PktWorldChannelMoveReserveResult";
                    break;
                case 0x6E:  //110
                    result = "PktWorldLeave";
                    break;
                case 0x6F:  //111
                    result = "PktWorldLeaveResult";
                    break;
                case 0x70:  //112
                    result = "PktTeleportCastingStart";
                    break;
                case 0x71:  //113
                    result = "PktTeleportCastingStartResult";
                    break;
                case 0x72:  //114
                    result = "PktTeleportCastingStartNotify";
                    break;
                case 0x73:  //115
                    result = "PktTeleportDepartNotify";
                    break;
                case 0x74:  //116
                    result = "PktTeleportArriveNotify";
                    break;
                case 0x75:  //117
                    result = "PktWorldInfoUpdateNotify";
                    break;
                case 0x76:  //118
                    result = "PktMapPlayerPositionRead";
                    break;
                case 0x77:  //119
                    result = "PktMapPlayerPositionReadResult";
                    break;
                case 0x78:  //120
                    result = "PktMapWorldInfoRead";
                    break;
                case 0x79:  //121
                    result = "PktMapWorldInfoReadResult";
                    break;
                case 0x7A:  //122
                    result = "PktAutoMoveTeleport";
                    break;
                case 0x7B:  //123
                    result = "PktAutoMoveTeleportResult";
                    break;
                case 0x7C:  //124
                    result = "PktWorldExit";
                    break;
                case 0x7D:  //125
                    result = "PktWorldExitResult";
                    break;
                case 0x7E:  //126
                    result = "PktBossWorldEnterInfo";
                    break;
                case 0x7F:  //127
                    result = "PktBossWorldEnterInfoResult";
                    break;
                case 0x80:  //128
                    result = "PktBossWorldClosingNotify";
                    break;
                case 0x81:  //129
                    result = "PktBossStateRequest";
                    break;
                case 0x82:  //130
                    result = "PktBossStateRequestResult";
                    break;
                case 0xC8:  //200
                    result = "PktPlayerMove";
                    break;
                case 0xC9:  //201
                    result = "PktPlayerMoveResult";
                    break;
                case 0xCA:  //202
                    result = "PktPlayerMoveNotify";
                    break;
                case 0xCB:  //203
                    result = "PktPlayerMoveListNotify";
                    //PktPlayerMoveListNotify.Packet(packet);
                    break;
                case 0xCC:
                    result = "PktSightEnterNotify";
                    break;
                case 0xCD:
                    result = "PktSightLeaveNotify";
                    break;
                case 0xCE:
                    result = "PktNpcMoveNotify";
                    //PktNpcMoveNotify.Packet(packet);
                    break;
                case 0xCF:  //207
                    result = "PktCharacterDieNotify";
                    break;
                case 0xD0:  //208
                    result = "PktActorDestroyNotify";
                    break;
                case 0xD1:  //209
                    result = "PktPlayerRevive";
                    break;
                case 0xD2:  //210
                    result = "PktPlayerReviveResult";
                    break;
                case 0xD3:  //211
                    result = "PktPlayerReviveNotify";
                    break;
                case 0xD4:  //212
                    result = "PktNpcSpawn";
                    break;
                case 0xD5:  //213
                    result = "PktNpcSpawnResult";
                    break;
                case 0xD6:  //214
                    result = "PktNpcCreateNotify";
                    break;
                case 0xD7:  //215
                    result = "PktCharacterKill";
                    break;
                case 0xD8:  //216
                    result = "PktCharacterKillResult";
                    break;
                case 0xD9:  //217
                    result = "PktNpcAllKill";
                    break;
                case 0xDA:  //218
                    result = "PktNpcAllKillResult";
                    break;
                case 0xDB:  //219
                    result = "PktCharacterLevelUpNotify";
                    break;
                case 0xDC:  //220
                    result = "PktCharacterMasteryLevelUpNotify";
                    break;
                case 0xDD:  //221
                    result = "PktPlayerNameChange";
                    break;
                case 0xDE:  //222
                    result = "PktPlayerNameChangeResult";
                    break;
                case 0xDF:  //223
                    result = "PktCharacterStatChangeNotify";
                    break;
                case 0xE0:  //224
                    result = "PktActorStateChange";
                    break;
                case 0xE1:  //225
                    result = "PktActorStateChangeResult";
                    break;
                case 0xE2:  //226
                    result = "PktActorStateChangeNotify";
                    break;
                case 0xE3:  //227
                    result = "PktActorTeamChangeNotify";
                    break;
                case 0xE4:  //228
                    result = "PktPlayerClassUpgrade";
                    break;
                case 0xE5:  //229
                    result = "PktPlayerClassUpgradeResult";
                    break;
                case 0xE6:  //230
                    result = "PktPlayerSocialActionInput";
                    break;
                case 0xE7:  //231
                    result = "PktPlayerSocialActionInputResult";
                    break;
                case 0xE8:  //232
                    result = "PktPlayerSocialActionNotify";
                    break;
                case 0xE9:  //233
                    result = "PktPlayerSubClassListRead";
                    break;
                case 0xEA:  //234
                    result = "PktPlayerSubClassListReadResult";
                    break;
                case 0xEB:  //235
                    result = "PktPlayerClassChange";
                    break;
                case 0xEC:  //236
                    result = "PktPlayerClassChangeResult";
                    break;
                case 0xED:  //237
                    result = "PktGadgetCreateNotify";
                    break;
                case 0xEE:  //238
                    result = "PktGadgetControlStart";
                    break;
                case 0xEF:  //239
                    result = "PktGadgetControlStartResult";
                    break;
                case 0xF0:  //240
                    result = "PktGadgetControlStartNotify";
                    break;
                case 0xF1:  //241
                    result = "PktGadgetControl";
                    break;
                case 0xF2:  //242
                    result = "PktGadgetControlResult";
                    break;
                case 0xF3:  //243
                    result = "PktGadgetControlNotify";
                    break;
                case 0xF4:  //244
                    result = "PktGadgetControlCancel";
                    break;
                case 0xF5:  //245
                    result = "PktGadgetControlCancelResult";
                    break;
                case 0xF6:  //246
                    result = "PktGadgetControlCancelNotify";
                    break;
                case 0xF7:  //247
                    result = "PktGadgetActiveNotify";
                    break;
                case 0xF8:  //248
                    result = "PktReconnectGadgetControlNotify";
                    break;
                case 0xF9:  //249
                    result = "PktPlayerInfoRead";
                    break;
                case 0xFA:  //250
                    result = "PktPlayerInfoReadResult";
                    break;
                case 0xFB:  //251
                    result = "PktNpcSightShowNotify";
                    break;
                case 0xFC:  //252
                    result = "PktPlayerStatDetailInfoRead";
                    break;
                case 0xFD:  //253
                    result = "PktPlayerStatDetailInfoReadResult";
                    break;
                case 0xFE:  //254
                    result = "PktPlayerGuildInfoRead";
                    break;
                case 0xFF:  //255
                    result = "PktPlayerGuildInfoReadResult";
                    break;
                case 0x100: //256
                    result = "PktEliminationInsert";
                    break;
                case 0x101: //257
                    result = "PktEliminationInsertResult";
                    break;
                case 0x102: //258
                    result = "PktEliminationGet";
                    break;
                case 0x103: //259
                    result = "PktEliminationGetResult";
                    break;
                case 0x104: //260
                    result = "PktEliminationDel";
                    break;
                case 0x105: //261
                    result = "PktEliminationDelResult";
                    break;
                case 0x106: //262
                    result = "PktContentUnlockListRead";
                    break;
                case 0x107: //263
                    result = "PktContentUnlockListReadResult";
                    break;
                case 0x108: //264
                    result = "PktContentUnlockRequest";
                    break;
                case 0x109: //265
                    result = "PktContentUnlockRequestResult";
                    break;
                case 0x10A: //266
                    result = "PktMapAlarm";
                    break;
                case 0x10B: //267
                    result = "PktMapAlarmResult";
                    break;
                case 0x10C: //268
                    result = "PktMapAlarmNotify";
                    break;
                case 0x10D: //269
                    result = "PktPlayerBadgeNotify";
                    break;
                case 0x10E: //270
                    result = "PktBattleStartNotify";
                    break;
                case 0x10F: //271
                    result = "PktBattleEndNotify";
                    break;
                case 0x110: //272
                    result = "PktTargetActorChange";
                    break;
                case 0x111: //273
                    result = "PktTargetActorChangeResult";
                    break;
                case 0x112: //274
                    result = "PktNotify";
                    break;
                case 0x113: //275
                    result = "PktLevelUpGift";
                    break;
                case 0x114: //276
                    result = "PktLevelUpGiftResult";
                    break;
                case 0x115: //277
                    result = "PktUIOpenClose";
                    break;
                case 0x116: //278
                    result = "PktUIOpenCloseResult";
                    break;
                case 0x117: //279
                    result = "PktBossMonsterKillNotify";
                    break;
                case 0x118: //280
                    result = "PktPlayerGuildDungeonSupportListRead";
                    break;
                case 0x119: //281
                    result = "PktPlayerGuildDungeonSupportListReadResult";
                    break;
                case 0x11A: //282
                    result = "PktFieldBossExistNotify";
                    break;
                case 0x11B: //283
                    result = "PktFieldBossKillNotify";
                    break;
                case 0x11C: //284
                    result = "PktFieldBossItemLootNotify";
                    break;
                case 0x11D: //285
                    result = "PktExpDisplayNotify";
                    //PktPktExpDisplayNotify.Packet(packet);
                    break;
                case 0x11E: //286
                    result = "PktPlayerSelfIntroChange";
                    break;
                case 0x11F: //287
                    result = "PktPlayerSelfIntroChangeResult";
                    break;
                case 0x12C: //300
                    result = "PktAchievementListRead";
                    break;
                case 0x12D: //301
                    result = "PktAchievementListReadResult";
                    break;
                case 0x12E: //302
                    result = "PktPeriodAchievementListRead";
                    break;
                case 0x12F: //303
                    result = "PktPeriodAchievementListReadResult";
                    break;
                case 0x130: //304
                    result = "PktAchievementCompletedNotify";
                    break;
                case 0x131: //305
                    result = "PktAchievementRewardGet";
                    break;
                case 0x132: //306
                    result = "PktAchievementRewardGetResult";
                    break;
                case 0x133: //307
                    result = "PktPeriodAchievementRewardGet";
                    break;
                case 0x134: //308
                    result = "PktPeriodAchievementRewardGetResult";
                    break;
                case 0x135: //309
                    result = "PktAchievementLevelRewardGet";
                    break;
                case 0x136: //310
                    result = "PktAchievementLevelRewardGetResult";
                    break;
                case 0x137: //311
                    result = "PktHeroicLevelUpNotify";
                    break;
                case 0x138: //312
                    result = "PktLeaderboardScoreUpdatedNotify";
                    break;
                case 0x139: //313
                    result = "PktAchievementCompleteListRead";
                    break;
                case 0x13A: //314
                    result = "PktAchievementCompleteListReadResult";
                    break;
                case 0x15E: //350
                    result = "PktDailyActivityListRead";
                    break;
                case 0x15F: //351
                    result = "PktDailyActivityListReadResult";
                    break;
                case 0x160: //352
                    result = "PktDailyActivityCompletedNotify";
                    break;
                case 0x161: //353
                    result = "PktDailyActivityRewardGet";
                    break;
                case 0x162: //354
                    result = "PktDailyActivityRewardGetResult";
                    break;
                case 0x163: //355
                    result = "PktDailyActivityPointRewardGet";
                    break;
                case 0x164: //356
                    result = "PktDailyActivityPointRewardGetResult";
                    break;
                case 0x190: //400
                    result = "PktRuneInfoRead";
                    break;
                case 0x191: //401
                    result = "PktRuneInfoReadResult";
                    break;
                case 0x192: //402
                    result = "PktRuneLevelUp";
                    break;
                case 0x193: //403
                    result = "PktRuneLevelUpResult";
                    break;
                case 0x1C2: //450
                    result = "PktMonsterBookListRead";
                    break;
                case 0x1C3: //451
                    result = "PktMonsterBookListReadResult";
                    //PktMonsterBookListReadresult.Packet(packet);
                    break;
                case 0x1C4: //452
                    result = "PktMonsterCoreUse";
                    break;
                case 0x1C5: //453
                    result = "PktMonsterCoreUseResult";
                    break;
                case 0x1C6: //454
                    result = "PktMonsterCoreUseAll";
                    break;
                case 0x1C7: //455
                    result = "PktMonsterCoreUseAllResult";
                    break;
                case 0x1C8: //456
                    result = "PktMonsterBookGroupRewardGet";
                    break;
                case 0x1C9: //457
                    result = "PktMonsterBookGroupRewardGetResult";
                    break;
                case 0x1F4: //500
                    result = "PktRestRewardGet";
                    break;
                case 0x1F5: //501
                    result = "PktRestRewardGetResult";
                    break;
                case 0x1F6: //502
                    result = "PktRestRewardChangeNotify";
                    break;
                case 0x226: //550
                    result = "PktAttendanceRead";
                    break;
                case 0x227: //551
                    result = "PktAttendanceReadResult";
                    break;
                case 0x228: //552
                    result = "PktAttendanceAttend";
                    break;
                case 0x229: //553
                    result = "PktAttendanceAttendResult";
                    break;
                case 0x22A: //554
                    result = "PktAttendanceDailyGet";
                    break;
                case 0x22B: //555
                    result = "PktAttendanceDailyGetResult";
                    break;
                case 0x22C: //556
                    result = "PktAttendanceWeeklyGet";
                    break;
                case 0x22D: //557
                    result = "PktAttendanceWeeklyGetResult";
                    break;
                case 0x258: //600
                    result = "PktSkillCastingStart";
                    break;
                case 0x259: //601
                    result = "PktSkillCastingStartResult";
                    break;
                case 0x25A: //602
                    result = "PktSkillCastingStartNotify";
                    break;
                case 0x25B: //603
                    result = "PktSkillStart";
                    break;
                case 0x25C: //604
                    result = "PktSkillStartResult";
                    break;
                case 0x25D: //605
                    result = "PktSkillStartNotify";
                    break;
                case 0x25E: //606
                    result = "PktSkillRotate";
                    break;
                case 0x25F: //607
                    result = "PktSkillRotateResult";
                    break;
                case 0x260: //608
                    result = "PktSkillRotateNotify";
                    break;
                case 0x261: //609
                    result = "PktSkillEffectFire";
                    break;
                case 0x262: //610
                    result = "PktSkillEffectFireResult";
                    break;
                case 0x263: //611
                    result = "PktSkillHitNotify";
                    //PktSkillHitNotify.Packet(packet);
                    break;
                case 0x264: //612
                    result = "PktSkillMissNotify";
                    break;
                case 0x265: //613
                    result = "PktSkillCoolTimeResetNotify";
                    break;
                case 0x266: //614
                    result = "PktProjectileCreateNotify";
                    break;
                case 0x267: //615
                    result = "PktProjectileMoveNotify";
                    break;
                case 0x268: //616
                    result = "PktProjectileHit";
                    break;
                case 0x269: //617
                    result = "PktProjectileHitResult";
                    break;
                case 0x26A: //618
                    result = "PktProjectileDestroyNotify";
                    break;
                case 0x26B: //619
                    result = "PktGroundObjectCreateNotify";
                    break;
                case 0x26C: //620
                    result = "PktGroundObjectDestroyNotify";
                    break;
                case 0x26D: //621
                    result = "PktBuffAddNotify";
                    break;
                case 0x26E: //622
                    result = "PktBuffRemoveNotify";
                    break;
                case 0x26F: //623
                    result = "PktBuffRemove";
                    break;
                case 0x270: //624
                    result = "PktBuffRemoveResult";
                    break;
                case 0x271: //625
                    result = "PktSkillListRead";
                    break;
                case 0x272: //626
                    result = "PktSkillListReadResult";
                    break;
                case 0x273: //627
                    result = "PktSkillUpgrade";
                    break;
                case 0x274: //628
                    result = "PktSkillUpgradeResult";
                    break;
                case 0x275: //629
                    result = "PktSkillDeckEquip";
                    break;
                case 0x276: //630
                    result = "PktSkillDeckEquipResult";
                    break;
                case 0x277: //631
                    result = "PktSkillBookUse";
                    break;
                case 0x278: //632
                    result = "PktSkillBookUseResult";
                    break;
                case 0x279: //633
                    result = "PktSkillAcquireNotify";
                    break;
                case 0x27A: //634
                    result = "PktSoulShotEnableChange";
                    break;
                case 0x27B: //635
                    result = "PktSoulShotEnableChangeResult";
                    break;
                case 0x27C: //636
                    result = "PktSoulShotEnableChangeNotify";
                    break;
                case 0x27D: //637
                    result = "PktSoulShotItemDeleteNotify";
                    break;
                case 0x27E: //638
                    result = "PktSkillCoolTimeNotify";
                    break;
                case 0x27F: //639
                    result = "PktSkillAutoRegistrationChange";
                    break;
                case 0x280: //640
                    result = "PktSkillAutoRegistrationChangeResult";
                    break;
                case 0x281: //641
                    result = "PktSkillAutoUseDeckChange";
                    break;
                case 0x282: //642
                    result = "PktSkillAutoUseDeckChangeResult";
                    break;
                case 0x2EE: //750
                    result = "PktChatChannelChange";
                    break;
                case 0x2EF: //751
                    result = "PktChatChannelChangeResult";
                    break;
                case 0x2F0: //752
                    result = "PktChatChannelChangeNotify";
                    break;
                case 0x2F1: //753
                    result = "PktChatChannelListRead";
                    break;
                case 0x2F2: //754
                    result = "PktChatChannelListReadResult";
                    break;
                case 0x2F3: //755
                    result = "PktChatChannelWrite";
                    break;
                case 0x2F4: //756
                    result = "PktChatChannelWriteResult";
                    break;
                case 0x2F5: //757
                    result = "PktChatFriendRoomListRead";
                    break;
                case 0x2F6: //758
                    result = "PktChatFriendRoomListReadResult";
                    break;
                case 0x2F7: //759
                    result = "PktChatFriendRoomGet";
                    break;
                case 0x2F8: //760
                    result = "PktChatFriendRoomGetResult";
                    break;
                case 0x2F9: //761
                    result = "PktChatFriendRoomCreateNotify";
                    break;
                case 0x2FA: //762
                    result = "PktChatFriendRoomLeave";
                    break;
                case 0x2FB: //763
                    result = "PktChatFriendRoomLeaveResult";
                    break;
                case 0x2FC: //764
                    result = "PktChatFriendRoomLeaveNotify";
                    break;
                case 0x2FD: //765
                    result = "PktChatFriendListRead";
                    break;
                case 0x2FE: //766
                    result = "PktChatFriendListReadResult";
                    break;
                case 0x2FF: //767
                    result = "PktChatFriendWrite";
                    break;
                case 0x300: //768
                    result = "PktChatFriendWriteResult";
                    break;
                case 0x301: //769
                    result = "PktChatFriendWriteNotify";
                    break;
                case 0x302: //770
                    result = "PktChatFriendMessageRead";
                    break;
                case 0x303: //771
                    result = "PktChatFriendMessageReadResult";
                    break;
                case 0x304: //772
                    result = "PktChatFriendMessageReadNotify";
                    break;
                case 0x305: //773
                    result = "PktChatGuildListRead";
                    break;
                case 0x306: //774
                    result = "PktChatGuildListReadResult";
                    break;
                case 0x307: //775
                    result = "PktChatGuildWrite";
                    break;
                case 0x308: //776
                    result = "PktChatGuildWriteResult";
                    break;
                case 0x309: //777
                    result = "PktChatGuildWriteNotify";
                    break;
                case 0x30A: //778
                    result = "PktChatGuildMessageRead";
                    break;
                case 0x30B: //779
                    result = "PktChatGuildMessageReadResult";
                    break;
                case 0x30C: //780
                    result = "PktChatSimpleRead";
                    break;
                case 0x30D: //781
                    result = "PktChatSimpleReadResult";
                    break;
                case 0x30E: //782
                    result = "PktChatWorldWrite";
                    break;
                case 0x30F: //783
                    result = "PktChatWorldWriteResult";
                    break;
                case 0x310: //784
                    result = "PktChatWorldWriteNotify";
                    break;
                case 0x311: //785
                    result = "PktChatPartyWrite";
                    break;
                case 0x312: //786
                    result = "PktChatPartyWriteResult";
                    break;
                case 0x313: //787
                    result = "PktChatPartyWriteNotify";
                    break;
                case 0x314: //788
                    result = "PktChatItemLootNotify";
                    break;
                case 0x315: //789
                    result = "PktSystemMessageShowNotify";
                    break;
                case 0x316: //790
                    result = "PktChatAddInfoRead";
                    break;
                case 0x317: //791
                    result = "PktChatAddInfoReadResult";
                    break;
                case 0x318: //792
                    result = "PktChatPromoListRead";
                    break;
                case 0x319: //793
                    result = "PktChatPromoListReadResult";
                    break;
                case 0x31A: //794
                    result = "PktChatPromoWrite";
                    break;
                case 0x31B: //795
                    result = "PktChatPromoWriteResult";
                    break;
                case 0x31C: //796
                    result = "PktChatBlockListRead";
                    break;
                case 0x31D: //797
                    result = "PktChatBlockListReadResult";
                    break;
                case 0x31E: //798
                    result = "PktChatBlockInsert";
                    break;
                case 0x31F: //799
                    result = "PktChatBlockInsertResult";
                    break;
                case 0x320: //800
                    result = "PktChatBlockDelete";
                    break;
                case 0x321: //801
                    result = "PktChatBlockDeleteResult";
                    break;
                case 0x352: //850
                    result = "PktBagListRead";
                    break;
                case 0x353: //851
                    result = "PktBagListReadResult";
                    //PktBagListReadresult.Packet(packet);
                    break;
                case 0x354: //852
                    result = "PktEquipmentListRead";
                    break;
                case 0x355: //853
                    result = "PktEquipmentListReadResult";
                    break;
                case 0x356: //854
                    result = "PktItemUpdateNotify";
                    break;
                case 0x357: //855
                    result = "PktItemEquip";
                    break;
                case 0x358: //856
                    result = "PktItemEquipResult";
                    break;
                case 0x359: //857
                    result = "PktItemEquipNotify";
                    break;
                case 0x35A: //858
                    result = "PktItemUnequip";
                    break;
                case 0x35B: //859
                    result = "PktItemUnequipResult";
                    break;
                case 0x35C: //860
                    result = "PktItemUnequipAll";
                    break;
                case 0x35D: //861
                    result = "PktItemUnequipAllResult";
                    break;
                case 0x35E: //862
                    result = "PktItemUnequipNotify";
                    break;
                case 0x35F: //863
                    result = "PktItemLike";
                    break;
                case 0x360: //864
                    result = "PktItemLikeResult";
                    break;
                case 0x361: //865
                    result = "PktItemSell";
                    break;
                case 0x362: //866
                    result = "PktItemSellResult";
                    break;
                case 0x363: //867
                    result = "PktItemDecompose";
                    break;
                case 0x364: //868
                    result = "PktItemDecomposeResult";
                    break;
                case 0x365: //869
                    result = "PktItemLevelUp";
                    break;
                case 0x366: //870
                    result = "PktItemLevelUpResult";
                    break;
                case 0x367: //871
                    result = "PktItemLevelUpInSocket";
                    break;
                case 0x368: //872
                    result = "PktItemLevelUpInSocketResult";
                    break;
                case 0x369: //873
                    result = "PktItemLimitBreak";
                    break;
                case 0x36A: //874
                    result = "PktItemLimitBreakResult";
                    break;
                case 0x36B: //875
                    result = "PktItemEnchant";
                    break;
                case 0x36C: //876
                    result = "PktItemEnchantResult";
                    break;
                case 0x36D: //877
                    result = "PktEquipmentItemChangeNotify";
                    break;
                case 0x36E: //878
                    result = "PktItemUpgrade";
                    break;
                case 0x36F: //879
                    result = "PktItemUpgradeResult";
                    break;
                case 0x370: //880
                    result = "PktItemUpgradeInSocket";
                    break;
                case 0x371: //881
                    result = "PktItemUpgradeInSocketResult";
                    break;
                case 0x372: //882
                    result = "PktItemCompose";
                    break;
                case 0x373: //883
                    result = "PktItemComposeResult";
                    break;
                case 0x374: //884
                    result = "PktItemOptionChange";
                    break;
                case 0x375: //885
                    result = "PktItemOptionChangeResult";
                    break;
                case 0x376: //886
                    result = "PktItemAbilityUpgrade";
                    break;
                case 0x377: //887
                    result = "PktItemAbilityUpgradeResult";
                    break;
                case 0x378: //888
                    result = "PktItemUseNotify";
                    break;
                case 0x379: //889
                    result = "PktItemUse";
                    break;
                case 0x37A: //890
                    result = "PktItemUseResult";
                    break;
                case 0x37B: //891
                    result = "PktItemCoolTimeResetNotyfy";
                    break;
                case 0x37C: //892
                    result = "PktSoulCrystalEquip";
                    break;
                case 0x37D: //893
                    result = "PktSoulCrystalEquipResult";
                    break;
                case 0x37E: //894
                    result = "PktSoulCrystalExtract";
                    break;
                case 0x37F: //895
                    result = "PktSoulCrystalExtractResult";
                    break;
                case 0x380: //896
                    result = "PktEquipedSoulCrystalSell";
                    break;
                case 0x381: //897
                    result = "PktEquipedSoulCrystalSellResult";
                    break;
                case 0x382: //898
                    result = "PktSoulShotCraft";
                    break;
                case 0x383: //899
                    result = "PktSoulShotCraftResult";
                    break;
                case 0x384: //900
                    result = "PktItemCraft";
                    break;
                case 0x385: //901
                    result = "PktItemCraftResult";
                    break;
                case 0x386: //902
                    result = "PktItemLootNotify";
                    break;
                case 0x387: //903
                    result = "PktBagExpand";
                    break;
                case 0x388: //904
                    result = "PktBagExpandResult";
                    break;
                case 0x389: //905
                    result = "PktBagExpandNotify";
                    break;
                case 0x38A: //906
                    result = "PktWarehouseListRead";
                    break;
                case 0x38B: //907
                    result = "PktWarehouseListReadResult";
                    break;
                case 0x38C: //908
                    result = "PktItemMoveToWarehouse";
                    break;
                case 0x38D: //909
                    result = "PktItemMoveToWarehouseResult";
                    break;
                case 0x38E: //910
                    result = "PktItemMoveToBag";
                    break;
                case 0x38F: //911
                    result = "PktItemMoveToBagResult";
                    break;
                case 0x390: //912
                    result = "PktWarehouseExpand";
                    break;
                case 0x391: //913
                    result = "PktWarehouseExpandResult";
                    break;
                case 0x392: //914
                    result = "PktEquipmentDeckChanageNotify";
                    break;
                case 0x393: //915
                    result = "PktActiveEquipmentDeckRead";
                    break;
                case 0x394: //916
                    result = "PktActiveEquipmentDeckReadResult";
                    break;
                case 0x395: //917
                    result = "PktElixirInfoRead";
                    break;
                case 0x396: //918
                    result = "PktElixirInfoReadResult";
                    break;
                case 0x397: //919
                    result = "PktElixirChangeNotify";
                    break;
                case 0x398: //920
                    result = "PktSoulCrystalAutoExtract";
                    break;
                case 0x399: //921
                    result = "PktSoulCrystalAutoExtractResult";
                    break;
                case 0x39A: //922
                    result = "PktSummonGemUse";
                    break;
                case 0x39B: //923
                    result = "PktSummonGemUseResult";
                    break;
                case 0x39C: //924
                    result = "PktEquipmentCraft";
                    break;
                case 0x39D: //925
                    result = "PktEquipmentCraftResult";
                    break;
                case 0x39E: //926
                    result = "PktEquipmentCraftStepComplete";
                    break;
                case 0x39F: //927
                    result = "PktEquipmentCraftStepCompleteResult";
                    break;
                case 0x3A0: //928
                    result = "PktItemBoxListRead";
                    break;
                case 0x3A1: //929
                    result = "PktItemBoxListReadResult";
                    break;
                case 0x3A2: //930
                    result = "PktItemCraftInfoRead";
                    break;
                case 0x3A3: //931
                    result = "PktItemCraftInfoReadResult";
                    break;
                case 0x3A4: //932
                    result = "PktSoulCrystalUpgrade";
                    break;
                case 0x3A5: //933
                    result = "PktSoulCrystalUpgradeResult";
                    break;
                case 0x3A6: //934
                    result = "PktSoulCrystalUpgradeInSocket";
                    break;
                case 0x3A7: //935
                    result = "PktSoulCrystalUpgradeInSocketResult";
                    break;
                case 0x3A8: //936
                    result = "PktItemDisassemble";
                    break;
                case 0x3A9: //937
                    result = "PktItemDisassembleResult";
                    break;
                case 0x3AA: //938
                    result = "PktItemUseNicknameChange";
                    break;
                case 0x3AB: //939
                    result = "PktItemUseNicknameChangeResult";
                    break;
                case 0x3AC: //940
                    result = "PktBattleDeckActivate";
                    break;
                case 0x3AD: //941
                    result = "PktBattleDeckActivateResult";
                    break;
                case 0x3AE: //942
                    result = "PktItemOptionChangeInSocket";
                    break;
                case 0x3AF: //943
                    result = "PktItemOptionChangeInSocketResult";
                    break;
                case 0x3E8: //1000
                    result = "PktMailListRead";
                    break;
                case 0x3E9: //1001
                    result = "PktMailListReadResult";
                    break;
                case 0x3EA: //1002
                    result = "PktMailDelete";
                    break;
                case 0x3EB: //1003
                    result = "PktMailDeleteResult";
                    break;
                case 0x3EC: //1004
                    result = "PktMailDeleteAll";
                    break;
                case 0x3ED: //1005
                    result = "PktMailDeleteAllResult";
                    break;
                case 0x3EE: //1006
                    result = "PktMailRewardGet";
                    break;
                case 0x3EF: //1007
                    result = "PktMailRewardGetResult";
                    break;
                case 0x3F0: //1008
                    result = "PktMailRewardAllGet";
                    break;
                case 0x3F1: //1009
                    result = "PktMailRewardAllGetResult";
                    break;
                case 0x3F2: //1010
                    result = "PktMailReceiveNotify";
                    break;
                case 0x41A: //1050
                    result = "PktQuestStart";
                    break;
                case 0x41B: //1051
                    result = "PktQuestStartResult";
                    break;
                case 0x41C: //1052
                    result = "PktQuestCancel";
                    break;
                case 0x41D: //1053
                    result = "PktQuestCancelResult";
                    break;
                case 0x41E: //1054
                    result = "PktQuestRestart";
                    break;
                case 0x41F: //1055
                    result = "PktQuestRestartResult";
                    break;
                case 0x420: //1056
                    result = "PktQuestUpdate";
                    break;
                case 0x421: //1057
                    result = "PktQuestUpdateResult";
                    break;
                case 0x422: //1058
                    result = "PktQuestUpdateNotify";
                    break;
                case 0x423: //1059
                    result = "PktQuestGadgetControl";
                    break;
                case 0x424: //1060
                    result = "PktQuestGadgetControlResult";
                    break;
                case 0x425: //1061
                    result = "PktQuestGadgetControlNotify";
                    break;
                case 0x426: //1062
                    result = "PktQuestFailNotify";
                    break;
                case 0x427: //1063
                    result = "PktQuestComplete";
                    break;
                case 0x428: //1064
                    result = "PktQuestCompleteResult";
                    break;
                case 0x429: //1065
                    result = "PktQuestRevive";
                    break;
                case 0x42A: //1066
                    result = "PktQuestReviveResult";
                    break;
                case 0x42B: //1067
                    result = "PktQuestNpcSearch";
                    break;
                case 0x42C: //1068
                    result = "PktQuestNpcSearchResult";
                    break;
                case 0x42D: //1069
                    result = "PktQuestWaveStartNotify";
                    break;
                case 0x42E: //1070
                    result = "PktCastleAndFortressListRead";
                    break;
                case 0x42F: //1071
                    result = "PktCastleAndFortressListReadResult";
                    break;
                case 0x430: //1072
                    result = "PktQuestShareRequestNotify";
                    break;
                case 0x431: //1073
                    result = "PktQuestShareAcceptNotify";
                    break;
                case 0x432: //1074
                    result = "PktQuestShare";
                    break;
                case 0x433: //1075
                    result = "PktQuestShareResult";
                    break;
                case 0x434: //1076
                    result = "PktSharedQuestAccept";
                    break;
                case 0x435: //1077
                    result = "PktSharedQuestAcceptResult";
                    break;
                case 0x436: //1078
                    result = "PktQuestActListRead";
                    break;
                case 0x437: //1079
                    result = "PktQuestActListReadResult";
                    break;
                case 0x438: //1080
                    result = "PktQuestActCompleteRewardGet";
                    break;
                case 0x439: //1081
                    result = "PktQuestActCompleteRewardGetResult";
                    break;
                case 0x43A: //1082
                    result = "PktQuestActChapterCompleteNotify";
                    break;
                case 0x43B: //1083
                    result = "PktQuestScrollCompleteCountReset";
                    break;
                case 0x43C: //1084
                    result = "PktQuestScrollCompleteCountResetResult";
                    break;
                case 0x43D: //1085
                    result = "PktQuestTeleport";
                    break;
                case 0x43E: //1086
                    result = "PktQuestTeleportResult";
                    break;
                case 0x47E: //1150
                    result = "PktPartyInfoRead";
                    break;
                case 0x47F: //1151
                    result = "PktPartyInfoReadResult";
                    break;
                case 0x480: //1152
                    result = "PktPartySearchStart";
                    break;
                case 0x481: //1153
                    result = "PktPartySearchStartResult";
                    break;
                case 0x482: //1154
                    result = "PktPartySearchNotify";
                    break;
                case 0x483: //1155
                    result = "PktPartySearchCancel";
                    break;
                case 0x484: //1156
                    result = "PktPartySearchCancelResult";
                    break;
                case 0x485: //1157
                    result = "PktPartyMemberSearchStart";
                    break;
                case 0x486: //1158
                    result = "PktPartyMemberSearchStartResult";
                    break;
                case 0x487: //1159
                    result = "PktPartyMemberSearchCancel";
                    break;
                case 0x488: //1160
                    result = "PktPartyMemberSearchCancelResult";
                    break;
                case 0x489: //1161
                    result = "PktPartyInvite";
                    break;
                case 0x48A: //1162
                    result = "PktPartyInviteResult";
                    break;
                case 0x48B: //1163
                    result = "PktPartyInviteNotify";
                    break;
                case 0x48C: //1164
                    result = "PktPartyInviteAccept";
                    break;
                case 0x48D: //1165
                    result = "PktPartyInviteAcceptResult";
                    break;
                case 0x48E: //1166
                    result = "PktPartyInviteRefuse";
                    break;
                case 0x48F: //1167
                    result = "PktPartyInviteRefuseResult";
                    break;
                case 0x490: //1168
                    result = "PktPartyInviteRefuseNotify";
                    break;
                case 0x491: //1169
                    result = "PktPartyJoinRequest";
                    break;
                case 0x492: //1170
                    result = "PktPartyJoinRequestResult";
                    break;
                case 0x493: //1171
                    result = "PktPartyJoinRequestNotify";
                    break;
                case 0x494: //1172
                    result = "PktPartyJoinRequestCancel";
                    break;
                case 0x495: //1173
                    result = "PktPartyJoinRequestCancelResult";
                    break;
                case 0x496: //1174
                    result = "PktPartyJoinRequestCancelNotify";
                    break;
                case 0x497: //1175
                    result = "PktPartyJoinAccept";
                    break;
                case 0x498: //1176
                    result = "PktPartyJoinAcceptResult";
                    break;
                case 0x499: //1177
                    result = "PktPartyJoinAcceptNotify";
                    break;
                case 0x49A: //1178
                    result = "PktPartyJoinRefuse";
                    break;
                case 0x49B: //1179
                    result = "PktPartyJoinRefuseResult";
                    break;
                case 0x49C: //1180
                    result = "PktPartyJoinRefuseNotify";
                    break;
                case 0x49D: //1181
                    result = "PktPartyCreateNotify";
                    break;
                case 0x49E: //1182
                    result = "PktPartyMemberJoinNotify";
                    break;
                case 0x49F: //1183
                    result = "PktPartyExpel";
                    break;
                case 0x4A0: //1184
                    result = "PktPartyExpelResult";
                    break;
                case 0x4A1: //1185
                    result = "PktPartyExpelNotify";
                    break;
                case 0x4A2: //1186
                    result = "PktPartyWithdraw";
                    break;
                case 0x4A3: //1187
                    result = "PktPartyWithdrawResult";
                    break;
                case 0x4A4: //1188
                    result = "PktPartyWithdrawNotify";
                    break;
                case 0x4A5: //1189
                    result = "PktPartyDisband";
                    break;
                case 0x4A6: //1190
                    result = "PktPartyDisbandResult";
                    break;
                case 0x4A7: //1191
                    result = "PktPartyDisbandNotify";
                    break;
                case 0x4A8: //1192
                    result = "PktPartyMasterEntrust";
                    break;
                case 0x4A9: //1193
                    result = "PktPartyMasterEntrustResult";
                    break;
                case 0x4AA: //1194
                    result = "PktPartyMasterEntrustNotify";
                    break;
                case 0x4AB: //1195
                    result = "PktPartyMuster";
                    break;
                case 0x4AC: //1196
                    result = "PktPartyMusterResult";
                    break;
                case 0x4AD: //1197
                    result = "PktPartyMusterNotify";
                    break;
                case 0x4AE: //1198
                    result = "PktPartyMusterAccept";
                    break;
                case 0x4AF: //1199
                    result = "PktPartyMusterAcceptResult";
                    break;
                case 0x4B0: //1200
                    result = "PktPartyMusterRefuse";
                    break;
                case 0x4B1: //1201
                    result = "PktPartyMusterRefuseResult";
                    break;
                case 0x4B2: //1202
                    result = "PktPartyMusterRefuseNotify";
                    break;
                case 0x4B3: //1203
                    result = "PktPartyMeet";
                    break;
                case 0x4B4: //1204
                    result = "PktPartyMeetResult";
                    break;
                case 0x4B5: //1205
                    result = "PktPartyCall";
                    break;
                case 0x4B6: //1206
                    result = "PktPartyCallResult";
                    break;
                case 0x4B7: //1207
                    result = "PktPartyCallNotify";
                    break;
                case 0x4B8: //1208
                    result = "PktPartyMemberStatChangeNotify";
                    break;
                case 0x4B9: //1209
                    result = "PktPartyMasterWorldMoveNotify";
                    break;
                case 0x4BA: //1210
                    result = "PktPartyMemberDisconnectNotify";
                    break;
                case 0x4BB: //1211
                    result = "PktPartyMemberReconnectNotify";
                    break;
                case 0x4BC: //1212
                    result = "PktPartyNearPartyInfo";
                    break;
                case 0x4BD: //1213
                    result = "PktPartyNearPartyInfoResult";
                    break;
                case 0x4BE: //1214
                    result = "PktPartyNearPlayerInfo";
                    break;
                case 0x4BF: //1215
                    result = "PktPartyNearPlayerInfoResult";
                    break;
                case 0x4C0: //1216
                    result = "PktPartyTagSearch";
                    break;
                case 0x4C1: //1217
                    result = "PktPartyTagSearchResult";
                    break;
                case 0x4C2: //1218
                    result = "PktPartyTagChange";
                    break;
                case 0x4C3: //1219
                    result = "PktPartyTagChangeResult";
                    break;
                case 0x4C4: //1220
                    result = "PktPartyTempCreate";
                    break;
                case 0x4C5: //1221
                    result = "PktPartyTempCreateResult";
                    break;
                case 0x4C6: //1222
                    result = "PktPartyTempRegister";
                    break;
                case 0x4C7: //1223
                    result = "PktPartyTempRegisterResult";
                    break;
                case 0x4C8: //1224
                    result = "PktPartyCreate";
                    break;
                case 0x4C9: //1225
                    result = "PktPartyCreateResult";
                    break;
                case 0x4CA: //1226
                    result = "PktPartyMemberPosNotify";
                    break;
                case 0x4CB: //1227
                    result = "PktPartyAutoEnterList";
                    break;
                case 0x4CC: //1228
                    result = "PktPartyAutoEnterListResult";
                    break;
                case 0x4CD: //1229
                    result = "PktPartyAutoEnter";
                    break;
                case 0x4CE: //1230
                    result = "PktPartyAutoEnterResult";
                    break;
                case 0x4CF: //1231
                    result = "PktPartyAutoEnterNotify";
                    break;
                case 0x4D0: //1232
                    result = "PktPartyAutoEnterCancel";
                    break;
                case 0x4D1: //1233
                    result = "PktPartyAutoEnterCancelResult";
                    break;
                case 0x4D2: //1234
                    result = "PktPartyAutoEnterCancelNotify";
                    break;
                case 0x4D3: //1235
                    result = "PktPartyAutoEnterStartNotify";
                    break;
                case 0x4D4: //1236
                    result = "PktPartyAutoEnterAccept";
                    break;
                case 0x4D5: //1237
                    result = "PktPartyAutoEnterAcceptResult";
                    break;
                case 0x4D6: //1238
                    result = "PktPartyAutoEnterAcceptNotify";
                    break;
                case 0x4D7: //1239
                    result = "PktPartyAutoEnterAcceptTimeOutNotify";
                    break;
                case 0x4D8: //1240
                    result = "PktPartyAutoEnterAcceptImpossibleAreaNotify";
                    break;
                case 0x4D9: //1241
                    result = "PktPartyDungeonEnter";
                    break;
                case 0x4DA: //1242
                    result = "PktPartyDungeonEnterResult";
                    break;
                case 0x4DB: //1243
                    result = "PktPartyDungeonEnterStartNotify";
                    break;
                case 0x4DC: //1244
                    result = "PktPartyDungeonEnterCancelNotify";
                    break;
                case 0x4DD: //1245
                    result = "PktPartyDungeonEnterAccept";
                    break;
                case 0x4DE: //1246
                    result = "PktPartyDungeonEnterAcceptResult";
                    break;
                case 0x4DF: //1247
                    result = "PktPartyDungeonEnterAcceptNotify";
                    break;
                case 0x4E0: //1248
                    result = "PktPartyDungeonEnterNotify";
                    break;
                case 0x4E1: //1249
                    result = "PktPartyInfoNotify";
                    break;
                case 0x4E2: //1250
                    result = "PktPartyVoiceChatJoinNotify";
                    break;
                case 0x4E3: //1251
                    result = "PktPartyVoiceChatJoin";
                    break;
                case 0x4E4: //1252
                    result = "PktPartyVoiceChatJoinResult";
                    break;
                case 0x4E5: //1253
                    result = "PktPartyVoiceChatExit";
                    break;
                case 0x4E6: //1254
                    result = "PktPartyVoiceChatExitResult";
                    break;
                case 0x4E7: //1255
                    result = "PktPartyMemberWorldMoveNotify";
                    break;
                case 0x4E8: //1256
                    result = "PktPartyNameChange";
                    break;
                case 0x4E9: //1257
                    result = "PktPartyNameChangeResult";
                    break;
                case 0x4EA: //1258
                    result = "PktPartyNameChangeNotify";
                    break;
                case 0x4EB: //1259
                    result = "PktPartyInviteIndicate";
                    break;
                case 0x4EC: //1260
                    result = "PktPartyInviteIndicateResult";
                    break;
                case 0x4ED: //1261
                    result = "PktPartyEmblemChangeNotify";
                    break;
                case 0x514: //1300
                    result = "PktFriendListRead";
                    break;
                case 0x515: //1301
                    result = "PktFriendListReadResult";
                    break;
                case 0x516: //1302
                    result = "PktFriendInviteSendListRead";
                    break;
                case 0x517: //1303
                    result = "PktFriendInviteSendListReadResult";
                    break;
                case 0x518: //1304
                    result = "PktFriendInviterListRead";
                    break;
                case 0x519: //1305
                    result = "PktFriendInviterListReadResult";
                    break;
                case 0x51A: //1306
                    result = "PktFriendInvite";
                    break;
                case 0x51B: //1307
                    result = "PktFriendInviteResult";
                    break;
                case 0x51C: //1308
                    result = "PktFriendInviteNotify";
                    break;
                case 0x51D: //1309
                    result = "PktFriendInviteCancel";
                    break;
                case 0x51E: //1310
                    result = "PktFriendInviteCancelResult";
                    break;
                case 0x51F: //1311
                    result = "PktFriendInviteCancelAll";
                    break;
                case 0x520: //1312
                    result = "PktFriendInviteCancelAllResult";
                    break;
                case 0x521: //1313
                    result = "PktFriendInviteCancelNotify";
                    break;
                case 0x522: //1314
                    result = "PktFriendAccept";
                    break;
                case 0x523: //1315
                    result = "PktFriendAcceptResult";
                    break;
                case 0x524: //1316
                    result = "PktFriendAcceptNotify";
                    break;
                case 0x525: //1317
                    result = "PktFriendRefuse";
                    break;
                case 0x526: //1318
                    result = "PktFriendRefuseResult";
                    break;
                case 0x527: //1319
                    result = "PktFriendAcceptAll";
                    break;
                case 0x528: //1320
                    result = "PktFriendAcceptAllResult";
                    break;
                case 0x529: //1321
                    result = "PktFriendRefuseAll";
                    break;
                case 0x52A: //1322
                    result = "PktFriendRefuseAllResult";
                    break;
                case 0x52B: //1323
                    result = "PktFriendDelete";
                    break;
                case 0x52C: //1324
                    result = "PktFriendDeleteResult";
                    break;
                case 0x52D: //1325
                    result = "PktFriendSearch";
                    break;
                case 0x52E: //1326
                    result = "PktFriendSearchResult";
                    break;
                case 0x52F: //1327
                    result = "PktFriendLike";
                    break;
                case 0x530: //1328
                    result = "PktFriendLikeResult";
                    break;
                case 0x531: //1329
                    result = "PktFriendRecommendationListRead";
                    break;
                case 0x532: //1330
                    result = "PktFriendRecommendationListReadResult";
                    break;
                case 0x533: //1331
                    result = "PktFriendRecommendationListRefresh";
                    break;
                case 0x534: //1332
                    result = "PktFriendRecommendationListRefreshResult";
                    break;
                case 0x535: //1333
                    result = "PktFriendRecommendationInviteAll";
                    break;
                case 0x536: //1334
                    result = "PktFriendRecommendationInviteAllResult";
                    break;
                case 0x537: //1335
                    result = "PktFriendListAutoManager";
                    break;
                case 0x538: //1336
                    result = "PktFriendListAutoManagerResult";
                    break;
                case 0x539: //1337
                    result = "PktFriendGreet";
                    break;
                case 0x53A: //1338
                    result = "PktFriendGreetResult";
                    break;
                case 0x53B: //1339
                    result = "PktFriendGreetAll";
                    break;
                case 0x53C: //1340
                    result = "PktFriendGreetAllResult";
                    break;
                case 0x53D: //1341
                    result = "PktFriendGreetNotify";
                    break;
                case 0x53E: //1342
                    result = "PktFriendGreetReceive";
                    break;
                case 0x53F: //1343
                    result = "PktFriendGreetReceiveResult";
                    break;
                case 0x540: //1344
                    result = "PktFriendGreetReceiveAll";
                    break;
                case 0x541: //1345
                    result = "PktFriendGreetReceiveAllResult";
                    break;
                case 0x578: //1400
                    result = "PktGuildInfoRead";
                    break;
                case 0x579: //1401
                    result = "PktGuildInfoReadResult";
                    //PktGuildInfoReadresult.Packet(packet);
                    break;
                case 0x57A: //1402
                    result = "PktGuildMemberListRead";
                    break;
                case 0x57B: //1403
                    result = "PktGuildMemberListReadResult";
                    //PktGuildMemberListReadresult.Packet(packet);
                    break;
                case 0x57C: //1404
                    result = "PktGuildCreate";
                    break;
                case 0x57D: //1405
                    result = "PktGuildCreateResult";
                    break;
                case 0x57E: //1406
                    result = "PktGuildCreateCheck";
                    break;
                case 0x57F: //1407
                    result = "PktGuildCreateCheckResult";
                    break;
                case 0x580: //1408
                    result = "PktGuildInvite";
                    break;
                case 0x581: //1409
                    result = "PktGuildInviteResult";
                    break;
                case 0x582: //1410
                    result = "PktGuildInviteNotify";
                    break;
                case 0x583: //1411
                    result = "PktGuildInviteAccept";
                    break;
                case 0x584: //1412
                    result = "PktGuildInviteAcceptResult";
                    break;
                case 0x585: //1413
                    result = "PktGuildInviteRefuse";
                    break;
                case 0x586: //1414
                    result = "PktGuildInviteRefuseResult";
                    break;
                case 0x587: //1415
                    result = "PktGuildInviteRefuseNotify";
                    break;
                case 0x588: //1416
                    result = "PktGuildJoinRequest";
                    break;
                case 0x589: //1417
                    result = "PktGuildJoinRequestResult";
                    break;
                case 0x58A: //1418
                    result = "PktGuildJoinRequestNotify";
                    break;
                case 0x58B: //1419
                    result = "PktGuildJoinRequestListRead";
                    break;
                case 0x58C: //1420
                    result = "PktGuildJoinRequestListReadResult";
                    break;
                case 0x58D: //1421
                    result = "PktGuildReceivedJoinRequestListRead";
                    break;
                case 0x58E: //1422
                    result = "PktGuildReceivedJoinRequestListReadResult";
                    break;
                case 0x58F: //1423
                    result = "PktGuildJoinRequestCancel";
                    break;
                case 0x590: //1424
                    result = "PktGuildJoinRequestCancelResult";
                    break;
                case 0x591: //1425
                    result = "PktGuildJoinAccept";
                    break;
                case 0x592: //1426
                    result = "PktGuildJoinAcceptResult";
                    break;
                case 0x593: //1427
                    result = "PktGuildJoinAcceptAll";
                    break;
                case 0x594: //1428
                    result = "PktGuildJoinAcceptAllResult";
                    break;
                case 0x595: //1429
                    result = "PktGuildJoinAcceptNotify";
                    break;
                case 0x596: //1430
                    result = "PktGuildMemberJoinNotify";
                    break;
                case 0x597: //1431
                    result = "PktGuildJoinRefuse";
                    break;
                case 0x598: //1432
                    result = "PktGuildJoinRefuseResult";
                    break;
                case 0x599: //1433
                    result = "PktGuildJoinRefuseAll";
                    break;
                case 0x59A: //1434
                    result = "PktGuildJoinRefuseAllResult";
                    break;
                case 0x59B: //1435
                    result = "PktGuildJoinRefuseNotify";
                    break;
                case 0x59C: //1436
                    result = "PktGuildExpel";
                    break;
                case 0x59D: //1437
                    result = "PktGuildExpelResult";
                    break;
                case 0x59E: //1438
                    result = "PktGuildExpelNotify";
                    break;
                case 0x59F: //1439
                    result = "PktGuildWithdraw";
                    break;
                case 0x5A0: //1440
                    result = "PktGuildWithdrawResult";
                    break;
                case 0x5A1: //1441
                    result = "PktGuildWithdrawNotify";
                    break;
                case 0x5A2: //1442
                    result = "PktGuildDisband";
                    break;
                case 0x5A3: //1443
                    result = "PktGuildDisbandResult";
                    break;
                case 0x5A4: //1444
                    result = "PktGuildDisbandNotify";
                    break;
                case 0x5A5: //1445
                    result = "PktGuildMasterEntrust";
                    break;
                case 0x5A6: //1446
                    result = "PktGuildMasterEntrustResult";
                    break;
                case 0x5A7: //1447
                    result = "PktGuildMasterEntrustNotify";
                    break;
                case 0x5A8: //1448
                    result = "PktGuildMemberGradeChange";
                    break;
                case 0x5A9: //1449
                    result = "PktGuildMemberGradeChangeResult";
                    break;
                case 0x5AA: //1450
                    result = "PktGuildMemberGradeChangeNotify";
                    break;
                case 0x5AB: //1451
                    result = "PktGuildIntroductionChange";
                    break;
                case 0x5AC: //1452
                    result = "PktGuildIntroductionChangeResult";
                    break;
                case 0x5AD: //1453
                    result = "PktGuildNoticeChange";
                    break;
                case 0x5AE: //1454
                    result = "PktGuildNoticeChangeResult";
                    break;
                case 0x5AF: //1455
                    result = "PktGuildNameChange";
                    break;
                case 0x5B0: //1456
                    result = "PktGuildNameChangeResult";
                    break;
                case 0x5B1: //1457
                    result = "PktGuildEmblemChange";
                    break;
                case 0x5B2: //1458
                    result = "PktGuildEmblemChangeResult";
                    break;
                case 0x5B3: //1459
                    result = "PktGuildRecommendationListRead";
                    break;
                case 0x5B4: //1460
                    result = "PktGuildRecommendationListReadResult";
                    //PktGuildRecommendationListReadresult.Packet(packet);
                    break;
                case 0x5B5: //1461
                    result = "PktGuildRankingListRead";
                    break;
                case 0x5B6: //1462
                    result = "PktGuildRankingListReadResult";
                    break;
                case 0x5B7: //1463
                    result = "PktGuildRecommendationListRefresh";
                    break;
                case 0x5B8: //1464
                    result = "PktGuildRecommendationListRefreshResult";
                    break;
                case 0x5B9: //1465
                    result = "PktGuildMemberRecommendationListRead";
                    break;
                case 0x5BA: //1466
                    result = "PktGuildMemberRecommendationListReadResult";
                    break;
                case 0x5BB: //1467
                    result = "PktGuildDonate";
                    break;
                case 0x5BC: //1468
                    result = "PktGuildDonateResult";
                    break;
                case 0x5BD: //1469
                    result = "PktGuildLevelUpNotify";
                    break;
                case 0x5BE: //1470
                    result = "PktGuildImpeach";
                    break;
                case 0x5BF: //1471
                    result = "PktGuildImpeachResult";
                    break;
                case 0x5C0: //1472
                    result = "PktGuildImpeachNotify";
                    break;
                case 0x5C1: //1473
                    result = "PktGuildAttend";
                    break;
                case 0x5C2: //1474
                    result = "PktGuildAttendResult";
                    break;
                case 0x5C3: //1475
                    result = "PktGuildAttendRewardGet";
                    break;
                case 0x5C4: //1476
                    result = "PktGuildAttendRewardGetResult";
                    break;
                case 0x5C5: //1477
                    result = "PktGuildGreet";
                    break;
                case 0x5C6: //1478
                    result = "PktGuildGreetResult";
                    break;
                case 0x5C7: //1479
                    result = "PktGuildGreetAll";
                    break;
                case 0x5C8: //1480
                    result = "PktGuildGreetAllResult";
                    break;
                case 0x5C9: //1481
                    result = "PktGuildGreetingReceivedNotify";
                    break;
                case 0x5CA: //1482
                    result = "PktGuildGreetReceive";
                    break;
                case 0x5CB: //1483
                    result = "PktGuildGreetReceiveResult";
                    break;
                case 0x5CC: //1484
                    result = "PktGuildGreetReceiveAll";
                    break;
                case 0x5CD: //1485
                    result = "PktGuildGreetReceiveAllResult";
                    break;
                case 0x5CE: //1486
                    result = "PktGuildRecordListRead";
                    break;
                case 0x5CF: //1487
                    result = "PktGuildRecordListReadResult";
                    //PktGuildRecordListReadresult.Packet(packet);
                    break;
                case 0x5D0: //1488
                    result = "PktGuildWarehouseListRead";
                    break;
                case 0x5D1: //1489
                    result = "PktGuildWarehouseListReadResult";
                    break;
                case 0x5D2: //1490
                    result = "PktGuildWarehouseGrant";
                    break;
                case 0x5D3: //1491
                    result = "PktGuildWarehouseGrantResult";
                    break;
                case 0x5D4: //1492
                    result = "PktGuildWarehouseGrantAllMember";
                    break;
                case 0x5D5: //1493
                    result = "PktGuildWarehouseGrantAllMemberResult";
                    break;
                case 0x5D6: //1494
                    result = "PktGuildBuffUpgrade";
                    break;
                case 0x5D7: //1495
                    result = "PktGuildBuffUpgradeResult";
                    break;
                case 0x5D8: //1496
                    result = "PktGuildBuffListRead";
                    break;
                case 0x5D9: //1497
                    result = "PktGuildBuffListReadResult";
                    break;
                case 0x5DA: //1498
                    result = "PktGuildBuffBuy";
                    break;
                case 0x5DB: //1499
                    result = "PktGuildBuffBuyResult";
                    break;
                case 0x5DC: //1500
                    result = "PktGuildMarketListRead";
                    break;
                case 0x5DD: //1501
                    result = "PktGuildMarketListReadResult";
                    break;
                case 0x5DE: //1502
                    result = "PktGuildMarketBuy";
                    break;
                case 0x5DF: //1503
                    result = "PktGuildMarketBuyResult";
                    break;
                case 0x5E0: //1504
                    result = "PktGuildMarketGiftBuy";
                    break;
                case 0x5E1: //1505
                    result = "PktGuildMarketGiftBuyResult";
                    break;
                case 0x5E2: //1506
                    result = "PktGuildCastleUpgrade";
                    break;
                case 0x5E3: //1507
                    result = "PktGuildCastleUpgradeResult";
                    break;
                case 0x5E4: //1508
                    result = "PktGuildSearch";
                    break;
                case 0x5E5: //1509
                    result = "PktGuildSearchResult";
                    break;
                case 0x5E6: //1510
                    result = "PktGuildAllianceListRead";
                    break;
                case 0x5E7: //1511
                    result = "PktGuildAllianceListReadResult";
                    break;
                case 0x5E8: //1512
                    result = "PktGuildAllianceInviterListRead";
                    break;
                case 0x5E9: //1513
                    result = "PktGuildAllianceInviterListReadResult";
                    break;
                case 0x5EA: //1514
                    result = "PktGuildAllianceInvite";
                    break;
                case 0x5EB: //1515
                    result = "PktGuildAllianceInviteResult";
                    break;
                case 0x5EC: //1516
                    result = "PktGuildAllianceInvitationCancel";
                    break;
                case 0x5ED: //1517
                    result = "PktGuildAllianceInvitationCancelResult";
                    break;
                case 0x5EE: //1518
                    result = "PktGuildAllianceAccept";
                    break;
                case 0x5EF: //1519
                    result = "PktGuildAllianceAcceptResult";
                    break;
                case 0x5F0: //1520
                    result = "PktGuildAllianceChangeNotify";
                    break;
                case 0x5F1: //1521
                    result = "PktGuildHostilityChangeNotify";
                    break;
                case 0x5F2: //1522
                    result = "PktGuildAllianceRefuse";
                    break;
                case 0x5F3: //1523
                    result = "PktGuildAllianceRefuseResult";
                    break;
                case 0x5F4: //1524
                    result = "PktGuildAllianceRefuseAll";
                    break;
                case 0x5F5: //1525
                    result = "PktGuildAllianceRefuseAllResult";
                    break;
                case 0x5F6: //1526
                    result = "PktGuildAllianceDelete";
                    break;
                case 0x5F7: //1527
                    result = "PktGuildAllianceDeleteResult";
                    break;
                case 0x5F8: //1528
                    result = "PktGuildHostilityListRead";
                    break;
                case 0x5F9: //1529
                    result = "PktGuildHostilityListReadResult";
                    break;
                case 0x5FA: //1530
                    result = "PktGuildHostilityRegister";
                    break;
                case 0x5FB: //1531
                    result = "PktGuildHostilityRegisterResult";
                    break;
                case 0x5FC: //1532
                    result = "PktGuildHostilityWarDeclare";
                    break;
                case 0x5FD: //1533
                    result = "PktGuildHostilityWarDeclareResult";
                    break;
                case 0x5FE: //1534
                    result = "PktGuildHostilityUnregister";
                    break;
                case 0x5FF: //1535
                    result = "PktGuildHostilityUnregisterResult";
                    break;
                case 0x600: //1536
                    result = "PktGuildHostileWarSurrender";
                    break;
                case 0x601: //1537
                    result = "PktGuildHostileWarSurrenderResult";
                    break;
                case 0x602: //1538
                    result = "PktGuildHostileWarRecordListRead";
                    break;
                case 0x603: //1539
                    result = "PktGuildHostileWarRecordListReadResult";
                    break;
                case 0x604: //1540
                    result = "PktGuildAchievementListRead";
                    break;
                case 0x605: //1541
                    result = "PktGuildAchievementListReadResult";
                    break;
                case 0x606: //1542
                    result = "PktGuildAchievementRewardGet";
                    break;
                case 0x607: //1543
                    result = "PktGuildAchievementRewardGetResult";
                    break;
                case 0x608: //1544
                    result = "PktGuildJoinRequestOptionChange";
                    break;
                case 0x609: //1545
                    result = "PktGuildJoinRequestOptionChangeResult";
                    break;
                case 0x60A: //1546
                    result = "PktGuildInfoReadChangeNotify";
                    break;
                case 0x60B: //1547
                    result = "PktGuildBadgeNotify";
                    break;
                case 0x60C: //1548
                    result = "PktGuildHostileWarBroadcastNotify";
                    break;
                case 0x60D: //1549
                    result = "PktGuildNoticeRead";
                    break;
                case 0x60E: //1550
                    result = "PktGuildNoticeReadResult";
                    break;
                case 0x60F: //1551
                    result = "PktGuildPromotionLimitTimeNotify";
                    break;
                case 0x610: //1552
                    result = "PktGuildDungeonEnter";
                    break;
                case 0x611: //1553
                    result = "PktGuildDungeonEnterResult";
                    break;
                case 0x612: //1554
                    result = "PktGuildDungeonEnterNotify";
                    break;
                case 0x613: //1555
                    result = "PktGuildDungeonList";
                    break;
                case 0x614: //1556
                    result = "PktGuildDungeonListResult";
                    break;
                case 0x615: //1557
                    result = "PktGuildDungeonReset";
                    break;
                case 0x616: //1558
                    result = "PktGuildDungeonResetResult";
                    break;
                case 0x617: //1559
                    result = "PktGuildDungeonInviteRequest";
                    break;
                case 0x618: //1560
                    result = "PktGuildDungeonInviteRequestResult";
                    break;
                case 0x619: //1561
                    result = "PktGuildDungeonInviteRequestNotify";
                    break;
                case 0x61A: //1562
                    result = "PktGuildDungeonInviteAccept";
                    break;
                case 0x61B: //1563
                    result = "PktGuildDungeonInviteAcceptResult";
                    break;
                case 0x61C: //1564
                    result = "PktGuildDungeonDamageNotify";
                    break;
                case 0x61D: //1565
                    result = "PktGuildDungeonresultNotify";
                    break;
                case 0x61E: //1566
                    result = "PktGuildDungeonKickoutNotify";
                    break;
                case 0x61F: //1567
                    result = "PktGuildMasterBuffNotify";
                    break;
                case 0x620: //1568
                    result = "PktGuildNameChangeNotify";
                    break;
                case 0x621: //1569
                    result = "PktGuildMemberKillNotify";
                    break;
                case 0x622: //1570
                    result = "PktGuildInfoNotify";
                    break;
                case 0x623: //1571
                    result = "PktGuildAgitBuy";
                    break;
                case 0x624: //1572
                    result = "PktGuildAgitBuyResult";
                    break;
                case 0x625: //1573
                    result = "PktGuildAgitUpgrade";
                    break;
                case 0x626: //1574
                    result = "PktGuildAgitUpgradeResult";
                    break;
                case 0x627: //1575
                    result = "PktGuildAgitCrystalUpgrade";
                    break;
                case 0x628: //1576
                    result = "PktGuildAgitCrystalUpgradeResult";
                    break;
                case 0x629: //1577
                    result = "PktGuildAgitInfo";
                    break;
                case 0x62A: //1578
                    result = "PktGuildAgitInfoResult";
                    break;
                case 0x62B: //1579
                    result = "PktGuildAgitOpen";
                    break;
                case 0x62C: //1580
                    result = "PktGuildAgitOpenResult";
                    break;
                case 0x62D: //1581
                    result = "PktGuildAgitExpel";
                    break;
                case 0x62E: //1582
                    result = "PktGuildAgitExpelResult";
                    break;
                case 0x62F: //1583
                    result = "PktGuildAgitExpelNotify";
                    break;
                case 0x630: //1584
                    result = "PktGuildAgitEnter";
                    break;
                case 0x631: //1585
                    result = "PktGuildAgitEnterResult";
                    break;
                case 0x632: //1586
                    result = "PktGuildAgitLeave";
                    break;
                case 0x633: //1587
                    result = "PktGuildAgitLeaveResult";
                    break;
                case 0x634: //1588
                    result = "PktGuildAgitQuestList";
                    break;
                case 0x635: //1589
                    result = "PktGuildAgitQuestListResult";
                    //PktGuildAgitQuestListresult.Packet(packet);
                    break;
                case 0x636: //1590
                    result = "PktGuildAgitQuestAccept";
                    break;
                case 0x637: //1591
                    result = "PktGuildAgitQuestAcceptResult";
                    break;
                case 0x638: //1592
                    result = "PktGuildAgitQuestComplete";
                    break;
                case 0x639: //1593
                    result = "PktGuildAgitQuestCompleteResult";
                    break;
                case 0x63A: //1594
                    result = "PktGuildAgitQuestCompleteImmediately";
                    break;
                case 0x63B: //1595
                    result = "PktGuildAgitQuestCompleteImmediatelyResult";
                    break;
                case 0x63C: //1596
                    result = "PktGuildPromoListRead";
                    break;
                case 0x63D: //1597
                    result = "PktGuildPromoListReadResult";
                    break;
                case 0x63E: //1598
                    result = "PktGuildCommunityOpen";
                    break;
                case 0x63F: //1599
                    result = "PktGuildCommunityOpenResult";
                    break;
                case 0x640: //1600
                    result = "PktCastleSiegeInfoRead";
                    break;
                case 0x641: //1601
                    result = "PktCastleSiegeInfoReadResult";
                    break;
                case 0x642: //1602
                    result = "PktCastleSiegeEnter";
                    break;
                case 0x643: //1603
                    result = "PktCastleSiegeEnterResult";
                    break;
                case 0x644: //1604
                    result = "PktCastleSiegeEnterNotify";
                    break;
                case 0x645: //1605
                    result = "PktCastleSiegeInfoNotify";
                    break;
                case 0x646: //1606
                    result = "PktCastleSiegeStateChangeNotify";
                    break;
                case 0x647: //1607
                    result = "PktCastleSiegeGuildInfoRead";
                    break;
                case 0x648: //1608
                    result = "PktCastleSiegeGuildInfoReadResult";
                    break;
                case 0x649: //1609
                    result = "PktCastleSiegeFinishNotify";
                    break;
                case 0x64A: //1610
                    result = "PktCastleSiegeRetreatNotify";
                    break;
                case 0x64B: //1611
                    result = "PktCastleSiegeHolyArtifactHpChangeNotify";
                    break;
                case 0x64C: //1612
                    result = "PktCastleSiegeHolyArtifactImprintNotify";
                    break;
                case 0x64D: //1613
                    result = "PktCastleSiegeEventNotify";
                    break;
                case 0x64E: //1614
                    result = "PktCastleSiegeLeave";
                    break;
                case 0x64F: //1615
                    result = "PktCastleSiegeLeaveResult";
                    break;
                case 0x650: //1616
                    result = "PktCastleSiegeEntryBid";
                    break;
                case 0x651: //1617
                    result = "PktCastleSiegeEntryBidResult";
                    break;
                case 0x652: //1618
                    result = "PktCastleSiegeEntryBidCancel";
                    break;
                case 0x653: //1619
                    result = "PktCastleSiegeEntryBidCancelResult";
                    break;
                case 0x654: //1620
                    result = "PktCastleSiegeEntryChangeNotify";
                    break;
                case 0x655: //1621
                    result = "PktCastleSiegeFestivalInfoRead";
                    break;
                case 0x656: //1622
                    result = "PktCastleSiegeFestivalInfoReadResult";
                    break;
                case 0x657: //1623
                    result = "PktCastleSiegeFestivalLotteryBuy";
                    break;
                case 0x658: //1624
                    result = "PktCastleSiegeFestivalLotteryBuyResult";
                    break;
                case 0x659: //1625
                    result = "PktCastleSiegeFestivalLotteryRewardGet";
                    break;
                case 0x65A: //1626
                    result = "PktCastleSiegeFestivalLotteryRewardGetResult";
                    break;
                case 0x65B: //1627
                    result = "PktCastleSiegeGuildAlarm";
                    break;
                case 0x65C: //1628
                    result = "PktCastleSiegeGuildAlarmResult";
                    break;
                case 0x65D: //1629
                    result = "PktCastleSiegeGuildAlarmNotify";
                    break;
                case 0x65E: //1630
                    result = "PktCommonSiegeKillComboNotify";
                    break;
                case 0x65F: //1631
                    result = "PktCommonSiegeOccupyBuffNotify";
                    break;
                case 0x660: //1632
                    result = "PktCommonSiegeDestroyedActorNotify";
                    break;
                case 0x661: //1633
                    result = "PktCastleOccupyGuildInfo";
                    break;
                case 0x662: //1634
                    result = "PktCastleOccupyGuildInfoResult";
                    break;
                case 0x663: //1635
                    result = "PktCastleSiegePrevRecord";
                    break;
                case 0x664: //1636
                    result = "PktCastleSiegePrevRecordResult";
                    break;
                case 0x665: //1637
                    result = "PktCastleSiegeHistoryList";
                    break;
                case 0x666: //1638
                    result = "PktCastleSiegeHistoryListResult";
                    break;
                case 0x667: //1639
                    result = "PktCastleSiegePreseasonInfo";
                    break;
                case 0x668: //1640
                    result = "PktCastleSiegePreseasonInfoResult";
                    break;
                case 0x6A4: //1700
                    result = "PktFortressSiegeInfoRead";
                    break;
                case 0x6A5: //1701
                    result = "PktFortressSiegeInfoReadResult";
                    break;
                case 0x6A6: //1702
                    result = "PktFortressSiegeEntryBid";
                    break;
                case 0x6A7: //1703
                    result = "PktFortressSiegeEntryBidResult";
                    break;
                case 0x6A8: //1704
                    result = "PktFortressSiegeEntryBidCancel";
                    break;
                case 0x6A9: //1705
                    result = "PktFortressSiegeEntryBidCancelResult";
                    break;
                case 0x6AA: //1706
                    result = "PktFortressSiegeEntryChangeNotify";
                    break;
                case 0x6AB: //1707
                    result = "PktFortressSiegeEnter";
                    break;
                case 0x6AC: //1708
                    result = "PktFortressSiegeEnterResult";
                    break;
                case 0x6AD: //1709
                    result = "PktFortressSiegeEnterNotify";
                    break;
                case 0x6AE: //1710
                    result = "PktFortressSiegeInfoNotify";
                    break;
                case 0x6AF: //1711
                    result = "PktFortressSiegeStateChangeNotify";
                    break;
                case 0x6B0: //1712
                    result = "PktFortressSiegeGuildInfoRead";
                    break;
                case 0x6B1: //1713
                    result = "PktFortressSiegeGuildInfoReadResult";
                    break;
                case 0x6B2: //1714
                    result = "PktFortressSiegeFinishNotify";
                    break;
                case 0x6B3: //1715
                    result = "PktFortressSiegeRetreatNotify";
                    break;
                case 0x6B4: //1716
                    result = "PktFortressSiegeHolyArtifactHpChangeNotify";
                    break;
                case 0x6B5: //1717
                    result = "PktFortressSiegeHolyArtifactImprintNotify";
                    break;
                case 0x6B6: //1718
                    result = "PktFortressSiegeEventNotify";
                    break;
                case 0x6B7: //1719
                    result = "PktFortressSiegeLeave";
                    break;
                case 0x6B8: //1720
                    result = "PktFortressSiegeLeaveResult";
                    break;
                case 0x6B9: //1721
                    result = "PktFortressOccupyGuildInfo";
                    break;
                case 0x6BA: //1722
                    result = "PktFortressOccupyGuildInfoResult";
                    break;
                case 0x6BB: //1723
                    result = "PktFortressSiegePrevRecord";
                    break;
                case 0x6BC: //1724
                    result = "PktFortressSiegePrevRecordResult";
                    break;
                case 0x6BD: //1725
                    result = "PktFortressSiegeHistoryList";
                    break;
                case 0x6BE: //1726
                    result = "PktFortressSiegeHistoryListResult";
                    break;
                case 0x708: //1800
                    result = "PktAuctionHouseSearchListRead";
                    break;
                case 0x709: //1801
                    result = "PktAuctionHouseSearchListReadResult";
                    break;
                case 0x70A: //1802
                    result = "PktAuctionHouseItemDetailView";
                    break;
                case 0x70B: //1803
                    result = "PktAuctionHouseItemDetailViewResult";
                    break;
                case 0x70C: //1804
                    result = "PktAuctionHouseBuy";
                    break;
                case 0x70D: //1805
                    result = "PktAuctionHouseBuyResult";
                    break;
                case 0x70E: //1806
                    result = "PktAuctionHouseSellingListRead";
                    break;
                case 0x70F: //1807
                    result = "PktAuctionHouseSellingListReadResult";
                    break;
                case 0x710: //1808
                    result = "PktAuctionHouseSellingRegister";
                    break;
                case 0x711: //1809
                    result = "PktAuctionHouseSellingRegisterResult";
                    break;
                case 0x712: //1810
                    result = "PktAuctionHouseSellingCancel";
                    break;
                case 0x713: //1811
                    result = "PktAuctionHouseSellingCancelResult";
                    break;
                case 0x714: //1812
                    result = "PktAuctionHouseSellingresultGet";
                    break;
                case 0x715: //1813
                    result = "PktAuctionHouseSellingresultGetResult";
                    break;
                case 0x716: //1814
                    result = "PktAuctionHouseSellingresultGetAll";
                    break;
                case 0x717: //1815
                    result = "PktAuctionHouseSellingresultGetAllResult";
                    break;
                case 0x718: //1816
                    result = "PktAuctionHouseRecordListRead";
                    break;
                case 0x719: //1817
                    result = "PktAuctionHouseRecordListReadResult";
                    break;
                case 0x71A: //1818
                    result = "PktAuctionHouseAveragePriceGet";
                    break;
                case 0x71B: //1819
                    result = "PktAuctionHouseAveragePriceGetResult";
                    break;
                case 0x71C: //1820
                    result = "PktAuctionHouseFavoritesListRead";
                    break;
                case 0x71D: //1821
                    result = "PktAuctionHouseFavoritesListReadResult";
                    break;
                case 0x71E: //1822
                    result = "PktAuctionHouseFavoritesRegister";
                    break;
                case 0x71F: //1823
                    result = "PktAuctionHouseFavoritesRegisterResult";
                    break;
                case 0x720: //1824
                    result = "PktAuctionHouseFavoritesOnSaleNotify";
                    break;
                case 0x721: //1825
                    result = "PktAuctionHouseSellingRegisterAgain";
                    break;
                case 0x722: //1826
                    result = "PktAuctionHouseSellingRegisterAgainResult";
                    break;
                case 0x723: //1827
                    result = "PktAuctionHouseGetEnabled";
                    break;
                case 0x724: //1828
                    result = "PktAuctionHouseGetEnabledResult";
                    break;
                case 0x76C: //1900
                    result = "PktShopItemListRead";
                    break;
                case 0x76D: //1901
                    result = "PktShopItemListReadResult";
                    break;
                case 0x76E: //1902
                    result = "PktShopItemBuy";
                    break;
                case 0x76F: //1903
                    result = "PktShopItemBuyResult";
                    break;
                case 0x770: //1904
                    result = "PktFixedChargeNotify";
                    break;
                case 0x771: //1905
                    result = "PktFixedChargeInfoNotify";
                    break;
                case 0x772: //1906
                    result = "PktFixedChargeDetail";
                    break;
                case 0x773: //1907
                    result = "PktFixedChargeDetailResult";
                    break;
                case 0x774: //1908
                    result = "PktFixedChargeBuy";
                    break;
                case 0x775: //1909
                    result = "PktFixedChargeBuyResult";
                    break;
                case 0x776: //1910
                    result = "PktFixedChargeTopazGet";
                    break;
                case 0x777: //1911
                    result = "PktFixedChargeTopazGetResult";
                    break;
                case 0x778: //1912
                    result = "PktFixedChargeDiamondGet";
                    break;
                case 0x779: //1913
                    result = "PktFixedChargeDiamondGetResult";
                    break;
                case 0x77A: //1914
                    result = "PktFixedChargeYesterdayDiamondGet";
                    break;
                case 0x77B: //1915
                    result = "PktFixedChargeYesterdayDiamondGetResult";
                    break;
                case 0x77C: //1916
                    result = "PktPensionTypeNotify";
                    break;
                case 0x77D: //1917
                    result = "PktPensionTypeAchievementCompleteNotify";
                    break;
                case 0x77E: //1918
                    result = "PktPensionTypeDetail";
                    break;
                case 0x77F: //1919
                    result = "PktPensionTypeDetailResult";
                    break;
                case 0x780: //1920
                    result = "PktPensionTypeBuy";
                    break;
                case 0x781: //1921
                    result = "PktPensionTypeBuyResult";
                    break;
                case 0x782: //1922
                    result = "PktPensionTypeRewardGet";
                    break;
                case 0x783: //1923
                    result = "PktPensionTypeRewardGetResult";
                    break;
                case 0x784: //1924
                    result = "PktSmartPopupNotify";
                    break;
                case 0x785: //1925
                    result = "PktSmartPopupClose";
                    break;
                case 0x786: //1926
                    result = "PktSmartPopupCloseResult";
                    break;
                case 0x787: //1927
                    result = "PktDailyAdenaNotify";
                    break;
                case 0x788: //1928
                    result = "PktDailyAdenaInfoNotify";
                    break;
                case 0x789: //1929
                    result = "PktDailyAdenaDetail";
                    break;
                case 0x78A: //1930
                    result = "PktDailyAdenaDetailResult";
                    break;
                case 0x78B: //1931
                    result = "PktDailyAdenaBuy";
                    break;
                case 0x78C: //1932
                    result = "PktDailyAdenaBuyResult";
                    break;
                case 0x78D: //1933
                    result = "PktDailyAdenaDiamondGet";
                    break;
                case 0x78E: //1934
                    result = "PktDailyAdenaDiamondGetResult";
                    break;
                case 0x78F: //1935
                    result = "PktDailyAdenaRewardGet";
                    break;
                case 0x790: //1936
                    result = "PktDailyAdenaRewardGetResult";
                    break;
                case 0x791: //1937
                    result = "PktTimeShopListRead";
                    break;
                case 0x792: //1938
                    result = "PktTimeShopListReadResult";
                    break;
                case 0x793: //1939
                    result = "PktTimeShopListNotify";
                    break;
                case 0x794: //1940
                    result = "PktShopRewardListRead";
                    break;
                case 0x795: //1941
                    result = "PktShopRewardListReadResult";
                    break;
                case 0x796: //1942
                    result = "PktShopRewardGet";
                    break;
                case 0x797: //1943
                    result = "PktShopRewardGetResult";
                    break;
                case 0x798: //1944
                    result = "PktShopRewardNotify";
                    break;
                case 0x7D0: //2000
                    result = "PktDungeonListRead";
                    break;
                case 0x7D1: //2001
                    result = "PktDungeonListReadResult";
                    break;
                case 0x7D2: //2002
                    result = "PktDungeonEnter";
                    break;
                case 0x7D3: //2003
                    result = "PktDungeonEnterResult";
                    break;
                case 0x7D4: //2004
                    result = "PktDungeonExit";
                    break;
                case 0x7D5: //2005
                    result = "PktDungeonExitResult";
                    break;
                case 0x7D6: //2006
                    result = "PktDungeonGiveUp";
                    break;
                case 0x7D7: //2007
                    result = "PktDungeonGiveUpResult";
                    break;
                case 0x7D8: //2008
                    result = "PktDungeonSweep";
                    break;
                case 0x7D9: //2009
                    result = "PktDungeonSweepResult";
                    break;
                case 0x7DA: //2010
                    result = "PktDungeonresultNotify";
                    break;
                case 0x7DB: //2011
                    result = "PktDungeonStateNotify";
                    break;
                case 0x7DC: //2012
                    result = "PktDungeonEndTimeNotify";
                    break;
                case 0x7DD: //2013
                    result = "PktDungeonStartTimeNotify";
                    break;
                case 0x7DE: //2014
                    result = "PktDungeonScoreChangeNotify";
                    break;
                case 0x7DF: //2015
                    result = "PktDungeonReviveInfoNotify";
                    break;
                case 0x7E0: //2016
                    result = "PktGatheringNotify";
                    break;
                case 0x7E1: //2017
                    result = "PktDungeonQuestSweep";
                    break;
                case 0x7E2: //2018
                    result = "PktDungeonQuestSweepResult";
                    break;
                case 0x7E3: //2019
                    result = "PktDungeonQuestRewardGet";
                    break;
                case 0x7E4: //2020
                    result = "PktDungeonQuestRewardGetResult";
                    break;
                case 0x7E5: //2021
                    result = "PktDungeonQuestPointRewardGet";
                    break;
                case 0x7E6: //2022
                    result = "PktDungeonQuestPointRewardGetResult";
                    break;
                case 0x7E7: //2023
                    result = "PktDungeonHotTimeCharge";
                    break;
                case 0x7E8: //2024
                    result = "PktDungeonHotTimeChargeResult";
                    break;
                case 0x7E9: //2025
                    result = "PktDungeonQuestNotify";
                    break;
                case 0x7EA: //2026
                    result = "PktDungeonQuestCompleteNotify";
                    break;
                case 0x7EB: //2027
                    result = "PktDungeonHotTimeNotify";
                    break;
                case 0x7EC: //2028
                    result = "PktDungeonFreeCountBuy";
                    break;
                case 0x7ED: //2029
                    result = "PktDungeonFreeCountBuyResult";
                    break;
                case 0x7EE: //2030
                    result = "PktEnchantScrollDungeonStateNotify";
                    break;
                case 0x7EF: //2031
                    result = "PktEnchantScrollDungeonInfoNotify";
                    break;
                case 0x7F0: //2032
                    result = "PktDungeonReconnectNotify";
                    break;
                case 0x7F1: //2033
                    result = "PktEnchantScrollDungeonReconnectMoreInfoNotify";
                    break;
                case 0x7F2: //2034
                    result = "PktSummonStoneDungeonStateNotify";
                    break;
                case 0x7F3: //2035
                    result = "PktSummonStoneDungeonInfoNotify";
                    break;
                case 0x7F4: //2036
                    result = "PktSummonStoneDungeonReconnectMoreInfoNotify";
                    break;
                case 0x7F5: //2037
                    result = "PktDungeonBonusRewardNotify";
                    break;
                case 0x834: //2100
                    result = "PktPvpInfoRead";
                    break;
                case 0x835: //2101
                    result = "PktPvpInfoReadResult";
                    break;
                case 0x836: //2102
                    result = "PktPvpTargetListRefresh";
                    break;
                case 0x837: //2103
                    result = "PktPvpTargetListRefreshResult";
                    break;
                case 0x838: //2104
                    result = "PktPvpStartCheck";
                    break;
                case 0x839: //2105
                    result = "PktPvpStartCheckResult";
                    break;
                case 0x83A: //2106
                    result = "PktPvpStart";
                    break;
                case 0x83B: //2107
                    result = "PktPvpStartResult";
                    break;
                case 0x83C: //2108
                    result = "PktPvpStartNotify";
                    break;
                case 0x83D: //2109
                    result = "PktPvpRecordListRead";
                    break;
                case 0x83E: //2110
                    result = "PktPvpRecordListReadResult";
                    break;
                case 0x83F: //2111
                    result = "PktPvpRankingListRead";
                    break;
                case 0x840: //2112
                    result = "PktPvpRankingListReadResult";
                    break;
                case 0x841: //2113
                    result = "PktPvpLeave";
                    break;
                case 0x842: //2114
                    result = "PktPvpLeaveResult";
                    break;
                case 0x843: //2115
                    result = "PktPvpRewardGet";
                    break;
                case 0x844: //2116
                    result = "PktPvpRewardGetResult";
                    break;
                case 0x845: //2117
                    result = "PktPvpCountDownStartNotify";
                    break;
                case 0x846: //2118
                    result = "PktPvpTimeNotify";
                    break;
                case 0x847: //2119
                    result = "PktPvpEndNotify";
                    break;
                case 0x848: //2120
                    result = "PktPvpHonorRankUpNotify";
                    break;
                case 0x849: //2121
                    result = "PktPvpRankingChangeNotify";
                    break;
                case 0x84A: //2122
                    result = "PktPkStatus";
                    break;
                case 0x84B: //2123
                    result = "PktPkStatusResult";
                    break;
                case 0x84C: //2124
                    result = "PktPkStatusNotify";
                    break;
                case 0x84D: //2125
                    result = "PktPkAttackStateNotify";
                    break;
                case 0x84E: //2126
                    result = "PktPkPointNotify";
                    break;
                case 0x84F: //2127
                    result = "PktPlayerKilledNotify";
                    break;
                case 0x850: //2128
                    result = "PktPvpBattleStart";
                    break;
                case 0x851: //2129
                    result = "PktPvpBattleStartResult";
                    break;
                case 0x852: //2130
                    result = "PktPkPointMonsterKillCount";
                    break;
                case 0x853: //2131
                    result = "PktPkPointMonsterKillCountResult";
                    break;
                case 0x898: //2200
                    result = "PktClassTransferQuestStart";
                    break;
                case 0x899: //2201
                    result = "PktClassTransferQuestStartResult";
                    break;
                case 0x89A: //2202
                    result = "PktClassTransferQuestListRead";
                    break;
                case 0x89B: //2203
                    result = "PktClassTransferQuestListReadResult";
                    break;
                case 0x89C: //2204
                    result = "PktClassTransferQuestRewardGet";
                    break;
                case 0x89D: //2205
                    result = "PktClassTransferQuestRewardGetResult";
                    break;
                case 0x89E: //2206
                    result = "PktClassTransfer";
                    break;
                case 0x89F: //2207
                    result = "PktClassTransferResult";
                    break;
                case 0x8A0: //2208
                    result = "PktClassTransferableNotify";
                    break;
                case 0x8A1: //2209
                    result = "PktClassTransferQuestUpdateNotify";
                    break;
                case 0x8A2: //2210
                    result = "PktClassTransferQuestCompleteNotify";
                    break;
                case 0x8A3: //2211
                    result = "PktClassTransferCheatNotify";
                    break;
                case 0x8FC: //2300
                    result = "PktGuideQuestListRead";
                    break;
                case 0x8FD: //2301
                    result = "PktGuideQuestListReadResult";
                    break;
                case 0x8FE: //2302
                    result = "PktGuideQuestRewardGet";
                    break;
                case 0x8FF: //2303
                    result = "PktGuideQuestRewardGetResult";
                    break;
                case 0x900: //2304
                    result = "PktGuideQuestUpdateNotify";
                    break;
                case 0x901: //2305
                    result = "PktGuideQuestCompleteNotify";
                    break;
                case 0x902: //2306
                    result = "PktGuideQuestCheatNotify";
                    break;
                case 0x903: //2307
                    result = "PktGuideQuestActivityTimeRenew";
                    break;
                case 0x904: //2308
                    result = "PktGuideQuestActivityTimeRenewResult";
                    break;
                case 0x92E: //2350
                    result = "PktPromoteStateListRead";
                    break;
                case 0x92F: //2351
                    result = "PktPromoteStateListReadResult";
                    break;
                case 0x930: //2352
                    result = "PktPromoteStateLowListRead";
                    break;
                case 0x931: //2353
                    result = "PktPromoteStateLowListReadResult";
                    break;
                case 0x960: //2400
                    result = "PktTutorialNotify";
                    break;
                case 0x961: //2401
                    result = "PktTutorialListRead";
                    break;
                case 0x962: //2402
                    result = "PktTutorialListReadResult";
                    break;
                case 0x963: //2403
                    result = "PktTutorialStart";
                    break;
                case 0x964: //2404
                    result = "PktTutorialStartResult";
                    break;
                case 0x965: //2405
                    result = "PktTutorialProgress";
                    break;
                case 0x966: //2406
                    result = "PktTutorialProgressResult";
                    break;
                case 0x967: //2407
                    result = "PktTutorialRewardGet";
                    break;
                case 0x968: //2408
                    result = "PktTutorialRewardGetResult";
                    break;
                case 0x969: //2409
                    result = "PktTutorialMaterialReceiveNotify";
                    break;
                case 0x96A: //2410
                    result = "PktTutorialSkip";
                    break;
                case 0x96B: //2411
                    result = "PktTutorialSkipResult";
                    break;
                case 0x9C4: //2500
                    result = "PktCutSceneNotify";
                    break;
                case 0x9C5: //2501
                    result = "PktCutSceneStart";
                    break;
                case 0x9C6: //2502
                    result = "PktCutSceneStartResult";
                    break;
                case 0x9C7: //2503
                    result = "PktCutSceneEnd";
                    break;
                case 0x9C8: //2504
                    result = "PktCutSceneEndResult";
                    break;
                case 0x9C9: //2505
                    result = "PktCutSceneEndReserve";
                    break;
                case 0x9CA: //2506
                    result = "PktCutSceneEndReserveResult";
                    break;
                case 0x9CB: //2507
                    result = "PktWorldPause";
                    break;
                case 0x9CC: //2508
                    result = "PktWorldPauseResult";
                    break;
                case 0x9CD: //2509
                    result = "PktWorldResume";
                    break;
                case 0x9CE: //2510
                    result = "PktWorldResumeResult";
                    break;
                case 0xA28: //2600
                    result = "PktSystemSettingsGet";
                    break;
                case 0xA29: //2601
                    result = "PktSystemSettingsGetResult";
                    break;
                case 0xA2A: //2602
                    result = "PktSystemSettingsSet";
                    break;
                case 0xA2B: //2603
                    result = "PktSystemSettingsSetResult";
                    break;
                case 0xA2C: //2604
                    result = "PktSystemAlarmNotify";
                    break;
                case 0xA2D: //2605
                    result = "PktPing";
                    break;
                case 0xA2E: //2606
                    result = "PktPingResult";
                    break;
                case 0xA5A: //2650
                    result = "PktInstantCompleteListRead";
                    break;
                case 0xA5B: //2651
                    result = "PktInstantCompleteListReadResult";
                    break;
                case 0xA5C: //2652
                    result = "PktInstantCompleteRewardGet";
                    break;
                case 0xA5D: //2653
                    result = "PktInstantCompleteRewardGetResult";
                    break;
                case 0xA5E: //2654
                    result = "PktInstantCompleteRewardAllGet";
                    break;
                case 0xA5F: //2655
                    result = "PktInstantCompleteRewardAllGetResult";
                    break;
                case 0xA8C: //2700
                    result = "PktMissionRequestListRead";
                    break;
                case 0xA8D: //2701
                    result = "PktMissionRequestListReadResult";
                    break;
                case 0xA8E: //2702
                    result = "PktMissionRequestStart";
                    break;
                case 0xA8F: //2703
                    result = "PktMissionRequestStartResult";
                    break;
                case 0xA90: //2704
                    result = "PktMissionDailyRefresh";
                    break;
                case 0xA91: //2705
                    result = "PktMissionDailyRefreshResult";
                    break;
                case 0xA92: //2706
                    result = "PktMissionDailyNowComplete";
                    break;
                case 0xA93: //2707
                    result = "PktMissionDailyNowCompleteResult";
                    break;
                case 0xA94: //2708
                    result = "PktMissionDailyMaxComboComplete";
                    break;
                case 0xA95: //2709
                    result = "PktMissionDailyMaxComboCompleteResult";
                    break;
                case 0xA96: //2710
                    result = "PktMissionWeeklyPass";
                    break;
                case 0xA97: //2711
                    result = "PktMissionWeeklyPassResult";
                    break;
                case 0xA98: //2712
                    result = "PktMissionDailyRewardGet";
                    break;
                case 0xA99: //2713
                    result = "PktMissionDailyRewardGetResult";
                    break;
                case 0xA9A: //2714
                    result = "PktMissionWeeklyRewardGet";
                    break;
                case 0xA9B: //2715
                    result = "PktMissionWeeklyRewardGetResult";
                    break;
                case 0xA9C: //2716
                    result = "PktMissionRequestRewardGet";
                    break;
                case 0xA9D: //2717
                    result = "PktMissionRequestRewardGetResult";
                    break;
                case 0xA9E: //2718
                    result = "PktMissionRequestCompleteNotify";
                    break;
                case 0xA9F: //2719
                    result = "PktMissionDailyUpdateNotify";
                    break;
                case 0xAA0: //2720
                    result = "PktMissionWeeklyUpdateNotify";
                    break;
                case 0xAA1: //2721
                    result = "PktMissionTeleport";
                    break;
                case 0xAA2: //2722
                    result = "PktMissionTeleportResult";
                    break;
                case 0xAA3: //2723
                    result = "PktMissionWeeklyRefresh";
                    break;
                case 0xAA4: //2724
                    result = "PktMissionWeeklyRefreshResult";
                    break;
                case 0xAA5: //2725
                    result = "PktEventDailyQuestListRead";
                    break;
                case 0xAA6: //2726
                    result = "PktEventDailyQuestListReadResult";
                    break;
                case 0xAA7: //2727
                    result = "PktEventDailyQuestRewardGet";
                    break;
                case 0xAA8: //2728
                    result = "PktEventDailyQuestRewardGetResult";
                    break;
                case 0xAA9: //2729
                    result = "PktEventDailyQuestProgressRewardGet";
                    break;
                case 0xAAA: //2730
                    result = "PktEventDailyQuestProgressRewardGetResult";
                    break;
                case 0xAAB: //2731
                    result = "PktEventDailyQuestStart";
                    break;
                case 0xAAC: //2732
                    result = "PktEventDailyQuestStartResult";
                    break;
                case 0xAAD: //2733
                    result = "PktEventDailyQuestResetCompletedCountNotify";
                    break;
                case 0xABE: //2750
                    result = "PktEventListRead";
                    break;
                case 0xABF: //2751
                    result = "PktEventListReadResult";
                    break;
                case 0xAC0: //2752
                    result = "PktEventRewardGet";
                    break;
                case 0xAC1: //2753
                    result = "PktEventRewardGetResult";
                    break;
                case 0xAC2: //2754
                    result = "PktEventStartNotify";
                    break;
                case 0xAC3: //2755
                    result = "PktEventListNotify";
                    break;
                case 0xAC4: //2756
                    result = "PktEventMessageNotify";
                    break;
                case 0xAC5: //2757
                    result = "PktDropBoxEventNotify";
                    break;
                case 0xAC6: //2758
                    result = "PktInitDropBoxNotify";
                    break;
                case 0xAC7: //2759
                    result = "PktEventDiceExecute";
                    break;
                case 0xAC8: //2760
                    result = "PktEventDiceExecuteResult";
                    break;
                case 0xAC9: //2761
                    result = "PktEventProgressNotify";
                    break;
                case 0xACA: //2762
                    result = "PktEventPostListRead";
                    break;
                case 0xACB: //2763
                    result = "PktEventPostListReadResult";
                    break;
                case 0xAF0: //2800
                    result = "PktNetmarbleSIAPInitialize";
                    break;
                case 0xAF1: //2801
                    result = "PktNetmarbleSIAPInitializeResult";
                    break;
                case 0xAF2: //2802
                    result = "PktNetmarbleSIAPVerify";
                    break;
                case 0xAF3: //2803
                    result = "PktNetmarbleSIAPVerifyResult";
                    break;
                case 0xAF4: //2804
                    result = "PktNetmarbleSIAPPurchaseCancel";
                    break;
                case 0xAF5: //2805
                    result = "PktNetmarbleSIAPPurchaseCancelResult";
                    break;
                case 0xAF6: //2806
                    result = "PktGoogleAnalyticsFirstDied";
                    break;
                case 0xAF7: //2807
                    result = "PktGoogleAnalyticsFirstDiedResult";
                    break;
                case 0xAF8: //2808
                    result = "PktNetmarbleSWebAchievementNotify";
                    break;
                case 0xAF9: //2809
                    result = "PktNetmarbleSIAPGetNetmarbleItemId";
                    break;
                case 0xAFA: //2810
                    result = "PktNetmarbleSIAPGetNetmarbleItemIdResult";
                    break;
                case 0xB55: //2901
                    result = "PktRankingListRead";
                    break;
                case 0xB56: //2902
                    result = "PktRankingListReadResult";
                    break;
                case 0xB57: //2903
                    result = "PktBroadCastNotify";
                    break;
                case 0xB58: //2904
                    result = "PktSocialNetworkShared";
                    break;
                case 0xB59: //2905
                    result = "PktSocialNetworkSharedResult";
                    break;
                case 0xBB9: //3001
                    result = "PktUpdate";
                    break;
                case 0xBBA: //3002
                    result = "PktUpdateResult";
                    break;
                case 0xBBB: //3003
                    result = "PktAdminToolRequest";
                    break;
                case 0xBBC: //3004
                    result = "PktAdminToolRequestResult";
                    break;
                case 0xBBD: //3005
                    result = "PktAdminToolNoticeInsert";
                    break;
                case 0xBBE: //3006
                    result = "PktAdminToolNoticeInsertResult";
                    break;
                case 0xBBF: //3007
                    result = "PktAdminToolNoticeDelete";
                    break;
                case 0xBC0: //3008
                    result = "PktAdminToolNoticeDeleteResult";
                    break;
                case 0xC1D: //3101
                    result = "PktCharacterTitleListRead";
                    break;
                case 0xC1E: //3102
                    result = "PktCharacterTitleListReadResult";
                    break;
                case 0xC1F: //3103
                    result = "PktCharacterTitleEquip";
                    break;
                case 0xC20: //3104
                    result = "PktCharacterTitleEquipResult";
                    break;
                case 0xC21: //3105
                    result = "PktCharacterTitleUpdateNotify";
                    break;
                case 0xC22: //3106
                    result = "PktCharacterTitleEquipNotify";
                    break;
                case 0xC23: //3107
                    result = "PktCharacterTitleAcquire";
                    break;
                case 0xC24: //3108
                    result = "PktCharacterTitleAcquireResult";
                    break;
                case 0xC25: //3109
                    result = "PktCharacterTitleDeleteNotify";
                    break;
                case 0xC81: //3201
                    result = "PktCapeListRead";
                    break;
                case 0xC82: //3202
                    result = "PktCapeListReadResult";
                    break;
                case 0xC83: //3203
                    result = "PktCapeAcquire";
                    break;
                case 0xC84: //3204
                    result = "PktCapeAcquireResult";
                    break;
                case 0xC85: //3205
                    result = "PktCapeEquipChange";
                    break;
                case 0xC86: //3206
                    result = "PktCapeEquipChangeResult";
                    break;
                case 0xC87: //3207
                    result = "PktCapeUnequip";
                    break;
                case 0xC88: //3208
                    result = "PktCapeUnequipResult";
                    break;
                case 0xC89: //3209
                    result = "PktCapeLevelUp";
                    break;
                case 0xC8A: //3210
                    result = "PktCapeLevelUpResult";
                    break;
                case 0xC8B: //3211
                    result = "PktCapeOptionChange";
                    break;
                case 0xC8C: //3212
                    result = "PktCapeOptionChangeResult";
                    break;
                case 0xC8D: //3213
                    result = "PktGuildCapeLevelUp";
                    break;
                case 0xC8E: //3214
                    result = "PktGuildCapeLevelUpResult";
                    break;
                case 0xC8F: //3215
                    result = "PktGuildCapeColorChange";
                    break;
                case 0xC90: //3216
                    result = "PktGuildCapeColorChangeResult";
                    break;
                case 0xC91: //3217
                    result = "PktCapeChangePlayerNotify";
                    break;
                case 0xC92: //3218
                    result = "PktCapeChangeNotify";
                    break;
                case 0xFA1: //4001
                    result = "PktWebUserLogin";
                    break;
                case 0xFA2: //4002
                    result = "PktWebUserLoginResult";
                    break;
                case 0xFA3: //4003
                    result = "PktWebUserLogout";
                    break;
                case 0xFA4: //4004
                    result = "PktWebUserLogoutResult";
                    break;
                case 0xFA5: //4005
                    result = "PktActorLocationNotify";
                    break;
                case 0xFA6: //4006
                    result = "PktMessageShowNotify";
                    break;
                case 0xFA7: //4007
                    result = "PktMessageReply";
                    break;
                case 0xFA8: //4008
                    result = "PktMessageReplyResult";
                    break;
                case 0xFA9: //4009
                    result = "PktLogShowNotify";
                    break;
                case 0xFAA: //4010
                    result = "PktStyleSheet";
                    break;
                case 0xFAB: //4011
                    result = "PktStyleSheetResult";
                    break;
                case 0xFAC: //4012
                    result = "PktStyleSheetResource";
                    break;
                case 0xFAD: //4013
                    result = "PktStyleSheetResourceResult";
                    break;
                case 0xFAE: //4014
                    result = "PktTestBotPlayerInfoRead";
                    break;
                case 0xFAF: //4015
                    result = "PktTestBotPlayerInfoReadResult";
                    break;
                case 0xFB0: //4016
                    result = "PktQuestEdit";
                    break;
                case 0xFB1: //4017
                    result = "PktQuestEditResult";
                    break;
                case 0xFB2: //4018
                    result = "PktDebugShapeShowNotify";
                    break;
                case 0xFB3: //4019
                    result = "PktSecurityCodeManage";
                    break;
                case 0xFB4: //4020
                    result = "PktSecurityCodeManageResult";
                    break;
                case 0xFB5: //4021
                    result = "PktWorldBossNotify";
                    break;
                case 0xFB6: //4022
                    result = "PktTestBotCommandNotify";
                    break;
                case 0xFB7: //4023
                    result = "PktPerformanceTrace";
                    break;
                case 0xFB8: //4024
                    result = "PktPerformanceTraceResult";
                    break;
                case 0xFB9: //4025
                    result = "PktApolloVoiceGetAuthKey";
                    break;
                case 0xFBA: //4026
                    result = "PktApolloVoiceGetAuthKeyResult";
                    break;
                case 0xFBB: //4027
                    result = "PktEnvironmentManage";
                    break;
                case 0xFBC: //4028
                    result = "PktEnvironmentManageResult";
                    break;
                case 0xFBD: //4029
                    result = "PktFuncCall";
                    break;
                case 0xFBE: //4030
                    result = "PktFuncCallResult";
                    break;
                case 0xFBF: //4031
                    result = "PktObjectStatsTrace";
                    break;
                case 0xFC0: //4032
                    result = "PktObjectStatsTraceResult";
                    break;
                case 0x1389:    //5001
                    result = "PktPlayerSocialActionListRead";
                    break;
                case 0x138A:    //5002
                    result = "PktPlayerSocialActionListReadResult";
                    break;
                case 0x138B:    //5003
                    result = "PktPlayerSocialActionMessageChange";
                    break;
                case 0x138C:    //5004
                    result = "PktPlayerSocialActionMessageChangeResult";
                    break;
                case 0x138D:    //5005
                    result = "PktEventGachaListRead";
                    break;
                case 0x138E:    //5006
                    result = "PktEventGachaListReadResult";
                    break;
                case 0x138F:    //5007
                    result = "PktEventGachaDetailRead";
                    break;
                case 0x1390:    //5008
                    result = "PktEventGachaDetailReadResult";
                    break;
                case 0x1391:    //5009
                    result = "PktEventGacha";
                    break;
                case 0x1392:    //5010
                    result = "PktEventGachaResult";
                    break;
                case 0x1393:    //5011
                    result = "PktEventGachaNotify";
                    break;
                case 0x1394:    //5012
                    result = "PktGuildDailyRewardRead";
                    break;
                case 0x1395:    //5013
                    result = "PktGuildDailyRewardReadResult";
                    break;
                case 0x1396:    //5014
                    result = "PktGuildFortressDailyRewardGet";
                    break;
                case 0x1397:    //5015
                    result = "PktGuildFortressDailyRewardGetResult";
                    break;
                case 0x1771:    //6001
                    result = "PktGuildAgitKeeperInfo";
                    break;
                case 0x1772:    //6002
                    result = "PktGuildAgitKeeperInfoResult";
                    break;
                case 0x1773:    //6003
                    result = "PktGuildAgitBanquetList";
                    break;
                case 0x1774:    //6004
                    result = "PktGuildAgitBanquetListResult";
                    break;
                case 0x1775:    //6005
                    result = "PktGuildAgitBanquetCreate";
                    break;
                case 0x1776:    //6006
                    result = "PktGuildAgitBanquetCreateResult";
                    break;
                case 0x1777:    //6007
                    result = "PktGuildAgitBanquetCreateNotify";
                    break;
                case 0x1778:    //6008
                    result = "PktGuildAgitRelicList";
                    break;
                case 0x1779:    //6009
                    result = "PktGuildAgitRelicListResult";
                    break;
                case 0x177A:    //6010
                    result = "PktGuildAgitRelicRegist";
                    break;
                case 0x177B:    //6011
                    result = "PktGuildAgitRelicRegistResult";
                    break;
                case 0x177C:    //6012
                    result = "PktGuildAgitRelicAppraise";
                    break;
                case 0x177D:    //6013
                    result = "PktGuildAgitRelicAppraiseResult";
                    break;
                case 0x177E:    //6014
                    result = "PktGuildAgitRelicPointUse";
                    break;
                case 0x177F:    //6015
                    result = "PktGuildAgitRelicPointUseResult";
                    break;
                case 0x1780:    //6016
                    result = "PktGuildAgitKeeperUpgrade";
                    break;
                case 0x1781:    //6017
                    result = "PktGuildAgitKeeperUpgradeResult";
                    break;
                case 0x1782:    //6018
                    result = "PktGuildAgitKeeperAutoExtends";
                    break;
                case 0x1783:    //6019
                    result = "PktGuildAgitKeeperAutoExtendsResult";
                    break;
                case 0x1784:    //6020
                    result = "PktGuildAgitQuestListNotify";
                    break;
                case 0x1785:    //6021
                    result = "PktGuildAgitQuestUpdateNotify";
                    break;
                case 0x1786:    //6022
                    result = "PktGuildFortressGiveUp";
                    break;
                case 0x1787:    //6023
                    result = "PktGuildFortressGiveUpResult";
                    break;
                case 0x1788:    //6024
                    result = "PktGuildCastleGiveUp";
                    break;
                case 0x1789:    //6025
                    result = "PktGuildCastleGiveUpResult";
                    break;
                case 0x178A:    //6026
                    result = "PktGuildStateChangeNotify";
                    break;
                case 0x178B:    //6027
                    result = "PktGuildDonateReset";
                    break;
                case 0x178C:    //6028
                    result = "PktGuildDonateResetResult";
                    break;
                case 0x178D:    //6029
                    result = "PktGuildAgitUpgradeNotify";
                    break;
                case 0x178E:    //6030
                    result = "PktGuildAgitFirePlaceEnable";
                    break;
                case 0x178F:    //6031
                    result = "PktGuildAgitFirePlaceEnableResult";
                    break;
                case 0x1790:    //6032
                    result = "PktGuildAgitFirePlaceEnableNotify";
                    break;
                case 0x1791:    //6033
                    result = "PktGuildAgitLiquidCreate";
                    break;
                case 0x1792:    //6034
                    result = "PktGuildAgitLiquidCreateResult";
                    break;
                case 0x1793:    //6035
                    result = "PktGuildAgitLiquidCreateNotify";
                    break;
                case 0x1794:    //6036
                    result = "PktOtherGuildAllianceChangeNotify";
                    break;
                case 0x1795:    //6037
                    result = "PktGuildCastleDailyRewardGet";
                    break;
                case 0x1796:    //6038
                    result = "PktGuildCastleDailyRewardGetResult";
                    break;
                case 0x1797:    //6039
                    result = "PktGuildOrderNotify";
                    break;
                case 0x1798:    //6040
                    result = "PktGuildWarehouseGrantByList";
                    break;
                case 0x1799:    //6041
                    result = "PktGuildWarehouseGrantByListResult";
                    break;
                case 0x179A:    //6042
                    result = "PktGuildCastleTypeSelect";
                    break;
                case 0x179B:    //6043
                    result = "PktGuildCastleTypeSelectResult";
                    break;
                case 0x179C:    //6044
                    result = "PktGuildCastleTypeSelectNotify";
                    break;
                case 0x179D:    //6045
                    result = "PktGuildHostileWarEndSuggest";
                    break;
                case 0x179E:    //6046
                    result = "PktGuildHostileWarEndSuggestResult";
                    break;
                case 0x179F:    //6047
                    result = "PktGuildHostileWarEndAnswer";
                    break;
                case 0x17A0:    //6048
                    result = "PktGuildHostileWarEndAnswerResult";
                    break;
                case 0x17A1:    //6049
                    result = "PktGuildAgitQuestCompleteNotify";
                    break;
                case 0x17A2:    //6050
                    result = "PktGuildAgitWishListRead";
                    break;
                case 0x17A3:    //6051
                    result = "PktGuildAgitWishListReadResult";
                    break;
                case 0x17A4:    //6052
                    result = "PktGuildCastleTypeSelectTimeNotify";
                    break;
                case 0x17A5:    //6053
                    result = "PktGuildAgitWishGet";
                    break;
                case 0x17A6:    //6054
                    result = "PktGuildAgitWishGetResult";
                    break;
                case 0x17A7:    //6055
                    result = "PktGuildReJoinPenaltyTimeRead";
                    break;
                case 0x17A8:    //6056
                    result = "PktGuildReJoinPenaltyTimeReadResult";
                    break;
                case 0x17A9:    //6057
                    result = "PktGuildWantJoin";
                    break;
                case 0x17AA:    //6058
                    result = "PktGuildWantJoinResult";
                    break;
                case 0x17AB:    //6059
                    result = "PktGuildInviteListRead";
                    break;
                case 0x17AC:    //6060
                    result = "PktGuildInviteListReadResult";
                    break;
                case 0x17AD:    //6061
                    result = "PktGuildWantJoinListRead";
                    break;
                case 0x17AE:    //6062
                    result = "PktGuildWantJoinListReadResult";
                    break;
                case 0x17AF:    //6063
                    result = "PktGuildInviteCancel";
                    break;
                case 0x17B0:    //6064
                    result = "PktGuildInviteCancelResult";
                    break;
                case 0x17B1:    //6065
                    result = "PktGuildInviteReject";
                    break;
                case 0x17B2:    //6066
                    result = "PktGuildInviteRejectResult";
                    break;
                case 0x17B3:    //6067
                    result = "PktGuildMemberSelfIntroChange";
                    break;
                case 0x17B4:    //6068
                    result = "PktGuildMemberSelfIntroChangeResult";
                    break;
                case 0x17B5:    //6069
                    result = "PktGuildHostileWarRecordDetailRead";
                    break;
                case 0x17B6:    //6070
                    result = "PktGuildHostileWarRecordDetailReadResult";
                    break;
                case 0x17B7:    //6071
                    result = "PktGuildHostileWarRecordRankRead";
                    break;
                case 0x17B8:    //6072
                    result = "PktGuildHostileWarRecordRankReadResult";
                    break;
                case 0x17B9:    //6073
                    result = "PktGuildVoiceChatJoinNotify";
                    break;
                case 0x17BA:    //6074
                    result = "PktGuildVoiceChatJoin";
                    break;
                case 0x17BB:    //6075
                    result = "PktGuildVoiceChatJoinResult";
                    break;
                case 0x17BC:    //6076
                    result = "PktGuildVoiceChatExit";
                    break;
                case 0x17BD:    //6077
                    result = "PktGuildVoiceChatExitResult";
                    break;
                case 0x17BE:    //6078
                    result = "PktGuildVoiceChatEmpowerment";
                    break;
                case 0x17BF:    //6079
                    result = "PktGuildVoiceChatEmpowermentResult";
                    break;
                case 0x17C0:    //6080
                    result = "PktGuildVoiceChatEmpowermentNotify";
                    break;
                case 0x1B59:    //7001
                    result = "PktPetListRead";
                    break;
                case 0x1B5A:    //7002
                    result = "PktPetListReadResult";
                    break;
                case 0x1B5B:    //7003
                    result = "PktPetUnlockNotify";
                    break;
                case 0x1B5C:    //7004
                    result = "PktPetItemUse";
                    break;
                case 0x1B5D:    //7005
                    result = "PktPetItemUseResult";
                    break;
                case 0x1B5E:    //7006
                    result = "PktPetEquip";
                    break;
                case 0x1B5F:    //7007
                    result = "PktPetEquipResult";
                    break;
                case 0x1B60:    //7008
                    result = "PktPetRiding";
                    break;
                case 0x1B61:    //7009
                    result = "PktPetRidingResult";
                    break;
                case 0x1B62:    //7010
                    result = "PktPetUpdateNotify";
                    break;
                case 0x1B63:    //7011
                    result = "PktPetRidingNotify";
                    break;
                case 0x1B64:    //7012
                    result = "PktPetActive";
                    break;
                case 0x1B65:    //7013
                    result = "PktPetActiveResult";
                    break;
                case 0x1B66:    //7014
                    result = "PktPetActivatableNotify";
                    break;
                case 0x1B67:    //7015
                    result = "PktPetItemEquip";
                    break;
                case 0x1B68:    //7016
                    result = "PktPetItemEquipResult";
                    break;
                case 0x1B69:    //7017
                    result = "PktPetItemLevelUp";
                    break;
                case 0x1B6A:    //7018
                    result = "PktPetItemLevelUpResult";
                    break;
                case 0x1B6B:    //7019
                    result = "PktPetItemUpgrade";
                    break;
                case 0x1B6C:    //7020
                    result = "PktPetItemUpgradeResult";
                    break;
                case 0x1B6D:    //7021
                    result = "PktPetUpgrade";
                    break;
                case 0x1B6E:    //7022
                    result = "PktPetUpgradeResult";
                    break;
                case 0x1B6F:    //7023
                    result = "PktForcePetRidingNotify";
                    break;
                case 0x1B70:    //7024
                    result = "PktPetItemEnchant";
                    break;
                case 0x1B71:    //7025
                    result = "PktPetItemEnchantResult";
                    break;
                case 0x1B72:    //7026
                    result = "PktPetEquipmentItemLike";
                    break;
                case 0x1B73:    //7027
                    result = "PktPetEquipmentItemLikeResult";
                    break;
                case 0x1B74:    //7028
                    result = "PktPetItemOptionChange";
                    break;
                case 0x1B75:    //7029
                    result = "PktPetItemOptionChangeResult";
                    break;
                case 0x1C21:    //7201
                    result = "PktOptionChange";
                    break;
                case 0x1C22:    //7202
                    result = "PktOptionChangeResult";
                    break;
                case 0x1C23:    //7203
                    result = "PktOptionDeckListRead";
                    break;
                case 0x1C24:    //7204
                    result = "PktOptionDeckListReadResult";
                    break;
                case 0x1C25:    //7205
                    result = "PktOptionDeckChange";
                    break;
                case 0x1C26:    //7206
                    result = "PktOptionDeckChangeResult";
                    break;
                case 0x1C85:    //7301
                    result = "PktBattlefieldInfo";
                    break;
                case 0x1C86:    //7302
                    result = "PktBattlefieldInfoResult";
                    break;
                case 0x1C87:    //7303
                    result = "PktBattlefieldOpenTimeListNotify";
                    break;
                case 0x1C88:    //7304
                    result = "PktBattlefieldHistoryInfo";
                    break;
                case 0x1C89:    //7305
                    result = "PktBattlefieldHistoryInfoResult";
                    break;
                case 0x1C8A:    //7306
                    result = "PktBattlefieldPopup";
                    break;
                case 0x1C8B:    //7307
                    result = "PktBattlefieldPopupResult";
                    break;
                case 0x1C8C:    //7308
                    result = "PktBattlefieldEnter";
                    break;
                case 0x1C8D:    //7309
                    result = "PktBattlefieldEnterResult";
                    break;
                case 0x1C8E:    //7310
                    result = "PktBattlefieldEnterNotify";
                    break;
                case 0x1C8F:    //7311
                    result = "PktBattlefieldEnterCancel";
                    break;
                case 0x1C90:    //7312
                    result = "PktBattlefieldEnterCancelResult";
                    break;
                case 0x1C91:    //7313
                    result = "PktBattlefieldEnterCancelNotify";
                    break;
                case 0x1C92:    //7314
                    result = "PktBattlefieldEnterCompletedNotify";
                    break;
                case 0x1C93:    //7315
                    result = "PktBattlefieldCountDownStartNotify";
                    break;
                case 0x1C94:    //7316
                    result = "PktBattlefieldWorldEnter";
                    break;
                case 0x1C95:    //7317
                    result = "PktBattlefieldWorldEnterResult";
                    break;
                case 0x1C96:    //7318
                    result = "PktBattlefieldTimeNotify";
                    break;
                case 0x1C97:    //7319
                    result = "PktBattlefieldEndNotify";
                    break;
                case 0x1C98:    //7320
                    result = "PktBattlefieldExit";
                    break;
                case 0x1C99:    //7321
                    result = "PktBattlefieldExitResult";
                    break;
                case 0x1C9A:    //7322
                    result = "PktBattlefieldScoreChangeNotify";
                    break;
                case 0x1C9B:    //7323
                    result = "PktBattlefieldOccupationProgressListNotify";
                    break;
                case 0x1C9C:    //7324
                    result = "PktBattlefieldFreyaCarveStartNotify";
                    break;
                case 0x1C9D:    //7325
                    result = "PktBattlefieldFreyaCarveSuccessNotify";
                    break;
                case 0x1C9E:    //7326
                    result = "PktBattlefieldFreyaCarveFailNotify";
                    break;
                case 0x1C9F:    //7327
                    result = "PktBattlefieldKillNotify";
                    break;
                case 0x1CA0:    //7328
                    result = "PktBattlefieldOfHonorReconnectDataNotify";
                    break;
                case 0x1CA1:    //7329
                    result = "PktBattlefieldDailyTimeEndNotify";
                    break;
                case 0x1CA2:    //7330
                    result = "PktBattlefieldHallOfFameInfo";
                    break;
                case 0x1CA3:    //7331
                    result = "PktBattlefieldHallOfFameInfoResult";
                    break;
                case 0x1CA4:    //7332
                    result = "PktBattlefieldSeasonRewardNotify";
                    break;
                case 0x1CA5:    //7333
                    result = "PktBattlefieldSeasonRewardRequest";
                    break;
                case 0x1CA6:    //7334
                    result = "PktBattlefieldSeasonRewardRequestResult";
                    break;
                case 0x1CA7:    //7335
                    result = "PktBattlefieldPartyMemberLeagueChangeNotify";
                    break;
                case 0x1CA8:    //7336
                    result = "PktBattlefieldNextBuffCreateTimeNotify";
                    break;
                case 0x2329:    //9001
                    result = "PktGuildDungeonSupportRequest";
                    break;
                case 0x232A:    //9002
                    result = "PktGuildDungeonSupportRequestResult";
                    break;
                case 0x232B:    //9003
                    result = "PktGuildDungeonSupportCancel";
                    break;
                case 0x232C:    //9004
                    result = "PktGuildDungeonSupportCancelResult";
                    break;
                case 0x232D:    //9005
                    result = "PktGuildDungeonParticipate";
                    break;
                case 0x232E:    //9006
                    result = "PktGuildDungeonParticipateResult";
                    //PktGuildDungeonParticipateresult.Packet(packet);
                    break;
                case 0x232F:    //9007
                    result = "PktGuildDungeonHelpresultNotify";
                    break;
                case 0x2330:    //9008
                    result = "PktGuildDungeonHelpInfo";
                    break;
                case 0x2331:    //9009
                    result = "PktGuildDungeonHelpInfoResult";
                    break;
                case 0x2332:    //9010
                    result = "PktGuildDungeonHelpList";
                    break;
                case 0x2333:    //9011
                    result = "PktGuildDungeonHelpListResult";
                    break;
                case 0x251D:    //9501
                    result = "PktESportsContentsLockListRead";
                    break;
                case 0x251E:    //9502
                    result = "PktESportsContentsLockListReadResult";
                    break;
                case 0x251F:    //9503
                    result = "PktESportsMatchInfoNotify";
                    break;
                case 0x2520:    //9504
                    result = "PktESportsMatchJoin";
                    break;
                case 0x2521:    //9505
                    result = "PktESportsMatchJoinResult";
                    break;
                case 0x2581:    //9601
                    result = "PktEventCheckBoardListRead";
                    break;
                case 0x2582:    //9602
                    result = "PktEventCheckBoardListReadResult";
                    break;
                case 0x2583:    //9603
                    result = "PktEventCheckBoardGet";
                    break;
                case 0x2584:    //9604
                    result = "PktEventCheckBoardGetResult";
                    break;
                case 0x2585:    //9605
                    result = "PktEventCheckBoardReset";
                    break;
                case 0x2586:    //9606
                    result = "PktEventCheckBoardResetResult";
                    break;
                case 0x2587:    //9607
                    result = "PktEventCheckBoardAccrueGet";
                    break;
                case 0x2588:    //9608
                    result = "PktEventCheckBoardAccrueGetResult";
                    break;
                case 0x2589:    //9609
                    result = "PktEventCheckBoardBadgeClear";
                    break;
                case 0x258A:    //9610
                    result = "PktEventCheckBoardBadgeClearResult";
                    break;
                case 0x25E5:    //9701
                    result = "PktFacebookInviteList";
                    break;
                case 0x25E6:    //9702
                    result = "PktFacebookInviteListResult";
                    break;
                case 0x25E7:    //9703
                    result = "PktFacebookInviteRequest";
                    break;
                case 0x25E8:    //9704
                    result = "PktFacebookInviteRequestResult";
                    break;
                case 0x25E9:    //9705
                    result = "PktFacebookFriendListInfoRequest";
                    break;
                case 0x25EA:    //9706
                    result = "PktFacebookFriendListInfoRequestResult";
                    break;
                case 0x25EB:    //9707
                    result = "PktFacebookRewardRequest";
                    break;
                case 0x25EC:    //9708
                    result = "PktFacebookRewardRequestResult";
                    break;
                case 0x2617:    //9751
                    result = "PktNewsletterListRead";
                    break;
                case 0x2618:    //9752
                    result = "PktNewsletterListReadResult";
                    break;
                case 0x2619:    //9753
                    result = "PktNewsletterDelete";
                    break;
                case 0x261A:    //9754
                    result = "PktNewsletterDeleteResult";
                    break;
                case 0x261B:    //9755
                    result = "PktNewsletterDeleteAll";
                    break;
                case 0x261C:    //9756
                    result = "PktNewsletterDeleteAllResult";
                    break;
                case 0x261D:    //9757
                    result = "PktNewsletterRewardGet";
                    break;
                case 0x261E:    //9758
                    result = "PktNewsletterRewardGetResult";
                    break;
                case 0x261F:    //9759
                    result = "PktNewsletterRewardAllGet";
                    break;
                case 0x2620:    //9760
                    result = "PktNewsletterRewardAllGetResult";
                    break;
                case 0x2621:    //9761
                    result = "PktNewsletterReceiveNotify";
                    break;
                case 0x2622:    //9762
                    result = "PktNewsletterOpen";
                    break;
                case 0x2623:    //9763
                    result = "PktNewsletterOpenResult";
                    break;
                case 0x2711:    //10001
                    result = "PktGuildEmblemChangeNotify";
                    break;
                case 0x2712:    //10002
                    result = "PktGuildNicknameChangeNotify";
                    break;
                case 0x2713:    //10003
                    result = "PktGuildMemberLoginNotify";
                    break;
                case 0x2714:    //10004
                    result = "PktGuildDonateNotify";
                    break;
                case 0x2715:    //10005
                    result = "PktGuildWarehouseGrantNotify";
                    break;
                case 0x2716:    //10006
                    result = "PktGuildWarehouseGrantAllNotify";
                    break;
                case 0x2717:    //10007
                    result = "PktGuildWarehouseGrantByListNotify";
                    break;
                case 0x2718:    //10008
                    result = "PktGuildMarketGiftBuyNotify";
                    break;
                case 0x2719:    //10009
                    result = "PktGuildRevenge";
                    break;
                case 0x271A:    //10010
                    result = "PktGuildRevengeResult";
                    break;
                case 0x271B:    //10011
                    result = "PktGuildRevengeNotify";
                    break;
                case 0x271C:    //10012
                    result = "PktGuildRevengeAnswer";
                    break;
                case 0x271D:    //10013
                    result = "PktGuildRevengeAnswerResult";
                    break;
                case 0x271E:    //10014
                    result = "PktGuildHostilityRegisterNotify";
                    break;
                case 0x271F:    //10015
                    result = "PktGuildHostileWarEndRefuseNotify";
                    break;
                case 0x2720:    //10016
                    result = "PktGuildHostileWarEndNotify";
                    break;
                case 0x2721:    //10017
                    result = "PktGuildHostileWarSurrenderNotify";
                    break;
                case 0x2722:    //10018
                    result = "PktGuildBuffUpgradeNotify";
                    break;
                case 0x2723:    //10019
                    result = "PktGuildMarketBuyNotify";
                    break;
                case 0x2724:    //10020
                    result = "PktGuildDungeonResetNotify";
                    break;
                case 0x2725:    //10021
                    result = "PktFortressSiegeEntryBidNotify";
                    break;
                case 0x2726:    //10022
                    result = "PktCastleSiegeEntryBidNotify";
                    break;
                case 0x2727:    //10023
                    result = "PktFortressSiegeEntryBidTimeNotify";
                    break;
                case 0x2728:    //10024
                    result = "PktCastleSiegeEntryBidTimeNotify";
                    break;
                case 0x2729:    //10025
                    result = "PktFortressSiegeJoinNotify";
                    break;
                case 0x272A:    //10026
                    result = "PktCastleSiegeJoinNotify";
                    break;
                case 0x272B:    //10027
                    result = "PktFortressSiegeStartNotify";
                    break;
                case 0x272C:    //10028
                    result = "PktCastleSiegeStartNotify";
                    break;
                case 0x272D:    //10029
                    result = "PktGuildFortressGiveUpNotify";
                    break;
                case 0x272E:    //10030
                    result = "PktGuildCastleTypeSelectGuildNotify";
                    break;
                case 0x272F:    //10031
                    result = "PktGuildAgitCrystalUpgradeNotify";
                    break;
                case 0x2730:    //10032
                    result = "PktGuildAgitRelicPointUseNotify";
                    break;
                case 0x2731:    //10033
                    result = "PktGuildAgitFirePlaceDisableNotify";
                    break;
                case 0x2775:    //10101
                    result = "PktServerTransferListRead";
                    break;
                case 0x2776:    //10102
                    result = "PktServerTransferListReadResult";
                    break;
                case 0x2777:    //10103
                    result = "PktServerTransferBuyCheck";
                    break;
                case 0x2778:    //10104
                    result = "PktServerTransferBuyCheckResult";
                    break;
                case 0x2779:    //10105
                    result = "PktServerTransferInfoRead";
                    break;
                case 0x277A:    //10106
                    result = "PktServerTransferInfoReadResult";
                    break;
                case 0x277B:    //10107
                    result = "PktServerTransferItemUse";
                    break;
                case 0x277C:    //10108
                    result = "PktServerTransferItemUseResult";
                    break;
                case 0x277D:    //10109
                    result = "PktServerTransferReady";
                    break;
                case 0x277E:    //10110
                    result = "PktServerTransferReadyResult";
                    break;
                case 0x277F:    //10111
                    result = "PktServerTransferStart";
                    break;
                case 0x2780:    //10112
                    result = "PktServerTransferStartResult";
                    break;
                case 0x2781:    //10113
                    result = "PktServerTransferEnd";
                    break;
                case 0x2782:    //10114
                    result = "PktServerTransferEndResult";
                    break;
                case 0x2783:    //10115
                    result = "PktPlayerStorageListRead";
                    break;
                case 0x2784:    //10116
                    result = "PktPlayerStorageListReadResult";
                    break;
                case 0x2785:    //10117
                    result = "PktPlayerStorageExpand";
                    break;
                case 0x2786:    //10118
                    result = "PktPlayerStorageExpandResult";
                    break;
                case 0x2787:    //10119
                    result = "PktItemMoveToPlayerStorage";
                    break;
                case 0x2788:    //10120
                    result = "PktItemMoveToPlayerStorageResult";
                    break;
                case 0x2789:    //10121
                    result = "PktPlayerStorageItemMoveToBag";
                    break;
                case 0x278A:    //10122
                    result = "PktPlayerStorageItemMoveToBagResult";
                    break;
                case 0x278B:    //10123
                    result = "PktItemSpecialNotify";
                    break;
                case 0x278C:    //10124
                    result = "PktItemCoolTimeListNotify";
                    break;
                case 0x278D:    //10125
                    result = "PktBossItemDropNotify";
                    break;
                case 0x283D:    //10301
                    result = "PktFreeSiegeRecruitCreate";
                    break;
                case 0x283E:    //10302
                    result = "PktFreeSiegeRecruitCreateResult";
                    break;
                case 0x283F:    //10303
                    result = "PktFreeSiegeRecruitCreateNotify";
                    break;
                case 0x2840:    //10304
                    result = "PktFreeSiegeRecruitDisband";
                    break;
                case 0x2841:    //10305
                    result = "PktFreeSiegeRecruitDisbandResult";
                    break;
                case 0x2842:    //10306
                    result = "PktFreeSiegeRecruitDisbandNotify";
                    break;
                case 0x2843:    //10307
                    result = "PktFreeSiegeRecruitExpel";
                    break;
                case 0x2844:    //10308
                    result = "PktFreeSiegeRecruitExpelResult";
                    break;
                case 0x2845:    //10309
                    result = "PktFreeSiegeRecruitExpelNotify";
                    break;
                case 0x2846:    //10310
                    result = "PktFreeSiegeRecruitWithdraw";
                    break;
                case 0x2847:    //10311
                    result = "PktFreeSiegeRecruitWithdrawResult";
                    break;
                case 0x2848:    //10312
                    result = "PktFreeSiegeRecruitWithdrawNotify";
                    break;
                case 0x2849:    //10313
                    result = "PktFreeSiegeRecruitChangeClass";
                    break;
                case 0x284A:    //10314
                    result = "PktFreeSiegeRecruitChangeClassResult";
                    break;
                case 0x284B:    //10315
                    result = "PktFreeSiegeRecruitChangeClassNotify";
                    break;
                case 0x284C:    //10316
                    result = "PktFreeSiegeRecruitInvite";
                    break;
                case 0x284D:    //10317
                    result = "PktFreeSiegeRecruitInviteResult";
                    break;
                case 0x284E:    //10318
                    result = "PktFreeSiegeRecruitInviteNotify";
                    break;
                case 0x284F:    //10319
                    result = "PktFreeSiegeRecruitInviteRefuse";
                    break;
                case 0x2850:    //10320
                    result = "PktFreeSiegeRecruitInviteRefuseResult";
                    break;
                case 0x2851:    //10321
                    result = "PktFreeSiegeRecruitInviteRefuseNotify";
                    break;
                case 0x2852:    //10322
                    result = "PktFreeSiegeRecruitJoin";
                    break;
                case 0x2853:    //10323
                    result = "PktFreeSiegeRecruitJoinResult";
                    break;
                case 0x2854:    //10324
                    result = "PktFreeSiegeRecruitJoinNotify";
                    break;
                case 0x2855:    //10325
                    result = "PktFreeSiegeRecruitReady";
                    break;
                case 0x2856:    //10326
                    result = "PktFreeSiegeRecruitReadyResult";
                    break;
                case 0x2857:    //10327
                    result = "PktFreeSiegeRecruitReadyNotify";
                    break;
                case 0x2858:    //10328
                    result = "PktFreeSiegeEnterRequest";
                    break;
                case 0x2859:    //10329
                    result = "PktFreeSiegeEnterRequestResult";
                    break;
                case 0x285A:    //10330
                    result = "PktFreeSiegeEnterRequestNotify";
                    break;
                case 0x285B:    //10331
                    result = "PktFreeSiegeRecruitDataNotify";
                    break;
                case 0x285C:    //10332
                    result = "PktFreeSiegeEnterCancel";
                    break;
                case 0x285D:    //10333
                    result = "PktFreeSiegeEnterCancelResult";
                    break;
                case 0x285E:    //10334
                    result = "PktFreeSiegeEnterCancelNotify";
                    break;
                case 0x285F:    //10335
                    result = "PktFreeSiegeStepNotify";
                    break;
                case 0x2860:    //10336
                    result = "PktFreeSiegeInfo";
                    break;
                case 0x2861:    //10337
                    result = "PktFreeSiegeInfoResult";
                    break;
                case 0x2862:    //10338
                    result = "PktFreeSiegeSubMissionUpdateNotify";
                    break;
                case 0x2863:    //10339
                    result = "PktFreeSiegeFinishNotify";
                    break;
                case 0x2864:    //10340
                    result = "PktFreeSiegeChangeClass";
                    break;
                case 0x2865:    //10341
                    result = "PktFreeSiegeChangeClassResult";
                    break;
                case 0x2866:    //10342
                    result = "PktFreeSiegeLeaderState";
                    break;
                case 0x2867:    //10343
                    result = "PktFreeSiegeLeaderStateResult";
                    break;
                case 0x2868:    //10344
                    result = "PktFreeSiegeChangeLeaderNotify";
                    break;
                case 0x2869:    //10345
                    result = "PktFreeSiegeEnterWaitNotify";
                    break;
                case 0x286A:    //10346
                    result = "PktFreeSiegeSkillListNotify";
                    break;
                case 0x286B:    //10347
                    result = "PktFreeSiegeTransferCoolTimeNotify";
                    break;
                case 0x2905:    //10501
                    result = "PktObserverSiegeEnter";
                    break;
                case 0x2906:    //10502
                    result = "PktObserverSiegeEnterResult";
                    break;
                case 0x2907:    //10503
                    result = "PktObserverSiegeEnterNotify";
                    break;
                case 0x2908:    //10504
                    result = "PktObserverParticipateInfo";
                    break;
                case 0x2909:    //10505
                    result = "PktObserverParticipateInfoResult";
                    break;
                case 0x290A:    //10506
                    result = "PktCommonSiegeGuildInfoRead";
                    break;
                case 0x290B:    //10507
                    result = "PktCommonSiegeGuildInfoReadResult";
                    break;
                case 0x290C:    //10508
                    result = "PktCommonSiegeFinishNotifyForObserver";
                    break;
                case 0x2AF9:    //11001
                    result = "PktSummonGemListRead";
                    break;
                case 0x2AFA:    //11002
                    result = "PktSummonGemListReadResult";
                    break;
                case 0x2AFB:    //11003
                    result = "PktSummonGemPartyMatch";
                    break;
                case 0x2AFC:    //11004
                    result = "PktSummonGemPartyMatchResult";
                    break;
                case 0x2AFD:    //11005
                    result = "PktSummonGemPartyMatchCancel";
                    break;
                case 0x2AFE:    //11006
                    result = "PktSummonGemPartyMatchCancelResult";
                    break;
                case 0x2AFF:    //11007
                    result = "PktSummonGemEnter";
                    break;
                case 0x2B00:    //11008
                    result = "PktSummonGemEnterResult";
                    break;
                case 0x2B01:    //11009
                    result = "PktSummonGemSingleMatch";
                    break;
                case 0x2B02:    //11010
                    result = "PktSummonGemSingleMatchResult";
                    break;
                case 0x2B03:    //11011
                    result = "PktSummonGemSingleMatchCancel";
                    break;
                case 0x2B04:    //11012
                    result = "PktSummonGemSingleMatchCancelResult";
                    break;
                case 0x2B05:    //11013
                    result = "PktSummonGemNextDungeonReadyNotice";
                    break;
                case 0x2B06:    //11014
                    result = "PktSummonGemDungeonFinishNotice";
                    break;
                case 0x2B07:    //11015
                    result = "PktSummonGemAutoMatch";
                    break;
                case 0x2B08:    //11016
                    result = "PktSummonGemAutoMatchResult";
                    break;
                case 0x2B09:    //11017
                    result = "PktSummonGemAutoMatchCancel";
                    break;
                case 0x2B0A:    //11018
                    result = "PktSummonGemAutoMatchCancelResult";
                    break;
                case 0x2B0B:    //11019
                    result = "PktSummonGemReservationExit";
                    break;
                case 0x2B0C:    //11020
                    result = "PktSummonGemReservationExitResult";
                    break;
                case 0x2B0D:    //11021
                    result = "PktSummonGemReservationExitCancel";
                    break;
                case 0x2B0E:    //11022
                    result = "PktSummonGemReservationExitCancelResult";
                    break;
                case 0x2B0F:    //11023
                    result = "PktSummonGemMemberChangeNotice";
                    break;
                case 0x2B10:    //11024
                    result = "PktSummonGemDungeonStartNotice";
                    break;
                case 0x2B11:    //11025
                    result = "PktSummonGemItemConsumeNotice";
                    break;
                case 0x2B12:    //11026
                    result = "PktSummonGemDungeonExitNotice";
                    break;
                default:
                    result = "(InvalidPacket)";
                    break;
            }


            Console.Write("\tPacketType: " + result + "\n");
        }
    }
}
