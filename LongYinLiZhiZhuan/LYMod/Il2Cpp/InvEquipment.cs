using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class InvEquipment : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_mItems;

	private static readonly IntPtr NativeFieldInfoPtr_mAttachments;

	private static readonly IntPtr NativeMethodInfoPtr_get_equippedItems_Public_get_Il2CppReferenceArray_1_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_InvGameItem_Slot_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_InvGameItem_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_InvGameItem_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_InvGameItem_Slot_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasEquipped_Public_Boolean_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasEquipped_Public_Boolean_Slot_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_InvGameItem_Slot_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<InvGameItem> mItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvGameItem>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<InvAttachmentPoint> mAttachments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAttachments);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvAttachmentPoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAttachments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<InvGameItem> equippedItems
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 43697, RefRangeEnd = 43706, XrefRangeStart = 43697, XrefRangeEnd = 43697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_equippedItems_Public_get_Il2CppReferenceArray_1_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvGameItem>>(intPtr) : null;
		}
	}

	static InvEquipment()
	{
		Il2CppClassPointerStore<InvEquipment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InvEquipment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr);
		NativeFieldInfoPtr_mItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, "mItems");
		NativeFieldInfoPtr_mAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, "mAttachments");
		NativeMethodInfoPtr_get_equippedItems_Public_get_Il2CppReferenceArray_1_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_Replace_Public_InvGameItem_Slot_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_Equip_Public_InvGameItem_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_Unequip_Public_InvGameItem_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_Unequip_Public_InvGameItem_Slot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_HasEquipped_Public_Boolean_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_HasEquipped_Public_Boolean_Slot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_GetItem_Public_InvGameItem_Slot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr, 100663349);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43731, RefRangeEnd = 43734, XrefRangeStart = 43706, XrefRangeEnd = 43731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&slot);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_InvGameItem_Slot_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43743, RefRangeEnd = 43745, XrefRangeStart = 43734, XrefRangeEnd = 43743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem Equip(InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equip_Public_InvGameItem_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43745, XrefRangeEnd = 43747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem Unequip(InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unequip_Public_InvGameItem_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43747, XrefRangeEnd = 43748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem Unequip(InvBaseItem.Slot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unequip_Public_InvGameItem_Slot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool HasEquipped(InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEquipped_Public_Boolean_InvGameItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43748, XrefRangeEnd = 43749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasEquipped(InvBaseItem.Slot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEquipped_Public_Boolean_Slot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43749, RefRangeEnd = 43750, XrefRangeStart = 43749, XrefRangeEnd = 43749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_InvGameItem_Slot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvEquipment()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvEquipment>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InvEquipment(IntPtr pointer)
		: base(pointer)
	{
	}
}
