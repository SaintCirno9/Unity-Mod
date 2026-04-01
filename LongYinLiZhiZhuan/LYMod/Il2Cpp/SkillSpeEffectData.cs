using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SkillSpeEffectData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_speName;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfSpe;

	private static readonly System.IntPtr NativeFieldInfoPtr_speEffectTargetType;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_SkillSpeEffectTargetType_SkillSpeEffectTriggerType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string speName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool selfSpe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfSpe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfSpe)) = flag;
		}
	}

	public unsafe SkillSpeEffectTargetType speEffectTargetType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEffectTargetType);
			return *(SkillSpeEffectTargetType*)num;
		}
		set
		{
			*(SkillSpeEffectTargetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEffectTargetType)) = skillSpeEffectTargetType;
		}
	}

	public unsafe SkillSpeEffectTriggerType triggerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerType);
			return *(SkillSpeEffectTriggerType*)num;
		}
		set
		{
			*(SkillSpeEffectTriggerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerType)) = skillSpeEffectTriggerType;
		}
	}

	static SkillSpeEffectData()
	{
		Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillSpeEffectData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr);
		NativeFieldInfoPtr_speName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, "speName");
		NativeFieldInfoPtr_selfSpe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, "selfSpe");
		NativeFieldInfoPtr_speEffectTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, "speEffectTargetType");
		NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, "triggerType");
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_SkillSpeEffectTargetType_SkillSpeEffectTriggerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, 100667912);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr, 100667913);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141600, XrefRangeStart = 141596, XrefRangeEnd = 141598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillSpeEffectData(string _speName, bool _selfSpe, SkillSpeEffectTargetType _speEffectTargetType, SkillSpeEffectTriggerType _triggerType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillSpeEffectData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_speName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_selfSpe;
		*(SkillSpeEffectTargetType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_speEffectTargetType;
		*(SkillSpeEffectTriggerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_triggerType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_SkillSpeEffectTargetType_SkillSpeEffectTriggerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141600, XrefRangeEnd = 141615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public SkillSpeEffectData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
