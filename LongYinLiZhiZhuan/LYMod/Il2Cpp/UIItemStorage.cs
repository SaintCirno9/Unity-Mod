using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class UIItemStorage : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_maxItemCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxRows;

	private static readonly IntPtr NativeFieldInfoPtr_maxColumns;

	private static readonly IntPtr NativeFieldInfoPtr_template;

	private static readonly IntPtr NativeFieldInfoPtr_background;

	private static readonly IntPtr NativeFieldInfoPtr_spacing;

	private static readonly IntPtr NativeFieldInfoPtr_padding;

	private static readonly IntPtr NativeFieldInfoPtr_mItems;

	private static readonly IntPtr NativeMethodInfoPtr_get_items_Public_get_List_1_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_InvGameItem_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_InvGameItem_Int32_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int maxItemCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxItemCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxItemCount)) = num;
		}
	}

	public unsafe int maxRows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRows);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRows)) = num;
		}
	}

	public unsafe int maxColumns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxColumns);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxColumns)) = num;
		}
	}

	public unsafe GameObject template
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe UIWidget background
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIWidget>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIWidget));
		}
	}

	public unsafe int spacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing)) = num;
		}
	}

	public unsafe int padding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_padding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_padding)) = num;
		}
	}

	public unsafe List<InvGameItem> mItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InvGameItem>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InvGameItem> items
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43507, RefRangeEnd = 43508, XrefRangeStart = 43502, XrefRangeEnd = 43507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_items_Public_get_List_1_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InvGameItem>>(intPtr) : null;
		}
	}

	static UIItemStorage()
	{
		Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIItemStorage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr);
		NativeFieldInfoPtr_maxItemCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "maxItemCount");
		NativeFieldInfoPtr_maxRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "maxRows");
		NativeFieldInfoPtr_maxColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "maxColumns");
		NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "template");
		NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "background");
		NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "spacing");
		NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "padding");
		NativeFieldInfoPtr_mItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, "mItems");
		NativeMethodInfoPtr_get_items_Public_get_List_1_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_GetItem_Public_InvGameItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_Replace_Public_InvGameItem_Int32_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr, 100663324);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43512, RefRangeEnd = 43513, XrefRangeStart = 43508, XrefRangeEnd = 43512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem GetItem(int slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_InvGameItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43515, RefRangeEnd = 43516, XrefRangeStart = 43513, XrefRangeEnd = 43515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem Replace(int slot, InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&slot);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_InvGameItem_Int32_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43516, XrefRangeEnd = 43541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43541, XrefRangeEnd = 43549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIItemStorage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIItemStorage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIItemStorage(IntPtr pointer)
		: base(pointer)
	{
	}
}
