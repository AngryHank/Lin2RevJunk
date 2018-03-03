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
                case 0x1:
                    result = "PktVersionresult";
                    break;
                case 0x2:
                    result = "PktLogin";
                    break;
                case 0x3:
                    result = "PktLoginresult";
                    break;
                case 0x4:
                    result = "PktLogout";
                    break;
                case 0x5:
                    result = "PktLogoutresult";
                    break;
                case 0x6:
                    result = "PktKeyChangeNotify";
                    break;
                case 0x7:
                    result = "PktKeyChanged";
                    break;
                case 0x8:
                    result = "PktKeyChangedresult";
                    break;
                case 0x9:
                    result = "PktWithdrawUser";
                    break;
                case 0xA:
                    result = "PktWithdrawUserresult";
                    break;
                case 0xB:
                    result = "PktTimeSync";
                    break;
                case 0xC:
                    result = "PktTimeSyncresult";
                    break;
                case 0xD:
                    result = "PktKickout";
                    break;
                case 0xE:
                    result = "PktKickoutNotify";
                    break;
                case 0xF:
                    result = "PktKickoutresult";
                    break;
                case 0x10:
                    result = "PktWaitingNumUpdateNotify";
                    break;
                case 0x11:
                    result = "PktWaitingOverNotify";
                    break;
                case 0x12:
                    result = "PktPlayerListRead";
                    break;
                case 0x13:
                    result = "PktPlayerListReadresult";
                    break;
                case 0x14:
                    result = "PktPlayerCreate";
                    break;
                case 0x15:
                    result = "PktPlayerCreateresult";
                    break;
                case 0x16:
                    result = "PktPlayerDelete";
                    break;
                case 0x17:
                    result = "PktPlayerDeleteresult";
                    break;
                case 0x18:
                    result = "PktPlayerSelect";
                    break;
                case 0x19:
                    result = "PktPlayerSelectresult";
                    break;
                case 0x1A:
                    result = "PktSystemTutorialStart";
                    break;
                case 0x1B:
                    result = "PktSystemTutorialStartresult";
                    break;
                case 0x1C:
                    result = "PktMoveToSelectCharacter";
                    break;
                case 0x1D:
                    result = "PktMoveToSelectCharacterresult";
                    break;
                case 0x1E:
                    result = "PktNoticeListRead";
                    break;
                case 0x1F:
                    result = "PktNoticeListReadresult";
                    break;
                case 0x20:
                    result = "PktPopupNoticeListRead";
                    break;
                case 0x21:
                    result = "PktPopupNoticeListReadresult";
                    break;
                case 0x22:
                    result = "PktPopupNoticeChangeNotify";
                    break;
                case 0x23:
                    result = "PktRollNoticeNotify";
                    break;
                case 0x24:
                    result = "PktConfineUserNotify";
                    break;
                case 0x25:
                    result = "PktConfineUserKick";
                    break;
                case 0x26:
                    result = "PktConfineUserKickresult";
                    break;
                case 0x27:
                    result = "PktNoticeNotify";
                    break;
                case 0x28:
                    result = "PktVersion2";
                    break;
                case 0x29:
                    result = "PktVersion2result";
                    break;
                case 0x2A:
                    result = "PktAccountLinkInfo";
                    break;
                case 0x2B:
                    result = "PktAccountLinkInforesult";
                    break;
                case 0x2C:
                    result = "PktAccountLinkReward";
                    break;
                case 0x2D:
                    result = "PktAccountLinkRewardresult";
                    break;
                case 0x2E:
                    result = "PktNicknameCheck";
                    break;
                case 0x2F:
                    result = "PktNicknameCheckresult";
                    break;
                case 0x64:
                    result = "PktWorldMoveReserve";
                    break;
                case 0x65:
                    result = "PktWorldMoveReserveresult";
                    break;
                case 0x66:
                    result = "PktWorldMoveStart";
                    break;
                case 0x67:
                    result = "PktWorldMoveStartresult";
                    break;
                case 0x68:
                    result = "PktWorldMoveFinish";
                    break;
                case 0x69:
                    result = "PktWorldMoveFinishresult";
                    break;
                case 0x6A:
                    result = "PktWorldChannelList";
                    break;
                case 0x6B:
                    result = "PktWorldChannelListresult";
                    break;
                case 0x6C:
                    result = "PktWorldChannelMoveReserve";
                    break;
                case 0x6D:
                    result = "PktWorldChannelMoveReserveresult";
                    break;
                case 0x6E:
                    result = "PktWorldLeave";
                    break;
                case 0x6F:
                    result = "PktWorldLeaveresult";
                    break;
                case 0x70:
                    result = "PktTeleportCastingStart";
                    break;
                case 0x71:
                    result = "PktTeleportCastingStartresult";
                    break;
                case 0x72:
                    result = "PktTeleportCastingStartNotify";
                    break;
                case 0x73:
                    result = "PktTeleportDepartNotify";
                    break;
                case 0x74:
                    result = "PktTeleportArriveNotify";
                    break;
                case 0x75:
                    result = "PktWorldInfoUpdateNotify";
                    break;
                case 0x76:
                    result = "PktMapPlayerPositionRead";
                    break;
                case 0x77:
                    result = "PktMapPlayerPositionReadresult";
                    break;
                case 0x78:
                    result = "PktMapWorldInfoRead";
                    break;
                case 0x79:
                    result = "PktMapWorldInfoReadresult";
                    break;
                case 0x7A:
                    result = "PktAutoMoveTeleport";
                    break;
                case 0x7B:
                    result = "PktAutoMoveTeleportresult";
                    break;
                case 0x7C:
                    result = "PktWorldExit";
                    break;
                case 0x7D:
                    result = "PktWorldExitresult";
                    break;
                case 0x7E:
                    result = "PktBossWorldEnterInfo";
                    break;
                case 0x7F:
                    result = "PktBossWorldEnterInforesult";
                    break;
                case 0x80:
                    result = "PktBossWorldClosingNotify";
                    break;
                case 0x81:
                    result = "PktBossStateRequest";
                    break;
                case 0x82:
                    result = "PktBossStateRequestresult";
                    break;
                case 0xC8:
                    result = "PktPlayerMove";
                    break;
                case 0xC9:
                    result = "PktPlayerMoveresult";
                    break;
                case 0xCA:
                    result = "PktPlayerMoveNotify";
                    break;
                case 0xCB:
                    result = "PktPlayerMoveListNotify";
                    PktPlayerMoveListNotify.Packet(packet.ToBytes());
                    break;
                case 0xCC:
                    result = "PktSightEnterNotify";
                    break;
                case 0xCD:
                    result = "PktSightLeaveNotify";
                    break;
                case 0xCE:
                    result = "PktNpcMoveNotify";
                    PktNpcMoveNotify.Packet(packet.ToBytes());
                    break;
                case 0xCF:
                    result = "PktCharacterDieNotify";
                    break;
                case 0xD0:
                    result = "PktActorDestroyNotify";
                    break;
                case 0xD1:
                    result = "PktPlayerRevive";
                    break;
                case 0xD2:
                    result = "PktPlayerReviveresult";
                    break;
                case 0xD3:
                    result = "PktPlayerReviveNotify";
                    break;
                case 0xD4:
                    result = "PktNpcSpawn";
                    break;
                case 0xD5:
                    result = "PktNpcSpawnresult";
                    break;
                case 0xD6:
                    result = "PktNpcCreateNotify";
                    break;
                case 0xD7:
                    result = "PktCharacterKill";
                    break;
                case 0xD8:
                    result = "PktCharacterKillresult";
                    break;
                case 0xD9:
                    result = "PktNpcAllKill";
                    break;
                case 0xDA:
                    result = "PktNpcAllKillresult";
                    break;
                case 0xDB:
                    result = "PktCharacterLevelUpNotify";
                    break;
                case 0xDC:
                    result = "PktCharacterMasteryLevelUpNotify";
                    break;
                case 0xDD:
                    result = "PktPlayerNameChange";
                    break;
                case 0xDE:
                    result = "PktPlayerNameChangeresult";
                    break;
                case 0xDF:
                    result = "PktCharacterStatChangeNotify";
                    break;
                case 0xE0:
                    result = "PktActorStateChange";
                    break;
                case 0xE1:
                    result = "PktActorStateChangeresult";
                    break;
                case 0xE2:
                    result = "PktActorStateChangeNotify";
                    break;
                case 0xE3:
                    result = "PktActorTeamChangeNotify";
                    break;
                case 0xE4:
                    result = "PktPlayerClassUpgrade";
                    break;
                case 0xE5:
                    result = "PktPlayerClassUpgraderesult";
                    break;
                case 0xE6:
                    result = "PktPlayerSocialActionInput";
                    break;
                case 0xE7:
                    result = "PktPlayerSocialActionInputresult";
                    break;
                case 0xE8:
                    result = "PktPlayerSocialActionNotify";
                    break;
                case 0xE9:
                    result = "PktPlayerSubClassListRead";
                    break;
                case 0xEA:
                    result = "PktPlayerSubClassListReadresult";
                    break;
                case 0xEB:
                    result = "PktPlayerClassChange";
                    break;
                case 0xEC:
                    result = "PktPlayerClassChangeresult";
                    break;
                case 0xED:
                    result = "PktGadgetCreateNotify";
                    break;
                case 0xEE:
                    result = "PktGadgetControlStart";
                    break;
                case 0xEF:
                    result = "PktGadgetControlStartresult";
                    break;
                case 0xF0:
                    result = "PktGadgetControlStartNotify";
                    break;
                case 0xF1:
                    result = "PktGadgetControl";
                    break;
                case 0xF2:
                    result = "PktGadgetControlresult";
                    break;
                case 0xF3:
                    result = "PktGadgetControlNotify";
                    break;
                case 0xF4:
                    result = "PktGadgetControlCancel";
                    break;
                case 0xF5:
                    result = "PktGadgetControlCancelresult";
                    break;
                case 0xF6:
                    result = "PktGadgetControlCancelNotify";
                    break;
                case 0xF7:
                    result = "PktGadgetActiveNotify";
                    break;
                case 0xF8:
                    result = "PktReconnectGadgetControlNotify";
                    break;
                case 0xF9:
                    result = "PktPlayerInfoRead";
                    break;
                case 0xFA:
                    result = "PktPlayerInfoReadresult";
                    break;
                case 0xFB:
                    result = "PktNpcSightShowNotify";
                    break;
                case 0xFC:
                    result = "PktPlayerStatDetailInfoRead";
                    break;
                case 0xFD:
                    result = "PktPlayerStatDetailInfoReadresult";
                    break;
                case 0xFE:
                    result = "PktPlayerGuildInfoRead";
                    break;
                case 0xFF:
                    result = "PktPlayerGuildInfoReadresult";
                    break;
                case 0x100:
                    result = "PktEliminationInsert";
                    break;
                case 0x101:
                    result = "PktEliminationInsertresult";
                    break;
                case 0x102:
                    result = "PktEliminationGet";
                    break;
                case 0x103:
                    result = "PktEliminationGetresult";
                    break;
                case 0x104:
                    result = "PktEliminationDel";
                    break;
                case 0x105:
                    result = "PktEliminationDelresult";
                    break;
                case 0x106:
                    result = "PktContentUnlockListRead";
                    break;
                case 0x107:
                    result = "PktContentUnlockListReadresult";
                    break;
                case 0x108:
                    result = "PktContentUnlockRequest";
                    break;
                case 0x109:
                    result = "PktContentUnlockRequestresult";
                    break;
                case 0x10A:
                    result = "PktMapAlarm";
                    break;
                case 0x10B:
                    result = "PktMapAlarmresult";
                    break;
                case 0x10C:
                    result = "PktMapAlarmNotify";
                    break;
                case 0x10D:
                    result = "PktPlayerBadgeNotify";
                    break;
                case 0x10E:
                    result = "PktBattleStartNotify";
                    break;
                case 0x10F:
                    result = "PktBattleEndNotify";
                    break;
                case 0x110:
                    result = "PktTargetActorChange";
                    break;
                case 0x111:
                    result = "PktTargetActorChangeresult";
                    break;
                case 0x112:
                    result = "PktNotify";
                    break;
                case 0x113:
                    result = "PktLevelUpGift";
                    break;
                case 0x114:
                    result = "PktLevelUpGiftresult";
                    break;
                case 0x115:
                    result = "PktUIOpenClose";
                    break;
                case 0x116:
                    result = "PktUIOpenCloseresult";
                    break;
                case 0x117:
                    result = "PktBossMonsterKillNotify";
                    break;
                case 0x118:
                    result = "PktPlayerGuildDungeonSupportListRead";
                    break;
                case 0x119:
                    result = "PktPlayerGuildDungeonSupportListReadresult";
                    break;
                case 0x11A:
                    result = "PktFieldBossExistNotify";
                    break;
                case 0x11B:
                    result = "PktFieldBossKillNotify";
                    break;
                case 0x11C:
                    result = "PktFieldBossItemLootNotify";
                    break;
                case 0x11D:
                    result = "PktExpDisplayNotify";
                    PktPktExpDisplayNotify.Packet(packet.ToBytes());
                    break;
                case 0x11E:
                    result = "PktPlayerSelfIntroChange";
                    break;
                case 0x11F:
                    result = "PktPlayerSelfIntroChangeresult";
                    break;
                case 0x12C:
                    result = "PktAchievementListRead";
                    break;
                case 0x12D:
                    result = "PktAchievementListReadresult";
                    break;
                case 0x12E:
                    result = "PktPeriodAchievementListRead";
                    break;
                case 0x12F:
                    result = "PktPeriodAchievementListReadresult";
                    break;
                case 0x130:
                    result = "PktAchievementCompletedNotify";
                    break;
                case 0x131:
                    result = "PktAchievementRewardGet";
                    break;
                case 0x132:
                    result = "PktAchievementRewardGetresult";
                    break;
                case 0x133:
                    result = "PktPeriodAchievementRewardGet";
                    break;
                case 0x134:
                    result = "PktPeriodAchievementRewardGetresult";
                    break;
                case 0x135:
                    result = "PktAchievementLevelRewardGet";
                    break;
                case 0x136:
                    result = "PktAchievementLevelRewardGetresult";
                    break;
                case 0x137:
                    result = "PktHeroicLevelUpNotify";
                    break;
                case 0x138:
                    result = "PktLeaderboardScoreUpdatedNotify";
                    break;
                case 0x139:
                    result = "PktAchievementCompleteListRead";
                    break;
                case 0x13A:
                    result = "PktAchievementCompleteListReadresult";
                    break;
                case 0x15E:
                    result = "PktDailyActivityListRead";
                    break;
                case 0x15F:
                    result = "PktDailyActivityListReadresult";
                    break;
                case 0x160:
                    result = "PktDailyActivityCompletedNotify";
                    break;
                case 0x161:
                    result = "PktDailyActivityRewardGet";
                    break;
                case 0x162:
                    result = "PktDailyActivityRewardGetresult";
                    break;
                case 0x163:
                    result = "PktDailyActivityPointRewardGet";
                    break;
                case 0x164:
                    result = "PktDailyActivityPointRewardGetresult";
                    break;
                case 0x190:
                    result = "PktRuneInfoRead";
                    break;
                case 0x191:
                    result = "PktRuneInfoReadresult";
                    break;
                case 0x192:
                    result = "PktRuneLevelUp";
                    break;
                case 0x193:
                    result = "PktRuneLevelUpresult";
                    break;
                case 0x1C2:
                    result = "PktMonsterBookListRead";
                    break;
                case 0x1C3:
                    result = "PktMonsterBookListReadresult";
                    PktMonsterBookListReadresult.Packet(packet.Clone().ToBytes());
                    PktMonsterBookListReadresultClean.Packet(packet.ToBytes());
                    break;
                case 0x1C4:
                    result = "PktMonsterCoreUse";
                    break;
                case 0x1C5:
                    result = "PktMonsterCoreUseresult";
                    break;
                case 0x1C6:
                    result = "PktMonsterCoreUseAll";
                    break;
                case 0x1C7:
                    result = "PktMonsterCoreUseAllresult";
                    break;
                case 0x1C8:
                    result = "PktMonsterBookGroupRewardGet";
                    break;
                case 0x1C9:
                    result = "PktMonsterBookGroupRewardGetresult";
                    break;
                case 0x1F4:
                    result = "PktRestRewardGet";
                    break;
                case 0x1F5:
                    result = "PktRestRewardGetresult";
                    break;
                case 0x1F6:
                    result = "PktRestRewardChangeNotify";
                    break;
                case 0x226:
                    result = "PktAttendanceRead";
                    break;
                case 0x227:
                    result = "PktAttendanceReadresult";
                    break;
                case 0x228:
                    result = "PktAttendanceAttend";
                    break;
                case 0x229:
                    result = "PktAttendanceAttendresult";
                    break;
                case 0x22A:
                    result = "PktAttendanceDailyGet";
                    break;
                case 0x22B:
                    result = "PktAttendanceDailyGetresult";
                    break;
                case 0x22C:
                    result = "PktAttendanceWeeklyGet";
                    break;
                case 0x22D:
                    result = "PktAttendanceWeeklyGetresult";
                    break;
                case 0x258:
                    result = "PktSkillCastingStart";
                    break;
                case 0x259:
                    result = "PktSkillCastingStartresult";
                    break;
                case 0x25A:
                    result = "PktSkillCastingStartNotify";
                    break;
                case 0x25B:
                    result = "PktSkillStart";
                    break;
                case 0x25C:
                    result = "PktSkillStartresult";
                    break;
                case 0x25D:
                    result = "PktSkillStartNotify";
                    break;
                case 0x25E:
                    result = "PktSkillRotate";
                    break;
                case 0x25F:
                    result = "PktSkillRotateresult";
                    break;
                case 0x260:
                    result = "PktSkillRotateNotify";
                    break;
                case 0x261:
                    result = "PktSkillEffectFire";
                    break;
                case 0x262:
                    result = "PktSkillEffectFireresult";
                    break;
                case 0x263:
                    result = "PktSkillHitNotify";
                    PktSkillHitNotify.Packet(packet.ToBytes());
                    break;
                case 0x264:
                    result = "PktSkillMissNotify";
                    break;
                case 0x265:
                    result = "PktSkillCoolTimeResetNotify";
                    break;
                case 0x266:
                    result = "PktProjectileCreateNotify";
                    break;
                case 0x267:
                    result = "PktProjectileMoveNotify";
                    break;
                case 0x268:
                    result = "PktProjectileHit";
                    break;
                case 0x269:
                    result = "PktProjectileHitresult";
                    break;
                case 0x26A:
                    result = "PktProjectileDestroyNotify";
                    break;
                case 0x26B:
                    result = "PktGroundObjectCreateNotify";
                    break;
                case 0x26C:
                    result = "PktGroundObjectDestroyNotify";
                    break;
                case 0x26D:
                    result = "PktBuffAddNotify";
                    break;
                case 0x26E:
                    result = "PktBuffRemoveNotify";
                    break;
                case 0x26F:
                    result = "PktBuffRemove";
                    break;
                case 0x270:
                    result = "PktBuffRemoveresult";
                    break;
                case 0x271:
                    result = "PktSkillListRead";
                    break;
                case 0x272:
                    result = "PktSkillListReadresult";
                    break;
                case 0x273:
                    result = "PktSkillUpgrade";
                    break;
                case 0x274:
                    result = "PktSkillUpgraderesult";
                    break;
                case 0x275:
                    result = "PktSkillDeckEquip";
                    break;
                case 0x276:
                    result = "PktSkillDeckEquipresult";
                    break;
                case 0x277:
                    result = "PktSkillBookUse";
                    break;
                case 0x278:
                    result = "PktSkillBookUseresult";
                    break;
                case 0x279:
                    result = "PktSkillAcquireNotify";
                    break;
                case 0x27A:
                    result = "PktSoulShotEnableChange";
                    break;
                case 0x27B:
                    result = "PktSoulShotEnableChangeresult";
                    break;
                case 0x27C:
                    result = "PktSoulShotEnableChangeNotify";
                    break;
                case 0x27D:
                    result = "PktSoulShotItemDeleteNotify";
                    break;
                case 0x27E:
                    result = "PktSkillCoolTimeNotify";
                    break;
                case 0x27F:
                    result = "PktSkillAutoRegistrationChange";
                    break;
                case 0x280:
                    result = "PktSkillAutoRegistrationChangeresult";
                    break;
                case 0x281:
                    result = "PktSkillAutoUseDeckChange";
                    break;
                case 0x282:
                    result = "PktSkillAutoUseDeckChangeresult";
                    break;
                case 0x2EE:
                    result = "PktChatChannelChange";
                    break;
                case 0x2EF:
                    result = "PktChatChannelChangeresult";
                    break;
                case 0x2F0:
                    result = "PktChatChannelChangeNotify";
                    break;
                case 0x2F1:
                    result = "PktChatChannelListRead";
                    break;
                case 0x2F2:
                    result = "PktChatChannelListReadresult";
                    break;
                case 0x2F3:
                    result = "PktChatChannelWrite";
                    break;
                case 0x2F4:
                    result = "PktChatChannelWriteresult";
                    break;
                case 0x2F5:
                    result = "PktChatFriendRoomListRead";
                    break;
                case 0x2F6:
                    result = "PktChatFriendRoomListReadresult";
                    break;
                case 0x2F7:
                    result = "PktChatFriendRoomGet";
                    break;
                case 0x2F8:
                    result = "PktChatFriendRoomGetresult";
                    break;
                case 0x2F9:
                    result = "PktChatFriendRoomCreateNotify";
                    break;
                case 0x2FA:
                    result = "PktChatFriendRoomLeave";
                    break;
                case 0x2FB:
                    result = "PktChatFriendRoomLeaveresult";
                    break;
                case 0x2FC:
                    result = "PktChatFriendRoomLeaveNotify";
                    break;
                case 0x2FD:
                    result = "PktChatFriendListRead";
                    break;
                case 0x2FE:
                    result = "PktChatFriendListReadresult";
                    break;
                case 0x2FF:
                    result = "PktChatFriendWrite";
                    break;
                case 0x300:
                    result = "PktChatFriendWriteresult";
                    break;
                case 0x301:
                    result = "PktChatFriendWriteNotify";
                    break;
                case 0x302:
                    result = "PktChatFriendMessageRead";
                    break;
                case 0x303:
                    result = "PktChatFriendMessageReadresult";
                    break;
                case 0x304:
                    result = "PktChatFriendMessageReadNotify";
                    break;
                case 0x305:
                    result = "PktChatGuildListRead";
                    break;
                case 0x306:
                    result = "PktChatGuildListReadresult";
                    break;
                case 0x307:
                    result = "PktChatGuildWrite";
                    break;
                case 0x308:
                    result = "PktChatGuildWriteresult";
                    break;
                case 0x309:
                    result = "PktChatGuildWriteNotify";
                    break;
                case 0x30A:
                    result = "PktChatGuildMessageRead";
                    break;
                case 0x30B:
                    result = "PktChatGuildMessageReadresult";
                    break;
                case 0x30C:
                    result = "PktChatSimpleRead";
                    break;
                case 0x30D:
                    result = "PktChatSimpleReadresult";
                    break;
                case 0x30E:
                    result = "PktChatWorldWrite";
                    break;
                case 0x30F:
                    result = "PktChatWorldWriteresult";
                    break;
                case 0x310:
                    result = "PktChatWorldWriteNotify";
                    break;
                case 0x311:
                    result = "PktChatPartyWrite";
                    break;
                case 0x312:
                    result = "PktChatPartyWriteresult";
                    break;
                case 0x313:
                    result = "PktChatPartyWriteNotify";
                    break;
                case 0x314:
                    result = "PktChatItemLootNotify";
                    break;
                case 0x315:
                    result = "PktSystemMessageShowNotify";
                    break;
                case 0x316:
                    result = "PktChatAddInfoRead";
                    break;
                case 0x317:
                    result = "PktChatAddInfoReadresult";
                    break;
                case 0x318:
                    result = "PktChatPromoListRead";
                    break;
                case 0x319:
                    result = "PktChatPromoListReadresult";
                    break;
                case 0x31A:
                    result = "PktChatPromoWrite";
                    break;
                case 0x31B:
                    result = "PktChatPromoWriteresult";
                    break;
                case 0x31C:
                    result = "PktChatBlockListRead";
                    break;
                case 0x31D:
                    result = "PktChatBlockListReadresult";
                    break;
                case 0x31E:
                    result = "PktChatBlockInsert";
                    break;
                case 0x31F:
                    result = "PktChatBlockInsertresult";
                    break;
                case 0x320:
                    result = "PktChatBlockDelete";
                    break;
                case 0x321:
                    result = "PktChatBlockDeleteresult";
                    break;
                case 0x352:
                    result = "PktBagListRead";
                    break;
                case 0x353:
                    result = "PktBagListReadresult";
                    PktBagListReadresult.Packet(packet.Clone());
                    PktBagListReadresultClean.Packet(packet);
                    break;
                case 0x354:
                    result = "PktEquipmentListRead";
                    break;
                case 0x355:
                    result = "PktEquipmentListReadresult";
                    break;
                case 0x356:
                    result = "PktItemUpdateNotify";
                    break;
                case 0x357:
                    result = "PktItemEquip";
                    break;
                case 0x358:
                    result = "PktItemEquipresult";
                    break;
                case 0x359:
                    result = "PktItemEquipNotify";
                    break;
                case 0x35A:
                    result = "PktItemUnequip";
                    break;
                case 0x35B:
                    result = "PktItemUnequipresult";
                    break;
                case 0x35C:
                    result = "PktItemUnequipAll";
                    break;
                case 0x35D:
                    result = "PktItemUnequipAllresult";
                    break;
                case 0x35E:
                    result = "PktItemUnequipNotify";
                    break;
                case 0x35F:
                    result = "PktItemLike";
                    break;
                case 0x360:
                    result = "PktItemLikeresult";
                    break;
                case 0x361:
                    result = "PktItemSell";
                    break;
                case 0x362:
                    result = "PktItemSellresult";
                    break;
                case 0x363:
                    result = "PktItemDecompose";
                    break;
                case 0x364:
                    result = "PktItemDecomposeresult";
                    break;
                case 0x365:
                    result = "PktItemLevelUp";
                    break;
                case 0x366:
                    result = "PktItemLevelUpresult";
                    break;
                case 0x367:
                    result = "PktItemLevelUpInSocket";
                    break;
                case 0x368:
                    result = "PktItemLevelUpInSocketresult";
                    break;
                case 0x369:
                    result = "PktItemLimit	break";
                    break;
                case 0x36A:
                    result = "PktItemLimit	breakresult";
                    break;
                case 0x36B:
                    result = "PktItemEnchant";
                    break;
                case 0x36C:
                    result = "PktItemEnchantresult";
                    break;
                case 0x36D:
                    result = "PktEquipmentItemChangeNotify";
                    break;
                case 0x36E:
                    result = "PktItemUpgrade";
                    break;
                case 0x36F:
                    result = "PktItemUpgraderesult";
                    break;
                case 0x370:
                    result = "PktItemUpgradeInSocket";
                    break;
                case 0x371:
                    result = "PktItemUpgradeInSocketresult";
                    break;
                case 0x372:
                    result = "PktItemCompose";
                    break;
                case 0x373:
                    result = "PktItemComposeresult";
                    break;
                case 0x374:
                    result = "PktItemOptionChange";
                    break;
                case 0x375:
                    result = "PktItemOptionChangeresult";
                    break;
                case 0x376:
                    result = "PktItemAbilityUpgrade";
                    break;
                case 0x377:
                    result = "PktItemAbilityUpgraderesult";
                    break;
                case 0x378:
                    result = "PktItemUseNotify";
                    break;
                case 0x379:
                    result = "PktItemUse";
                    break;
                case 0x37A:
                    result = "PktItemUseresult";
                    break;
                case 0x37B:
                    result = "PktItemCoolTimeResetNotyfy";
                    break;
                case 0x37C:
                    result = "PktSoulCrystalEquip";
                    break;
                case 0x37D:
                    result = "PktSoulCrystalEquipresult";
                    break;
                case 0x37E:
                    result = "PktSoulCrystalExtract";
                    break;
                case 0x37F:
                    result = "PktSoulCrystalExtractresult";
                    break;
                case 0x380:
                    result = "PktEquipedSoulCrystalSell";
                    break;
                case 0x381:
                    result = "PktEquipedSoulCrystalSellresult";
                    break;
                case 0x382:
                    result = "PktSoulShotCraft";
                    break;
                case 0x383:
                    result = "PktSoulShotCraftresult";
                    break;
                case 0x384:
                    result = "PktItemCraft";
                    break;
                case 0x385:
                    result = "PktItemCraftresult";
                    break;
                case 0x386:
                    result = "PktItemLootNotify";
                    break;
                case 0x387:
                    result = "PktBagExpand";
                    break;
                case 0x388:
                    result = "PktBagExpandresult";
                    break;
                case 0x389:
                    result = "PktBagExpandNotify";
                    break;
                case 0x38A:
                    result = "PktWarehouseListRead";
                    break;
                case 0x38B:
                    result = "PktWarehouseListReadresult";
                    break;
                case 0x38C:
                    result = "PktItemMoveToWarehouse";
                    break;
                case 0x38D:
                    result = "PktItemMoveToWarehouseresult";
                    break;
                case 0x38E:
                    result = "PktItemMoveToBag";
                    break;
                case 0x38F:
                    result = "PktItemMoveToBagresult";
                    break;
                case 0x390:
                    result = "PktWarehouseExpand";
                    break;
                case 0x391:
                    result = "PktWarehouseExpandresult";
                    break;
                case 0x392:
                    result = "PktEquipmentDeckChanageNotify";
                    break;
                case 0x393:
                    result = "PktActiveEquipmentDeckRead";
                    break;
                case 0x394:
                    result = "PktActiveEquipmentDeckReadresult";
                    break;
                case 0x395:
                    result = "PktElixirInfoRead";
                    break;
                case 0x396:
                    result = "PktElixirInfoReadresult";
                    break;
                case 0x397:
                    result = "PktElixirChangeNotify";
                    break;
                case 0x398:
                    result = "PktSoulCrystalAutoExtract";
                    break;
                case 0x399:
                    result = "PktSoulCrystalAutoExtractresult";
                    break;
                case 0x39A:
                    result = "PktSummonGemUse";
                    break;
                case 0x39B:
                    result = "PktSummonGemUseresult";
                    break;
                case 0x39C:
                    result = "PktEquipmentCraft";
                    break;
                case 0x39D:
                    result = "PktEquipmentCraftresult";
                    break;
                case 0x39E:
                    result = "PktEquipmentCraftStepComplete";
                    break;
                case 0x39F:
                    result = "PktEquipmentCraftStepCompleteresult";
                    break;
                case 0x3A0:
                    result = "PktItemBoxListRead";
                    break;
                case 0x3A1:
                    result = "PktItemBoxListReadresult";
                    break;
                case 0x3A2:
                    result = "PktItemCraftInfoRead";
                    break;
                case 0x3A3:
                    result = "PktItemCraftInfoReadresult";
                    break;
                case 0x3A4:
                    result = "PktSoulCrystalUpgrade";
                    break;
                case 0x3A5:
                    result = "PktSoulCrystalUpgraderesult";
                    break;
                case 0x3A6:
                    result = "PktSoulCrystalUpgradeInSocket";
                    break;
                case 0x3A7:
                    result = "PktSoulCrystalUpgradeInSocketresult";
                    break;
                case 0x3A8:
                    result = "PktItemDisassemble";
                    break;
                case 0x3A9:
                    result = "PktItemDisassembleresult";
                    break;
                case 0x3AA:
                    result = "PktItemUseNicknameChange";
                    break;
                case 0x3AB:
                    result = "PktItemUseNicknameChangeresult";
                    break;
                case 0x3AC:
                    result = "PktBattleDeckActivate";
                    break;
                case 0x3AD:
                    result = "PktBattleDeckActivateresult";
                    break;
                case 0x3AE:
                    result = "PktItemOptionChangeInSocket";
                    break;
                case 0x3AF:
                    result = "PktItemOptionChangeInSocketresult";
                    break;
                case 0x3E8:
                    result = "PktMailListRead";
                    break;
                case 0x3E9:
                    result = "PktMailListReadresult";
                    break;
                case 0x3EA:
                    result = "PktMailDelete";
                    break;
                case 0x3EB:
                    result = "PktMailDeleteresult";
                    break;
                case 0x3EC:
                    result = "PktMailDeleteAll";
                    break;
                case 0x3ED:
                    result = "PktMailDeleteAllresult";
                    break;
                case 0x3EE:
                    result = "PktMailRewardGet";
                    break;
                case 0x3EF:
                    result = "PktMailRewardGetresult";
                    break;
                case 0x3F0:
                    result = "PktMailRewardAllGet";
                    break;
                case 0x3F1:
                    result = "PktMailRewardAllGetresult";
                    break;
                case 0x3F2:
                    result = "PktMailReceiveNotify";
                    break;
                case 0x41A:
                    result = "PktQuestStart";
                    break;
                case 0x41B:
                    result = "PktQuestStartresult";
                    break;
                case 0x41C:
                    result = "PktQuestCancel";
                    break;
                case 0x41D:
                    result = "PktQuestCancelresult";
                    break;
                case 0x41E:
                    result = "PktQuestRestart";
                    break;
                case 0x41F:
                    result = "PktQuestRestartresult";
                    break;
                case 0x420:
                    result = "PktQuestUpdate";
                    break;
                case 0x421:
                    result = "PktQuestUpdateresult";
                    break;
                case 0x422:
                    result = "PktQuestUpdateNotify";
                    break;
                case 0x423:
                    result = "PktQuestGadgetControl";
                    break;
                case 0x424:
                    result = "PktQuestGadgetControlresult";
                    break;
                case 0x425:
                    result = "PktQuestGadgetControlNotify";
                    break;
                case 0x426:
                    result = "PktQuestFailNotify";
                    break;
                case 0x427:
                    result = "PktQuestComplete";
                    break;
                case 0x428:
                    result = "PktQuestCompleteresult";
                    break;
                case 0x429:
                    result = "PktQuestRevive";
                    break;
                case 0x42A:
                    result = "PktQuestReviveresult";
                    break;
                case 0x42B:
                    result = "PktQuestNpcSearch";
                    break;
                case 0x42C:
                    result = "PktQuestNpcSearchresult";
                    break;
                case 0x42D:
                    result = "PktQuestWaveStartNotify";
                    break;
                case 0x42E:
                    result = "PktCastleAndFortressListRead";
                    break;
                case 0x42F:
                    result = "PktCastleAndFortressListReadresult";
                    break;
                case 0x430:
                    result = "PktQuestShareRequestNotify";
                    break;
                case 0x431:
                    result = "PktQuestShareAcceptNotify";
                    break;
                case 0x432:
                    result = "PktQuestShare";
                    break;
                case 0x433:
                    result = "PktQuestShareresult";
                    break;
                case 0x434:
                    result = "PktSharedQuestAccept";
                    break;
                case 0x435:
                    result = "PktSharedQuestAcceptresult";
                    break;
                case 0x436:
                    result = "PktQuestActListRead";
                    break;
                case 0x437:
                    result = "PktQuestActListReadresult";
                    break;
                case 0x438:
                    result = "PktQuestActCompleteRewardGet";
                    break;
                case 0x439:
                    result = "PktQuestActCompleteRewardGetresult";
                    break;
                case 0x43A:
                    result = "PktQuestActChapterCompleteNotify";
                    break;
                case 0x43B:
                    result = "PktQuestScrollCompleteCountReset";
                    break;
                case 0x43C:
                    result = "PktQuestScrollCompleteCountResetresult";
                    break;
                case 0x43D:
                    result = "PktQuestTeleport";
                    break;
                case 0x43E:
                    result = "PktQuestTeleportresult";
                    break;
                case 0x47E:
                    result = "PktPartyInfoRead";
                    break;
                case 0x47F:
                    result = "PktPartyInfoReadresult";
                    break;
                case 0x480:
                    result = "PktPartySearchStart";
                    break;
                case 0x481:
                    result = "PktPartySearchStartresult";
                    break;
                case 0x482:
                    result = "PktPartySearchNotify";
                    break;
                case 0x483:
                    result = "PktPartySearchCancel";
                    break;
                case 0x484:
                    result = "PktPartySearchCancelresult";
                    break;
                case 0x485:
                    result = "PktPartyMemberSearchStart";
                    break;
                case 0x486:
                    result = "PktPartyMemberSearchStartresult";
                    break;
                case 0x487:
                    result = "PktPartyMemberSearchCancel";
                    break;
                case 0x488:
                    result = "PktPartyMemberSearchCancelresult";
                    break;
                case 0x489:
                    result = "PktPartyInvite";
                    break;
                case 0x48A:
                    result = "PktPartyInviteresult";
                    break;
                case 0x48B:
                    result = "PktPartyInviteNotify";
                    break;
                case 0x48C:
                    result = "PktPartyInviteAccept";
                    break;
                case 0x48D:
                    result = "PktPartyInviteAcceptresult";
                    break;
                case 0x48E:
                    result = "PktPartyInviteRefuse";
                    break;
                case 0x48F:
                    result = "PktPartyInviteRefuseresult";
                    break;
                case 0x490:
                    result = "PktPartyInviteRefuseNotify";
                    break;
                case 0x491:
                    result = "PktPartyJoinRequest";
                    break;
                case 0x492:
                    result = "PktPartyJoinRequestresult";
                    break;
                case 0x493:
                    result = "PktPartyJoinRequestNotify";
                    break;
                case 0x494:
                    result = "PktPartyJoinRequestCancel";
                    break;
                case 0x495:
                    result = "PktPartyJoinRequestCancelresult";
                    break;
                case 0x496:
                    result = "PktPartyJoinRequestCancelNotify";
                    break;
                case 0x497:
                    result = "PktPartyJoinAccept";
                    break;
                case 0x498:
                    result = "PktPartyJoinAcceptresult";
                    break;
                case 0x499:
                    result = "PktPartyJoinAcceptNotify";
                    break;
                case 0x49A:
                    result = "PktPartyJoinRefuse";
                    break;
                case 0x49B:
                    result = "PktPartyJoinRefuseresult";
                    break;
                case 0x49C:
                    result = "PktPartyJoinRefuseNotify";
                    break;
                case 0x49D:
                    result = "PktPartyCreateNotify";
                    break;
                case 0x49E:
                    result = "PktPartyMemberJoinNotify";
                    break;
                case 0x49F:
                    result = "PktPartyExpel";
                    break;
                case 0x4A0:
                    result = "PktPartyExpelresult";
                    break;
                case 0x4A1:
                    result = "PktPartyExpelNotify";
                    break;
                case 0x4A2:
                    result = "PktPartyWithdraw";
                    break;
                case 0x4A3:
                    result = "PktPartyWithdrawresult";
                    break;
                case 0x4A4:
                    result = "PktPartyWithdrawNotify";
                    break;
                case 0x4A5:
                    result = "PktPartyDisband";
                    break;
                case 0x4A6:
                    result = "PktPartyDisbandresult";
                    break;
                case 0x4A7:
                    result = "PktPartyDisbandNotify";
                    break;
                case 0x4A8:
                    result = "PktPartyMasterEntrust";
                    break;
                case 0x4A9:
                    result = "PktPartyMasterEntrustresult";
                    break;
                case 0x4AA:
                    result = "PktPartyMasterEntrustNotify";
                    break;
                case 0x4AB:
                    result = "PktPartyMuster";
                    break;
                case 0x4AC:
                    result = "PktPartyMusterresult";
                    break;
                case 0x4AD:
                    result = "PktPartyMusterNotify";
                    break;
                case 0x4AE:
                    result = "PktPartyMusterAccept";
                    break;
                case 0x4AF:
                    result = "PktPartyMusterAcceptresult";
                    break;
                case 0x4B0:
                    result = "PktPartyMusterRefuse";
                    break;
                case 0x4B1:
                    result = "PktPartyMusterRefuseresult";
                    break;
                case 0x4B2:
                    result = "PktPartyMusterRefuseNotify";
                    break;
                case 0x4B3:
                    result = "PktPartyMeet";
                    break;
                case 0x4B4:
                    result = "PktPartyMeetresult";
                    break;
                case 0x4B5:
                    result = "PktPartyCall";
                    break;
                case 0x4B6:
                    result = "PktPartyCallresult";
                    break;
                case 0x4B7:
                    result = "PktPartyCallNotify";
                    break;
                case 0x4B8:
                    result = "PktPartyMemberStatChangeNotify";
                    break;
                case 0x4B9:
                    result = "PktPartyMasterWorldMoveNotify";
                    break;
                case 0x4BA:
                    result = "PktPartyMemberDisconnectNotify";
                    break;
                case 0x4BB:
                    result = "PktPartyMemberReconnectNotify";
                    break;
                case 0x4BC:
                    result = "PktPartyNearPartyInfo";
                    break;
                case 0x4BD:
                    result = "PktPartyNearPartyInforesult";
                    break;
                case 0x4BE:
                    result = "PktPartyNearPlayerInfo";
                    break;
                case 0x4BF:
                    result = "PktPartyNearPlayerInforesult";
                    break;
                case 0x4C0:
                    result = "PktPartyTagSearch";
                    break;
                case 0x4C1:
                    result = "PktPartyTagSearchresult";
                    break;
                case 0x4C2:
                    result = "PktPartyTagChange";
                    break;
                case 0x4C3:
                    result = "PktPartyTagChangeresult";
                    break;
                case 0x4C4:
                    result = "PktPartyTempCreate";
                    break;
                case 0x4C5:
                    result = "PktPartyTempCreateresult";
                    break;
                case 0x4C6:
                    result = "PktPartyTempRegister";
                    break;
                case 0x4C7:
                    result = "PktPartyTempRegisterresult";
                    break;
                case 0x4C8:
                    result = "PktPartyCreate";
                    break;
                case 0x4C9:
                    result = "PktPartyCreateresult";
                    break;
                case 0x4CA:
                    result = "PktPartyMemberPosNotify";
                    break;
                case 0x4CB:
                    result = "PktPartyAutoEnterList";
                    break;
                case 0x4CC:
                    result = "PktPartyAutoEnterListresult";
                    break;
                case 0x4CD:
                    result = "PktPartyAutoEnter";
                    break;
                case 0x4CE:
                    result = "PktPartyAutoEnterresult";
                    break;
                case 0x4CF:
                    result = "PktPartyAutoEnterNotify";
                    break;
                case 0x4D0:
                    result = "PktPartyAutoEnterCancel";
                    break;
                case 0x4D1:
                    result = "PktPartyAutoEnterCancelresult";
                    break;
                case 0x4D2:
                    result = "PktPartyAutoEnterCancelNotify";
                    break;
                case 0x4D3:
                    result = "PktPartyAutoEnterStartNotify";
                    break;
                case 0x4D4:
                    result = "PktPartyAutoEnterAccept";
                    break;
                case 0x4D5:
                    result = "PktPartyAutoEnterAcceptresult";
                    break;
                case 0x4D6:
                    result = "PktPartyAutoEnterAcceptNotify";
                    break;
                case 0x4D7:
                    result = "PktPartyAutoEnterAcceptTimeOutNotify";
                    break;
                case 0x4D8:
                    result = "PktPartyAutoEnterAcceptImpossibleAreaNotify";
                    break;
                case 0x4D9:
                    result = "PktPartyDungeonEnter";
                    break;
                case 0x4DA:
                    result = "PktPartyDungeonEnterresult";
                    break;
                case 0x4DB:
                    result = "PktPartyDungeonEnterStartNotify";
                    break;
                case 0x4DC:
                    result = "PktPartyDungeonEnterCancelNotify";
                    break;
                case 0x4DD:
                    result = "PktPartyDungeonEnterAccept";
                    break;
                case 0x4DE:
                    result = "PktPartyDungeonEnterAcceptresult";
                    break;
                case 0x4DF:
                    result = "PktPartyDungeonEnterAcceptNotify";
                    break;
                case 0x4E0:
                    result = "PktPartyDungeonEnterNotify";
                    break;
                case 0x4E1:
                    result = "PktPartyInfoNotify";
                    break;
                case 0x4E2:
                    result = "PktPartyVoiceChatJoinNotify";
                    break;
                case 0x4E3:
                    result = "PktPartyVoiceChatJoin";
                    break;
                case 0x4E4:
                    result = "PktPartyVoiceChatJoinresult";
                    break;
                case 0x4E5:
                    result = "PktPartyVoiceChatExit";
                    break;
                case 0x4E6:
                    result = "PktPartyVoiceChatExitresult";
                    break;
                case 0x4E7:
                    result = "PktPartyMemberWorldMoveNotify";
                    break;
                case 0x4E8:
                    result = "PktPartyNameChange";
                    break;
                case 0x4E9:
                    result = "PktPartyNameChangeresult";
                    break;
                case 0x4EA:
                    result = "PktPartyNameChangeNotify";
                    break;
                case 0x4EB:
                    result = "PktPartyInviteIndicate";
                    break;
                case 0x4EC:
                    result = "PktPartyInviteIndicateresult";
                    break;
                case 0x4ED:
                    result = "PktPartyEmblemChangeNotify";
                    break;
                case 0x514:
                    result = "PktFriendListRead";
                    break;
                case 0x515:
                    result = "PktFriendListReadresult";
                    break;
                case 0x516:
                    result = "PktFriendInviteSendListRead";
                    break;
                case 0x517:
                    result = "PktFriendInviteSendListReadresult";
                    break;
                case 0x518:
                    result = "PktFriendInviterListRead";
                    break;
                case 0x519:
                    result = "PktFriendInviterListReadresult";
                    break;
                case 0x51A:
                    result = "PktFriendInvite";
                    break;
                case 0x51B:
                    result = "PktFriendInviteresult";
                    break;
                case 0x51C:
                    result = "PktFriendInviteNotify";
                    break;
                case 0x51D:
                    result = "PktFriendInviteCancel";
                    break;
                case 0x51E:
                    result = "PktFriendInviteCancelresult";
                    break;
                case 0x51F:
                    result = "PktFriendInviteCancelAll";
                    break;
                case 0x520:
                    result = "PktFriendInviteCancelAllresult";
                    break;
                case 0x521:
                    result = "PktFriendInviteCancelNotify";
                    break;
                case 0x522:
                    result = "PktFriendAccept";
                    break;
                case 0x523:
                    result = "PktFriendAcceptresult";
                    break;
                case 0x524:
                    result = "PktFriendAcceptNotify";
                    break;
                case 0x525:
                    result = "PktFriendRefuse";
                    break;
                case 0x526:
                    result = "PktFriendRefuseresult";
                    break;
                case 0x527:
                    result = "PktFriendAcceptAll";
                    break;
                case 0x528:
                    result = "PktFriendAcceptAllresult";
                    break;
                case 0x529:
                    result = "PktFriendRefuseAll";
                    break;
                case 0x52A:
                    result = "PktFriendRefuseAllresult";
                    break;
                case 0x52B:
                    result = "PktFriendDelete";
                    break;
                case 0x52C:
                    result = "PktFriendDeleteresult";
                    break;
                case 0x52D:
                    result = "PktFriendSearch";
                    break;
                case 0x52E:
                    result = "PktFriendSearchresult";
                    break;
                case 0x52F:
                    result = "PktFriendLike";
                    break;
                case 0x530:
                    result = "PktFriendLikeresult";
                    break;
                case 0x531:
                    result = "PktFriendRecommendationListRead";
                    break;
                case 0x532:
                    result = "PktFriendRecommendationListReadresult";
                    break;
                case 0x533:
                    result = "PktFriendRecommendationListRefresh";
                    break;
                case 0x534:
                    result = "PktFriendRecommendationListRefreshresult";
                    break;
                case 0x535:
                    result = "PktFriendRecommendationInviteAll";
                    break;
                case 0x536:
                    result = "PktFriendRecommendationInviteAllresult";
                    break;
                case 0x537:
                    result = "PktFriendListAutoManager";
                    break;
                case 0x538:
                    result = "PktFriendListAutoManagerresult";
                    break;
                case 0x539:
                    result = "PktFriendGreet";
                    break;
                case 0x53A:
                    result = "PktFriendGreetresult";
                    break;
                case 0x53B:
                    result = "PktFriendGreetAll";
                    break;
                case 0x53C:
                    result = "PktFriendGreetAllresult";
                    break;
                case 0x53D:
                    result = "PktFriendGreetNotify";
                    break;
                case 0x53E:
                    result = "PktFriendGreetReceive";
                    break;
                case 0x53F:
                    result = "PktFriendGreetReceiveresult";
                    break;
                case 0x540:
                    result = "PktFriendGreetReceiveAll";
                    break;
                case 0x541:
                    result = "PktFriendGreetReceiveAllresult";
                    break;
                case 0x578:
                    result = "PktGuildInfoRead";
                    break;
                case 0x579:
                    result = "PktGuildInfoReadresult";
                    PktGuildInfoReadresult.Packet(packet.Clone().ToBytes());
                    PktGuildInfoReadresultClean.Packet(packet.ToBytes());
                    break;
                case 0x57A:
                    result = "PktGuildMemberListRead";
                    break;
                case 0x57B:
                    result = "PktGuildMemberListReadresult";
                    PktGuildMemberListReadresultClean.Packet(packet);
                    break;
                case 0x57C:
                    result = "PktGuildCreate";
                    break;
                case 0x57D:
                    result = "PktGuildCreateresult";
                    break;
                case 0x57E:
                    result = "PktGuildCreateCheck";
                    break;
                case 0x57F:
                    result = "PktGuildCreateCheckresult";
                    break;
                case 0x580:
                    result = "PktGuildInvite";
                    break;
                case 0x581:
                    result = "PktGuildInviteresult";
                    break;
                case 0x582:
                    result = "PktGuildInviteNotify";
                    break;
                case 0x583:
                    result = "PktGuildInviteAccept";
                    break;
                case 0x584:
                    result = "PktGuildInviteAcceptresult";
                    break;
                case 0x585:
                    result = "PktGuildInviteRefuse";
                    break;
                case 0x586:
                    result = "PktGuildInviteRefuseresult";
                    break;
                case 0x587:
                    result = "PktGuildInviteRefuseNotify";
                    break;
                case 0x588:
                    result = "PktGuildJoinRequest";
                    break;
                case 0x589:
                    result = "PktGuildJoinRequestresult";
                    break;
                case 0x58A:
                    result = "PktGuildJoinRequestNotify";
                    break;
                case 0x58B:
                    result = "PktGuildJoinRequestListRead";
                    break;
                case 0x58C:
                    result = "PktGuildJoinRequestListReadresult";
                    break;
                case 0x58D:
                    result = "PktGuildReceivedJoinRequestListRead";
                    break;
                case 0x58E:
                    result = "PktGuildReceivedJoinRequestListReadresult";
                    break;
                case 0x58F:
                    result = "PktGuildJoinRequestCancel";
                    break;
                case 0x590:
                    result = "PktGuildJoinRequestCancelresult";
                    break;
                case 0x591:
                    result = "PktGuildJoinAccept";
                    break;
                case 0x592:
                    result = "PktGuildJoinAcceptresult";
                    break;
                case 0x593:
                    result = "PktGuildJoinAcceptAll";
                    break;
                case 0x594:
                    result = "PktGuildJoinAcceptAllresult";
                    break;
                case 0x595:
                    result = "PktGuildJoinAcceptNotify";
                    break;
                case 0x596:
                    result = "PktGuildMemberJoinNotify";
                    break;
                case 0x597:
                    result = "PktGuildJoinRefuse";
                    break;
                case 0x598:
                    result = "PktGuildJoinRefuseresult";
                    break;
                case 0x599:
                    result = "PktGuildJoinRefuseAll";
                    break;
                case 0x59A:
                    result = "PktGuildJoinRefuseAllresult";
                    break;
                case 0x59B:
                    result = "PktGuildJoinRefuseNotify";
                    break;
                case 0x59C:
                    result = "PktGuildExpel";
                    break;
                case 0x59D:
                    result = "PktGuildExpelresult";
                    break;
                case 0x59E:
                    result = "PktGuildExpelNotify";
                    break;
                case 0x59F:
                    result = "PktGuildWithdraw";
                    break;
                case 0x5A0:
                    result = "PktGuildWithdrawresult";
                    break;
                case 0x5A1:
                    result = "PktGuildWithdrawNotify";
                    break;
                case 0x5A2:
                    result = "PktGuildDisband";
                    break;
                case 0x5A3:
                    result = "PktGuildDisbandresult";
                    break;
                case 0x5A4:
                    result = "PktGuildDisbandNotify";
                    break;
                case 0x5A5:
                    result = "PktGuildMasterEntrust";
                    break;
                case 0x5A6:
                    result = "PktGuildMasterEntrustresult";
                    break;
                case 0x5A7:
                    result = "PktGuildMasterEntrustNotify";
                    break;
                case 0x5A8:
                    result = "PktGuildMemberGradeChange";
                    break;
                case 0x5A9:
                    result = "PktGuildMemberGradeChangeresult";
                    break;
                case 0x5AA:
                    result = "PktGuildMemberGradeChangeNotify";
                    break;
                case 0x5AB:
                    result = "PktGuildIntroductionChange";
                    break;
                case 0x5AC:
                    result = "PktGuildIntroductionChangeresult";
                    break;
                case 0x5AD:
                    result = "PktGuildNoticeChange";
                    break;
                case 0x5AE:
                    result = "PktGuildNoticeChangeresult";
                    break;
                case 0x5AF:
                    result = "PktGuildNameChange";
                    break;
                case 0x5B0:
                    result = "PktGuildNameChangeresult";
                    break;
                case 0x5B1:
                    result = "PktGuildEmblemChange";
                    break;
                case 0x5B2:
                    result = "PktGuildEmblemChangeresult";
                    break;
                case 0x5B3:
                    result = "PktGuildRecommendationListRead";
                    break;
                case 0x5B4:
                    result = "PktGuildRecommendationListReadresult";
                    PktGuildRecommendationListReadresult.Packet(packet.Clone().ToBytes());
                    PktGuildRecommendationListReadresult.Packet(packet.ToBytes());
                    break;
                case 0x5B5:
                    result = "PktGuildRankingListRead";
                    break;
                case 0x5B6:
                    result = "PktGuildRankingListReadresult";
                    break;
                case 0x5B7:
                    result = "PktGuildRecommendationListRefresh";
                    break;
                case 0x5B8:
                    result = "PktGuildRecommendationListRefreshresult";
                    break;
                case 0x5B9:
                    result = "PktGuildMemberRecommendationListRead";
                    break;
                case 0x5BA:
                    result = "PktGuildMemberRecommendationListReadresult";
                    break;
                case 0x5BB:
                    result = "PktGuildDonate";
                    break;
                case 0x5BC:
                    result = "PktGuildDonateresult";
                    break;
                case 0x5BD:
                    result = "PktGuildLevelUpNotify";
                    break;
                case 0x5BE:
                    result = "PktGuildImpeach";
                    break;
                case 0x5BF:
                    result = "PktGuildImpeachresult";
                    break;
                case 0x5C0:
                    result = "PktGuildImpeachNotify";
                    break;
                case 0x5C1:
                    result = "PktGuildAttend";
                    break;
                case 0x5C2:
                    result = "PktGuildAttendresult";
                    break;
                case 0x5C3:
                    result = "PktGuildAttendRewardGet";
                    break;
                case 0x5C4:
                    result = "PktGuildAttendRewardGetresult";
                    break;
                case 0x5C5:
                    result = "PktGuildGreet";
                    break;
                case 0x5C6:
                    result = "PktGuildGreetresult";
                    break;
                case 0x5C7:
                    result = "PktGuildGreetAll";
                    break;
                case 0x5C8:
                    result = "PktGuildGreetAllresult";
                    break;
                case 0x5C9:
                    result = "PktGuildGreetingReceivedNotify";
                    break;
                case 0x5CA:
                    result = "PktGuildGreetReceive";
                    break;
                case 0x5CB:
                    result = "PktGuildGreetReceiveresult";
                    break;
                case 0x5CC:
                    result = "PktGuildGreetReceiveAll";
                    break;
                case 0x5CD:
                    result = "PktGuildGreetReceiveAllresult";
                    break;
                case 0x5CE:
                    result = "PktGuildRecordListRead";
                    break;
                case 0x5CF:
                    result = "PktGuildRecordListReadresult";
                    PktGuildRecordListReadresultClean.Packet(packet.ToBytes());
                    break;
                case 0x5D0:
                    result = "PktGuildWarehouseListRead";
                    break;
                case 0x5D1:
                    result = "PktGuildWarehouseListReadresult";
                    break;
                case 0x5D2:
                    result = "PktGuildWarehouseGrant";
                    break;
                case 0x5D3:
                    result = "PktGuildWarehouseGrantresult";
                    break;
                case 0x5D4:
                    result = "PktGuildWarehouseGrantAllMember";
                    break;
                case 0x5D5:
                    result = "PktGuildWarehouseGrantAllMemberresult";
                    break;
                case 0x5D6:
                    result = "PktGuildBuffUpgrade";
                    break;
                case 0x5D7:
                    result = "PktGuildBuffUpgraderesult";
                    break;
                case 0x5D8:
                    result = "PktGuildBuffListRead";
                    break;
                case 0x5D9:
                    result = "PktGuildBuffListReadresult";
                    break;
                case 0x5DA:
                    result = "PktGuildBuffBuy";
                    break;
                case 0x5DB:
                    result = "PktGuildBuffBuyresult";
                    break;
                case 0x5DC:
                    result = "PktGuildMarketListRead";
                    break;
                case 0x5DD:
                    result = "PktGuildMarketListReadresult";
                    break;
                case 0x5DE:
                    result = "PktGuildMarketBuy";
                    break;
                case 0x5DF:
                    result = "PktGuildMarketBuyresult";
                    break;
                case 0x5E0:
                    result = "PktGuildMarketGiftBuy";
                    break;
                case 0x5E1:
                    result = "PktGuildMarketGiftBuyresult";
                    break;
                case 0x5E2:
                    result = "PktGuildCastleUpgrade";
                    break;
                case 0x5E3:
                    result = "PktGuildCastleUpgraderesult";
                    break;
                case 0x5E4:
                    result = "PktGuildSearch";
                    break;
                case 0x5E5:
                    result = "PktGuildSearchresult";
                    break;
                case 0x5E6:
                    result = "PktGuildAllianceListRead";
                    break;
                case 0x5E7:
                    result = "PktGuildAllianceListReadresult";
                    break;
                case 0x5E8:
                    result = "PktGuildAllianceInviterListRead";
                    break;
                case 0x5E9:
                    result = "PktGuildAllianceInviterListReadresult";
                    break;
                case 0x5EA:
                    result = "PktGuildAllianceInvite";
                    break;
                case 0x5EB:
                    result = "PktGuildAllianceInviteresult";
                    break;
                case 0x5EC:
                    result = "PktGuildAllianceInvitationCancel";
                    break;
                case 0x5ED:
                    result = "PktGuildAllianceInvitationCancelresult";
                    break;
                case 0x5EE:
                    result = "PktGuildAllianceAccept";
                    break;
                case 0x5EF:
                    result = "PktGuildAllianceAcceptresult";
                    break;
                case 0x5F0:
                    result = "PktGuildAllianceChangeNotify";
                    break;
                case 0x5F1:
                    result = "PktGuildHostilityChangeNotify";
                    break;
                case 0x5F2:
                    result = "PktGuildAllianceRefuse";
                    break;
                case 0x5F3:
                    result = "PktGuildAllianceRefuseresult";
                    break;
                case 0x5F4:
                    result = "PktGuildAllianceRefuseAll";
                    break;
                case 0x5F5:
                    result = "PktGuildAllianceRefuseAllresult";
                    break;
                case 0x5F6:
                    result = "PktGuildAllianceDelete";
                    break;
                case 0x5F7:
                    result = "PktGuildAllianceDeleteresult";
                    break;
                case 0x5F8:
                    result = "PktGuildHostilityListRead";
                    break;
                case 0x5F9:
                    result = "PktGuildHostilityListReadresult";
                    break;
                case 0x5FA:
                    result = "PktGuildHostilityRegister";
                    break;
                case 0x5FB:
                    result = "PktGuildHostilityRegisterresult";
                    break;
                case 0x5FC:
                    result = "PktGuildHostilityWarDeclare";
                    break;
                case 0x5FD:
                    result = "PktGuildHostilityWarDeclareresult";
                    break;
                case 0x5FE:
                    result = "PktGuildHostilityUnregister";
                    break;
                case 0x5FF:
                    result = "PktGuildHostilityUnregisterresult";
                    break;
                case 0x600:
                    result = "PktGuildHostileWarSurrender";
                    break;
                case 0x601:
                    result = "PktGuildHostileWarSurrenderresult";
                    break;
                case 0x602:
                    result = "PktGuildHostileWarRecordListRead";
                    break;
                case 0x603:
                    result = "PktGuildHostileWarRecordListReadresult";
                    break;
                case 0x604:
                    result = "PktGuildAchievementListRead";
                    break;
                case 0x605:
                    result = "PktGuildAchievementListReadresult";
                    break;
                case 0x606:
                    result = "PktGuildAchievementRewardGet";
                    break;
                case 0x607:
                    result = "PktGuildAchievementRewardGetresult";
                    break;
                case 0x608:
                    result = "PktGuildJoinRequestOptionChange";
                    break;
                case 0x609:
                    result = "PktGuildJoinRequestOptionChangeresult";
                    break;
                case 0x60A:
                    result = "PktGuildInfoReadChangeNotify";
                    break;
                case 0x60B:
                    result = "PktGuildBadgeNotify";
                    break;
                case 0x60C:
                    result = "PktGuildHostileWarBroadcastNotify";
                    break;
                case 0x60D:
                    result = "PktGuildNoticeRead";
                    break;
                case 0x60E:
                    result = "PktGuildNoticeReadresult";
                    break;
                case 0x60F:
                    result = "PktGuildPromotionLimitTimeNotify";
                    break;
                case 0x610:
                    result = "PktGuildDungeonEnter";
                    break;
                case 0x611:
                    result = "PktGuildDungeonEnterresult";
                    break;
                case 0x612:
                    result = "PktGuildDungeonEnterNotify";
                    break;
                case 0x613:
                    result = "PktGuildDungeonList";
                    break;
                case 0x614:
                    result = "PktGuildDungeonListresult";
                    break;
                case 0x615:
                    result = "PktGuildDungeonReset";
                    break;
                case 0x616:
                    result = "PktGuildDungeonResetresult";
                    break;
                case 0x617:
                    result = "PktGuildDungeonInviteRequest";
                    break;
                case 0x618:
                    result = "PktGuildDungeonInviteRequestresult";
                    break;
                case 0x619:
                    result = "PktGuildDungeonInviteRequestNotify";
                    break;
                case 0x61A:
                    result = "PktGuildDungeonInviteAccept";
                    break;
                case 0x61B:
                    result = "PktGuildDungeonInviteAcceptresult";
                    break;
                case 0x61C:
                    result = "PktGuildDungeonDamageNotify";
                    break;
                case 0x61D:
                    result = "PktGuildDungeon	resultNotify";
                    break;
                case 0x61E:
                    result = "PktGuildDungeonKickoutNotify";
                    break;
                case 0x61F:
                    result = "PktGuildMasterBuffNotify";
                    break;
                case 0x620:
                    result = "PktGuildNameChangeNotify";
                    break;
                case 0x621:
                    result = "PktGuildMemberKillNotify";
                    break;
                case 0x622:
                    result = "PktGuildInfoNotify";
                    break;
                case 0x623:
                    result = "PktGuildAgitBuy";
                    break;
                case 0x624:
                    result = "PktGuildAgitBuyresult";
                    break;
                case 0x625:
                    result = "PktGuildAgitUpgrade";
                    break;
                case 0x626:
                    result = "PktGuildAgitUpgraderesult";
                    break;
                case 0x627:
                    result = "PktGuildAgitCrystalUpgrade";
                    break;
                case 0x628:
                    result = "PktGuildAgitCrystalUpgraderesult";
                    break;
                case 0x629:
                    result = "PktGuildAgitInfo";
                    break;
                case 0x62A:
                    result = "PktGuildAgitInforesult";
                    break;
                case 0x62B:
                    result = "PktGuildAgitOpen";
                    break;
                case 0x62C:
                    result = "PktGuildAgitOpenresult";
                    break;
                case 0x62D:
                    result = "PktGuildAgitExpel";
                    break;
                case 0x62E:
                    result = "PktGuildAgitExpelresult";
                    break;
                case 0x62F:
                    result = "PktGuildAgitExpelNotify";
                    break;
                case 0x630:
                    result = "PktGuildAgitEnter";
                    break;
                case 0x631:
                    result = "PktGuildAgitEnterresult";
                    break;
                case 0x632:
                    result = "PktGuildAgitLeave";
                    break;
                case 0x633:
                    result = "PktGuildAgitLeaveresult";
                    break;
                case 0x634:
                    result = "PktGuildAgitQuestList";
                    break;
                case 0x635:
                    result = "PktGuildAgitQuestListresult";
                    break;
                case 0x636:
                    result = "PktGuildAgitQuestAccept";
                    break;
                case 0x637:
                    result = "PktGuildAgitQuestAcceptresult";
                    break;
                case 0x638:
                    result = "PktGuildAgitQuestComplete";
                    break;
                case 0x639:
                    result = "PktGuildAgitQuestCompleteresult";
                    break;
                case 0x63A:
                    result = "PktGuildAgitQuestCompleteImmediately";
                    break;
                case 0x63B:
                    result = "PktGuildAgitQuestCompleteImmediatelyresult";
                    break;
                case 0x63C:
                    result = "PktGuildPromoListRead";
                    break;
                case 0x63D:
                    result = "PktGuildPromoListReadresult";
                    break;
                case 0x63E:
                    result = "PktGuildCommunityOpen";
                    break;
                case 0x63F:
                    result = "PktGuildCommunityOpenresult";
                    break;
                case 0x640:
                    result = "PktCastleSiegeInfoRead";
                    break;
                case 0x641:
                    result = "PktCastleSiegeInfoReadresult";
                    break;
                case 0x642:
                    result = "PktCastleSiegeEnter";
                    break;
                case 0x643:
                    result = "PktCastleSiegeEnterresult";
                    break;
                case 0x644:
                    result = "PktCastleSiegeEnterNotify";
                    break;
                case 0x645:
                    result = "PktCastleSiegeInfoNotify";
                    break;
                case 0x646:
                    result = "PktCastleSiegeStateChangeNotify";
                    break;
                case 0x647:
                    result = "PktCastleSiegeGuildInfoRead";
                    break;
                case 0x648:
                    result = "PktCastleSiegeGuildInfoReadresult";
                    break;
                case 0x649:
                    result = "PktCastleSiegeFinishNotify";
                    break;
                case 0x64A:
                    result = "PktCastleSiegeRetreatNotify";
                    break;
                case 0x64B:
                    result = "PktCastleSiegeHolyArtifactHpChangeNotify";
                    break;
                case 0x64C:
                    result = "PktCastleSiegeHolyArtifactImprintNotify";
                    break;
                case 0x64D:
                    result = "PktCastleSiegeEventNotify";
                    break;
                case 0x64E:
                    result = "PktCastleSiegeLeave";
                    break;
                case 0x64F:
                    result = "PktCastleSiegeLeaveresult";
                    break;
                case 0x650:
                    result = "PktCastleSiegeEntryBid";
                    break;
                case 0x651:
                    result = "PktCastleSiegeEntryBidresult";
                    break;
                case 0x652:
                    result = "PktCastleSiegeEntryBidCancel";
                    break;
                case 0x653:
                    result = "PktCastleSiegeEntryBidCancelresult";
                    break;
                case 0x654:
                    result = "PktCastleSiegeEntryChangeNotify";
                    break;
                case 0x655:
                    result = "PktCastleSiegeFestivalInfoRead";
                    break;
                case 0x656:
                    result = "PktCastleSiegeFestivalInfoReadresult";
                    break;
                case 0x657:
                    result = "PktCastleSiegeFestivalLotteryBuy";
                    break;
                case 0x658:
                    result = "PktCastleSiegeFestivalLotteryBuyresult";
                    break;
                case 0x659:
                    result = "PktCastleSiegeFestivalLotteryRewardGet";
                    break;
                case 0x65A:
                    result = "PktCastleSiegeFestivalLotteryRewardGetresult";
                    break;
                case 0x65B:
                    result = "PktCastleSiegeGuildAlarm";
                    break;
                case 0x65C:
                    result = "PktCastleSiegeGuildAlarmresult";
                    break;
                case 0x65D:
                    result = "PktCastleSiegeGuildAlarmNotify";
                    break;
                case 0x65E:
                    result = "PktCommonSiegeKillComboNotify";
                    break;
                case 0x65F:
                    result = "PktCommonSiegeOccupyBuffNotify";
                    break;
                case 0x660:
                    result = "PktCommonSiegeDestroyedActorNotify";
                    break;
                case 0x661:
                    result = "PktCastleOccupyGuildInfo";
                    break;
                case 0x662:
                    result = "PktCastleOccupyGuildInforesult";
                    break;
                case 0x663:
                    result = "PktCastleSiegePrevRecord";
                    break;
                case 0x664:
                    result = "PktCastleSiegePrevRecordresult";
                    break;
                case 0x665:
                    result = "PktCastleSiegeHistoryList";
                    break;
                case 0x666:
                    result = "PktCastleSiegeHistoryListresult";
                    break;
                case 0x667:
                    result = "PktCastleSiegePreseasonInfo";
                    break;
                case 0x668:
                    result = "PktCastleSiegePreseasonInforesult";
                    break;
                case 0x6A4:
                    result = "PktFortressSiegeInfoRead";
                    break;
                case 0x6A5:
                    result = "PktFortressSiegeInfoReadresult";
                    break;
                case 0x6A6:
                    result = "PktFortressSiegeEntryBid";
                    break;
                case 0x6A7:
                    result = "PktFortressSiegeEntryBidresult";
                    break;
                case 0x6A8:
                    result = "PktFortressSiegeEntryBidCancel";
                    break;
                case 0x6A9:
                    result = "PktFortressSiegeEntryBidCancelresult";
                    break;
                case 0x6AA:
                    result = "PktFortressSiegeEntryChangeNotify";
                    break;
                case 0x6AB:
                    result = "PktFortressSiegeEnter";
                    break;
                case 0x6AC:
                    result = "PktFortressSiegeEnterresult";
                    break;
                case 0x6AD:
                    result = "PktFortressSiegeEnterNotify";
                    break;
                case 0x6AE:
                    result = "PktFortressSiegeInfoNotify";
                    break;
                case 0x6AF:
                    result = "PktFortressSiegeStateChangeNotify";
                    break;
                case 0x6B0:
                    result = "PktFortressSiegeGuildInfoRead";
                    break;
                case 0x6B1:
                    result = "PktFortressSiegeGuildInfoReadresult";
                    break;
                case 0x6B2:
                    result = "PktFortressSiegeFinishNotify";
                    break;
                case 0x6B3:
                    result = "PktFortressSiegeRetreatNotify";
                    break;
                case 0x6B4:
                    result = "PktFortressSiegeHolyArtifactHpChangeNotify";
                    break;
                case 0x6B5:
                    result = "PktFortressSiegeHolyArtifactImprintNotify";
                    break;
                case 0x6B6:
                    result = "PktFortressSiegeEventNotify";
                    break;
                case 0x6B7:
                    result = "PktFortressSiegeLeave";
                    break;
                case 0x6B8:
                    result = "PktFortressSiegeLeaveresult";
                    break;
                case 0x6B9:
                    result = "PktFortressOccupyGuildInfo";
                    break;
                case 0x6BA:
                    result = "PktFortressOccupyGuildInforesult";
                    break;
                case 0x6BB:
                    result = "PktFortressSiegePrevRecord";
                    break;
                case 0x6BC:
                    result = "PktFortressSiegePrevRecordresult";
                    break;
                case 0x6BD:
                    result = "PktFortressSiegeHistoryList";
                    break;
                case 0x6BE:
                    result = "PktFortressSiegeHistoryListresult";
                    break;
                case 0x708:
                    result = "PktAuctionHouseSearchListRead";
                    break;
                case 0x709:
                    result = "PktAuctionHouseSearchListReadresult";
                    break;
                case 0x70A:
                    result = "PktAuctionHouseItemDetailView";
                    break;
                case 0x70B:
                    result = "PktAuctionHouseItemDetailViewresult";
                    break;
                case 0x70C:
                    result = "PktAuctionHouseBuy";
                    break;
                case 0x70D:
                    result = "PktAuctionHouseBuyresult";
                    break;
                case 0x70E:
                    result = "PktAuctionHouseSellingListRead";
                    break;
                case 0x70F:
                    result = "PktAuctionHouseSellingListReadresult";
                    break;
                case 0x710:
                    result = "PktAuctionHouseSellingRegister";
                    break;
                case 0x711:
                    result = "PktAuctionHouseSellingRegisterresult";
                    break;
                case 0x712:
                    result = "PktAuctionHouseSellingCancel";
                    break;
                case 0x713:
                    result = "PktAuctionHouseSellingCancelresult";
                    break;
                case 0x714:
                    result = "PktAuctionHouseSelling	resultGet";
                    break;
                case 0x715:
                    result = "PktAuctionHouseSelling	resultGetresult";
                    break;
                case 0x716:
                    result = "PktAuctionHouseSelling	resultGetAll";
                    break;
                case 0x717:
                    result = "PktAuctionHouseSelling	resultGetAllresult";
                    break;
                case 0x718:
                    result = "PktAuctionHouseRecordListRead";
                    break;
                case 0x719:
                    result = "PktAuctionHouseRecordListReadresult";
                    break;
                case 0x71A:
                    result = "PktAuctionHouseAveragePriceGet";
                    break;
                case 0x71B:
                    result = "PktAuctionHouseAveragePriceGetresult";
                    break;
                case 0x71C:
                    result = "PktAuctionHouseFavoritesListRead";
                    break;
                case 0x71D:
                    result = "PktAuctionHouseFavoritesListReadresult";
                    break;
                case 0x71E:
                    result = "PktAuctionHouseFavoritesRegister";
                    break;
                case 0x71F:
                    result = "PktAuctionHouseFavoritesRegisterresult";
                    break;
                case 0x720:
                    result = "PktAuctionHouseFavoritesOnSaleNotify";
                    break;
                case 0x721:
                    result = "PktAuctionHouseSellingRegisterAgain";
                    break;
                case 0x722:
                    result = "PktAuctionHouseSellingRegisterAgainresult";
                    break;
                case 0x723:
                    result = "PktAuctionHouseGetEnabled";
                    break;
                case 0x724:
                    result = "PktAuctionHouseGetEnabledresult";
                    break;
                case 0x76C:
                    result = "PktShopItemListRead";
                    break;
                case 0x76D:
                    result = "PktShopItemListReadresult";
                    break;
                case 0x76E:
                    result = "PktShopItemBuy";
                    break;
                case 0x76F:
                    result = "PktShopItemBuyresult";
                    break;
                case 0x770:
                    result = "PktFixedChargeNotify";
                    break;
                case 0x771:
                    result = "PktFixedChargeInfoNotify";
                    break;
                case 0x772:
                    result = "PktFixedChargeDetail";
                    break;
                case 0x773:
                    result = "PktFixedChargeDetailresult";
                    break;
                case 0x774:
                    result = "PktFixedChargeBuy";
                    break;
                case 0x775:
                    result = "PktFixedChargeBuyresult";
                    break;
                case 0x776:
                    result = "PktFixedChargeTopazGet";
                    break;
                case 0x777:
                    result = "PktFixedChargeTopazGetresult";
                    break;
                case 0x778:
                    result = "PktFixedChargeDiamondGet";
                    break;
                case 0x779:
                    result = "PktFixedChargeDiamondGetresult";
                    break;
                case 0x77A:
                    result = "PktFixedChargeYesterdayDiamondGet";
                    break;
                case 0x77B:
                    result = "PktFixedChargeYesterdayDiamondGetresult";
                    break;
                case 0x77C:
                    result = "PktPensionTypeNotify";
                    break;
                case 0x77D:
                    result = "PktPensionTypeAchievementCompleteNotify";
                    break;
                case 0x77E:
                    result = "PktPensionTypeDetail";
                    break;
                case 0x77F:
                    result = "PktPensionTypeDetailresult";
                    break;
                case 0x780:
                    result = "PktPensionTypeBuy";
                    break;
                case 0x781:
                    result = "PktPensionTypeBuyresult";
                    break;
                case 0x782:
                    result = "PktPensionTypeRewardGet";
                    break;
                case 0x783:
                    result = "PktPensionTypeRewardGetresult";
                    break;
                case 0x784:
                    result = "PktSmartPopupNotify";
                    break;
                case 0x785:
                    result = "PktSmartPopupClose";
                    break;
                case 0x786:
                    result = "PktSmartPopupCloseresult";
                    break;
                case 0x787:
                    result = "PktDailyAdenaNotify";
                    break;
                case 0x788:
                    result = "PktDailyAdenaInfoNotify";
                    break;
                case 0x789:
                    result = "PktDailyAdenaDetail";
                    break;
                case 0x78A:
                    result = "PktDailyAdenaDetailresult";
                    break;
                case 0x78B:
                    result = "PktDailyAdenaBuy";
                    break;
                case 0x78C:
                    result = "PktDailyAdenaBuyresult";
                    break;
                case 0x78D:
                    result = "PktDailyAdenaDiamondGet";
                    break;
                case 0x78E:
                    result = "PktDailyAdenaDiamondGetresult";
                    break;
                case 0x78F:
                    result = "PktDailyAdenaRewardGet";
                    break;
                case 0x790:
                    result = "PktDailyAdenaRewardGetresult";
                    break;
                case 0x791:
                    result = "PktTimeShopListRead";
                    break;
                case 0x792:
                    result = "PktTimeShopListReadresult";
                    break;
                case 0x793:
                    result = "PktTimeShopListNotify";
                    break;
                case 0x794:
                    result = "PktShopRewardListRead";
                    break;
                case 0x795:
                    result = "PktShopRewardListReadresult";
                    break;
                case 0x796:
                    result = "PktShopRewardGet";
                    break;
                case 0x797:
                    result = "PktShopRewardGetresult";
                    break;
                case 0x798:
                    result = "PktShopRewardNotify";
                    break;
                case 0x7D0:
                    result = "PktDungeonListRead";
                    break;
                case 0x7D1:
                    result = "PktDungeonListReadresult";
                    break;
                case 0x7D2:
                    result = "PktDungeonEnter";
                    break;
                case 0x7D3:
                    result = "PktDungeonEnterresult";
                    break;
                case 0x7D4:
                    result = "PktDungeonExit";
                    break;
                case 0x7D5:
                    result = "PktDungeonExitresult";
                    break;
                case 0x7D6:
                    result = "PktDungeonGiveUp";
                    break;
                case 0x7D7:
                    result = "PktDungeonGiveUpresult";
                    break;
                case 0x7D8:
                    result = "PktDungeonSweep";
                    break;
                case 0x7D9:
                    result = "PktDungeonSweepresult";
                    break;
                case 0x7DA:
                    result = "PktDungeon	resultNotify";
                    break;
                case 0x7DB:
                    result = "PktDungeonStateNotify";
                    break;
                case 0x7DC:
                    result = "PktDungeonEndTimeNotify";
                    break;
                case 0x7DD:
                    result = "PktDungeonStartTimeNotify";
                    break;
                case 0x7DE:
                    result = "PktDungeonScoreChangeNotify";
                    break;
                case 0x7DF:
                    result = "PktDungeonReviveInfoNotify";
                    break;
                case 0x7E0:
                    result = "PktGatheringNotify";
                    break;
                case 0x7E1:
                    result = "PktDungeonQuestSweep";
                    break;
                case 0x7E2:
                    result = "PktDungeonQuestSweepresult";
                    break;
                case 0x7E3:
                    result = "PktDungeonQuestRewardGet";
                    break;
                case 0x7E4:
                    result = "PktDungeonQuestRewardGetresult";
                    break;
                case 0x7E5:
                    result = "PktDungeonQuestPointRewardGet";
                    break;
                case 0x7E6:
                    result = "PktDungeonQuestPointRewardGetresult";
                    break;
                case 0x7E7:
                    result = "PktDungeonHotTimeCharge";
                    break;
                case 0x7E8:
                    result = "PktDungeonHotTimeChargeresult";
                    break;
                case 0x7E9:
                    result = "PktDungeonQuestNotify";
                    break;
                case 0x7EA:
                    result = "PktDungeonQuestCompleteNotify";
                    break;
                case 0x7EB:
                    result = "PktDungeonHotTimeNotify";
                    break;
                case 0x7EC:
                    result = "PktDungeonFreeCountBuy";
                    break;
                case 0x7ED:
                    result = "PktDungeonFreeCountBuyresult";
                    break;
                case 0x7EE:
                    result = "PktEnchantScrollDungeonStateNotify";
                    break;
                case 0x7EF:
                    result = "PktEnchantScrollDungeonInfoNotify";
                    break;
                case 0x7F0:
                    result = "PktDungeonReconnectNotify";
                    break;
                case 0x7F1:
                    result = "PktEnchantScrollDungeonReconnectMoreInfoNotify";
                    break;
                case 0x7F2:
                    result = "PktSummonStoneDungeonStateNotify";
                    break;
                case 0x7F3:
                    result = "PktSummonStoneDungeonInfoNotify";
                    break;
                case 0x7F4:
                    result = "PktSummonStoneDungeonReconnectMoreInfoNotify";
                    break;
                case 0x7F5:
                    result = "PktDungeonBonusRewardNotify";
                    break;
                case 0x834:
                    result = "PktPvpInfoRead";
                    break;
                case 0x835:
                    result = "PktPvpInfoReadresult";
                    break;
                case 0x836:
                    result = "PktPvpTargetListRefresh";
                    break;
                case 0x837:
                    result = "PktPvpTargetListRefreshresult";
                    break;
                case 0x838:
                    result = "PktPvpStartCheck";
                    break;
                case 0x839:
                    result = "PktPvpStartCheckresult";
                    break;
                case 0x83A:
                    result = "PktPvpStart";
                    break;
                case 0x83B:
                    result = "PktPvpStartresult";
                    break;
                case 0x83C:
                    result = "PktPvpStartNotify";
                    break;
                case 0x83D:
                    result = "PktPvpRecordListRead";
                    break;
                case 0x83E:
                    result = "PktPvpRecordListReadresult";
                    break;
                case 0x83F:
                    result = "PktPvpRankingListRead";
                    break;
                case 0x840:
                    result = "PktPvpRankingListReadresult";
                    break;
                case 0x841:
                    result = "PktPvpLeave";
                    break;
                case 0x842:
                    result = "PktPvpLeaveresult";
                    break;
                case 0x843:
                    result = "PktPvpRewardGet";
                    break;
                case 0x844:
                    result = "PktPvpRewardGetresult";
                    break;
                case 0x845:
                    result = "PktPvpCountDownStartNotify";
                    break;
                case 0x846:
                    result = "PktPvpTimeNotify";
                    break;
                case 0x847:
                    result = "PktPvpEndNotify";
                    break;
                case 0x848:
                    result = "PktPvpHonorRankUpNotify";
                    break;
                case 0x849:
                    result = "PktPvpRankingChangeNotify";
                    break;
                case 0x84A:
                    result = "PktPkStatus";
                    break;
                case 0x84B:
                    result = "PktPkStatusresult";
                    break;
                case 0x84C:
                    result = "PktPkStatusNotify";
                    break;
                case 0x84D:
                    result = "PktPkAttackStateNotify";
                    break;
                case 0x84E:
                    result = "PktPkPointNotify";
                    break;
                case 0x84F:
                    result = "PktPlayerKilledNotify";
                    break;
                case 0x850:
                    result = "PktPvpBattleStart";
                    break;
                case 0x851:
                    result = "PktPvpBattleStartresult";
                    break;
                case 0x852:
                    result = "PktPkPointMonsterKillCount";
                    break;
                case 0x853:
                    result = "PktPkPointMonsterKillCountresult";
                    break;
                case 0x898:
                    result = "PktClassTransferQuestStart";
                    break;
                case 0x899:
                    result = "PktClassTransferQuestStartresult";
                    break;
                case 0x89A:
                    result = "PktClassTransferQuestListRead";
                    break;
                case 0x89B:
                    result = "PktClassTransferQuestListReadresult";
                    break;
                case 0x89C:
                    result = "PktClassTransferQuestRewardGet";
                    break;
                case 0x89D:
                    result = "PktClassTransferQuestRewardGetresult";
                    break;
                case 0x89E:
                    result = "PktClassTransfer";
                    break;
                case 0x89F:
                    result = "PktClassTransferresult";
                    break;
                case 0x8A0:
                    result = "PktClassTransferableNotify";
                    break;
                case 0x8A1:
                    result = "PktClassTransferQuestUpdateNotify";
                    break;
                case 0x8A2:
                    result = "PktClassTransferQuestCompleteNotify";
                    break;
                case 0x8A3:
                    result = "PktClassTransferCheatNotify";
                    break;
                case 0x8FC:
                    result = "PktGuideQuestListRead";
                    break;
                case 0x8FD:
                    result = "PktGuideQuestListReadresult";
                    break;
                case 0x8FE:
                    result = "PktGuideQuestRewardGet";
                    break;
                case 0x8FF:
                    result = "PktGuideQuestRewardGetresult";
                    break;
                case 0x900:
                    result = "PktGuideQuestUpdateNotify";
                    break;
                case 0x901:
                    result = "PktGuideQuestCompleteNotify";
                    break;
                case 0x902:
                    result = "PktGuideQuestCheatNotify";
                    break;
                case 0x903:
                    result = "PktGuideQuestActivityTimeRenew";
                    break;
                case 0x904:
                    result = "PktGuideQuestActivityTimeRenewresult";
                    break;
                case 0x92E:
                    result = "PktPromoteStateListRead";
                    break;
                case 0x92F:
                    result = "PktPromoteStateListReadresult";
                    break;
                case 0x930:
                    result = "PktPromoteStateLowListRead";
                    break;
                case 0x931:
                    result = "PktPromoteStateLowListReadresult";
                    break;
                case 0x960:
                    result = "PktTutorialNotify";
                    break;
                case 0x961:
                    result = "PktTutorialListRead";
                    break;
                case 0x962:
                    result = "PktTutorialListReadresult";
                    break;
                case 0x963:
                    result = "PktTutorialStart";
                    break;
                case 0x964:
                    result = "PktTutorialStartresult";
                    break;
                case 0x965:
                    result = "PktTutorialProgress";
                    break;
                case 0x966:
                    result = "PktTutorialProgressresult";
                    break;
                case 0x967:
                    result = "PktTutorialRewardGet";
                    break;
                case 0x968:
                    result = "PktTutorialRewardGetresult";
                    break;
                case 0x969:
                    result = "PktTutorialMaterialReceiveNotify";
                    break;
                case 0x96A:
                    result = "PktTutorialSkip";
                    break;
                case 0x96B:
                    result = "PktTutorialSkipresult";
                    break;
                case 0x9C4:
                    result = "PktCutSceneNotify";
                    break;
                case 0x9C5:
                    result = "PktCutSceneStart";
                    break;
                case 0x9C6:
                    result = "PktCutSceneStartresult";
                    break;
                case 0x9C7:
                    result = "PktCutSceneEnd";
                    break;
                case 0x9C8:
                    result = "PktCutSceneEndresult";
                    break;
                case 0x9C9:
                    result = "PktCutSceneEndReserve";
                    break;
                case 0x9CA:
                    result = "PktCutSceneEndReserveresult";
                    break;
                case 0x9CB:
                    result = "PktWorldPause";
                    break;
                case 0x9CC:
                    result = "PktWorldPauseresult";
                    break;
                case 0x9CD:
                    result = "PktWorldResume";
                    break;
                case 0x9CE:
                    result = "PktWorldResumeresult";
                    break;
                case 0xA28:
                    result = "PktSystemSettingsGet";
                    break;
                case 0xA29:
                    result = "PktSystemSettingsGetresult";
                    break;
                case 0xA2A:
                    result = "PktSystemSettingsSet";
                    break;
                case 0xA2B:
                    result = "PktSystemSettingsSetresult";
                    break;
                case 0xA2C:
                    result = "PktSystemAlarmNotify";
                    break;
                case 0xA2D:
                    result = "PktPing";
                    break;
                case 0xA2E:
                    result = "PktPingresult";
                    break;
                case 0xA5A:
                    result = "PktInstantCompleteListRead";
                    break;
                case 0xA5B:
                    result = "PktInstantCompleteListReadresult";
                    break;
                case 0xA5C:
                    result = "PktInstantCompleteRewardGet";
                    break;
                case 0xA5D:
                    result = "PktInstantCompleteRewardGetresult";
                    break;
                case 0xA5E:
                    result = "PktInstantCompleteRewardAllGet";
                    break;
                case 0xA5F:
                    result = "PktInstantCompleteRewardAllGetresult";
                    break;
                case 0xA8C:
                    result = "PktMissionRequestListRead";
                    break;
                case 0xA8D:
                    result = "PktMissionRequestListReadresult";
                    break;
                case 0xA8E:
                    result = "PktMissionRequestStart";
                    break;
                case 0xA8F:
                    result = "PktMissionRequestStartresult";
                    break;
                case 0xA90:
                    result = "PktMissionDailyRefresh";
                    break;
                case 0xA91:
                    result = "PktMissionDailyRefreshresult";
                    break;
                case 0xA92:
                    result = "PktMissionDailyNowComplete";
                    break;
                case 0xA93:
                    result = "PktMissionDailyNowCompleteresult";
                    break;
                case 0xA94:
                    result = "PktMissionDailyMaxComboComplete";
                    break;
                case 0xA95:
                    result = "PktMissionDailyMaxComboCompleteresult";
                    break;
                case 0xA96:
                    result = "PktMissionWeeklyPass";
                    break;
                case 0xA97:
                    result = "PktMissionWeeklyPassresult";
                    break;
                case 0xA98:
                    result = "PktMissionDailyRewardGet";
                    break;
                case 0xA99:
                    result = "PktMissionDailyRewardGetresult";
                    break;
                case 0xA9A:
                    result = "PktMissionWeeklyRewardGet";
                    break;
                case 0xA9B:
                    result = "PktMissionWeeklyRewardGetresult";
                    break;
                case 0xA9C:
                    result = "PktMissionRequestRewardGet";
                    break;
                case 0xA9D:
                    result = "PktMissionRequestRewardGetresult";
                    break;
                case 0xA9E:
                    result = "PktMissionRequestCompleteNotify";
                    break;
                case 0xA9F:
                    result = "PktMissionDailyUpdateNotify";
                    break;
                case 0xAA0:
                    result = "PktMissionWeeklyUpdateNotify";
                    break;
                case 0xAA1:
                    result = "PktMissionTeleport";
                    break;
                case 0xAA2:
                    result = "PktMissionTeleportresult";
                    break;
                case 0xAA3:
                    result = "PktMissionWeeklyRefresh";
                    break;
                case 0xAA4:
                    result = "PktMissionWeeklyRefreshresult";
                    break;
                case 0xAA5:
                    result = "PktEventDailyQuestListRead";
                    break;
                case 0xAA6:
                    result = "PktEventDailyQuestListReadresult";
                    break;
                case 0xAA7:
                    result = "PktEventDailyQuestRewardGet";
                    break;
                case 0xAA8:
                    result = "PktEventDailyQuestRewardGetresult";
                    break;
                case 0xAA9:
                    result = "PktEventDailyQuestProgressRewardGet";
                    break;
                case 0xAAA:
                    result = "PktEventDailyQuestProgressRewardGetresult";
                    break;
                case 0xAAB:
                    result = "PktEventDailyQuestStart";
                    break;
                case 0xAAC:
                    result = "PktEventDailyQuestStartresult";
                    break;
                case 0xAAD:
                    result = "PktEventDailyQuestResetCompletedCountNotify";
                    break;
                case 0xABE:
                    result = "PktEventListRead";
                    break;
                case 0xABF:
                    result = "PktEventListReadresult";
                    break;
                case 0xAC0:
                    result = "PktEventRewardGet";
                    break;
                case 0xAC1:
                    result = "PktEventRewardGetresult";
                    break;
                case 0xAC2:
                    result = "PktEventStartNotify";
                    break;
                case 0xAC3:
                    result = "PktEventListNotify";
                    break;
                case 0xAC4:
                    result = "PktEventMessageNotify";
                    break;
                case 0xAC5:
                    result = "PktDropBoxEventNotify";
                    break;
                case 0xAC6:
                    result = "PktInitDropBoxNotify";
                    break;
                case 0xAC7:
                    result = "PktEventDiceExecute";
                    break;
                case 0xAC8:
                    result = "PktEventDiceExecuteresult";
                    break;
                case 0xAC9:
                    result = "PktEventProgressNotify";
                    break;
                case 0xACA:
                    result = "PktEventPostListRead";
                    break;
                case 0xACB:
                    result = "PktEventPostListReadresult";
                    break;
                case 0xAF0:
                    result = "PktNetmarbleSIAPInitialize";
                    break;
                case 0xAF1:
                    result = "PktNetmarbleSIAPInitializeresult";
                    break;
                case 0xAF2:
                    result = "PktNetmarbleSIAPVerify";
                    break;
                case 0xAF3:
                    result = "PktNetmarbleSIAPVerifyresult";
                    break;
                case 0xAF4:
                    result = "PktNetmarbleSIAPPurchaseCancel";
                    break;
                case 0xAF5:
                    result = "PktNetmarbleSIAPPurchaseCancelresult";
                    break;
                case 0xAF6:
                    result = "PktGoogleAnalyticsFirstDied";
                    break;
                case 0xAF7:
                    result = "PktGoogleAnalyticsFirstDiedresult";
                    break;
                case 0xAF8:
                    result = "PktNetmarbleSWebAchievementNotify";
                    break;
                case 0xAF9:
                    result = "PktNetmarbleSIAPGetNetmarbleItemId";
                    break;
                case 0xAFA:
                    result = "PktNetmarbleSIAPGetNetmarbleItemIdresult";
                    break;
                case 0xBB9:
                    result = "PktUpdate";
                    break;
                case 0xBBA:
                    result = "PktUpdateresult";
                    break;
                case 0xBBB:
                    result = "PktAdminToolRequest";
                    break;
                case 0xBBC:
                    result = "PktAdminToolRequestresult";
                    break;
                case 0xBBD:
                    result = "PktAdminToolNoticeInsert";
                    break;
                case 0xBBE:
                    result = "PktAdminToolNoticeInsertresult";
                    break;
                case 0xBBF:
                    result = "PktAdminToolNoticeDelete";
                    break;
                case 0xBC0:
                    result = "PktAdminToolNoticeDeleteresult";
                    break;
                case 0xB55:
                    result = "PktRankingListRead";
                    break;
                case 0xB56:
                    result = "PktRankingListReadresult";
                    break;
                case 0xB57:
                    result = "PktBroadCastNotify";
                    break;
                case 0xB58:
                    result = "PktSocialNetworkShared";
                    break;
                case 0xB59:
                    result = "PktSocialNetworkSharedresult";
                    break;
                case 0xC1D:
                    result = "PktCharacterTitleListRead";
                    break;
                case 0xC1E:
                    result = "PktCharacterTitleListReadresult";
                    break;
                case 0xC1F:
                    result = "PktCharacterTitleEquip";
                    break;
                case 0xC20:
                    result = "PktCharacterTitleEquipresult";
                    break;
                case 0xC21:
                    result = "PktCharacterTitleUpdateNotify";
                    break;
                case 0xC22:
                    result = "PktCharacterTitleEquipNotify";
                    break;
                case 0xC23:
                    result = "PktCharacterTitleAcquire";
                    break;
                case 0xC24:
                    result = "PktCharacterTitleAcquireresult";
                    break;
                case 0xC25:
                    result = "PktCharacterTitleDeleteNotify";
                    break;
                case 0x1394:
                    result = "PktGuildDailyRewardRead";
                    break;
                case 0x1395:
                    result = "PktGuildDailyRewardReadresult";
                    break;
                case 0x1396:
                    result = "PktGuildFortressDailyRewardGet";
                    break;
                case 0x1397:
                    result = "PktGuildFortressDailyRewardGetresult";
                    break;
                case 0xFA1:
                    result = "PktWebUserLogin";
                    break;
                case 0xFA2:
                    result = "PktWebUserLoginresult";
                    break;
                case 0xFA3:
                    result = "PktWebUserLogout";
                    break;
                case 0xFA4:
                    result = "PktWebUserLogoutresult";
                    break;
                case 0xFA5:
                    result = "PktActorLocationNotify";
                    break;
                case 0xFA6:
                    result = "PktMessageShowNotify";
                    break;
                case 0xFA7:
                    result = "PktMessageReply";
                    break;
                case 0xFA8:
                    result = "PktMessageReplyresult";
                    break;
                case 0xFA9:
                    result = "PktLogShowNotify";
                    break;
                case 0xFAA:
                    result = "PktStyleSheet";
                    break;
                case 0xFAB:
                    result = "PktStyleSheetresult";
                    break;
                case 0xFAC:
                    result = "PktStyleSheetResource";
                    break;
                case 0xFAD:
                    result = "PktStyleSheetResourceresult";
                    break;
                case 0xFAE:
                    result = "PktTestBotPlayerInfoRead";
                    break;
                case 0xFAF:
                    result = "PktTestBotPlayerInfoReadresult";
                    break;
                case 0xFB0:
                    result = "PktQuestEdit";
                    break;
                case 0xFB1:
                    result = "PktQuestEditresult";
                    break;
                case 0xFB2:
                    result = "PktDebugShapeShowNotify";
                    break;
                case 0xFB3:
                    result = "PktSecurityCodeManage";
                    break;
                case 0xFB4:
                    result = "PktSecurityCodeManageresult";
                    break;
                case 0xFB5:
                    result = "PktWorldBossNotify";
                    break;
                case 0xFB6:
                    result = "PktTestBotCommandNotify";
                    break;
                case 0xFB7:
                    result = "PktPerformanceTrace";
                    break;
                case 0xFB8:
                    result = "PktPerformanceTraceresult";
                    break;
                case 0xFB9:
                    result = "PktApolloVoiceGetAuthKey";
                    break;
                case 0xFBA:
                    result = "PktApolloVoiceGetAuthKeyresult";
                    break;
                case 0xFBB:
                    result = "PktEnvironmentManage";
                    break;
                case 0xFBC:
                    result = "PktEnvironmentManageresult";
                    break;
                case 0xFBD:
                    result = "PktFuncCall";
                    break;
                case 0xFBE:
                    result = "PktFuncCallresult";
                    break;
                case 0xFBF:
                    result = "PktObjectStatsTrace";
                    break;
                case 0xFC0:
                    result = "PktObjectStatsTraceresult";
                    break;
                case 0x1C21:
                    result = "PktOptionChange";
                    break;
                case 0x1C22:
                    result = "PktOptionChangeresult";
                    break;
                case 0x1C23:
                    result = "PktOptionDeckListRead";
                    break;
                case 0x1C24:
                    result = "PktOptionDeckListReadresult";
                    break;
                case 0x1C25:
                    result = "PktOptionDeckChange";
                    break;
                case 0x1C26:
                    result = "PktOptionDeckChangeresult";
                    break;
                case 0x1B59:
                    result = "PktPetListRead";
                    break;
                case 0x1B5A:
                    result = "PktPetListReadresult";
                    break;
                case 0x1B5B:
                    result = "PktPetUnlockNotify";
                    break;
                case 0x1B5C:
                    result = "PktPetItemUse";
                    break;
                case 0x1B5D:
                    result = "PktPetItemUseresult";
                    break;
                case 0x1B5E:
                    result = "PktPetEquip";
                    break;
                case 0x1B5F:
                    result = "PktPetEquipresult";
                    break;
                case 0x1B60:
                    result = "PktPetRiding";
                    break;
                case 0x1B61:
                    result = "PktPetRidingresult";
                    break;
                case 0x1B62:
                    result = "PktPetUpdateNotify";
                    break;
                case 0x1B63:
                    result = "PktPetRidingNotify";
                    break;
                case 0x1B64:
                    result = "PktPetActive";
                    break;
                case 0x1B65:
                    result = "PktPetActiveresult";
                    break;
                case 0x1B66:
                    result = "PktPetActivatableNotify";
                    break;
                case 0x1B67:
                    result = "PktPetItemEquip";
                    break;
                case 0x1B68:
                    result = "PktPetItemEquipresult";
                    break;
                case 0x1B69:
                    result = "PktPetItemLevelUp";
                    break;
                case 0x1B6A:
                    result = "PktPetItemLevelUpresult";
                    break;
                case 0x1B6B:
                    result = "PktPetItemUpgrade";
                    break;
                case 0x1B6C:
                    result = "PktPetItemUpgraderesult";
                    break;
                case 0x1B6D:
                    result = "PktPetUpgrade";
                    break;
                case 0x1B6E:
                    result = "PktPetUpgraderesult";
                    break;
                case 0x1B6F:
                    result = "PktForcePetRidingNotify";
                    break;
                case 0x1B70:
                    result = "PktPetItemEnchant";
                    break;
                case 0x1B71:
                    result = "PktPetItemEnchantresult";
                    break;
                case 0x1B72:
                    result = "PktPetEquipmentItemLike";
                    break;
                case 0x1B73:
                    result = "PktPetEquipmentItemLikeresult";
                    break;
                case 0x1B74:
                    result = "PktPetItemOptionChange";
                    break;
                case 0x1B75:
                    result = "PktPetItemOptionChangeresult";
                    break;
                case 0x1771:
                    result = "PktGuildAgitKeeperInfo";
                    break;
                case 0x1772:
                    result = "PktGuildAgitKeeperInforesult";
                    break;
                case 0x1773:
                    result = "PktGuildAgitBanquetList";
                    break;
                case 0x1774:
                    result = "PktGuildAgitBanquetListresult";
                    break;
                case 0x1775:
                    result = "PktGuildAgitBanquetCreate";
                    break;
                case 0x1776:
                    result = "PktGuildAgitBanquetCreateresult";
                    break;
                case 0x1777:
                    result = "PktGuildAgitBanquetCreateNotify";
                    break;
                case 0x1778:
                    result = "PktGuildAgitRelicList";
                    break;
                case 0x1779:
                    result = "PktGuildAgitRelicListresult";
                    break;
                case 0x177A:
                    result = "PktGuildAgitRelicRegist";
                    break;
                case 0x177B:
                    result = "PktGuildAgitRelicRegistresult";
                    break;
                case 0x177C:
                    result = "PktGuildAgitRelicAppraise";
                    break;
                case 0x177D:
                    result = "PktGuildAgitRelicAppraiseresult";
                    break;
                case 0x177E:
                    result = "PktGuildAgitRelicPointUse";
                    break;
                case 0x177F:
                    result = "PktGuildAgitRelicPointUseresult";
                    break;
                case 0x1780:
                    result = "PktGuildAgitKeeperUpgrade";
                    break;
                case 0x1781:
                    result = "PktGuildAgitKeeperUpgraderesult";
                    break;
                case 0x1782:
                    result = "PktGuildAgitKeeperAutoExtends";
                    break;
                case 0x1783:
                    result = "PktGuildAgitKeeperAutoExtendsresult";
                    break;
                case 0x1784:
                    result = "PktGuildAgitQuestListNotify";
                    break;
                case 0x1785:
                    result = "PktGuildAgitQuestUpdateNotify";
                    break;
                case 0x1786:
                    result = "PktGuildFortressGiveUp";
                    break;
                case 0x1787:
                    result = "PktGuildFortressGiveUpresult";
                    break;
                case 0x1788:
                    result = "PktGuildCastleGiveUp";
                    break;
                case 0x1789:
                    result = "PktGuildCastleGiveUpresult";
                    break;
                case 0x178A:
                    result = "PktGuildStateChangeNotify";
                    break;
                case 0x178B:
                    result = "PktGuildDonateReset";
                    break;
                case 0x178C:
                    result = "PktGuildDonateResetresult";
                    break;
                case 0x178D:
                    result = "PktGuildAgitUpgradeNotify";
                    break;
                case 0x178E:
                    result = "PktGuildAgitFirePlaceEnable";
                    break;
                case 0x178F:
                    result = "PktGuildAgitFirePlaceEnableresult";
                    break;
                case 0x1790:
                    result = "PktGuildAgitFirePlaceEnableNotify";
                    break;
                case 0x1791:
                    result = "PktGuildAgitLiquidCreate";
                    break;
                case 0x1792:
                    result = "PktGuildAgitLiquidCreateresult";
                    break;
                case 0x1793:
                    result = "PktGuildAgitLiquidCreateNotify";
                    break;
                case 0x1794:
                    result = "PktOtherGuildAllianceChangeNotify";
                    break;
                case 0x1795:
                    result = "PktGuildCastleDailyRewardGet";
                    break;
                case 0x1796:
                    result = "PktGuildCastleDailyRewardGetresult";
                    break;
                case 0x1797:
                    result = "PktGuildOrderNotify";
                    break;
                case 0x1798:
                    result = "PktGuildWarehouseGrantByList";
                    break;
                case 0x1799:
                    result = "PktGuildWarehouseGrantByListresult";
                    break;
                case 0x179A:
                    result = "PktGuildCastleTypeSelect";
                    break;
                case 0x179B:
                    result = "PktGuildCastleTypeSelectresult";
                    break;
                case 0x179C:
                    result = "PktGuildCastleTypeSelectNotify";
                    break;
                case 0x179D:
                    result = "PktGuildHostileWarEndSuggest";
                    break;
                case 0x179E:
                    result = "PktGuildHostileWarEndSuggestresult";
                    break;
                case 0x179F:
                    result = "PktGuildHostileWarEndAnswer";
                    break;
                case 0x17A0:
                    result = "PktGuildHostileWarEndAnswerresult";
                    break;
                case 0x17A1:
                    result = "PktGuildAgitQuestCompleteNotify";
                    break;
                case 0x17A2:
                    result = "PktGuildAgitWishListRead";
                    break;
                case 0x17A3:
                    result = "PktGuildAgitWishListReadresult";
                    break;
                case 0x17A4:
                    result = "PktGuildCastleTypeSelectTimeNotify";
                    break;
                case 0x17A5:
                    result = "PktGuildAgitWishGet";
                    break;
                case 0x17A6:
                    result = "PktGuildAgitWishGetresult";
                    break;
                case 0x17A7:
                    result = "PktGuildReJoinPenaltyTimeRead";
                    break;
                case 0x17A8:
                    result = "PktGuildReJoinPenaltyTimeReadresult";
                    break;
                case 0x17A9:
                    result = "PktGuildWantJoin";
                    break;
                case 0x17AA:
                    result = "PktGuildWantJoinresult";
                    break;
                case 0x17AB:
                    result = "PktGuildInviteListRead";
                    break;
                case 0x17AC:
                    result = "PktGuildInviteListReadresult";
                    break;
                case 0x17AD:
                    result = "PktGuildWantJoinListRead";
                    break;
                case 0x17AE:
                    result = "PktGuildWantJoinListReadresult";
                    break;
                case 0x17AF:
                    result = "PktGuildInviteCancel";
                    break;
                case 0x17B0:
                    result = "PktGuildInviteCancelresult";
                    break;
                case 0x17B1:
                    result = "PktGuildInviteReject";
                    break;
                case 0x17B2:
                    result = "PktGuildInviteRejectresult";
                    break;
                case 0x17B3:
                    result = "PktGuildMemberSelfIntroChange";
                    break;
                case 0x17B4:
                    result = "PktGuildMemberSelfIntroChangeresult";
                    break;
                case 0x2711:
                    result = "PktGuildEmblemChangeNotify";
                    break;
                case 0x2712:
                    result = "PktGuildNicknameChangeNotify";
                    break;
                case 0x2713:
                    result = "PktGuildMemberLoginNotify";
                    break;
                case 0x2714:
                    result = "PktGuildDonateNotify";
                    break;
                case 0x2715:
                    result = "PktGuildWarehouseGrantNotify";
                    break;
                case 0x2716:
                    result = "PktGuildWarehouseGrantAllNotify";
                    break;
                case 0x2717:
                    result = "PktGuildWarehouseGrantByListNotify";
                    break;
                case 0x2718:
                    result = "PktGuildMarketGiftBuyNotify";
                    break;
                case 0x2719:
                    result = "PktGuildRevenge";
                    break;
                case 0x271A:
                    result = "PktGuildRevengeresult";
                    break;
                case 0x271B:
                    result = "PktGuildRevengeNotify";
                    break;
                case 0x271C:
                    result = "PktGuildRevengeAnswer";
                    break;
                case 0x271D:
                    result = "PktGuildRevengeAnswerresult";
                    break;
                case 0x271E:
                    result = "PktGuildHostilityRegisterNotify";
                    break;
                case 0x271F:
                    result = "PktGuildHostileWarEndRefuseNotify";
                    break;
                case 0x2720:
                    result = "PktGuildHostileWarEndNotify";
                    break;
                case 0x2721:
                    result = "PktGuildHostileWarSurrenderNotify";
                    break;
                case 0x2722:
                    result = "PktGuildBuffUpgradeNotify";
                    break;
                case 0x2723:
                    result = "PktGuildMarketBuyNotify";
                    break;
                case 0x2724:
                    result = "PktGuildDungeonResetNotify";
                    break;
                case 0x2725:
                    result = "PktFortressSiegeEntryBidNotify";
                    break;
                case 0x2726:
                    result = "PktCastleSiegeEntryBidNotify";
                    break;
                case 0x2727:
                    result = "PktFortressSiegeEntryBidTimeNotify";
                    break;
                case 0x2728:
                    result = "PktCastleSiegeEntryBidTimeNotify";
                    break;
                case 0x2729:
                    result = "PktFortressSiegeJoinNotify";
                    break;
                case 0x272A:
                    result = "PktCastleSiegeJoinNotify";
                    break;
                case 0x272B:
                    result = "PktFortressSiegeStartNotify";
                    break;
                case 0x272C:
                    result = "PktCastleSiegeStartNotify";
                    break;
                case 0x272D:
                    result = "PktGuildFortressGiveUpNotify";
                    break;
                case 0x272E:
                    result = "PktGuildCastleTypeSelectGuildNotify";
                    break;
                case 0x272F:
                    result = "PktGuildAgitCrystalUpgradeNotify";
                    break;
                case 0x2730:
                    result = "PktGuildAgitRelicPointUseNotify";
                    break;
                case 0x2731:
                    result = "PktGuildAgitFirePlaceDisableNotify";
                    break;
                case 0x283D:
                    result = "PktFreeSiegeRecruitCreate";
                    break;
                case 0x283E:
                    result = "PktFreeSiegeRecruitCreateresult";
                    break;
                case 0x283F:
                    result = "PktFreeSiegeRecruitCreateNotify";
                    break;
                case 0x2840:
                    result = "PktFreeSiegeRecruitDisband";
                    break;
                case 0x2841:
                    result = "PktFreeSiegeRecruitDisbandresult";
                    break;
                case 0x2842:
                    result = "PktFreeSiegeRecruitDisbandNotify";
                    break;
                case 0x2843:
                    result = "PktFreeSiegeRecruitExpel";
                    break;
                case 0x2844:
                    result = "PktFreeSiegeRecruitExpelresult";
                    break;
                case 0x2845:
                    result = "PktFreeSiegeRecruitExpelNotify";
                    break;
                case 0x2846:
                    result = "PktFreeSiegeRecruitWithdraw";
                    break;
                case 0x2847:
                    result = "PktFreeSiegeRecruitWithdrawresult";
                    break;
                case 0x2848:
                    result = "PktFreeSiegeRecruitWithdrawNotify";
                    break;
                case 0x2849:
                    result = "PktFreeSiegeRecruitChangeClass";
                    break;
                case 0x284A:
                    result = "PktFreeSiegeRecruitChangeClassresult";
                    break;
                case 0x284B:
                    result = "PktFreeSiegeRecruitChangeClassNotify";
                    break;
                case 0x284C:
                    result = "PktFreeSiegeRecruitInvite";
                    break;
                case 0x284D:
                    result = "PktFreeSiegeRecruitInviteresult";
                    break;
                case 0x284E:
                    result = "PktFreeSiegeRecruitInviteNotify";
                    break;
                case 0x284F:
                    result = "PktFreeSiegeRecruitInviteRefuse";
                    break;
                case 0x2850:
                    result = "PktFreeSiegeRecruitInviteRefuseresult";
                    break;
                case 0x2851:
                    result = "PktFreeSiegeRecruitInviteRefuseNotify";
                    break;
                case 0x2852:
                    result = "PktFreeSiegeRecruitJoin";
                    break;
                case 0x2853:
                    result = "PktFreeSiegeRecruitJoinresult";
                    break;
                case 0x2854:
                    result = "PktFreeSiegeRecruitJoinNotify";
                    break;
                case 0x2855:
                    result = "PktFreeSiegeRecruitReady";
                    break;
                case 0x2856:
                    result = "PktFreeSiegeRecruitReadyresult";
                    break;
                case 0x2857:
                    result = "PktFreeSiegeRecruitReadyNotify";
                    break;
                case 0x2858:
                    result = "PktFreeSiegeEnterRequest";
                    break;
                case 0x2859:
                    result = "PktFreeSiegeEnterRequestresult";
                    break;
                case 0x285A:
                    result = "PktFreeSiegeEnterRequestNotify";
                    break;
                case 0x285B:
                    result = "PktFreeSiegeRecruitDataNotify";
                    break;
                case 0x285C:
                    result = "PktFreeSiegeEnterCancel";
                    break;
                case 0x285D:
                    result = "PktFreeSiegeEnterCancelresult";
                    break;
                case 0x285E:
                    result = "PktFreeSiegeEnterCancelNotify";
                    break;
                case 0x285F:
                    result = "PktFreeSiegeStepNotify";
                    break;
                case 0x2860:
                    result = "PktFreeSiegeInfo";
                    break;
                case 0x2861:
                    result = "PktFreeSiegeInforesult";
                    break;
                case 0x2862:
                    result = "PktFreeSiegeSubMissionUpdateNotify";
                    break;
                case 0x2863:
                    result = "PktFreeSiegeFinishNotify";
                    break;
                case 0x2864:
                    result = "PktFreeSiegeChangeClass";
                    break;
                case 0x2865:
                    result = "PktFreeSiegeChangeClassresult";
                    break;
                case 0x2866:
                    result = "PktFreeSiegeLeaderState";
                    break;
                case 0x2867:
                    result = "PktFreeSiegeLeaderStateresult";
                    break;
                case 0x2868:
                    result = "PktFreeSiegeChangeLeaderNotify";
                    break;
                case 0x2869:
                    result = "PktFreeSiegeEnterWaitNotify";
                    break;
                case 0x286A:
                    result = "PktFreeSiegeSkillListNotify";
                    break;
                case 0x286B:
                    result = "PktFreeSiegeTransferCoolTimeNotify";
                    break;
                case 0x2617:
                    result = "PktNewsletterListRead";
                    break;
                case 0x2618:
                    result = "PktNewsletterListReadresult";
                    break;
                case 0x2619:
                    result = "PktNewsletterDelete";
                    break;
                case 0x261A:
                    result = "PktNewsletterDeleteresult";
                    break;
                case 0x261B:
                    result = "PktNewsletterDeleteAll";
                    break;
                case 0x261C:
                    result = "PktNewsletterDeleteAllresult";
                    break;
                case 0x261D:
                    result = "PktNewsletterRewardGet";
                    break;
                case 0x261E:
                    result = "PktNewsletterRewardGetresult";
                    break;
                case 0x261F:
                    result = "PktNewsletterRewardAllGet";
                    break;
                case 0x2620:
                    result = "PktNewsletterRewardAllGetresult";
                    break;
                case 0x2621:
                    result = "PktNewsletterReceiveNotify";
                    break;
                case 0x2622:
                    result = "PktNewsletterOpen";
                    break;
                case 0x2623:
                    result = "PktNewsletterOpenresult";
                    break;
                case 0x25E5:
                    result = "PktFacebookInviteList";
                    break;
                case 0x25E6:
                    result = "PktFacebookInviteListresult";
                    break;
                case 0x25E7:
                    result = "PktFacebookInviteRequest";
                    break;
                case 0x25E8:
                    result = "PktFacebookInviteRequestresult";
                    break;
                case 0x25E9:
                    result = "PktFacebookFriendListInfoRequest";
                    break;
                case 0x25EA:
                    result = "PktFacebookFriendListInfoRequestresult";
                    break;
                case 0x25EB:
                    result = "PktFacebookRewardRequest";
                    break;
                case 0x25EC:
                    result = "PktFacebookRewardRequestresult";
                    break;
                case 0x2581:
                    result = "PktEventCheckBoardListRead";
                    break;
                case 0x2582:
                    result = "PktEventCheckBoardListReadresult";
                    break;
                case 0x2583:
                    result = "PktEventCheckBoardGet";
                    break;
                case 0x2584:
                    result = "PktEventCheckBoardGetresult";
                    break;
                case 0x2585:
                    result = "PktEventCheckBoardReset";
                    break;
                case 0x2586:
                    result = "PktEventCheckBoardResetresult";
                    break;
                case 0x2587:
                    result = "PktEventCheckBoardAccrueGet";
                    break;
                case 0x2588:
                    result = "PktEventCheckBoardAccrueGetresult";
                    break;
                case 0x2589:
                    result = "PktEventCheckBoardBadgeClear";
                    break;
                case 0x258A:
                    result = "PktEventCheckBoardBadgeClearresult";
                    break;
                case 0x251D:
                    result = "PktESportsContentsLockListRead";
                    break;
                case 0x251E:
                    result = "PktESportsContentsLockListReadresult";
                    break;
                case 0x251F:
                    result = "PktESportsMatchInfoNotify";
                    break;
                case 0x2520:
                    result = "PktESportsMatchJoin";
                    break;
                case 0x2521:
                    result = "PktESportsMatchJoinresult";
                    break;
                case 0x2329:
                    result = "PktGuildDungeonSupportRequest";
                    break;
                case 0x232A:
                    result = "PktGuildDungeonSupportRequestresult";
                    break;
                case 0x232B:
                    result = "PktGuildDungeonSupportCancel";
                    break;
                case 0x232C:
                    result = "PktGuildDungeonSupportCancelresult";
                    break;
                case 0x232D:
                    result = "PktGuildDungeonParticipate";
                    break;
                case 0x232E:
                    result = "PktGuildDungeonParticipateresult";
                    PktGuildDungeonParticipateresult.Packet(packet.Clone());
                    PktGuildDungeonParticipateresultClean.Packet(packet.ToBytes());
                    break;
                case 0x232F:
                    result = "PktGuildDungeonHelp	resultNotify";
                    break;
                case 0x2330:
                    result = "PktGuildDungeonHelpInfo";
                    break;
                case 0x2331:
                    result = "PktGuildDungeonHelpInforesult";
                    break;
                case 0x2332:
                    result = "PktGuildDungeonHelpList";
                    break;
                case 0x2333:
                    result = "PktGuildDungeonHelpListresult";
                    break;
                case 0x1C85:
                    result = "PktBattlefieldInfo";
                    break;
                case 0x1C86:
                    result = "PktBattlefieldInforesult";
                    break;
                case 0x1C87:
                    result = "PktBattlefieldOpenTimeListNotify";
                    break;
                case 0x1C88:
                    result = "PktBattlefieldHistoryInfo";
                    break;
                case 0x1C89:
                    result = "PktBattlefieldHistoryInforesult";
                    break;
                case 0x1C8A:
                    result = "PktBattlefieldPopup";
                    break;
                case 0x1C8B:
                    result = "PktBattlefieldPopupresult";
                    break;
                case 0x1C8C:
                    result = "PktBattlefieldEnter";
                    break;
                case 0x1C8D:
                    result = "PktBattlefieldEnterresult";
                    break;
                case 0x1C8E:
                    result = "PktBattlefieldEnterNotify";
                    break;
                case 0x1C8F:
                    result = "PktBattlefieldEnterCancel";
                    break;
                case 0x1C90:
                    result = "PktBattlefieldEnterCancelresult";
                    break;
                case 0x1C91:
                    result = "PktBattlefieldEnterCancelNotify";
                    break;
                case 0x1C92:
                    result = "PktBattlefieldEnterCompletedNotify";
                    break;
                case 0x1C93:
                    result = "PktBattlefieldCountDownStartNotify";
                    break;
                case 0x1C94:
                    result = "PktBattlefieldWorldEnter";
                    break;
                case 0x1C95:
                    result = "PktBattlefieldWorldEnterresult";
                    break;
                case 0x1C96:
                    result = "PktBattlefieldTimeNotify";
                    break;
                case 0x1C97:
                    result = "PktBattlefieldEndNotify";
                    break;
                case 0x1C98:
                    result = "PktBattlefieldExit";
                    break;
                case 0x1C99:
                    result = "PktBattlefieldExitresult";
                    break;
                case 0x1C9A:
                    result = "PktBattlefieldScoreChangeNotify";
                    break;
                case 0x1C9B:
                    result = "PktBattlefieldOccupationProgressListNotify";
                    break;
                case 0x1C9C:
                    result = "PktBattlefieldFreyaCarveStartNotify";
                    break;
                case 0x1C9D:
                    result = "PktBattlefieldFreyaCarveSuccessNotify";
                    break;
                case 0x1C9E:
                    result = "PktBattlefieldFreyaCarveFailNotify";
                    break;
                case 0x1C9F:
                    result = "PktBattlefieldKillNotify";
                    break;
                case 0x1CA0:
                    result = "PktBattlefieldOfHonorReconnectDataNotify";
                    break;
                case 0x1CA1:
                    result = "PktBattlefieldDailyTimeEndNotify";
                    break;
                case 0x1CA2:
                    result = "PktBattlefieldHallOfFameInfo";
                    break;
                case 0x1CA3:
                    result = "PktBattlefieldHallOfFameInforesult";
                    break;
                case 0x1CA4:
                    result = "PktBattlefieldSeasonRewardNotify";
                    break;
                case 0x1CA5:
                    result = "PktBattlefieldSeasonRewardRequest";
                    break;
                case 0x1CA6:
                    result = "PktBattlefieldSeasonRewardRequestresult";
                    break;
                case 0x1CA7:
                    result = "PktBattlefieldPartyMemberLeagueChangeNotify";
                    break;
                case 0x1CA8:
                    result = "PktBattlefieldNextBuffCreateTimeNotify";
                    break;
                default:
                    result = "(InvalidPacket)";
                    break;
            }

 
            Console.Write("\tPacketType: " + result + "\n");
        }
    }
}
