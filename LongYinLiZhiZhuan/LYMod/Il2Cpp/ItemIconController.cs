using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class ItemIconController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_itemListID;

	private static readonly IntPtr NativeFieldInfoPtr_itemData;

	private static readonly IntPtr NativeFieldInfoPtr_itemIconType;

	private static readonly IntPtr NativeFieldInfoPtr_tradeIconType;

	private static readonly IntPtr NativeFieldInfoPtr_updateTime;

	private static readonly IntPtr NativeFieldInfoPtr_PriceColor;

	private static readonly IntPtr NativeFieldInfoPtr_ContributionColor;

	private static readonly IntPtr NativeFieldInfoPtr_BookContributionColor;

	private static readonly IntPtr NativeFieldInfoPtr_GovernContributionColor;

	private static readonly IntPtr NativeFieldInfoPtr_inited;

	private static readonly IntPtr NativeFieldInfoPtr_hideItemName;

	private static readonly IntPtr NativeFieldInfoPtr_hideItemBox;

	private static readonly IntPtr NativeFieldInfoPtr_needRefreshPriceIcon;

	private static readonly IntPtr NativeFieldInfoPtr_fromStorage;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemAreaSpeRate_Public_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemTreasureSpeRate_Public_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHeroFavorValueRate_Public_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AutoSetName_Public_Void_ItemSortType_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int itemListID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemListID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemListID)) = num;
		}
	}

	public unsafe ItemData itemData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe ItemIconType itemIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIconType);
			return *(ItemIconType*)num;
		}
		set
		{
			*(ItemIconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIconType)) = itemIconType;
		}
	}

	public unsafe TradeIconType tradeIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeIconType);
			return *(TradeIconType*)num;
		}
		set
		{
			*(TradeIconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeIconType)) = tradeIconType;
		}
	}

	public unsafe float updateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateTime)) = num;
		}
	}

	public unsafe static Color PriceColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PriceColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PriceColor, (void*)(&color));
		}
	}

	public unsafe static Color ContributionColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ContributionColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ContributionColor, (void*)(&color));
		}
	}

	public unsafe static Color BookContributionColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BookContributionColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BookContributionColor, (void*)(&color));
		}
	}

	public unsafe static Color GovernContributionColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GovernContributionColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GovernContributionColor, (void*)(&color));
		}
	}

	public unsafe bool inited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited)) = flag;
		}
	}

	public unsafe bool hideItemName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideItemName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideItemName)) = flag;
		}
	}

	public unsafe bool hideItemBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideItemBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideItemBox)) = flag;
		}
	}

	public unsafe bool needRefreshPriceIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefreshPriceIcon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefreshPriceIcon)) = flag;
		}
	}

	public unsafe string fromStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromStorage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromStorage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ItemIconController()
	{
		Il2CppClassPointerStore<ItemIconController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ItemIconController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr);
		NativeFieldInfoPtr_itemListID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "itemListID");
		NativeFieldInfoPtr_itemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "itemData");
		NativeFieldInfoPtr_itemIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "itemIconType");
		NativeFieldInfoPtr_tradeIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "tradeIconType");
		NativeFieldInfoPtr_updateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "updateTime");
		NativeFieldInfoPtr_PriceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "PriceColor");
		NativeFieldInfoPtr_ContributionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "ContributionColor");
		NativeFieldInfoPtr_BookContributionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "BookContributionColor");
		NativeFieldInfoPtr_GovernContributionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "GovernContributionColor");
		NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "inited");
		NativeFieldInfoPtr_hideItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "hideItemName");
		NativeFieldInfoPtr_hideItemBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "hideItemBox");
		NativeFieldInfoPtr_needRefreshPriceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "needRefreshPriceIcon");
		NativeFieldInfoPtr_fromStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, "fromStorage");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669399);
		NativeMethodInfoPtr_GetItemAreaSpeRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669400);
		NativeMethodInfoPtr_GetItemTreasureSpeRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669401);
		NativeMethodInfoPtr_GetHeroFavorValueRate_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669402);
		NativeMethodInfoPtr_GetItemPrice_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669403);
		NativeMethodInfoPtr_AutoSetName_Public_Void_ItemSortType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669404);
		NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669405);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr, 100669406);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198988, XrefRangeEnd = 199442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199442, XrefRangeEnd = 199451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetItemAreaSpeRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemAreaSpeRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 199485, RefRangeEnd = 199488, XrefRangeStart = 199451, XrefRangeEnd = 199485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetItemTreasureSpeRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemTreasureSpeRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199511, RefRangeEnd = 199512, XrefRangeStart = 199488, XrefRangeEnd = 199511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeroFavorValueRate(bool buy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&buy);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroFavorValueRate_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199557, RefRangeEnd = 199559, XrefRangeStart = 199512, XrefRangeEnd = 199557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemPrice(bool buy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&buy);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPrice_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 199648, RefRangeEnd = 199669, XrefRangeStart = 199559, XrefRangeEnd = 199648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoSetName(ItemSortType sortType = ItemSortType.ItemType, bool reverseOrder = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&sortType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &reverseOrder;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoSetName_Public_Void_ItemSortType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199669, XrefRangeEnd = 199684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemIconController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemIconController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemIconController(IntPtr pointer)
		: base(pointer)
	{
	}
}
