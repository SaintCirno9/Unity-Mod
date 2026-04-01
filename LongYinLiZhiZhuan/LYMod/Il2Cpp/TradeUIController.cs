using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp;

public class TradeUIController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_TradeRightLabel;

	private static readonly IntPtr NativeFieldInfoPtr_tradeUIType;

	private static readonly IntPtr NativeFieldInfoPtr_forceItemListType;

	private static readonly IntPtr NativeFieldInfoPtr_useAreaItemPrice;

	private static readonly IntPtr NativeFieldInfoPtr_noSell;

	private static readonly IntPtr NativeFieldInfoPtr_tradeUI;

	private static readonly IntPtr NativeFieldInfoPtr_deltaMoney;

	private static readonly IntPtr NativeFieldInfoPtr_deltaWeight;

	private static readonly IntPtr NativeFieldInfoPtr_leftList;

	private static readonly IntPtr NativeFieldInfoPtr_leftOutList;

	private static readonly IntPtr NativeFieldInfoPtr_rightList;

	private static readonly IntPtr NativeFieldInfoPtr_rightOutList;

	private static readonly IntPtr NativeFieldInfoPtr_leftResourceLabel;

	private static readonly IntPtr NativeFieldInfoPtr_rightResourceLabel;

	private static readonly IntPtr NativeFieldInfoPtr_deltaResourceLabel;

	private static readonly IntPtr NativeFieldInfoPtr_leftWeightLabel;

	private static readonly IntPtr NativeFieldInfoPtr_rightWeightLabel;

	private static readonly IntPtr NativeFieldInfoPtr_deltaWeightLabel;

	private static readonly IntPtr NativeFieldInfoPtr_leftDiscount;

	private static readonly IntPtr NativeFieldInfoPtr_rightDiscount;

	private static readonly IntPtr NativeFieldInfoPtr_areaDiscount;

	private static readonly IntPtr NativeFieldInfoPtr_speDiscount;

	private static readonly IntPtr NativeFieldInfoPtr_minItemLv;

	private static readonly IntPtr NativeFieldInfoPtr_maxItemLv;

	private static readonly IntPtr NativeFieldInfoPtr_speSellValueRate;

	private static readonly IntPtr NativeFieldInfoPtr_speBuyValueRate;

	private static readonly IntPtr NativeFieldInfoPtr_discardItemList;

	private static readonly IntPtr NativeFieldInfoPtr_discard;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TradeUIController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FreshResourceLabel_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideTradeUI_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_Int32_Int32_Boolean_Boolean_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanSell_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanBuy_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SureButtonClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RealManageTrade_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CancelButtonClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TradeIconClicked_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static List<string> TradeRightLabel
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TradeRightLabel, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TradeRightLabel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TradeUIType tradeUIType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeUIType);
			return *(TradeUIType*)num;
		}
		set
		{
			*(TradeUIType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeUIType)) = tradeUIType;
		}
	}

	public unsafe ItemListType forceItemListType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceItemListType);
			return *(ItemListType*)num;
		}
		set
		{
			*(ItemListType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceItemListType)) = itemListType;
		}
	}

	public unsafe bool useAreaItemPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAreaItemPrice);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAreaItemPrice)) = flag;
		}
	}

	public unsafe bool noSell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSell)) = flag;
		}
	}

	public unsafe GameObject tradeUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeUI);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe int deltaMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaMoney)) = num;
		}
	}

	public unsafe float deltaWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaWeight)) = num;
		}
	}

	public unsafe ItemListController leftList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemListController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListController));
		}
	}

	public unsafe ItemListController leftOutList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftOutList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemListController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftOutList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListController));
		}
	}

	public unsafe ItemListController rightList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemListController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListController));
		}
	}

	public unsafe ItemListController rightOutList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightOutList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemListController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightOutList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListController));
		}
	}

	public unsafe Text leftResourceLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftResourceLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftResourceLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe Text rightResourceLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightResourceLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightResourceLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe Text deltaResourceLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaResourceLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaResourceLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe Text leftWeightLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWeightLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWeightLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe Text rightWeightLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightWeightLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightWeightLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe Text deltaWeightLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaWeightLabel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaWeightLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
		}
	}

	public unsafe GameObject leftDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftDiscount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftDiscount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject rightDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightDiscount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightDiscount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject areaDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDiscount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaDiscount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject speDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speDiscount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speDiscount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe int minItemLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minItemLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minItemLv)) = num;
		}
	}

	public unsafe int maxItemLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxItemLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxItemLv)) = num;
		}
	}

	public unsafe float speSellValueRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSellValueRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSellValueRate)) = num;
		}
	}

	public unsafe float speBuyValueRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuyValueRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speBuyValueRate)) = num;
		}
	}

	public unsafe ItemListData discardItemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardItemList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardItemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe bool discard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discard)) = flag;
		}
	}

	public unsafe static TradeUIController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TradeUIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tradeUIController));
		}
	}

	public unsafe static TradeUIController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338201, XrefRangeEnd = 338205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_TradeUIController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TradeUIController>(intPtr) : null;
		}
	}

	static TradeUIController()
	{
		Il2CppClassPointerStore<TradeUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TradeUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr);
		NativeFieldInfoPtr_TradeRightLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "TradeRightLabel");
		NativeFieldInfoPtr_tradeUIType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "tradeUIType");
		NativeFieldInfoPtr_forceItemListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "forceItemListType");
		NativeFieldInfoPtr_useAreaItemPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "useAreaItemPrice");
		NativeFieldInfoPtr_noSell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "noSell");
		NativeFieldInfoPtr_tradeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "tradeUI");
		NativeFieldInfoPtr_deltaMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "deltaMoney");
		NativeFieldInfoPtr_deltaWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "deltaWeight");
		NativeFieldInfoPtr_leftList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "leftList");
		NativeFieldInfoPtr_leftOutList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "leftOutList");
		NativeFieldInfoPtr_rightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "rightList");
		NativeFieldInfoPtr_rightOutList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "rightOutList");
		NativeFieldInfoPtr_leftResourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "leftResourceLabel");
		NativeFieldInfoPtr_rightResourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "rightResourceLabel");
		NativeFieldInfoPtr_deltaResourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "deltaResourceLabel");
		NativeFieldInfoPtr_leftWeightLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "leftWeightLabel");
		NativeFieldInfoPtr_rightWeightLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "rightWeightLabel");
		NativeFieldInfoPtr_deltaWeightLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "deltaWeightLabel");
		NativeFieldInfoPtr_leftDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "leftDiscount");
		NativeFieldInfoPtr_rightDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "rightDiscount");
		NativeFieldInfoPtr_areaDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "areaDiscount");
		NativeFieldInfoPtr_speDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "speDiscount");
		NativeFieldInfoPtr_minItemLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "minItemLv");
		NativeFieldInfoPtr_maxItemLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "maxItemLv");
		NativeFieldInfoPtr_speSellValueRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "speSellValueRate");
		NativeFieldInfoPtr_speBuyValueRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "speBuyValueRate");
		NativeFieldInfoPtr_discardItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "discardItemList");
		NativeFieldInfoPtr_discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "discard");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_TradeUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671964);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671965);
		NativeMethodInfoPtr_FreshResourceLabel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671966);
		NativeMethodInfoPtr_HideTradeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671967);
		NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671968);
		NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671969);
		NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671970);
		NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_Int32_Int32_Boolean_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671971);
		NativeMethodInfoPtr_CanSell_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671972);
		NativeMethodInfoPtr_CanBuy_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671973);
		NativeMethodInfoPtr_SureButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671974);
		NativeMethodInfoPtr_RealManageTrade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671975);
		NativeMethodInfoPtr_CancelButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671976);
		NativeMethodInfoPtr_TradeIconClicked_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671977);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr, 100671978);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338205, XrefRangeEnd = 338210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 338468, RefRangeEnd = 338472, XrefRangeStart = 338210, XrefRangeEnd = 338468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreshResourceLabel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreshResourceLabel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338472, XrefRangeEnd = 338517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideTradeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideTradeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 338518, RefRangeEnd = 338526, XrefRangeStart = 338517, XrefRangeEnd = 338518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTradeUI(TradeUIType targetType, ItemListData leftItemList, ItemListData rightItemList, bool _useAreaItemPrice = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&targetType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftItemList);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightItemList);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &_useAreaItemPrice;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 338527, RefRangeEnd = 338528, XrefRangeStart = 338526, XrefRangeEnd = 338527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTradeUI(TradeUIType targetType, ItemListType targetItemListType, ItemListData leftItemList, ItemListData rightItemList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&targetType);
		*(ItemListType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &targetItemListType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftItemList);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightItemList);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 338529, RefRangeEnd = 338530, XrefRangeStart = 338528, XrefRangeEnd = 338529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTradeUI(TradeUIType targetType, ItemListData leftItemList, ItemListData rightItemList, int _minItemLv, int _maxItemLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&targetType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftItemList);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightItemList);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &_minItemLv;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &_maxItemLv;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListData_ItemListData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 338689, RefRangeEnd = 338695, XrefRangeStart = 338530, XrefRangeEnd = 338689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTradeUI(TradeUIType targetType, ItemListType targetItemListType, ItemListData leftItemList, ItemListData rightItemList, int _minItemLv, int _maxItemLv, bool _useAreaItemPrice = false, bool _noSell = false, float _speSellValueRate = 1f, float _speBuyValueRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[10];
		*ptr = (nint)(&targetType);
		*(ItemListType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &targetItemListType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftItemList);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightItemList);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &_minItemLv;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &_maxItemLv;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &_useAreaItemPrice;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &_noSell;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &_speSellValueRate;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &_speBuyValueRate;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTradeUI_Public_Void_TradeUIType_ItemListType_ItemListData_ItemListData_Int32_Int32_Boolean_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool CanSell()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSell_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CanBuy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBuy_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338695, XrefRangeEnd = 338719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SureButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SureButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338719, XrefRangeEnd = 338868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RealManageTrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RealManageTrade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 338892, RefRangeEnd = 338893, XrefRangeStart = 338868, XrefRangeEnd = 338892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338893, XrefRangeEnd = 338925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TradeIconClicked(GameObject iconClicked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconClicked);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TradeIconClicked_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TradeUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradeUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TradeUIController(IntPtr pointer)
		: base(pointer)
	{
	}
}
