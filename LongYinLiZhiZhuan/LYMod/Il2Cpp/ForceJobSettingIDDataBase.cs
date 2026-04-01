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
public class ForceJobSettingIDDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_jobName;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectForceSpeAdd;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectSkillText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string jobName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string jobDescribe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDescribe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDescribe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<LivingSkillType> effectSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LivingSkillType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ForceSpeAddDataType> effectForceSpeAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectForceSpeAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceSpeAddDataType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectForceSpeAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ForceJobSettingIDDataBase()
	{
		Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceJobSettingIDDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_jobName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, "jobName");
		NativeFieldInfoPtr_jobDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, "jobDescribe");
		NativeFieldInfoPtr_effectSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, "effectSkill");
		NativeFieldInfoPtr_effectForceSpeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, "effectForceSpeAdd");
		NativeMethodInfoPtr_GetEffectSkillText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, 100667302);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr, 100667303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123701, XrefRangeEnd = 123721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEffectSkillText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEffectSkillText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceJobSettingIDDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceJobSettingIDDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ForceJobSettingIDDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
