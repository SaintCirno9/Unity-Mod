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
public class AreaBuildingData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_buildingID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lv;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_noCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopItemList;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_produceRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceStoreRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemyMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelfHouseTotalAddPerLv;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStealItemMaxLv_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeEnemyMonth_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraPartyScore_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraPartyRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceProduceRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxResourceRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoManageResourceRate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetResourceStoreRate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Name_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_AreaBuildingDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildingAvailable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuyMoney_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelfHouseTotalAdd_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeResourceRate_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaBuildingRateChange_Public_List_1_AreaBuildingRateChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingSpeAddData_Public_ForceSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeMaxPeople_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeAreaState_Public_Single_AreaStateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeAllAreaState_Public_Single_AreaStateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalChangeResource_Public_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObstacleRemoveCostResource_Public_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingCureSkill_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingCureCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDestroyTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMoveTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArea_Public_AreaData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDestroyCostText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMoveCostText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingText_Public_String_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuidlingDetailText_Public_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int buildingID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingID)) = num;
		}
	}

	public unsafe int lv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv)) = num;
		}
	}

	public unsafe int buildTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildTimeLeft);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildTimeLeft)) = num;
		}
	}

	public unsafe int upgradeTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeTimeLeft);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeTimeLeft)) = num;
		}
	}

	public unsafe int destroyTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyTimeLeft);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyTimeLeft)) = num;
		}
	}

	public unsafe bool noCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noCancel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noCancel)) = flag;
		}
	}

	public unsafe ItemListData shopItemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopItemList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopItemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe List<MissionData> missionDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float produceRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_produceRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_produceRate)) = num;
		}
	}

	public unsafe float resourceStoreRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStoreRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceStoreRate)) = num;
		}
	}

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

	public unsafe int belongHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongHeroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongHeroID)) = num;
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

	public unsafe int enemyMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyMonth)) = num;
		}
	}

	public unsafe static float SelfHouseTotalAddPerLv
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelfHouseTotalAddPerLv, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelfHouseTotalAddPerLv, (void*)(&num));
		}
	}

	static AreaBuildingData()
	{
		Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaBuildingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr);
		NativeFieldInfoPtr_buildingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "buildingID");
		NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "lv");
		NativeFieldInfoPtr_buildTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "buildTimeLeft");
		NativeFieldInfoPtr_upgradeTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "upgradeTimeLeft");
		NativeFieldInfoPtr_destroyTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "destroyTimeLeft");
		NativeFieldInfoPtr_noCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "noCancel");
		NativeFieldInfoPtr_shopItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "shopItemList");
		NativeFieldInfoPtr_missionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "missionDatas");
		NativeFieldInfoPtr_produceRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "produceRate");
		NativeFieldInfoPtr_resourceStoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "resourceStoreRate");
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_belongHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "belongHeroID");
		NativeFieldInfoPtr_missionNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "missionNumCount");
		NativeFieldInfoPtr_plotNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "plotNumCount");
		NativeFieldInfoPtr_enemyMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "enemyMonth");
		NativeFieldInfoPtr_SelfHouseTotalAddPerLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, "SelfHouseTotalAddPerLv");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667138);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667139);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667140);
		NativeMethodInfoPtr_GetStealItemMaxLv_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667141);
		NativeMethodInfoPtr_ChangeEnemyMonth_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667142);
		NativeMethodInfoPtr_GetExtraPartyScore_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667143);
		NativeMethodInfoPtr_GetExtraPartyRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667144);
		NativeMethodInfoPtr_GetResourceProduceRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667145);
		NativeMethodInfoPtr_GetMaxResourceRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_AutoManageResourceRate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_ResetResourceStoreRate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_Name_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_DataBase_Public_AreaBuildingDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_BuildingAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_GetBuyMoney_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_GetSelfHouseTotalAdd_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr_ChangeResourceRate_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667154);
		NativeMethodInfoPtr_GetAreaBuildingRateChange_Public_List_1_AreaBuildingRateChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667155);
		NativeMethodInfoPtr_GetBuildingSpeAddData_Public_ForceSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667156);
		NativeMethodInfoPtr_GetChangeMaxPeople_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667157);
		NativeMethodInfoPtr_GetChangeAreaState_Public_Single_AreaStateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667158);
		NativeMethodInfoPtr_GetChangeAllAreaState_Public_Single_AreaStateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667159);
		NativeMethodInfoPtr_GetTotalChangeResource_Public_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_GetObstacleRemoveCostResource_Public_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667162);
		NativeMethodInfoPtr_GetBuildingCureSkill_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_GetBuildingCureCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667164);
		NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667165);
		NativeMethodInfoPtr_GetDestroyTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667166);
		NativeMethodInfoPtr_GetBuildTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667167);
		NativeMethodInfoPtr_GetMoveTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667168);
		NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667169);
		NativeMethodInfoPtr_GetArea_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667170);
		NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667171);
		NativeMethodInfoPtr_GetUpgradeDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667172);
		NativeMethodInfoPtr_GetDestroyCostText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667173);
		NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_GetMoveCostText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_GetBuildingText_Public_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_GetBuidlingDetailText_Public_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr, 100667178);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120602, XrefRangeEnd = 120603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120616, RefRangeEnd = 120619, XrefRangeStart = 120603, XrefRangeEnd = 120616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData(int _buildingID, int _lv, int _areaID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_buildingID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_lv;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_areaID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120632, RefRangeEnd = 120633, XrefRangeStart = 120619, XrefRangeEnd = 120632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingData(int _areaID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaBuildingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_areaID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120634, RefRangeEnd = 120637, XrefRangeStart = 120633, XrefRangeEnd = 120634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetStealItemMaxLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStealItemMaxLv_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 120653, RefRangeEnd = 120663, XrefRangeStart = 120637, XrefRangeEnd = 120653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeEnemyMonth(int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeEnemyMonth_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 120664, RefRangeEnd = 120670, XrefRangeStart = 120663, XrefRangeEnd = 120664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraPartyScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraPartyScore_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 120671, RefRangeEnd = 120677, XrefRangeStart = 120670, XrefRangeEnd = 120671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraPartyRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraPartyRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetResourceProduceRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceProduceRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMaxResourceRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxResourceRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120679, RefRangeEnd = 120680, XrefRangeStart = 120677, XrefRangeEnd = 120679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoManageResourceRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoManageResourceRate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ResetResourceStoreRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetResourceStoreRate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 120693, RefRangeEnd = 120708, XrefRangeStart = 120680, XrefRangeEnd = 120693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Name(bool withLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&withLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Name_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(59)]
	[CachedScanResults(RefRangeStart = 120718, RefRangeEnd = 120777, XrefRangeStart = 120708, XrefRangeEnd = 120718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingDataBase DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_AreaBuildingDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaBuildingDataBase>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 120777, RefRangeEnd = 120782, XrefRangeStart = 120777, XrefRangeEnd = 120777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BuildingAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildingAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120786, RefRangeEnd = 120787, XrefRangeStart = 120782, XrefRangeEnd = 120786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBuyMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuyMoney_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120791, RefRangeEnd = 120794, XrefRangeStart = 120787, XrefRangeEnd = 120791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSelfHouseTotalAdd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelfHouseTotalAdd_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120813, RefRangeEnd = 120814, XrefRangeStart = 120794, XrefRangeEnd = 120813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeResourceRate(float result, bool showInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&result);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeResourceRate_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120826, RefRangeEnd = 120827, XrefRangeStart = 120814, XrefRangeEnd = 120826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<AreaBuildingRateChange> GetAreaBuildingRateChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaBuildingRateChange_Public_List_1_AreaBuildingRateChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AreaBuildingRateChange>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120830, RefRangeEnd = 120831, XrefRangeStart = 120827, XrefRangeEnd = 120830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceSpeAddData GetBuildingSpeAddData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildingSpeAddData_Public_ForceSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120841, RefRangeEnd = 120842, XrefRangeStart = 120831, XrefRangeEnd = 120841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChangeMaxPeople()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeMaxPeople_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120853, RefRangeEnd = 120854, XrefRangeStart = 120842, XrefRangeEnd = 120853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120865, RefRangeEnd = 120866, XrefRangeStart = 120854, XrefRangeEnd = 120865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120878, RefRangeEnd = 120879, XrefRangeStart = 120866, XrefRangeEnd = 120878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<float> GetTotalChangeResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalChangeResource_Public_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 120894, RefRangeEnd = 120902, XrefRangeStart = 120879, XrefRangeEnd = 120894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<float> GetUpgradeCostResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120925, RefRangeEnd = 120928, XrefRangeStart = 120902, XrefRangeEnd = 120925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<float> GetObstacleRemoveCostResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObstacleRemoveCostResource_Public_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 120928, RefRangeEnd = 120937, XrefRangeStart = 120928, XrefRangeEnd = 120928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBuildingCureSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildingCureSkill_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120937, RefRangeEnd = 120940, XrefRangeStart = 120937, XrefRangeEnd = 120937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBuildingCureCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildingCureCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 120953, RefRangeEnd = 120961, XrefRangeStart = 120940, XrefRangeEnd = 120953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120975, RefRangeEnd = 120977, XrefRangeStart = 120961, XrefRangeEnd = 120975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDestroyTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDestroyTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120990, RefRangeEnd = 120991, XrefRangeStart = 120977, XrefRangeEnd = 120990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBuildTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 121004, RefRangeEnd = 121008, XrefRangeStart = 120991, XrefRangeEnd = 121004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMoveTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMoveTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 121014, RefRangeEnd = 121019, XrefRangeStart = 121008, XrefRangeEnd = 121014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBuildSpeedRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 121029, RefRangeEnd = 121063, XrefRangeStart = 121019, XrefRangeEnd = 121029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData GetArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArea_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 121167, RefRangeEnd = 121169, XrefRangeStart = 121063, XrefRangeEnd = 121167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUpgrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 121356, RefRangeEnd = 121358, XrefRangeStart = 121169, XrefRangeEnd = 121356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUpgradeDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121365, RefRangeEnd = 121366, XrefRangeStart = 121358, XrefRangeEnd = 121365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDestroyCostText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDestroyCostText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121366, XrefRangeEnd = 121378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUpgradeCostText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121378, XrefRangeEnd = 121385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMoveCostText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMoveCostText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121418, RefRangeEnd = 121419, XrefRangeStart = 121385, XrefRangeEnd = 121418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBuildingText(bool showBuildingName, bool detail, bool showBuildTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&showBuildingName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &detail;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showBuildTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildingText_Public_String_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121452, RefRangeEnd = 121453, XrefRangeStart = 121419, XrefRangeEnd = 121452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBuidlingDetailText(bool showBuildingName, bool detail)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&showBuildingName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &detail;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuidlingDetailText_Public_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121453, XrefRangeEnd = 121468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaBuildingData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
