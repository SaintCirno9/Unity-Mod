using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp;

public class UIStorageSlot : UIItemSlot
{
	private static readonly IntPtr NativeFieldInfoPtr_storage;

	private static readonly IntPtr NativeFieldInfoPtr_slot;

	private static readonly IntPtr NativeMethodInfoPtr_get_observedItem_Protected_Virtual_get_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_Replace_Protected_Virtual_InvGameItem_InvGameItem_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UIItemStorage storage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIItemStorage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIItemStorage));
		}
	}

	public unsafe int slot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot)) = num;
		}
	}

	public unsafe override InvGameItem observedItem
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43549, XrefRangeEnd = 43554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_observedItem_Protected_Virtual_get_InvGameItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
		}
	}

	static UIStorageSlot()
	{
		Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIStorageSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr);
		NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr, "storage");
		NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr, "slot");
		NativeMethodInfoPtr_get_observedItem_Protected_Virtual_get_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_Replace_Protected_Virtual_InvGameItem_InvGameItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr, 100663327);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43554, XrefRangeEnd = 43559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override InvGameItem Replace(InvGameItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Replace_Protected_Virtual_InvGameItem_InvGameItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvGameItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43559, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIStorageSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIStorageSlot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIStorageSlot(IntPtr pointer)
		: base(pointer)
	{
	}
}
