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
public class ChangeHeroStateData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxhp;

	private static readonly System.IntPtr NativeFieldInfoPtr_mana;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMana;

	private static readonly System.IntPtr NativeFieldInfoPtr_power;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeAttri;

	private static readonly System.IntPtr NativeFieldInfoPtr_charm;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffData;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ChangeHeroStateData_ChangeHeroStateData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxChangeMaxHp_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxChangeMaxMp_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe float hp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp)) = num;
		}
	}

	public unsafe float maxhp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxhp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxhp)) = num;
		}
	}

	public unsafe float mana
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mana);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mana)) = num;
		}
	}

	public unsafe float maxMana
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMana);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMana)) = num;
		}
	}

	public unsafe float power
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power)) = num;
		}
	}

	public unsafe float maxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower)) = num;
		}
	}

	public unsafe float externalInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalInjury)) = num;
		}
	}

	public unsafe float internalInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalInjury)) = num;
		}
	}

	public unsafe float poisonInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonInjury);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonInjury)) = num;
		}
	}

	public unsafe List<int> changeAttri
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAttri);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeAttri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float charm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charm)) = num;
		}
	}

	public unsafe HeroSpeAddData buffData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	static ChangeHeroStateData()
	{
		Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChangeHeroStateData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr);
		NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "hp");
		NativeFieldInfoPtr_maxhp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "maxhp");
		NativeFieldInfoPtr_mana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "mana");
		NativeFieldInfoPtr_maxMana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "maxMana");
		NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "power");
		NativeFieldInfoPtr_maxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "maxPower");
		NativeFieldInfoPtr_externalInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "externalInjury");
		NativeFieldInfoPtr_internalInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "internalInjury");
		NativeFieldInfoPtr_poisonInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "poisonInjury");
		NativeFieldInfoPtr_changeAttri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "changeAttri");
		NativeFieldInfoPtr_charm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "charm");
		NativeFieldInfoPtr_buffData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, "buffData");
		NativeMethodInfoPtr_op_Multiply_Public_Static_ChangeHeroStateData_ChangeHeroStateData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667950);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667951);
		NativeMethodInfoPtr_GetMaxChangeMaxHp_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667952);
		NativeMethodInfoPtr_GetMaxChangeMaxMp_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667953);
		NativeMethodInfoPtr_GetDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667954);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr, 100667955);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142127, RefRangeEnd = 142130, XrefRangeStart = 142124, XrefRangeEnd = 142127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ChangeHeroStateData operator *(ChangeHeroStateData a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_ChangeHeroStateData_ChangeHeroStateData_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeHeroStateData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142143, RefRangeEnd = 142144, XrefRangeStart = 142130, XrefRangeEnd = 142143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeHeroStateData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeHeroStateData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142144, RefRangeEnd = 142147, XrefRangeStart = 142144, XrefRangeEnd = 142144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxChangeMaxHp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxChangeMaxHp_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142147, RefRangeEnd = 142150, XrefRangeStart = 142147, XrefRangeEnd = 142147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxChangeMaxMp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxChangeMaxMp_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142232, RefRangeEnd = 142233, XrefRangeStart = 142150, XrefRangeEnd = 142232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142250, RefRangeEnd = 142251, XrefRangeStart = 142233, XrefRangeEnd = 142250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ChangeHeroStateData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
