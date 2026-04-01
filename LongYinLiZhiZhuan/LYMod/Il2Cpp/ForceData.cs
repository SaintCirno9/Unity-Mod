using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class ForceData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_forceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSkinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoAddMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMaleRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_masterForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_servantForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_startSkillBookID;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_leader;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownAreasID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownResourcePointsID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownHeros;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroLvNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSalary;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalPopulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceStore;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceStoreMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStorageSelfDiscount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStorageOtherDiscount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookWriterList;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookStorageDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookStorageMaxRareLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_allyForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceStopWarTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuSkillFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_livingSkillFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceDetailDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceHeroDetailDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFavorSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthAttackResourcePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthGetResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthAddOtherForceFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthReduceOtherForceFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomAttackAreaDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthGetHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_nowResearchTech;

	private static readonly System.IntPtr NativeFieldInfoPtr_techLvData;

	private static readonly System.IntPtr NativeFieldInfoPtr_techSpeAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceSpeAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_showRoomItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_showRoomChangeFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceJobSettingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceInteractionTimeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthManaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerOutForceContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_speBuildingID;

	private static readonly System.IntPtr NativeFieldInfoPtr_speFunctionDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_reasearchTechList;

	private static readonly System.IntPtr NativeFieldInfoPtr_JoinBigForceNeedSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_JoinBigForceNeedFame;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourcePercent_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSalaryRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRealSalaryCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_ForceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceStopWarTime_Public_Void_Int32_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceStopWarTime_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllyForce_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAllyForce_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BreakAllyForce_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAttack_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceRelationshipText_Public_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSexLimit_Public_SexLimit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeetForceSexLimit_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BookStorageAddBook_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceJob_Public_Void_Int32_Int32_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceJobExtraExpRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceJobExtraAttriNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnHero_Public_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnHeros_Public_List_1_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAllHero_Public_List_1_HeroData_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeAllAreaState_Public_Single_AreaStateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MainArea_Public_AreaData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNowResearchTech_Public_ForceTechLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeNowResearch_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNowResearch_Public_Void_ForceTechLvData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreaNotFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxAreaNum_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulationNotFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxHeroNum_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceFavor_Public_Void_ForceFavorSettingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceFavor_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeForceFavor_Public_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceFavor_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceFavorRate_Public_Single_ForceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveResource_Public_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_ResourceData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeResourceSound_Public_Static_String_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_List_1_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLeader_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLeader_Public_Void_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHero_Public_Void_HeroData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceConquerArea_Public_Void_AreaData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_AreaData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_ResourcePointData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KungfuSkillFocusDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJoinForceNeedDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerMeetForceJoinRequire_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int forceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceID)) = num;
		}
	}

	public unsafe string forceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceName)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe bool bigForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigForce)) = flag;
		}
	}

	public unsafe bool autoAddMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoAddMember);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoAddMember)) = flag;
		}
	}

	public unsafe string forceStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStyle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStyle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float forceMaleRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMaleRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMaleRate)) = num;
		}
	}

	public unsafe int forceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLv)) = num;
		}
	}

	public unsafe int mainAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainAreaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainAreaID)) = num;
		}
	}

	public unsafe int masterForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterForce);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterForce)) = num;
		}
	}

	public unsafe List<int> servantForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_servantForce);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_servantForce)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> startSkillBookID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSkillBookID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSkillBookID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int leader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leader);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leader)) = num;
		}
	}

	public unsafe List<int> ownAreasID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownAreasID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownAreasID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ownResourcePointsID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownResourcePointsID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownResourcePointsID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ownHeros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownHeros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownHeros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> heroLvNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroLvNum);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroLvNum)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int totalSalary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSalary);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSalary)) = num;
		}
	}

	public unsafe int totalPopulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalPopulation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalPopulation)) = num;
		}
	}

	public unsafe List<float> resourceStore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStore);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStore)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> resourceStoreMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStoreMax);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStoreMax)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> resourceChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ItemListData forceStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe float forceStorageSelfDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorageSelfDiscount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorageSelfDiscount)) = num;
		}
	}

	public unsafe float forceStorageOtherDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorageOtherDiscount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStorageOtherDiscount)) = num;
		}
	}

	public unsafe List<BookWriterData> bookWriterList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookWriterList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BookWriterData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookWriterList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ItemListData bookStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe bool bookStorageDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorageDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorageDirty)) = flag;
		}
	}

	public unsafe Dictionary<int, int> bookStorageMaxRareLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorageMaxRareLv);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookStorageMaxRareLv)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<float> forceFavor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> allyForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allyForce);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allyForce)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, int> ForceStopWarTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceStopWarTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceStopWarTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
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

	public unsafe List<float> itemFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForceFocusType forceFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFocus);
			return *(ForceFocusType*)num;
		}
		set
		{
			*(ForceFocusType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFocus)) = forceFocusType;
		}
	}

	public unsafe bool forceDetailDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDetailDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDetailDirty)) = flag;
		}
	}

	public unsafe bool forceHeroDetailDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHeroDetailDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHeroDetailDirty)) = flag;
		}
	}

	public unsafe List<ForceFavorSettingData> forceFavorSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavorSetting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceFavorSettingData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavorSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int thisMonthAttackResourcePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAttackResourcePoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAttackResourcePoint)) = num;
		}
	}

	public unsafe int thisMonthGetResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthGetResource);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthGetResource)) = num;
		}
	}

	public unsafe int thisMonthAddOtherForceFavor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAddOtherForceFavor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAddOtherForceFavor)) = num;
		}
	}

	public unsafe int thisMonthReduceOtherForceFavor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthReduceOtherForceFavor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthReduceOtherForceFavor)) = num;
		}
	}

	public unsafe int randomAttackAreaDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomAttackAreaDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomAttackAreaDay)) = num;
		}
	}

	public unsafe int thisMonthGetHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthGetHero);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthGetHero)) = num;
		}
	}

	public unsafe int nowResearchTech
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowResearchTech);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowResearchTech)) = num;
		}
	}

	public unsafe List<ForceTechLvData> techLvData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_techLvData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceTechLvData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_techLvData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForceSpeAddData techSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_techSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_techSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceSpeAddData));
		}
	}

	public unsafe ForceSpeAddData forceSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceSpeAddData));
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

	public unsafe ForceJobSettingData forceJobSettingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobSettingData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceJobSettingData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceJobSettingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceJobSettingData));
		}
	}

	public unsafe ForceInteractionTimeData forceInteractionTimeData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceInteractionTimeData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceInteractionTimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceInteractionTimeData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceInteractionTimeData));
		}
	}

	public unsafe bool thisMonthAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthAttack)) = flag;
		}
	}

	public unsafe int thisMonthManaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthManaged);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisMonthManaged)) = num;
		}
	}

	public unsafe float playerOutForceContribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOutForceContribution);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOutForceContribution)) = num;
		}
	}

	public unsafe int speBuildingID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuildingID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuildingID)) = num;
		}
	}

	public unsafe string speFunctionDescribe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speFunctionDescribe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speFunctionDescribe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<int> reasearchTechList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reasearchTechList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reasearchTechList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static float JoinBigForceNeedSkill
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JoinBigForceNeedSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JoinBigForceNeedSkill, (void*)(&num));
		}
	}

	public unsafe static float JoinBigForceNeedFame
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JoinBigForceNeedFame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JoinBigForceNeedFame, (void*)(&num));
		}
	}

	static ForceData()
	{
		Il2CppClassPointerStore<ForceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceData>.NativeClassPtr);
		NativeFieldInfoPtr_forceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceID");
		NativeFieldInfoPtr_forceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceName");
		NativeFieldInfoPtr_defaultSkinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "defaultSkinID");
		NativeFieldInfoPtr_bigForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "bigForce");
		NativeFieldInfoPtr_autoAddMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "autoAddMember");
		NativeFieldInfoPtr_forceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceStyle");
		NativeFieldInfoPtr_forceMaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceMaleRate");
		NativeFieldInfoPtr_forceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceLv");
		NativeFieldInfoPtr_mainAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "mainAreaID");
		NativeFieldInfoPtr_masterForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "masterForce");
		NativeFieldInfoPtr_servantForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "servantForce");
		NativeFieldInfoPtr_startSkillBookID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "startSkillBookID");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "color");
		NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "leader");
		NativeFieldInfoPtr_ownAreasID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "ownAreasID");
		NativeFieldInfoPtr_ownResourcePointsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "ownResourcePointsID");
		NativeFieldInfoPtr_ownHeros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "ownHeros");
		NativeFieldInfoPtr_heroLvNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "heroLvNum");
		NativeFieldInfoPtr_totalSalary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "totalSalary");
		NativeFieldInfoPtr_totalPopulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "totalPopulation");
		NativeFieldInfoPtr_resourceStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "resourceStore");
		NativeFieldInfoPtr_resourceStoreMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "resourceStoreMax");
		NativeFieldInfoPtr_resourceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "resourceChange");
		NativeFieldInfoPtr_forceStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceStorage");
		NativeFieldInfoPtr_forceStorageSelfDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceStorageSelfDiscount");
		NativeFieldInfoPtr_forceStorageOtherDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceStorageOtherDiscount");
		NativeFieldInfoPtr_bookWriterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "bookWriterList");
		NativeFieldInfoPtr_bookStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "bookStorage");
		NativeFieldInfoPtr_bookStorageDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "bookStorageDirty");
		NativeFieldInfoPtr_bookStorageMaxRareLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "bookStorageMaxRareLv");
		NativeFieldInfoPtr_forceFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceFavor");
		NativeFieldInfoPtr_allyForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "allyForce");
		NativeFieldInfoPtr_ForceStopWarTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "ForceStopWarTime");
		NativeFieldInfoPtr_kungfuSkillFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "kungfuSkillFocus");
		NativeFieldInfoPtr_livingSkillFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "livingSkillFocus");
		NativeFieldInfoPtr_itemFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "itemFocus");
		NativeFieldInfoPtr_forceFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceFocus");
		NativeFieldInfoPtr_forceDetailDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceDetailDirty");
		NativeFieldInfoPtr_forceHeroDetailDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceHeroDetailDirty");
		NativeFieldInfoPtr_forceFavorSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceFavorSetting");
		NativeFieldInfoPtr_thisMonthAttackResourcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthAttackResourcePoint");
		NativeFieldInfoPtr_thisMonthGetResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthGetResource");
		NativeFieldInfoPtr_thisMonthAddOtherForceFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthAddOtherForceFavor");
		NativeFieldInfoPtr_thisMonthReduceOtherForceFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthReduceOtherForceFavor");
		NativeFieldInfoPtr_randomAttackAreaDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "randomAttackAreaDay");
		NativeFieldInfoPtr_thisMonthGetHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthGetHero");
		NativeFieldInfoPtr_nowResearchTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "nowResearchTech");
		NativeFieldInfoPtr_techLvData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "techLvData");
		NativeFieldInfoPtr_techSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "techSpeAddData");
		NativeFieldInfoPtr_forceSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceSpeAddData");
		NativeFieldInfoPtr_showRoomItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "showRoomItems");
		NativeFieldInfoPtr_showRoomChangeFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "showRoomChangeFame");
		NativeFieldInfoPtr_forceJobSettingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceJobSettingData");
		NativeFieldInfoPtr_forceInteractionTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "forceInteractionTimeData");
		NativeFieldInfoPtr_thisMonthAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthAttack");
		NativeFieldInfoPtr_thisMonthManaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "thisMonthManaged");
		NativeFieldInfoPtr_playerOutForceContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "playerOutForceContribution");
		NativeFieldInfoPtr_speBuildingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "speBuildingID");
		NativeFieldInfoPtr_speFunctionDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "speFunctionDescribe");
		NativeFieldInfoPtr_reasearchTechList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "reasearchTechList");
		NativeFieldInfoPtr_JoinBigForceNeedSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "JoinBigForceNeedSkill");
		NativeFieldInfoPtr_JoinBigForceNeedFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceData>.NativeClassPtr, "JoinBigForceNeedFame");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667304);
		NativeMethodInfoPtr_GetResourcePercent_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667305);
		NativeMethodInfoPtr_GetSalaryRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667306);
		NativeMethodInfoPtr_GetRealSalaryCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667307);
		NativeMethodInfoPtr_DataBase_Public_ForceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667308);
		NativeMethodInfoPtr_SetForceStopWarTime_Public_Void_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667309);
		NativeMethodInfoPtr_GetForceStopWarTime_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667310);
		NativeMethodInfoPtr_IsAllyForce_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667311);
		NativeMethodInfoPtr_AddAllyForce_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_BreakAllyForce_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr_CanAttack_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667314);
		NativeMethodInfoPtr_GetForceRelationshipText_Public_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr_ForceSexLimit_Public_SexLimit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667316);
		NativeMethodInfoPtr_MeetForceSexLimit_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667317);
		NativeMethodInfoPtr_GetForceName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667318);
		NativeMethodInfoPtr_BookStorageAddBook_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667319);
		NativeMethodInfoPtr_SetForceJob_Public_Void_Int32_Int32_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667320);
		NativeMethodInfoPtr_GetForceJobExtraExpRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667321);
		NativeMethodInfoPtr_GetForceJobExtraAttriNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667322);
		NativeMethodInfoPtr_GetOwnHero_Public_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667323);
		NativeMethodInfoPtr_GetOwnHeros_Public_List_1_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr_FindAllHero_Public_List_1_HeroData_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr_GetChangeAllAreaState_Public_Single_AreaStateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667326);
		NativeMethodInfoPtr_MainArea_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667327);
		NativeMethodInfoPtr_GetNowResearchTech_Public_ForceTechLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667328);
		NativeMethodInfoPtr_UpgradeNowResearch_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667329);
		NativeMethodInfoPtr_SetNowResearch_Public_Void_ForceTechLvData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667330);
		NativeMethodInfoPtr_AreaNotFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667331);
		NativeMethodInfoPtr_GetMaxAreaNum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667332);
		NativeMethodInfoPtr_PopulationNotFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667333);
		NativeMethodInfoPtr_GetMaxHeroNum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr_SetForceFavor_Public_Void_ForceFavorSettingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667335);
		NativeMethodInfoPtr_SetForceFavor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667336);
		NativeMethodInfoPtr_ChangeForceFavor_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667337);
		NativeMethodInfoPtr_GetForceFavor_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667338);
		NativeMethodInfoPtr_GetForceFavorRate_Public_Single_ForceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667339);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667340);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667341);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667342);
		NativeMethodInfoPtr_HaveResource_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667343);
		NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667344);
		NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_ResourceData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667345);
		NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667346);
		NativeMethodInfoPtr_GetChangeResourceSound_Public_Static_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667347);
		NativeMethodInfoPtr_CostResource_Public_Void_List_1_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667348);
		NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667349);
		NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667350);
		NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667351);
		NativeMethodInfoPtr_GetLeader_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667352);
		NativeMethodInfoPtr_SetLeader_Public_Void_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667353);
		NativeMethodInfoPtr_AddHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667354);
		NativeMethodInfoPtr_AddHero_Public_Void_HeroData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667355);
		NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667356);
		NativeMethodInfoPtr_ForceConquerArea_Public_Void_AreaData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667357);
		NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_AreaData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667358);
		NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_ResourcePointData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667359);
		NativeMethodInfoPtr_KungfuSkillFocusDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667360);
		NativeMethodInfoPtr_GetJoinForceNeedDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667361);
		NativeMethodInfoPtr_PlayerMeetForceJoinRequire_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667362);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceData>.NativeClassPtr, 100667363);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123970, RefRangeEnd = 123971, XrefRangeStart = 123721, XrefRangeEnd = 123970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 123974, RefRangeEnd = 123980, XrefRangeStart = 123971, XrefRangeEnd = 123974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetResourcePercent(int resourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resourceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourcePercent_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123980, RefRangeEnd = 123981, XrefRangeStart = 123980, XrefRangeEnd = 123980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSalaryRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSalaryRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123983, RefRangeEnd = 123985, XrefRangeStart = 123981, XrefRangeEnd = 123983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRealSalaryCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRealSalaryCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123985, XrefRangeEnd = 123995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_ForceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124052, RefRangeEnd = 124056, XrefRangeStart = 123995, XrefRangeEnd = 124052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForceStopWarTime(int targetForceID, int time, bool back = true, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&targetForceID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &back;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceStopWarTime_Public_Void_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124067, RefRangeEnd = 124071, XrefRangeStart = 124056, XrefRangeEnd = 124067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetForceStopWarTime(int targetForceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetForceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceStopWarTime_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 124082, RefRangeEnd = 124089, XrefRangeStart = 124071, XrefRangeEnd = 124082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAllyForce(int targetForceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetForceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllyForce_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124132, RefRangeEnd = 124134, XrefRangeStart = 124089, XrefRangeEnd = 124132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAllyForce(int targetForceID, bool back = true, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&targetForceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &back;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAllyForce_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124178, RefRangeEnd = 124181, XrefRangeStart = 124134, XrefRangeEnd = 124178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BreakAllyForce(int targetForceID, bool back = true, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&targetForceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &back;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BreakAllyForce_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 124186, RefRangeEnd = 124192, XrefRangeStart = 124181, XrefRangeEnd = 124186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanAttack(int targetForceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetForceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAttack_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124204, RefRangeEnd = 124209, XrefRangeStart = 124192, XrefRangeEnd = 124204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetForceRelationshipText(int targetForceID, bool useDarkColor = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetForceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDarkColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceRelationshipText_Public_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124209, RefRangeEnd = 124210, XrefRangeStart = 124209, XrefRangeEnd = 124209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SexLimit ForceSexLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSexLimit_Public_SexLimit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SexLimit*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 124210, RefRangeEnd = 124218, XrefRangeStart = 124210, XrefRangeEnd = 124210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MeetForceSexLimit(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeetForceSexLimit_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 43697, RefRangeEnd = 43706, XrefRangeStart = 43697, XrefRangeEnd = 43706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetForceName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 124231, RefRangeEnd = 124240, XrefRangeStart = 124218, XrefRangeEnd = 124231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BookStorageAddBook(ItemData book, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)book);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BookStorageAddBook_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124285, RefRangeEnd = 124290, XrefRangeStart = 124240, XrefRangeEnd = 124285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForceJob(int jobType, int jobID, HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&jobType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceJob_Public_Void_Int32_Int32_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124290, RefRangeEnd = 124294, XrefRangeStart = 124290, XrefRangeEnd = 124290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceJobExtraExpRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceJobExtraExpRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 124294, RefRangeEnd = 124301, XrefRangeStart = 124294, XrefRangeEnd = 124294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetForceJobExtraAttriNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceJobExtraAttriNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(112)]
	[CachedScanResults(RefRangeStart = 124313, RefRangeEnd = 124425, XrefRangeStart = 124301, XrefRangeEnd = 124313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetOwnHero(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOwnHero_Public_HeroData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 124447, RefRangeEnd = 124463, XrefRangeStart = 124425, XrefRangeEnd = 124447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<HeroData> GetOwnHeros()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOwnHeros_Public_List_1_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 124488, RefRangeEnd = 124504, XrefRangeStart = 124463, XrefRangeEnd = 124488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<HeroData> FindAllHero(int minForceLv = -1, int maxForceLv = -1, bool noLeader = false, bool noJob = false, bool noPlayer = false, bool noPrison = false, bool noSpe = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&minForceLv);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxForceLv;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLeader;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &noJob;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &noPlayer;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &noPrison;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noSpe;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAllHero_Public_List_1_HeroData_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124522, RefRangeEnd = 124524, XrefRangeStart = 124504, XrefRangeEnd = 124522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChangeAllAreaState(AreaStateType areaStateType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&areaStateType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeAllAreaState_Public_Single_AreaStateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 124534, RefRangeEnd = 124556, XrefRangeStart = 124524, XrefRangeEnd = 124534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData MainArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MainArea_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 124557, RefRangeEnd = 124587, XrefRangeStart = 124556, XrefRangeEnd = 124557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceTechLvData GetNowResearchTech()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNowResearchTech_Public_ForceTechLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceTechLvData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124636, RefRangeEnd = 124637, XrefRangeStart = 124587, XrefRangeEnd = 124636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeNowResearch(bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeNowResearch_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124675, RefRangeEnd = 124678, XrefRangeStart = 124637, XrefRangeEnd = 124675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNowResearch(ForceTechLvData targetTech, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetTech);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNowResearch_Public_Void_ForceTechLvData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124680, RefRangeEnd = 124682, XrefRangeStart = 124678, XrefRangeEnd = 124680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AreaNotFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreaNotFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124684, RefRangeEnd = 124685, XrefRangeStart = 124682, XrefRangeEnd = 124684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxAreaNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxAreaNum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 124686, RefRangeEnd = 124697, XrefRangeStart = 124685, XrefRangeEnd = 124686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PopulationNotFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulationNotFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124699, RefRangeEnd = 124700, XrefRangeStart = 124697, XrefRangeEnd = 124699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxHeroNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxHeroNum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124702, RefRangeEnd = 124703, XrefRangeStart = 124700, XrefRangeEnd = 124702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForceFavor(ForceFavorSettingData setting)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)setting);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceFavor_Public_Void_ForceFavorSettingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124719, RefRangeEnd = 124721, XrefRangeStart = 124703, XrefRangeEnd = 124719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForceFavor(int id, float favor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &favor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceFavor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 124777, RefRangeEnd = 124831, XrefRangeStart = 124721, XrefRangeEnd = 124777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeForceFavor(int id, float favor, bool showInfo = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &favor;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeForceFavor_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 124836, RefRangeEnd = 124883, XrefRangeStart = 124831, XrefRangeEnd = 124836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceFavor(int forceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceFavor_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124889, RefRangeEnd = 124891, XrefRangeStart = 124883, XrefRangeEnd = 124889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetForceFavorRate(ForceData targetForce)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetForce);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceFavorRate_Public_Single_ForceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124893, RefRangeEnd = 124897, XrefRangeStart = 124891, XrefRangeEnd = 124893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124902, RefRangeEnd = 124907, XrefRangeStart = 124897, XrefRangeEnd = 124902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveResource(List<float> resourceList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveResource_Public_Boolean_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124913, RefRangeEnd = 124915, XrefRangeStart = 124907, XrefRangeEnd = 124913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 124916, RefRangeEnd = 124923, XrefRangeStart = 124915, XrefRangeEnd = 124916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124928, RefRangeEnd = 124931, XrefRangeStart = 124923, XrefRangeEnd = 124928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResource(List<float> resourceList, bool showInfo, bool showHud = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showHud;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124931, XrefRangeEnd = 124937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResource(List<ResourceData> resourceList, bool showInfo, bool showHud = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showHud;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResource_Public_Void_List_1_ResourceData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 124996, RefRangeEnd = 125042, XrefRangeStart = 124937, XrefRangeEnd = 124996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResource(int id, float num, bool showInfo = false, bool showHud = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showHud;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResource_Public_Void_Int32_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125042, XrefRangeEnd = 125050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetChangeResourceSound(int id, float num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeResourceSound_Public_Static_String_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 125055, RefRangeEnd = 125061, XrefRangeStart = 125050, XrefRangeEnd = 125055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(List<float> resourceList, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_List_1_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125067, RefRangeEnd = 125068, XrefRangeStart = 125061, XrefRangeEnd = 125067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(List<ResourceData> resourceList, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_List_1_ResourceData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 125069, RefRangeEnd = 125073, XrefRangeStart = 125068, XrefRangeEnd = 125069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(ResourceData resource, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_ResourceData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 125074, RefRangeEnd = 125077, XrefRangeStart = 125073, XrefRangeEnd = 125074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostResource(int id, float num, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostResource_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 125087, RefRangeEnd = 125122, XrefRangeStart = 125077, XrefRangeEnd = 125087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetLeader()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLeader_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125176, RefRangeEnd = 125178, XrefRangeStart = 125122, XrefRangeEnd = 125176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLeader(HeroData targetHero, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLeader_Public_Void_HeroData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125178, XrefRangeEnd = 125182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHero(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125186, RefRangeEnd = 125188, XrefRangeStart = 125182, XrefRangeEnd = 125186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHero(HeroData targetHero, int _forceLv, int _generation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLv;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_generation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHero_Public_Void_HeroData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125191, RefRangeEnd = 125192, XrefRangeStart = 125188, XrefRangeEnd = 125191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHero(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHero_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125245, RefRangeEnd = 125247, XrefRangeStart = 125192, XrefRangeEnd = 125245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceConquerArea(AreaData targetArea, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetArea);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceConquerArea_Public_Void_AreaData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125247, XrefRangeEnd = 125260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceConquerResourcePoint(AreaData targetArea, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetArea);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_AreaData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 125310, RefRangeEnd = 125314, XrefRangeStart = 125260, XrefRangeEnd = 125310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceConquerResourcePoint(ResourcePointData targetResourcePoint, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetResourcePoint);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceConquerResourcePoint_Public_Void_ResourcePointData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125332, RefRangeEnd = 125333, XrefRangeStart = 125314, XrefRangeEnd = 125332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string KungfuSkillFocusDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KungfuSkillFocusDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125455, RefRangeEnd = 125456, XrefRangeStart = 125333, XrefRangeEnd = 125455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetJoinForceNeedDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJoinForceNeedDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125508, RefRangeEnd = 125510, XrefRangeStart = 125456, XrefRangeEnd = 125508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PlayerMeetForceJoinRequire()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerMeetForceJoinRequire_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125525, RefRangeEnd = 125526, XrefRangeStart = 125510, XrefRangeEnd = 125525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ForceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
