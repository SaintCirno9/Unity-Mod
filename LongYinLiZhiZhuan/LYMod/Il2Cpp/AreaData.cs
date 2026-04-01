using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class AreaData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaName;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaStartLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteName;

	private static readonly System.IntPtr NativeFieldInfoPtr_backgroundType;

	private static readonly System.IntPtr NativeFieldInfoPtr_backgroundSkinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_xScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigMapPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPeople;

	private static readonly System.IntPtr NativeFieldInfoPtr_people;

	private static readonly System.IntPtr NativeFieldInfoPtr_safe;

	private static readonly System.IntPtr NativeFieldInfoPtr_support;

	private static readonly System.IntPtr NativeFieldInfoPtr_defence;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeAreaState;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeAllAreaState;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_insideHeros;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceValueRateBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceValueRateTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectResourcePointID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaSpeAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaBranchDefenceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaBranchDefenceUpgradeLeftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaTreasurePriceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaDetailDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaInfoDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisMonthManaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaInteractionTimeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_speProduct;

	private static readonly System.IntPtr NativeFieldInfoPtr_branchLeaderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoBuild;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoBuildResourceRateLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoBuildPriority;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_AreaData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BelongPlayerOrAlley_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaMapRandomEventCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeBuildingNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterBuilding_Public_AreaBuildingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInsideHeros_Public_List_1_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInsideHero_Public_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBranchLeader_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAddState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanReduceState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecordLog_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLog_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAreaState_Public_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaStatePercent_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaState_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxAreaState_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSupport_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafe_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeAreaState_Public_Single_AreaStateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeAreaState_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForce_Public_ForceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonthChangeSupport_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonthChangeSafe_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonthChangeDefence_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePeople_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePeople_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TotalState_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageTempResourceValueRate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaStateProduceRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColumn_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRow_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAroundTiles_Public_List_1_AreaTileData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_Public_AreaTileData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int areaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID)) = num;
		}
	}

	public unsafe string areaName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int areaStartLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaStartLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaStartLv)) = num;
		}
	}

	public unsafe string spriteName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string backgroundType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int backgroundSkinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundSkinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundSkinID)) = num;
		}
	}

	public unsafe float xScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xScale)) = num;
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

	public unsafe int areaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaType)) = num;
		}
	}

	public unsafe float maxPeople
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPeople);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPeople)) = num;
		}
	}

	public unsafe float people
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_people);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_people)) = num;
		}
	}

	public unsafe float safe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safe);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safe)) = num;
		}
	}

	public unsafe float support
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_support);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_support)) = num;
		}
	}

	public unsafe float defence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defence);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defence)) = num;
		}
	}

	public unsafe List<float> changeAreaState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAreaState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAreaState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> changeAllAreaState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAllAreaState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAllAreaState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe List<int> insideHeros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insideHeros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insideHeros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> changeResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeResource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeResource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> resourceValueRateBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> resourceValueRateTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateTemp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateTemp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> connectAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectAreaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectAreaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> nearAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> connectResourcePointID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectResourcePointID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectResourcePointID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForceSpeAddData areaSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceSpeAddData));
		}
	}

	public unsafe int mapWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapWidth)) = num;
		}
	}

	public unsafe int mapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapHeight)) = num;
		}
	}

	public unsafe List<AreaTileData> areaTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaTileData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> roadTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> areaBranchDefenceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaBranchDefenceLv);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaBranchDefenceLv)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> areaBranchDefenceUpgradeLeftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaBranchDefenceUpgradeLeftTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaBranchDefenceUpgradeLeftTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AreaTreasurePriceData> areaTreasurePriceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTreasurePriceData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaTreasurePriceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTreasurePriceData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe bool areaDetailDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDetailDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDetailDirty)) = flag;
		}
	}

	public unsafe bool areaInfoDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaInfoDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaInfoDirty)) = flag;
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

	public unsafe AreaInteractionTimeData areaInteractionTimeData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaInteractionTimeData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaInteractionTimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaInteractionTimeData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaInteractionTimeData));
		}
	}

	public unsafe List<string> speProduct
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speProduct);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speProduct)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int branchLeaderID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_branchLeaderID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_branchLeaderID)) = num;
		}
	}

	public unsafe bool autoBuild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuild)) = flag;
		}
	}

	public unsafe float autoBuildResourceRateLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuildResourceRateLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuildResourceRateLimit)) = num;
		}
	}

	public unsafe int autoBuildPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuildPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBuildPriority)) = num;
		}
	}

	static AreaData()
	{
		Il2CppClassPointerStore<AreaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaData>.NativeClassPtr);
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_areaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaName");
		NativeFieldInfoPtr_areaStartLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaStartLv");
		NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "spriteName");
		NativeFieldInfoPtr_backgroundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "backgroundType");
		NativeFieldInfoPtr_backgroundSkinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "backgroundSkinID");
		NativeFieldInfoPtr_xScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "xScale");
		NativeFieldInfoPtr_bigMapPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "bigMapPos");
		NativeFieldInfoPtr_areaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaType");
		NativeFieldInfoPtr_maxPeople = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "maxPeople");
		NativeFieldInfoPtr_people = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "people");
		NativeFieldInfoPtr_safe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "safe");
		NativeFieldInfoPtr_support = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "support");
		NativeFieldInfoPtr_defence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "defence");
		NativeFieldInfoPtr_changeAreaState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "changeAreaState");
		NativeFieldInfoPtr_changeAllAreaState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "changeAllAreaState");
		NativeFieldInfoPtr_belongForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "belongForceID");
		NativeFieldInfoPtr_insideHeros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "insideHeros");
		NativeFieldInfoPtr_changeResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "changeResource");
		NativeFieldInfoPtr_resourceValueRateBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "resourceValueRateBase");
		NativeFieldInfoPtr_resourceValueRateTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "resourceValueRateTemp");
		NativeFieldInfoPtr_connectAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "connectAreaID");
		NativeFieldInfoPtr_nearAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "nearAreaID");
		NativeFieldInfoPtr_connectResourcePointID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "connectResourcePointID");
		NativeFieldInfoPtr_areaSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaSpeAddData");
		NativeFieldInfoPtr_mapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "mapWidth");
		NativeFieldInfoPtr_mapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "mapHeight");
		NativeFieldInfoPtr_areaTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaTiles");
		NativeFieldInfoPtr_roadTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "roadTiles");
		NativeFieldInfoPtr_areaBranchDefenceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaBranchDefenceLv");
		NativeFieldInfoPtr_areaBranchDefenceUpgradeLeftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaBranchDefenceUpgradeLeftTime");
		NativeFieldInfoPtr_areaTreasurePriceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaTreasurePriceData");
		NativeFieldInfoPtr_recordLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "recordLog");
		NativeFieldInfoPtr_areaDetailDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaDetailDirty");
		NativeFieldInfoPtr_areaInfoDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaInfoDirty");
		NativeFieldInfoPtr_thisMonthManaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "thisMonthManaged");
		NativeFieldInfoPtr_missionNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "missionNumCount");
		NativeFieldInfoPtr_plotNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "plotNumCount");
		NativeFieldInfoPtr_areaInteractionTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "areaInteractionTimeData");
		NativeFieldInfoPtr_speProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "speProduct");
		NativeFieldInfoPtr_branchLeaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "branchLeaderID");
		NativeFieldInfoPtr_autoBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "autoBuild");
		NativeFieldInfoPtr_autoBuildResourceRateLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "autoBuildResourceRateLimit");
		NativeFieldInfoPtr_autoBuildPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, "autoBuildPriority");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667214);
		NativeMethodInfoPtr_DataBase_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667215);
		NativeMethodInfoPtr_BelongPlayerOrAlley_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667216);
		NativeMethodInfoPtr_GetAreaName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667217);
		NativeMethodInfoPtr_GetAreaMapRandomEventCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667218);
		NativeMethodInfoPtr_GetSpeBuildingNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667219);
		NativeMethodInfoPtr_GetCenterBuilding_Public_AreaBuildingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667220);
		NativeMethodInfoPtr_GetInsideHeros_Public_List_1_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr_GetInsideHero_Public_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667222);
		NativeMethodInfoPtr_SetBranchLeader_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_CanAddState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_CanReduceState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr_GetRecordLog_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667227);
		NativeMethodInfoPtr_AddLog_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667228);
		NativeMethodInfoPtr_ChangeAreaState_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667229);
		NativeMethodInfoPtr_GetAreaStatePercent_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667230);
		NativeMethodInfoPtr_GetAreaState_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667231);
		NativeMethodInfoPtr_GetMaxAreaState_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667232);
		NativeMethodInfoPtr_GetSupport_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667233);
		NativeMethodInfoPtr_GetSafe_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667235);
		NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_GetChangeAreaState_Public_Single_AreaStateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_GetChangeAreaState_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667238);
		NativeMethodInfoPtr_GetForceColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_GetForce_Public_ForceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_GetMonthChangeSupport_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_GetMonthChangeSafe_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_GetMonthChangeDefence_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_ChangePeople_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_ChangePeople_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr_TotalState_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_ResetAllState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_ManageTempResourceValueRate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_GetAreaStateProduceRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_GetColumn_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_GetRow_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_GetAroundTiles_Public_List_1_AreaTileData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr_GetTile_Public_AreaTileData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100667260);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122128, RefRangeEnd = 122129, XrefRangeStart = 121969, XrefRangeEnd = 122128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 122139, RefRangeEnd = 122149, XrefRangeStart = 122129, XrefRangeEnd = 122139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122159, RefRangeEnd = 122163, XrefRangeStart = 122149, XrefRangeEnd = 122159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BelongPlayerOrAlley()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BelongPlayerOrAlley_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 43697, RefRangeEnd = 43706, XrefRangeStart = 43697, XrefRangeEnd = 43706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAreaName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122181, RefRangeEnd = 122182, XrefRangeStart = 122163, XrefRangeEnd = 122181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAreaMapRandomEventCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaMapRandomEventCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122193, RefRangeEnd = 122195, XrefRangeStart = 122182, XrefRangeEnd = 122193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSpeBuildingNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeBuildingNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 122208, RefRangeEnd = 122261, XrefRangeStart = 122195, XrefRangeEnd = 122208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData GetCenterBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCenterBuilding_Public_AreaBuildingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaBuildingData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122283, RefRangeEnd = 122285, XrefRangeStart = 122261, XrefRangeEnd = 122283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<HeroData> GetInsideHeros()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInsideHeros_Public_List_1_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 122297, RefRangeEnd = 122387, XrefRangeStart = 122285, XrefRangeEnd = 122297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetInsideHero(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInsideHero_Public_HeroData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 122396, RefRangeEnd = 122402, XrefRangeStart = 122387, XrefRangeEnd = 122396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBranchLeader(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBranchLeader_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122402, RefRangeEnd = 122404, XrefRangeStart = 122402, XrefRangeEnd = 122402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAutoSetting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAutoSetting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool CanAddState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAddState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CanReduceState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanReduceState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122414, RefRangeEnd = 122415, XrefRangeStart = 122404, XrefRangeEnd = 122414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRecordLog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecordLog_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 122464, RefRangeEnd = 122479, XrefRangeStart = 122415, XrefRangeEnd = 122464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLog(string newLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newLog);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLog_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 122483, RefRangeEnd = 122491, XrefRangeStart = 122479, XrefRangeEnd = 122483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAreaState(int areaStateType, float result, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&areaStateType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAreaState_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122491, RefRangeEnd = 122496, XrefRangeStart = 122491, XrefRangeEnd = 122491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAreaStatePercent(int areaStateType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&areaStateType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaStatePercent_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122496, RefRangeEnd = 122499, XrefRangeStart = 122496, XrefRangeEnd = 122496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAreaState(int areaStateType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&areaStateType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaState_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122499, RefRangeEnd = 122500, XrefRangeStart = 122499, XrefRangeEnd = 122499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxAreaState(int areaStateType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&areaStateType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxAreaState_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122500, RefRangeEnd = 122503, XrefRangeStart = 122500, XrefRangeEnd = 122500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSupport()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSupport_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122503, RefRangeEnd = 122505, XrefRangeStart = 122503, XrefRangeEnd = 122503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSafe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafe_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122519, RefRangeEnd = 122523, XrefRangeStart = 122505, XrefRangeEnd = 122519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData FindBuilding(string buildingName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaBuildingData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122535, RefRangeEnd = 122538, XrefRangeStart = 122523, XrefRangeEnd = 122535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData FindBuilding(int buildingID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBuilding_Public_AreaBuildingData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaBuildingData>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 122544, RefRangeEnd = 122554, XrefRangeStart = 122538, XrefRangeEnd = 122544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChangeAreaState(AreaStateType areaStateType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&areaStateType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeAreaState_Public_Single_AreaStateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 122544, RefRangeEnd = 122554, XrefRangeStart = 122544, XrefRangeEnd = 122554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChangeAreaState(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeAreaState_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122568, RefRangeEnd = 122570, XrefRangeStart = 122554, XrefRangeEnd = 122568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetForceColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(137)]
	[CachedScanResults(RefRangeStart = 122580, RefRangeEnd = 122717, XrefRangeStart = 122570, XrefRangeEnd = 122580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceData GetForce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForce_Public_ForceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122717, RefRangeEnd = 122718, XrefRangeStart = 122717, XrefRangeEnd = 122717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMonthChangeSupport()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonthChangeSupport_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122718, RefRangeEnd = 122719, XrefRangeStart = 122718, XrefRangeEnd = 122718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMonthChangeSafe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonthChangeSafe_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122719, RefRangeEnd = 122720, XrefRangeStart = 122719, XrefRangeEnd = 122719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMonthChangeDefence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonthChangeDefence_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122726, RefRangeEnd = 122730, XrefRangeStart = 122720, XrefRangeEnd = 122726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePeople(float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePeople_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122736, RefRangeEnd = 122741, XrefRangeStart = 122730, XrefRangeEnd = 122736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSupport(float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122747, RefRangeEnd = 122752, XrefRangeStart = 122741, XrefRangeEnd = 122747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSafe(float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122758, RefRangeEnd = 122763, XrefRangeStart = 122752, XrefRangeEnd = 122758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeDefence(float num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122779, RefRangeEnd = 122781, XrefRangeStart = 122763, XrefRangeEnd = 122779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePeople(float num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePeople_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 122797, RefRangeEnd = 122803, XrefRangeStart = 122781, XrefRangeEnd = 122797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSupport(float num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSupport_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 122819, RefRangeEnd = 122825, XrefRangeStart = 122803, XrefRangeEnd = 122819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeSafe(float num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeSafe_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122841, RefRangeEnd = 122842, XrefRangeStart = 122825, XrefRangeEnd = 122841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeDefence(float num, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&num);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeDefence_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122842, RefRangeEnd = 122844, XrefRangeStart = 122842, XrefRangeEnd = 122842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float TotalState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TotalState_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122853, RefRangeEnd = 122854, XrefRangeStart = 122844, XrefRangeEnd = 122853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAllState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAllState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122870, RefRangeEnd = 122871, XrefRangeStart = 122854, XrefRangeEnd = 122870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageTempResourceValueRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageTempResourceValueRate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122874, RefRangeEnd = 122875, XrefRangeStart = 122871, XrefRangeEnd = 122874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAreaStateProduceRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaStateProduceRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetColumn(int tileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColumn_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetRow(int tileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRow_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122899, RefRangeEnd = 122901, XrefRangeStart = 122875, XrefRangeEnd = 122899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<AreaTileData> GetAroundTiles(int tileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAroundTiles_Public_List_1_AreaTileData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaTileData>>(intPtr) : null;
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 122904, RefRangeEnd = 122975, XrefRangeStart = 122901, XrefRangeEnd = 122904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaTileData GetTile(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTile_Public_AreaTileData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaTileData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122990, RefRangeEnd = 122991, XrefRangeStart = 122975, XrefRangeEnd = 122990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
