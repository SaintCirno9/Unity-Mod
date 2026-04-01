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
public class InvGameItem : Il2CppSystem.Object
{
	[OriginalName("Assembly-CSharp.dll", "", "Quality")]
	public enum Quality
	{
		Broken,
		Cursed,
		Damaged,
		Worn,
		Sturdy,
		Polished,
		Improved,
		Crafted,
		Superior,
		Enchanted,
		Epic,
		Legendary,
		_LastDoNotUse
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mBaseItemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBaseItem;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseItemID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseItem_Public_get_InvBaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_statMultiplier_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_InvBaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateStats_Public_List_1_InvStat_0;

	public unsafe int mBaseItemID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBaseItemID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBaseItemID)) = num;
		}
	}

	public unsafe Quality quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quality);
			return *(Quality*)num;
		}
		set
		{
			*(Quality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quality)) = quality;
		}
	}

	public unsafe int itemLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLevel)) = num;
		}
	}

	public unsafe InvBaseItem mBaseItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBaseItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InvBaseItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBaseItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)invBaseItem));
		}
	}

	public unsafe int baseItemID
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43750, RefRangeEnd = 43753, XrefRangeStart = 43750, XrefRangeEnd = 43750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseItemID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe InvBaseItem baseItem
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 43758, RefRangeEnd = 43773, XrefRangeStart = 43753, XrefRangeEnd = 43758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseItem_Public_get_InvBaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InvBaseItem>(intPtr) : null;
		}
	}

	public unsafe string name
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43782, RefRangeEnd = 43784, XrefRangeStart = 43773, XrefRangeEnd = 43782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe float statMultiplier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43784, XrefRangeEnd = 43795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_statMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Color color
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43797, RefRangeEnd = 43799, XrefRangeStart = 43795, XrefRangeEnd = 43797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static InvGameItem()
	{
		Il2CppClassPointerStore<InvGameItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InvGameItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr);
		NativeFieldInfoPtr_mBaseItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, "mBaseItemID");
		NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, "quality");
		NativeFieldInfoPtr_itemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, "itemLevel");
		NativeFieldInfoPtr_mBaseItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, "mBaseItem");
		NativeMethodInfoPtr_get_baseItemID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_baseItem_Public_get_InvBaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_statMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_InvBaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_CalculateStats_Public_List_1_InvStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr, 100663357);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43799, XrefRangeEnd = 43800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem(int id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43802, RefRangeEnd = 43804, XrefRangeStart = 43800, XrefRangeEnd = 43802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem(int id, InvBaseItem bi)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvGameItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bi);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_InvBaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43847, RefRangeEnd = 43848, XrefRangeStart = 43804, XrefRangeEnd = 43847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<InvStat> CalculateStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateStats_Public_List_1_InvStat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InvStat>>(intPtr) : null;
	}

	public InvGameItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
