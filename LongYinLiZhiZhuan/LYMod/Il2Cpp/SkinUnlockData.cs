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
public class SkinUnlockData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinLvUnlocked;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0;

	public unsafe int skinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID)) = num;
		}
	}

	public unsafe List<bool> skinLvUnlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinLvUnlocked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinLvUnlocked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SkinUnlockData()
	{
		Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkinUnlockData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr);
		NativeFieldInfoPtr_skinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr, "skinID");
		NativeFieldInfoPtr_skinLvUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr, "skinLvUnlocked");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr, 100667012);
		NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr, 100667013);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113548, RefRangeEnd = 113550, XrefRangeStart = 113526, XrefRangeEnd = 113548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinUnlockData(int _skinID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinUnlockData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_skinID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113561, RefRangeEnd = 113562, XrefRangeStart = 113550, XrefRangeEnd = 113561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_skinLv);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeLine;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public SkinUnlockData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
