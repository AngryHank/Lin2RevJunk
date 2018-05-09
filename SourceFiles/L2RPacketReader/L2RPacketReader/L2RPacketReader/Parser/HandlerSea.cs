using System;
using System.IO;
using L2RPacketReader.Parser.Parsers;

namespace L2RPacketReader.Parser
{
    class HandlerSEA
    {
        private static string result;
        public static void TypePacket(PacketReader packet, ushort packetID)
        {

            /*
             * 
             * Packet IDs for version: 0.22.10      2018-03-27
             * 
             * All packet parsers will need to be readded and 
             * tested before this will actually do anything.
             * Most parsers likely are not compatible with this 
             * verison
             * 
             */
            Console.Write("PacketID: " + packetID.ToString("X") + "\tLength: " + packet.Remaining);
            //Packet Handler for PacketID
            switch (packetID)
            {
                case 0:     // 0x1
                    result = "PktVersion";
                    break;
                case 1:     // 0x2
                    result = "PktVersionResult";
                    break;
                case 2:     // 0x3
                    result = "PktLogin";
                    break;
                case 3:     // 0x4
                    result = "PktLoginResult";
                    break;
                case 4:     // 0x5
                    result = "PktLogout";
                    break;
                case 5:     // 0x6
                    result = "PktLogoutResult";
                    break;
                case 6:     // 0x7
                    result = "PktKeyChangeNotify";
                    break;
                case 7:     // 0x8
                    result = "PktKeyChanged";
                    break;
                case 8:     // 0x9
                    result = "PktKeyChangedResult";
                    break;
                case 9:     // 0xA
                    result = "PktWithdrawUser";
                    break;
                case 10:        // 0xB
                    result = "PktWithdrawUserResult";
                    break;
                case 11:        // 0xC
                    result = "PktTimeSync";
                    break;
                case 12:        // 0xD
                    result = "PktTimeSyncResult";
                    break;
                case 13:        // 0xE
                    result = "PktKickout";
                    break;
                case 14:        // 0xF
                    result = "PktKickoutNotify";
                    break;
                case 15:        // 0x10
                    result = "PktKickoutResult";
                    break;
                case 16:        // 0x11
                    result = "PktWaitingNumUpdateNotify";
                    break;
                case 17:        // 0x12
                    result = "PktWaitingOverNotify";
                    break;
                case 18:        // 0x13
                    result = "PktPlayerListRead";
                    break;
                case 19:        // 0x14
                    result = "PktPlayerListReadResult";
                    break;
                case 20:        // 0x15
                    result = "PktPlayerCreate";
                    break;
                case 21:        // 0x16
                    result = "PktPlayerCreateResult";
                    break;
                case 22:        // 0x17
                    result = "PktPlayerDelete";
                    break;
                case 23:        // 0x18
                    result = "PktPlayerDeleteResult";
                    break;
                case 24:        // 0x19
                    result = "PktPlayerSelect";
                    break;
                case 25:        // 0x1A
                    result = "PktPlayerSelectResult";
                    break;
                case 26:        // 0x1B
                    result = "PktSystemTutorialStart";
                    break;
                case 27:        // 0x1C
                    result = "PktSystemTutorialStartResult";
                    break;
                case 28:        // 0x1D
                    result = "PktMoveToSelectCharacter";
                    break;
                case 29:        // 0x1E
                    result = "PktMoveToSelectCharacterResult";
                    break;
                case 30:        // 0x1F
                    result = "PktNoticeListRead";
                    break;
                case 31:        // 0x20
                    result = "PktNoticeListReadResult";
                    break;
                case 32:        // 0x21
                    result = "PktPopupNoticeListRead";
                    break;
                case 33:        // 0x22
                    result = "PktPopupNoticeListReadResult";
                    break;
                case 34:        // 0x23
                    result = "PktPopupNoticeChangeNotify";
                    break;
                case 35:        // 0x24
                    result = "PktRollNoticeNotify";
                    break;
                case 36:        // 0x25
                    result = "PktConfineUserNotify";
                    break;
                case 37:        // 0x26
                    result = "PktConfineUserKick";
                    break;
                case 38:        // 0x27
                    result = "PktConfineUserKickResult";
                    break;
                case 39:        // 0x28
                    result = "PktNoticeNotify";
                    break;
                case 40:        // 0x29
                    result = "PktVersion2";
                    break;
                case 41:        // 0x2A
                    result = "PktVersion2Result";
                    break;
                case 42:        // 0x2B
                    result = "PktAccountLinkInfo";
                    break;
                case 43:        // 0x2C
                    result = "PktAccountLinkInfoResult";
                    break;
                case 44:        // 0x2D
                    result = "PktAccountLinkReward";
                    break;
                case 45:        // 0x2E
                    result = "PktAccountLinkRewardResult";
                    break;
                case 46:        // 0x2F
                    result = "PktNicknameCheck";
                    break;
                case 47:        // 0x30
                    result = "PktNicknameCheckResult";
                    break;
                case 100:       // 0x65
                    result = "PktWorldMoveReserve";
                    break;
                case 101:       // 0x66
                    result = "PktWorldMoveReserveResult";
                    break;
                case 102:       // 0x67
                    result = "PktWorldMoveStart";
                    break;
                case 103:       // 0x68
                    result = "PktWorldMoveStartResult";
                    break;
                case 104:       // 0x69
                    result = "PktWorldMoveFinish";
                    break;
                case 105:       // 0x6A
                    result = "PktWorldMoveFinishResult";
                    break;
                case 106:       // 0x6B
                    result = "PktWorldChannelList";
                    break;
                case 107:       // 0x6C
                    result = "PktWorldChannelListResult";
                    break;
                case 108:       // 0x6D
                    result = "PktWorldChannelMoveReserve";
                    break;
                case 109:       // 0x6E
                    result = "PktWorldChannelMoveReserveResult";
                    break;
                case 110:       // 0x6F
                    result = "PktWorldLeave";
                    break;
                case 111:       // 0x70
                    result = "PktWorldLeaveResult";
                    break;
                case 112:       // 0x71
                    result = "PktTeleportCastingStart";
                    break;
                case 113:       // 0x72
                    result = "PktTeleportCastingStartResult";
                    break;
                case 114:       // 0x73
                    result = "PktTeleportCastingStartNotify";
                    break;
                case 115:       // 0x74
                    result = "PktTeleportDepartNotify";
                    break;
                case 116:       // 0x75
                    result = "PktTeleportArriveNotify";
                    break;
                case 117:       // 0x76
                    result = "PktWorldInfoUpdateNotify";
                    break;
                case 118:       // 0x77
                    result = "PktMapPlayerPositionRead";
                    break;
                case 119:       // 0x78
                    result = "PktMapPlayerPositionReadResult";
                    break;
                case 120:       // 0x79
                    result = "PktMapWorldInfoRead";
                    break;
                case 121:       // 0x7A
                    result = "PktMapWorldInfoReadResult";
                    break;
                case 122:       // 0x7B
                    result = "PktAutoMoveTeleport";
                    break;
                case 123:       // 0x7C
                    result = "PktAutoMoveTeleportResult";
                    break;
                case 124:       // 0x7D
                    result = "PktWorldExit";
                    break;
                case 125:       // 0x7E
                    result = "PktWorldExitResult";
                    break;
                case 126:       // 0x7F
                    result = "PktBossWorldEnterInfo";
                    break;
                case 127:       // 0x80
                    result = "PktBossWorldEnterInfoResult";
                    break;
                case 128:       // 0x81
                    result = "PktBossWorldClosingNotify";
                    break;
                case 129:       // 0x82
                    result = "PktCertainPointNotify";
                    break;
                case 130:       // 0x83
                    result = "PktTownExit";
                    break;
                case 131:       // 0x84
                    result = "PktTownExitResult";
                    break;
                case 132:       // 0x85
                    result = "PktBossTrophyTownEnterNotify";
                    break;
                case 133:       // 0x86
                    result = "PktBossTrophyStatusNotify";
                    break;
                case 200:       // 0xC9
                    result = "PktPlayerMove";
                    break;
                case 201:       // 0xCA
                    result = "PktPlayerMoveResult";
                    break;
                case 202:       // 0xCB
                    result = "PktPlayerMoveNotify";
                    break;
                case 203:       // 0xCC
                    result = "PktPlayerMoveListNotify";
                    break;
                case 204:       // 0xCD
                    result = "PktSightEnterNotify";
                    break;
                case 205:       // 0xCE
                    result = "PktSightLeaveNotify";
                    break;
                case 206:       // 0xCF
                    result = "PktNpcMoveNotify";
                    break;
                case 207:       // 0xD0
                    result = "PktCharacterDieNotify";
                    break;
                case 208:       // 0xD1
                    result = "PktActorDestroyNotify";
                    break;
                case 209:       // 0xD2
                    result = "PktPlayerRevive";
                    break;
                case 210:       // 0xD3
                    result = "PktPlayerReviveResult";
                    break;
                case 211:       // 0xD4
                    result = "PktPlayerReviveNotify";
                    break;
                case 212:       // 0xD5
                    result = "PktNpcSpawn";
                    break;
                case 213:       // 0xD6
                    result = "PktNpcSpawnResult";
                    break;
                case 214:       // 0xD7
                    result = "PktNpcCreateNotify";
                    break;
                case 215:       // 0xD8
                    result = "PktCharacterKill";
                    break;
                case 216:       // 0xD9
                    result = "PktCharacterKillResult";
                    break;
                case 217:       // 0xDA
                    result = "PktNpcAllKill";
                    break;
                case 218:       // 0xDB
                    result = "PktNpcAllKillResult";
                    break;
                case 219:       // 0xDC
                    result = "PktCharacterLevelUpNotify";
                    break;
                case 220:       // 0xDD
                    result = "PktCharacterMasteryLevelUpNotify";
                    break;
                case 221:       // 0xDE
                    result = "PktPlayerNameChange";
                    break;
                case 222:       // 0xDF
                    result = "PktPlayerNameChangeResult";
                    break;
                case 223:       // 0xE0
                    result = "PktCharacterStatChangeNotify";
                    break;
                case 224:       // 0xE1
                    result = "PktActorStateChange";
                    break;
                case 225:       // 0xE2
                    result = "PktActorStateChangeResult";
                    break;
                case 226:       // 0xE3
                    result = "PktActorStateChangeNotify";
                    break;
                case 227:       // 0xE4
                    result = "PktActorTeamChangeNotify";
                    break;
                case 228:       // 0xE5
                    result = "PktPlayerClassUpgrade";
                    break;
                case 229:       // 0xE6
                    result = "PktPlayerClassUpgradeResult";
                    break;
                case 230:       // 0xE7
                    result = "PktPlayerSocialActionInput";
                    break;
                case 231:       // 0xE8
                    result = "PktPlayerSocialActionInputResult";
                    break;
                case 232:       // 0xE9
                    result = "PktPlayerSocialActionNotify";
                    break;
                case 233:       // 0xEA
                    result = "PktPlayerSubClassListRead";
                    break;
                case 234:       // 0xEB
                    result = "PktPlayerSubClassListReadResult";
                    break;
                case 235:       // 0xEC
                    result = "PktPlayerClassChange";
                    break;
                case 236:       // 0xED
                    result = "PktPlayerClassChangeResult";
                    break;
                case 237:       // 0xEE
                    result = "PktGadgetCreateNotify";
                    break;
                case 238:       // 0xEF
                    result = "PktGadgetControlStart";
                    break;
                case 239:       // 0xF0
                    result = "PktGadgetControlStartResult";
                    break;
                case 240:       // 0xF1
                    result = "PktGadgetControlStartNotify";
                    break;
                case 241:       // 0xF2
                    result = "PktGadgetControl";
                    break;
                case 242:       // 0xF3
                    result = "PktGadgetControlResult";
                    break;
                case 243:       // 0xF4
                    result = "PktGadgetControlNotify";
                    break;
                case 244:       // 0xF5
                    result = "PktGadgetControlCancel";
                    break;
                case 245:       // 0xF6
                    result = "PktGadgetControlCancelResult";
                    break;
                case 246:       // 0xF7
                    result = "PktGadgetControlCancelNotify";
                    break;
                case 247:       // 0xF8
                    result = "PktGadgetActiveNotify";
                    break;
                case 248:       // 0xF9
                    result = "PktReconnectGadgetControlNotify";
                    break;
                case 249:       // 0xFA
                    result = "PktPlayerInfoRead";
                    break;
                case 250:       // 0xFB
                    result = "PktPlayerInfoReadResult";
                    break;
                case 251:       // 0xFC
                    result = "PktNpcSightShowNotify";
                    break;
                case 252:       // 0xFD
                    result = "PktPlayerStatDetailInfoRead";
                    break;
                case 253:       // 0xFE
                    result = "PktPlayerStatDetailInfoReadResult";
                    break;
                case 254:       // 0xFF
                    result = "PktPlayerGuildInfoRead";
                    break;
                case 255:       // 0x100
                    result = "PktPlayerGuildInfoReadResult";
                    break;
                case 256:       // 0x101
                    result = "PktEliminationInsert";
                    break;
                case 257:       // 0x102
                    result = "PktEliminationInsertResult";
                    break;
                case 258:       // 0x103
                    result = "PktEliminationGet";
                    break;
                case 259:       // 0x104
                    result = "PktEliminationGetResult";
                    break;
                case 260:       // 0x105
                    result = "PktEliminationDel";
                    break;
                case 261:       // 0x106
                    result = "PktEliminationDelResult";
                    break;
                case 262:       // 0x107
                    result = "PktContentUnlockListRead";
                    break;
                case 263:       // 0x108
                    result = "PktContentUnlockListReadResult";
                    break;
                case 264:       // 0x109
                    result = "PktContentUnlockRequest";
                    break;
                case 265:       // 0x10A
                    result = "PktContentUnlockRequestResult";
                    break;
                case 266:       // 0x10B
                    result = "PktMapAlarm";
                    break;
                case 267:       // 0x10C
                    result = "PktMapAlarmResult";
                    break;
                case 268:       // 0x10D
                    result = "PktMapAlarmNotify";
                    break;
                case 269:       // 0x10E
                    result = "PktPlayerBadgeNotify";
                    break;
                case 270:       // 0x10F
                    result = "PktBattleStartNotify";
                    break;
                case 271:       // 0x110
                    result = "PktBattleEndNotify";
                    break;
                case 272:       // 0x111
                    result = "PktTargetActorChange";
                    break;
                case 273:       // 0x112
                    result = "PktTargetActorChangeResult";
                    break;
                case 274:       // 0x113
                    result = "PktNotify";
                    break;
                case 275:       // 0x114
                    result = "PktLevelUpGift";
                    break;
                case 276:       // 0x115
                    result = "PktLevelUpGiftResult";
                    break;
                case 277:       // 0x116
                    result = "PktUIOpenClose";
                    break;
                case 278:       // 0x117
                    result = "PktUIOpenCloseResult";
                    break;
                case 279:       // 0x118
                    result = "PktBossMonsterKillNotify";
                    break;
                case 280:       // 0x119
                    result = "PktPlayerGuildDungeonSupportListRead";
                    break;
                case 281:       // 0x11A
                    result = "PktPlayerGuildDungeonSupportListReadResult";
                    break;
                case 282:       // 0x11B
                    result = "PktFieldBossExistNotify";
                    break;
                case 283:       // 0x11C
                    result = "PktFieldBossKillNotify";
                    break;
                case 284:       // 0x11D
                    result = "PktFieldBossItemLootNotify";
                    break;
                case 285:       // 0x11E
                    result = "PktExpDisplayNotify";
                    break;
                case 286:       // 0x11F
                    result = "PktPlayerSelfIntroChange";
                    break;
                case 287:       // 0x120
                    result = "PktPlayerSelfIntroChangeResult";
                    break;
                case 288:       // 0x121
                    result = "PktBossNpcCombatStartTimeNotify";
                    break;
                case 289:       // 0x122
                    result = "PktNpcTargetUpdateNotify";
                    break;
                case 290:       // 0x123
                    result = "PktPlayerCinematicAction";
                    break;
                case 291:       // 0x124
                    result = "PktPlayerCinematicActionResult";
                    break;
                case 292:       // 0x125
                    result = "PktPlayerCinematicActionNotify";
                    break;
                case 300:       // 0x12D
                    result = "PktAchievementListRead";
                    break;
                case 301:       // 0x12E
                    result = "PktAchievementListReadResult";
                    break;
                case 302:       // 0x12F
                    result = "PktPeriodAchievementListRead";
                    break;
                case 303:       // 0x130
                    result = "PktPeriodAchievementListReadResult";
                    break;
                case 304:       // 0x131
                    result = "PktAchievementCompletedNotify";
                    break;
                case 305:       // 0x132
                    result = "PktAchievementRewardGet";
                    break;
                case 306:       // 0x133
                    result = "PktAchievementRewardGetResult";
                    break;
                case 307:       // 0x134
                    result = "PktPeriodAchievementRewardGet";
                    break;
                case 308:       // 0x135
                    result = "PktPeriodAchievementRewardGetResult";
                    break;
                case 309:       // 0x136
                    result = "PktAchievementLevelRewardGet";
                    break;
                case 310:       // 0x137
                    result = "PktAchievementLevelRewardGetResult";
                    break;
                case 311:       // 0x138
                    result = "PktHeroicLevelUpNotify";
                    break;
                case 312:       // 0x139
                    result = "PktLeaderboardScoreUpdatedNotify";
                    break;
                case 313:       // 0x13A
                    result = "PktAchievementCompleteListRead";
                    break;
                case 314:       // 0x13B
                    result = "PktAchievementCompleteListReadResult";
                    break;
                case 350:       // 0x15F
                    result = "PktDailyActivityListRead";
                    break;
                case 351:       // 0x160
                    result = "PktDailyActivityListReadResult";
                    break;
                case 352:       // 0x161
                    result = "PktDailyActivityCompletedNotify";
                    break;
                case 353:       // 0x162
                    result = "PktDailyActivityRewardGet";
                    break;
                case 354:       // 0x163
                    result = "PktDailyActivityRewardGetResult";
                    break;
                case 355:       // 0x164
                    result = "PktDailyActivityPointRewardGet";
                    break;
                case 356:       // 0x165
                    result = "PktDailyActivityPointRewardGetResult";
                    break;
                case 400:       // 0x191
                    result = "PktRuneInfoRead";
                    break;
                case 401:       // 0x192
                    result = "PktRuneInfoReadResult";
                    break;
                case 402:       // 0x193
                    result = "PktRuneLevelUp";
                    break;
                case 403:       // 0x194
                    result = "PktRuneLevelUpResult";
                    break;
                case 450:       // 0x1C3
                    result = "PktMonsterBookListRead";
                    break;
                case 451:       // 0x1C4
                    result = "PktMonsterBookListReadResult";
                    break;
                case 452:       // 0x1C5
                    result = "PktMonsterCoreUse";
                    break;
                case 453:       // 0x1C6
                    result = "PktMonsterCoreUseResult";
                    break;
                case 454:       // 0x1C7
                    result = "PktMonsterCoreUseAll";
                    break;
                case 455:       // 0x1C8
                    result = "PktMonsterCoreUseAllResult";
                    break;
                case 456:       // 0x1C9
                    result = "PktMonsterBookGroupRewardGet";
                    break;
                case 457:       // 0x1CA
                    result = "PktMonsterBookGroupRewardGetResult";
                    break;
                case 458:       // 0x1CB
                    result = "PktMonsterCoreDecompose";
                    break;
                case 459:       // 0x1CC
                    result = "PktMonsterCoreDecomposeResult";
                    break;
                case 460:       // 0x1CD
                    result = "PktMonsterCoreShopList";
                    break;
                case 461:       // 0x1CE
                    result = "PktMonsterCoreShopListResult";
                    break;
                case 462:       // 0x1CF
                    result = "PktMonsterCoreShopBuy";
                    break;
                case 463:       // 0x1D0
                    result = "PktMonsterCoreShopBuyResult";
                    break;
                case 464:       // 0x1D1
                    result = "PktMonsterCoreShopRefresh";
                    break;
                case 465:       // 0x1D2
                    result = "PktMonsterCoreShopRefreshResult";
                    break;
                case 500:       // 0x1F5
                    result = "PktRestRewardGet";
                    break;
                case 501:       // 0x1F6
                    result = "PktRestRewardGetResult";
                    break;
                case 502:       // 0x1F7
                    result = "PktRestRewardChangeNotify";
                    break;
                case 550:       // 0x227
                    result = "PktAttendanceRead";
                    break;
                case 551:       // 0x228
                    result = "PktAttendanceReadResult";
                    break;
                case 552:       // 0x229
                    result = "PktAttendanceAttend";
                    break;
                case 553:       // 0x22A
                    result = "PktAttendanceAttendResult";
                    break;
                case 554:       // 0x22B
                    result = "PktAttendanceDailyGet";
                    break;
                case 555:       // 0x22C
                    result = "PktAttendanceDailyGetResult";
                    break;
                case 556:       // 0x22D
                    result = "PktAttendanceWeeklyGet";
                    break;
                case 557:       // 0x22E
                    result = "PktAttendanceWeeklyGetResult";
                    break;
                case 600:       // 0x259
                    result = "PktSkillCastingStart";
                    break;
                case 601:       // 0x25A
                    result = "PktSkillCastingStartResult";
                    break;
                case 602:       // 0x25B
                    result = "PktSkillCastingStartNotify";
                    break;
                case 603:       // 0x25C
                    result = "PktSkillStart";
                    break;
                case 604:       // 0x25D
                    result = "PktSkillStartResult";
                    break;
                case 605:       // 0x25E
                    result = "PktSkillStartNotify";
                    break;
                case 606:       // 0x25F
                    result = "PktSkillRotate";
                    break;
                case 607:       // 0x260
                    result = "PktSkillRotateResult";
                    break;
                case 608:       // 0x261
                    result = "PktSkillRotateNotify";
                    break;
                case 609:       // 0x262
                    result = "PktSkillEffectFire";
                    break;
                case 610:       // 0x263
                    result = "PktSkillEffectFireResult";
                    break;
                case 611:       // 0x264
                    result = "PktSkillHitNotify";
                    break;
                case 612:       // 0x265
                    result = "PktSkillMissNotify";
                    break;
                case 613:       // 0x266
                    result = "PktSkillCoolTimeResetNotify";
                    break;
                case 614:       // 0x267
                    result = "PktProjectileCreateNotify";
                    break;
                case 615:       // 0x268
                    result = "PktProjectileMoveNotify";
                    break;
                case 616:       // 0x269
                    result = "PktProjectileHit";
                    break;
                case 617:       // 0x26A
                    result = "PktProjectileHitResult";
                    break;
                case 618:       // 0x26B
                    result = "PktProjectileDestroyNotify";
                    break;
                case 619:       // 0x26C
                    result = "PktGroundObjectCreateNotify";
                    break;
                case 620:       // 0x26D
                    result = "PktGroundObjectDestroyNotify";
                    break;
                case 621:       // 0x26E
                    result = "PktBuffAddNotify";
                    break;
                case 622:       // 0x26F
                    result = "PktBuffRemoveNotify";
                    break;
                case 623:       // 0x270
                    result = "PktBuffRemove";
                    break;
                case 624:       // 0x271
                    result = "PktBuffRemoveResult";
                    break;
                case 625:       // 0x272
                    result = "PktSkillListRead";
                    break;
                case 626:       // 0x273
                    result = "PktSkillListReadResult";
                    break;
                case 627:       // 0x274
                    result = "PktSkillUpgrade";
                    break;
                case 628:       // 0x275
                    result = "PktSkillUpgradeResult";
                    break;
                case 629:       // 0x276
                    result = "PktSkillDeckEquip";
                    break;
                case 630:       // 0x277
                    result = "PktSkillDeckEquipResult";
                    break;
                case 631:       // 0x278
                    result = "PktSkillBookUse";
                    break;
                case 632:       // 0x279
                    result = "PktSkillBookUseResult";
                    break;
                case 633:       // 0x27A
                    result = "PktSkillAcquireNotify";
                    break;
                case 634:       // 0x27B
                    result = "PktSoulShotEnableChange";
                    break;
                case 635:       // 0x27C
                    result = "PktSoulShotEnableChangeResult";
                    break;
                case 636:       // 0x27D
                    result = "PktSoulShotEnableChangeNotify";
                    break;
                case 637:       // 0x27E
                    result = "PktSoulShotItemDeleteNotify";
                    break;
                case 638:       // 0x27F
                    result = "PktSkillCoolTimeNotify";
                    break;
                case 639:       // 0x280
                    result = "PktSkillAutoRegistrationChange";
                    break;
                case 640:       // 0x281
                    result = "PktSkillAutoRegistrationChangeResult";
                    break;
                case 641:       // 0x282
                    result = "PktSkillAutoUseDeckChange";
                    break;
                case 642:       // 0x283
                    result = "PktSkillAutoUseDeckChangeResult";
                    break;
                case 643:       // 0x284
                    result = "PktSummonNpcOrder";
                    break;
                case 644:       // 0x285
                    result = "PktSummonNpcOrderResult";
                    break;
                case 645:       // 0x286
                    result = "PktBuffRefreshNotify";
                    break;
                case 646:       // 0x287
                    result = "PktSummonNpcStateNotify";
                    break;
                case 750:       // 0x2EF
                    result = "PktChatChannelChange";
                    break;
                case 751:       // 0x2F0
                    result = "PktChatChannelChangeResult";
                    break;
                case 752:       // 0x2F1
                    result = "PktChatChannelChangeNotify";
                    break;
                case 753:       // 0x2F2
                    result = "PktChatChannelListRead";
                    break;
                case 754:       // 0x2F3
                    result = "PktChatChannelListReadResult";
                    break;
                case 755:       // 0x2F4
                    result = "PktChatChannelWrite";
                    break;
                case 756:       // 0x2F5
                    result = "PktChatChannelWriteResult";
                    break;
                case 757:       // 0x2F6
                    result = "PktChatFriendRoomListRead";
                    break;
                case 758:       // 0x2F7
                    result = "PktChatFriendRoomListReadResult";
                    break;
                case 759:       // 0x2F8
                    result = "PktChatFriendRoomGet";
                    break;
                case 760:       // 0x2F9
                    result = "PktChatFriendRoomGetResult";
                    break;
                case 761:       // 0x2FA
                    result = "PktChatFriendRoomCreateNotify";
                    break;
                case 762:       // 0x2FB
                    result = "PktChatFriendRoomLeave";
                    break;
                case 763:       // 0x2FC
                    result = "PktChatFriendRoomLeaveResult";
                    break;
                case 764:       // 0x2FD
                    result = "PktChatFriendRoomLeaveNotify";
                    break;
                case 765:       // 0x2FE
                    result = "PktChatFriendListRead";
                    break;
                case 766:       // 0x2FF
                    result = "PktChatFriendListReadResult";
                    break;
                case 767:       // 0x300
                    result = "PktChatFriendWrite";
                    break;
                case 768:       // 0x301
                    result = "PktChatFriendWriteResult";
                    break;
                case 769:       // 0x302
                    result = "PktChatFriendWriteNotify";
                    break;
                case 770:       // 0x303
                    result = "PktChatFriendMessageRead";
                    break;
                case 771:       // 0x304
                    result = "PktChatFriendMessageReadResult";
                    break;
                case 772:       // 0x305
                    result = "PktChatFriendMessageReadNotify";
                    break;
                case 773:       // 0x306
                    result = "PktChatGuildListRead";
                    break;
                case 774:       // 0x307
                    result = "PktChatGuildListReadResult";
                    break;
                case 775:       // 0x308
                    result = "PktChatGuildWrite";
                    break;
                case 776:       // 0x309
                    result = "PktChatGuildWriteResult";
                    break;
                case 777:       // 0x30A
                    result = "PktChatGuildWriteNotify";
                    break;
                case 778:       // 0x30B
                    result = "PktChatGuildMessageRead";
                    break;
                case 779:       // 0x30C
                    result = "PktChatGuildMessageReadResult";
                    break;
                case 780:       // 0x30D
                    result = "PktChatSimpleRead";
                    break;
                case 781:       // 0x30E
                    result = "PktChatSimpleReadResult";
                    break;
                case 782:       // 0x30F
                    result = "PktChatWorldWrite";
                    break;
                case 783:       // 0x310
                    result = "PktChatWorldWriteResult";
                    break;
                case 784:       // 0x311
                    result = "PktChatWorldWriteNotify";
                    break;
                case 785:       // 0x312
                    result = "PktChatPartyWrite";
                    break;
                case 786:       // 0x313
                    result = "PktChatPartyWriteResult";
                    break;
                case 787:       // 0x314
                    result = "PktChatPartyWriteNotify";
                    break;
                case 788:       // 0x315
                    result = "PktChatItemLootNotify";
                    break;
                case 789:       // 0x316
                    result = "PktSystemMessageShowNotify";
                    break;
                case 790:       // 0x317
                    result = "PktChatAddInfoRead";
                    break;
                case 791:       // 0x318
                    result = "PktChatAddInfoReadResult";
                    break;
                case 792:       // 0x319
                    result = "PktChatPromoListRead";
                    break;
                case 793:       // 0x31A
                    result = "PktChatPromoListReadResult";
                    break;
                case 794:       // 0x31B
                    result = "PktChatPromoWrite";
                    break;
                case 795:       // 0x31C
                    result = "PktChatPromoWriteResult";
                    break;
                case 796:       // 0x31D
                    result = "PktChatBlockListRead";
                    break;
                case 797:       // 0x31E
                    result = "PktChatBlockListReadResult";
                    break;
                case 798:       // 0x31F
                    result = "PktChatBlockInsert";
                    break;
                case 799:       // 0x320
                    result = "PktChatBlockInsertResult";
                    break;
                case 800:       // 0x321
                    result = "PktChatBlockDelete";
                    break;
                case 801:       // 0x322
                    result = "PktChatBlockDeleteResult";
                    break;
                case 850:       // 0x353
                    result = "PktBagListRead";
                    break;
                case 851:       // 0x354
                    result = "PktBagListReadResult";
                    break;
                case 852:       // 0x355
                    result = "PktEquipmentListRead";
                    break;
                case 853:       // 0x356
                    result = "PktEquipmentListReadResult";
                    break;
                case 854:       // 0x357
                    result = "PktItemUpdateNotify";
                    break;
                case 855:       // 0x358
                    result = "PktItemEquip";
                    break;
                case 856:       // 0x359
                    result = "PktItemEquipResult";
                    break;
                case 857:       // 0x35A
                    result = "PktItemEquipNotify";
                    break;
                case 858:       // 0x35B
                    result = "PktItemUnequip";
                    break;
                case 859:       // 0x35C
                    result = "PktItemUnequipResult";
                    break;
                case 860:       // 0x35D
                    result = "PktItemUnequipAll";
                    break;
                case 861:       // 0x35E
                    result = "PktItemUnequipAllResult";
                    break;
                case 862:       // 0x35F
                    result = "PktItemUnequipNotify";
                    break;
                case 863:       // 0x360
                    result = "PktItemLike";
                    break;
                case 864:       // 0x361
                    result = "PktItemLikeResult";
                    break;
                case 865:       // 0x362
                    result = "PktItemSell";
                    break;
                case 866:       // 0x363
                    result = "PktItemSellResult";
                    break;
                case 867:       // 0x364
                    result = "PktItemDecompose";
                    break;
                case 868:       // 0x365
                    result = "PktItemDecomposeResult";
                    break;
                case 869:       // 0x366
                    result = "PktItemLevelUp";
                    break;
                case 870:       // 0x367
                    result = "PktItemLevelUpResult";
                    break;
                case 871:       // 0x368
                    result = "PktItemLevelUpInSocket";
                    break;
                case 872:       // 0x369
                    result = "PktItemLevelUpInSocketResult";
                    break;
                case 873:       // 0x36A
                    result = "PktItemLimitBreak";
                    break;
                case 874:       // 0x36B
                    result = "PktItemLimitBreakResult";
                    break;
                case 875:       // 0x36C
                    result = "PktItemEnchant";
                    break;
                case 876:       // 0x36D
                    result = "PktItemEnchantResult";
                    break;
                case 877:       // 0x36E
                    result = "PktEquipmentItemChangeNotify";
                    break;
                case 878:       // 0x36F
                    result = "PktItemUpgrade";
                    break;
                case 879:       // 0x370
                    result = "PktItemUpgradeResult";
                    break;
                case 880:       // 0x371
                    result = "PktItemUpgradeInSocket";
                    break;
                case 881:       // 0x372
                    result = "PktItemUpgradeInSocketResult";
                    break;
                case 882:       // 0x373
                    result = "PktItemCompose";
                    break;
                case 883:       // 0x374
                    result = "PktItemComposeResult";
                    break;
                case 884:       // 0x375
                    result = "PktItemOptionChange";
                    break;
                case 885:       // 0x376
                    result = "PktItemOptionChangeResult";
                    break;
                case 886:       // 0x377
                    result = "PktItemAbilityUpgrade";
                    break;
                case 887:       // 0x378
                    result = "PktItemAbilityUpgradeResult";
                    break;
                case 888:       // 0x379
                    result = "PktItemUseNotify";
                    break;
                case 889:       // 0x37A
                    result = "PktItemUse";
                    break;
                case 890:       // 0x37B
                    result = "PktItemUseResult";
                    break;
                case 891:       // 0x37C
                    result = "PktItemCoolTimeResetNotyfy";
                    break;
                case 892:       // 0x37D
                    result = "PktSoulCrystalEquip";
                    break;
                case 893:       // 0x37E
                    result = "PktSoulCrystalEquipResult";
                    break;
                case 894:       // 0x37F
                    result = "PktSoulCrystalExtract";
                    break;
                case 895:       // 0x380
                    result = "PktSoulCrystalExtractResult";
                    break;
                case 896:       // 0x381
                    result = "PktEquipedSoulCrystalSell";
                    break;
                case 897:       // 0x382
                    result = "PktEquipedSoulCrystalSellResult";
                    break;
                case 898:       // 0x383
                    result = "PktSoulShotCraft";
                    break;
                case 899:       // 0x384
                    result = "PktSoulShotCraftResult";
                    break;
                case 900:       // 0x385
                    result = "PktItemCraft";
                    break;
                case 901:       // 0x386
                    result = "PktItemCraftResult";
                    break;
                case 902:       // 0x387
                    result = "PktItemLootNotify";
                    break;
                case 903:       // 0x388
                    result = "PktBagExpand";
                    break;
                case 904:       // 0x389
                    result = "PktBagExpandResult";
                    break;
                case 905:       // 0x38A
                    result = "PktBagExpandNotify";
                    break;
                case 906:       // 0x38B
                    result = "PktWarehouseListRead";
                    break;
                case 907:       // 0x38C
                    result = "PktWarehouseListReadResult";
                    break;
                case 908:       // 0x38D
                    result = "PktItemMoveToWarehouse";
                    break;
                case 909:       // 0x38E
                    result = "PktItemMoveToWarehouseResult";
                    break;
                case 910:       // 0x38F
                    result = "PktItemMoveToBag";
                    break;
                case 911:       // 0x390
                    result = "PktItemMoveToBagResult";
                    break;
                case 912:       // 0x391
                    result = "PktWarehouseExpand";
                    break;
                case 913:       // 0x392
                    result = "PktWarehouseExpandResult";
                    break;
                case 914:       // 0x393
                    result = "PktEquipmentDeckChanageNotify";
                    break;
                case 915:       // 0x394
                    result = "PktActiveEquipmentDeckRead";
                    break;
                case 916:       // 0x395
                    result = "PktActiveEquipmentDeckReadResult";
                    break;
                case 917:       // 0x396
                    result = "PktElixirInfoRead";
                    break;
                case 918:       // 0x397
                    result = "PktElixirInfoReadResult";
                    break;
                case 919:       // 0x398
                    result = "PktElixirChangeNotify";
                    break;
                case 920:       // 0x399
                    result = "PktSoulCrystalAutoExtract";
                    break;
                case 921:       // 0x39A
                    result = "PktSoulCrystalAutoExtractResult";
                    break;
                case 922:       // 0x39B
                    result = "PktSummonGemUse";
                    break;
                case 923:       // 0x39C
                    result = "PktSummonGemUseResult";
                    break;
                case 924:       // 0x39D
                    result = "PktEquipmentCraft";
                    break;
                case 925:       // 0x39E
                    result = "PktEquipmentCraftResult";
                    break;
                case 926:       // 0x39F
                    result = "PktEquipmentCraftStepComplete";
                    break;
                case 927:       // 0x3A0
                    result = "PktEquipmentCraftStepCompleteResult";
                    break;
                case 928:       // 0x3A1
                    result = "PktItemBoxListRead";
                    break;
                case 929:       // 0x3A2
                    result = "PktItemBoxListReadResult";
                    break;
                case 930:       // 0x3A3
                    result = "PktItemCraftInfoRead";
                    break;
                case 931:       // 0x3A4
                    result = "PktItemCraftInfoReadResult";
                    break;
                case 932:       // 0x3A5
                    result = "PktItemDisassemble";
                    break;
                case 933:       // 0x3A6
                    result = "PktItemDisassembleResult";
                    break;
                case 934:       // 0x3A7
                    result = "PktItemUseNicknameChange";
                    break;
                case 935:       // 0x3A8
                    result = "PktItemUseNicknameChangeResult";
                    break;
                case 936:       // 0x3A9
                    result = "PktBattleDeckActivate";
                    break;
                case 937:       // 0x3AA
                    result = "PktBattleDeckActivateResult";
                    break;
                case 938:       // 0x3AB
                    result = "PktItemOptionChangeInSocket";
                    break;
                case 939:       // 0x3AC
                    result = "PktItemOptionChangeInSocketResult";
                    break;
                case 940:       // 0x3AD
                    result = "PktDeletePeriodItemNotify";
                    break;
                case 941:       // 0x3AE
                    result = "PktBeautyChangeNotify";
                    break;
                case 942:       // 0x3AF
                    result = "PktAppearanceNotify";
                    break;
                case 943:       // 0x3B0
                    result = "PktItemDelete";
                    break;
                case 944:       // 0x3B1
                    result = "PktItemDeleteResult";
                    break;
                case 945:       // 0x3B2
                    result = "PktBattleDeckExpand";
                    break;
                case 946:       // 0x3B3
                    result = "PktBattleDeckExpandResult";
                    break;
                case 947:       // 0x3B4
                    result = "PktBattleDeckOverwrite";
                    break;
                case 948:       // 0x3B5
                    result = "PktBattleDeckOverwriteResult";
                    break;
                case 949:       // 0x3B6
                    result = "PktBattleDeckCustomizing";
                    break;
                case 950:       // 0x3B7
                    result = "PktBattleDeckCustomizingResult";
                    break;
                case 951:       // 0x3B8
                    result = "PktLatestEnchantItemListRead";
                    break;
                case 952:       // 0x3B9
                    result = "PktLatestEnchantItemListReadResult";
                    break;
                case 1000:      // 0x3E9
                    result = "PktMailListRead";
                    break;
                case 1001:      // 0x3EA
                    result = "PktMailListReadResult";
                    break;
                case 1002:      // 0x3EB
                    result = "PktMailDelete";
                    break;
                case 1003:      // 0x3EC
                    result = "PktMailDeleteResult";
                    break;
                case 1004:      // 0x3ED
                    result = "PktMailDeleteAll";
                    break;
                case 1005:      // 0x3EE
                    result = "PktMailDeleteAllResult";
                    break;
                case 1006:      // 0x3EF
                    result = "PktMailRewardGet";
                    break;
                case 1007:      // 0x3F0
                    result = "PktMailRewardGetResult";
                    break;
                case 1008:      // 0x3F1
                    result = "PktMailRewardAllGet";
                    break;
                case 1009:      // 0x3F2
                    result = "PktMailRewardAllGetResult";
                    break;
                case 1010:      // 0x3F3
                    result = "PktMailReceiveNotify";
                    break;
                case 1050:      // 0x41B
                    result = "PktQuestStart";
                    break;
                case 1051:      // 0x41C
                    result = "PktQuestStartResult";
                    break;
                case 1052:      // 0x41D
                    result = "PktQuestCancel";
                    break;
                case 1053:      // 0x41E
                    result = "PktQuestCancelResult";
                    break;
                case 1054:      // 0x41F
                    result = "PktQuestRestart";
                    break;
                case 1055:      // 0x420
                    result = "PktQuestRestartResult";
                    break;
                case 1056:      // 0x421
                    result = "PktQuestUpdate";
                    break;
                case 1057:      // 0x422
                    result = "PktQuestUpdateResult";
                    break;
                case 1058:      // 0x423
                    result = "PktQuestUpdateNotify";
                    break;
                case 1059:      // 0x424
                    result = "PktQuestGadgetControl";
                    break;
                case 1060:      // 0x425
                    result = "PktQuestGadgetControlResult";
                    break;
                case 1061:      // 0x426
                    result = "PktQuestGadgetControlNotify";
                    break;
                case 1062:      // 0x427
                    result = "PktQuestFailNotify";
                    break;
                case 1063:      // 0x428
                    result = "PktQuestComplete";
                    break;
                case 1064:      // 0x429
                    result = "PktQuestCompleteResult";
                    break;
                case 1065:      // 0x42A
                    result = "PktQuestRevive";
                    break;
                case 1066:      // 0x42B
                    result = "PktQuestReviveResult";
                    break;
                case 1067:      // 0x42C
                    result = "PktQuestNpcSearch";
                    break;
                case 1068:      // 0x42D
                    result = "PktQuestNpcSearchResult";
                    break;
                case 1069:      // 0x42E
                    result = "PktQuestWaveStartNotify";
                    break;
                case 1070:      // 0x42F
                    result = "PktCastleAndFortressListRead";
                    break;
                case 1071:      // 0x430
                    result = "PktCastleAndFortressListReadResult";
                    break;
                case 1072:      // 0x431
                    result = "PktQuestShareRequestNotify";
                    break;
                case 1073:      // 0x432
                    result = "PktQuestShareAcceptNotify";
                    break;
                case 1074:      // 0x433
                    result = "PktQuestShare";
                    break;
                case 1075:      // 0x434
                    result = "PktQuestShareResult";
                    break;
                case 1076:      // 0x435
                    result = "PktSharedQuestAccept";
                    break;
                case 1077:      // 0x436
                    result = "PktSharedQuestAcceptResult";
                    break;
                case 1078:      // 0x437
                    result = "PktQuestActListRead";
                    break;
                case 1079:      // 0x438
                    result = "PktQuestActListReadResult";
                    break;
                case 1080:      // 0x439
                    result = "PktQuestActCompleteRewardGet";
                    break;
                case 1081:      // 0x43A
                    result = "PktQuestActCompleteRewardGetResult";
                    break;
                case 1082:      // 0x43B
                    result = "PktQuestActChapterCompleteNotify";
                    break;
                case 1083:      // 0x43C
                    result = "PktQuestScrollCompleteCountReset";
                    break;
                case 1084:      // 0x43D
                    result = "PktQuestScrollCompleteCountResetResult";
                    break;
                case 1085:      // 0x43E
                    result = "PktQuestTeleport";
                    break;
                case 1086:      // 0x43F
                    result = "PktQuestTeleportResult";
                    break;
                case 1087:      // 0x440
                    result = "PktQuestSimpleUpdateNotify";
                    break;
                case 1150:      // 0x47F
                    result = "PktPartyInfoRead";
                    break;
                case 1151:      // 0x480
                    result = "PktPartyInfoReadResult";
                    break;
                case 1152:      // 0x481
                    result = "PktPartySearchStart";
                    break;
                case 1153:      // 0x482
                    result = "PktPartySearchStartResult";
                    break;
                case 1154:      // 0x483
                    result = "PktPartySearchNotify";
                    break;
                case 1155:      // 0x484
                    result = "PktPartySearchCancel";
                    break;
                case 1156:      // 0x485
                    result = "PktPartySearchCancelResult";
                    break;
                case 1157:      // 0x486
                    result = "PktPartyMemberSearchStart";
                    break;
                case 1158:      // 0x487
                    result = "PktPartyMemberSearchStartResult";
                    break;
                case 1159:      // 0x488
                    result = "PktPartyMemberSearchCancel";
                    break;
                case 1160:      // 0x489
                    result = "PktPartyMemberSearchCancelResult";
                    break;
                case 1161:      // 0x48A
                    result = "PktPartyInvite";
                    break;
                case 1162:      // 0x48B
                    result = "PktPartyInviteResult";
                    break;
                case 1163:      // 0x48C
                    result = "PktPartyInviteNotify";
                    break;
                case 1164:      // 0x48D
                    result = "PktPartyInviteAccept";
                    break;
                case 1165:      // 0x48E
                    result = "PktPartyInviteAcceptResult";
                    break;
                case 1166:      // 0x48F
                    result = "PktPartyInviteRefuse";
                    break;
                case 1167:      // 0x490
                    result = "PktPartyInviteRefuseResult";
                    break;
                case 1168:      // 0x491
                    result = "PktPartyInviteRefuseNotify";
                    break;
                case 1169:      // 0x492
                    result = "PktPartyJoinRequest";
                    break;
                case 1170:      // 0x493
                    result = "PktPartyJoinRequestResult";
                    break;
                case 1171:      // 0x494
                    result = "PktPartyJoinRequestNotify";
                    break;
                case 1172:      // 0x495
                    result = "PktPartyJoinRequestCancel";
                    break;
                case 1173:      // 0x496
                    result = "PktPartyJoinRequestCancelResult";
                    break;
                case 1174:      // 0x497
                    result = "PktPartyJoinRequestCancelNotify";
                    break;
                case 1175:      // 0x498
                    result = "PktPartyJoinAccept";
                    break;
                case 1176:      // 0x499
                    result = "PktPartyJoinAcceptResult";
                    break;
                case 1177:      // 0x49A
                    result = "PktPartyJoinAcceptNotify";
                    break;
                case 1178:      // 0x49B
                    result = "PktPartyJoinRefuse";
                    break;
                case 1179:      // 0x49C
                    result = "PktPartyJoinRefuseResult";
                    break;
                case 1180:      // 0x49D
                    result = "PktPartyJoinRefuseNotify";
                    break;
                case 1181:      // 0x49E
                    result = "PktPartyCreateNotify";
                    break;
                case 1182:      // 0x49F
                    result = "PktPartyMemberJoinNotify";
                    break;
                case 1183:      // 0x4A0
                    result = "PktPartyExpel";
                    break;
                case 1184:      // 0x4A1
                    result = "PktPartyExpelResult";
                    break;
                case 1185:      // 0x4A2
                    result = "PktPartyExpelNotify";
                    break;
                case 1186:      // 0x4A3
                    result = "PktPartyWithdraw";
                    break;
                case 1187:      // 0x4A4
                    result = "PktPartyWithdrawResult";
                    break;
                case 1188:      // 0x4A5
                    result = "PktPartyWithdrawNotify";
                    break;
                case 1189:      // 0x4A6
                    result = "PktPartyDisband";
                    break;
                case 1190:      // 0x4A7
                    result = "PktPartyDisbandResult";
                    break;
                case 1191:      // 0x4A8
                    result = "PktPartyDisbandNotify";
                    break;
                case 1192:      // 0x4A9
                    result = "PktPartyMasterEntrust";
                    break;
                case 1193:      // 0x4AA
                    result = "PktPartyMasterEntrustResult";
                    break;
                case 1194:      // 0x4AB
                    result = "PktPartyMasterEntrustNotify";
                    break;
                case 1195:      // 0x4AC
                    result = "PktPartyMuster";
                    break;
                case 1196:      // 0x4AD
                    result = "PktPartyMusterResult";
                    break;
                case 1197:      // 0x4AE
                    result = "PktPartyMusterNotify";
                    break;
                case 1198:      // 0x4AF
                    result = "PktPartyMusterAccept";
                    break;
                case 1199:      // 0x4B0
                    result = "PktPartyMusterAcceptResult";
                    break;
                case 1200:      // 0x4B1
                    result = "PktPartyMusterRefuse";
                    break;
                case 1201:      // 0x4B2
                    result = "PktPartyMusterRefuseResult";
                    break;
                case 1202:      // 0x4B3
                    result = "PktPartyMusterRefuseNotify";
                    break;
                case 1203:      // 0x4B4
                    result = "PktPartyMeet";
                    break;
                case 1204:      // 0x4B5
                    result = "PktPartyMeetResult";
                    break;
                case 1205:      // 0x4B6
                    result = "PktPartyCall";
                    break;
                case 1206:      // 0x4B7
                    result = "PktPartyCallResult";
                    break;
                case 1207:      // 0x4B8
                    result = "PktPartyCallNotify";
                    break;
                case 1208:      // 0x4B9
                    result = "PktPartyMemberStatChangeNotify";
                    break;
                case 1209:      // 0x4BA
                    result = "PktPartyMasterWorldMoveNotify";
                    break;
                case 1210:      // 0x4BB
                    result = "PktPartyMemberDisconnectNotify";
                    break;
                case 1211:      // 0x4BC
                    result = "PktPartyMemberReconnectNotify";
                    break;
                case 1212:      // 0x4BD
                    result = "PktPartyNearPartyInfo";
                    break;
                case 1213:      // 0x4BE
                    result = "PktPartyNearPartyInfoResult";
                    break;
                case 1214:      // 0x4BF
                    result = "PktPartyNearPlayerInfo";
                    break;
                case 1215:      // 0x4C0
                    result = "PktPartyNearPlayerInfoResult";
                    break;
                case 1216:      // 0x4C1
                    result = "PktPartyTagSearch";
                    break;
                case 1217:      // 0x4C2
                    result = "PktPartyTagSearchResult";
                    break;
                case 1218:      // 0x4C3
                    result = "PktPartyTagChange";
                    break;
                case 1219:      // 0x4C4
                    result = "PktPartyTagChangeResult";
                    break;
                case 1220:      // 0x4C5
                    result = "PktPartyTempCreate";
                    break;
                case 1221:      // 0x4C6
                    result = "PktPartyTempCreateResult";
                    break;
                case 1222:      // 0x4C7
                    result = "PktPartyTempRegister";
                    break;
                case 1223:      // 0x4C8
                    result = "PktPartyTempRegisterResult";
                    break;
                case 1224:      // 0x4C9
                    result = "PktPartyCreate";
                    break;
                case 1225:      // 0x4CA
                    result = "PktPartyCreateResult";
                    break;
                case 1226:      // 0x4CB
                    result = "PktPartyMemberPosNotify";
                    break;
                case 1227:      // 0x4CC
                    result = "PktPartyAutoEnterList";
                    break;
                case 1228:      // 0x4CD
                    result = "PktPartyAutoEnterListResult";
                    break;
                case 1229:      // 0x4CE
                    result = "PktPartyAutoEnter";
                    break;
                case 1230:      // 0x4CF
                    result = "PktPartyAutoEnterResult";
                    break;
                case 1231:      // 0x4D0
                    result = "PktPartyAutoEnterNotify";
                    break;
                case 1232:      // 0x4D1
                    result = "PktPartyAutoEnterCancel";
                    break;
                case 1233:      // 0x4D2
                    result = "PktPartyAutoEnterCancelResult";
                    break;
                case 1234:      // 0x4D3
                    result = "PktPartyAutoEnterCancelNotify";
                    break;
                case 1235:      // 0x4D4
                    result = "PktPartyAutoEnterStartNotify";
                    break;
                case 1236:      // 0x4D5
                    result = "PktPartyAutoEnterAccept";
                    break;
                case 1237:      // 0x4D6
                    result = "PktPartyAutoEnterAcceptResult";
                    break;
                case 1238:      // 0x4D7
                    result = "PktPartyAutoEnterAcceptNotify";
                    break;
                case 1239:      // 0x4D8
                    result = "PktPartyAutoEnterAcceptTimeOutNotify";
                    break;
                case 1240:      // 0x4D9
                    result = "PktPartyAutoEnterAcceptImpossibleAreaNotify";
                    break;
                case 1241:      // 0x4DA
                    result = "PktPartyDungeonEnter";
                    break;
                case 1242:      // 0x4DB
                    result = "PktPartyDungeonEnterResult";
                    break;
                case 1243:      // 0x4DC
                    result = "PktPartyDungeonEnterStartNotify";
                    break;
                case 1244:      // 0x4DD
                    result = "PktPartyDungeonEnterCancelNotify";
                    break;
                case 1245:      // 0x4DE
                    result = "PktPartyDungeonEnterAccept";
                    break;
                case 1246:      // 0x4DF
                    result = "PktPartyDungeonEnterAcceptResult";
                    break;
                case 1247:      // 0x4E0
                    result = "PktPartyDungeonEnterAcceptNotify";
                    break;
                case 1248:      // 0x4E1
                    result = "PktPartyDungeonEnterNotify";
                    break;
                case 1249:      // 0x4E2
                    result = "PktPartyInfoNotify";
                    break;
                case 1250:      // 0x4E3
                    result = "PktPartyVoiceChatJoinNotify";
                    break;
                case 1251:      // 0x4E4
                    result = "PktPartyVoiceChatJoin";
                    break;
                case 1252:      // 0x4E5
                    result = "PktPartyVoiceChatJoinResult";
                    break;
                case 1253:      // 0x4E6
                    result = "PktPartyVoiceChatExit";
                    break;
                case 1254:      // 0x4E7
                    result = "PktPartyVoiceChatExitResult";
                    break;
                case 1255:      // 0x4E8
                    result = "PktPartyMemberWorldMoveNotify";
                    break;
                case 1256:      // 0x4E9
                    result = "PktPartyNameChange";
                    break;
                case 1257:      // 0x4EA
                    result = "PktPartyNameChangeResult";
                    break;
                case 1258:      // 0x4EB
                    result = "PktPartyNameChangeNotify";
                    break;
                case 1259:      // 0x4EC
                    result = "PktPartyInviteIndicate";
                    break;
                case 1260:      // 0x4ED
                    result = "PktPartyInviteIndicateResult";
                    break;
                case 1261:      // 0x4EE
                    result = "PktPartyEmblemChangeNotify";
                    break;
                case 1262:      // 0x4EF
                    result = "PktPartyDungeonSupportEnter";
                    break;
                case 1263:      // 0x4F0
                    result = "PktPartyDungeonSupportEnterResult";
                    break;
                case 1264:      // 0x4F1
                    result = "PktPartyDungeonHelpRequest";
                    break;
                case 1265:      // 0x4F2
                    result = "PktPartyDungeonHelpRequestResult";
                    break;
                case 1266:      // 0x4F3
                    result = "PktPartyDungeonHelpCancel";
                    break;
                case 1267:      // 0x4F4
                    result = "PktPartyDungeonHelpCancelResult";
                    break;
                case 1268:      // 0x4F5
                    result = "PktPartyDungeonHelpInfo";
                    break;
                case 1269:      // 0x4F6
                    result = "PktPartyDungeonHelpInfoResult";
                    break;
                case 1270:      // 0x4F7
                    result = "PktPartyDungeonHelpList";
                    break;
                case 1271:      // 0x4F8
                    result = "PktPartyDungeonHelpListResult";
                    break;
                case 1272:      // 0x4F9
                    result = "PktPartyDungeonHelpParticipate";
                    break;
                case 1273:      // 0x4FA
                    result = "PktPartyDungeonHelpParticipateResult";
                    break;
                case 1274:      // 0x4FB
                    result = "PktPartyDungeonResultNotify";
                    break;
                case 1275:      // 0x4FC
                    result = "PktPartyMemberBattleDeckChangeNotify";
                    break;
                case 1300:      // 0x515
                    result = "PktFriendListRead";
                    break;
                case 1301:      // 0x516
                    result = "PktFriendListReadResult";
                    break;
                case 1302:      // 0x517
                    result = "PktFriendInviteSendListRead";
                    break;
                case 1303:      // 0x518
                    result = "PktFriendInviteSendListReadResult";
                    break;
                case 1304:      // 0x519
                    result = "PktFriendInviterListRead";
                    break;
                case 1305:      // 0x51A
                    result = "PktFriendInviterListReadResult";
                    break;
                case 1306:      // 0x51B
                    result = "PktFriendInvite";
                    break;
                case 1307:      // 0x51C
                    result = "PktFriendInviteResult";
                    break;
                case 1308:      // 0x51D
                    result = "PktFriendInviteNotify";
                    break;
                case 1309:      // 0x51E
                    result = "PktFriendInviteCancel";
                    break;
                case 1310:      // 0x51F
                    result = "PktFriendInviteCancelResult";
                    break;
                case 1311:      // 0x520
                    result = "PktFriendInviteCancelAll";
                    break;
                case 1312:      // 0x521
                    result = "PktFriendInviteCancelAllResult";
                    break;
                case 1313:      // 0x522
                    result = "PktFriendInviteCancelNotify";
                    break;
                case 1314:      // 0x523
                    result = "PktFriendAccept";
                    break;
                case 1315:      // 0x524
                    result = "PktFriendAcceptResult";
                    break;
                case 1316:      // 0x525
                    result = "PktFriendAcceptNotify";
                    break;
                case 1317:      // 0x526
                    result = "PktFriendRefuse";
                    break;
                case 1318:      // 0x527
                    result = "PktFriendRefuseResult";
                    break;
                case 1319:      // 0x528
                    result = "PktFriendAcceptAll";
                    break;
                case 1320:      // 0x529
                    result = "PktFriendAcceptAllResult";
                    break;
                case 1321:      // 0x52A
                    result = "PktFriendRefuseAll";
                    break;
                case 1322:      // 0x52B
                    result = "PktFriendRefuseAllResult";
                    break;
                case 1323:      // 0x52C
                    result = "PktFriendDelete";
                    break;
                case 1324:      // 0x52D
                    result = "PktFriendDeleteResult";
                    break;
                case 1325:      // 0x52E
                    result = "PktFriendSearch";
                    break;
                case 1326:      // 0x52F
                    result = "PktFriendSearchResult";
                    break;
                case 1327:      // 0x530
                    result = "PktFriendLike";
                    break;
                case 1328:      // 0x531
                    result = "PktFriendLikeResult";
                    break;
                case 1329:      // 0x532
                    result = "PktFriendRecommendationListRead";
                    break;
                case 1330:      // 0x533
                    result = "PktFriendRecommendationListReadResult";
                    break;
                case 1331:      // 0x534
                    result = "PktFriendRecommendationListRefresh";
                    break;
                case 1332:      // 0x535
                    result = "PktFriendRecommendationListRefreshResult";
                    break;
                case 1333:      // 0x536
                    result = "PktFriendRecommendationInviteAll";
                    break;
                case 1334:      // 0x537
                    result = "PktFriendRecommendationInviteAllResult";
                    break;
                case 1335:      // 0x538
                    result = "PktFriendListAutoManager";
                    break;
                case 1336:      // 0x539
                    result = "PktFriendListAutoManagerResult";
                    break;
                case 1337:      // 0x53A
                    result = "PktFriendGreet";
                    break;
                case 1338:      // 0x53B
                    result = "PktFriendGreetResult";
                    break;
                case 1339:      // 0x53C
                    result = "PktFriendGreetAll";
                    break;
                case 1340:      // 0x53D
                    result = "PktFriendGreetAllResult";
                    break;
                case 1341:      // 0x53E
                    result = "PktFriendGreetNotify";
                    break;
                case 1342:      // 0x53F
                    result = "PktFriendGreetReceive";
                    break;
                case 1343:      // 0x540
                    result = "PktFriendGreetReceiveResult";
                    break;
                case 1344:      // 0x541
                    result = "PktFriendGreetReceiveAll";
                    break;
                case 1345:      // 0x542
                    result = "PktFriendGreetReceiveAllResult";
                    break;
                case 1400:      // 0x579
                    result = "PktGuildInfoRead";
                    break;
                case 1401:      // 0x57A
                    result = "PktGuildInfoReadResult";
                    break;
                case 1402:      // 0x57B
                    result = "PktGuildMemberListRead";
                    break;
                case 1403:      // 0x57C
                    result = "PktGuildMemberListReadResult";
                    break;
                case 1404:      // 0x57D
                    result = "PktGuildCreate";
                    break;
                case 1405:      // 0x57E
                    result = "PktGuildCreateResult";
                    break;
                case 1406:      // 0x57F
                    result = "PktGuildCreateCheck";
                    break;
                case 1407:      // 0x580
                    result = "PktGuildCreateCheckResult";
                    break;
                case 1408:      // 0x581
                    result = "PktGuildInvite";
                    break;
                case 1409:      // 0x582
                    result = "PktGuildInviteResult";
                    break;
                case 1410:      // 0x583
                    result = "PktGuildInviteNotify";
                    break;
                case 1411:      // 0x584
                    result = "PktGuildInviteAccept";
                    break;
                case 1412:      // 0x585
                    result = "PktGuildInviteAcceptResult";
                    break;
                case 1413:      // 0x586
                    result = "PktGuildInviteRefuse";
                    break;
                case 1414:      // 0x587
                    result = "PktGuildInviteRefuseResult";
                    break;
                case 1415:      // 0x588
                    result = "PktGuildInviteRefuseNotify";
                    break;
                case 1416:      // 0x589
                    result = "PktGuildJoinRequest";
                    break;
                case 1417:      // 0x58A
                    result = "PktGuildJoinRequestResult";
                    break;
                case 1418:      // 0x58B
                    result = "PktGuildJoinRequestNotify";
                    break;
                case 1419:      // 0x58C
                    result = "PktGuildJoinRequestListRead";
                    break;
                case 1420:      // 0x58D
                    result = "PktGuildJoinRequestListReadResult";
                    break;
                case 1421:      // 0x58E
                    result = "PktGuildReceivedJoinRequestListRead";
                    break;
                case 1422:      // 0x58F
                    result = "PktGuildReceivedJoinRequestListReadResult";
                    break;
                case 1423:      // 0x590
                    result = "PktGuildJoinRequestCancel";
                    break;
                case 1424:      // 0x591
                    result = "PktGuildJoinRequestCancelResult";
                    break;
                case 1425:      // 0x592
                    result = "PktGuildJoinAccept";
                    break;
                case 1426:      // 0x593
                    result = "PktGuildJoinAcceptResult";
                    break;
                case 1427:      // 0x594
                    result = "PktGuildJoinAcceptAll";
                    break;
                case 1428:      // 0x595
                    result = "PktGuildJoinAcceptAllResult";
                    break;
                case 1429:      // 0x596
                    result = "PktGuildJoinAcceptNotify";
                    break;
                case 1430:      // 0x597
                    result = "PktGuildMemberJoinNotify";
                    break;
                case 1431:      // 0x598
                    result = "PktGuildJoinRefuse";
                    break;
                case 1432:      // 0x599
                    result = "PktGuildJoinRefuseResult";
                    break;
                case 1433:      // 0x59A
                    result = "PktGuildJoinRefuseAll";
                    break;
                case 1434:      // 0x59B
                    result = "PktGuildJoinRefuseAllResult";
                    break;
                case 1435:      // 0x59C
                    result = "PktGuildJoinRefuseNotify";
                    break;
                case 1436:      // 0x59D
                    result = "PktGuildExpel";
                    break;
                case 1437:      // 0x59E
                    result = "PktGuildExpelResult";
                    break;
                case 1438:      // 0x59F
                    result = "PktGuildExpelNotify";
                    break;
                case 1439:      // 0x5A0
                    result = "PktGuildWithdraw";
                    break;
                case 1440:      // 0x5A1
                    result = "PktGuildWithdrawResult";
                    break;
                case 1441:      // 0x5A2
                    result = "PktGuildWithdrawNotify";
                    break;
                case 1442:      // 0x5A3
                    result = "PktGuildDisband";
                    break;
                case 1443:      // 0x5A4
                    result = "PktGuildDisbandResult";
                    break;
                case 1444:      // 0x5A5
                    result = "PktGuildDisbandNotify";
                    break;
                case 1445:      // 0x5A6
                    result = "PktGuildMasterEntrust";
                    break;
                case 1446:      // 0x5A7
                    result = "PktGuildMasterEntrustResult";
                    break;
                case 1447:      // 0x5A8
                    result = "PktGuildMasterEntrustNotify";
                    break;
                case 1448:      // 0x5A9
                    result = "PktGuildMemberGradeChange";
                    break;
                case 1449:      // 0x5AA
                    result = "PktGuildMemberGradeChangeResult";
                    break;
                case 1450:      // 0x5AB
                    result = "PktGuildMemberGradeChangeNotify";
                    break;
                case 1451:      // 0x5AC
                    result = "PktGuildIntroductionChange";
                    break;
                case 1452:      // 0x5AD
                    result = "PktGuildIntroductionChangeResult";
                    break;
                case 1453:      // 0x5AE
                    result = "PktGuildNoticeChange";
                    break;
                case 1454:      // 0x5AF
                    result = "PktGuildNoticeChangeResult";
                    break;
                case 1455:      // 0x5B0
                    result = "PktGuildNameChange";
                    break;
                case 1456:      // 0x5B1
                    result = "PktGuildNameChangeResult";
                    break;
                case 1457:      // 0x5B2
                    result = "PktGuildEmblemChange";
                    break;
                case 1458:      // 0x5B3
                    result = "PktGuildEmblemChangeResult";
                    break;
                case 1459:      // 0x5B4
                    result = "PktGuildRecommendationListRead";
                    break;
                case 1460:      // 0x5B5
                    result = "PktGuildRecommendationListReadResult";
                    break;
                case 1461:      // 0x5B6
                    result = "PktGuildRankingListRead";
                    break;
                case 1462:      // 0x5B7
                    result = "PktGuildRankingListReadResult";
                    break;
                case 1463:      // 0x5B8
                    result = "PktGuildRecommendationListRefresh";
                    break;
                case 1464:      // 0x5B9
                    result = "PktGuildRecommendationListRefreshResult";
                    break;
                case 1465:      // 0x5BA
                    result = "PktGuildMemberRecommendationListRead";
                    break;
                case 1466:      // 0x5BB
                    result = "PktGuildMemberRecommendationListReadResult";
                    break;
                case 1467:      // 0x5BC
                    result = "PktGuildDonate";
                    break;
                case 1468:      // 0x5BD
                    result = "PktGuildDonateResult";
                    break;
                case 1469:      // 0x5BE
                    result = "PktGuildLevelUpNotify";
                    break;
                case 1470:      // 0x5BF
                    result = "PktGuildImpeach";
                    break;
                case 1471:      // 0x5C0
                    result = "PktGuildImpeachResult";
                    break;
                case 1472:      // 0x5C1
                    result = "PktGuildImpeachNotify";
                    break;
                case 1473:      // 0x5C2
                    result = "PktGuildAttend";
                    break;
                case 1474:      // 0x5C3
                    result = "PktGuildAttendResult";
                    break;
                case 1475:      // 0x5C4
                    result = "PktGuildAttendRewardGet";
                    break;
                case 1476:      // 0x5C5
                    result = "PktGuildAttendRewardGetResult";
                    break;
                case 1477:      // 0x5C6
                    result = "PktGuildGreet";
                    break;
                case 1478:      // 0x5C7
                    result = "PktGuildGreetResult";
                    break;
                case 1479:      // 0x5C8
                    result = "PktGuildGreetAll";
                    break;
                case 1480:      // 0x5C9
                    result = "PktGuildGreetAllResult";
                    break;
                case 1481:      // 0x5CA
                    result = "PktGuildGreetingReceivedNotify";
                    break;
                case 1482:      // 0x5CB
                    result = "PktGuildGreetReceive";
                    break;
                case 1483:      // 0x5CC
                    result = "PktGuildGreetReceiveResult";
                    break;
                case 1484:      // 0x5CD
                    result = "PktGuildGreetReceiveAll";
                    break;
                case 1485:      // 0x5CE
                    result = "PktGuildGreetReceiveAllResult";
                    break;
                case 1486:      // 0x5CF
                    result = "PktGuildRecordListRead";
                    break;
                case 1487:      // 0x5D0
                    result = "PktGuildRecordListReadResult";
                    break;
                case 1488:      // 0x5D1
                    result = "PktGuildWarehouseListRead";
                    break;
                case 1489:      // 0x5D2
                    result = "PktGuildWarehouseListReadResult";
                    break;
                case 1490:      // 0x5D3
                    result = "PktGuildWarehouseGrant";
                    break;
                case 1491:      // 0x5D4
                    result = "PktGuildWarehouseGrantResult";
                    break;
                case 1492:      // 0x5D5
                    result = "PktGuildWarehouseGrantAllMember";
                    break;
                case 1493:      // 0x5D6
                    result = "PktGuildWarehouseGrantAllMemberResult";
                    break;
                case 1494:      // 0x5D7
                    result = "PktGuildBuffUpgrade";
                    break;
                case 1495:      // 0x5D8
                    result = "PktGuildBuffUpgradeResult";
                    break;
                case 1496:      // 0x5D9
                    result = "PktGuildBuffListRead";
                    break;
                case 1497:      // 0x5DA
                    result = "PktGuildBuffListReadResult";
                    break;
                case 1498:      // 0x5DB
                    result = "PktGuildBuffBuy";
                    break;
                case 1499:      // 0x5DC
                    result = "PktGuildBuffBuyResult";
                    break;
                case 1500:      // 0x5DD
                    result = "PktGuildMarketListRead";
                    break;
                case 1501:      // 0x5DE
                    result = "PktGuildMarketListReadResult";
                    break;
                case 1502:      // 0x5DF
                    result = "PktGuildMarketBuy";
                    break;
                case 1503:      // 0x5E0
                    result = "PktGuildMarketBuyResult";
                    break;
                case 1504:      // 0x5E1
                    result = "PktGuildMarketGiftBuy";
                    break;
                case 1505:      // 0x5E2
                    result = "PktGuildMarketGiftBuyResult";
                    break;
                case 1506:      // 0x5E3
                    result = "PktGuildCastleUpgrade";
                    break;
                case 1507:      // 0x5E4
                    result = "PktGuildCastleUpgradeResult";
                    break;
                case 1508:      // 0x5E5
                    result = "PktGuildSearch";
                    break;
                case 1509:      // 0x5E6
                    result = "PktGuildSearchResult";
                    break;
                case 1510:      // 0x5E7
                    result = "PktGuildAllianceListRead";
                    break;
                case 1511:      // 0x5E8
                    result = "PktGuildAllianceListReadResult";
                    break;
                case 1512:      // 0x5E9
                    result = "PktGuildAllianceInviterListRead";
                    break;
                case 1513:      // 0x5EA
                    result = "PktGuildAllianceInviterListReadResult";
                    break;
                case 1514:      // 0x5EB
                    result = "PktGuildAllianceInvite";
                    break;
                case 1515:      // 0x5EC
                    result = "PktGuildAllianceInviteResult";
                    break;
                case 1516:      // 0x5ED
                    result = "PktGuildAllianceInvitationCancel";
                    break;
                case 1517:      // 0x5EE
                    result = "PktGuildAllianceInvitationCancelResult";
                    break;
                case 1518:      // 0x5EF
                    result = "PktGuildAllianceAccept";
                    break;
                case 1519:      // 0x5F0
                    result = "PktGuildAllianceAcceptResult";
                    break;
                case 1520:      // 0x5F1
                    result = "PktGuildAllianceChangeNotify";
                    break;
                case 1521:      // 0x5F2
                    result = "PktGuildHostilityChangeNotify";
                    break;
                case 1522:      // 0x5F3
                    result = "PktGuildAllianceRefuse";
                    break;
                case 1523:      // 0x5F4
                    result = "PktGuildAllianceRefuseResult";
                    break;
                case 1524:      // 0x5F5
                    result = "PktGuildAllianceRefuseAll";
                    break;
                case 1525:      // 0x5F6
                    result = "PktGuildAllianceRefuseAllResult";
                    break;
                case 1526:      // 0x5F7
                    result = "PktGuildAllianceDelete";
                    break;
                case 1527:      // 0x5F8
                    result = "PktGuildAllianceDeleteResult";
                    break;
                case 1528:      // 0x5F9
                    result = "PktGuildHostilityListRead";
                    break;
                case 1529:      // 0x5FA
                    result = "PktGuildHostilityListReadResult";
                    break;
                case 1530:      // 0x5FB
                    result = "PktGuildHostilityRegister";
                    break;
                case 1531:      // 0x5FC
                    result = "PktGuildHostilityRegisterResult";
                    break;
                case 1532:      // 0x5FD
                    result = "PktGuildHostilityWarDeclare";
                    break;
                case 1533:      // 0x5FE
                    result = "PktGuildHostilityWarDeclareResult";
                    break;
                case 1534:      // 0x5FF
                    result = "PktGuildHostilityUnregister";
                    break;
                case 1535:      // 0x600
                    result = "PktGuildHostilityUnregisterResult";
                    break;
                case 1536:      // 0x601
                    result = "PktGuildHostileWarSurrender";
                    break;
                case 1537:      // 0x602
                    result = "PktGuildHostileWarSurrenderResult";
                    break;
                case 1538:      // 0x603
                    result = "PktGuildHostileWarRecordListRead";
                    break;
                case 1539:      // 0x604
                    result = "PktGuildHostileWarRecordListReadResult";
                    break;
                case 1540:      // 0x605
                    result = "PktGuildAchievementListRead";
                    break;
                case 1541:      // 0x606
                    result = "PktGuildAchievementListReadResult";
                    break;
                case 1542:      // 0x607
                    result = "PktGuildAchievementRewardGet";
                    break;
                case 1543:      // 0x608
                    result = "PktGuildAchievementRewardGetResult";
                    break;
                case 1544:      // 0x609
                    result = "PktGuildJoinRequestOptionChange";
                    break;
                case 1545:      // 0x60A
                    result = "PktGuildJoinRequestOptionChangeResult";
                    break;
                case 1546:      // 0x60B
                    result = "PktGuildInfoReadChangeNotify";
                    break;
                case 1547:      // 0x60C
                    result = "PktGuildBadgeNotify";
                    break;
                case 1548:      // 0x60D
                    result = "PktGuildHostileWarBroadcastNotify";
                    break;
                case 1549:      // 0x60E
                    result = "PktGuildNoticeRead";
                    break;
                case 1550:      // 0x60F
                    result = "PktGuildNoticeReadResult";
                    break;
                case 1551:      // 0x610
                    result = "PktGuildPromotionLimitTimeNotify";
                    break;
                case 1552:      // 0x611
                    result = "PktGuildDungeonEnter";
                    break;
                case 1553:      // 0x612
                    result = "PktGuildDungeonEnterResult";
                    break;
                case 1554:      // 0x613
                    result = "PktGuildDungeonEnterNotify";
                    break;
                case 1555:      // 0x614
                    result = "PktGuildDungeonList";
                    break;
                case 1556:      // 0x615
                    result = "PktGuildDungeonListResult";
                    break;
                case 1557:      // 0x616
                    result = "PktGuildDungeonReset";
                    break;
                case 1558:      // 0x617
                    result = "PktGuildDungeonResetResult";
                    break;
                case 1559:      // 0x618
                    result = "PktGuildDungeonInviteRequest";
                    break;
                case 1560:      // 0x619
                    result = "PktGuildDungeonInviteRequestResult";
                    break;
                case 1561:      // 0x61A
                    result = "PktGuildDungeonInviteRequestNotify";
                    break;
                case 1562:      // 0x61B
                    result = "PktGuildDungeonInviteAccept";
                    break;
                case 1563:      // 0x61C
                    result = "PktGuildDungeonInviteAcceptResult";
                    break;
                case 1564:      // 0x61D
                    result = "PktGuildDungeonDamageNotify";
                    break;
                case 1565:      // 0x61E
                    result = "PktGuildDungeonResultNotify";
                    break;
                case 1566:      // 0x61F
                    result = "PktGuildDungeonKickoutNotify";
                    break;
                case 1567:      // 0x620
                    result = "PktGuildMasterBuffNotify";
                    break;
                case 1568:      // 0x621
                    result = "PktGuildNameChangeNotify";
                    break;
                case 1569:      // 0x622
                    result = "PktGuildMemberKillNotify";
                    break;
                case 1570:      // 0x623
                    result = "PktGuildInfoNotify";
                    break;
                case 1571:      // 0x624
                    result = "PktGuildAgitBuy";
                    break;
                case 1572:      // 0x625
                    result = "PktGuildAgitBuyResult";
                    break;
                case 1573:      // 0x626
                    result = "PktGuildAgitUpgrade";
                    break;
                case 1574:      // 0x627
                    result = "PktGuildAgitUpgradeResult";
                    break;
                case 1575:      // 0x628
                    result = "PktGuildAgitCrystalUpgrade";
                    break;
                case 1576:      // 0x629
                    result = "PktGuildAgitCrystalUpgradeResult";
                    break;
                case 1577:      // 0x62A
                    result = "PktGuildAgitInfo";
                    break;
                case 1578:      // 0x62B
                    result = "PktGuildAgitInfoResult";
                    break;
                case 1579:      // 0x62C
                    result = "PktGuildAgitOpen";
                    break;
                case 1580:      // 0x62D
                    result = "PktGuildAgitOpenResult";
                    break;
                case 1581:      // 0x62E
                    result = "PktGuildAgitExpel";
                    break;
                case 1582:      // 0x62F
                    result = "PktGuildAgitExpelResult";
                    break;
                case 1583:      // 0x630
                    result = "PktGuildAgitExpelNotify";
                    break;
                case 1584:      // 0x631
                    result = "PktGuildAgitEnter";
                    break;
                case 1585:      // 0x632
                    result = "PktGuildAgitEnterResult";
                    break;
                case 1586:      // 0x633
                    result = "PktGuildAgitLeave";
                    break;
                case 1587:      // 0x634
                    result = "PktGuildAgitLeaveResult";
                    break;
                case 1588:      // 0x635
                    result = "PktGuildAgitQuestList";
                    break;
                case 1589:      // 0x636
                    result = "PktGuildAgitQuestListResult";
                    break;
                case 1590:      // 0x637
                    result = "PktGuildAgitQuestAccept";
                    break;
                case 1591:      // 0x638
                    result = "PktGuildAgitQuestAcceptResult";
                    break;
                case 1592:      // 0x639
                    result = "PktGuildAgitQuestComplete";
                    break;
                case 1593:      // 0x63A
                    result = "PktGuildAgitQuestCompleteResult";
                    break;
                case 1594:      // 0x63B
                    result = "PktGuildAgitQuestCompleteImmediately";
                    break;
                case 1595:      // 0x63C
                    result = "PktGuildAgitQuestCompleteImmediatelyResult";
                    break;
                case 1596:      // 0x63D
                    result = "PktGuildPromoListRead";
                    break;
                case 1597:      // 0x63E
                    result = "PktGuildPromoListReadResult";
                    break;
                case 1598:      // 0x63F
                    result = "PktGuildCommunityOpen";
                    break;
                case 1599:      // 0x640
                    result = "PktGuildCommunityOpenResult";
                    break;
                case 1600:      // 0x641
                    result = "PktCastleSiegeInfoRead";
                    break;
                case 1601:      // 0x642
                    result = "PktCastleSiegeInfoReadResult";
                    break;
                case 1602:      // 0x643
                    result = "PktCastleSiegeEnter";
                    break;
                case 1603:      // 0x644
                    result = "PktCastleSiegeEnterResult";
                    break;
                case 1604:      // 0x645
                    result = "PktCastleSiegeEnterNotify";
                    break;
                case 1605:      // 0x646
                    result = "PktCastleSiegeInfoNotify";
                    break;
                case 1606:      // 0x647
                    result = "PktCastleSiegeStateChangeNotify";
                    break;
                case 1607:      // 0x648
                    result = "PktCastleSiegeGuildInfoRead";
                    break;
                case 1608:      // 0x649
                    result = "PktCastleSiegeGuildInfoReadResult";
                    break;
                case 1609:      // 0x64A
                    result = "PktCastleSiegeFinishNotify";
                    break;
                case 1610:      // 0x64B
                    result = "PktCastleSiegeRetreatNotify";
                    break;
                case 1611:      // 0x64C
                    result = "PktCastleSiegeHolyArtifactHpChangeNotify";
                    break;
                case 1612:      // 0x64D
                    result = "PktCastleSiegeHolyArtifactImprintNotify";
                    break;
                case 1613:      // 0x64E
                    result = "PktCastleSiegeEventNotify";
                    break;
                case 1614:      // 0x64F
                    result = "PktCastleSiegeLeave";
                    break;
                case 1615:      // 0x650
                    result = "PktCastleSiegeLeaveResult";
                    break;
                case 1616:      // 0x651
                    result = "PktCastleSiegeEntryBid";
                    break;
                case 1617:      // 0x652
                    result = "PktCastleSiegeEntryBidResult";
                    break;
                case 1618:      // 0x653
                    result = "PktCastleSiegeEntryBidCancel";
                    break;
                case 1619:      // 0x654
                    result = "PktCastleSiegeEntryBidCancelResult";
                    break;
                case 1620:      // 0x655
                    result = "PktCastleSiegeEntryChangeNotify";
                    break;
                case 1621:      // 0x656
                    result = "PktCastleSiegeFestivalInfoRead";
                    break;
                case 1622:      // 0x657
                    result = "PktCastleSiegeFestivalInfoReadResult";
                    break;
                case 1623:      // 0x658
                    result = "PktCastleSiegeFestivalLotteryBuy";
                    break;
                case 1624:      // 0x659
                    result = "PktCastleSiegeFestivalLotteryBuyResult";
                    break;
                case 1625:      // 0x65A
                    result = "PktCastleSiegeFestivalLotteryRewardGet";
                    break;
                case 1626:      // 0x65B
                    result = "PktCastleSiegeFestivalLotteryRewardGetResult";
                    break;
                case 1627:      // 0x65C
                    result = "PktCastleSiegeGuildAlarm";
                    break;
                case 1628:      // 0x65D
                    result = "PktCastleSiegeGuildAlarmResult";
                    break;
                case 1629:      // 0x65E
                    result = "PktCastleSiegeGuildAlarmNotify";
                    break;
                case 1630:      // 0x65F
                    result = "PktCommonSiegeKillComboNotify";
                    break;
                case 1631:      // 0x660
                    result = "PktCommonSiegeOccupyBuffNotify";
                    break;
                case 1632:      // 0x661
                    result = "PktCommonSiegeDestroyedActorNotify";
                    break;
                case 1633:      // 0x662
                    result = "PktCastleOccupyGuildInfo";
                    break;
                case 1634:      // 0x663
                    result = "PktCastleOccupyGuildInfoResult";
                    break;
                case 1635:      // 0x664
                    result = "PktCastleSiegePrevRecord";
                    break;
                case 1636:      // 0x665
                    result = "PktCastleSiegePrevRecordResult";
                    break;
                case 1637:      // 0x666
                    result = "PktCastleSiegeHistoryList";
                    break;
                case 1638:      // 0x667
                    result = "PktCastleSiegeHistoryListResult";
                    break;
                case 1639:      // 0x668
                    result = "PktCastleSiegePreseasonInfo";
                    break;
                case 1640:      // 0x669
                    result = "PktCastleSiegePreseasonInfoResult";
                    break;
                case 1700:      // 0x6A5
                    result = "PktFortressSiegeInfoRead";
                    break;
                case 1701:      // 0x6A6
                    result = "PktFortressSiegeInfoReadResult";
                    break;
                case 1702:      // 0x6A7
                    result = "PktFortressSiegeEntryBid";
                    break;
                case 1703:      // 0x6A8
                    result = "PktFortressSiegeEntryBidResult";
                    break;
                case 1704:      // 0x6A9
                    result = "PktFortressSiegeEntryBidCancel";
                    break;
                case 1705:      // 0x6AA
                    result = "PktFortressSiegeEntryBidCancelResult";
                    break;
                case 1706:      // 0x6AB
                    result = "PktFortressSiegeEntryChangeNotify";
                    break;
                case 1707:      // 0x6AC
                    result = "PktFortressSiegeEnter";
                    break;
                case 1708:      // 0x6AD
                    result = "PktFortressSiegeEnterResult";
                    break;
                case 1709:      // 0x6AE
                    result = "PktFortressSiegeEnterNotify";
                    break;
                case 1710:      // 0x6AF
                    result = "PktFortressSiegeInfoNotify";
                    break;
                case 1711:      // 0x6B0
                    result = "PktFortressSiegeStateChangeNotify";
                    break;
                case 1712:      // 0x6B1
                    result = "PktFortressSiegeGuildInfoRead";
                    break;
                case 1713:      // 0x6B2
                    result = "PktFortressSiegeGuildInfoReadResult";
                    break;
                case 1714:      // 0x6B3
                    result = "PktFortressSiegeFinishNotify";
                    break;
                case 1715:      // 0x6B4
                    result = "PktFortressSiegeRetreatNotify";
                    break;
                case 1716:      // 0x6B5
                    result = "PktFortressSiegeHolyArtifactHpChangeNotify";
                    break;
                case 1717:      // 0x6B6
                    result = "PktFortressSiegeHolyArtifactImprintNotify";
                    break;
                case 1718:      // 0x6B7
                    result = "PktFortressSiegeEventNotify";
                    break;
                case 1719:      // 0x6B8
                    result = "PktFortressSiegeLeave";
                    break;
                case 1720:      // 0x6B9
                    result = "PktFortressSiegeLeaveResult";
                    break;
                case 1721:      // 0x6BA
                    result = "PktFortressOccupyGuildInfo";
                    break;
                case 1722:      // 0x6BB
                    result = "PktFortressOccupyGuildInfoResult";
                    break;
                case 1723:      // 0x6BC
                    result = "PktFortressSiegePrevRecord";
                    break;
                case 1724:      // 0x6BD
                    result = "PktFortressSiegePrevRecordResult";
                    break;
                case 1725:      // 0x6BE
                    result = "PktFortressSiegeHistoryList";
                    break;
                case 1726:      // 0x6BF
                    result = "PktFortressSiegeHistoryListResult";
                    break;
                case 1800:      // 0x709
                    result = "PktAuctionHouseSearchListRead";
                    break;
                case 1801:      // 0x70A
                    result = "PktAuctionHouseSearchListReadResult";
                    break;
                case 1802:      // 0x70B
                    result = "PktAuctionHouseItemDetailView";
                    break;
                case 1803:      // 0x70C
                    result = "PktAuctionHouseItemDetailViewResult";
                    break;
                case 1804:      // 0x70D
                    result = "PktAuctionHouseBuy";
                    break;
                case 1805:      // 0x70E
                    result = "PktAuctionHouseBuyResult";
                    break;
                case 1806:      // 0x70F
                    result = "PktAuctionHouseSellingListRead";
                    break;
                case 1807:      // 0x710
                    result = "PktAuctionHouseSellingListReadResult";
                    break;
                case 1808:      // 0x711
                    result = "PktAuctionHouseSellingRegister";
                    break;
                case 1809:      // 0x712
                    result = "PktAuctionHouseSellingRegisterResult";
                    break;
                case 1810:      // 0x713
                    result = "PktAuctionHouseSellingCancel";
                    break;
                case 1811:      // 0x714
                    result = "PktAuctionHouseSellingCancelResult";
                    break;
                case 1812:      // 0x715
                    result = "PktAuctionHouseSellingResultGet";
                    break;
                case 1813:      // 0x716
                    result = "PktAuctionHouseSellingResultGetResult";
                    break;
                case 1814:      // 0x717
                    result = "PktAuctionHouseSellingResultGetAll";
                    break;
                case 1815:      // 0x718
                    result = "PktAuctionHouseSellingResultGetAllResult";
                    break;
                case 1816:      // 0x719
                    result = "PktAuctionHouseRecordListRead";
                    break;
                case 1817:      // 0x71A
                    result = "PktAuctionHouseRecordListReadResult";
                    break;
                case 1818:      // 0x71B
                    result = "PktAuctionHouseAveragePriceGet";
                    break;
                case 1819:      // 0x71C
                    result = "PktAuctionHouseAveragePriceGetResult";
                    break;
                case 1820:      // 0x71D
                    result = "PktAuctionHouseFavoritesListRead";
                    break;
                case 1821:      // 0x71E
                    result = "PktAuctionHouseFavoritesListReadResult";
                    break;
                case 1822:      // 0x71F
                    result = "PktAuctionHouseFavoritesRegister";
                    break;
                case 1823:      // 0x720
                    result = "PktAuctionHouseFavoritesRegisterResult";
                    break;
                case 1824:      // 0x721
                    result = "PktAuctionHouseFavoritesOnSaleNotify";
                    break;
                case 1825:      // 0x722
                    result = "PktAuctionHouseSellingRegisterAgain";
                    break;
                case 1826:      // 0x723
                    result = "PktAuctionHouseSellingRegisterAgainResult";
                    break;
                case 1827:      // 0x724
                    result = "PktAuctionHouseGetEnabled";
                    break;
                case 1828:      // 0x725
                    result = "PktAuctionHouseGetEnabledResult";
                    break;
                case 1900:      // 0x76D
                    result = "PktShopItemListRead";
                    break;
                case 1901:      // 0x76E
                    result = "PktShopItemListReadResult";
                    break;
                case 1902:      // 0x76F
                    result = "PktShopItemBuy";
                    break;
                case 1903:      // 0x770
                    result = "PktShopItemBuyResult";
                    break;
                case 1904:      // 0x771
                    result = "PktFixedChargeNotify";
                    break;
                case 1905:      // 0x772
                    result = "PktFixedChargeInfoNotify";
                    break;
                case 1906:      // 0x773
                    result = "PktFixedChargeDetail";
                    break;
                case 1907:      // 0x774
                    result = "PktFixedChargeDetailResult";
                    break;
                case 1908:      // 0x775
                    result = "PktFixedChargeBuy";
                    break;
                case 1909:      // 0x776
                    result = "PktFixedChargeBuyResult";
                    break;
                case 1910:      // 0x777
                    result = "PktFixedChargeTopazGet";
                    break;
                case 1911:      // 0x778
                    result = "PktFixedChargeTopazGetResult";
                    break;
                case 1912:      // 0x779
                    result = "PktFixedChargeDiamondGet";
                    break;
                case 1913:      // 0x77A
                    result = "PktFixedChargeDiamondGetResult";
                    break;
                case 1914:      // 0x77B
                    result = "PktFixedChargeYesterdayDiamondGet";
                    break;
                case 1915:      // 0x77C
                    result = "PktFixedChargeYesterdayDiamondGetResult";
                    break;
                case 1916:      // 0x77D
                    result = "PktPensionTypeNotify";
                    break;
                case 1917:      // 0x77E
                    result = "PktPensionTypeAchievementCompleteNotify";
                    break;
                case 1918:      // 0x77F
                    result = "PktPensionTypeDetail";
                    break;
                case 1919:      // 0x780
                    result = "PktPensionTypeDetailResult";
                    break;
                case 1920:      // 0x781
                    result = "PktPensionTypeBuy";
                    break;
                case 1921:      // 0x782
                    result = "PktPensionTypeBuyResult";
                    break;
                case 1922:      // 0x783
                    result = "PktPensionTypeRewardGet";
                    break;
                case 1923:      // 0x784
                    result = "PktPensionTypeRewardGetResult";
                    break;
                case 1924:      // 0x785
                    result = "PktSmartPopupNotify";
                    break;
                case 1925:      // 0x786
                    result = "PktSmartPopupClose";
                    break;
                case 1926:      // 0x787
                    result = "PktSmartPopupCloseResult";
                    break;
                case 1927:      // 0x788
                    result = "PktDailyAdenaNotify";
                    break;
                case 1928:      // 0x789
                    result = "PktDailyAdenaInfoNotify";
                    break;
                case 1929:      // 0x78A
                    result = "PktDailyAdenaDetail";
                    break;
                case 1930:      // 0x78B
                    result = "PktDailyAdenaDetailResult";
                    break;
                case 1931:      // 0x78C
                    result = "PktDailyAdenaBuy";
                    break;
                case 1932:      // 0x78D
                    result = "PktDailyAdenaBuyResult";
                    break;
                case 1933:      // 0x78E
                    result = "PktDailyAdenaDiamondGet";
                    break;
                case 1934:      // 0x78F
                    result = "PktDailyAdenaDiamondGetResult";
                    break;
                case 1935:      // 0x790
                    result = "PktDailyAdenaRewardGet";
                    break;
                case 1936:      // 0x791
                    result = "PktDailyAdenaRewardGetResult";
                    break;
                case 1937:      // 0x792
                    result = "PktShopRewardListRead";
                    break;
                case 1938:      // 0x793
                    result = "PktShopRewardListReadResult";
                    break;
                case 1939:      // 0x794
                    result = "PktShopRewardGet";
                    break;
                case 1940:      // 0x795
                    result = "PktShopRewardGetResult";
                    break;
                case 1941:      // 0x796
                    result = "PktShopRewardNotify";
                    break;
                case 1942:      // 0x797
                    result = "PktFixedChargeGoodsListRead";
                    break;
                case 1943:      // 0x798
                    result = "PktFixedChargeGoodsListReadResult";
                    break;
                case 1944:      // 0x799
                    result = "PktFixedChargeGoodsBuy";
                    break;
                case 1945:      // 0x79A
                    result = "PktFixedChargeGoodsBuyResult";
                    break;
                case 1946:      // 0x79B
                    result = "PktFixedChargeGoodsDailyReward";
                    break;
                case 1947:      // 0x79C
                    result = "PktFixedChargeGoodsDailyRewardResult";
                    break;
                case 1948:      // 0x79D
                    result = "PktFixedChargeGoodsExpireNotify";
                    break;
                case 1949:      // 0x79E
                    result = "PktTimeShopListRead";
                    break;
                case 1950:      // 0x79F
                    result = "PktTimeShopListReadResult";
                    break;
                case 1951:      // 0x7A0
                    result = "PktTimeShopListNotify";
                    break;
                case 1952:      // 0x7A1
                    result = "PktDiscountShopListRead";
                    break;
                case 1953:      // 0x7A2
                    result = "PktDiscountShopListReadResult";
                    break;
                case 1954:      // 0x7A3
                    result = "PktBeautyShopListRead";
                    break;
                case 1955:      // 0x7A4
                    result = "PktBeautyShopListReadResult";
                    break;
                case 1956:      // 0x7A5
                    result = "PktBeautyShopItemBuy";
                    break;
                case 1957:      // 0x7A6
                    result = "PktBeautyShopItemBuyResult";
                    break;
                case 1958:      // 0x7A7
                    result = "PktDailyBenefitsEventStartNotify";
                    break;
                case 1959:      // 0x7A8
                    result = "PktDailyBenefitsEventExpireNotify";
                    break;
                case 2000:      // 0x7D1
                    result = "PktDungeonListRead";
                    break;
                case 2001:      // 0x7D2
                    result = "PktDungeonListReadResult";
                    break;
                case 2002:      // 0x7D3
                    result = "PktDungeonEnter";
                    break;
                case 2003:      // 0x7D4
                    result = "PktDungeonEnterResult";
                    break;
                case 2004:      // 0x7D5
                    result = "PktDungeonExit";
                    break;
                case 2005:      // 0x7D6
                    result = "PktDungeonExitResult";
                    break;
                case 2006:      // 0x7D7
                    result = "PktDungeonGiveUp";
                    break;
                case 2007:      // 0x7D8
                    result = "PktDungeonGiveUpResult";
                    break;
                case 2008:      // 0x7D9
                    result = "PktDungeonSweep";
                    break;
                case 2009:      // 0x7DA
                    result = "PktDungeonSweepResult";
                    break;
                case 2010:      // 0x7DB
                    result = "PktDungeonResultNotify";
                    break;
                case 2011:      // 0x7DC
                    result = "PktDungeonStateNotify";
                    break;
                case 2012:      // 0x7DD
                    result = "PktDungeonEndTimeNotify";
                    break;
                case 2013:      // 0x7DE
                    result = "PktDungeonStartTimeNotify";
                    break;
                case 2014:      // 0x7DF
                    result = "PktDungeonScoreChangeNotify";
                    break;
                case 2015:      // 0x7E0
                    result = "PktDungeonReviveInfoNotify";
                    break;
                case 2016:      // 0x7E1
                    result = "PktGatheringNotify";
                    break;
                case 2017:      // 0x7E2
                    result = "PktDungeonQuestSweep";
                    break;
                case 2018:      // 0x7E3
                    result = "PktDungeonQuestSweepResult";
                    break;
                case 2019:      // 0x7E4
                    result = "PktDungeonQuestRewardGet";
                    break;
                case 2020:      // 0x7E5
                    result = "PktDungeonQuestRewardGetResult";
                    break;
                case 2021:      // 0x7E6
                    result = "PktDungeonQuestPointRewardGet";
                    break;
                case 2022:      // 0x7E7
                    result = "PktDungeonQuestPointRewardGetResult";
                    break;
                case 2023:      // 0x7E8
                    result = "PktDungeonHotTimeCharge";
                    break;
                case 2024:      // 0x7E9
                    result = "PktDungeonHotTimeChargeResult";
                    break;
                case 2025:      // 0x7EA
                    result = "PktDungeonQuestNotify";
                    break;
                case 2026:      // 0x7EB
                    result = "PktDungeonQuestCompleteNotify";
                    break;
                case 2027:      // 0x7EC
                    result = "PktDungeonHotTimeNotify";
                    break;
                case 2028:      // 0x7ED
                    result = "PktDungeonFreeCountBuy";
                    break;
                case 2029:      // 0x7EE
                    result = "PktDungeonFreeCountBuyResult";
                    break;
                case 2030:      // 0x7EF
                    result = "PktEnchantScrollDungeonStateNotify";
                    break;
                case 2031:      // 0x7F0
                    result = "PktEnchantScrollDungeonInfoNotify";
                    break;
                case 2032:      // 0x7F1
                    result = "PktDungeonReconnectNotify";
                    break;
                case 2033:      // 0x7F2
                    result = "PktEnchantScrollDungeonReconnectMoreInfoNotify";
                    break;
                case 2034:      // 0x7F3
                    result = "PktSummonStoneDungeonStateNotify";
                    break;
                case 2035:      // 0x7F4
                    result = "PktSummonStoneDungeonInfoNotify";
                    break;
                case 2036:      // 0x7F5
                    result = "PktSummonStoneDungeonReconnectMoreInfoNotify";
                    break;
                case 2037:      // 0x7F6
                    result = "PktDungeonBonusRewardNotify";
                    break;
                case 2038:      // 0x7F7
                    result = "PktPartyDungeonListRead";
                    break;
                case 2039:      // 0x7F8
                    result = "PktPartyDungeonListReadResult";
                    break;
                case 2040:      // 0x7F9
                    result = "PktPartyDungeonClearReset";
                    break;
                case 2041:      // 0x7FA
                    result = "PktPartyDungeonClearResetResult";
                    break;
                case 2100:      // 0x835
                    result = "PktPvpInfoRead";
                    break;
                case 2101:      // 0x836
                    result = "PktPvpInfoReadResult";
                    break;
                case 2102:      // 0x837
                    result = "PktPvpTargetListRefresh";
                    break;
                case 2103:      // 0x838
                    result = "PktPvpTargetListRefreshResult";
                    break;
                case 2104:      // 0x839
                    result = "PktPvpStartCheck";
                    break;
                case 2105:      // 0x83A
                    result = "PktPvpStartCheckResult";
                    break;
                case 2106:      // 0x83B
                    result = "PktPvpStart";
                    break;
                case 2107:      // 0x83C
                    result = "PktPvpStartResult";
                    break;
                case 2108:      // 0x83D
                    result = "PktPvpStartNotify";
                    break;
                case 2109:      // 0x83E
                    result = "PktPvpRecordListRead";
                    break;
                case 2110:      // 0x83F
                    result = "PktPvpRecordListReadResult";
                    break;
                case 2111:      // 0x840
                    result = "PktPvpRankingListRead";
                    break;
                case 2112:      // 0x841
                    result = "PktPvpRankingListReadResult";
                    break;
                case 2113:      // 0x842
                    result = "PktPvpLeave";
                    break;
                case 2114:      // 0x843
                    result = "PktPvpLeaveResult";
                    break;
                case 2115:      // 0x844
                    result = "PktPvpRewardGet";
                    break;
                case 2116:      // 0x845
                    result = "PktPvpRewardGetResult";
                    break;
                case 2117:      // 0x846
                    result = "PktPvpCountDownStartNotify";
                    break;
                case 2118:      // 0x847
                    result = "PktPvpTimeNotify";
                    break;
                case 2119:      // 0x848
                    result = "PktPvpEndNotify";
                    break;
                case 2120:      // 0x849
                    result = "PktPvpHonorRankUpNotify";
                    break;
                case 2121:      // 0x84A
                    result = "PktPvpRankingChangeNotify";
                    break;
                case 2122:      // 0x84B
                    result = "PktPkStatus";
                    break;
                case 2123:      // 0x84C
                    result = "PktPkStatusResult";
                    break;
                case 2124:      // 0x84D
                    result = "PktPkStatusNotify";
                    break;
                case 2125:      // 0x84E
                    result = "PktPkAttackStateNotify";
                    break;
                case 2126:      // 0x84F
                    result = "PktPkPointNotify";
                    break;
                case 2127:      // 0x850
                    result = "PktPlayerKilledNotify";
                    break;
                case 2128:      // 0x851
                    result = "PktPvpBattleStart";
                    break;
                case 2129:      // 0x852
                    result = "PktPvpBattleStartResult";
                    break;
                case 2130:      // 0x853
                    result = "PktPkPointMonsterKillCount";
                    break;
                case 2131:      // 0x854
                    result = "PktPkPointMonsterKillCountResult";
                    break;
                case 2200:      // 0x899
                    result = "PktClassTransferQuestStart";
                    break;
                case 2201:      // 0x89A
                    result = "PktClassTransferQuestStartResult";
                    break;
                case 2202:      // 0x89B
                    result = "PktClassTransferQuestListRead";
                    break;
                case 2203:      // 0x89C
                    result = "PktClassTransferQuestListReadResult";
                    break;
                case 2204:      // 0x89D
                    result = "PktClassTransferQuestRewardGet";
                    break;
                case 2205:      // 0x89E
                    result = "PktClassTransferQuestRewardGetResult";
                    break;
                case 2206:      // 0x89F
                    result = "PktClassTransfer";
                    break;
                case 2207:      // 0x8A0
                    result = "PktClassTransferResult";
                    break;
                case 2208:      // 0x8A1
                    result = "PktClassTransferableNotify";
                    break;
                case 2209:      // 0x8A2
                    result = "PktClassTransferQuestUpdateNotify";
                    break;
                case 2210:      // 0x8A3
                    result = "PktClassTransferQuestCompleteNotify";
                    break;
                case 2211:      // 0x8A4
                    result = "PktClassTransferCheatNotify";
                    break;
                case 2212:      // 0x8A5
                    result = "PktClassTransfer2ActListRead";
                    break;
                case 2213:      // 0x8A6
                    result = "PktClassTransfer2ActListReadResult";
                    break;
                case 2214:      // 0x8A7
                    result = "PktClassTransfer2ActRewardGet";
                    break;
                case 2215:      // 0x8A8
                    result = "PktClassTransfer2ActRewardGetResult";
                    break;
                case 2216:      // 0x8A9
                    result = "PktClassTransferPageRead";
                    break;
                case 2217:      // 0x8AA
                    result = "PktClassTransferPageReadResult";
                    break;
                case 2218:      // 0x8AB
                    result = "PktClassTransferPageOpen";
                    break;
                case 2219:      // 0x8AC
                    result = "PktClassTransferPageOpenResult";
                    break;
                case 2300:      // 0x8FD
                    result = "PktGuideQuestListRead";
                    break;
                case 2301:      // 0x8FE
                    result = "PktGuideQuestListReadResult";
                    break;
                case 2302:      // 0x8FF
                    result = "PktGuideQuestRewardGet";
                    break;
                case 2303:      // 0x900
                    result = "PktGuideQuestRewardGetResult";
                    break;
                case 2304:      // 0x901
                    result = "PktGuideQuestUpdateNotify";
                    break;
                case 2305:      // 0x902
                    result = "PktGuideQuestCompleteNotify";
                    break;
                case 2306:      // 0x903
                    result = "PktGuideQuestCheatNotify";
                    break;
                case 2307:      // 0x904
                    result = "PktGuideQuestActivityTimeRenew";
                    break;
                case 2308:      // 0x905
                    result = "PktGuideQuestActivityTimeRenewResult";
                    break;
                case 2350:      // 0x92F
                    result = "PktPromoteStateListRead";
                    break;
                case 2351:      // 0x930
                    result = "PktPromoteStateListReadResult";
                    break;
                case 2352:      // 0x931
                    result = "PktPromoteStateLowListRead";
                    break;
                case 2353:      // 0x932
                    result = "PktPromoteStateLowListReadResult";
                    break;
                case 2400:      // 0x961
                    result = "PktTutorialNotify";
                    break;
                case 2401:      // 0x962
                    result = "PktTutorialListRead";
                    break;
                case 2402:      // 0x963
                    result = "PktTutorialListReadResult";
                    break;
                case 2403:      // 0x964
                    result = "PktTutorialStart";
                    break;
                case 2404:      // 0x965
                    result = "PktTutorialStartResult";
                    break;
                case 2405:      // 0x966
                    result = "PktTutorialProgress";
                    break;
                case 2406:      // 0x967
                    result = "PktTutorialProgressResult";
                    break;
                case 2407:      // 0x968
                    result = "PktTutorialRewardGet";
                    break;
                case 2408:      // 0x969
                    result = "PktTutorialRewardGetResult";
                    break;
                case 2409:      // 0x96A
                    result = "PktTutorialMaterialReceiveNotify";
                    break;
                case 2410:      // 0x96B
                    result = "PktTutorialSkip";
                    break;
                case 2411:      // 0x96C
                    result = "PktTutorialSkipResult";
                    break;
                case 2500:      // 0x9C5
                    result = "PktCutSceneNotify";
                    break;
                case 2501:      // 0x9C6
                    result = "PktCutSceneStart";
                    break;
                case 2502:      // 0x9C7
                    result = "PktCutSceneStartResult";
                    break;
                case 2503:      // 0x9C8
                    result = "PktCutSceneEnd";
                    break;
                case 2504:      // 0x9C9
                    result = "PktCutSceneEndResult";
                    break;
                case 2505:      // 0x9CA
                    result = "PktCutSceneEndReserve";
                    break;
                case 2506:      // 0x9CB
                    result = "PktCutSceneEndReserveResult";
                    break;
                case 2507:      // 0x9CC
                    result = "PktWorldPause";
                    break;
                case 2508:      // 0x9CD
                    result = "PktWorldPauseResult";
                    break;
                case 2509:      // 0x9CE
                    result = "PktWorldResume";
                    break;
                case 2510:      // 0x9CF
                    result = "PktWorldResumeResult";
                    break;
                case 2511:      // 0x9D0
                    result = "PktQuestCutSceneEndSync";
                    break;
                case 2512:      // 0x9D1
                    result = "PktQuestCutSceneEndSyncResult";
                    break;
                case 2513:      // 0x9D2
                    result = "PktQuestCutSceneEndSyncNotify";
                    break;
                case 2600:      // 0xA29
                    result = "PktSystemSettingsGet";
                    break;
                case 2601:      // 0xA2A
                    result = "PktSystemSettingsGetResult";
                    break;
                case 2602:      // 0xA2B
                    result = "PktSystemSettingsSet";
                    break;
                case 2603:      // 0xA2C
                    result = "PktSystemSettingsSetResult";
                    break;
                case 2604:      // 0xA2D
                    result = "PktSystemAlarmNotify";
                    break;
                case 2605:      // 0xA2E
                    result = "PktPing";
                    break;
                case 2606:      // 0xA2F
                    result = "PktPingResult";
                    break;
                case 2650:      // 0xA5B
                    result = "PktInstantCompleteListRead";
                    break;
                case 2651:      // 0xA5C
                    result = "PktInstantCompleteListReadResult";
                    break;
                case 2652:      // 0xA5D
                    result = "PktInstantCompleteRewardGet";
                    break;
                case 2653:      // 0xA5E
                    result = "PktInstantCompleteRewardGetResult";
                    break;
                case 2654:      // 0xA5F
                    result = "PktInstantCompleteRewardAllGet";
                    break;
                case 2655:      // 0xA60
                    result = "PktInstantCompleteRewardAllGetResult";
                    break;
                case 2700:      // 0xA8D
                    result = "PktMissionRequestListRead";
                    break;
                case 2701:      // 0xA8E
                    result = "PktMissionRequestListReadResult";
                    break;
                case 2702:      // 0xA8F
                    result = "PktMissionRequestStart";
                    break;
                case 2703:      // 0xA90
                    result = "PktMissionRequestStartResult";
                    break;
                case 2704:      // 0xA91
                    result = "PktMissionDailyRefresh";
                    break;
                case 2705:      // 0xA92
                    result = "PktMissionDailyRefreshResult";
                    break;
                case 2706:      // 0xA93
                    result = "PktMissionDailyNowComplete";
                    break;
                case 2707:      // 0xA94
                    result = "PktMissionDailyNowCompleteResult";
                    break;
                case 2708:      // 0xA95
                    result = "PktMissionDailyMaxComboComplete";
                    break;
                case 2709:      // 0xA96
                    result = "PktMissionDailyMaxComboCompleteResult";
                    break;
                case 2710:      // 0xA97
                    result = "PktMissionWeeklyPass";
                    break;
                case 2711:      // 0xA98
                    result = "PktMissionWeeklyPassResult";
                    break;
                case 2712:      // 0xA99
                    result = "PktMissionDailyRewardGet";
                    break;
                case 2713:      // 0xA9A
                    result = "PktMissionDailyRewardGetResult";
                    break;
                case 2714:      // 0xA9B
                    result = "PktMissionWeeklyRewardGet";
                    break;
                case 2715:      // 0xA9C
                    result = "PktMissionWeeklyRewardGetResult";
                    break;
                case 2716:      // 0xA9D
                    result = "PktMissionRequestRewardGet";
                    break;
                case 2717:      // 0xA9E
                    result = "PktMissionRequestRewardGetResult";
                    break;
                case 2718:      // 0xA9F
                    result = "PktMissionRequestCompleteNotify";
                    break;
                case 2719:      // 0xAA0
                    result = "PktMissionDailyUpdateNotify";
                    break;
                case 2720:      // 0xAA1
                    result = "PktMissionWeeklyUpdateNotify";
                    break;
                case 2721:      // 0xAA2
                    result = "PktMissionTeleport";
                    break;
                case 2722:      // 0xAA3
                    result = "PktMissionTeleportResult";
                    break;
                case 2723:      // 0xAA4
                    result = "PktMissionWeeklyRefresh";
                    break;
                case 2724:      // 0xAA5
                    result = "PktMissionWeeklyRefreshResult";
                    break;
                case 2725:      // 0xAA6
                    result = "PktEventDailyQuestListRead";
                    break;
                case 2726:      // 0xAA7
                    result = "PktEventDailyQuestListReadResult";
                    break;
                case 2727:      // 0xAA8
                    result = "PktEventDailyQuestRewardGet";
                    break;
                case 2728:      // 0xAA9
                    result = "PktEventDailyQuestRewardGetResult";
                    break;
                case 2729:      // 0xAAA
                    result = "PktEventDailyQuestProgressRewardGet";
                    break;
                case 2730:      // 0xAAB
                    result = "PktEventDailyQuestProgressRewardGetResult";
                    break;
                case 2731:      // 0xAAC
                    result = "PktEventDailyQuestStart";
                    break;
                case 2732:      // 0xAAD
                    result = "PktEventDailyQuestStartResult";
                    break;
                case 2733:      // 0xAAE
                    result = "PktEventDailyQuestResetCompletedCountNotify";
                    break;
                case 2750:      // 0xABF
                    result = "PktEventListRead";
                    break;
                case 2751:      // 0xAC0
                    result = "PktEventListReadResult";
                    break;
                case 2752:      // 0xAC1
                    result = "PktEventRewardGet";
                    break;
                case 2753:      // 0xAC2
                    result = "PktEventRewardGetResult";
                    break;
                case 2754:      // 0xAC3
                    result = "PktEventStartNotify";
                    break;
                case 2755:      // 0xAC4
                    result = "PktEventListNotify";
                    break;
                case 2756:      // 0xAC5
                    result = "PktEventMessageNotify";
                    break;
                case 2757:      // 0xAC6
                    result = "PktDropBoxEventNotify";
                    break;
                case 2758:      // 0xAC7
                    result = "PktInitDropBoxNotify";
                    break;
                case 2759:      // 0xAC8
                    result = "PktEventDiceExecute";
                    break;
                case 2760:      // 0xAC9
                    result = "PktEventDiceExecuteResult";
                    break;
                case 2761:      // 0xACA
                    result = "PktEventProgressNotify";
                    break;
                case 2762:      // 0xACB
                    result = "PktEventPostListRead";
                    break;
                case 2763:      // 0xACC
                    result = "PktEventPostListReadResult";
                    break;
                case 2764:      // 0xACD
                    result = "PktEventNeroDiceExecute";
                    break;
                case 2765:      // 0xACE
                    result = "PktEventNeroDiceExecuteResult";
                    break;
                case 2766:      // 0xACF
                    result = "PktEventNeroDiceGetReward";
                    break;
                case 2767:      // 0xAD0
                    result = "PktEventNeroDiceGetRewardResult";
                    break;
                case 2768:      // 0xAD1
                    result = "PktEventPostConfirm";
                    break;
                case 2769:      // 0xAD2
                    result = "PktEventPostConfirmResult";
                    break;
                case 2800:      // 0xAF1
                    result = "PktNetmarbleSIAPInitialize";
                    break;
                case 2801:      // 0xAF2
                    result = "PktNetmarbleSIAPInitializeResult";
                    break;
                case 2802:      // 0xAF3
                    result = "PktNetmarbleSIAPVerify";
                    break;
                case 2803:      // 0xAF4
                    result = "PktNetmarbleSIAPVerifyResult";
                    break;
                case 2804:      // 0xAF5
                    result = "PktNetmarbleSIAPPurchaseCancel";
                    break;
                case 2805:      // 0xAF6
                    result = "PktNetmarbleSIAPPurchaseCancelResult";
                    break;
                case 2806:      // 0xAF7
                    result = "PktGoogleAnalyticsFirstDied";
                    break;
                case 2807:      // 0xAF8
                    result = "PktGoogleAnalyticsFirstDiedResult";
                    break;
                case 2808:      // 0xAF9
                    result = "PktNetmarbleSWebAchievementNotify";
                    break;
                case 2900:      // 0xB55
                    result = "PktRankingListRead";
                    break;
                case 2901:      // 0xB56
                    result = "PktRankingListReadResult";
                    break;
                case 2902:      // 0xB57
                    result = "PktBroadCastNotify";
                    break;
                case 3000:      // 0xBB9
                    result = "PktUpdate";
                    break;
                case 3001:      // 0xBBA
                    result = "PktUpdateResult";
                    break;
                case 3002:      // 0xBBB
                    result = "PktAdminToolRequest";
                    break;
                case 3003:      // 0xBBC
                    result = "PktAdminToolRequestResult";
                    break;
                case 3004:      // 0xBBD
                    result = "PktAdminToolNoticeInsert";
                    break;
                case 3005:      // 0xBBE
                    result = "PktAdminToolNoticeInsertResult";
                    break;
                case 3006:      // 0xBBF
                    result = "PktAdminToolNoticeDelete";
                    break;
                case 3007:      // 0xBC0
                    result = "PktAdminToolNoticeDeleteResult";
                    break;
                case 3100:      // 0xC1D
                    result = "PktCharacterTitleListRead";
                    break;
                case 3101:      // 0xC1E
                    result = "PktCharacterTitleListReadResult";
                    break;
                case 3102:      // 0xC1F
                    result = "PktCharacterTitleEquip";
                    break;
                case 3103:      // 0xC20
                    result = "PktCharacterTitleEquipResult";
                    break;
                case 3104:      // 0xC21
                    result = "PktCharacterTitleUpdateNotify";
                    break;
                case 3105:      // 0xC22
                    result = "PktCharacterTitleEquipNotify";
                    break;
                case 3106:      // 0xC23
                    result = "PktCharacterTitleAcquire";
                    break;
                case 3107:      // 0xC24
                    result = "PktCharacterTitleAcquireResult";
                    break;
                case 3108:      // 0xC25
                    result = "PktCharacterTitleDeleteNotify";
                    break;
                case 3200:      // 0xC81
                    result = "PktCapeListRead";
                    break;
                case 3201:      // 0xC82
                    result = "PktCapeListReadResult";
                    break;
                case 3202:      // 0xC83
                    result = "PktCapeAcquire";
                    break;
                case 3203:      // 0xC84
                    result = "PktCapeAcquireResult";
                    break;
                case 3204:      // 0xC85
                    result = "PktCapeEquipChange";
                    break;
                case 3205:      // 0xC86
                    result = "PktCapeEquipChangeResult";
                    break;
                case 3206:      // 0xC87
                    result = "PktCapeUnequip";
                    break;
                case 3207:      // 0xC88
                    result = "PktCapeUnequipResult";
                    break;
                case 3208:      // 0xC89
                    result = "PktCapeLevelUp";
                    break;
                case 3209:      // 0xC8A
                    result = "PktCapeLevelUpResult";
                    break;
                case 3210:      // 0xC8B
                    result = "PktCapeOptionChange";
                    break;
                case 3211:      // 0xC8C
                    result = "PktCapeOptionChangeResult";
                    break;
                case 3212:      // 0xC8D
                    result = "PktGuildCapeLevelUp";
                    break;
                case 3213:      // 0xC8E
                    result = "PktGuildCapeLevelUpResult";
                    break;
                case 3214:      // 0xC8F
                    result = "PktGuildCapeColorChange";
                    break;
                case 3215:      // 0xC90
                    result = "PktGuildCapeColorChangeResult";
                    break;
                case 3216:      // 0xC91
                    result = "PktCapeChangePlayerNotify";
                    break;
                case 3217:      // 0xC92
                    result = "PktCapeChangeNotify";
                    break;
                case 3500:      // 0xDAD
                    result = "PktCacheObjectInvalidateNotify";
                    break;
                case 4000:      // 0xFA1
                    result = "PktWebUserLogin";
                    break;
                case 4001:      // 0xFA2
                    result = "PktWebUserLoginResult";
                    break;
                case 4002:      // 0xFA3
                    result = "PktWebUserLogout";
                    break;
                case 4003:      // 0xFA4
                    result = "PktWebUserLogoutResult";
                    break;
                case 4004:      // 0xFA5
                    result = "PktActorLocationNotify";
                    break;
                case 4005:      // 0xFA6
                    result = "PktMessageShowNotify";
                    break;
                case 4006:      // 0xFA7
                    result = "PktMessageReply";
                    break;
                case 4007:      // 0xFA8
                    result = "PktMessageReplyResult";
                    break;
                case 4008:      // 0xFA9
                    result = "PktLogShowNotify";
                    break;
                case 4009:      // 0xFAA
                    result = "PktStyleSheet";
                    break;
                case 4010:      // 0xFAB
                    result = "PktStyleSheetResult";
                    break;
                case 4011:      // 0xFAC
                    result = "PktStyleSheetResource";
                    break;
                case 4012:      // 0xFAD
                    result = "PktStyleSheetResourceResult";
                    break;
                case 4013:      // 0xFAE
                    result = "PktTestBotPlayerInfoRead";
                    break;
                case 4014:      // 0xFAF
                    result = "PktTestBotPlayerInfoReadResult";
                    break;
                case 4015:      // 0xFB0
                    result = "PktQuestEdit";
                    break;
                case 4016:      // 0xFB1
                    result = "PktQuestEditResult";
                    break;
                case 4017:      // 0xFB2
                    result = "PktDebugShapeShowNotify";
                    break;
                case 4018:      // 0xFB3
                    result = "PktSecurityCodeManage";
                    break;
                case 4019:      // 0xFB4
                    result = "PktSecurityCodeManageResult";
                    break;
                case 4020:      // 0xFB5
                    result = "PktWorldBossNotify";
                    break;
                case 4021:      // 0xFB6
                    result = "PktTestBotCommandNotify";
                    break;
                case 4022:      // 0xFB7
                    result = "PktPerformanceTrace";
                    break;
                case 4023:      // 0xFB8
                    result = "PktPerformanceTraceResult";
                    break;
                case 4024:      // 0xFB9
                    result = "PktApolloVoiceGetAuthKey";
                    break;
                case 4025:      // 0xFBA
                    result = "PktApolloVoiceGetAuthKeyResult";
                    break;
                case 4026:      // 0xFBB
                    result = "PktEnvironmentManage";
                    break;
                case 4027:      // 0xFBC
                    result = "PktEnvironmentManageResult";
                    break;
                case 4028:      // 0xFBD
                    result = "PktFuncCall";
                    break;
                case 4029:      // 0xFBE
                    result = "PktFuncCallResult";
                    break;
                case 4030:      // 0xFBF
                    result = "PktObjectStatsTrace";
                    break;
                case 4031:      // 0xFC0
                    result = "PktObjectStatsTraceResult";
                    break;
                case 5000:      // 0x1389
                    result = "PktPlayerSocialActionListRead";
                    break;
                case 5001:      // 0x138A
                    result = "PktPlayerSocialActionListReadResult";
                    break;
                case 5002:      // 0x138B
                    result = "PktPlayerSocialActionMessageChange";
                    break;
                case 5003:      // 0x138C
                    result = "PktPlayerSocialActionMessageChangeResult";
                    break;
                case 5004:      // 0x138D
                    result = "PktEventGachaListRead";
                    break;
                case 5005:      // 0x138E
                    result = "PktEventGachaListReadResult";
                    break;
                case 5006:      // 0x138F
                    result = "PktEventGachaDetailRead";
                    break;
                case 5007:      // 0x1390
                    result = "PktEventGachaDetailReadResult";
                    break;
                case 5008:      // 0x1391
                    result = "PktEventGacha";
                    break;
                case 5009:      // 0x1392
                    result = "PktEventGachaResult";
                    break;
                case 5010:      // 0x1393
                    result = "PktEventGachaNotify";
                    break;
                case 5900:      // 0x170D
                    result = "PktQuestCutScenePlayResult";
                    break;
                case 5901:      // 0x170E
                    result = "PktItemProtect";
                    break;
                case 5902:      // 0x170F
                    result = "PktItemProtectResult";
                    break;
                case 5903:      // 0x1710
                    result = "PktSocialNetworkShared";
                    break;
                case 5904:      // 0x1711
                    result = "PktSocialNetworkSharedResult";
                    break;
                case 5905:      // 0x1712
                    result = "PktGuildDailyRewardRead";
                    break;
                case 5906:      // 0x1713
                    result = "PktGuildDailyRewardReadResult";
                    break;
                case 5907:      // 0x1714
                    result = "PktGuildFortressDailyRewardGet";
                    break;
                case 5908:      // 0x1715
                    result = "PktGuildFortressDailyRewardGetResult";
                    break;
                case 5909:      // 0x1716
                    result = "PktPacketLogView";
                    break;
                case 5910:      // 0x1717
                    result = "PktPacketLogViewResult";
                    break;
                case 5911:      // 0x1718
                    result = "PktGuildJoinRequestRandom";
                    break;
                case 5912:      // 0x1719
                    result = "PktGuildJoinRequestRandomResult";
                    break;
                case 5913:      // 0x171A
                    result = "PktShopItemDailyListRead";
                    break;
                case 5914:      // 0x171B
                    result = "PktShopItemDailyListReadResult";
                    break;
                case 5915:      // 0x171C
                    result = "PktShopItemDailyBuy";
                    break;
                case 5916:      // 0x171D
                    result = "PktShopItemDailyBuyResult";
                    break;
                case 5917:      // 0x171E
                    result = "PktShopItemDailyReward";
                    break;
                case 5918:      // 0x171F
                    result = "PktShopItemDailyRewardResult";
                    break;
                case 5919:      // 0x1720
                    result = "PktShopItemDailyBonus";
                    break;
                case 5920:      // 0x1721
                    result = "PktShopItemDailyBonusResult";
                    break;
                case 5921:      // 0x1722
                    result = "PktEventTargetListRead";
                    break;
                case 5922:      // 0x1723
                    result = "PktEventTargetListReadResult";
                    break;
                case 5923:      // 0x1724
                    result = "PktEventTargetAttendanceRead";
                    break;
                case 5924:      // 0x1725
                    result = "PktEventTargetAttendanceReadResult";
                    break;
                case 5925:      // 0x1726
                    result = "PktEventTargetAttendanceReward";
                    break;
                case 5926:      // 0x1727
                    result = "PktEventTargetAttendanceRewardResult";
                    break;
                case 5927:      // 0x1728
                    result = "PktEventTargetChargeConsumeRead";
                    break;
                case 5928:      // 0x1729
                    result = "PktEventTargetChargeConsumeReadResult";
                    break;
                case 5929:      // 0x172A
                    result = "PktEventTargetChargeConsumeReward";
                    break;
                case 5930:      // 0x172B
                    result = "PktEventTargetChargeConsumeRewardResult";
                    break;
                case 6000:      // 0x1771
                    result = "PktGuildAgitKeeperInfo";
                    break;
                case 6001:      // 0x1772
                    result = "PktGuildAgitKeeperInfoResult";
                    break;
                case 6002:      // 0x1773
                    result = "PktGuildAgitBanquetList";
                    break;
                case 6003:      // 0x1774
                    result = "PktGuildAgitBanquetListResult";
                    break;
                case 6004:      // 0x1775
                    result = "PktGuildAgitBanquetCreate";
                    break;
                case 6005:      // 0x1776
                    result = "PktGuildAgitBanquetCreateResult";
                    break;
                case 6006:      // 0x1777
                    result = "PktGuildAgitBanquetCreateNotify";
                    break;
                case 6007:      // 0x1778
                    result = "PktGuildAgitRelicList";
                    break;
                case 6008:      // 0x1779
                    result = "PktGuildAgitRelicListResult";
                    break;
                case 6009:      // 0x177A
                    result = "PktGuildAgitRelicRegist";
                    break;
                case 6010:      // 0x177B
                    result = "PktGuildAgitRelicRegistResult";
                    break;
                case 6011:      // 0x177C
                    result = "PktGuildAgitRelicAppraise";
                    break;
                case 6012:      // 0x177D
                    result = "PktGuildAgitRelicAppraiseResult";
                    break;
                case 6013:      // 0x177E
                    result = "PktGuildAgitRelicPointUse";
                    break;
                case 6014:      // 0x177F
                    result = "PktGuildAgitRelicPointUseResult";
                    break;
                case 6015:      // 0x1780
                    result = "PktGuildAgitKeeperUpgrade";
                    break;
                case 6016:      // 0x1781
                    result = "PktGuildAgitKeeperUpgradeResult";
                    break;
                case 6017:      // 0x1782
                    result = "PktGuildAgitKeeperAutoExtends";
                    break;
                case 6018:      // 0x1783
                    result = "PktGuildAgitKeeperAutoExtendsResult";
                    break;
                case 6019:      // 0x1784
                    result = "PktGuildAgitQuestListNotify";
                    break;
                case 6020:      // 0x1785
                    result = "PktGuildAgitQuestUpdateNotify";
                    break;
                case 6021:      // 0x1786
                    result = "PktGuildFortressGiveUp";
                    break;
                case 6022:      // 0x1787
                    result = "PktGuildFortressGiveUpResult";
                    break;
                case 6023:      // 0x1788
                    result = "PktGuildCastleGiveUp";
                    break;
                case 6024:      // 0x1789
                    result = "PktGuildCastleGiveUpResult";
                    break;
                case 6025:      // 0x178A
                    result = "PktGuildStateChangeNotify";
                    break;
                case 6026:      // 0x178B
                    result = "PktGuildDonateReset";
                    break;
                case 6027:      // 0x178C
                    result = "PktGuildDonateResetResult";
                    break;
                case 6028:      // 0x178D
                    result = "PktGuildAgitUpgradeNotify";
                    break;
                case 6029:      // 0x178E
                    result = "PktGuildAgitFirePlaceEnable";
                    break;
                case 6030:      // 0x178F
                    result = "PktGuildAgitFirePlaceEnableResult";
                    break;
                case 6031:      // 0x1790
                    result = "PktGuildAgitFirePlaceEnableNotify";
                    break;
                case 6032:      // 0x1791
                    result = "PktGuildAgitLiquidCreate";
                    break;
                case 6033:      // 0x1792
                    result = "PktGuildAgitLiquidCreateResult";
                    break;
                case 6034:      // 0x1793
                    result = "PktGuildAgitLiquidCreateNotify";
                    break;
                case 6035:      // 0x1794
                    result = "PktOtherGuildAllianceChangeNotify";
                    break;
                case 6036:      // 0x1795
                    result = "PktGuildCastleDailyRewardGet";
                    break;
                case 6037:      // 0x1796
                    result = "PktGuildCastleDailyRewardGetResult";
                    break;
                case 6038:      // 0x1797
                    result = "PktGuildOrderNotify";
                    break;
                case 6039:      // 0x1798
                    result = "PktGuildWarehouseGrantByList";
                    break;
                case 6040:      // 0x1799
                    result = "PktGuildWarehouseGrantByListResult";
                    break;
                case 6041:      // 0x179A
                    result = "PktGuildCastleTypeSelect";
                    break;
                case 6042:      // 0x179B
                    result = "PktGuildCastleTypeSelectResult";
                    break;
                case 6043:      // 0x179C
                    result = "PktGuildCastleTypeSelectNotify";
                    break;
                case 6044:      // 0x179D
                    result = "PktGuildHostileWarEndSuggest";
                    break;
                case 6045:      // 0x179E
                    result = "PktGuildHostileWarEndSuggestResult";
                    break;
                case 6046:      // 0x179F
                    result = "PktGuildHostileWarEndAnswer";
                    break;
                case 6047:      // 0x17A0
                    result = "PktGuildHostileWarEndAnswerResult";
                    break;
                case 6048:      // 0x17A1
                    result = "PktGuildAgitQuestCompleteNotify";
                    break;
                case 6049:      // 0x17A2
                    result = "PktGuildAgitWishListRead";
                    break;
                case 6050:      // 0x17A3
                    result = "PktGuildAgitWishListReadResult";
                    break;
                case 6051:      // 0x17A4
                    result = "PktGuildCastleTypeSelectTimeNotify";
                    break;
                case 6052:      // 0x17A5
                    result = "PktGuildAgitWishGet";
                    break;
                case 6053:      // 0x17A6
                    result = "PktGuildAgitWishGetResult";
                    break;
                case 6054:      // 0x17A7
                    result = "PktGuildReJoinPenaltyTimeRead";
                    break;
                case 6055:      // 0x17A8
                    result = "PktGuildReJoinPenaltyTimeReadResult";
                    break;
                case 6056:      // 0x17A9
                    result = "PktGuildWantJoin";
                    break;
                case 6057:      // 0x17AA
                    result = "PktGuildWantJoinResult";
                    break;
                case 6058:      // 0x17AB
                    result = "PktGuildInviteListRead";
                    break;
                case 6059:      // 0x17AC
                    result = "PktGuildInviteListReadResult";
                    break;
                case 6060:      // 0x17AD
                    result = "PktGuildWantJoinListRead";
                    break;
                case 6061:      // 0x17AE
                    result = "PktGuildWantJoinListReadResult";
                    break;
                case 6062:      // 0x17AF
                    result = "PktGuildInviteCancel";
                    break;
                case 6063:      // 0x17B0
                    result = "PktGuildInviteCancelResult";
                    break;
                case 6064:      // 0x17B1
                    result = "PktGuildInviteReject";
                    break;
                case 6065:      // 0x17B2
                    result = "PktGuildInviteRejectResult";
                    break;
                case 6066:      // 0x17B3
                    result = "PktGuildMemberSelfIntroChange";
                    break;
                case 6067:      // 0x17B4
                    result = "PktGuildMemberSelfIntroChangeResult";
                    break;
                case 6068:      // 0x17B5
                    result = "PktGuildHostileWarRecordDetailRead";
                    break;
                case 6069:      // 0x17B6
                    result = "PktGuildHostileWarRecordDetailReadResult";
                    break;
                case 6070:      // 0x17B7
                    result = "PktGuildHostileWarRecordRankRead";
                    break;
                case 6071:      // 0x17B8
                    result = "PktGuildHostileWarRecordRankReadResult";
                    break;
                case 6072:      // 0x17B9
                    result = "PktGuildVoiceChatJoinNotify";
                    break;
                case 6073:      // 0x17BA
                    result = "PktGuildVoiceChatJoin";
                    break;
                case 6074:      // 0x17BB
                    result = "PktGuildVoiceChatJoinResult";
                    break;
                case 6075:      // 0x17BC
                    result = "PktGuildVoiceChatExit";
                    break;
                case 6076:      // 0x17BD
                    result = "PktGuildVoiceChatExitResult";
                    break;
                case 6077:      // 0x17BE
                    result = "PktGuildVoiceChatEmpowerment";
                    break;
                case 6078:      // 0x17BF
                    result = "PktGuildVoiceChatEmpowermentResult";
                    break;
                case 6079:      // 0x17C0
                    result = "PktGuildVoiceChatEmpowermentNotify";
                    break;
                case 6080:      // 0x17C1
                    result = "PktGuildAgitInviteRequest";
                    break;
                case 6081:      // 0x17C2
                    result = "PktGuildAgitInviteRequestResult";
                    break;
                case 6082:      // 0x17C3
                    result = "PktGuildAgitInviteRequestNotify";
                    break;
                case 6083:      // 0x17C4
                    result = "PktGuildAgitUsableAlliance";
                    break;
                case 6084:      // 0x17C5
                    result = "PktGuildAgitUsableAllianceResult";
                    break;
                case 6085:      // 0x17C6
                    result = "PktGuildAgitPixieSpawnStartNotify";
                    break;
                case 6086:      // 0x17C7
                    result = "PktGuildAgitPixieSpawnEndNotify";
                    break;
                case 6087:      // 0x17C8
                    result = "PktGuildAgitPixieRemainTimeNotify";
                    break;
                case 6088:      // 0x17C9
                    result = "PktGuildAgitPixieRewardNotify";
                    break;
                case 6089:      // 0x17CA
                    result = "PktGuildAgitPixieScoredNotify";
                    break;
                case 6090:      // 0x17CB
                    result = "PktGuildAgitFireplaceNotify";
                    break;
                case 7000:      // 0x1B59
                    result = "PktPetListRead";
                    break;
                case 7001:      // 0x1B5A
                    result = "PktPetListReadResult";
                    break;
                case 7002:      // 0x1B5B
                    result = "PktPetUnlockNotify";
                    break;
                case 7003:      // 0x1B5C
                    result = "PktPetItemUse";
                    break;
                case 7004:      // 0x1B5D
                    result = "PktPetItemUseResult";
                    break;
                case 7005:      // 0x1B5E
                    result = "PktPetEquip";
                    break;
                case 7006:      // 0x1B5F
                    result = "PktPetEquipResult";
                    break;
                case 7007:      // 0x1B60
                    result = "PktPetRiding";
                    break;
                case 7008:      // 0x1B61
                    result = "PktPetRidingResult";
                    break;
                case 7009:      // 0x1B62
                    result = "PktPetUpdateNotify";
                    break;
                case 7010:      // 0x1B63
                    result = "PktPetRidingNotify";
                    break;
                case 7011:      // 0x1B64
                    result = "PktPetActive";
                    break;
                case 7012:      // 0x1B65
                    result = "PktPetActiveResult";
                    break;
                case 7013:      // 0x1B66
                    result = "PktPetActivatableNotify";
                    break;
                case 7014:      // 0x1B67
                    result = "PktPetItemEquip";
                    break;
                case 7015:      // 0x1B68
                    result = "PktPetItemEquipResult";
                    break;
                case 7016:      // 0x1B69
                    result = "PktPetItemLevelUp";
                    break;
                case 7017:      // 0x1B6A
                    result = "PktPetItemLevelUpResult";
                    break;
                case 7018:      // 0x1B6B
                    result = "PktPetItemUpgrade";
                    break;
                case 7019:      // 0x1B6C
                    result = "PktPetItemUpgradeResult";
                    break;
                case 7020:      // 0x1B6D
                    result = "PktPetUpgrade";
                    break;
                case 7021:      // 0x1B6E
                    result = "PktPetUpgradeResult";
                    break;
                case 7022:      // 0x1B6F
                    result = "PktForcePetRidingNotify";
                    break;
                case 7023:      // 0x1B70
                    result = "PktPetItemEnchant";
                    break;
                case 7024:      // 0x1B71
                    result = "PktPetItemEnchantResult";
                    break;
                case 7025:      // 0x1B72
                    result = "PktPetEquipmentItemLike";
                    break;
                case 7026:      // 0x1B73
                    result = "PktPetEquipmentItemLikeResult";
                    break;
                case 7027:      // 0x1B74
                    result = "PktPetItemOptionChange";
                    break;
                case 7028:      // 0x1B75
                    result = "PktPetItemOptionChangeResult";
                    break;
                case 7100:      // 0x1BBD
                    result = "PktMeleeKillNotify";
                    break;
                case 7101:      // 0x1BBE
                    result = "PktMeleeRankingChangeNotify";
                    break;
                case 7200:      // 0x1C21
                    result = "PktOptionChange";
                    break;
                case 7201:      // 0x1C22
                    result = "PktOptionChangeResult";
                    break;
                case 7202:      // 0x1C23
                    result = "PktOptionDeckListRead";
                    break;
                case 7203:      // 0x1C24
                    result = "PktOptionDeckListReadResult";
                    break;
                case 7204:      // 0x1C25
                    result = "PktOptionDeckChange";
                    break;
                case 7205:      // 0x1C26
                    result = "PktOptionDeckChangeResult";
                    break;
                case 7300:      // 0x1C85
                    result = "PktBattlefieldInfo";
                    break;
                case 7301:      // 0x1C86
                    result = "PktBattlefieldInfoResult";
                    break;
                case 7302:      // 0x1C87
                    result = "PktBattlefieldOpenTimeListNotify";
                    break;
                case 7303:      // 0x1C88
                    result = "PktBattlefieldHistoryInfo";
                    break;
                case 7304:      // 0x1C89
                    result = "PktBattlefieldHistoryInfoResult";
                    break;
                case 7305:      // 0x1C8A
                    result = "PktBattlefieldPopup";
                    break;
                case 7306:      // 0x1C8B
                    result = "PktBattlefieldPopupResult";
                    break;
                case 7307:      // 0x1C8C
                    result = "PktBattlefieldEnter";
                    break;
                case 7308:      // 0x1C8D
                    result = "PktBattlefieldEnterResult";
                    break;
                case 7309:      // 0x1C8E
                    result = "PktBattlefieldEnterNotify";
                    break;
                case 7310:      // 0x1C8F
                    result = "PktBattlefieldEnterCancel";
                    break;
                case 7311:      // 0x1C90
                    result = "PktBattlefieldEnterCancelResult";
                    break;
                case 7312:      // 0x1C91
                    result = "PktBattlefieldEnterCancelNotify";
                    break;
                case 7313:      // 0x1C92
                    result = "PktBattlefieldEnterCompletedNotify";
                    break;
                case 7314:      // 0x1C93
                    result = "PktBattlefieldCountDownStartNotify";
                    break;
                case 7315:      // 0x1C94
                    result = "PktBattlefieldWorldEnter";
                    break;
                case 7316:      // 0x1C95
                    result = "PktBattlefieldWorldEnterResult";
                    break;
                case 7317:      // 0x1C96
                    result = "PktBattlefieldTimeNotify";
                    break;
                case 7318:      // 0x1C97
                    result = "PktBattlefieldEndNotify";
                    break;
                case 7319:      // 0x1C98
                    result = "PktBattlefieldExit";
                    break;
                case 7320:      // 0x1C99
                    result = "PktBattlefieldExitResult";
                    break;
                case 7321:      // 0x1C9A
                    result = "PktBattlefieldScoreChangeNotify";
                    break;
                case 7322:      // 0x1C9B
                    result = "PktBattlefieldOccupationProgressListNotify";
                    break;
                case 7323:      // 0x1C9C
                    result = "PktBattlefieldFreyaCarveStartNotify";
                    break;
                case 7324:      // 0x1C9D
                    result = "PktBattlefieldFreyaCarveSuccessNotify";
                    break;
                case 7325:      // 0x1C9E
                    result = "PktBattlefieldFreyaCarveFailNotify";
                    break;
                case 7326:      // 0x1C9F
                    result = "PktBattlefieldKillNotify";
                    break;
                case 7327:      // 0x1CA0
                    result = "PktBattlefieldOfHonorReconnectDataNotify";
                    break;
                case 7328:      // 0x1CA1
                    result = "PktBattlefieldDailyTimeEndNotify";
                    break;
                case 7329:      // 0x1CA2
                    result = "PktBattlefieldHallOfFameInfo";
                    break;
                case 7330:      // 0x1CA3
                    result = "PktBattlefieldHallOfFameInfoResult";
                    break;
                case 7331:      // 0x1CA4
                    result = "PktBattlefieldSeasonRewardNotify";
                    break;
                case 7332:      // 0x1CA5
                    result = "PktBattlefieldSeasonRewardRequest";
                    break;
                case 7333:      // 0x1CA6
                    result = "PktBattlefieldSeasonRewardRequestResult";
                    break;
                case 7334:      // 0x1CA7
                    result = "PktBattlefieldPartyMemberLeagueChangeNotify";
                    break;
                case 7335:      // 0x1CA8
                    result = "PktBattlefieldNextBuffCreateTimeNotify";
                    break;
                case 7800:      // 0x1E79
                    result = "PktCostumeSetHidden";
                    break;
                case 7801:      // 0x1E7A
                    result = "PktCostumeSetHiddenResult";
                    break;
                case 7802:      // 0x1E7B
                    result = "PktCostumeSetHiddenNotify";
                    break;
                case 7803:      // 0x1E7C
                    result = "PktCostumeShopListRead";
                    break;
                case 7804:      // 0x1E7D
                    result = "PktCostumeShopListReadResult";
                    break;
                case 7805:      // 0x1E7E
                    result = "PktCostumeShopBuy";
                    break;
                case 7806:      // 0x1E7F
                    result = "PktCostumeShopBuyResult";
                    break;
                case 9000:      // 0x2329
                    result = "PktGuildDungeonSupportRequest";
                    break;
                case 9001:      // 0x232A
                    result = "PktGuildDungeonSupportRequestResult";
                    break;
                case 9002:      // 0x232B
                    result = "PktGuildDungeonSupportCancel";
                    break;
                case 9003:      // 0x232C
                    result = "PktGuildDungeonSupportCancelResult";
                    break;
                case 9004:      // 0x232D
                    result = "PktGuildDungeonParticipate";
                    break;
                case 9005:      // 0x232E
                    result = "PktGuildDungeonParticipateResult";
                    break;
                case 9006:      // 0x232F
                    result = "PktGuildDungeonHelpResultNotify";
                    break;
                case 9007:      // 0x2330
                    result = "PktGuildDungeonHelpInfo";
                    break;
                case 9008:      // 0x2331
                    result = "PktGuildDungeonHelpInfoResult";
                    break;
                case 9009:      // 0x2332
                    result = "PktGuildDungeonHelpList";
                    break;
                case 9010:      // 0x2333
                    result = "PktGuildDungeonHelpListResult";
                    break;
                case 9500:      // 0x251D
                    result = "PktESportsContentsLockListRead";
                    break;
                case 9501:      // 0x251E
                    result = "PktESportsContentsLockListReadResult";
                    break;
                case 9502:      // 0x251F
                    result = "PktESportsMatchInfoNotify";
                    break;
                case 9503:      // 0x2520
                    result = "PktESportsMatchJoin";
                    break;
                case 9504:      // 0x2521
                    result = "PktESportsMatchJoinResult";
                    break;
                case 9600:      // 0x2581
                    result = "PktEventCheckBoardListRead";
                    break;
                case 9601:      // 0x2582
                    result = "PktEventCheckBoardListReadResult";
                    break;
                case 9602:      // 0x2583
                    result = "PktEventCheckBoardGet";
                    break;
                case 9603:      // 0x2584
                    result = "PktEventCheckBoardGetResult";
                    break;
                case 9604:      // 0x2585
                    result = "PktEventCheckBoardReset";
                    break;
                case 9605:      // 0x2586
                    result = "PktEventCheckBoardResetResult";
                    break;
                case 9606:      // 0x2587
                    result = "PktEventCheckBoardAccrueGet";
                    break;
                case 9607:      // 0x2588
                    result = "PktEventCheckBoardAccrueGetResult";
                    break;
                case 9608:      // 0x2589
                    result = "PktEventCheckBoardBadgeClear";
                    break;
                case 9609:      // 0x258A
                    result = "PktEventCheckBoardBadgeClearResult";
                    break;
                case 10000:     // 0x2711
                    result = "PktGuildEmblemChangeNotify";
                    break;
                case 10001:     // 0x2712
                    result = "PktGuildNicknameChangeNotify";
                    break;
                case 10002:     // 0x2713
                    result = "PktGuildMemberLoginNotify";
                    break;
                case 10003:     // 0x2714
                    result = "PktGuildDonateNotify";
                    break;
                case 10004:     // 0x2715
                    result = "PktGuildWarehouseGrantNotify";
                    break;
                case 10005:     // 0x2716
                    result = "PktGuildWarehouseGrantAllNotify";
                    break;
                case 10006:     // 0x2717
                    result = "PktGuildWarehouseGrantByListNotify";
                    break;
                case 10007:     // 0x2718
                    result = "PktGuildMarketGiftBuyNotify";
                    break;
                case 10008:     // 0x2719
                    result = "PktGuildRevenge";
                    break;
                case 10009:     // 0x271A
                    result = "PktGuildRevengeResult";
                    break;
                case 10010:     // 0x271B
                    result = "PktGuildRevengeNotify";
                    break;
                case 10011:     // 0x271C
                    result = "PktGuildRevengeAnswer";
                    break;
                case 10012:     // 0x271D
                    result = "PktGuildRevengeAnswerResult";
                    break;
                case 10013:     // 0x271E
                    result = "PktGuildHostilityRegisterNotify";
                    break;
                case 10014:     // 0x271F
                    result = "PktGuildHostileWarEndRefuseNotify";
                    break;
                case 10015:     // 0x2720
                    result = "PktGuildHostileWarEndNotify";
                    break;
                case 10016:     // 0x2721
                    result = "PktGuildHostileWarSurrenderNotify";
                    break;
                case 10017:     // 0x2722
                    result = "PktGuildBuffUpgradeNotify";
                    break;
                case 10018:     // 0x2723
                    result = "PktGuildMarketBuyNotify";
                    break;
                case 10019:     // 0x2724
                    result = "PktGuildDungeonResetNotify";
                    break;
                case 10020:     // 0x2725
                    result = "PktFortressSiegeEntryBidNotify";
                    break;
                case 10021:     // 0x2726
                    result = "PktCastleSiegeEntryBidNotify";
                    break;
                case 10022:     // 0x2727
                    result = "PktFortressSiegeEntryBidTimeNotify";
                    break;
                case 10023:     // 0x2728
                    result = "PktCastleSiegeEntryBidTimeNotify";
                    break;
                case 10024:     // 0x2729
                    result = "PktFortressSiegeJoinNotify";
                    break;
                case 10025:     // 0x272A
                    result = "PktCastleSiegeJoinNotify";
                    break;
                case 10026:     // 0x272B
                    result = "PktFortressSiegeStartNotify";
                    break;
                case 10027:     // 0x272C
                    result = "PktCastleSiegeStartNotify";
                    break;
                case 10028:     // 0x272D
                    result = "PktGuildFortressGiveUpNotify";
                    break;
                case 10029:     // 0x272E
                    result = "PktGuildCastleTypeSelectGuildNotify";
                    break;
                case 10030:     // 0x272F
                    result = "PktGuildAgitCrystalUpgradeNotify";
                    break;
                case 10031:     // 0x2730
                    result = "PktGuildAgitRelicPointUseNotify";
                    break;
                case 10032:     // 0x2731
                    result = "PktGuildAgitFirePlaceDisableNotify";
                    break;
                case 10100:     // 0x2775
                    result = "PktServerTransferListRead";
                    break;
                case 10101:     // 0x2776
                    result = "PktServerTransferListReadResult";
                    break;
                case 10102:     // 0x2777
                    result = "PktServerTransferBuyCheck";
                    break;
                case 10103:     // 0x2778
                    result = "PktServerTransferBuyCheckResult";
                    break;
                case 10104:     // 0x2779
                    result = "PktServerTransferInfoRead";
                    break;
                case 10105:     // 0x277A
                    result = "PktServerTransferInfoReadResult";
                    break;
                case 10106:     // 0x277B
                    result = "PktServerTransferItemUse";
                    break;
                case 10107:     // 0x277C
                    result = "PktServerTransferItemUseResult";
                    break;
                case 10108:     // 0x277D
                    result = "PktServerTransferReady";
                    break;
                case 10109:     // 0x277E
                    result = "PktServerTransferReadyResult";
                    break;
                case 10110:     // 0x277F
                    result = "PktServerTransferStart";
                    break;
                case 10111:     // 0x2780
                    result = "PktServerTransferStartResult";
                    break;
                case 10112:     // 0x2781
                    result = "PktServerTransferEnd";
                    break;
                case 10113:     // 0x2782
                    result = "PktServerTransferEndResult";
                    break;
                case 10114:     // 0x2783
                    result = "PktPlayerStorageListRead";
                    break;
                case 10115:     // 0x2784
                    result = "PktPlayerStorageListReadResult";
                    break;
                case 10116:     // 0x2785
                    result = "PktPlayerStorageExpand";
                    break;
                case 10117:     // 0x2786
                    result = "PktPlayerStorageExpandResult";
                    break;
                case 10118:     // 0x2787
                    result = "PktItemMoveToPlayerStorage";
                    break;
                case 10119:     // 0x2788
                    result = "PktItemMoveToPlayerStorageResult";
                    break;
                case 10120:     // 0x2789
                    result = "PktPlayerStorageItemMoveToBag";
                    break;
                case 10121:     // 0x278A
                    result = "PktPlayerStorageItemMoveToBagResult";
                    break;
                case 10122:     // 0x278B
                    result = "PktItemSpecialNotify";
                    break;
                case 10123:     // 0x278C
                    result = "PktBossItemDropNotify";
                    break;
                case 10300:     // 0x283D
                    result = "PktFreeSiegeRecruitCreate";
                    break;
                case 10301:     // 0x283E
                    result = "PktFreeSiegeRecruitCreateResult";
                    break;
                case 10302:     // 0x283F
                    result = "PktFreeSiegeRecruitCreateNotify";
                    break;
                case 10303:     // 0x2840
                    result = "PktFreeSiegeRecruitDisband";
                    break;
                case 10304:     // 0x2841
                    result = "PktFreeSiegeRecruitDisbandResult";
                    break;
                case 10305:     // 0x2842
                    result = "PktFreeSiegeRecruitDisbandNotify";
                    break;
                case 10306:     // 0x2843
                    result = "PktFreeSiegeRecruitExpel";
                    break;
                case 10307:     // 0x2844
                    result = "PktFreeSiegeRecruitExpelResult";
                    break;
                case 10308:     // 0x2845
                    result = "PktFreeSiegeRecruitExpelNotify";
                    break;
                case 10309:     // 0x2846
                    result = "PktFreeSiegeRecruitWithdraw";
                    break;
                case 10310:     // 0x2847
                    result = "PktFreeSiegeRecruitWithdrawResult";
                    break;
                case 10311:     // 0x2848
                    result = "PktFreeSiegeRecruitWithdrawNotify";
                    break;
                case 10312:     // 0x2849
                    result = "PktFreeSiegeRecruitChangeClass";
                    break;
                case 10313:     // 0x284A
                    result = "PktFreeSiegeRecruitChangeClassResult";
                    break;
                case 10314:     // 0x284B
                    result = "PktFreeSiegeRecruitChangeClassNotify";
                    break;
                case 10315:     // 0x284C
                    result = "PktFreeSiegeRecruitInvite";
                    break;
                case 10316:     // 0x284D
                    result = "PktFreeSiegeRecruitInviteResult";
                    break;
                case 10317:     // 0x284E
                    result = "PktFreeSiegeRecruitInviteNotify";
                    break;
                case 10318:     // 0x284F
                    result = "PktFreeSiegeRecruitInviteRefuse";
                    break;
                case 10319:     // 0x2850
                    result = "PktFreeSiegeRecruitInviteRefuseResult";
                    break;
                case 10320:     // 0x2851
                    result = "PktFreeSiegeRecruitInviteRefuseNotify";
                    break;
                case 10321:     // 0x2852
                    result = "PktFreeSiegeRecruitJoin";
                    break;
                case 10322:     // 0x2853
                    result = "PktFreeSiegeRecruitJoinResult";
                    break;
                case 10323:     // 0x2854
                    result = "PktFreeSiegeRecruitJoinNotify";
                    break;
                case 10324:     // 0x2855
                    result = "PktFreeSiegeRecruitReady";
                    break;
                case 10325:     // 0x2856
                    result = "PktFreeSiegeRecruitReadyResult";
                    break;
                case 10326:     // 0x2857
                    result = "PktFreeSiegeRecruitReadyNotify";
                    break;
                case 10327:     // 0x2858
                    result = "PktFreeSiegeEnterRequest";
                    break;
                case 10328:     // 0x2859
                    result = "PktFreeSiegeEnterRequestResult";
                    break;
                case 10329:     // 0x285A
                    result = "PktFreeSiegeEnterRequestNotify";
                    break;
                case 10330:     // 0x285B
                    result = "PktFreeSiegeRecruitDataNotify";
                    break;
                case 10331:     // 0x285C
                    result = "PktFreeSiegeEnterCancel";
                    break;
                case 10332:     // 0x285D
                    result = "PktFreeSiegeEnterCancelResult";
                    break;
                case 10333:     // 0x285E
                    result = "PktFreeSiegeEnterCancelNotify";
                    break;
                case 10334:     // 0x285F
                    result = "PktFreeSiegeStepNotify";
                    break;
                case 10335:     // 0x2860
                    result = "PktFreeSiegeInfo";
                    break;
                case 10336:     // 0x2861
                    result = "PktFreeSiegeInfoResult";
                    break;
                case 10337:     // 0x2862
                    result = "PktFreeSiegeSubMissionUpdateNotify";
                    break;
                case 10338:     // 0x2863
                    result = "PktFreeSiegeFinishNotify";
                    break;
                case 10339:     // 0x2864
                    result = "PktFreeSiegeChangeClass";
                    break;
                case 10340:     // 0x2865
                    result = "PktFreeSiegeChangeClassResult";
                    break;
                case 10341:     // 0x2866
                    result = "PktFreeSiegeLeaderState";
                    break;
                case 10342:     // 0x2867
                    result = "PktFreeSiegeLeaderStateResult";
                    break;
                case 10343:     // 0x2868
                    result = "PktFreeSiegeChangeLeaderNotify";
                    break;
                case 10344:     // 0x2869
                    result = "PktFreeSiegeEnterWaitNotify";
                    break;
                case 10345:     // 0x286A
                    result = "PktFreeSiegeSkillListNotify";
                    break;
                case 10346:     // 0x286B
                    result = "PktFreeSiegeTransferCoolTimeNotify";
                    break;
                case 10500:     // 0x2905
                    result = "PktObserverSiegeEnter";
                    break;
                case 10501:     // 0x2906
                    result = "PktObserverSiegeEnterResult";
                    break;
                case 10502:     // 0x2907
                    result = "PktObserverSiegeEnterNotify";
                    break;
                case 10503:     // 0x2908
                    result = "PktObserverParticipateInfo";
                    break;
                case 10504:     // 0x2909
                    result = "PktObserverParticipateInfoResult";
                    break;
                case 10505:     // 0x290A
                    result = "PktCommonSiegeGuildInfoRead";
                    break;
                case 10506:     // 0x290B
                    result = "PktCommonSiegeGuildInfoReadResult";
                    break;
                case 10507:     // 0x290C
                    result = "PktCommonSiegeFinishNotifyForObserver";
                    break;
                case 10700:     // 0x29CD
                    result = "PktTalismanDeckRead";
                    break;
                case 10701:     // 0x29CE
                    result = "PktTalismanDeckReadResult";
                    break;
                case 10702:     // 0x29CF
                    result = "PktTalismanEquip";
                    break;
                case 10703:     // 0x29D0
                    result = "PktTalismanEquipResult";
                    break;
                case 10704:     // 0x29D1
                    result = "PktTalismanUnequip";
                    break;
                case 10705:     // 0x29D2
                    result = "PktTalismanUnequipResult";
                    break;
                case 10706:     // 0x29D3
                    result = "PktTalismanAllUnequip";
                    break;
                case 10707:     // 0x29D4
                    result = "PktTalismanAllUnequipResult";
                    break;
                case 10708:     // 0x29D5
                    result = "PktTalismanBookRead";
                    break;
                case 10709:     // 0x29D6
                    result = "PktTalismanBookReadResult";
                    break;
                case 10710:     // 0x29D7
                    result = "PktTalismanBookRegistration";
                    break;
                case 10711:     // 0x29D8
                    result = "PktTalismanBookRegistrationResult";
                    break;
                case 10712:     // 0x29D9
                    result = "PktTalismanSetBookRead";
                    break;
                case 10713:     // 0x29DA
                    result = "PktTalismanSetBookReadResult";
                    break;
                case 10714:     // 0x29DB
                    result = "PktTalismanSetBookRegistration";
                    break;
                case 10715:     // 0x29DC
                    result = "PktTalismanSetBookRegistrationResult";
                    break;
                case 10716:     // 0x29DD
                    result = "PktTalismanSetBookLevelUp";
                    break;
                case 10717:     // 0x29DE
                    result = "PktTalismanSetBookLevelUpResult";
                    break;
                default:
                    result = "(InvalidPacket)";
                    break;
            }
            

            Console.Write("\tPacketType: " + result + "\n");
        }
    }
}
