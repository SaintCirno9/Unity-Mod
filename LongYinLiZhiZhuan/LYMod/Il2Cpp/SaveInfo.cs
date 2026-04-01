using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SaveInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SaveVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_SaveDetail;

	private static readonly System.IntPtr NativeFieldInfoPtr_SaveTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

	public unsafe string SaveVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SaveDetail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveDetail);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveDetail)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SaveTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveTime);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveTime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SaveInfo()
	{
		Il2CppClassPointerStore<SaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SaveInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr);
		NativeFieldInfoPtr_SaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveVersion");
		NativeFieldInfoPtr_SaveDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveDetail");
		NativeFieldInfoPtr_SaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100666965);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100666966);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 112924, RefRangeEnd = 112928, XrefRangeStart = 112920, XrefRangeEnd = 112924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveInfo(string _SaveVersion, string _SaveDetail, string _SaveTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_SaveVersion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_SaveDetail);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_SaveTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
