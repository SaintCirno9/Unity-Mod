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
public class ForceJobSettingDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minForceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxForceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobIDSetting;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int minForceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minForceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minForceLv)) = num;
		}
	}

	public unsafe int maxForceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForceLv)) = num;
		}
	}

	public unsafe List<ForceJobSettingIDDataBase> jobIDSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobIDSetting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceJobSettingIDDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobIDSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ForceJobSettingDataBase()
	{
		Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceJobSettingDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_minForceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr, "minForceLv");
		NativeFieldInfoPtr_maxForceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr, "maxForceLv");
		NativeFieldInfoPtr_jobIDSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr, "jobIDSetting");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr, 100667301);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123700, XrefRangeEnd = 123701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceJobSettingDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceJobSettingDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ForceJobSettingDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
