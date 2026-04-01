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
public class MissionData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MissionBountyTypeRewardType;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_speMissionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_stageMinLeftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_rewardRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_treasureLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_bountyTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_minForceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionSourceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionBountyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionDisableQuickTravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionHideTargetPlace;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionHideTargetPlaceString;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionRandomSeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAutoFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionFunds;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionFameReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionContributionRewardBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionContributionReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionMoneyReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionJoinTeamHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionJoinTeamHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionTargetTypeBaseMissionContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionTargetNpc;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MissionRelateToHero_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDifficulty_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBountyTargetItem_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionBaseDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionExtraDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetInnID_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetAreaID_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerTargetDescribe_Public_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionTargetDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MissionNeedFinished_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe static List<string> MissionBountyTypeRewardType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionBountyTypeRewardType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionBountyTypeRewardType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int speMissionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMissionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMissionID)) = num;
		}
	}

	public unsafe int leftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime)) = num;
		}
	}

	public unsafe int stageMinLeftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stageMinLeftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stageMinLeftTime)) = num;
		}
	}

	public unsafe float difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty)) = num;
		}
	}

	public unsafe float difficultyRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyRate)) = num;
		}
	}

	public unsafe float rewardRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardRate)) = num;
		}
	}

	public unsafe float treasureLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLv);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLv)) = num;
		}
	}

	public unsafe List<BountyType> bountyTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bountyTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BountyType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bountyTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int minForceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minForceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minForceLv)) = num;
		}
	}

	public unsafe MissionSourceType missionSourceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionSourceType);
			return *(MissionSourceType*)num;
		}
		set
		{
			*(MissionSourceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionSourceType)) = missionSourceType;
		}
	}

	public unsafe BountyType missionBountyType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionBountyType);
			return *(BountyType*)num;
		}
		set
		{
			*(BountyType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionBountyType)) = bountyType;
		}
	}

	public unsafe int sourceHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceHeroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceHeroID)) = num;
		}
	}

	public unsafe int sourceForceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceForceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceForceID)) = num;
		}
	}

	public unsafe int missionHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHeroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHeroID)) = num;
		}
	}

	public unsafe bool missionDisableQuickTravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionDisableQuickTravel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionDisableQuickTravel)) = flag;
		}
	}

	public unsafe bool missionHideTargetPlace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHideTargetPlace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHideTargetPlace)) = flag;
		}
	}

	public unsafe string missionHideTargetPlaceString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHideTargetPlaceString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionHideTargetPlaceString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int missionRandomSeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRandomSeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRandomSeed)) = num;
		}
	}

	public unsafe List<MissionTargetData> missionTargetDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionTargetData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool noAutoFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoFinish);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoFinish)) = flag;
		}
	}

	public unsafe int missionFunds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFunds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFunds)) = num;
		}
	}

	public unsafe float missionFameReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFameReward);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionFameReward)) = num;
		}
	}

	public unsafe float missionContributionRewardBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionContributionRewardBase);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionContributionRewardBase)) = num;
		}
	}

	public unsafe float missionContributionReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionContributionReward);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionContributionReward)) = num;
		}
	}

	public unsafe int missionMoneyReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionMoneyReward);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionMoneyReward)) = num;
		}
	}

	public unsafe string missionJoinTeamHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionJoinTeamHero);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionJoinTeamHero)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<int> missionJoinTeamHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionJoinTeamHeroID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionJoinTeamHeroID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> MissionTargetTypeBaseMissionContribution
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionTargetTypeBaseMissionContribution, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionTargetTypeBaseMissionContribution, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<MissionTargetType> MissionTargetNpc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionTargetNpc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionTargetType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionTargetNpc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MissionData()
	{
		Il2CppClassPointerStore<MissionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MissionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionData>.NativeClassPtr);
		NativeFieldInfoPtr_MissionBountyTypeRewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "MissionBountyTypeRewardType");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_speMissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "speMissionID");
		NativeFieldInfoPtr_leftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "leftTime");
		NativeFieldInfoPtr_stageMinLeftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "stageMinLeftTime");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_difficultyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "difficultyRate");
		NativeFieldInfoPtr_rewardRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "rewardRate");
		NativeFieldInfoPtr_treasureLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "treasureLv");
		NativeFieldInfoPtr_bountyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "bountyTypes");
		NativeFieldInfoPtr_minForceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "minForceLv");
		NativeFieldInfoPtr_missionSourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionSourceType");
		NativeFieldInfoPtr_missionBountyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionBountyType");
		NativeFieldInfoPtr_sourceHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "sourceHeroID");
		NativeFieldInfoPtr_sourceForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "sourceForceID");
		NativeFieldInfoPtr_missionHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionHeroID");
		NativeFieldInfoPtr_missionDisableQuickTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionDisableQuickTravel");
		NativeFieldInfoPtr_missionHideTargetPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionHideTargetPlace");
		NativeFieldInfoPtr_missionHideTargetPlaceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionHideTargetPlaceString");
		NativeFieldInfoPtr_missionRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionRandomSeed");
		NativeFieldInfoPtr_missionTargetDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionTargetDatas");
		NativeFieldInfoPtr_noAutoFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "noAutoFinish");
		NativeFieldInfoPtr_missionFunds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionFunds");
		NativeFieldInfoPtr_missionFameReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionFameReward");
		NativeFieldInfoPtr_missionContributionRewardBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionContributionRewardBase");
		NativeFieldInfoPtr_missionContributionReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionContributionReward");
		NativeFieldInfoPtr_missionMoneyReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionMoneyReward");
		NativeFieldInfoPtr_missionJoinTeamHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionJoinTeamHero");
		NativeFieldInfoPtr_missionJoinTeamHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "missionJoinTeamHeroID");
		NativeFieldInfoPtr_MissionTargetTypeBaseMissionContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "MissionTargetTypeBaseMissionContribution");
		NativeFieldInfoPtr_MissionTargetNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, "MissionTargetNpc");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668030);
		NativeMethodInfoPtr_MissionRelateToHero_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668031);
		NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668032);
		NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668033);
		NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668034);
		NativeMethodInfoPtr_SetDifficulty_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668035);
		NativeMethodInfoPtr_GetMissionDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668036);
		NativeMethodInfoPtr_GetBountyTargetItem_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668037);
		NativeMethodInfoPtr_GetMissionBaseDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668038);
		NativeMethodInfoPtr_GetMissionExtraDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668039);
		NativeMethodInfoPtr_GetMissionDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668040);
		NativeMethodInfoPtr_GetTargetInnID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668041);
		NativeMethodInfoPtr_GetTargetAreaID_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668042);
		NativeMethodInfoPtr_GetTriggerTargetDescribe_Public_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668043);
		NativeMethodInfoPtr_GetMissionTargetDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668044);
		NativeMethodInfoPtr_MissionNeedFinished_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668045);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionData>.NativeClassPtr, 100668046);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 144133, RefRangeEnd = 144160, XrefRangeStart = 144096, XrefRangeEnd = 144133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 144192, RefRangeEnd = 144195, XrefRangeStart = 144160, XrefRangeEnd = 144192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MissionRelateToHero(int targetHeroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetHeroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MissionRelateToHero_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 144202, RefRangeEnd = 144207, XrefRangeStart = 144195, XrefRangeEnd = 144202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(MissionTargetType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_missionTargetType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_difficulty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 144214, RefRangeEnd = 144236, XrefRangeStart = 144207, XrefRangeEnd = 144214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty, int _minForceLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(MissionTargetType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_missionTargetType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_difficulty;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_minForceLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 144249, RefRangeEnd = 144251, XrefRangeStart = 144236, XrefRangeEnd = 144249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty, int _minForceLv, float _baseMissionContributionReward)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(MissionTargetType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_missionTargetType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_difficulty;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_minForceLv;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_baseMissionContributionReward;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceMission_Public_MissionData_String_MissionTargetType_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 144251, RefRangeEnd = 144257, XrefRangeStart = 144251, XrefRangeEnd = 144251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDifficulty(float _difficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_difficulty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDifficulty_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 144260, RefRangeEnd = 144262, XrefRangeStart = 144257, XrefRangeEnd = 144260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 144281, RefRangeEnd = 144282, XrefRangeStart = 144262, XrefRangeEnd = 144281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBountyTargetItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBountyTargetItem_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 144377, RefRangeEnd = 144381, XrefRangeStart = 144282, XrefRangeEnd = 144377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionBaseDescribe(bool showFinishRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showFinishRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionBaseDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 144488, RefRangeEnd = 144491, XrefRangeStart = 144381, XrefRangeEnd = 144488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionExtraDescribe(bool showMissionTargetType, bool showDifficulty, bool showFinishRate, bool showForceContribution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&showMissionTargetType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showDifficulty;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showFinishRate;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showForceContribution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionExtraDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 144494, RefRangeEnd = 144495, XrefRangeStart = 144491, XrefRangeEnd = 144494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionDescribe(bool showMissionTargetType, bool showDifficulty, bool showFinishRate, bool showForceContribution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&showMissionTargetType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showDifficulty;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showFinishRate;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showForceContribution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionDescribe_Public_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 144502, RefRangeEnd = 144504, XrefRangeStart = 144495, XrefRangeEnd = 144502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTargetInnID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTargetInnID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 144594, RefRangeEnd = 144599, XrefRangeStart = 144504, XrefRangeEnd = 144594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetTargetAreaID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTargetAreaID_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 144723, RefRangeEnd = 144729, XrefRangeStart = 144599, XrefRangeEnd = 144723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTriggerTargetDescribe(int targetID = 0, bool unclear = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unclear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerTargetDescribe_Public_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 145351, RefRangeEnd = 145354, XrefRangeStart = 144729, XrefRangeEnd = 145351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionTargetDescribe(bool showFinishRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showFinishRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionTargetDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 145360, RefRangeEnd = 145363, XrefRangeStart = 145354, XrefRangeEnd = 145360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MissionNeedFinished(int needDataID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&needDataID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MissionNeedFinished_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 145378, RefRangeEnd = 145386, XrefRangeStart = 145363, XrefRangeEnd = 145378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public MissionData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
