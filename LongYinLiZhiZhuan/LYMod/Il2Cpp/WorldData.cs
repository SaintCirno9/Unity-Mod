using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2Cpp;

[System.Serializable]
public class WorldData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_chapter;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_villageAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Areas;

	private static readonly System.IntPtr NativeFieldInfoPtr_Inns;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourcePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_Forces;

	private static readonly System.IntPtr NativeFieldInfoPtr_Heros;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempHeros;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigMapRandomEventDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaMapRandomEventDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRandomWorldEventDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldEventDatasSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldEventDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldNewsDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_MailDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_cheating;

	private static readonly System.IntPtr NativeFieldInfoPtr_cheated;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_relaxMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_hour;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMeetingStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePartyStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMeetingMissedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBetrayForceBadTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGetTeacherTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerServantForceTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_infos;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotHappened;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlotEventLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldPlotEventStartData;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldPlotEventStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_openLeaveForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_openForceBuilding;

	private static readonly System.IntPtr NativeFieldInfoPtr_openForceAttackResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_openForceAttackArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_openForceAttackBasement;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthCatchBadFamePlayerTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthGambleTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthPartyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthForcePartyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthDoctorTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthPerformForMoneyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthCoachTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthAttackMartialClubTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthSpeReduceBadFameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthSpeAddFameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthSpeGetTalentPointTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthChallengeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthBuyAreaInfoTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthGiveMoneyToGovernTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthBreakEquipTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthKillTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthFreshBountyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_showRoomItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_showRoomChangeFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_nowWeather;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherLastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinUnlockData;

	private static readonly System.IntPtr NativeFieldInfoPtr_speBuildingUnlocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishForceMissionCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalFightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalWinFightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalEnemyKilled;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalBadFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_studyFightWithGreatHeroSingleWinNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_studyFightWithGreatHeroMultiWinNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_studyFightWithGreatHeroFinalWinNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalHeroMeet;

	private static readonly System.IntPtr NativeFieldInfoPtr_prisonData;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameResultTriggered;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBookWriter;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisYearExploreSpeEventNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisYearExploreBigSpeEventNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_governStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleTimeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_tempTagDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponResearchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_meditationData;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceSpeResearchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceSpeFunctionAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_getSpePoisonData;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineSpePoisonData;

	private static readonly System.IntPtr NativeFieldInfoPtr_speBookStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_speBookStorageSpeAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_speSummonResearchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_speEnhanceStone;

	private static readonly System.IntPtr NativeFieldInfoPtr_speSpellRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoResearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerAuctionItem;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAuctionItem_Public_get_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerAuctionItem_Public_set_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDifficlutyName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTempTag_Public_Boolean_HeroTagDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTempTag_Public_HeroTagDataBase_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTempTagID_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTempTag_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGameResultTriggered_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Player_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSaveID_Public_Int32_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSaveIDEvent_Public_EventData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSerializingMethod_Internal_Void_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerMissionEventData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverPlayerMissionEventData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChapterBadFameRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockSkin_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkinUnlocked_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanQuickTravel_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSpeEnhanceStoneNum_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldNews_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveWorldNews_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomWorldNews_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTempHeroCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomEnemyCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTempHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTempHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArea_Public_AreaData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForce_Public_ForceData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroForce_Public_ForceData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHero_Public_HeroData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHero_Public_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int chapter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapter)) = num;
		}
	}

	public unsafe List<int> cityAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityAreaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityAreaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> villageAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageAreaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageAreaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> forceAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceAreaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceAreaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AreaData> Areas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Areas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Areas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InnData> Inns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ResourcePointData> ResourcePoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResourcePoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResourcePointData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResourcePoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceData> Forces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Forces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Forces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroData> Heros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Heros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Heros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroData> TempHeros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempHeros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempHeros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EventData> BigMapRandomEventDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapRandomEventDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapRandomEventDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EventData> AreaMapRandomEventDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaMapRandomEventDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaMapRandomEventDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int lastRandomWorldEventDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRandomWorldEventDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRandomWorldEventDay)) = num;
		}
	}

	public unsafe List<int> WorldEventDatasSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldEventDatasSaveRecord);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldEventDatasSaveRecord)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EventData> WorldEventDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldEventDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldEventDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WorldNewsData> WorldNewsDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldNewsDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldNewsData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldNewsDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MailData> MailDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MailDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MailData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MailDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool cheating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cheating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cheating)) = flag;
		}
	}

	public unsafe bool cheated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cheated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cheated)) = flag;
		}
	}

	public unsafe GameMode gameMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMode);
			return *(GameMode*)num;
		}
		set
		{
			*(GameMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMode)) = gameMode;
		}
	}

	public unsafe int gameDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDifficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDifficulty)) = num;
		}
	}

	public unsafe bool relaxMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relaxMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relaxMode)) = flag;
		}
	}

	public unsafe TimeData worldTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeData));
		}
	}

	public unsafe float TimeDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeDifficulty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeDifficulty)) = num;
		}
	}

	public unsafe float hour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hour)) = num;
		}
	}

	public unsafe bool forceMeetingStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMeetingStarted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMeetingStarted)) = flag;
		}
	}

	public unsafe bool forcePartyStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePartyStarted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePartyStarted)) = flag;
		}
	}

	public unsafe int forceMeetingMissedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMeetingMissedTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMeetingMissedTime)) = num;
		}
	}

	public unsafe int playerBetrayForceBadTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBetrayForceBadTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBetrayForceBadTime)) = num;
		}
	}

	public unsafe int playerGetTeacherTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGetTeacherTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGetTeacherTime)) = num;
		}
	}

	public unsafe int playerServantForceTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerServantForceTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerServantForceTime)) = num;
		}
	}

	public unsafe List<InfoData> infos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InfoData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, TimeData> plotHappened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotHappened);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TimeData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotHappened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> missionFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe PlotEventLogData PlotEventLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlotEventLog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlotEventLogData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlotEventLog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)plotEventLogData));
		}
	}

	public unsafe List<WorldPlotEventStartData> worldPlotEventStartData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlotEventStartData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldPlotEventStartData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlotEventStartData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, TimeData> worldPlotEventStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlotEventStartTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TimeData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlotEventStartTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<string> tutorialFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool openLeaveForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLeaveForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLeaveForce)) = flag;
		}
	}

	public unsafe bool openForceBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceBuilding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceBuilding)) = flag;
		}
	}

	public unsafe bool openForceAttackResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackResource);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackResource)) = flag;
		}
	}

	public unsafe bool openForceAttackArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackArea)) = flag;
		}
	}

	public unsafe bool openForceAttackBasement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackBasement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openForceAttackBasement)) = flag;
		}
	}

	public unsafe int monthCatchBadFamePlayerTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCatchBadFamePlayerTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCatchBadFamePlayerTime)) = num;
		}
	}

	public unsafe int monthGambleTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthGambleTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthGambleTime)) = num;
		}
	}

	public unsafe int monthPartyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthPartyTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthPartyTime)) = num;
		}
	}

	public unsafe int monthForcePartyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthForcePartyTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthForcePartyTime)) = num;
		}
	}

	public unsafe int monthDoctorTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthDoctorTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthDoctorTime)) = num;
		}
	}

	public unsafe int monthPerformForMoneyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthPerformForMoneyTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthPerformForMoneyTime)) = num;
		}
	}

	public unsafe int monthCoachTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCoachTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCoachTime)) = num;
		}
	}

	public unsafe int monthAttackMartialClubTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthAttackMartialClubTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthAttackMartialClubTime)) = num;
		}
	}

	public unsafe int monthSpeReduceBadFameTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeReduceBadFameTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeReduceBadFameTime)) = num;
		}
	}

	public unsafe int monthSpeAddFameTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeAddFameTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeAddFameTime)) = num;
		}
	}

	public unsafe int monthSpeGetTalentPointTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeGetTalentPointTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSpeGetTalentPointTime)) = num;
		}
	}

	public unsafe int monthChallengeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthChallengeTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthChallengeTime)) = num;
		}
	}

	public unsafe int monthBuyAreaInfoTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthBuyAreaInfoTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthBuyAreaInfoTime)) = num;
		}
	}

	public unsafe int monthGiveMoneyToGovernTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthGiveMoneyToGovernTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthGiveMoneyToGovernTime)) = num;
		}
	}

	public unsafe int monthBreakEquipTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthBreakEquipTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthBreakEquipTime)) = num;
		}
	}

	public unsafe int monthKillTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthKillTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthKillTime)) = num;
		}
	}

	public unsafe int monthFreshBountyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthFreshBountyTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthFreshBountyTime)) = num;
		}
	}

	public unsafe List<List<ItemData>> showRoomItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRoomItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<ItemData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRoomItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float showRoomChangeFame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRoomChangeFame);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRoomChangeFame)) = num;
		}
	}

	public unsafe int nowWeather
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowWeather);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowWeather)) = num;
		}
	}

	public unsafe float weatherLastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherLastTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherLastTime)) = num;
		}
	}

	public unsafe List<SkinUnlockData> skinUnlockData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinUnlockData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkinUnlockData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinUnlockData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> speBuildingUnlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuildingUnlocked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuildingUnlocked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int finishForceMissionCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishForceMissionCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishForceMissionCount)) = num;
		}
	}

	public unsafe int totalFightCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalFightCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalFightCount)) = num;
		}
	}

	public unsafe int totalWinFightCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalWinFightCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalWinFightCount)) = num;
		}
	}

	public unsafe int totalEnemyKilled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalEnemyKilled);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalEnemyKilled)) = num;
		}
	}

	public unsafe float totalBadFame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalBadFame);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalBadFame)) = num;
		}
	}

	public unsafe int studyFightWithGreatHeroSingleWinNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroSingleWinNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroSingleWinNum)) = num;
		}
	}

	public unsafe int studyFightWithGreatHeroMultiWinNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroMultiWinNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroMultiWinNum)) = num;
		}
	}

	public unsafe int studyFightWithGreatHeroFinalWinNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroFinalWinNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_studyFightWithGreatHeroFinalWinNum)) = num;
		}
	}

	public unsafe int totalHeroMeet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalHeroMeet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalHeroMeet)) = num;
		}
	}

	public unsafe PrisonData prisonData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prisonData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PrisonData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prisonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prisonData));
		}
	}

	public unsafe List<int> gameResultTriggered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameResultTriggered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameResultTriggered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BookWriterData> playerBookWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBookWriter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BookWriterData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBookWriter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int thisYearExploreSpeEventNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearExploreSpeEventNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearExploreSpeEventNum)) = num;
		}
	}

	public unsafe int thisYearExploreBigSpeEventNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearExploreBigSpeEventNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisYearExploreBigSpeEventNum)) = num;
		}
	}

	public unsafe ItemListData governStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_governStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe float battleTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTimeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTimeScale)) = num;
		}
	}

	public unsafe List<HeroTagDataBase> tempTagDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTagDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroTagDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTagDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe WeaponResearchData weaponResearchData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponResearchData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeaponResearchData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponResearchData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weaponResearchData));
		}
	}

	public unsafe MeditationData meditationData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeditationData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meditationData));
		}
	}

	public unsafe ForceSpeResearchData forceSpeResearchData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeResearchData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeResearchData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeResearchData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceSpeResearchData));
		}
	}

	public unsafe HeroSpeAddData forceSpeFunctionAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeFunctionAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeFunctionAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe SpePoisonData getSpePoisonData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getSpePoisonData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpePoisonData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getSpePoisonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spePoisonData));
		}
	}

	public unsafe SpePoisonData combineSpePoisonData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineSpePoisonData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpePoisonData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineSpePoisonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spePoisonData));
		}
	}

	public unsafe ItemListData speBookStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBookStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBookStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe HeroSpeAddData speBookStorageSpeAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBookStorageSpeAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBookStorageSpeAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe SpeSummonResearchData speSummonResearchData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSummonResearchData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpeSummonResearchData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSummonResearchData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)speSummonResearchData));
		}
	}

	public unsafe int speEnhanceStone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEnhanceStone);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEnhanceStone)) = num;
		}
	}

	public unsafe List<float> speSpellRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSpellRate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSpellRate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool autoResearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoResearch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoResearch)) = flag;
		}
	}

	public unsafe ItemData playerAuctionItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAuctionItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAuctionItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe ItemData PlayerAuctionItem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAuctionItem_Public_get_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114213, XrefRangeEnd = 114216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerAuctionItem_Public_set_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static WorldData()
	{
		Il2CppClassPointerStore<WorldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldData>.NativeClassPtr);
		NativeFieldInfoPtr_chapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "chapter");
		NativeFieldInfoPtr_cityAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "cityAreaID");
		NativeFieldInfoPtr_villageAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "villageAreaID");
		NativeFieldInfoPtr_forceAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forceAreaID");
		NativeFieldInfoPtr_Areas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "Areas");
		NativeFieldInfoPtr_Inns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "Inns");
		NativeFieldInfoPtr_ResourcePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "ResourcePoints");
		NativeFieldInfoPtr_Forces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "Forces");
		NativeFieldInfoPtr_Heros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "Heros");
		NativeFieldInfoPtr_TempHeros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "TempHeros");
		NativeFieldInfoPtr_BigMapRandomEventDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "BigMapRandomEventDatas");
		NativeFieldInfoPtr_AreaMapRandomEventDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "AreaMapRandomEventDatas");
		NativeFieldInfoPtr_lastRandomWorldEventDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "lastRandomWorldEventDay");
		NativeFieldInfoPtr_WorldEventDatasSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "WorldEventDatasSaveRecord");
		NativeFieldInfoPtr_WorldEventDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "WorldEventDatas");
		NativeFieldInfoPtr_WorldNewsDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "WorldNewsDatas");
		NativeFieldInfoPtr_MailDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "MailDatas");
		NativeFieldInfoPtr_cheating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "cheating");
		NativeFieldInfoPtr_cheated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "cheated");
		NativeFieldInfoPtr_gameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "gameMode");
		NativeFieldInfoPtr_gameDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "gameDifficulty");
		NativeFieldInfoPtr_relaxMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "relaxMode");
		NativeFieldInfoPtr_worldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "worldTime");
		NativeFieldInfoPtr_TimeDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "TimeDifficulty");
		NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "hour");
		NativeFieldInfoPtr_forceMeetingStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forceMeetingStarted");
		NativeFieldInfoPtr_forcePartyStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forcePartyStarted");
		NativeFieldInfoPtr_forceMeetingMissedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forceMeetingMissedTime");
		NativeFieldInfoPtr_playerBetrayForceBadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "playerBetrayForceBadTime");
		NativeFieldInfoPtr_playerGetTeacherTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "playerGetTeacherTime");
		NativeFieldInfoPtr_playerServantForceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "playerServantForceTime");
		NativeFieldInfoPtr_infos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "infos");
		NativeFieldInfoPtr_plotHappened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "plotHappened");
		NativeFieldInfoPtr_missionFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "missionFinished");
		NativeFieldInfoPtr_PlotEventLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "PlotEventLog");
		NativeFieldInfoPtr_worldPlotEventStartData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "worldPlotEventStartData");
		NativeFieldInfoPtr_worldPlotEventStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "worldPlotEventStartTime");
		NativeFieldInfoPtr_tutorialFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "tutorialFinished");
		NativeFieldInfoPtr_openLeaveForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "openLeaveForce");
		NativeFieldInfoPtr_openForceBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "openForceBuilding");
		NativeFieldInfoPtr_openForceAttackResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "openForceAttackResource");
		NativeFieldInfoPtr_openForceAttackArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "openForceAttackArea");
		NativeFieldInfoPtr_openForceAttackBasement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "openForceAttackBasement");
		NativeFieldInfoPtr_monthCatchBadFamePlayerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthCatchBadFamePlayerTime");
		NativeFieldInfoPtr_monthGambleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthGambleTime");
		NativeFieldInfoPtr_monthPartyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthPartyTime");
		NativeFieldInfoPtr_monthForcePartyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthForcePartyTime");
		NativeFieldInfoPtr_monthDoctorTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthDoctorTime");
		NativeFieldInfoPtr_monthPerformForMoneyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthPerformForMoneyTime");
		NativeFieldInfoPtr_monthCoachTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthCoachTime");
		NativeFieldInfoPtr_monthAttackMartialClubTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthAttackMartialClubTime");
		NativeFieldInfoPtr_monthSpeReduceBadFameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthSpeReduceBadFameTime");
		NativeFieldInfoPtr_monthSpeAddFameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthSpeAddFameTime");
		NativeFieldInfoPtr_monthSpeGetTalentPointTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthSpeGetTalentPointTime");
		NativeFieldInfoPtr_monthChallengeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthChallengeTime");
		NativeFieldInfoPtr_monthBuyAreaInfoTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthBuyAreaInfoTime");
		NativeFieldInfoPtr_monthGiveMoneyToGovernTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthGiveMoneyToGovernTime");
		NativeFieldInfoPtr_monthBreakEquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthBreakEquipTime");
		NativeFieldInfoPtr_monthKillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthKillTime");
		NativeFieldInfoPtr_monthFreshBountyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "monthFreshBountyTime");
		NativeFieldInfoPtr_showRoomItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "showRoomItems");
		NativeFieldInfoPtr_showRoomChangeFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "showRoomChangeFame");
		NativeFieldInfoPtr_nowWeather = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "nowWeather");
		NativeFieldInfoPtr_weatherLastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "weatherLastTime");
		NativeFieldInfoPtr_skinUnlockData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "skinUnlockData");
		NativeFieldInfoPtr_speBuildingUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speBuildingUnlocked");
		NativeFieldInfoPtr_finishForceMissionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "finishForceMissionCount");
		NativeFieldInfoPtr_totalFightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "totalFightCount");
		NativeFieldInfoPtr_totalWinFightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "totalWinFightCount");
		NativeFieldInfoPtr_totalEnemyKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "totalEnemyKilled");
		NativeFieldInfoPtr_totalBadFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "totalBadFame");
		NativeFieldInfoPtr_studyFightWithGreatHeroSingleWinNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "studyFightWithGreatHeroSingleWinNum");
		NativeFieldInfoPtr_studyFightWithGreatHeroMultiWinNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "studyFightWithGreatHeroMultiWinNum");
		NativeFieldInfoPtr_studyFightWithGreatHeroFinalWinNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "studyFightWithGreatHeroFinalWinNum");
		NativeFieldInfoPtr_totalHeroMeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "totalHeroMeet");
		NativeFieldInfoPtr_prisonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "prisonData");
		NativeFieldInfoPtr_gameResultTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "gameResultTriggered");
		NativeFieldInfoPtr_playerBookWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "playerBookWriter");
		NativeFieldInfoPtr_thisYearExploreSpeEventNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "thisYearExploreSpeEventNum");
		NativeFieldInfoPtr_thisYearExploreBigSpeEventNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "thisYearExploreBigSpeEventNum");
		NativeFieldInfoPtr_governStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "governStorage");
		NativeFieldInfoPtr_battleTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "battleTimeScale");
		NativeFieldInfoPtr_tempTagDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "tempTagDataBase");
		NativeFieldInfoPtr_weaponResearchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "weaponResearchData");
		NativeFieldInfoPtr_meditationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "meditationData");
		NativeFieldInfoPtr_forceSpeResearchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forceSpeResearchData");
		NativeFieldInfoPtr_forceSpeFunctionAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "forceSpeFunctionAddData");
		NativeFieldInfoPtr_getSpePoisonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "getSpePoisonData");
		NativeFieldInfoPtr_combineSpePoisonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "combineSpePoisonData");
		NativeFieldInfoPtr_speBookStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speBookStorage");
		NativeFieldInfoPtr_speBookStorageSpeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speBookStorageSpeAdd");
		NativeFieldInfoPtr_speSummonResearchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speSummonResearchData");
		NativeFieldInfoPtr_speEnhanceStone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speEnhanceStone");
		NativeFieldInfoPtr_speSpellRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "speSpellRate");
		NativeFieldInfoPtr_autoResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "autoResearch");
		NativeFieldInfoPtr_playerAuctionItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "playerAuctionItem");
		NativeMethodInfoPtr_get_PlayerAuctionItem_Public_get_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667045);
		NativeMethodInfoPtr_set_PlayerAuctionItem_Public_set_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667046);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667047);
		NativeMethodInfoPtr_GetDifficlutyName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667048);
		NativeMethodInfoPtr_AddTempTag_Public_Boolean_HeroTagDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667049);
		NativeMethodInfoPtr_FindTempTag_Public_HeroTagDataBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667050);
		NativeMethodInfoPtr_FindTempTagID_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667051);
		NativeMethodInfoPtr_ClearTempTag_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667052);
		NativeMethodInfoPtr_AddGameResultTriggered_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667053);
		NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667054);
		NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667055);
		NativeMethodInfoPtr_Player_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667056);
		NativeMethodInfoPtr_GetEventSaveID_Public_Int32_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_GetEventSaveIDEvent_Public_EventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_OnSerializingMethod_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667059);
		NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667060);
		NativeMethodInfoPtr_SetPlayerMissionEventData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667061);
		NativeMethodInfoPtr_RecoverPlayerMissionEventData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667062);
		NativeMethodInfoPtr_GetChapterBadFameRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667063);
		NativeMethodInfoPtr_UnlockSkin_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667064);
		NativeMethodInfoPtr_SkinUnlocked_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667065);
		NativeMethodInfoPtr_CanQuickTravel_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667066);
		NativeMethodInfoPtr_ChangeSpeEnhanceStoneNum_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667067);
		NativeMethodInfoPtr_AddWorldNews_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667068);
		NativeMethodInfoPtr_HaveWorldNews_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667069);
		NativeMethodInfoPtr_GetRandomWorldNews_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667070);
		NativeMethodInfoPtr_GetTempHeroCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667071);
		NativeMethodInfoPtr_GetRandomEnemyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667072);
		NativeMethodInfoPtr_AddTempHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667073);
		NativeMethodInfoPtr_RemoveTempHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_GetHeroCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_AddNewHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_GetArea_Public_AreaData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_GetForce_Public_ForceData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr_GetHeroForce_Public_ForceData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr_GetHero_Public_HeroData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_GetHero_Public_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldData>.NativeClassPtr, 100667083);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114216, XrefRangeEnd = 114433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 114437, RefRangeEnd = 114440, XrefRangeStart = 114433, XrefRangeEnd = 114437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDifficlutyName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDifficlutyName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114452, RefRangeEnd = 114453, XrefRangeStart = 114440, XrefRangeEnd = 114452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddTempTag(HeroTagDataBase tempTag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tempTag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTempTag_Public_Boolean_HeroTagDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114460, RefRangeEnd = 114461, XrefRangeStart = 114453, XrefRangeEnd = 114460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroTagDataBase FindTempTag(string tagName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTempTag_Public_HeroTagDataBase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroTagDataBase>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 114466, RefRangeEnd = 114469, XrefRangeStart = 114461, XrefRangeEnd = 114466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindTempTagID(string tagName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTempTagID_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114489, RefRangeEnd = 114490, XrefRangeStart = 114469, XrefRangeEnd = 114489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTempTag(string tagName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTempTag_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 114503, RefRangeEnd = 114506, XrefRangeStart = 114490, XrefRangeEnd = 114503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGameResultTriggered(int resultID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resultID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGameResultTriggered_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114507, RefRangeEnd = 114509, XrefRangeStart = 114506, XrefRangeEnd = 114507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveGameResultTriggered(int resultID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resultID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114510, RefRangeEnd = 114511, XrefRangeStart = 114509, XrefRangeEnd = 114510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveGameResultTriggered()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveGameResultTriggered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2865)]
	[CachedScanResults(RefRangeStart = 114513, RefRangeEnd = 117378, XrefRangeStart = 114511, XrefRangeEnd = 114513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData Player()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Player_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117384, RefRangeEnd = 117386, XrefRangeStart = 117378, XrefRangeEnd = 117384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetEventSaveID(EventData targetEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventSaveID_Public_Int32_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 117389, RefRangeEnd = 117393, XrefRangeStart = 117386, XrefRangeEnd = 117389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData GetEventSaveIDEvent(int eventSaveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventSaveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventSaveIDEvent_Public_EventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117393, XrefRangeEnd = 117428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117428, XrefRangeEnd = 117448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 117478, RefRangeEnd = 117479, XrefRangeStart = 117448, XrefRangeEnd = 117478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerMissionEventData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerMissionEventData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117520, RefRangeEnd = 117521, XrefRangeStart = 117479, XrefRangeEnd = 117520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverPlayerMissionEventData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverPlayerMissionEventData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117522, RefRangeEnd = 117524, XrefRangeStart = 117521, XrefRangeEnd = 117522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChapterBadFameRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChapterBadFameRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 117569, RefRangeEnd = 117577, XrefRangeStart = 117524, XrefRangeEnd = 117569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockSkin(int _skinID, int _skinLv, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_skinID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_skinLv;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockSkin_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117596, RefRangeEnd = 117598, XrefRangeStart = 117577, XrefRangeEnd = 117596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SkinUnlocked(int _skinID, int _skinLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_skinID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_skinLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkinUnlocked_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117606, RefRangeEnd = 117607, XrefRangeStart = 117598, XrefRangeEnd = 117606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanQuickTravel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanQuickTravel_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117622, RefRangeEnd = 117624, XrefRangeStart = 117607, XrefRangeEnd = 117622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSpeEnhanceStoneNum(int num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSpeEnhanceStoneNum_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117632, RefRangeEnd = 117635, XrefRangeStart = 117624, XrefRangeEnd = 117632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWorldNews(string text, int time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWorldNews_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117637, RefRangeEnd = 117638, XrefRangeStart = 117635, XrefRangeEnd = 117637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveWorldNews(bool includeWorldNews)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeWorldNews);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveWorldNews_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117650, RefRangeEnd = 117651, XrefRangeStart = 117638, XrefRangeEnd = 117650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRandomWorldNews(bool includeWorldNews)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeWorldNews);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomWorldNews_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117651, XrefRangeEnd = 117655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTempHeroCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempHeroCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117663, RefRangeEnd = 117664, XrefRangeStart = 117655, XrefRangeEnd = 117663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRandomEnemyCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomEnemyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 117677, RefRangeEnd = 117684, XrefRangeStart = 117664, XrefRangeEnd = 117677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTempHero(HeroData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTempHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117691, RefRangeEnd = 117692, XrefRangeStart = 117684, XrefRangeEnd = 117691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTempHero(HeroData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTempHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117692, XrefRangeEnd = 117696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHeroCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117709, RefRangeEnd = 117712, XrefRangeStart = 117696, XrefRangeEnd = 117709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewHero(HeroData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117719, RefRangeEnd = 117720, XrefRangeStart = 117712, XrefRangeEnd = 117719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHero(HeroData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117727, RefRangeEnd = 117728, XrefRangeStart = 117720, XrefRangeEnd = 117727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData GetArea(string areaName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(areaName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArea_Public_AreaData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117735, RefRangeEnd = 117736, XrefRangeStart = 117728, XrefRangeEnd = 117735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData GetForce(string forceName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(forceName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForce_Public_ForceData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 117738, RefRangeEnd = 117771, XrefRangeStart = 117736, XrefRangeEnd = 117738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData GetHeroForce(int heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroForce_Public_ForceData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(1557)]
	[CachedScanResults(RefRangeStart = 117786, RefRangeEnd = 119343, XrefRangeStart = 117771, XrefRangeEnd = 117786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetHero(string heroName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(heroName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHero_Public_HeroData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(273)]
	[CachedScanResults(RefRangeStart = 119350, RefRangeEnd = 119623, XrefRangeStart = 119343, XrefRangeEnd = 119350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetHero(int heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHero_Public_HeroData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119623, XrefRangeEnd = 119640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public WorldData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
