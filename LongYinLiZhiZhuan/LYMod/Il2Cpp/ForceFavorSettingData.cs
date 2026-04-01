using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ForceFavorSettingData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_forceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFavor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

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

	public unsafe float forceFavor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFavor)) = num;
		}
	}

	static ForceFavorSettingData()
	{
		Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceFavorSettingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr);
		NativeFieldInfoPtr_forceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr, "forceID");
		NativeFieldInfoPtr_forceFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr, "forceFavor");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr, 100667298);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 113338, RefRangeEnd = 113353, XrefRangeStart = 113338, XrefRangeEnd = 113353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceFavorSettingData(int _forceID, float _forceFavor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceFavorSettingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_forceID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceFavor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ForceFavorSettingData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
