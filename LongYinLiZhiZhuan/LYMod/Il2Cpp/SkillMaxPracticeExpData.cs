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
public class SkillMaxPracticeExpData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skillID;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPracticeExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxReadExp;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int skillID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID)) = num;
		}
	}

	public unsafe float maxPracticeExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPracticeExp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPracticeExp)) = num;
		}
	}

	public unsafe List<float> maxReadExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxReadExp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxReadExp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SkillMaxPracticeExpData()
	{
		Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillMaxPracticeExpData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr);
		NativeFieldInfoPtr_skillID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr, "skillID");
		NativeFieldInfoPtr_maxPracticeExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr, "maxPracticeExp");
		NativeFieldInfoPtr_maxReadExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr, "maxReadExp");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr, 100667410);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr, 100667411);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126325, RefRangeEnd = 126327, XrefRangeStart = 126303, XrefRangeEnd = 126325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillMaxPracticeExpData(int _skillID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillMaxPracticeExpData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_skillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126327, XrefRangeEnd = 126342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public SkillMaxPracticeExpData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
