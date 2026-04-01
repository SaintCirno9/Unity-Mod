using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SkillDamageRangeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rangeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRange;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe DamageRangeType rangeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeType);
			return *(DamageRangeType*)num;
		}
		set
		{
			*(DamageRangeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeType)) = damageRangeType;
		}
	}

	public unsafe int minRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRange)) = num;
		}
	}

	public unsafe int maxRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRange)) = num;
		}
	}

	static SkillDamageRangeData()
	{
		Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillDamageRangeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr);
		NativeFieldInfoPtr_rangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr, "rangeType");
		NativeFieldInfoPtr_minRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr, "minRange");
		NativeFieldInfoPtr_maxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr, "maxRange");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr, 100667935);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr, 100667936);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 113387, RefRangeEnd = 113414, XrefRangeStart = 113387, XrefRangeEnd = 113414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillDamageRangeData(int type, int min, int max)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillDamageRangeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141812, XrefRangeEnd = 141827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public SkillDamageRangeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
