using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSpine.Unity;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class HeroData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isSummon;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonID;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonMoveRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonControlable;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonSourceHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_interestingStar;

	private static readonly System.IntPtr NativeFieldInfoPtr_manageAiHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_dailyAIManaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroAIData;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroAIDataArriveTargetRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroAISettingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_speHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_tempPlotHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_recruitAble;

	private static readonly System.IntPtr NativeFieldInfoPtr_loveAble;

	private static readonly System.IntPtr NativeFieldInfoPtr_hide;

	private static readonly System.IntPtr NativeFieldInfoPtr_dead;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroName;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroFamilyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroNickName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFemale;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_outsideForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceJobType;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceJobID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceJobCD;

	private static readonly System.IntPtr NativeFieldInfoPtr_branchLeaderAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMonthContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisYearContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastYearContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFightContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroForceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroStrengthLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_atAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigMapPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_inSafeArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_inPrison;

	private static readonly System.IntPtr NativeFieldInfoPtr_age;

	private static readonly System.IntPtr NativeFieldInfoPtr_generation;

	private static readonly System.IntPtr NativeFieldInfoPtr_voicePitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinColorDark;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSkinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeSkinCd;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSetSkin;

	private static readonly System.IntPtr NativeFieldInfoPtr_setSkinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_setSkinLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuSkillFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_livingSkillFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_goodKungfuSkillName;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveMeet;

	private static readonly System.IntPtr NativeFieldInfoPtr_favor;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseAttri;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAttri;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalAttri;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseFightSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFightSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalFightSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLivingSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLivingSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalLivingSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_expLivingSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_hp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxhp;

	private static readonly System.IntPtr NativeFieldInfoPtr_realMaxHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_power;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_realMaxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_mana;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMana;

	private static readonly System.IntPtr NativeFieldInfoPtr_realMaxMana;

	private static readonly System.IntPtr NativeFieldInfoPtr_armor;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGovern;

	private static readonly System.IntPtr NativeFieldInfoPtr_governLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_governContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHornord;

	private static readonly System.IntPtr NativeFieldInfoPtr_hornorLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_fame;

	private static readonly System.IntPtr NativeFieldInfoPtr_badFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_loyal;

	private static readonly System.IntPtr NativeFieldInfoPtr_evil;

	private static readonly System.IntPtr NativeFieldInfoPtr_chaos;

	private static readonly System.IntPtr NativeFieldInfoPtr_nature;

	private static readonly System.IntPtr NativeFieldInfoPtr_talent;

	private static readonly System.IntPtr NativeFieldInfoPtr_hobby;

	private static readonly System.IntPtr NativeFieldInfoPtr_rest;

	private static readonly System.IntPtr NativeFieldInfoPtr_cureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_salary;

	private static readonly System.IntPtr NativeFieldInfoPtr_population;

	private static readonly System.IntPtr NativeFieldInfoPtr_nowEquipment;

	private static readonly System.IntPtr NativeFieldInfoPtr_horseSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_horse;

	private static readonly System.IntPtr NativeFieldInfoPtr_horseArmorSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_horseArmor;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemListData;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_partPosture;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfCureTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_restCureTotalRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_medResist;

	private static readonly System.IntPtr NativeFieldInfoPtr_fightProtectTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_fightForceEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_fightSpeControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_battlePrepareSpellData;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillMaxPracticeExpData;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuSkills;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalSkillSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_dodgeSkillSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_dodgeSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueSkillSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackSkillSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackSkills;

	private static readonly System.IntPtr NativeFieldInfoPtr_nowActiveSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroBuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroDetailDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroBuffDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroIconDirtyCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_missions;

	private static readonly System.IntPtr NativeFieldInfoPtr_inTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamLeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamMates;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoLeaveTeamDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoLeaveTeamDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyGuard;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerInteractionTimeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBecomeTeacherTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_Teacher;

	private static readonly System.IntPtr NativeFieldInfoPtr_Students;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lover;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreLovers;

	private static readonly System.IntPtr NativeFieldInfoPtr_Relatives;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brothers;

	private static readonly System.IntPtr NativeFieldInfoPtr_Friends;

	private static readonly System.IntPtr NativeFieldInfoPtr_Haters;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfHouseTotalAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroTagPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroTagData;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookWriteWorking;

	private static readonly System.IntPtr NativeFieldInfoPtr_wantRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_studyNewSkillSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_settingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_servantForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_recruitByPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTempHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRandomEnemy;

	private static readonly System.IntPtr NativeFieldInfoPtr_needRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_inWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_inMountain;

	private static readonly System.IntPtr NativeFieldInfoPtr_inHill;

	private static readonly System.IntPtr NativeFieldInfoPtr_fightScore;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HeroIconDirty_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HeroIconDirty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSerializingMethod_Internal_Void_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateFaceCode_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFaceCode_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTagNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalTagPoint_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveForceFunction_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeaponResearchWeaponType_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveSpeInteractWithNPC_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeditationTopic_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroID_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHeroSkillID_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAskJoinTeamNeedFavor_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSpeTeammate_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferWeaponType_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomFaceData_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinColorByDark_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveMission_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMission_Public_MissionData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MissionKeepInTeam_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroPermanentTagNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentWeightLv_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissMeetingReduceContribution_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHitMoveRange_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsePoisonRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagePoisonEquipment_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagePoisonItem_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFameForceLv_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextForceLvFame_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFightTime_Public_Int32_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroAIData_Public_Void_HeroAIData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillMaxPracticeExp_Public_SkillMaxPracticeExpData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSkillMaxPracticeExp_Public_Void_SkillMaxPracticeExpData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTagPoint_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonHorseIdleAnim_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonHorseRunAnim_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonHorseWalkAnim_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceJobSpeAddResult_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeetForceJobRequire_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAISettingPriorityLv_Public_Int32_AISettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAISettingFocus_Public_Int32_AISettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Favor_Public_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTeamMate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxStudent_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDoctorTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseAttriNum_Public_Single_BaseAttriType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroFavorUI_Public_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFullSetName_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuickDetail_Public_String_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSkillPower_Public_Void_SkillChangePowerType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillPowerChargeSpeed_Public_Single_FightSkillType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Name_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeForceLvNeedSkillNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillRareLvExpRate_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBountyMissionNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxBountyMissionNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSelfHouseTotalAdd_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayHeroSound_Public_Void_AudioClip_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroLittleTalkSound_Public_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroSoundVoiceAgePitch_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroSoundAgePitch_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroSoundAgeID_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroMeetSound_Public_AudioClip_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroShoutSound_Public_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroHurtSound_Public_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroDieSound_Public_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroRecoverSound_Public_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaID_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AtAreaName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBigMapPos_Public_BigMapPos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecordLog_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLog_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHobbyDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroDetailDirty_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRandomSkill_Public_KungfuSkillLvData_Int32_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoInPrison_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoOutPrison_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecruitCost_Public_Int32_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyGuardNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseAttackSkill_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseSkill_Public_Boolean_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIdentifyKnowledge_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentifyAllItem_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNowActiveSkill_Public_Void_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNowActiveSkill_Public_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraMaxHp_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraMaxMana_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHpBar_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMpBar_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPowerBar_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNeedRemove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomBigMapMovePos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomEnemyBadFame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SameForce_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoGetFightExp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoGetFightExp_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StuffStoppable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshHorseState_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroHorseRest_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroHorseTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeighChangeTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeatherChangeTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainChangeTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTravelSpeed_Public_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseScore_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSeeRange_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExploreStepRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxSelfCureTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCurePower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCurePostureRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRestCureRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRestCurePower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRestCurePostureRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPostureCurePower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPostureCurePostureRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraStateValueRate_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraHpRecoverValueRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUseItemValue_Public_Single_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRestValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPostureValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPostureValue_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BattleControlable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemControlable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemExchangeable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemLockable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerLeadForce_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NoLoyal_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeLoyal_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetLoyal_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoyalWorkRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoyalExpRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoChangeLoyal_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinForceServant_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveServantForce_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForce_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinForce_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckOutForceContribution_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearContributionRecord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveForce_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearForceJob_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroSalary_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroPopulation_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSameBook_Public_ItemData_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveHobby_Public_Boolean_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttackSkillSlotUnlocked_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FightReset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FightSettingReset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonGraphic_Public_SkeletonGraphic_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseSpeSkeleton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonGraphic_Public_Void_Transform_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonGraphicSkinColor_Public_Void_SkeletonGraphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonGraphicFaceSlot_Public_Void_SkeletonGraphic_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_GameObject_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinName_Public_String_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSkinID_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDefaultSkin_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkin_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_SkeletonAnimation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_SkeletonAnimation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSkeletonHorse_Public_Void_SkeletonAnimation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonSkinColor_Public_Void_SkeletonAnimation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonFaceSlot_Public_Void_SkeletonAnimation_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroWeaponAttackAnim_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkillWeapon_Public_Void_SkeletonAnimation_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFightScore_Public_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHpPercent_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetManaPercent_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPowerPercent_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFullRecoverTime_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecoverRate_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttriRate_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageTagTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveTag_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTag_Public_Void_Int32_Single_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTag_Public_HeroTagData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTag_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTag_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisUnderstandTag_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnderstandTag_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnderstandTag_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllTempTag_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBuff_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttackSelfTeam_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroName_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSetName_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveSetName_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroFamilyName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroName_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroForceLvDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroForceLvDescribeSimplify_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBetrayForceBadTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBetrayForceBadFame_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanPlayerMeet_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeetNeedFame_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFavor_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNatureFavorRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFavorRate_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFavor_Public_Void_Single_Boolean_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStartFavor_Public_Single_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroMeet_Public_Void_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMeetFavor_Public_Void_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFavor_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveFriend_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFriend_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveHater_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHater_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHater_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveBrother_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBrother_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBrother_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRelative_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveTeacher_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTeacher_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveStudent_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStudent_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStudent_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllStudent_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveLover_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLover_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLover_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HavePrelover_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPrelover_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePrelover_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllPrelover_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlayerMakeLoverUnhappy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTeacher_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationShipText_Public_String_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveRelationBetterThanFriend_Public_Boolean_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveTeacherStudentRelation_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoFightQuickChangeState_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHp_Public_Void_Single_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeadToAlive_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxHp_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMana_Public_Void_Single_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxMana_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePower_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxPower_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWoundResist_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageResist_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRandomInjury_Public_Void_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeExternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeInternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePoisonInjury_Public_Single_Single_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullRecover_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalInjury_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoCureSelfInjury_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureInjury_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureExternalInjurySkill_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureExternalInjury_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureExternalInjuryTime_Public_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureInternalInjurySkill_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureInternalInjury_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCureInternalInjuryTime_Public_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCurePoisonInjurySkill_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCurePoisonInjury_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfCurePoisonInjuryTime_Public_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeLivingSkillExp_Public_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLivingSkillExpMax_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeLivingSkill_Public_Void_Int32_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFightSkill_Public_Void_Int32_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAttri_Public_Void_Int32_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_EquipmentData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxAttri_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxFightSkill_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMaxLivingSkill_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAttriAndSkill_Public_Void_HeroSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxAttri_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFightSkill_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxLivingSkill_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshMaxAttriAndSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseMoveRange_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMoveRange_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBounty_Public_Void_Int32_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMoney_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFame_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroFameForceLv_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameDifficultyFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGovernReduceBadFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGovernExtraFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHornorReduceBadFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHornorAddFavorRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBountyPirce_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBadFameFineMoney_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageAIInPrison_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBadFame_Public_Void_Single_Boolean_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBadFameRate_Public_Single_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerSameForce_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroGovernName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroHornorName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHornorChangeMaxArea_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHornorUpgradeCost_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGovernUpgradeCost_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeGovernContribution_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeGovernLv_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHornorLv_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OutsideForceExtraContributionRate_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelfForceContrituion_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeForceContribution_Public_Void_Single_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroForceLv_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroForceLvChangeMaxAttri_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshHeroSalaryAndPopulation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeroForceLv_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BattleChangeSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFightExpRate_Public_Single_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSkillBookExp_Public_Void_Single_KungfuSkillLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBookExpRate_Public_Single_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceBookStorageExpRate_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameDifficultyExpRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSkillUpgrade_Public_Void_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeSkill_Public_Void_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkill_Public_KungfuSkillLvData_KungfuSkillLvData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSkill_Public_KungfuSkillLvData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageGetItemPoison_Public_Single_ItemData_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageGetEquipPoison_Public_Single_ItemData_Boolean_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomAttriAndSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseAllItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseAllSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseSkill_Public_Void_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EquipSkill_Public_Void_KungfuSkillLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnequipSkill_Public_Void_KungfuSkillLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EquipHorse_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnequipHorse_Public_Void_ItemData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EquipItem_Public_Void_ItemData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnequipItem_Public_Void_ItemData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CosumeMedFood_Public_Void_ItemData_Boolean_HeroData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseMedFood_Public_Void_ItemData_Boolean_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFoodSpeBuff_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWineSpeBuff_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebateSpeBuff_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTempTag_Public_Void_HeroTagDataBase_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeTempTag_Public_Void_String_HeroSpeAddDataType_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArea_Public_AreaData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForce_Public_ForceData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceLeader_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeForceLvNeedText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalAttir_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalFightSkill_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalLivingSkill_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebateScore_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFavorValue_Public_Single_ItemData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxBuyValue_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFavorValueRate_Public_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceStorageDiscount_Public_Single_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionData_MissionTargetType_String_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroItemLv_Public_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RandomAttriAndSkill_b__516_0_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RandomAttriAndSkill_b__516_1_Private_Boolean_Int32_0;

	public unsafe bool isSummon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSummon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSummon)) = flag;
		}
	}

	public unsafe int summonID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonID)) = num;
		}
	}

	public unsafe float summonLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonLv);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonLv)) = num;
		}
	}

	public unsafe int summonMoveRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonMoveRange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonMoveRange)) = num;
		}
	}

	public unsafe bool summonControlable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonControlable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonControlable)) = flag;
		}
	}

	public unsafe string summonSourceHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonSourceHero);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonSourceHero)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool interestingStar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interestingStar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interestingStar)) = flag;
		}
	}

	public unsafe float manageAiHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manageAiHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manageAiHour)) = num;
		}
	}

	public unsafe bool dailyAIManaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dailyAIManaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dailyAIManaged)) = flag;
		}
	}

	public unsafe HeroAIData heroAIData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAIData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroAIData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAIData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroAIData));
		}
	}

	public unsafe HeroAIData heroAIDataArriveTargetRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAIDataArriveTargetRecord);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroAIData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAIDataArriveTargetRecord)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroAIData));
		}
	}

	public unsafe HeroAISettingData heroAISettingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAISettingData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroAISettingData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroAISettingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroAISettingData));
		}
	}

	public unsafe int heroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroID)) = num;
		}
	}

	public unsafe bool speHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speHero);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speHero)) = flag;
		}
	}

	public unsafe bool tempPlotHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempPlotHero);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempPlotHero)) = flag;
		}
	}

	public unsafe bool recruitAble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recruitAble);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recruitAble)) = flag;
		}
	}

	public unsafe bool loveAble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loveAble);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loveAble)) = flag;
		}
	}

	public unsafe bool hide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hide)) = flag;
		}
	}

	public unsafe bool dead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dead)) = flag;
		}
	}

	public unsafe string heroName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string heroFamilyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFamilyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFamilyName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string heroNickName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroNickName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroNickName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFemale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFemale)) = flag;
		}
	}

	public unsafe int belongForceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongForceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongForceID)) = num;
		}
	}

	public unsafe int skillForceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillForceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillForceID)) = num;
		}
	}

	public unsafe bool outsideForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideForce)) = flag;
		}
	}

	public unsafe int forceJobType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobType)) = num;
		}
	}

	public unsafe int forceJobID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobID)) = num;
		}
	}

	public unsafe int forceJobCD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobCD);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobCD)) = num;
		}
	}

	public unsafe int branchLeaderAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_branchLeaderAreaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_branchLeaderAreaID)) = num;
		}
	}

	public unsafe float thisMonthContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthContribution)) = num;
		}
	}

	public unsafe float lastMonthContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMonthContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMonthContribution)) = num;
		}
	}

	public unsafe float thisYearContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearContribution)) = num;
		}
	}

	public unsafe float lastYearContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastYearContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastYearContribution)) = num;
		}
	}

	public unsafe float lastFightContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFightContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFightContribution)) = num;
		}
	}

	public unsafe bool isLeader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLeader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLeader)) = flag;
		}
	}

	public unsafe int heroForceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroForceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroForceLv)) = num;
		}
	}

	public unsafe float heroStrengthLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroStrengthLv);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroStrengthLv)) = num;
		}
	}

	public unsafe int atAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atAreaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atAreaID)) = num;
		}
	}

	public unsafe BigMapPos bigMapPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigMapPos>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigMapPos));
		}
	}

	public unsafe bool inSafeArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSafeArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSafeArea)) = flag;
		}
	}

	public unsafe bool inPrison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inPrison);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inPrison)) = flag;
		}
	}

	public unsafe int age
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_age);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_age)) = num;
		}
	}

	public unsafe int generation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generation)) = num;
		}
	}

	public unsafe float voicePitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voicePitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voicePitch)) = num;
		}
	}

	public unsafe HeroFaceData faceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroFaceData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroFaceData));
		}
	}

	public unsafe float skinColorDark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColorDark);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColorDark)) = num;
		}
	}

	public unsafe int defaultSkinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSkinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSkinID)) = num;
		}
	}

	public unsafe int skinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID)) = num;
		}
	}

	public unsafe int skinLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinLv)) = num;
		}
	}

	public unsafe int changeSkinCd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeSkinCd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeSkinCd)) = num;
		}
	}

	public unsafe bool playerSetSkin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSetSkin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSetSkin)) = flag;
		}
	}

	public unsafe int setSkinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSkinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSkinID)) = num;
		}
	}

	public unsafe int setSkinLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSkinLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSkinLv)) = num;
		}
	}

	public unsafe List<int> kungfuSkillFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> livingSkillFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_livingSkillFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_livingSkillFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> goodKungfuSkillName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goodKungfuSkillName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goodKungfuSkillName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool haveMeet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveMeet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveMeet)) = flag;
		}
	}

	public unsafe float favor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favor)) = num;
		}
	}

	public unsafe List<float> baseAttri
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAttri);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAttri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> maxAttri
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAttri);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAttri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> totalAttri
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAttri);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAttri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> baseFightSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFightSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFightSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> maxFightSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFightSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFightSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> totalFightSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalFightSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalFightSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> baseLivingSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLivingSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLivingSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> maxLivingSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLivingSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLivingSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> totalLivingSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalLivingSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalLivingSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> expLivingSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expLivingSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expLivingSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float hp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp)) = num;
		}
	}

	public unsafe float maxhp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxhp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxhp)) = num;
		}
	}

	public unsafe float realMaxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxHp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxHp)) = num;
		}
	}

	public unsafe float power
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power)) = num;
		}
	}

	public unsafe float maxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower)) = num;
		}
	}

	public unsafe float realMaxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxPower)) = num;
		}
	}

	public unsafe float mana
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mana);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mana)) = num;
		}
	}

	public unsafe float maxMana
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMana);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMana)) = num;
		}
	}

	public unsafe float realMaxMana
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxMana);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realMaxMana)) = num;
		}
	}

	public unsafe float armor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armor)) = num;
		}
	}

	public unsafe float externalInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalInjury)) = num;
		}
	}

	public unsafe float internalInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalInjury)) = num;
		}
	}

	public unsafe float poisonInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonInjury)) = num;
		}
	}

	public unsafe bool isGovern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGovern);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGovern)) = flag;
		}
	}

	public unsafe int governLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governLv)) = num;
		}
	}

	public unsafe float governContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governContribution)) = num;
		}
	}

	public unsafe bool isHornord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHornord);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHornord)) = flag;
		}
	}

	public unsafe int hornorLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hornorLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hornorLv)) = num;
		}
	}

	public unsafe float forceContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceContribution)) = num;
		}
	}

	public unsafe float fame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fame);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fame)) = num;
		}
	}

	public unsafe float badFame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_badFame);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_badFame)) = num;
		}
	}

	public unsafe float loyal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loyal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loyal)) = num;
		}
	}

	public unsafe float evil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evil);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evil)) = num;
		}
	}

	public unsafe float chaos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chaos);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chaos)) = num;
		}
	}

	public unsafe int nature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nature);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nature)) = num;
		}
	}

	public unsafe int talent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_talent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_talent)) = num;
		}
	}

	public unsafe List<int> hobby
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hobby);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hobby)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool rest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rest)) = flag;
		}
	}

	public unsafe int cureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cureType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cureType)) = num;
		}
	}

	public unsafe int salary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salary);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salary)) = num;
		}
	}

	public unsafe int population
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population)) = num;
		}
	}

	public unsafe HeroEquipmentData nowEquipment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowEquipment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroEquipmentData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowEquipment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroEquipmentData));
		}
	}

	public unsafe int horseSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseSaveRecord)) = num;
		}
	}

	public unsafe ItemData horse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe int horseArmorSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseArmorSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseArmorSaveRecord)) = num;
		}
	}

	public unsafe ItemData horseArmor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseArmor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseArmor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe ItemListData itemListData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemListData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemListData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe ItemListData selfStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe PartPostureData partPosture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partPosture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PartPostureData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partPosture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)partPostureData));
		}
	}

	public unsafe int selfCureTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfCureTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfCureTime)) = num;
		}
	}

	public unsafe float restCureTotalRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restCureTotalRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restCureTotalRate)) = num;
		}
	}

	public unsafe float medResist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medResist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medResist)) = num;
		}
	}

	public unsafe bool fightProtectTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightProtectTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightProtectTarget)) = flag;
		}
	}

	public unsafe bool fightForceEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightForceEnter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightForceEnter)) = flag;
		}
	}

	public unsafe bool fightSpeControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightSpeControl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightSpeControl)) = flag;
		}
	}

	public unsafe BattlePrepareSpellData battlePrepareSpellData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePrepareSpellData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattlePrepareSpellData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePrepareSpellData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battlePrepareSpellData));
		}
	}

	public unsafe List<SkillMaxPracticeExpData> skillMaxPracticeExpData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillMaxPracticeExpData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkillMaxPracticeExpData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillMaxPracticeExpData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> skillCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillCount);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillCount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KungfuSkillLvData> kungfuSkills
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkills);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuSkillLvData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkills)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int internalSkillSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalSkillSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalSkillSaveRecord)) = num;
		}
	}

	public unsafe KungfuSkillLvData internalSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuSkillLvData));
		}
	}

	public unsafe int dodgeSkillSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dodgeSkillSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dodgeSkillSaveRecord)) = num;
		}
	}

	public unsafe KungfuSkillLvData dodgeSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dodgeSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dodgeSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuSkillLvData));
		}
	}

	public unsafe int uniqueSkillSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueSkillSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueSkillSaveRecord)) = num;
		}
	}

	public unsafe KungfuSkillLvData uniqueSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuSkillLvData));
		}
	}

	public unsafe List<int> attackSkillSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackSkillSaveRecord);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackSkillSaveRecord)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KungfuSkillLvData> attackSkills
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackSkills);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuSkillLvData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackSkills)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int nowActiveSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowActiveSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowActiveSkill)) = num;
		}
	}

	public unsafe HeroSpeAddData baseAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe HeroSpeAddData totalAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe HeroSpeAddData heroBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBuff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBuff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe List<int> autoSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoSetting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool heroDetailDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroDetailDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroDetailDirty)) = flag;
		}
	}

	public unsafe bool heroBuffDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBuffDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBuffDirty)) = flag;
		}
	}

	public unsafe int heroIconDirtyCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroIconDirtyCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroIconDirtyCount)) = num;
		}
	}

	public unsafe MissionData forceMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMission)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)missionData));
		}
	}

	public unsafe List<MissionData> missions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool inTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inTeam);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inTeam)) = flag;
		}
	}

	public unsafe int teamLeader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamLeader);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamLeader)) = num;
		}
	}

	public unsafe List<int> teamMates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamMates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamMates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int autoLeaveTeamDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLeaveTeamDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLeaveTeamDay)) = num;
		}
	}

	public unsafe bool autoLeaveTeamDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLeaveTeamDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLeaveTeamDestroy)) = flag;
		}
	}

	public unsafe bool bodyGuard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyGuard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyGuard)) = flag;
		}
	}

	public unsafe PlayerInteractionTimeData playerInteractionTimeData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionTimeData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInteractionTimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionTimeData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerInteractionTimeData));
		}
	}

	public unsafe int plotNumCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotNumCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotNumCount)) = num;
		}
	}

	public unsafe int missionNumCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumCount)) = num;
		}
	}

	public unsafe int playerBecomeTeacherTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBecomeTeacherTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBecomeTeacherTime)) = num;
		}
	}

	public unsafe int Teacher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Teacher);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Teacher)) = num;
		}
	}

	public unsafe List<int> Students
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Students);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Students)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int Lover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lover);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lover)) = num;
		}
	}

	public unsafe List<int> PreLovers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreLovers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreLovers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> Relatives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Relatives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Relatives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> Brothers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brothers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brothers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> Friends
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Friends);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Friends)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> Haters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Haters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Haters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> recordLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordLog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordLog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float selfHouseTotalAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfHouseTotalAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfHouseTotalAdd)) = num;
		}
	}

	public unsafe float heroTagPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagPoint)) = num;
		}
	}

	public unsafe List<HeroTagData> heroTagData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroTagData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool bookWriteWorking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookWriteWorking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookWriteWorking)) = flag;
		}
	}

	public unsafe bool wantRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantRemove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantRemove)) = flag;
		}
	}

	public unsafe bool equipLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipLock)) = flag;
		}
	}

	public unsafe bool skillLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLock)) = flag;
		}
	}

	public unsafe int studyNewSkillSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyNewSkillSetting);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyNewSkillSetting)) = num;
		}
	}

	public unsafe string settingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int servantForceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_servantForceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_servantForceID)) = num;
		}
	}

	public unsafe bool recruitByPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recruitByPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recruitByPlayer)) = flag;
		}
	}

	public unsafe bool isTempHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTempHero);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTempHero)) = flag;
		}
	}

	public unsafe bool isRandomEnemy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandomEnemy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandomEnemy)) = flag;
		}
	}

	public unsafe bool needRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRemove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRemove)) = flag;
		}
	}

	public unsafe bool inWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inWater);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inWater)) = flag;
		}
	}

	public unsafe bool inMountain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inMountain);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inMountain)) = flag;
		}
	}

	public unsafe bool inHill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inHill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inHill)) = flag;
		}
	}

	public unsafe float fightScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightScore);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightScore)) = num;
		}
	}

	public unsafe bool HeroIconDirty
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126405, RefRangeEnd = 126406, XrefRangeStart = 126405, XrefRangeEnd = 126405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HeroIconDirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 126396, RefRangeEnd = 126405, XrefRangeStart = 126395, XrefRangeEnd = 126396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HeroIconDirty_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static HeroData()
	{
		Il2CppClassPointerStore<HeroData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroData>.NativeClassPtr);
		NativeFieldInfoPtr_isSummon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isSummon");
		NativeFieldInfoPtr_summonID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "summonID");
		NativeFieldInfoPtr_summonLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "summonLv");
		NativeFieldInfoPtr_summonMoveRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "summonMoveRange");
		NativeFieldInfoPtr_summonControlable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "summonControlable");
		NativeFieldInfoPtr_summonSourceHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "summonSourceHero");
		NativeFieldInfoPtr_interestingStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "interestingStar");
		NativeFieldInfoPtr_manageAiHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "manageAiHour");
		NativeFieldInfoPtr_dailyAIManaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "dailyAIManaged");
		NativeFieldInfoPtr_heroAIData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroAIData");
		NativeFieldInfoPtr_heroAIDataArriveTargetRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroAIDataArriveTargetRecord");
		NativeFieldInfoPtr_heroAISettingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroAISettingData");
		NativeFieldInfoPtr_heroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroID");
		NativeFieldInfoPtr_speHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "speHero");
		NativeFieldInfoPtr_tempPlotHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "tempPlotHero");
		NativeFieldInfoPtr_recruitAble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "recruitAble");
		NativeFieldInfoPtr_loveAble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "loveAble");
		NativeFieldInfoPtr_hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "hide");
		NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "dead");
		NativeFieldInfoPtr_heroName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroName");
		NativeFieldInfoPtr_heroFamilyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroFamilyName");
		NativeFieldInfoPtr_heroNickName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroNickName");
		NativeFieldInfoPtr_isFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isFemale");
		NativeFieldInfoPtr_belongForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "belongForceID");
		NativeFieldInfoPtr_skillForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skillForceID");
		NativeFieldInfoPtr_outsideForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "outsideForce");
		NativeFieldInfoPtr_forceJobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "forceJobType");
		NativeFieldInfoPtr_forceJobID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "forceJobID");
		NativeFieldInfoPtr_forceJobCD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "forceJobCD");
		NativeFieldInfoPtr_branchLeaderAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "branchLeaderAreaID");
		NativeFieldInfoPtr_thisMonthContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "thisMonthContribution");
		NativeFieldInfoPtr_lastMonthContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "lastMonthContribution");
		NativeFieldInfoPtr_thisYearContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "thisYearContribution");
		NativeFieldInfoPtr_lastYearContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "lastYearContribution");
		NativeFieldInfoPtr_lastFightContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "lastFightContribution");
		NativeFieldInfoPtr_isLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isLeader");
		NativeFieldInfoPtr_heroForceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroForceLv");
		NativeFieldInfoPtr_heroStrengthLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroStrengthLv");
		NativeFieldInfoPtr_atAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "atAreaID");
		NativeFieldInfoPtr_bigMapPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "bigMapPos");
		NativeFieldInfoPtr_inSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inSafeArea");
		NativeFieldInfoPtr_inPrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inPrison");
		NativeFieldInfoPtr_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "age");
		NativeFieldInfoPtr_generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "generation");
		NativeFieldInfoPtr_voicePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "voicePitch");
		NativeFieldInfoPtr_faceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "faceData");
		NativeFieldInfoPtr_skinColorDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skinColorDark");
		NativeFieldInfoPtr_defaultSkinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "defaultSkinID");
		NativeFieldInfoPtr_skinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skinID");
		NativeFieldInfoPtr_skinLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skinLv");
		NativeFieldInfoPtr_changeSkinCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "changeSkinCd");
		NativeFieldInfoPtr_playerSetSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "playerSetSkin");
		NativeFieldInfoPtr_setSkinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "setSkinID");
		NativeFieldInfoPtr_setSkinLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "setSkinLv");
		NativeFieldInfoPtr_kungfuSkillFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "kungfuSkillFocus");
		NativeFieldInfoPtr_livingSkillFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "livingSkillFocus");
		NativeFieldInfoPtr_goodKungfuSkillName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "goodKungfuSkillName");
		NativeFieldInfoPtr_haveMeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "haveMeet");
		NativeFieldInfoPtr_favor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "favor");
		NativeFieldInfoPtr_baseAttri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "baseAttri");
		NativeFieldInfoPtr_maxAttri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxAttri");
		NativeFieldInfoPtr_totalAttri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "totalAttri");
		NativeFieldInfoPtr_baseFightSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "baseFightSkill");
		NativeFieldInfoPtr_maxFightSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxFightSkill");
		NativeFieldInfoPtr_totalFightSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "totalFightSkill");
		NativeFieldInfoPtr_baseLivingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "baseLivingSkill");
		NativeFieldInfoPtr_maxLivingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxLivingSkill");
		NativeFieldInfoPtr_totalLivingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "totalLivingSkill");
		NativeFieldInfoPtr_expLivingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "expLivingSkill");
		NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "hp");
		NativeFieldInfoPtr_maxhp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxhp");
		NativeFieldInfoPtr_realMaxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "realMaxHp");
		NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "power");
		NativeFieldInfoPtr_maxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxPower");
		NativeFieldInfoPtr_realMaxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "realMaxPower");
		NativeFieldInfoPtr_mana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "mana");
		NativeFieldInfoPtr_maxMana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "maxMana");
		NativeFieldInfoPtr_realMaxMana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "realMaxMana");
		NativeFieldInfoPtr_armor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "armor");
		NativeFieldInfoPtr_externalInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "externalInjury");
		NativeFieldInfoPtr_internalInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "internalInjury");
		NativeFieldInfoPtr_poisonInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "poisonInjury");
		NativeFieldInfoPtr_isGovern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isGovern");
		NativeFieldInfoPtr_governLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "governLv");
		NativeFieldInfoPtr_governContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "governContribution");
		NativeFieldInfoPtr_isHornord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isHornord");
		NativeFieldInfoPtr_hornorLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "hornorLv");
		NativeFieldInfoPtr_forceContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "forceContribution");
		NativeFieldInfoPtr_fame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "fame");
		NativeFieldInfoPtr_badFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "badFame");
		NativeFieldInfoPtr_loyal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "loyal");
		NativeFieldInfoPtr_evil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "evil");
		NativeFieldInfoPtr_chaos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "chaos");
		NativeFieldInfoPtr_nature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "nature");
		NativeFieldInfoPtr_talent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "talent");
		NativeFieldInfoPtr_hobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "hobby");
		NativeFieldInfoPtr_rest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "rest");
		NativeFieldInfoPtr_cureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "cureType");
		NativeFieldInfoPtr_salary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "salary");
		NativeFieldInfoPtr_population = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "population");
		NativeFieldInfoPtr_nowEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "nowEquipment");
		NativeFieldInfoPtr_horseSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "horseSaveRecord");
		NativeFieldInfoPtr_horse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "horse");
		NativeFieldInfoPtr_horseArmorSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "horseArmorSaveRecord");
		NativeFieldInfoPtr_horseArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "horseArmor");
		NativeFieldInfoPtr_itemListData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "itemListData");
		NativeFieldInfoPtr_selfStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "selfStorage");
		NativeFieldInfoPtr_partPosture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "partPosture");
		NativeFieldInfoPtr_selfCureTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "selfCureTime");
		NativeFieldInfoPtr_restCureTotalRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "restCureTotalRate");
		NativeFieldInfoPtr_medResist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "medResist");
		NativeFieldInfoPtr_fightProtectTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "fightProtectTarget");
		NativeFieldInfoPtr_fightForceEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "fightForceEnter");
		NativeFieldInfoPtr_fightSpeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "fightSpeControl");
		NativeFieldInfoPtr_battlePrepareSpellData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "battlePrepareSpellData");
		NativeFieldInfoPtr_skillMaxPracticeExpData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skillMaxPracticeExpData");
		NativeFieldInfoPtr_skillCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skillCount");
		NativeFieldInfoPtr_kungfuSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "kungfuSkills");
		NativeFieldInfoPtr_internalSkillSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "internalSkillSaveRecord");
		NativeFieldInfoPtr_internalSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "internalSkill");
		NativeFieldInfoPtr_dodgeSkillSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "dodgeSkillSaveRecord");
		NativeFieldInfoPtr_dodgeSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "dodgeSkill");
		NativeFieldInfoPtr_uniqueSkillSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "uniqueSkillSaveRecord");
		NativeFieldInfoPtr_uniqueSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "uniqueSkill");
		NativeFieldInfoPtr_attackSkillSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "attackSkillSaveRecord");
		NativeFieldInfoPtr_attackSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "attackSkills");
		NativeFieldInfoPtr_nowActiveSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "nowActiveSkill");
		NativeFieldInfoPtr_baseAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "baseAddData");
		NativeFieldInfoPtr_totalAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "totalAddData");
		NativeFieldInfoPtr_heroBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroBuff");
		NativeFieldInfoPtr_autoSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "autoSetting");
		NativeFieldInfoPtr_heroDetailDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroDetailDirty");
		NativeFieldInfoPtr_heroBuffDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroBuffDirty");
		NativeFieldInfoPtr_heroIconDirtyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroIconDirtyCount");
		NativeFieldInfoPtr_forceMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "forceMission");
		NativeFieldInfoPtr_missions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "missions");
		NativeFieldInfoPtr_inTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inTeam");
		NativeFieldInfoPtr_teamLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "teamLeader");
		NativeFieldInfoPtr_teamMates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "teamMates");
		NativeFieldInfoPtr_autoLeaveTeamDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "autoLeaveTeamDay");
		NativeFieldInfoPtr_autoLeaveTeamDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "autoLeaveTeamDestroy");
		NativeFieldInfoPtr_bodyGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "bodyGuard");
		NativeFieldInfoPtr_playerInteractionTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "playerInteractionTimeData");
		NativeFieldInfoPtr_plotNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "plotNumCount");
		NativeFieldInfoPtr_missionNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "missionNumCount");
		NativeFieldInfoPtr_playerBecomeTeacherTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "playerBecomeTeacherTime");
		NativeFieldInfoPtr_Teacher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Teacher");
		NativeFieldInfoPtr_Students = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Students");
		NativeFieldInfoPtr_Lover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Lover");
		NativeFieldInfoPtr_PreLovers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "PreLovers");
		NativeFieldInfoPtr_Relatives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Relatives");
		NativeFieldInfoPtr_Brothers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Brothers");
		NativeFieldInfoPtr_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Friends");
		NativeFieldInfoPtr_Haters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "Haters");
		NativeFieldInfoPtr_recordLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "recordLog");
		NativeFieldInfoPtr_selfHouseTotalAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "selfHouseTotalAdd");
		NativeFieldInfoPtr_heroTagPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroTagPoint");
		NativeFieldInfoPtr_heroTagData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "heroTagData");
		NativeFieldInfoPtr_bookWriteWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "bookWriteWorking");
		NativeFieldInfoPtr_wantRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "wantRemove");
		NativeFieldInfoPtr_equipLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "equipLock");
		NativeFieldInfoPtr_skillLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "skillLock");
		NativeFieldInfoPtr_studyNewSkillSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "studyNewSkillSetting");
		NativeFieldInfoPtr_settingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "settingName");
		NativeFieldInfoPtr_servantForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "servantForceID");
		NativeFieldInfoPtr_recruitByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "recruitByPlayer");
		NativeFieldInfoPtr_isTempHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isTempHero");
		NativeFieldInfoPtr_isRandomEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "isRandomEnemy");
		NativeFieldInfoPtr_needRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "needRemove");
		NativeFieldInfoPtr_inWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inWater");
		NativeFieldInfoPtr_inMountain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inMountain");
		NativeFieldInfoPtr_inHill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "inHill");
		NativeFieldInfoPtr_fightScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroData>.NativeClassPtr, "fightScore");
		NativeMethodInfoPtr_set_HeroIconDirty_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667415);
		NativeMethodInfoPtr_get_HeroIconDirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667416);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667417);
		NativeMethodInfoPtr_OnSerializingMethod_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667418);
		NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667419);
		NativeMethodInfoPtr_GenerateFaceCode_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667420);
		NativeMethodInfoPtr_LoadFaceCode_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667421);
		NativeMethodInfoPtr_GetMaxTagNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667422);
		NativeMethodInfoPtr_GetTotalTagPoint_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667423);
		NativeMethodInfoPtr_HaveForceFunction_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667424);
		NativeMethodInfoPtr_GetWeaponResearchWeaponType_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667425);
		NativeMethodInfoPtr_HaveSpeInteractWithNPC_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667426);
		NativeMethodInfoPtr_GetMeditationTopic_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667427);
		NativeMethodInfoPtr_SetHeroID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr_ResetHeroSkillID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_GetAskJoinTeamNeedFavor_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_IsSpeTeammate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667432);
		NativeMethodInfoPtr_GetPreferWeaponType_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667433);
		NativeMethodInfoPtr_RandomFaceData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667434);
		NativeMethodInfoPtr_GetSkinColorByDark_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667435);
		NativeMethodInfoPtr_HaveMission_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667436);
		NativeMethodInfoPtr_FindMission_Public_MissionData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667437);
		NativeMethodInfoPtr_MissionKeepInTeam_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667438);
		NativeMethodInfoPtr_GetHeroPermanentTagNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667439);
		NativeMethodInfoPtr_GetEquipmentWeightLv_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667440);
		NativeMethodInfoPtr_GetMissMeetingReduceContribution_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667441);
		NativeMethodInfoPtr_GetHitMoveRange_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667442);
		NativeMethodInfoPtr_UsePoisonRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667443);
		NativeMethodInfoPtr_ManagePoisonEquipment_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667444);
		NativeMethodInfoPtr_ManagePoisonItem_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667445);
		NativeMethodInfoPtr_GetFameForceLv_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667446);
		NativeMethodInfoPtr_GetNextForceLvFame_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667447);
		NativeMethodInfoPtr_GetFightTime_Public_Int32_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667448);
		NativeMethodInfoPtr_SetHeroAIData_Public_Void_HeroAIData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667449);
		NativeMethodInfoPtr_ResetAI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667450);
		NativeMethodInfoPtr_GetSkillMaxPracticeExp_Public_SkillMaxPracticeExpData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667451);
		NativeMethodInfoPtr_AddSkillMaxPracticeExp_Public_Void_SkillMaxPracticeExpData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667452);
		NativeMethodInfoPtr_ChangeTagPoint_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667453);
		NativeMethodInfoPtr_GetSkeletonHorseIdleAnim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667454);
		NativeMethodInfoPtr_GetSkeletonHorseRunAnim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667455);
		NativeMethodInfoPtr_GetSkeletonHorseWalkAnim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667456);
		NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667457);
		NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667458);
		NativeMethodInfoPtr_GetForceJobSpeAddResult_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667459);
		NativeMethodInfoPtr_MeetForceJobRequire_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667460);
		NativeMethodInfoPtr_GetAISettingPriorityLv_Public_Int32_AISettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667461);
		NativeMethodInfoPtr_GetAISettingFocus_Public_Int32_AISettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667462);
		NativeMethodInfoPtr_Favor_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667463);
		NativeMethodInfoPtr_GetMaxTeamMate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667464);
		NativeMethodInfoPtr_GetMaxStudent_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667465);
		NativeMethodInfoPtr_GetMaxDoctorTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667466);
		NativeMethodInfoPtr_GetBaseAttriNum_Public_Single_BaseAttriType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667467);
		NativeMethodInfoPtr_SetHeroFavorUI_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667468);
		NativeMethodInfoPtr_GetFullSetName_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667469);
		NativeMethodInfoPtr_GetQuickDetail_Public_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667470);
		NativeMethodInfoPtr_ChangeSkillPower_Public_Void_SkillChangePowerType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667471);
		NativeMethodInfoPtr_GetSkillPowerChargeSpeed_Public_Single_FightSkillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667472);
		NativeMethodInfoPtr_Name_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667473);
		NativeMethodInfoPtr_GetUpgradeForceLvNeedSkillNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667474);
		NativeMethodInfoPtr_GetSkillRareLvExpRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667475);
		NativeMethodInfoPtr_GetBountyMissionNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667476);
		NativeMethodInfoPtr_GetMaxBountyMissionNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667477);
		NativeMethodInfoPtr_ChangeSelfHouseTotalAdd_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667478);
		NativeMethodInfoPtr_PlayHeroSound_Public_Void_AudioClip_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667479);
		NativeMethodInfoPtr_GetHeroLittleTalkSound_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667480);
		NativeMethodInfoPtr_GetHeroSoundVoiceAgePitch_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667481);
		NativeMethodInfoPtr_GetHeroSoundAgePitch_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667482);
		NativeMethodInfoPtr_GetHeroSoundAgeID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_GetHeroMeetSound_Public_AudioClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr_GetHeroShoutSound_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667485);
		NativeMethodInfoPtr_GetHeroHurtSound_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667486);
		NativeMethodInfoPtr_GetHeroDieSound_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667487);
		NativeMethodInfoPtr_GetHeroRecoverSound_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667488);
		NativeMethodInfoPtr_GetAreaID_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667489);
		NativeMethodInfoPtr_AtAreaName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667490);
		NativeMethodInfoPtr_GetBigMapPos_Public_BigMapPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667491);
		NativeMethodInfoPtr_GetRecordLog_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667492);
		NativeMethodInfoPtr_AddLog_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667493);
		NativeMethodInfoPtr_GetHobbyDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667494);
		NativeMethodInfoPtr_CheckHeroDetailDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667495);
		NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667496);
		NativeMethodInfoPtr_FindRandomSkill_Public_KungfuSkillLvData_Int32_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667497);
		NativeMethodInfoPtr_GoInPrison_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667498);
		NativeMethodInfoPtr_GoOutPrison_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667499);
		NativeMethodInfoPtr_GetRecruitCost_Public_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667500);
		NativeMethodInfoPtr_GetBodyGuardNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667501);
		NativeMethodInfoPtr_CanUseAttackSkill_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667502);
		NativeMethodInfoPtr_CanUseSkill_Public_Boolean_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667503);
		NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667504);
		NativeMethodInfoPtr_GetIdentifyKnowledge_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667505);
		NativeMethodInfoPtr_TryIdentifyAllItem_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667506);
		NativeMethodInfoPtr_SetNowActiveSkill_Public_Void_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667507);
		NativeMethodInfoPtr_GetNowActiveSkill_Public_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667508);
		NativeMethodInfoPtr_GetExtraMaxHp_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667509);
		NativeMethodInfoPtr_GetExtraMaxMana_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667510);
		NativeMethodInfoPtr_SetHpBar_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667511);
		NativeMethodInfoPtr_SetMpBar_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667512);
		NativeMethodInfoPtr_SetPowerBar_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667513);
		NativeMethodInfoPtr_SetNeedRemove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667514);
		NativeMethodInfoPtr_RandomBigMapMovePos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667515);
		NativeMethodInfoPtr_SetRandomEnemyBadFame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667516);
		NativeMethodInfoPtr_SameForce_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667517);
		NativeMethodInfoPtr_AutoGetFightExp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667518);
		NativeMethodInfoPtr_AutoGetFightExp_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667519);
		NativeMethodInfoPtr_StuffStoppable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667520);
		NativeMethodInfoPtr_RefreshHorseState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667521);
		NativeMethodInfoPtr_ManageHeroHorseRest_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667522);
		NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667523);
		NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667524);
		NativeMethodInfoPtr_ManageHeroHorseTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667525);
		NativeMethodInfoPtr_GetFinalTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667526);
		NativeMethodInfoPtr_GetTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667527);
		NativeMethodInfoPtr_GetWeighChangeTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667528);
		NativeMethodInfoPtr_GetWeatherChangeTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667529);
		NativeMethodInfoPtr_GetTerrainChangeTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667530);
		NativeMethodInfoPtr_GetTravelSpeed_Public_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667531);
		NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667532);
		NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667533);
		NativeMethodInfoPtr_GetHorseScore_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667534);
		NativeMethodInfoPtr_GetSeeRange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667535);
		NativeMethodInfoPtr_GetExploreStepRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667536);
		NativeMethodInfoPtr_MaxSelfCureTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667537);
		NativeMethodInfoPtr_GetSelfCureRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667538);
		NativeMethodInfoPtr_GetSelfCurePower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667539);
		NativeMethodInfoPtr_GetSelfCurePostureRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667540);
		NativeMethodInfoPtr_GetRestCureRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667541);
		NativeMethodInfoPtr_GetRestCurePower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667542);
		NativeMethodInfoPtr_GetRestCurePostureRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667543);
		NativeMethodInfoPtr_GetPostureCurePower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667544);
		NativeMethodInfoPtr_GetPostureCurePostureRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667545);
		NativeMethodInfoPtr_GetExtraStateValueRate_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667546);
		NativeMethodInfoPtr_GetExtraHpRecoverValueRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667547);
		NativeMethodInfoPtr_GetUseItemValue_Public_Single_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667548);
		NativeMethodInfoPtr_GetSelfCureValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667549);
		NativeMethodInfoPtr_GetRestValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667550);
		NativeMethodInfoPtr_GetPostureValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667551);
		NativeMethodInfoPtr_GetPostureValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667552);
		NativeMethodInfoPtr_BattleControlable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667553);
		NativeMethodInfoPtr_ItemControlable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667554);
		NativeMethodInfoPtr_ItemExchangeable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667555);
		NativeMethodInfoPtr_ItemLockable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667556);
		NativeMethodInfoPtr_PlayerLeadForce_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667557);
		NativeMethodInfoPtr_NoLoyal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667558);
		NativeMethodInfoPtr_ChangeLoyal_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667559);
		NativeMethodInfoPtr_ResetLoyal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667560);
		NativeMethodInfoPtr_GetLoyalWorkRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667561);
		NativeMethodInfoPtr_GetLoyalExpRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667562);
		NativeMethodInfoPtr_AutoChangeLoyal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667563);
		NativeMethodInfoPtr_JoinForceServant_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667564);
		NativeMethodInfoPtr_LeaveServantForce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667565);
		NativeMethodInfoPtr_SetForce_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667566);
		NativeMethodInfoPtr_JoinForce_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667567);
		NativeMethodInfoPtr_CheckOutForceContribution_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667568);
		NativeMethodInfoPtr_ClearContributionRecord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667569);
		NativeMethodInfoPtr_LeaveForce_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667570);
		NativeMethodInfoPtr_ClearForceJob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667571);
		NativeMethodInfoPtr_GetHeroSalary_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667572);
		NativeMethodInfoPtr_GetHeroPopulation_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667573);
		NativeMethodInfoPtr_FindSameBook_Public_ItemData_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667574);
		NativeMethodInfoPtr_HaveHobby_Public_Boolean_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667575);
		NativeMethodInfoPtr_AttackSkillSlotUnlocked_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667576);
		NativeMethodInfoPtr_FightReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667577);
		NativeMethodInfoPtr_FightSettingReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667578);
		NativeMethodInfoPtr_GetSkeletonGraphic_Public_SkeletonGraphic_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667579);
		NativeMethodInfoPtr_UseSpeSkeleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667580);
		NativeMethodInfoPtr_SetSkeletonGraphic_Public_Void_Transform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667581);
		NativeMethodInfoPtr_SetSkeletonGraphicSkinColor_Public_Void_SkeletonGraphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667582);
		NativeMethodInfoPtr_SetSkeletonGraphicFaceSlot_Public_Void_SkeletonGraphic_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667583);
		NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667584);
		NativeMethodInfoPtr_GetSkinName_Public_String_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667585);
		NativeMethodInfoPtr_GetDefaultSkinID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667586);
		NativeMethodInfoPtr_ResetDefaultSkin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667587);
		NativeMethodInfoPtr_SetSkin_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667588);
		NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_SkeletonAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667589);
		NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_SkeletonAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667590);
		NativeMethodInfoPtr_RefreshSkeletonHorse_Public_Void_SkeletonAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667591);
		NativeMethodInfoPtr_SetSkeletonSkinColor_Public_Void_SkeletonAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667592);
		NativeMethodInfoPtr_SetSkeletonFaceSlot_Public_Void_SkeletonAnimation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667593);
		NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667594);
		NativeMethodInfoPtr_GetHeroWeaponAttackAnim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667595);
		NativeMethodInfoPtr_SetSkillWeapon_Public_Void_SkeletonAnimation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667596);
		NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667597);
		NativeMethodInfoPtr_GetFightScore_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667598);
		NativeMethodInfoPtr_GetHpPercent_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667599);
		NativeMethodInfoPtr_GetManaPercent_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667600);
		NativeMethodInfoPtr_GetPowerPercent_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667601);
		NativeMethodInfoPtr_GetFullRecoverTime_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667602);
		NativeMethodInfoPtr_GetRecoverRate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667603);
		NativeMethodInfoPtr_GetAttriRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667604);
		NativeMethodInfoPtr_ManageTagTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667605);
		NativeMethodInfoPtr_HaveTag_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667606);
		NativeMethodInfoPtr_AddTag_Public_Void_Int32_Single_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667607);
		NativeMethodInfoPtr_FindTag_Public_HeroTagData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667608);
		NativeMethodInfoPtr_RemoveTag_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667609);
		NativeMethodInfoPtr_RemoveTag_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667610);
		NativeMethodInfoPtr_DisUnderstandTag_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667611);
		NativeMethodInfoPtr_UnderstandTag_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667612);
		NativeMethodInfoPtr_UnderstandTag_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667613);
		NativeMethodInfoPtr_ClearAllTempTag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667614);
		NativeMethodInfoPtr_AddBuff_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667615);
		NativeMethodInfoPtr_AttackSelfTeam_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667616);
		NativeMethodInfoPtr_HeroName_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667617);
		NativeMethodInfoPtr_CanSetName_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667618);
		NativeMethodInfoPtr_HaveSetName_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667619);
		NativeMethodInfoPtr_HeroFamilyName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667620);
		NativeMethodInfoPtr_GetHeroName_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667621);
		NativeMethodInfoPtr_GetHeroForceLvDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667622);
		NativeMethodInfoPtr_GetHeroForceLvDescribeSimplify_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667623);
		NativeMethodInfoPtr_GetBetrayForceBadTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667624);
		NativeMethodInfoPtr_GetBetrayForceBadFame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667625);
		NativeMethodInfoPtr_CanPlayerMeet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667626);
		NativeMethodInfoPtr_GetMeetNeedFame_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667627);
		NativeMethodInfoPtr_GetMaxFavor_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667628);
		NativeMethodInfoPtr_GetNatureFavorRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667629);
		NativeMethodInfoPtr_GetFavorRate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667630);
		NativeMethodInfoPtr_ChangeFavor_Public_Void_Single_Boolean_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667631);
		NativeMethodInfoPtr_GetStartFavor_Public_Single_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667632);
		NativeMethodInfoPtr_SetHeroMeet_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667633);
		NativeMethodInfoPtr_SetMeetFavor_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_SetFavor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667635);
		NativeMethodInfoPtr_HaveFriend_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667636);
		NativeMethodInfoPtr_AddFriend_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667637);
		NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667638);
		NativeMethodInfoPtr_HaveHater_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667639);
		NativeMethodInfoPtr_AddHater_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667640);
		NativeMethodInfoPtr_RemoveHater_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667641);
		NativeMethodInfoPtr_HaveBrother_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667642);
		NativeMethodInfoPtr_AddBrother_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667643);
		NativeMethodInfoPtr_RemoveBrother_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667644);
		NativeMethodInfoPtr_RemoveRelative_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667645);
		NativeMethodInfoPtr_HaveTeacher_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667646);
		NativeMethodInfoPtr_GetTeacher_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667647);
		NativeMethodInfoPtr_HaveStudent_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667648);
		NativeMethodInfoPtr_AddStudent_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667649);
		NativeMethodInfoPtr_RemoveStudent_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667650);
		NativeMethodInfoPtr_RemoveAllStudent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667651);
		NativeMethodInfoPtr_HaveLover_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667652);
		NativeMethodInfoPtr_SetLover_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667653);
		NativeMethodInfoPtr_RemoveLover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667654);
		NativeMethodInfoPtr_HavePrelover_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667655);
		NativeMethodInfoPtr_AddPrelover_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667656);
		NativeMethodInfoPtr_RemovePrelover_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667657);
		NativeMethodInfoPtr_RemoveAllPrelover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667658);
		NativeMethodInfoPtr_CheckPlayerMakeLoverUnhappy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667659);
		NativeMethodInfoPtr_RemoveTeacher_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667660);
		NativeMethodInfoPtr_GetRelationShipText_Public_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667661);
		NativeMethodInfoPtr_HaveRelationBetterThanFriend_Public_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667662);
		NativeMethodInfoPtr_HaveTeacherStudentRelation_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667663);
		NativeMethodInfoPtr_AutoFightQuickChangeState_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667664);
		NativeMethodInfoPtr_ChangeHp_Public_Void_Single_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667665);
		NativeMethodInfoPtr_DeadToAlive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667666);
		NativeMethodInfoPtr_ChangeMaxHp_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667667);
		NativeMethodInfoPtr_ChangeMana_Public_Void_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667668);
		NativeMethodInfoPtr_ChangeMaxMana_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667669);
		NativeMethodInfoPtr_ChangePower_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667670);
		NativeMethodInfoPtr_ChangeMaxPower_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667671);
		NativeMethodInfoPtr_GetWoundResist_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667672);
		NativeMethodInfoPtr_GetDamageResist_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667673);
		NativeMethodInfoPtr_ChangeRandomInjury_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667674);
		NativeMethodInfoPtr_ChangeExternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667675);
		NativeMethodInfoPtr_ChangeInternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667676);
		NativeMethodInfoPtr_ChangePoisonInjury_Public_Single_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667677);
		NativeMethodInfoPtr_FullRecover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667678);
		NativeMethodInfoPtr_GetTotalInjury_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667679);
		NativeMethodInfoPtr_AutoCureSelfInjury_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667680);
		NativeMethodInfoPtr_GetSelfCureInjury_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667681);
		NativeMethodInfoPtr_GetSelfCureExternalInjurySkill_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667682);
		NativeMethodInfoPtr_GetSelfCureExternalInjury_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667683);
		NativeMethodInfoPtr_GetSelfCureExternalInjuryTime_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667684);
		NativeMethodInfoPtr_GetSelfCureInternalInjurySkill_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667685);
		NativeMethodInfoPtr_GetSelfCureInternalInjury_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667686);
		NativeMethodInfoPtr_GetSelfCureInternalInjuryTime_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667687);
		NativeMethodInfoPtr_GetSelfCurePoisonInjurySkill_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667688);
		NativeMethodInfoPtr_GetSelfCurePoisonInjury_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667689);
		NativeMethodInfoPtr_GetSelfCurePoisonInjuryTime_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667690);
		NativeMethodInfoPtr_ChangeLivingSkillExp_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667691);
		NativeMethodInfoPtr_GetLivingSkillExpMax_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667692);
		NativeMethodInfoPtr_ChangeLivingSkill_Public_Void_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667693);
		NativeMethodInfoPtr_ChangeFightSkill_Public_Void_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667694);
		NativeMethodInfoPtr_ChangeAttri_Public_Void_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667695);
		NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_EquipmentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667696);
		NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667697);
		NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667698);
		NativeMethodInfoPtr_ChangeMaxAttri_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667699);
		NativeMethodInfoPtr_ChangeMaxFightSkill_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667700);
		NativeMethodInfoPtr_ChangeMaxLivingSkill_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667701);
		NativeMethodInfoPtr_ChangeAttriAndSkill_Public_Void_HeroSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667702);
		NativeMethodInfoPtr_GetMaxAttri_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667703);
		NativeMethodInfoPtr_GetMaxFightSkill_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667704);
		NativeMethodInfoPtr_GetMaxLivingSkill_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667705);
		NativeMethodInfoPtr_RefreshMaxAttriAndSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667706);
		NativeMethodInfoPtr_GetBaseMoveRange_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667707);
		NativeMethodInfoPtr_GetMoveRange_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667708);
		NativeMethodInfoPtr_GetBounty_Public_Void_Int32_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667709);
		NativeMethodInfoPtr_ChangeMoney_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667710);
		NativeMethodInfoPtr_ChangeFame_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667711);
		NativeMethodInfoPtr_CheckHeroFameForceLv_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667712);
		NativeMethodInfoPtr_GetFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667713);
		NativeMethodInfoPtr_GetGameDifficultyFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667714);
		NativeMethodInfoPtr_GetGovernReduceBadFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667715);
		NativeMethodInfoPtr_GetGovernExtraFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667716);
		NativeMethodInfoPtr_GetHornorReduceBadFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667717);
		NativeMethodInfoPtr_GetHornorAddFavorRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667718);
		NativeMethodInfoPtr_GetBountyPirce_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667719);
		NativeMethodInfoPtr_GetBadFameFineMoney_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667720);
		NativeMethodInfoPtr_ManageAIInPrison_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667721);
		NativeMethodInfoPtr_ChangeBadFame_Public_Void_Single_Boolean_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667722);
		NativeMethodInfoPtr_GetBadFameRate_Public_Single_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667723);
		NativeMethodInfoPtr_IsPlayerSameForce_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667724);
		NativeMethodInfoPtr_GetHeroGovernName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667725);
		NativeMethodInfoPtr_GetHeroHornorName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667726);
		NativeMethodInfoPtr_GetHornorChangeMaxArea_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667727);
		NativeMethodInfoPtr_GetHornorUpgradeCost_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667728);
		NativeMethodInfoPtr_GetGovernUpgradeCost_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667729);
		NativeMethodInfoPtr_ChangeGovernContribution_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667730);
		NativeMethodInfoPtr_ChangeGovernLv_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667731);
		NativeMethodInfoPtr_ChangeHornorLv_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667732);
		NativeMethodInfoPtr_OutsideForceExtraContributionRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667733);
		NativeMethodInfoPtr_SelfForceContrituion_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667734);
		NativeMethodInfoPtr_ChangeForceContribution_Public_Void_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667735);
		NativeMethodInfoPtr_ChangeHeroForceLv_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667736);
		NativeMethodInfoPtr_ManageHeroForceLvChangeMaxAttri_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667737);
		NativeMethodInfoPtr_RefreshHeroSalaryAndPopulation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667738);
		NativeMethodInfoPtr_SetHeroForceLv_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667739);
		NativeMethodInfoPtr_BattleChangeSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667740);
		NativeMethodInfoPtr_AddSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667741);
		NativeMethodInfoPtr_GetFightExpRate_Public_Single_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667742);
		NativeMethodInfoPtr_AddSkillBookExp_Public_Void_Single_KungfuSkillLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667743);
		NativeMethodInfoPtr_GetBookExpRate_Public_Single_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667744);
		NativeMethodInfoPtr_GetForceBookStorageExpRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667745);
		NativeMethodInfoPtr_GetGameDifficultyExpRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667746);
		NativeMethodInfoPtr_CheckSkillUpgrade_Public_Void_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667747);
		NativeMethodInfoPtr_UpgradeSkill_Public_Void_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667748);
		NativeMethodInfoPtr_GetSkill_Public_KungfuSkillLvData_KungfuSkillLvData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667749);
		NativeMethodInfoPtr_FindSkill_Public_KungfuSkillLvData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667750);
		NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667751);
		NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667752);
		NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667753);
		NativeMethodInfoPtr_ManageGetItemPoison_Public_Single_ItemData_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667754);
		NativeMethodInfoPtr_ManageGetEquipPoison_Public_Single_ItemData_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667755);
		NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667756);
		NativeMethodInfoPtr_RandomAttriAndSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667757);
		NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667758);
		NativeMethodInfoPtr_LoseAllItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667759);
		NativeMethodInfoPtr_LoseAllSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667760);
		NativeMethodInfoPtr_LoseSkill_Public_Void_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667761);
		NativeMethodInfoPtr_EquipSkill_Public_Void_KungfuSkillLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667762);
		NativeMethodInfoPtr_UnequipSkill_Public_Void_KungfuSkillLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667763);
		NativeMethodInfoPtr_EquipHorse_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667764);
		NativeMethodInfoPtr_UnequipHorse_Public_Void_ItemData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667765);
		NativeMethodInfoPtr_EquipItem_Public_Void_ItemData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667766);
		NativeMethodInfoPtr_UnequipItem_Public_Void_ItemData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667767);
		NativeMethodInfoPtr_CosumeMedFood_Public_Void_ItemData_Boolean_HeroData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667768);
		NativeMethodInfoPtr_UseMedFood_Public_Void_ItemData_Boolean_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667769);
		NativeMethodInfoPtr_GetFoodSpeBuff_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667770);
		NativeMethodInfoPtr_GetWineSpeBuff_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667771);
		NativeMethodInfoPtr_GetDebateSpeBuff_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667772);
		NativeMethodInfoPtr_AddTempTag_Public_Void_HeroTagDataBase_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667773);
		NativeMethodInfoPtr_UpgradeTempTag_Public_Void_String_HeroSpeAddDataType_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667774);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667775);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667776);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667777);
		NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667778);
		NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667779);
		NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667780);
		NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667781);
		NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667782);
		NativeMethodInfoPtr_GetArea_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667783);
		NativeMethodInfoPtr_GetForce_Public_ForceData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667784);
		NativeMethodInfoPtr_GetForceLeader_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667785);
		NativeMethodInfoPtr_GetUpgradeForceLvNeedText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667786);
		NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667787);
		NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667788);
		NativeMethodInfoPtr_GetTotalAttir_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667789);
		NativeMethodInfoPtr_GetTotalFightSkill_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667790);
		NativeMethodInfoPtr_GetTotalLivingSkill_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667791);
		NativeMethodInfoPtr_GetDebateScore_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667792);
		NativeMethodInfoPtr_GetItemFavorValue_Public_Single_ItemData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667793);
		NativeMethodInfoPtr_FullState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667794);
		NativeMethodInfoPtr_RecoverState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667795);
		NativeMethodInfoPtr_GetMaxBuyValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667796);
		NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667797);
		NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667798);
		NativeMethodInfoPtr_GetFavorValueRate_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667799);
		NativeMethodInfoPtr_GetForceStorageDiscount_Public_Single_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667800);
		NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667801);
		NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667802);
		NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667803);
		NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667804);
		NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionData_MissionTargetType_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667805);
		NativeMethodInfoPtr_GetHeroItemLv_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667806);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667807);
		NativeMethodInfoPtr__RandomAttriAndSkill_b__516_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667808);
		NativeMethodInfoPtr__RandomAttriAndSkill_b__516_1_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroData>.NativeClassPtr, 100667809);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 126857, RefRangeEnd = 126863, XrefRangeStart = 126406, XrefRangeEnd = 126857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126863, XrefRangeEnd = 126985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSerializingMethod(StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSerializingMethod_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126985, XrefRangeEnd = 127087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeserializedMethod(StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127104, RefRangeEnd = 127105, XrefRangeStart = 127087, XrefRangeEnd = 127104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateFaceCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateFaceCode_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127117, RefRangeEnd = 127118, XrefRangeStart = 127105, XrefRangeEnd = 127117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadFaceCode(string faceCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(faceCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFaceCode_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127126, RefRangeEnd = 127129, XrefRangeStart = 127118, XrefRangeEnd = 127126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxTagNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTagNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127135, RefRangeEnd = 127138, XrefRangeStart = 127129, XrefRangeEnd = 127135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalTagPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalTagPoint_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(86)]
	[CachedScanResults(RefRangeStart = 127153, RefRangeEnd = 127239, XrefRangeStart = 127138, XrefRangeEnd = 127153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveForceFunction(int forceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveForceFunction_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 127245, RefRangeEnd = 127258, XrefRangeStart = 127239, XrefRangeEnd = 127245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWeaponResearchWeaponType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeaponResearchWeaponType_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127265, RefRangeEnd = 127266, XrefRangeStart = 127258, XrefRangeEnd = 127265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveSpeInteractWithNPC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveSpeInteractWithNPC_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 127277, RefRangeEnd = 127283, XrefRangeStart = 127266, XrefRangeEnd = 127277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMeditationTopic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeditationTopic_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 127287, RefRangeEnd = 127294, XrefRangeStart = 127283, XrefRangeEnd = 127287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroID(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127298, RefRangeEnd = 127300, XrefRangeStart = 127294, XrefRangeEnd = 127298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetHeroSkillID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetHeroSkillID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127315, RefRangeEnd = 127317, XrefRangeStart = 127300, XrefRangeEnd = 127315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAskJoinTeamNeedFavor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAskJoinTeamNeedFavor_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 127327, RefRangeEnd = 127331, XrefRangeStart = 127317, XrefRangeEnd = 127327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSpeTeammate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSpeTeammate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127331, XrefRangeEnd = 127346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAutoSetting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 127370, RefRangeEnd = 127374, XrefRangeStart = 127346, XrefRangeEnd = 127370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPreferWeaponType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferWeaponType_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127447, RefRangeEnd = 127449, XrefRangeStart = 127374, XrefRangeEnd = 127447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RandomFaceData(bool includeNoRandom = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeNoRandom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomFaceData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 127454, RefRangeEnd = 127480, XrefRangeStart = 127449, XrefRangeEnd = 127454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetSkinColorByDark()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinColorByDark_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 127485, RefRangeEnd = 127490, XrefRangeStart = 127480, XrefRangeEnd = 127485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveMission(string targetMissionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMissionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveMission_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127497, RefRangeEnd = 127499, XrefRangeStart = 127490, XrefRangeEnd = 127497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionData FindMission(string targetMissionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMissionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMission_Public_MissionData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127520, RefRangeEnd = 127523, XrefRangeStart = 127499, XrefRangeEnd = 127520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MissionKeepInTeam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MissionKeepInTeam_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 127528, RefRangeEnd = 127532, XrefRangeStart = 127523, XrefRangeEnd = 127528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHeroPermanentTagNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroPermanentTagNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 127536, RefRangeEnd = 127542, XrefRangeStart = 127532, XrefRangeEnd = 127536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetEquipmentWeightLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipmentWeightLv_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127542, RefRangeEnd = 127544, XrefRangeStart = 127542, XrefRangeEnd = 127542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMissMeetingReduceContribution()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissMeetingReduceContribution_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127548, RefRangeEnd = 127549, XrefRangeStart = 127544, XrefRangeEnd = 127548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHitMoveRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHitMoveRange_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 127556, RefRangeEnd = 127562, XrefRangeStart = 127549, XrefRangeEnd = 127556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float UsePoisonRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsePoisonRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127633, RefRangeEnd = 127634, XrefRangeStart = 127562, XrefRangeEnd = 127633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManagePoisonEquipment(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagePoisonEquipment_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127634, XrefRangeEnd = 127655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManagePoisonItem(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagePoisonItem_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 127657, RefRangeEnd = 127663, XrefRangeStart = 127655, XrefRangeEnd = 127657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFameForceLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFameForceLv_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127664, RefRangeEnd = 127666, XrefRangeStart = 127663, XrefRangeEnd = 127664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNextForceLvFame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextForceLvFame_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127675, RefRangeEnd = 127677, XrefRangeStart = 127666, XrefRangeEnd = 127675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFightTime(HeroData enemyData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enemyData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFightTime_Public_Int32_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127686, RefRangeEnd = 127689, XrefRangeStart = 127677, XrefRangeEnd = 127686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroAIData(HeroAIData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroAIData_Public_Void_HeroAIData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 127689, RefRangeEnd = 127704, XrefRangeStart = 127689, XrefRangeEnd = 127689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127711, RefRangeEnd = 127713, XrefRangeStart = 127704, XrefRangeEnd = 127711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillMaxPracticeExpData GetSkillMaxPracticeExp(int targetID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillMaxPracticeExp_Public_SkillMaxPracticeExpData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillMaxPracticeExpData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127724, RefRangeEnd = 127726, XrefRangeStart = 127713, XrefRangeEnd = 127724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSkillMaxPracticeExp(SkillMaxPracticeExpData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSkillMaxPracticeExp_Public_Void_SkillMaxPracticeExpData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127741, RefRangeEnd = 127744, XrefRangeStart = 127726, XrefRangeEnd = 127741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeTagPoint(float delta, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delta);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTagPoint_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 127748, RefRangeEnd = 127753, XrefRangeStart = 127744, XrefRangeEnd = 127748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkeletonHorseIdleAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonHorseIdleAnim_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 127757, RefRangeEnd = 127761, XrefRangeStart = 127753, XrefRangeEnd = 127757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkeletonHorseRunAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonHorseRunAnim_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127765, RefRangeEnd = 127766, XrefRangeStart = 127761, XrefRangeEnd = 127765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkeletonHorseWalkAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonHorseWalkAnim_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127766, XrefRangeEnd = 127767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceJobEffectSkillNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127809, RefRangeEnd = 127811, XrefRangeStart = 127767, XrefRangeEnd = 127809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceJobEffectSkillNum(int jobType, int jobID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jobType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceJobEffectSkillNum_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127822, RefRangeEnd = 127824, XrefRangeStart = 127811, XrefRangeEnd = 127822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceJobSpeAddResult(int forceSpeAddDataType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceSpeAddDataType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceJobSpeAddResult_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127852, RefRangeEnd = 127853, XrefRangeStart = 127824, XrefRangeEnd = 127852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MeetForceJobRequire(int jobType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&jobType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeetForceJobRequire_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 127856, RefRangeEnd = 127876, XrefRangeStart = 127853, XrefRangeEnd = 127856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAISettingPriorityLv(AISettingType targetType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAISettingPriorityLv_Public_Int32_AISettingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 127879, RefRangeEnd = 127890, XrefRangeStart = 127876, XrefRangeEnd = 127879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAISettingFocus(AISettingType targetType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAISettingFocus_Public_Int32_AISettingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(74)]
	[CachedScanResults(RefRangeStart = 127891, RefRangeEnd = 127965, XrefRangeStart = 127890, XrefRangeEnd = 127891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Favor(bool floorToInt = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&floorToInt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Favor_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 127965, RefRangeEnd = 127977, XrefRangeStart = 127965, XrefRangeEnd = 127965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxTeamMate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTeamMate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 127965, RefRangeEnd = 127977, XrefRangeStart = 127965, XrefRangeEnd = 127977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxStudent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxStudent_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127980, RefRangeEnd = 127981, XrefRangeStart = 127977, XrefRangeEnd = 127980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxDoctorTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxDoctorTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127995, RefRangeEnd = 127996, XrefRangeStart = 127981, XrefRangeEnd = 127995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBaseAttriNum(BaseAttriType targetAttri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetAttri);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseAttriNum_Public_Single_BaseAttriType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128093, RefRangeEnd = 128095, XrefRangeStart = 127996, XrefRangeEnd = 128093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroFavorUI(GameObject heroFavorUI, bool showFullInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroFavorUI);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showFullInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroFavorUI_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128095, XrefRangeEnd = 128106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFullSetName(bool useGrayColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useGrayColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullSetName_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128556, RefRangeEnd = 128558, XrefRangeStart = 128106, XrefRangeEnd = 128556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetQuickDetail(bool fullDetail, bool showForceContribution = false, bool showTagPoint = false, bool showSkillNum = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fullDetail);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showForceContribution;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showTagPoint;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showSkillNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuickDetail_Public_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128587, RefRangeEnd = 128590, XrefRangeStart = 128558, XrefRangeEnd = 128587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSkillPower(SkillChangePowerType skillChangePowerType, float deltaPower = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&skillChangePowerType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaPower;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSkillPower_Public_Void_SkillChangePowerType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128590, XrefRangeEnd = 128592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillPowerChargeSpeed(FightSkillType targetSkillType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetSkillType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillPowerChargeSpeed_Public_Single_FightSkillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 128597, RefRangeEnd = 128687, XrefRangeStart = 128592, XrefRangeEnd = 128597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Name(bool colored)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&colored);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Name_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 128697, RefRangeEnd = 128701, XrefRangeStart = 128687, XrefRangeEnd = 128697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeForceLvNeedSkillNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeForceLvNeedSkillNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 128710, RefRangeEnd = 128716, XrefRangeStart = 128701, XrefRangeEnd = 128710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillRareLvExpRate(int targetRareLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetRareLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillRareLvExpRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128720, RefRangeEnd = 128723, XrefRangeStart = 128716, XrefRangeEnd = 128720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBountyMissionNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBountyMissionNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128727, RefRangeEnd = 128730, XrefRangeStart = 128723, XrefRangeEnd = 128727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxBountyMissionNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxBountyMissionNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128730, RefRangeEnd = 128732, XrefRangeStart = 128730, XrefRangeEnd = 128730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSelfHouseTotalAdd(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSelfHouseTotalAdd_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 128741, RefRangeEnd = 128750, XrefRangeStart = 128732, XrefRangeEnd = 128741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayHeroSound(AudioClip targetClip, float volume = 1f, float pitch = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetClip);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayHeroSound_Public_Void_AudioClip_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128759, RefRangeEnd = 128760, XrefRangeStart = 128750, XrefRangeEnd = 128759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroLittleTalkSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroLittleTalkSound_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128761, RefRangeEnd = 128762, XrefRangeStart = 128760, XrefRangeEnd = 128761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeroSoundVoiceAgePitch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroSoundVoiceAgePitch_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128762, XrefRangeEnd = 128763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeroSoundAgePitch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroSoundAgePitch_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetHeroSoundAgeID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroSoundAgeID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 128772, RefRangeEnd = 128778, XrefRangeStart = 128763, XrefRangeEnd = 128772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroMeetSound(string meetType = "Meet")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(meetType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroMeetSound_Public_AudioClip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128798, RefRangeEnd = 128799, XrefRangeStart = 128778, XrefRangeEnd = 128798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroShoutSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroShoutSound_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128809, RefRangeEnd = 128812, XrefRangeStart = 128799, XrefRangeEnd = 128809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroHurtSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroHurtSound_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128812, XrefRangeEnd = 128822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroDieSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroDieSound_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128822, XrefRangeEnd = 128831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetHeroRecoverSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroRecoverSound_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 128866, RefRangeEnd = 128874, XrefRangeStart = 128831, XrefRangeEnd = 128866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAreaID(bool includeNearArea)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeNearArea);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaID_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 128893, RefRangeEnd = 128926, XrefRangeStart = 128874, XrefRangeEnd = 128893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string AtAreaName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AtAreaName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128936, RefRangeEnd = 128938, XrefRangeStart = 128926, XrefRangeEnd = 128936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigMapPos GetBigMapPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBigMapPos_Public_BigMapPos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigMapPos>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128948, RefRangeEnd = 128949, XrefRangeStart = 128938, XrefRangeEnd = 128948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRecordLog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecordLog_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 128991, RefRangeEnd = 129030, XrefRangeStart = 128949, XrefRangeEnd = 128991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLog(string newLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newLog);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLog_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129045, RefRangeEnd = 129048, XrefRangeStart = 129030, XrefRangeEnd = 129045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHobbyDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHobbyDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 129057, RefRangeEnd = 129067, XrefRangeStart = 129048, XrefRangeEnd = 129057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckHeroDetailDirty(bool forceCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroDetailDirty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 129068, RefRangeEnd = 129076, XrefRangeStart = 129067, XrefRangeEnd = 129068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData FindRandomItem(int minItemLv, int maxItemLv, bool includeEquipment, int targetItemType = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minItemLv);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxItemLv;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeEquipment;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetItemType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 129101, RefRangeEnd = 129106, XrefRangeStart = 129076, XrefRangeEnd = 129101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillLvData FindRandomSkill(int maxSkillRareLv, HeroData exclusiveHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maxSkillRareLv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exclusiveHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRandomSkill_Public_KungfuSkillLvData_Int32_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129106, RefRangeEnd = 129108, XrefRangeStart = 129106, XrefRangeEnd = 129106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoInPrison()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoInPrison_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129108, RefRangeEnd = 129110, XrefRangeStart = 129108, XrefRangeEnd = 129108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoOutPrison()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoOutPrison_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 129115, RefRangeEnd = 129125, XrefRangeStart = 129110, XrefRangeEnd = 129115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRecruitCost(bool tempRecruit, float rate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tempRecruit);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecruitCost_Public_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129135, RefRangeEnd = 129137, XrefRangeStart = 129125, XrefRangeEnd = 129135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBodyGuardNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyGuardNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129142, RefRangeEnd = 129143, XrefRangeStart = 129137, XrefRangeEnd = 129142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUseAttackSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseAttackSkill_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 129151, RefRangeEnd = 129156, XrefRangeStart = 129143, XrefRangeEnd = 129151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUseSkill(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseSkill_Public_Boolean_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 129157, RefRangeEnd = 129162, XrefRangeStart = 129156, XrefRangeEnd = 129157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 129166, RefRangeEnd = 129175, XrefRangeStart = 129162, XrefRangeEnd = 129166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetIdentifyKnowledge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIdentifyKnowledge_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129200, RefRangeEnd = 129202, XrefRangeStart = 129175, XrefRangeEnd = 129200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryIdentifyAllItem(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryIdentifyAllItem_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129208, RefRangeEnd = 129210, XrefRangeStart = 129202, XrefRangeEnd = 129208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNowActiveSkill(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNowActiveSkill_Public_Void_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 129211, RefRangeEnd = 129293, XrefRangeStart = 129210, XrefRangeEnd = 129211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillLvData GetNowActiveSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNowActiveSkill_Public_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 129295, RefRangeEnd = 129301, XrefRangeStart = 129293, XrefRangeEnd = 129295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraMaxHp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraMaxHp_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 129303, RefRangeEnd = 129309, XrefRangeStart = 129301, XrefRangeEnd = 129303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraMaxMana()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraMaxMana_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 129349, RefRangeEnd = 129356, XrefRangeStart = 129309, XrefRangeEnd = 129349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHpBar(GameObject hpBarRoot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hpBarRoot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHpBar_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 129396, RefRangeEnd = 129401, XrefRangeStart = 129356, XrefRangeEnd = 129396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMpBar(GameObject mpBarRoot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mpBarRoot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMpBar_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129441, RefRangeEnd = 129443, XrefRangeStart = 129401, XrefRangeEnd = 129441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPowerBar(GameObject powerBarRoot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)powerBarRoot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPowerBar_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 129457, RefRangeEnd = 129472, XrefRangeStart = 129443, XrefRangeEnd = 129457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNeedRemove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNeedRemove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129482, RefRangeEnd = 129484, XrefRangeStart = 129472, XrefRangeEnd = 129482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RandomBigMapMovePos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomBigMapMovePos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129492, RefRangeEnd = 129494, XrefRangeStart = 129484, XrefRangeEnd = 129492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandomEnemyBadFame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandomEnemyBadFame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129494, RefRangeEnd = 129496, XrefRangeStart = 129494, XrefRangeEnd = 129494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SameForce(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SameForce_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129496, XrefRangeEnd = 129497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoGetFightExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoGetFightExp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 129530, RefRangeEnd = 129536, XrefRangeStart = 129497, XrefRangeEnd = 129530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoGetFightExp(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoGetFightExp_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 129543, RefRangeEnd = 129547, XrefRangeStart = 129536, XrefRangeEnd = 129543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StuffStoppable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StuffStoppable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 129560, RefRangeEnd = 129564, XrefRangeStart = 129547, XrefRangeEnd = 129560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHorseState(bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHorseState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129564, XrefRangeEnd = 129568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageHeroHorseRest(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroHorseRest_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129569, RefRangeEnd = 129570, XrefRangeStart = 129568, XrefRangeEnd = 129569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageHeroHorseMove(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129581, RefRangeEnd = 129583, XrefRangeStart = 129570, XrefRangeEnd = 129581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageHeroHorseMove(float deltaTime, bool isInSafeArea)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deltaTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInSafeArea;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroHorseMove_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129584, RefRangeEnd = 129586, XrefRangeStart = 129583, XrefRangeEnd = 129584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageHeroHorseTime(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroHorseTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 129607, RefRangeEnd = 129611, XrefRangeStart = 129586, XrefRangeEnd = 129607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFinalTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129614, RefRangeEnd = 129615, XrefRangeStart = 129611, XrefRangeEnd = 129614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129615, RefRangeEnd = 129618, XrefRangeStart = 129615, XrefRangeEnd = 129615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWeighChangeTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeighChangeTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129631, RefRangeEnd = 129634, XrefRangeStart = 129618, XrefRangeEnd = 129631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWeatherChangeTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeatherChangeTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 129639, RefRangeEnd = 129645, XrefRangeStart = 129634, XrefRangeEnd = 129639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainChangeTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainChangeTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 129655, RefRangeEnd = 129660, XrefRangeStart = 129645, XrefRangeEnd = 129655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTravelSpeed(bool havePower, bool isSprint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&havePower);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSprint;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTravelSpeed_Public_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129660, RefRangeEnd = 129662, XrefRangeStart = 129660, XrefRangeEnd = 129660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129662, RefRangeEnd = 129663, XrefRangeStart = 129662, XrefRangeEnd = 129662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseTravelSpeed(bool havePower, bool isSprint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&havePower);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSprint;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseTravelSpeed_Public_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129667, RefRangeEnd = 129669, XrefRangeStart = 129663, XrefRangeEnd = 129667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseScore_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129672, RefRangeEnd = 129673, XrefRangeStart = 129669, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSeeRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSeeRange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129676, RefRangeEnd = 129678, XrefRangeStart = 129673, XrefRangeEnd = 129676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExploreStepRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExploreStepRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129678, RefRangeEnd = 129681, XrefRangeStart = 129678, XrefRangeEnd = 129678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int MaxSelfCureTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxSelfCureTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetSelfCureRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetSelfCurePower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCurePower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetSelfCurePostureRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCurePostureRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetRestCureRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRestCureRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetRestCurePower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRestCurePower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetRestCurePostureRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRestCurePostureRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129681, RefRangeEnd = 129682, XrefRangeStart = 129681, XrefRangeEnd = 129681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPostureCurePower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPostureCurePower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetPostureCurePostureRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPostureCurePostureRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 129682, RefRangeEnd = 129697, XrefRangeStart = 129682, XrefRangeEnd = 129682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetExtraStateValueRate(float statePercent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&statePercent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraStateValueRate_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129697, RefRangeEnd = 129698, XrefRangeStart = 129697, XrefRangeEnd = 129697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraHpRecoverValueRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraHpRecoverValueRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129722, RefRangeEnd = 129724, XrefRangeStart = 129698, XrefRangeEnd = 129722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetUseItemValue(ItemData targetItem, bool useExtraStateValueRate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useExtraStateValueRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUseItemValue_Public_Single_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129732, RefRangeEnd = 129733, XrefRangeStart = 129724, XrefRangeEnd = 129732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129742, RefRangeEnd = 129743, XrefRangeStart = 129733, XrefRangeEnd = 129742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRestValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRestValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129746, RefRangeEnd = 129747, XrefRangeStart = 129743, XrefRangeEnd = 129746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPostureValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPostureValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129762, RefRangeEnd = 129765, XrefRangeStart = 129747, XrefRangeEnd = 129762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPostureValue(float recoverRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recoverRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPostureValue_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 129774, RefRangeEnd = 129778, XrefRangeStart = 129765, XrefRangeEnd = 129774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BattleControlable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BattleControlable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 129790, RefRangeEnd = 129797, XrefRangeStart = 129778, XrefRangeEnd = 129790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ItemControlable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemControlable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 129808, RefRangeEnd = 129812, XrefRangeStart = 129797, XrefRangeEnd = 129808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ItemExchangeable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemExchangeable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129812, RefRangeEnd = 129815, XrefRangeStart = 129812, XrefRangeEnd = 129812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ItemLockable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemLockable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool PlayerLeadForce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerLeadForce_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129815, RefRangeEnd = 129816, XrefRangeStart = 129815, XrefRangeEnd = 129815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NoLoyal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NoLoyal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 129857, RefRangeEnd = 129869, XrefRangeStart = 129816, XrefRangeEnd = 129857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeLoyal(float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeLoyal_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129870, RefRangeEnd = 129873, XrefRangeStart = 129869, XrefRangeEnd = 129870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetLoyal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetLoyal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 129873, RefRangeEnd = 129879, XrefRangeStart = 129873, XrefRangeEnd = 129873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLoyalWorkRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoyalWorkRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129879, RefRangeEnd = 129882, XrefRangeStart = 129879, XrefRangeEnd = 129879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLoyalExpRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoyalExpRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129887, RefRangeEnd = 129888, XrefRangeStart = 129882, XrefRangeEnd = 129887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoChangeLoyal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoChangeLoyal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129912, RefRangeEnd = 129913, XrefRangeStart = 129888, XrefRangeEnd = 129912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinForceServant(int _forceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_forceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinForceServant_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129938, RefRangeEnd = 129939, XrefRangeStart = 129913, XrefRangeEnd = 129938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveServantForce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveServantForce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129950, RefRangeEnd = 129953, XrefRangeStart = 129939, XrefRangeEnd = 129950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForce(int _forceID, int _forceLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_forceID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForce_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 130039, RefRangeEnd = 130055, XrefRangeStart = 129953, XrefRangeEnd = 130039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinForce(int _forceID, int _forceLv = -1, int _generation = -1, bool showInfo = true, bool setTeacherToLeader = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_forceID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLv;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_generation;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &setTeacherToLeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinForce_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130055, XrefRangeEnd = 130063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckOutForceContribution()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckOutForceContribution_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ClearContributionRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearContributionRecord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 130256, RefRangeEnd = 130263, XrefRangeStart = 130063, XrefRangeEnd = 130256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveForce(bool showInfo, bool removeTeacher = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&showInfo);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeTeacher;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveForce_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130276, RefRangeEnd = 130277, XrefRangeStart = 130263, XrefRangeEnd = 130276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearForceJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearForceJob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130278, RefRangeEnd = 130279, XrefRangeStart = 130277, XrefRangeEnd = 130278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHeroSalary(int _forceLv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_forceLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroSalary_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130280, RefRangeEnd = 130281, XrefRangeStart = 130279, XrefRangeEnd = 130280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHeroPopulation(int _forceLv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_forceLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroPopulation_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 130297, RefRangeEnd = 130300, XrefRangeStart = 130281, XrefRangeEnd = 130297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData FindSameBook(ItemData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSameBook_Public_ItemData_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 130304, RefRangeEnd = 130307, XrefRangeStart = 130300, XrefRangeEnd = 130304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveHobby(ItemData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveHobby_Public_Boolean_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 130309, RefRangeEnd = 130313, XrefRangeStart = 130307, XrefRangeEnd = 130309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AttackSkillSlotUnlocked(int skillSlotID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillSlotID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttackSkillSlotUnlocked_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 130332, RefRangeEnd = 130336, XrefRangeStart = 130313, XrefRangeEnd = 130332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FightReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FightReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130337, RefRangeEnd = 130339, XrefRangeStart = 130336, XrefRangeEnd = 130337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FightSettingReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FightSettingReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 130359, RefRangeEnd = 130373, XrefRangeStart = 130339, XrefRangeEnd = 130359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkeletonGraphic GetSkeletonGraphic(Transform targetSkeletonParent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeletonParent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonGraphic_Public_SkeletonGraphic_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonGraphic>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130388, RefRangeEnd = 130390, XrefRangeStart = 130373, XrefRangeEnd = 130388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseSpeSkeleton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseSpeSkeleton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 130494, RefRangeEnd = 130503, XrefRangeStart = 130390, XrefRangeEnd = 130494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonGraphic(Transform targetSkeletonParent, int forceSkinID = -99, int forceSkinLv = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeletonParent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSkinID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSkinLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonGraphic_Public_Void_Transform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130545, RefRangeEnd = 130547, XrefRangeStart = 130503, XrefRangeEnd = 130545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonGraphicSkinColor(SkeletonGraphic targetSkeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonGraphicSkinColor_Public_Void_SkeletonGraphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 130572, RefRangeEnd = 130579, XrefRangeStart = 130547, XrefRangeEnd = 130572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonGraphicFaceSlot(SkeletonGraphic targetSkeleton, int i, int targetID = -99)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonGraphicFaceSlot_Public_Void_SkeletonGraphic_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 130607, RefRangeEnd = 130615, XrefRangeStart = 130579, XrefRangeEnd = 130607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkeletonAnimation GenerateHeroSkeleton(GameObject parent, Vector3 scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_GameObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonAnimation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130627, RefRangeEnd = 130628, XrefRangeStart = 130615, XrefRangeEnd = 130627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkinName(bool skeletonAnim = true, int forceSkinID = -99, int forceSkinLv = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&skeletonAnim);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSkinID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSkinLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinName_Public_String_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 130642, RefRangeEnd = 130646, XrefRangeStart = 130628, XrefRangeEnd = 130642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDefaultSkinID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultSkinID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 130655, RefRangeEnd = 130665, XrefRangeStart = 130646, XrefRangeEnd = 130655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDefaultSkin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDefaultSkin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 130673, RefRangeEnd = 130677, XrefRangeStart = 130665, XrefRangeEnd = 130673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkin(int _skinID, int _skinLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_skinID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_skinLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkin_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130677, XrefRangeEnd = 130702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkeletonAnimation GenerateHeroSkeleton(SkeletonAnimation skeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHeroSkeleton_Public_SkeletonAnimation_SkeletonAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonAnimation>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 130740, RefRangeEnd = 130748, XrefRangeStart = 130702, XrefRangeEnd = 130740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHeroSkeleton(SkeletonAnimation skeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_SkeletonAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130778, RefRangeEnd = 130779, XrefRangeStart = 130748, XrefRangeEnd = 130778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSkeletonHorse(SkeletonAnimation targetSkeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSkeletonHorse_Public_Void_SkeletonAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130779, XrefRangeEnd = 130893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonSkinColor(SkeletonAnimation targetSkeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonSkinColor_Public_Void_SkeletonAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130952, RefRangeEnd = 130953, XrefRangeStart = 130893, XrefRangeEnd = 130952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonFaceSlot(SkeletonAnimation targetSkeleton, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonFaceSlot_Public_Void_SkeletonAnimation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130974, RefRangeEnd = 130976, XrefRangeStart = 130953, XrefRangeEnd = 130974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroWeapon(SkeletonAnimation targetSkeleton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130983, RefRangeEnd = 130985, XrefRangeStart = 130976, XrefRangeEnd = 130983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroWeaponAttackAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroWeaponAttackAnim_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131035, RefRangeEnd = 131037, XrefRangeStart = 130985, XrefRangeEnd = 131035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkillWeapon(SkeletonAnimation targetSkeleton, string weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(weaponName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkillWeapon_Public_Void_SkeletonAnimation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131080, RefRangeEnd = 131082, XrefRangeStart = 131037, XrefRangeEnd = 131080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroWeapon(SkeletonAnimation targetSkeleton, string weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(weaponName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroWeapon_Public_Void_SkeletonAnimation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 131093, RefRangeEnd = 131107, XrefRangeStart = 131082, XrefRangeEnd = 131093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFightScore(bool includeTeamMate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeTeamMate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFightScore_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 131107, RefRangeEnd = 131114, XrefRangeStart = 131107, XrefRangeEnd = 131107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHpPercent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHpPercent_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131114, RefRangeEnd = 131118, XrefRangeStart = 131114, XrefRangeEnd = 131114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetManaPercent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetManaPercent_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131118, RefRangeEnd = 131119, XrefRangeStart = 131118, XrefRangeEnd = 131118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPowerPercent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPowerPercent_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131124, RefRangeEnd = 131128, XrefRangeStart = 131119, XrefRangeEnd = 131124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFullRecoverTime(float baseRecoverRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&baseRecoverRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullRecoverTime_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 131134, RefRangeEnd = 131139, XrefRangeStart = 131128, XrefRangeEnd = 131134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRecoverRate(float baseRecoverRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&baseRecoverRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecoverRate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131174, RefRangeEnd = 131175, XrefRangeStart = 131139, XrefRangeEnd = 131174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAttriRate(int attriID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&attriID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttriRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131185, RefRangeEnd = 131187, XrefRangeStart = 131175, XrefRangeEnd = 131185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageTagTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageTagTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 131191, RefRangeEnd = 131194, XrefRangeStart = 131187, XrefRangeEnd = 131191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveTag(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTag_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 131337, RefRangeEnd = 131375, XrefRangeStart = 131194, XrefRangeEnd = 131337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTag(int id, float time = -1f, string source = null, bool showInfo = false, bool needFreshHeroDetail = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(source);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &needFreshHeroDetail;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTag_Public_Void_Int32_Single_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 131381, RefRangeEnd = 131384, XrefRangeStart = 131375, XrefRangeEnd = 131381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroTagData FindTag(int tagID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tagID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTag_Public_HeroTagData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroTagData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131412, RefRangeEnd = 131413, XrefRangeStart = 131384, XrefRangeEnd = 131412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTag(string tagName, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTag_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 131439, RefRangeEnd = 131451, XrefRangeStart = 131413, XrefRangeEnd = 131439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTag(int tagID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tagID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTag_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131451, XrefRangeEnd = 131472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisUnderstandTag(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisUnderstandTag_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131489, RefRangeEnd = 131490, XrefRangeStart = 131472, XrefRangeEnd = 131489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnderstandTag(string tagName, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnderstandTag_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131536, RefRangeEnd = 131538, XrefRangeStart = 131490, XrefRangeEnd = 131536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnderstandTag(int id, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnderstandTag_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131551, RefRangeEnd = 131552, XrefRangeStart = 131538, XrefRangeEnd = 131551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllTempTag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllTempTag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(258)]
	[CachedScanResults(RefRangeStart = 131553, RefRangeEnd = 131811, XrefRangeStart = 131552, XrefRangeEnd = 131553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBuff(int id, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBuff_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 131812, RefRangeEnd = 131822, XrefRangeStart = 131811, XrefRangeEnd = 131812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AttackSelfTeam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttackSelfTeam_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(56)]
	[CachedScanResults(RefRangeStart = 131843, RefRangeEnd = 131899, XrefRangeStart = 131822, XrefRangeEnd = 131843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string HeroName(bool useSetName = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useSetName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroName_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131916, RefRangeEnd = 131918, XrefRangeStart = 131899, XrefRangeEnd = 131916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanSetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSetName_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131936, RefRangeEnd = 131940, XrefRangeStart = 131918, XrefRangeEnd = 131936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveSetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveSetName_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 131957, RefRangeEnd = 131960, XrefRangeStart = 131940, XrefRangeEnd = 131957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string HeroFamilyName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroFamilyName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 131963, RefRangeEnd = 131999, XrefRangeStart = 131960, XrefRangeEnd = 131963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroName(bool fullDescribe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fullDescribe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroName_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 132041, RefRangeEnd = 132060, XrefRangeStart = 131999, XrefRangeEnd = 132041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroForceLvDescribe(bool fullName = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fullName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroForceLvDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 132105, RefRangeEnd = 132117, XrefRangeStart = 132060, XrefRangeEnd = 132105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroForceLvDescribeSimplify()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroForceLvDescribeSimplify_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132117, RefRangeEnd = 132119, XrefRangeStart = 132117, XrefRangeEnd = 132117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBetrayForceBadTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBetrayForceBadTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132119, RefRangeEnd = 132121, XrefRangeStart = 132119, XrefRangeEnd = 132119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBetrayForceBadFame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBetrayForceBadFame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 132130, RefRangeEnd = 132138, XrefRangeStart = 132121, XrefRangeEnd = 132130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPlayerMeet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanPlayerMeet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 132138, RefRangeEnd = 132141, XrefRangeStart = 132138, XrefRangeEnd = 132138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMeetNeedFame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeetNeedFame_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 132160, RefRangeEnd = 132163, XrefRangeStart = 132141, XrefRangeEnd = 132160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxFavor(float maxFavor = 100f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxFavor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxFavor_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132180, RefRangeEnd = 132181, XrefRangeStart = 132163, XrefRangeEnd = 132180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNatureFavorRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNatureFavorRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132229, RefRangeEnd = 132230, XrefRangeStart = 132181, XrefRangeEnd = 132229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFavorRate(float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFavorRate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 132303, RefRangeEnd = 132331, XrefRangeStart = 132230, XrefRangeEnd = 132303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFavor(float num, bool showPopInfo = true, float maxFavor = 100f, float forceRate = 0f, bool successSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFavor;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRate;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &successSound;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFavor_Public_Void_Single_Boolean_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 132331, RefRangeEnd = 132338, XrefRangeStart = 132331, XrefRangeEnd = 132331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetStartFavor(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStartFavor_Public_Single_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 132339, RefRangeEnd = 132358, XrefRangeStart = 132338, XrefRangeEnd = 132339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroMeet(bool showInfo = true, float startFavor = -999f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&showInfo);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startFavor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroMeet_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 132412, RefRangeEnd = 132416, XrefRangeStart = 132358, XrefRangeEnd = 132412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMeetFavor(bool showPopInfo, float startFavor = -999f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&showPopInfo);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startFavor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMeetFavor_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132434, RefRangeEnd = 132436, XrefRangeStart = 132416, XrefRangeEnd = 132434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFavor(float num, bool showPopInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFavor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 132440, RefRangeEnd = 132455, XrefRangeStart = 132436, XrefRangeEnd = 132440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveFriend(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveFriend_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 132490, RefRangeEnd = 132497, XrefRangeStart = 132455, XrefRangeEnd = 132490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFriend(int _heroID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFriend_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 132537, RefRangeEnd = 132546, XrefRangeStart = 132497, XrefRangeEnd = 132537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFriend(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 132550, RefRangeEnd = 132570, XrefRangeStart = 132546, XrefRangeEnd = 132550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveHater(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveHater_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 132613, RefRangeEnd = 132619, XrefRangeStart = 132570, XrefRangeEnd = 132613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHater(int _heroID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHater_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 132655, RefRangeEnd = 132659, XrefRangeStart = 132619, XrefRangeEnd = 132655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHater(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHater_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132663, RefRangeEnd = 132665, XrefRangeStart = 132659, XrefRangeEnd = 132663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveBrother(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveBrother_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132709, RefRangeEnd = 132710, XrefRangeStart = 132665, XrefRangeEnd = 132709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBrother(int _heroID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBrother_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132750, RefRangeEnd = 132752, XrefRangeStart = 132710, XrefRangeEnd = 132750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBrother(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBrother_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132792, RefRangeEnd = 132793, XrefRangeStart = 132752, XrefRangeEnd = 132792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRelative(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRelative_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 132793, RefRangeEnd = 132799, XrefRangeStart = 132793, XrefRangeEnd = 132793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveTeacher()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTeacher_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132809, RefRangeEnd = 132811, XrefRangeStart = 132799, XrefRangeEnd = 132809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetTeacher()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTeacher_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132815, RefRangeEnd = 132816, XrefRangeStart = 132811, XrefRangeEnd = 132815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveStudent(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveStudent_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 132868, RefRangeEnd = 132874, XrefRangeStart = 132816, XrefRangeEnd = 132868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStudent(int _heroID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStudent_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 132931, RefRangeEnd = 132936, XrefRangeStart = 132874, XrefRangeEnd = 132931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveStudent(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStudent_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132940, RefRangeEnd = 132942, XrefRangeStart = 132936, XrefRangeEnd = 132940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllStudent(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllStudent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 132942, RefRangeEnd = 132955, XrefRangeStart = 132942, XrefRangeEnd = 132942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveLover()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveLover_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133003, RefRangeEnd = 133004, XrefRangeStart = 132955, XrefRangeEnd = 133003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLover(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLover_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133039, RefRangeEnd = 133041, XrefRangeStart = 133004, XrefRangeEnd = 133039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveLover(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 133045, RefRangeEnd = 133053, XrefRangeStart = 133041, XrefRangeEnd = 133045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HavePrelover(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HavePrelover_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133097, RefRangeEnd = 133098, XrefRangeStart = 133053, XrefRangeEnd = 133097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPrelover(int _heroID, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPrelover_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 133143, RefRangeEnd = 133148, XrefRangeStart = 133098, XrefRangeEnd = 133143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePrelover(int _heroID, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePrelover_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133152, RefRangeEnd = 133153, XrefRangeStart = 133148, XrefRangeEnd = 133152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllPrelover(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllPrelover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 133157, RefRangeEnd = 133162, XrefRangeStart = 133153, XrefRangeEnd = 133157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckPlayerMakeLoverUnhappy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPlayerMakeLoverUnhappy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 133200, RefRangeEnd = 133204, XrefRangeStart = 133162, XrefRangeEnd = 133200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTeacher(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTeacher_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133281, RefRangeEnd = 133283, XrefRangeStart = 133204, XrefRangeEnd = 133281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRelationShipText(int _heroID, bool fullDescribe = true, bool useColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullDescribe;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationShipText_Public_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 133295, RefRangeEnd = 133316, XrefRangeStart = 133283, XrefRangeEnd = 133295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveRelationBetterThanFriend(int _heroID, bool includeFriend = false, bool includeTeacherStudent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_heroID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFriend;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeTeacherStudent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveRelationBetterThanFriend_Public_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 133316, RefRangeEnd = 133320, XrefRangeStart = 133316, XrefRangeEnd = 133316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveTeacherStudentRelation(int _heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTeacherStudentRelation_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 133343, RefRangeEnd = 133346, XrefRangeStart = 133320, XrefRangeEnd = 133343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoFightQuickChangeState(float rate, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rate);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoFightQuickChangeState_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 133367, RefRangeEnd = 133383, XrefRangeStart = 133346, XrefRangeEnd = 133367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHp(float num, bool useRecoverRate = true, bool noDead = false, bool needRefresh = true, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRecoverRate;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &noDead;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRefresh;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHp_Public_Void_Single_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133383, RefRangeEnd = 133384, XrefRangeStart = 133383, XrefRangeEnd = 133383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeadToAlive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeadToAlive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 133404, RefRangeEnd = 133409, XrefRangeStart = 133384, XrefRangeEnd = 133404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxHp(float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxHp_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 133430, RefRangeEnd = 133447, XrefRangeStart = 133409, XrefRangeEnd = 133430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMana(float num, bool useRecoverRate = true, bool needRefresh = true, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRecoverRate;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRefresh;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMana_Public_Void_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 133467, RefRangeEnd = 133474, XrefRangeStart = 133447, XrefRangeEnd = 133467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxMana(float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxMana_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133495, RefRangeEnd = 133496, XrefRangeStart = 133474, XrefRangeEnd = 133495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePower(float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePower_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133496, XrefRangeEnd = 133516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxPower(float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxPower_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133519, RefRangeEnd = 133520, XrefRangeStart = 133516, XrefRangeEnd = 133519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWoundResist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWoundResist_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133523, RefRangeEnd = 133524, XrefRangeStart = 133520, XrefRangeEnd = 133523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDamageResist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDamageResist_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133533, RefRangeEnd = 133535, XrefRangeStart = 133524, XrefRangeEnd = 133533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeRandomInjury(float num, bool showText = false, bool gainExp = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gainExp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRandomInjury_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 133555, RefRangeEnd = 133588, XrefRangeStart = 133535, XrefRangeEnd = 133555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ChangeExternalInjury(float num, bool showText = false, bool gainExp = false, bool extraResist = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gainExp;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &extraResist;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeExternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 133608, RefRangeEnd = 133639, XrefRangeStart = 133588, XrefRangeEnd = 133608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ChangeInternalInjury(float num, bool showText = false, bool gainExp = false, bool extraResist = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gainExp;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &extraResist;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeInternalInjury_Public_Single_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 133659, RefRangeEnd = 133690, XrefRangeStart = 133639, XrefRangeEnd = 133659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ChangePoisonInjury(float num, bool showText = false, bool gainExp = false, bool extraResist = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gainExp;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &extraResist;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePoisonInjury_Public_Single_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 133702, RefRangeEnd = 133708, XrefRangeStart = 133690, XrefRangeEnd = 133702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FullRecover(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullRecover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 133708, RefRangeEnd = 133715, XrefRangeStart = 133708, XrefRangeEnd = 133708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalInjury()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalInjury_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133719, RefRangeEnd = 133720, XrefRangeStart = 133715, XrefRangeEnd = 133719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoCureSelfInjury()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoCureSelfInjury_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 133724, RefRangeEnd = 133734, XrefRangeStart = 133720, XrefRangeEnd = 133724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureInjury(float targetSKillNum, float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetSKillNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureInjury_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133736, RefRangeEnd = 133738, XrefRangeStart = 133734, XrefRangeEnd = 133736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureExternalInjurySkill(float buildingSkill = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureExternalInjurySkill_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 133742, RefRangeEnd = 133749, XrefRangeStart = 133738, XrefRangeEnd = 133742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureExternalInjury(float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureExternalInjury_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133754, RefRangeEnd = 133756, XrefRangeStart = 133749, XrefRangeEnd = 133754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSelfCureExternalInjuryTime(float buildingSkillNum = 0f, float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buildingSkillNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureExternalInjuryTime_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 133759, RefRangeEnd = 133763, XrefRangeStart = 133756, XrefRangeEnd = 133759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureInternalInjurySkill(float buildingSkill = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureInternalInjurySkill_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 133765, RefRangeEnd = 133771, XrefRangeStart = 133763, XrefRangeEnd = 133765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCureInternalInjury(float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureInternalInjury_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133774, RefRangeEnd = 133776, XrefRangeStart = 133771, XrefRangeEnd = 133774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSelfCureInternalInjuryTime(float buildingSkillNum = 0f, float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buildingSkillNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCureInternalInjuryTime_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133778, RefRangeEnd = 133780, XrefRangeStart = 133776, XrefRangeEnd = 133778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCurePoisonInjurySkill(float buildingSkill = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCurePoisonInjurySkill_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 133784, RefRangeEnd = 133790, XrefRangeStart = 133780, XrefRangeEnd = 133784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfCurePoisonInjury(float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCurePoisonInjury_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 133795, RefRangeEnd = 133797, XrefRangeStart = 133790, XrefRangeEnd = 133795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSelfCurePoisonInjuryTime(float buildingSkillNum = 0f, float speRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buildingSkillNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfCurePoisonInjuryTime_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 133862, RefRangeEnd = 133909, XrefRangeStart = 133797, XrefRangeEnd = 133862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeLivingSkillExp(int id, float num, bool showText = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeLivingSkillExp_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133911, RefRangeEnd = 133912, XrefRangeStart = 133909, XrefRangeEnd = 133911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLivingSkillExpMax(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLivingSkillExpMax_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 133984, RefRangeEnd = 133988, XrefRangeStart = 133912, XrefRangeEnd = 133984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeLivingSkill(int id, float num, bool showText, bool skillUpgrade = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skillUpgrade;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeLivingSkill_Public_Void_Int32_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 134038, RefRangeEnd = 134042, XrefRangeStart = 133988, XrefRangeEnd = 134038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFightSkill(int id, float num, bool showText, bool skillUpgrade = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skillUpgrade;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFightSkill_Public_Void_Int32_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134092, RefRangeEnd = 134094, XrefRangeStart = 134042, XrefRangeEnd = 134092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAttri(int id, float num, bool showText, bool skillUpgrade = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showText;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skillUpgrade;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAttri_Public_Void_Int32_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134094, XrefRangeEnd = 134096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForceJobDetailDirty(EquipmentData equipmentData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipmentData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_EquipmentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 134116, RefRangeEnd = 134122, XrefRangeStart = 134096, XrefRangeEnd = 134116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForceJobDetailDirty(HeroSpeAddData heroSpeAddData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 134137, RefRangeEnd = 134140, XrefRangeStart = 134122, XrefRangeEnd = 134137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForceJobDetailDirty(int livingSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&livingSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForceJobDetailDirty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 134169, RefRangeEnd = 134174, XrefRangeStart = 134140, XrefRangeEnd = 134169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxAttri(int id, int num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxAttri_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 134203, RefRangeEnd = 134213, XrefRangeStart = 134174, XrefRangeEnd = 134203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxFightSkill(int id, int num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxFightSkill_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 134242, RefRangeEnd = 134256, XrefRangeStart = 134213, XrefRangeEnd = 134242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMaxLivingSkill(int id, int num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMaxLivingSkill_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134280, RefRangeEnd = 134282, XrefRangeStart = 134256, XrefRangeEnd = 134280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAttriAndSkill(HeroSpeAddDataType speAddDataType, float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAttriAndSkill_Public_Void_HeroSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 134291, RefRangeEnd = 134295, XrefRangeStart = 134282, XrefRangeEnd = 134291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxAttri(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxAttri_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 134304, RefRangeEnd = 134313, XrefRangeStart = 134295, XrefRangeEnd = 134304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxFightSkill(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxFightSkill_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 134322, RefRangeEnd = 134361, XrefRangeStart = 134313, XrefRangeEnd = 134322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxLivingSkill(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxLivingSkill_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134407, RefRangeEnd = 134408, XrefRangeStart = 134361, XrefRangeEnd = 134407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshMaxAttriAndSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshMaxAttriAndSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134429, RefRangeEnd = 134430, XrefRangeStart = 134408, XrefRangeEnd = 134429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBaseMoveRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseMoveRange_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 134434, RefRangeEnd = 134439, XrefRangeStart = 134430, XrefRangeEnd = 134434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMoveRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMoveRange_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 134458, RefRangeEnd = 134463, XrefRangeStart = 134439, XrefRangeEnd = 134458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBounty(int num, HeroData bountyTarget, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bountyTarget);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBounty_Public_Void_Int32_HeroData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(155)]
	[CachedScanResults(RefRangeStart = 134483, RefRangeEnd = 134638, XrefRangeStart = 134463, XrefRangeEnd = 134483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMoney(int num, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMoney_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(80)]
	[CachedScanResults(RefRangeStart = 134672, RefRangeEnd = 134752, XrefRangeStart = 134638, XrefRangeEnd = 134672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFame(float num, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFame_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134767, RefRangeEnd = 134769, XrefRangeStart = 134752, XrefRangeEnd = 134767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckHeroFameForceLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroFameForceLv_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134783, RefRangeEnd = 134784, XrefRangeStart = 134769, XrefRangeEnd = 134783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134784, XrefRangeEnd = 134785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGameDifficultyFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameDifficultyFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134785, RefRangeEnd = 134787, XrefRangeStart = 134785, XrefRangeEnd = 134785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGovernReduceBadFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGovernReduceBadFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134787, RefRangeEnd = 134789, XrefRangeStart = 134787, XrefRangeEnd = 134787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGovernExtraFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGovernExtraFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 134789, RefRangeEnd = 134793, XrefRangeStart = 134789, XrefRangeEnd = 134789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHornorReduceBadFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHornorReduceBadFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 134789, RefRangeEnd = 134793, XrefRangeStart = 134789, XrefRangeEnd = 134793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHornorAddFavorRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHornorAddFavorRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 134798, RefRangeEnd = 134820, XrefRangeStart = 134793, XrefRangeEnd = 134798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBountyPirce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBountyPirce_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134822, RefRangeEnd = 134823, XrefRangeStart = 134820, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBadFameFineMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBadFameFineMoney_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134836, RefRangeEnd = 134837, XrefRangeStart = 134823, XrefRangeEnd = 134836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageAIInPrison(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageAIInPrison_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 134910, RefRangeEnd = 135000, XrefRangeStart = 134837, XrefRangeEnd = 134910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeBadFame(float num, bool showInfo = true, HeroData targetHero = null, bool changeDirect = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeDirect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBadFame_Public_Void_Single_Boolean_HeroData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135018, RefRangeEnd = 135019, XrefRangeStart = 135000, XrefRangeEnd = 135018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBadFameRate(HeroData targetHero = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBadFameRate_Public_Single_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 135020, RefRangeEnd = 135031, XrefRangeStart = 135019, XrefRangeEnd = 135020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayerSameForce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerSameForce_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 135041, RefRangeEnd = 135044, XrefRangeStart = 135031, XrefRangeEnd = 135041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroGovernName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroGovernName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 135054, RefRangeEnd = 135057, XrefRangeStart = 135044, XrefRangeEnd = 135054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHeroHornorName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroHornorName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 135057, RefRangeEnd = 135059, XrefRangeStart = 135057, XrefRangeEnd = 135057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHornorChangeMaxArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHornorChangeMaxArea_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135065, RefRangeEnd = 135069, XrefRangeStart = 135059, XrefRangeEnd = 135065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHornorUpgradeCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHornorUpgradeCost_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135075, RefRangeEnd = 135079, XrefRangeStart = 135069, XrefRangeEnd = 135075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGovernUpgradeCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGovernUpgradeCost_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 135103, RefRangeEnd = 135113, XrefRangeStart = 135079, XrefRangeEnd = 135103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeGovernContribution(float num, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeGovernContribution_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135113, XrefRangeEnd = 135119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeGovernLv(int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeGovernLv_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135119, XrefRangeEnd = 135125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHornorLv(int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHornorLv_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 135125, RefRangeEnd = 135127, XrefRangeStart = 135125, XrefRangeEnd = 135125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float OutsideForceExtraContributionRate(int forceID = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OutsideForceExtraContributionRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135129, RefRangeEnd = 135130, XrefRangeStart = 135127, XrefRangeEnd = 135129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float SelfForceContrituion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelfForceContrituion_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 135210, RefRangeEnd = 135250, XrefRangeStart = 135130, XrefRangeEnd = 135210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeForceContribution(float num, bool showInfo = true, int targetForce = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetForce;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeForceContribution_Public_Void_Single_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 135288, RefRangeEnd = 135296, XrefRangeStart = 135250, XrefRangeEnd = 135288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroForceLv(int num, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroForceLv_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135313, RefRangeEnd = 135314, XrefRangeStart = 135296, XrefRangeEnd = 135313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageHeroForceLvChangeMaxAttri(int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroForceLvChangeMaxAttri_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 135315, RefRangeEnd = 135318, XrefRangeStart = 135314, XrefRangeEnd = 135315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHeroSalaryAndPopulation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHeroSalaryAndPopulation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135362, RefRangeEnd = 135363, XrefRangeStart = 135318, XrefRangeEnd = 135362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeroForceLv(int _forceLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_forceLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeroForceLv_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 135369, RefRangeEnd = 135371, XrefRangeStart = 135363, XrefRangeEnd = 135369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleChangeSkillFightExp(float num, KungfuSkillLvData targetSkill, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BattleChangeSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 135417, RefRangeEnd = 135430, XrefRangeStart = 135371, XrefRangeEnd = 135417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSkillFightExp(float num, KungfuSkillLvData targetSkill, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSkillFightExp_Public_Void_Single_KungfuSkillLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135430, XrefRangeEnd = 135439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFightExpRate(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFightExpRate_Public_Single_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 135485, RefRangeEnd = 135494, XrefRangeStart = 135439, XrefRangeEnd = 135485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSkillBookExp(float num, KungfuSkillLvData targetSkill, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSkillBookExp_Public_Void_Single_KungfuSkillLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135494, XrefRangeEnd = 135503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBookExpRate(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBookExpRate_Public_Single_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135517, RefRangeEnd = 135521, XrefRangeStart = 135503, XrefRangeEnd = 135517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceBookStorageExpRate(int skillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceBookStorageExpRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 135529, RefRangeEnd = 135534, XrefRangeStart = 135521, XrefRangeEnd = 135529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGameDifficultyExpRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameDifficultyExpRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 135569, RefRangeEnd = 135572, XrefRangeStart = 135534, XrefRangeEnd = 135569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSkillUpgrade(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSkillUpgrade_Public_Void_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135583, RefRangeEnd = 135584, XrefRangeStart = 135572, XrefRangeEnd = 135583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeSkill(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeSkill_Public_Void_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 135646, RefRangeEnd = 135674, XrefRangeStart = 135584, XrefRangeEnd = 135646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillLvData GetSkill(KungfuSkillLvData skillLvData, bool showInfo = false, bool speShow = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillLvData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &speShow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkill_Public_KungfuSkillLvData_KungfuSkillLvData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 135680, RefRangeEnd = 135751, XrefRangeStart = 135674, XrefRangeEnd = 135680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillLvData FindSkill(int targetSkillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetSkillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSkill_Public_KungfuSkillLvData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillLvData>(intPtr) : null;
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 135788, RefRangeEnd = 135830, XrefRangeStart = 135751, XrefRangeEnd = 135788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItem(ItemListData _itemListData, bool showPopInfo, bool showSpeGetItem, int treasureChestClickTime = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_itemListData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showSpeGetItem;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &treasureChestClickTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(92)]
	[CachedScanResults(RefRangeStart = 135831, RefRangeEnd = 135923, XrefRangeStart = 135830, XrefRangeEnd = 135831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItem(ItemData itemData, bool showPopInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 135949, RefRangeEnd = 136039, XrefRangeStart = 135923, XrefRangeEnd = 135949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItem(ItemData itemData, bool showPopInfo, bool showSpeGetItem, int treasureChestClickTime = -1, bool skipManageItemPoison = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showSpeGetItem;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &treasureChestClickTime;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipManageItemPoison;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 136047, RefRangeEnd = 136056, XrefRangeStart = 136039, XrefRangeEnd = 136047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ManageGetItemPoison(ItemData itemData, bool showInfo, float poisonRate = 1f, bool reducePoisonNum = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &poisonRate;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &reducePoisonNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageGetItemPoison_Public_Single_ItemData_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136056, XrefRangeEnd = 136062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ManageGetEquipPoison(ItemData equipData, bool showInfo, float poisonRate = 1f, float injuryRate = 1f, float reduceRate = 0.8f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &poisonRate;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryRate;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &reduceRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageGetEquipPoison_Public_Single_ItemData_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136089, RefRangeEnd = 136091, XrefRangeStart = 136062, XrefRangeEnd = 136089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoManageEquipPoison()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136277, RefRangeEnd = 136279, XrefRangeStart = 136091, XrefRangeEnd = 136277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RandomAttriAndSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomAttriAndSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 136295, RefRangeEnd = 136385, XrefRangeStart = 136279, XrefRangeEnd = 136295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseItem(ItemData itemData, bool showPopInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 136394, RefRangeEnd = 136402, XrefRangeStart = 136385, XrefRangeEnd = 136394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseAllItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseAllItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136406, RefRangeEnd = 136407, XrefRangeStart = 136402, XrefRangeEnd = 136406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseAllSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseAllSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136439, RefRangeEnd = 136441, XrefRangeStart = 136407, XrefRangeEnd = 136439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseSkill(KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseSkill_Public_Void_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 136465, RefRangeEnd = 136470, XrefRangeStart = 136441, XrefRangeEnd = 136465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EquipSkill(KungfuSkillLvData skillLvData, bool playSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillLvData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EquipSkill_Public_Void_KungfuSkillLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 136493, RefRangeEnd = 136502, XrefRangeStart = 136470, XrefRangeEnd = 136493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnequipSkill(KungfuSkillLvData skillLvData, bool playSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillLvData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnequipSkill_Public_Void_KungfuSkillLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136502, XrefRangeEnd = 136513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EquipHorse(ItemData itemData, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EquipHorse_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136524, RefRangeEnd = 136525, XrefRangeStart = 136513, XrefRangeEnd = 136524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnequipHorse(ItemData itemData, bool playSound, bool forceUnequip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUnequip;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnequipHorse_Public_Void_ItemData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 136547, RefRangeEnd = 136555, XrefRangeStart = 136525, XrefRangeEnd = 136547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EquipItem(ItemData itemData, bool playSound = false, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EquipItem_Public_Void_ItemData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 136589, RefRangeEnd = 136595, XrefRangeStart = 136555, XrefRangeEnd = 136589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnequipItem(ItemData itemData, bool playSound = false, bool forceUnequip = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUnequip;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnequipItem_Public_Void_ItemData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 136751, RefRangeEnd = 136758, XrefRangeStart = 136595, XrefRangeEnd = 136751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CosumeMedFood(ItemData itemData, bool showInfo = false, HeroData sourceHero = null, float percent = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceHero);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &percent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CosumeMedFood_Public_Void_ItemData_Boolean_HeroData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 136816, RefRangeEnd = 136821, XrefRangeStart = 136758, XrefRangeEnd = 136816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseMedFood(ItemData itemData, bool playSound = false, bool showInfo = false, HeroData sourceHero = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseMedFood_Public_Void_ItemData_Boolean_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136850, RefRangeEnd = 136851, XrefRangeStart = 136821, XrefRangeEnd = 136850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetFoodSpeBuff(ItemData itemData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFoodSpeBuff_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136880, RefRangeEnd = 136882, XrefRangeStart = 136851, XrefRangeEnd = 136880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetWineSpeBuff(ItemData itemData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWineSpeBuff_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136900, RefRangeEnd = 136901, XrefRangeStart = 136882, XrefRangeEnd = 136900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDebateSpeBuff(int buffLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebateSpeBuff_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 136920, RefRangeEnd = 136923, XrefRangeStart = 136901, XrefRangeEnd = 136920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTempTag(HeroTagDataBase tempTag, int time, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tempTag);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTempTag_Public_Void_HeroTagDataBase_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136923, XrefRangeEnd = 136976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeTempTag(string tagName, HeroSpeAddDataType changeTarget, float changeNum, int setValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		*(HeroSpeAddDataType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeTarget;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &setValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeTempTag_Public_Void_String_HeroSpeAddDataType_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136982, RefRangeEnd = 136983, XrefRangeStart = 136976, XrefRangeEnd = 136982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveResource(List<ResourceData> resourceList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_ResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136983, XrefRangeEnd = 136985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveResource(ResourceData resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveResource_Public_Boolean_ResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 136986, RefRangeEnd = 136989, XrefRangeStart = 136985, XrefRangeEnd = 136986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveResource(int id, float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveResource_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136995, RefRangeEnd = 136996, XrefRangeStart = 136989, XrefRangeEnd = 136995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(List<ResourceData> resourceList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136996, XrefRangeEnd = 136998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(ResourceData resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136999, RefRangeEnd = 137001, XrefRangeStart = 136998, XrefRangeEnd = 136999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(int id, float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 137011, RefRangeEnd = 137023, XrefRangeStart = 137001, XrefRangeEnd = 137011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResource(int id, float num, bool showInfo, bool forceContribution = true, int targetForceID = -1, float contributionRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceContribution;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetForceID;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &contributionRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 137030, RefRangeEnd = 137031, XrefRangeStart = 137023, XrefRangeEnd = 137030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResource(List<float> num, bool showInfo, bool forceContribution = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceContribution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 137041, RefRangeEnd = 137083, XrefRangeStart = 137031, XrefRangeEnd = 137041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData GetArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArea_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(545)]
	[CachedScanResults(RefRangeStart = 137097, RefRangeEnd = 137642, XrefRangeStart = 137083, XrefRangeEnd = 137097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData GetForce(bool includeServant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeServant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForce_Public_ForceData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 137653, RefRangeEnd = 137688, XrefRangeStart = 137642, XrefRangeEnd = 137653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetForceLeader()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceLeader_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 137823, RefRangeEnd = 137825, XrefRangeStart = 137688, XrefRangeEnd = 137823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUpgradeForceLvNeedText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeForceLvNeedText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 137827, RefRangeEnd = 137832, XrefRangeStart = 137825, XrefRangeEnd = 137827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeForceLvNeedContribution(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 137834, RefRangeEnd = 137844, XrefRangeStart = 137832, XrefRangeEnd = 137834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeForceLvNeedContribution()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeForceLvNeedContribution_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 137848, RefRangeEnd = 137854, XrefRangeStart = 137844, XrefRangeEnd = 137848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalAttir()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalAttir_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 137858, RefRangeEnd = 137863, XrefRangeStart = 137854, XrefRangeEnd = 137858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalFightSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalFightSkill_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 137867, RefRangeEnd = 137870, XrefRangeStart = 137863, XrefRangeEnd = 137867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalLivingSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalLivingSkill_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 137877, RefRangeEnd = 137879, XrefRangeStart = 137870, XrefRangeEnd = 137877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDebateScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebateScore_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 137886, RefRangeEnd = 137914, XrefRangeStart = 137879, XrefRangeEnd = 137886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetItemFavorValue(ItemData targetItem, float maxLimit = 20f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLimit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemFavorValue_Public_Single_ItemData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 137914, RefRangeEnd = 137916, XrefRangeStart = 137914, XrefRangeEnd = 137914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FullState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 137916, RefRangeEnd = 137928, XrefRangeStart = 137916, XrefRangeEnd = 137916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 137929, RefRangeEnd = 137938, XrefRangeStart = 137928, XrefRangeEnd = 137929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxBuyValue(float discount = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&discount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxBuyValue_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 137942, RefRangeEnd = 137951, XrefRangeStart = 137938, XrefRangeEnd = 137942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTradeValueRate(bool buy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buy);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137951, XrefRangeEnd = 137956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTradeValueRate(bool buy, bool useLivingSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buy);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useLivingSkill;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradeValueRate_Public_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 137957, RefRangeEnd = 137958, XrefRangeStart = 137956, XrefRangeEnd = 137957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFavorValueRate(bool buy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buy);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFavorValueRate_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 137958, RefRangeEnd = 137965, XrefRangeStart = 137958, XrefRangeEnd = 137958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceStorageDiscount(ItemListData targetForceStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetForceStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceStorageDiscount_Public_Single_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137965, XrefRangeEnd = 137966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroMissionResult(MissionTargetType missionTargetType, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&missionTargetType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 137967, RefRangeEnd = 138012, XrefRangeStart = 137966, XrefRangeEnd = 137967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroMissionResult(MissionTargetType missionTargetType, string missionTargetID, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&missionTargetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(missionTargetID);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 138013, RefRangeEnd = 138017, XrefRangeStart = 138012, XrefRangeEnd = 138013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroMissionResult(MissionTargetType missionTargetType, int resourceNeed, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&missionTargetType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resourceNeed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 138023, RefRangeEnd = 138032, XrefRangeStart = 138017, XrefRangeEnd = 138023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroMissionResult(MissionTargetType missionTargetType, string missionTargetID, int resourceNeed, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&missionTargetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(missionTargetID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resourceNeed;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionTargetType_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 138072, RefRangeEnd = 138074, XrefRangeStart = 138032, XrefRangeEnd = 138072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHeroMissionResult(MissionData targetMission, MissionTargetType missionTargetType, string missionTargetID, int resourceNeed, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetMission);
		*(MissionTargetType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &missionTargetType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(missionTargetID);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resourceNeed;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHeroMissionResult_Public_Void_MissionData_MissionTargetType_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 138077, RefRangeEnd = 138084, XrefRangeStart = 138074, XrefRangeEnd = 138077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeroItemLv(bool useStrengthLv = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useStrengthLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroItemLv_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 138099, RefRangeEnd = 138103, XrefRangeStart = 138084, XrefRangeEnd = 138099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138103, XrefRangeEnd = 138107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _RandomAttriAndSkill_b__516_0(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RandomAttriAndSkill_b__516_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138107, XrefRangeEnd = 138111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _RandomAttriAndSkill_b__516_1(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RandomAttriAndSkill_b__516_1_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public HeroData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
