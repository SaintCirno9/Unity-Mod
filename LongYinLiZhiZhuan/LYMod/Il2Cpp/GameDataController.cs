using System;
using System.Runtime.CompilerServices;
using Il2CppCISFilterWordsSDK;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace Il2Cpp;

public class GameDataController : MonoBehaviour
{
	[ObfuscatedName("GameDataController+<>c__DisplayClass108_0")]
	public sealed class __c__DisplayClass108_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_saveID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__2_Internal_Void_0;

		public unsafe GameDataController __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameDataController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameDataController));
			}
		}

		public unsafe int saveID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveID)) = num;
			}
		}

		static __c__DisplayClass108_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "<>c__DisplayClass108_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_saveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, "saveID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100668914);
			NativeMethodInfoPtr__Load_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100668915);
			NativeMethodInfoPtr__Load_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100668916);
			NativeMethodInfoPtr__Load_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100668917);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass108_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178154, XrefRangeEnd = 178176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Load_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178176, XrefRangeEnd = 178198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Load_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178198, XrefRangeEnd = 178220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Load_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass108_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Tasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveDataFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameSaveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerprefDataFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefData;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffectVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExternalStorageDataFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExternalStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_rareLvData;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLevelData;

	private static readonly System.IntPtr NativeFieldInfoPtr_AiForceAttackPlayerAreaEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_AiForceAttackPlayerResourcePointEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_AiForceAttackFriendAreaEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceJobSettingDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillBulletDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_familyNameDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_givenNameDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_maleGivenNameDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_femaleGivenNameDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_speAddDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceSpeAddDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceTechDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSpeAddAvailableID;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSpeAddNegativeAvailableID;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSpeAddSelfBuffID;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSpeAddEnemyBuffID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigForceIDList;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingDataBaseTypeIDList;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_armorDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_helmetDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoesDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_medDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_foodDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_horseDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuSkillDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonSkillDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuSkillDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroNatureTalkTextDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroSpeTalkTextDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeHeroDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaleFaceTotalNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_FemaleFaceTotalNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaleFaceRandomID;

	private static readonly System.IntPtr NativeFieldInfoPtr_FemaleFaceRandomID;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlotDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_SummonDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourcePointTypeDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourcePointDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroTagDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_innDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_CheckReplaceSkillIconList;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookTypeIconDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_AchievementData;

	private static readonly System.IntPtr NativeFieldInfoPtr_tipsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_martialclubDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_loveableSpeHeroList;

	private static readonly System.IntPtr NativeFieldInfoPtr_poetryDataBase;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_CISFilterWordsSDKInited;

	private static readonly System.IntPtr NativeFieldInfoPtr_NameCensorWordsChecked;

	private static readonly System.IntPtr NativeFieldInfoPtr_keepTaskTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_GameDataController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveTask_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTask_Public_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSaveLoad_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanLoad_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckNameCensorWords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitWithEtag_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitWithLocalFile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyLocalCensorWordsFile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTestSave_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerPrefFilePath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerPrefFileBackupPath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerprefData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerprefData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAchFinishedCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalStorageMaxValue_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalStorageFilePath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveExternalStorageData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadExternalStorageData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemIntoExternalStorage_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemOutExternalStorage_Public_Void_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearExternalStorage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameIntoGameData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameDataIntoGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveDataPath_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOldSaveDataPath_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBackupDataPath_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeDataPath_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeSaveFileName_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveSave_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSave_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSaveInfo_Public_SaveInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveInfo_Public_SaveInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveSaveToBackUp_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveBackUpToSafe_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveDataPath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBackupDataPath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllGameData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAchStats_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAch_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAllAch_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteGameDataCsv_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTagID_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSkillData_Public_KungfuSkillData_LTCSVLoader_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceID_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToAttriRatio_Public_AttriNumData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToAttackRange_Public_List_1_SkillAttackRangeData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToDamageRange_Public_SkillDamageRangeData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToSpeAddData_Public_HeroSpeAddData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMedFoodData_Public_Void_ItemData_LTCSVLoader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadHorseData_Public_Void_ItemData_LTCSVLoader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingTypeIDList_Public_List_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomHeroFamilyName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomHeroGivenName_Public_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomHeroName_Public_String_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillDataBase_Public_KungfuSkillData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillID_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPeotryData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBigForceID_Public_Int32_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSkinDataBase_Public_SkinDataBase_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBookTypeIconDataBase_Public_BookTypeIconData_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTagDataBase_Public_HeroTagDataBase_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDlcState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitWithEtag_b__75_0_Private_Void_OnlineCensorFileResult_0;

	public unsafe List<Task> Tasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Task>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string saveDataPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveDataPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveDataPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string backupDataPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupDataPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupDataPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> saveDataFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_saveDataFileName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_saveDataFileName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameSaveData gameSaveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSaveData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameSaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSaveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSaveData));
		}
	}

	public unsafe static string playerprefDataFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerprefDataFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerprefDataFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static RePlayerPrefData playerPrefData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerPrefData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RePlayerPrefData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerPrefData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rePlayerPrefData));
		}
	}

	public unsafe static float soundEffectVolume
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_soundEffectVolume, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_soundEffectVolume, (void*)(&num));
		}
	}

	public unsafe static string ExternalStorageDataFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExternalStorageDataFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExternalStorageDataFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static ItemListData ExternalStorage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExternalStorage, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExternalStorage, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe List<RareLvData> rareLvData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLvData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RareLvData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLvData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceLevelData> forceLevelData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLevelData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceLevelData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLevelData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe EventData AiForceAttackPlayerAreaEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackPlayerAreaEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackPlayerAreaEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	public unsafe EventData AiForceAttackPlayerResourcePointEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackPlayerResourcePointEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackPlayerResourcePointEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	public unsafe EventData AiForceAttackFriendAreaEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackFriendAreaEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AiForceAttackFriendAreaEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	public unsafe List<ForceJobSettingDataBase> forceJobSettingDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobSettingDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceJobSettingDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobSettingDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SkillBulletData> SkillBulletDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillBulletDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkillBulletData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillBulletDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> familyNameDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> givenNameDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givenNameDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givenNameDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> maleGivenNameDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleGivenNameDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleGivenNameDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> femaleGivenNameDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleGivenNameDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleGivenNameDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroSpeAddDataBase> speAddDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speAddDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroSpeAddDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speAddDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceSpeAddDataBase> forceSpeAddDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceSpeAddDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceTechDataBase> forceTechDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceTechDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceTechDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceTechDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> randomSpeAddAvailableID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddAvailableID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddAvailableID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> randomSpeAddNegativeAvailableID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddNegativeAvailableID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddNegativeAvailableID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> randomSpeAddSelfBuffID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddSelfBuffID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddSelfBuffID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> randomSpeAddEnemyBuffID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddEnemyBuffID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddEnemyBuffID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AreaData> areaDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceData> forceDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> bigForceIDList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigForceIDList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigForceIDList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AreaBuildingDataBase> buildingDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaBuildingDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> buildingDataBaseTypeIDList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingDataBaseTypeIDList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingDataBaseTypeIDList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> weaponDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> armorDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armorDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armorDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> helmetDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helmetDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helmetDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> shoesDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> medDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> foodDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ItemData> horseDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KungfuSkillData> kungfuSkillDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuSkillData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KungfuSkillData> summonSkillDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonSkillDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuSkillData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonSkillDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<List<KungfuSkillData>>> kungfuSkillDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<List<KungfuSkillData>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuSkillDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<string>> HeroNatureTalkTextDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroNatureTalkTextDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroNatureTalkTextDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroSpeTalkTextDataBase> HeroSpeTalkTextDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroSpeTalkTextDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroSpeTalkTextDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroSpeTalkTextDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroData> SpeHeroDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeHeroDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeHeroDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HeroFaceData MaleFaceTotalNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleFaceTotalNum);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroFaceData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleFaceTotalNum)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroFaceData));
		}
	}

	public unsafe HeroFaceData FemaleFaceTotalNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FemaleFaceTotalNum);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroFaceData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FemaleFaceTotalNum)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroFaceData));
		}
	}

	public unsafe List<List<int>> MaleFaceRandomID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleFaceRandomID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleFaceRandomID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> FemaleFaceRandomID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FemaleFaceRandomID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FemaleFaceRandomID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<PlotData> PlotDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlotDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PlotData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlotDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SummonData> SummonDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SummonDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SummonData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SummonDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ResourcePointTypeData> resourcePointTypeDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResourcePointTypeData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ResourcePointData> resourcePointDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResourcePointData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroTagDataBase> heroTagDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroTagDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroTagDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InnData> innDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SkinDataBase> skinDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkinDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> CheckReplaceSkillIconList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckReplaceSkillIconList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckReplaceSkillIconList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BookTypeIconData> bookTypeIconDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BookTypeIconData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AchievementData> AchievementData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AchievementData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> tipsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipsData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MartialClubDataBase> martialclubDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_martialclubDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MartialClubDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_martialclubDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> loveableSpeHeroList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loveableSpeHeroList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loveableSpeHeroList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<PoetryData> poetryDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poetryDataBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PoetryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poetryDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static GameDataController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameDataController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameDataController));
		}
	}

	public unsafe bool CISFilterWordsSDKInited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CISFilterWordsSDKInited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CISFilterWordsSDKInited)) = flag;
		}
	}

	public unsafe bool NameCensorWordsChecked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameCensorWordsChecked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameCensorWordsChecked)) = flag;
		}
	}

	public unsafe float keepTaskTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepTaskTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepTaskTime)) = num;
		}
	}

	public unsafe static GameDataController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178220, XrefRangeEnd = 178224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_GameDataController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameDataController>(intPtr) : null;
		}
	}

	static GameDataController()
	{
		Il2CppClassPointerStore<GameDataController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameDataController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataController>.NativeClassPtr);
		NativeFieldInfoPtr_Tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "Tasks");
		NativeFieldInfoPtr_saveDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "saveDataPath");
		NativeFieldInfoPtr_backupDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "backupDataPath");
		NativeFieldInfoPtr_saveDataFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "saveDataFileName");
		NativeFieldInfoPtr_gameSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "gameSaveData");
		NativeFieldInfoPtr_playerprefDataFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "playerprefDataFileName");
		NativeFieldInfoPtr_playerPrefData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "playerPrefData");
		NativeFieldInfoPtr_soundEffectVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "soundEffectVolume");
		NativeFieldInfoPtr_ExternalStorageDataFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "ExternalStorageDataFileName");
		NativeFieldInfoPtr_ExternalStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "ExternalStorage");
		NativeFieldInfoPtr_rareLvData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "rareLvData");
		NativeFieldInfoPtr_forceLevelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "forceLevelData");
		NativeFieldInfoPtr_AiForceAttackPlayerAreaEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "AiForceAttackPlayerAreaEvent");
		NativeFieldInfoPtr_AiForceAttackPlayerResourcePointEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "AiForceAttackPlayerResourcePointEvent");
		NativeFieldInfoPtr_AiForceAttackFriendAreaEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "AiForceAttackFriendAreaEvent");
		NativeFieldInfoPtr_forceJobSettingDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "forceJobSettingDataBase");
		NativeFieldInfoPtr_SkillBulletDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "SkillBulletDataBase");
		NativeFieldInfoPtr_familyNameDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "familyNameDataBase");
		NativeFieldInfoPtr_givenNameDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "givenNameDataBase");
		NativeFieldInfoPtr_maleGivenNameDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "maleGivenNameDataBase");
		NativeFieldInfoPtr_femaleGivenNameDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "femaleGivenNameDataBase");
		NativeFieldInfoPtr_speAddDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "speAddDataBase");
		NativeFieldInfoPtr_forceSpeAddDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "forceSpeAddDataBase");
		NativeFieldInfoPtr_forceTechDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "forceTechDataBase");
		NativeFieldInfoPtr_randomSpeAddAvailableID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "randomSpeAddAvailableID");
		NativeFieldInfoPtr_randomSpeAddNegativeAvailableID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "randomSpeAddNegativeAvailableID");
		NativeFieldInfoPtr_randomSpeAddSelfBuffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "randomSpeAddSelfBuffID");
		NativeFieldInfoPtr_randomSpeAddEnemyBuffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "randomSpeAddEnemyBuffID");
		NativeFieldInfoPtr_areaDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "areaDataBase");
		NativeFieldInfoPtr_forceDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "forceDataBase");
		NativeFieldInfoPtr_bigForceIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "bigForceIDList");
		NativeFieldInfoPtr_buildingDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "buildingDataBase");
		NativeFieldInfoPtr_buildingDataBaseTypeIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "buildingDataBaseTypeIDList");
		NativeFieldInfoPtr_weaponDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "weaponDataBase");
		NativeFieldInfoPtr_armorDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "armorDataBase");
		NativeFieldInfoPtr_helmetDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "helmetDataBase");
		NativeFieldInfoPtr_shoesDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "shoesDataBase");
		NativeFieldInfoPtr_medDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "medDataBase");
		NativeFieldInfoPtr_foodDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "foodDataBase");
		NativeFieldInfoPtr_horseDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "horseDataBase");
		NativeFieldInfoPtr_kungfuSkillDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "kungfuSkillDataBase");
		NativeFieldInfoPtr_summonSkillDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "summonSkillDataBase");
		NativeFieldInfoPtr_kungfuSkillDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "kungfuSkillDataList");
		NativeFieldInfoPtr_HeroNatureTalkTextDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "HeroNatureTalkTextDataBase");
		NativeFieldInfoPtr_HeroSpeTalkTextDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "HeroSpeTalkTextDataBase");
		NativeFieldInfoPtr_SpeHeroDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "SpeHeroDataBase");
		NativeFieldInfoPtr_MaleFaceTotalNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "MaleFaceTotalNum");
		NativeFieldInfoPtr_FemaleFaceTotalNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "FemaleFaceTotalNum");
		NativeFieldInfoPtr_MaleFaceRandomID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "MaleFaceRandomID");
		NativeFieldInfoPtr_FemaleFaceRandomID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "FemaleFaceRandomID");
		NativeFieldInfoPtr_PlotDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "PlotDataBase");
		NativeFieldInfoPtr_SummonDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "SummonDataBase");
		NativeFieldInfoPtr_resourcePointTypeDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "resourcePointTypeDataBase");
		NativeFieldInfoPtr_resourcePointDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "resourcePointDataBase");
		NativeFieldInfoPtr_heroTagDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "heroTagDataBase");
		NativeFieldInfoPtr_innDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "innDataBase");
		NativeFieldInfoPtr_skinDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "skinDataBase");
		NativeFieldInfoPtr_CheckReplaceSkillIconList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "CheckReplaceSkillIconList");
		NativeFieldInfoPtr_bookTypeIconDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "bookTypeIconDataBase");
		NativeFieldInfoPtr_AchievementData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "AchievementData");
		NativeFieldInfoPtr_tipsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "tipsData");
		NativeFieldInfoPtr_martialclubDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "martialclubDataBase");
		NativeFieldInfoPtr_loveableSpeHeroList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "loveableSpeHeroList");
		NativeFieldInfoPtr_poetryDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "poetryDataBase");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_CISFilterWordsSDKInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "CISFilterWordsSDKInited");
		NativeFieldInfoPtr_NameCensorWordsChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "NameCensorWordsChecked");
		NativeFieldInfoPtr_keepTaskTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, "keepTaskTime");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_GameDataController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668842);
		NativeMethodInfoPtr_HaveTask_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668843);
		NativeMethodInfoPtr_AddTask_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668844);
		NativeMethodInfoPtr_CanSaveLoad_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668845);
		NativeMethodInfoPtr_CanLoad_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668846);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668847);
		NativeMethodInfoPtr_CheckNameCensorWords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668848);
		NativeMethodInfoPtr_InitWithEtag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668849);
		NativeMethodInfoPtr_InitWithLocalFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668850);
		NativeMethodInfoPtr_CopyLocalCensorWordsFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668851);
		NativeMethodInfoPtr_CopyTestSave_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668852);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668853);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668854);
		NativeMethodInfoPtr_GetPlayerPrefFilePath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668855);
		NativeMethodInfoPtr_GetPlayerPrefFileBackupPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668856);
		NativeMethodInfoPtr_SavePlayerprefData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668857);
		NativeMethodInfoPtr_LoadPlayerprefData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668858);
		NativeMethodInfoPtr_GetAchFinishedCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668859);
		NativeMethodInfoPtr_GetExternalStorageMaxValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668860);
		NativeMethodInfoPtr_GetExternalStorageFilePath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668861);
		NativeMethodInfoPtr_SaveExternalStorageData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668862);
		NativeMethodInfoPtr_LoadExternalStorageData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668863);
		NativeMethodInfoPtr_ItemIntoExternalStorage_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668864);
		NativeMethodInfoPtr_ItemOutExternalStorage_Public_Void_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668865);
		NativeMethodInfoPtr_ClearExternalStorage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668866);
		NativeMethodInfoPtr_GameIntoGameData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668867);
		NativeMethodInfoPtr_GameDataIntoGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668868);
		NativeMethodInfoPtr_GetSaveDataPath_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668869);
		NativeMethodInfoPtr_GetOldSaveDataPath_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668870);
		NativeMethodInfoPtr_GetBackupDataPath_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668871);
		NativeMethodInfoPtr_GetSafeDataPath_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668872);
		NativeMethodInfoPtr_UpgradeSaveFileName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668873);
		NativeMethodInfoPtr_HaveSave_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668874);
		NativeMethodInfoPtr_DeleteSave_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668875);
		NativeMethodInfoPtr_GenerateSaveInfo_Public_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668876);
		NativeMethodInfoPtr_GetSaveInfo_Public_SaveInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668877);
		NativeMethodInfoPtr_MoveSaveToBackUp_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668878);
		NativeMethodInfoPtr_MoveBackUpToSafe_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668879);
		NativeMethodInfoPtr_Save_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668880);
		NativeMethodInfoPtr_Load_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668881);
		NativeMethodInfoPtr_GetSaveDataPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668882);
		NativeMethodInfoPtr_GetBackupDataPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668883);
		NativeMethodInfoPtr_LoadAllGameData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668884);
		NativeMethodInfoPtr_ChangeAchStats_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668885);
		NativeMethodInfoPtr_CheckAch_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668886);
		NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668887);
		NativeMethodInfoPtr_CheckAllAch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668888);
		NativeMethodInfoPtr_WriteGameDataCsv_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668889);
		NativeMethodInfoPtr_GetTagID_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668890);
		NativeMethodInfoPtr_LoadSkillData_Public_KungfuSkillData_LTCSVLoader_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668891);
		NativeMethodInfoPtr_GetForceID_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668892);
		NativeMethodInfoPtr_StringToAttriRatio_Public_AttriNumData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668893);
		NativeMethodInfoPtr_StringToAttackRange_Public_List_1_SkillAttackRangeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668894);
		NativeMethodInfoPtr_StringToDamageRange_Public_SkillDamageRangeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668895);
		NativeMethodInfoPtr_StringToSpeAddData_Public_HeroSpeAddData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668896);
		NativeMethodInfoPtr_LoadMedFoodData_Public_Void_ItemData_LTCSVLoader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668897);
		NativeMethodInfoPtr_LoadHorseData_Public_Void_ItemData_LTCSVLoader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668898);
		NativeMethodInfoPtr_GetBuildingTypeIDList_Public_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668899);
		NativeMethodInfoPtr_GenerateRandomHeroFamilyName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668900);
		NativeMethodInfoPtr_GenerateRandomHeroGivenName_Public_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668901);
		NativeMethodInfoPtr_GenerateRandomHeroName_Public_String_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668902);
		NativeMethodInfoPtr_GetSkillDataBase_Public_KungfuSkillData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668903);
		NativeMethodInfoPtr_GetSkillID_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668904);
		NativeMethodInfoPtr_LoadPeotryData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668905);
		NativeMethodInfoPtr_GetRandomBigForceID_Public_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668906);
		NativeMethodInfoPtr_FindSkinDataBase_Public_SkinDataBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668907);
		NativeMethodInfoPtr_FindBookTypeIconDataBase_Public_BookTypeIconData_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668908);
		NativeMethodInfoPtr_GetTagDataBase_Public_HeroTagDataBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668909);
		NativeMethodInfoPtr_ResetDlcState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668910);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668911);
		NativeMethodInfoPtr__InitWithEtag_b__75_0_Private_Void_OnlineCensorFileResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataController>.NativeClassPtr, 100668913);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178248, RefRangeEnd = 178251, XrefRangeStart = 178224, XrefRangeEnd = 178248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveTask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTask_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178254, RefRangeEnd = 178257, XrefRangeStart = 178251, XrefRangeEnd = 178254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTask(Task task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTask_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178258, RefRangeEnd = 178261, XrefRangeStart = 178257, XrefRangeEnd = 178258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanSaveLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSaveLoad_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178263, RefRangeEnd = 178264, XrefRangeStart = 178261, XrefRangeEnd = 178263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanLoad_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178264, XrefRangeEnd = 178291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178314, RefRangeEnd = 178316, XrefRangeStart = 178291, XrefRangeEnd = 178314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckNameCensorWords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckNameCensorWords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178316, XrefRangeEnd = 178328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitWithEtag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitWithEtag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178328, XrefRangeEnd = 178333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitWithLocalFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitWithLocalFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178333, XrefRangeEnd = 178358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyLocalCensorWordsFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyLocalCensorWordsFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178358, XrefRangeEnd = 178394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyTestSave(string sourcePath, string destPath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTestSave_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178394, XrefRangeEnd = 178398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178398, XrefRangeEnd = 178422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178427, RefRangeEnd = 178428, XrefRangeStart = 178422, XrefRangeEnd = 178427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPlayerPrefFilePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerPrefFilePath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178433, RefRangeEnd = 178435, XrefRangeStart = 178428, XrefRangeEnd = 178433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPlayerPrefFileBackupPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerPrefFileBackupPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 178449, RefRangeEnd = 178453, XrefRangeStart = 178435, XrefRangeEnd = 178449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SavePlayerprefData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SavePlayerprefData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178453, XrefRangeEnd = 178503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerprefData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPlayerprefData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178523, RefRangeEnd = 178524, XrefRangeStart = 178503, XrefRangeEnd = 178523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAchFinishedCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAchFinishedCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178544, RefRangeEnd = 178546, XrefRangeStart = 178524, XrefRangeEnd = 178544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetExternalStorageMaxValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExternalStorageMaxValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178546, XrefRangeEnd = 178551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetExternalStorageFilePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExternalStorageFilePath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178565, RefRangeEnd = 178568, XrefRangeStart = 178551, XrefRangeEnd = 178565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveExternalStorageData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveExternalStorageData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178568, XrefRangeEnd = 178596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadExternalStorageData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadExternalStorageData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178603, RefRangeEnd = 178604, XrefRangeStart = 178596, XrefRangeEnd = 178603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ItemIntoExternalStorage(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemIntoExternalStorage_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178611, RefRangeEnd = 178613, XrefRangeStart = 178604, XrefRangeEnd = 178611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ItemOutExternalStorage(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemOutExternalStorage_Public_Void_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178613, XrefRangeEnd = 178620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearExternalStorage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearExternalStorage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178645, RefRangeEnd = 178646, XrefRangeStart = 178620, XrefRangeEnd = 178645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GameIntoGameData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameIntoGameData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178671, RefRangeEnd = 178672, XrefRangeStart = 178646, XrefRangeEnd = 178671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GameDataIntoGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameDataIntoGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 178689, RefRangeEnd = 178703, XrefRangeStart = 178672, XrefRangeEnd = 178689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSaveDataPath(int saveID, int saveType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&saveID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveDataPath_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178720, RefRangeEnd = 178722, XrefRangeStart = 178703, XrefRangeEnd = 178720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetOldSaveDataPath(int saveID, int saveType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&saveID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOldSaveDataPath_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 178739, RefRangeEnd = 178744, XrefRangeStart = 178722, XrefRangeEnd = 178739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBackupDataPath(int saveID, int saveType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&saveID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackupDataPath_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178763, RefRangeEnd = 178766, XrefRangeStart = 178744, XrefRangeEnd = 178763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSafeDataPath(int saveID, int saveType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&saveID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeDataPath_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178766, XrefRangeEnd = 178786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeSaveFileName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeSaveFileName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178788, RefRangeEnd = 178791, XrefRangeStart = 178786, XrefRangeEnd = 178788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveSave(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveSave_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178815, RefRangeEnd = 178816, XrefRangeStart = 178791, XrefRangeEnd = 178815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteSave(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteSave_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178896, RefRangeEnd = 178897, XrefRangeStart = 178816, XrefRangeEnd = 178896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveInfo GenerateSaveInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSaveInfo_Public_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178911, RefRangeEnd = 178913, XrefRangeStart = 178897, XrefRangeEnd = 178911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveInfo GetSaveInfo(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveInfo_Public_SaveInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178913, XrefRangeEnd = 178928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveSaveToBackUp(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveSaveToBackUp_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178928, XrefRangeEnd = 178943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveBackUpToSafe(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveBackUpToSafe_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 179023, RefRangeEnd = 179026, XrefRangeStart = 178943, XrefRangeEnd = 179023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179060, RefRangeEnd = 179061, XrefRangeStart = 179026, XrefRangeEnd = 179060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(int saveID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179061, XrefRangeEnd = 179063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSaveDataPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveDataPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179063, XrefRangeEnd = 179065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBackupDataPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackupDataPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181459, RefRangeEnd = 181460, XrefRangeStart = 179065, XrefRangeEnd = 181459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllGameData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllGameData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 181508, RefRangeEnd = 181536, XrefRangeStart = 181460, XrefRangeEnd = 181508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAchStats(int achID, float changeNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&achID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAchStats_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181580, RefRangeEnd = 181582, XrefRangeStart = 181536, XrefRangeEnd = 181580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAch(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAch_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181597, RefRangeEnd = 181598, XrefRangeStart = 181582, XrefRangeEnd = 181597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAchievement(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181653, RefRangeEnd = 181655, XrefRangeStart = 181598, XrefRangeEnd = 181653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAllAch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAllAch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181655, XrefRangeEnd = 181795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteGameDataCsv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteGameDataCsv_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181801, RefRangeEnd = 181802, XrefRangeStart = 181795, XrefRangeEnd = 181801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTagID(string tagName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tagName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTagID_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182157, RefRangeEnd = 182159, XrefRangeStart = 181802, XrefRangeEnd = 182157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillData LoadSkillData(LTCSVLoader loader, int i, bool _summonSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loader);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_summonSkill;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSkillData_Public_KungfuSkillData_LTCSVLoader_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182173, RefRangeEnd = 182175, XrefRangeStart = 182159, XrefRangeEnd = 182173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetForceID(string forceName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(forceName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceID_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182247, RefRangeEnd = 182249, XrefRangeStart = 182175, XrefRangeEnd = 182247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttriNumData StringToAttriRatio(string resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToAttriRatio_Public_AttriNumData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttriNumData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182273, RefRangeEnd = 182274, XrefRangeStart = 182249, XrefRangeEnd = 182273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SkillAttackRangeData> StringToAttackRange(string resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToAttackRange_Public_List_1_SkillAttackRangeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkillAttackRangeData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182274, XrefRangeEnd = 182285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillDamageRangeData StringToDamageRange(string resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToDamageRange_Public_SkillDamageRangeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillDamageRangeData>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 182321, RefRangeEnd = 182328, XrefRangeStart = 182285, XrefRangeEnd = 182321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData StringToSpeAddData(string resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToSpeAddData_Public_HeroSpeAddData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182359, RefRangeEnd = 182361, XrefRangeStart = 182328, XrefRangeEnd = 182359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadMedFoodData(ItemData newMedData, LTCSVLoader loader, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMedData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMedFoodData_Public_Void_ItemData_LTCSVLoader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182379, RefRangeEnd = 182380, XrefRangeStart = 182361, XrefRangeEnd = 182379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadHorseData(ItemData newHorseData, LTCSVLoader loader, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHorseData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadHorseData_Public_Void_ItemData_LTCSVLoader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182380, XrefRangeEnd = 182393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetBuildingTypeIDList(int TargetBuildingID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&TargetBuildingID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildingTypeIDList_Public_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182401, RefRangeEnd = 182403, XrefRangeStart = 182393, XrefRangeEnd = 182401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateRandomHeroFamilyName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomHeroFamilyName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182429, RefRangeEnd = 182430, XrefRangeStart = 182403, XrefRangeEnd = 182429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateRandomHeroGivenName(bool isFemale, bool useCensorWords = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isFemale);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCensorWords;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomHeroGivenName_Public_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182467, RefRangeEnd = 182469, XrefRangeStart = 182430, XrefRangeEnd = 182467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateRandomHeroName(bool isFemale, string familyName, bool useCensorWords = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isFemale);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCensorWords;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomHeroName_Public_String_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 182475, RefRangeEnd = 182499, XrefRangeStart = 182469, XrefRangeEnd = 182475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillData GetSkillDataBase(int skillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillDataBase_Public_KungfuSkillData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 182506, RefRangeEnd = 182509, XrefRangeStart = 182499, XrefRangeEnd = 182506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSkillID(string skillName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(skillName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillID_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182583, RefRangeEnd = 182584, XrefRangeStart = 182509, XrefRangeEnd = 182583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPeotryData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPeotryData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 182590, RefRangeEnd = 182623, XrefRangeStart = 182584, XrefRangeEnd = 182590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRandomBigForceID(float noBigForceRate = 0f, int noBigForceResult = -2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&noBigForceRate);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &noBigForceResult;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomBigForceID_Public_Int32_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 182629, RefRangeEnd = 182639, XrefRangeStart = 182623, XrefRangeEnd = 182629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinDataBase FindSkinDataBase(int targetSkinID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetSkinID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSkinDataBase_Public_SkinDataBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkinDataBase>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182645, RefRangeEnd = 182646, XrefRangeStart = 182639, XrefRangeEnd = 182645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BookTypeIconData FindBookTypeIconDataBase(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBookTypeIconDataBase_Public_BookTypeIconData_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BookTypeIconData>(intPtr) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 182656, RefRangeEnd = 182672, XrefRangeStart = 182646, XrefRangeEnd = 182656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroTagDataBase GetTagDataBase(int tagID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tagID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTagDataBase_Public_HeroTagDataBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroTagDataBase>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182687, RefRangeEnd = 182689, XrefRangeStart = 182672, XrefRangeEnd = 182687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDlcState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDlcState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182689, XrefRangeEnd = 182711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameDataController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182711, XrefRangeEnd = 182718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitWithEtag_b__75_0(OnlineCensorFileResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitWithEtag_b__75_0_Private_Void_OnlineCensorFileResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameDataController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
