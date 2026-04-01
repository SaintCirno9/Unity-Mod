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
public class ItemListData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_money;

	private static readonly System.IntPtr NativeFieldInfoPtr_weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_allItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemTypeList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeList_Private_Void_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveList_Private_Void_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseItem_Public_Void_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_List_1_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BelongHero_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHero_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BelongForce_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForce_Public_ForceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

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

	public unsafe int money
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money)) = num;
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

	public unsafe float maxWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeight)) = num;
		}
	}

	public unsafe List<ItemData> allItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<ItemData>> itemTypeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTypeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<ItemData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTypeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ItemListData()
	{
		Il2CppClassPointerStore<ItemListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ItemListData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemListData>.NativeClassPtr);
		NativeFieldInfoPtr_heroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "heroID");
		NativeFieldInfoPtr_forceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "forceID");
		NativeFieldInfoPtr_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "money");
		NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "weight");
		NativeFieldInfoPtr_maxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "maxWeight");
		NativeFieldInfoPtr_allItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "allItem");
		NativeFieldInfoPtr_itemTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, "itemTypeList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667365);
		NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667366);
		NativeMethodInfoPtr_ClearAllItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667367);
		NativeMethodInfoPtr_GetItemName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667368);
		NativeMethodInfoPtr_GetItemValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667369);
		NativeMethodInfoPtr_MergeList_Private_Void_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667370);
		NativeMethodInfoPtr_RemoveList_Private_Void_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667371);
		NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667372);
		NativeMethodInfoPtr_LoseItem_Public_Void_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667373);
		NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667374);
		NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667375);
		NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_List_1_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667376);
		NativeMethodInfoPtr_BelongHero_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_GetHero_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr_BelongForce_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr_GetForce_Public_ForceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667380);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemListData>.NativeClassPtr, 100667381);
	}

	[CallerCount(74)]
	[CachedScanResults(RefRangeStart = 125585, RefRangeEnd = 125659, XrefRangeStart = 125526, XrefRangeEnd = 125585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemListData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemListData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125659, XrefRangeEnd = 125676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeserializedMethod(StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeserializedMethod_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 125685, RefRangeEnd = 125695, XrefRangeStart = 125676, XrefRangeEnd = 125685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 125712, RefRangeEnd = 125716, XrefRangeStart = 125695, XrefRangeEnd = 125712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetItemName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125720, RefRangeEnd = 125722, XrefRangeStart = 125716, XrefRangeEnd = 125720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetItemValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 125727, RefRangeEnd = 125734, XrefRangeStart = 125722, XrefRangeEnd = 125727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeList(ItemListData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeList_Private_Void_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125734, XrefRangeEnd = 125739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveList(ItemListData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveList_Private_Void_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 125727, RefRangeEnd = 125734, XrefRangeStart = 125727, XrefRangeEnd = 125734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItem(ItemListData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Void_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseItem(ItemListData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseItem_Public_Void_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 125788, RefRangeEnd = 125893, XrefRangeStart = 125739, XrefRangeEnd = 125788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItem(ItemData targetItem, bool showPopInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 125935, RefRangeEnd = 125963, XrefRangeStart = 125893, XrefRangeEnd = 125935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoseItem(ItemData targetItem, bool showPopInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoseItem_Public_Void_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 126004, RefRangeEnd = 126013, XrefRangeStart = 125963, XrefRangeEnd = 126004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData FindRandomItem(int minItemLv, int maxItemLv, bool includeEquipment, int targetItemType = -1, List<int> subType = null, int littleType = -1, float minValue = -1f, float maxValue = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&minItemLv);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxItemLv;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeEquipment;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetItemType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subType);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &littleType;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRandomItem_Public_ItemData_Int32_Int32_Boolean_Int32_List_1_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 126013, RefRangeEnd = 126025, XrefRangeStart = 126013, XrefRangeEnd = 126013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BelongHero()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BelongHero_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126034, RefRangeEnd = 126035, XrefRangeStart = 126025, XrefRangeEnd = 126034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetHero()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHero_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126035, RefRangeEnd = 126037, XrefRangeStart = 126035, XrefRangeEnd = 126035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BelongForce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BelongForce_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 126047, RefRangeEnd = 126054, XrefRangeStart = 126037, XrefRangeEnd = 126047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 126069, RefRangeEnd = 126070, XrefRangeStart = 126054, XrefRangeEnd = 126069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ItemListData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
