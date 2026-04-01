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
public class ForceJobSettingData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_emptyNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceJobs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveHero_Public_Boolean_HeroData_0;

	public unsafe int emptyNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyNum)) = num;
		}
	}

	public unsafe List<List<int>> ForceJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ForceJobSettingData()
	{
		Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceJobSettingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr);
		NativeFieldInfoPtr_emptyNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr, "emptyNum");
		NativeFieldInfoPtr_ForceJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr, "ForceJobs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr, 100667299);
		NativeMethodInfoPtr_HaveHero_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr, 100667300);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123691, RefRangeEnd = 123692, XrefRangeStart = 123622, XrefRangeEnd = 123691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceJobSettingData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceJobSettingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123699, RefRangeEnd = 123700, XrefRangeStart = 123692, XrefRangeEnd = 123699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveHero(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveHero_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ForceJobSettingData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
