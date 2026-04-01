using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ItemData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_subType;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkName;

	private static readonly System.IntPtr NativeFieldInfoPtr_describe;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_rareLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonNumDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_setName;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipmentData;

	private static readonly System.IntPtr NativeFieldInfoPtr_medFoodData;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookData;

	private static readonly System.IntPtr NativeFieldInfoPtr_treasureData;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialData;

	private static readonly System.IntPtr NativeFieldInfoPtr_horseData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseMaxWeightAdd_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeaponResearchExp_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHeroEquip_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemIconName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectPoisonNum_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSoundName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayItemSound_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemTypeDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBookRareLvName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BadFame_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShowRoomFameChange_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equiped_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialData_Public_ItemData_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialExtraCraftRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBookData_Public_ItemData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTreasureData_Public_ItemData_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecountRareLv_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountValueAndWeight_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTreasureValue_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTreasureRealValue_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContributionCost_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGovernContributionCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadBookContributionCost_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseSeeRange_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseStepAddRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentifyOneResult_Public_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentify_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullIdentify_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagePlayerGuessTreasureLv_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Name_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int itemID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID)) = num;
		}
	}

	public unsafe ItemType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ItemType*)num;
		}
		set
		{
			*(ItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = itemType;
		}
	}

	public unsafe int subType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subType)) = num;
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

	public unsafe string checkName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string describe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
		}
	}

	public unsafe int itemLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLv)) = num;
		}
	}

	public unsafe int rareLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv)) = num;
		}
	}

	public unsafe float weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight)) = num;
		}
	}

	public unsafe bool isNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNew);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNew)) = flag;
		}
	}

	public unsafe float poisonNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonNum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonNum)) = num;
		}
	}

	public unsafe bool poisonNumDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonNumDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonNumDetected)) = flag;
		}
	}

	public unsafe string setName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe EquipmentData equipmentData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipmentData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EquipmentData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipmentData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipmentData));
		}
	}

	public unsafe MedFoodData medFoodData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medFoodData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MedFoodData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medFoodData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)medFoodData));
		}
	}

	public unsafe BookData bookData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BookData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bookData));
		}
	}

	public unsafe TreasureData treasureData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TreasureData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treasureData));
		}
	}

	public unsafe MaterialData materialData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialData));
		}
	}

	public unsafe HorseData horseData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HorseData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horseData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)horseData));
		}
	}

	static ItemData()
	{
		Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ItemData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
		NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "itemID");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "type");
		NativeFieldInfoPtr_subType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "subType");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_checkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "checkName");
		NativeFieldInfoPtr_describe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "describe");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "value");
		NativeFieldInfoPtr_itemLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "itemLv");
		NativeFieldInfoPtr_rareLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "rareLv");
		NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "weight");
		NativeFieldInfoPtr_isNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "isNew");
		NativeFieldInfoPtr_poisonNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "poisonNum");
		NativeFieldInfoPtr_poisonNumDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "poisonNumDetected");
		NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "setName");
		NativeFieldInfoPtr_equipmentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "equipmentData");
		NativeFieldInfoPtr_medFoodData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "medFoodData");
		NativeFieldInfoPtr_bookData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "bookData");
		NativeFieldInfoPtr_treasureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "treasureData");
		NativeFieldInfoPtr_materialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "materialData");
		NativeFieldInfoPtr_horseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "horseData");
		NativeMethodInfoPtr__ctor_Public_Void_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667960);
		NativeMethodInfoPtr_GetHorseMaxWeightAdd_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667961);
		NativeMethodInfoPtr_GetWeaponResearchExp_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667962);
		NativeMethodInfoPtr_IsHeroEquip_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667963);
		NativeMethodInfoPtr_GetItemIconName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667964);
		NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667965);
		NativeMethodInfoPtr_DetectPoisonNum_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667966);
		NativeMethodInfoPtr_GetItemSoundName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667967);
		NativeMethodInfoPtr_PlayItemSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667968);
		NativeMethodInfoPtr_GetItemTypeDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667969);
		NativeMethodInfoPtr_GetBookRareLvName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667970);
		NativeMethodInfoPtr_BadFame_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667971);
		NativeMethodInfoPtr_GetShowRoomFameChange_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667972);
		NativeMethodInfoPtr_Equiped_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667973);
		NativeMethodInfoPtr_SetMaterialData_Public_ItemData_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667974);
		NativeMethodInfoPtr_GetMaterialExtraCraftRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667975);
		NativeMethodInfoPtr_SetBookData_Public_ItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667976);
		NativeMethodInfoPtr_SetTreasureData_Public_ItemData_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667977);
		NativeMethodInfoPtr_RecountRareLv_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667978);
		NativeMethodInfoPtr_CountValueAndWeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667979);
		NativeMethodInfoPtr_GetTreasureValue_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667980);
		NativeMethodInfoPtr_GetTreasureRealValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667981);
		NativeMethodInfoPtr_GetContributionCost_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667982);
		NativeMethodInfoPtr_GetGovernContributionCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667983);
		NativeMethodInfoPtr_GetReadBookContributionCost_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667984);
		NativeMethodInfoPtr_GetHorseSeeRange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667985);
		NativeMethodInfoPtr_GetHorseStepAddRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667986);
		NativeMethodInfoPtr_TryIdentifyOneResult_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667987);
		NativeMethodInfoPtr_TryIdentify_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667988);
		NativeMethodInfoPtr_FullIdentify_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667989);
		NativeMethodInfoPtr_ManagePlayerGuessTreasureLv_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667990);
		NativeMethodInfoPtr_Name_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667991);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100667992);
	}

	[CallerCount(140)]
	[CachedScanResults(RefRangeStart = 142312, RefRangeEnd = 142452, XrefRangeStart = 142281, XrefRangeEnd = 142312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData(ItemType _type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142452, RefRangeEnd = 142455, XrefRangeStart = 142452, XrefRangeEnd = 142452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseMaxWeightAdd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseMaxWeightAdd_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142456, RefRangeEnd = 142457, XrefRangeStart = 142455, XrefRangeEnd = 142456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWeaponResearchExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeaponResearchExp_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 142472, RefRangeEnd = 142474, XrefRangeStart = 142457, XrefRangeEnd = 142472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHeroEquip(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHeroEquip_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 142566, RefRangeEnd = 142585, XrefRangeStart = 142474, XrefRangeEnd = 142566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetItemIconName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemIconName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 142592, RefRangeEnd = 142597, XrefRangeStart = 142585, XrefRangeEnd = 142592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoManageEquipPoison(int heroLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heroLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoManageEquipPoison_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 142608, RefRangeEnd = 142615, XrefRangeStart = 142597, XrefRangeEnd = 142608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DetectPoisonNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectPoisonNum_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142629, RefRangeEnd = 142630, XrefRangeStart = 142615, XrefRangeEnd = 142629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetItemSoundName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemSoundName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142681, RefRangeEnd = 142684, XrefRangeStart = 142630, XrefRangeEnd = 142681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayItemSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayItemSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 142720, RefRangeEnd = 142727, XrefRangeStart = 142684, XrefRangeEnd = 142720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetItemTypeDescribe(bool italic = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&italic);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemTypeDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 142735, RefRangeEnd = 142741, XrefRangeStart = 142727, XrefRangeEnd = 142735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBookRareLvName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBookRareLvName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 142741, RefRangeEnd = 142753, XrefRangeStart = 142741, XrefRangeEnd = 142741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float BadFame(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BadFame_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 142753, RefRangeEnd = 142758, XrefRangeStart = 142753, XrefRangeEnd = 142753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetShowRoomFameChange(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShowRoomFameChange_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 142758, RefRangeEnd = 142769, XrefRangeStart = 142758, XrefRangeEnd = 142758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equiped()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equiped_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 142780, RefRangeEnd = 142784, XrefRangeStart = 142769, XrefRangeEnd = 142780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData SetMaterialData(int _subType, int _itemLv, int _rareLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_subType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_itemLv;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_rareLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialData_Public_ItemData_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 142786, RefRangeEnd = 142801, XrefRangeStart = 142784, XrefRangeEnd = 142786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaterialExtraCraftRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialExtraCraftRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(113)]
	[CachedScanResults(RefRangeStart = 142811, RefRangeEnd = 142924, XrefRangeStart = 142801, XrefRangeEnd = 142811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData SetBookData(int _skillID, int _rareLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_skillID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_rareLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBookData_Public_ItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143022, RefRangeEnd = 143024, XrefRangeStart = 142924, XrefRangeEnd = 143022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData SetTreasureData(int _subType, int _itemLv, int _rareLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_subType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_itemLv;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_rareLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTreasureData_Public_ItemData_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143048, RefRangeEnd = 143049, XrefRangeStart = 143024, XrefRangeEnd = 143048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecountRareLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecountRareLv_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 143094, RefRangeEnd = 143111, XrefRangeStart = 143049, XrefRangeEnd = 143094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CountValueAndWeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountValueAndWeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143130, RefRangeEnd = 143132, XrefRangeStart = 143111, XrefRangeEnd = 143130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTreasureValue(bool guess = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&guess);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTreasureValue_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 143139, RefRangeEnd = 143142, XrefRangeStart = 143132, XrefRangeEnd = 143139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTreasureRealValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTreasureRealValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143152, RefRangeEnd = 143153, XrefRangeStart = 143142, XrefRangeEnd = 143152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetContributionCost(int heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContributionCost_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143154, RefRangeEnd = 143155, XrefRangeStart = 143153, XrefRangeEnd = 143154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGovernContributionCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGovernContributionCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143165, RefRangeEnd = 143166, XrefRangeStart = 143155, XrefRangeEnd = 143165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetReadBookContributionCost(int heroID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heroID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadBookContributionCost_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 143166, RefRangeEnd = 143169, XrefRangeStart = 143166, XrefRangeEnd = 143166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseSeeRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseSeeRange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 143169, RefRangeEnd = 143172, XrefRangeStart = 143169, XrefRangeEnd = 143169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHorseStepAddRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseStepAddRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143177, RefRangeEnd = 143178, XrefRangeStart = 143172, XrefRangeEnd = 143177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryIdentifyOneResult(float identifyKnowledge, float identifyDifficulty)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&identifyKnowledge);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &identifyDifficulty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryIdentifyOneResult_Public_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143182, RefRangeEnd = 143183, XrefRangeStart = 143178, XrefRangeEnd = 143182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float TryIdentify(float identifyKnowledge)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&identifyKnowledge);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryIdentify_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143191, RefRangeEnd = 143193, XrefRangeStart = 143183, XrefRangeEnd = 143191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FullIdentify()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullIdentify_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143238, RefRangeEnd = 143239, XrefRangeStart = 143193, XrefRangeEnd = 143238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManagePlayerGuessTreasureLv(float playerKnowledgeLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerKnowledgeLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagePlayerGuessTreasureLv_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(137)]
	[CachedScanResults(RefRangeStart = 143253, RefRangeEnd = 143390, XrefRangeStart = 143239, XrefRangeEnd = 143253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Name(bool colored = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&colored);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Name_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 143405, RefRangeEnd = 143415, XrefRangeStart = 143390, XrefRangeEnd = 143405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ItemData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
