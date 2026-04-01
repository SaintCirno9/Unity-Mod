using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class EquipmentData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enhanceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_littleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_attriType;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_equiped;

	private static readonly System.IntPtr NativeFieldInfoPtr_animName;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipPoisonData;

	private static readonly System.IntPtr NativeFieldInfoPtr_speEnhanceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_speWeightLv;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseAddData_Public_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraAddName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int enhanceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enhanceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enhanceLv)) = num;
		}
	}

	public unsafe int littleType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_littleType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_littleType)) = num;
		}
	}

	public unsafe int attriType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attriType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attriType)) = num;
		}
	}

	public unsafe HeroSpeAddData baseAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe HeroSpeAddData extraAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe bool equiped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped)) = flag;
		}
	}

	public unsafe string animName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe EquipPoisonData equipPoisonData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipPoisonData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EquipPoisonData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipPoisonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipPoisonData));
		}
	}

	public unsafe int speEnhanceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEnhanceLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEnhanceLv)) = num;
		}
	}

	public unsafe int speWeightLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speWeightLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speWeightLv)) = num;
		}
	}

	static EquipmentData()
	{
		Il2CppClassPointerStore<EquipmentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EquipmentData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr);
		NativeFieldInfoPtr_enhanceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "enhanceLv");
		NativeFieldInfoPtr_littleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "littleType");
		NativeFieldInfoPtr_attriType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "attriType");
		NativeFieldInfoPtr_baseAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "baseAddData");
		NativeFieldInfoPtr_extraAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "extraAddData");
		NativeFieldInfoPtr_equiped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "equiped");
		NativeFieldInfoPtr_animName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "animName");
		NativeFieldInfoPtr_equipPoisonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "equipPoisonData");
		NativeFieldInfoPtr_speEnhanceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "speEnhanceLv");
		NativeFieldInfoPtr_speWeightLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, "speWeightLv");
		NativeMethodInfoPtr_GetBaseAddData_Public_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, 100667993);
		NativeMethodInfoPtr_GetExtraAddName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, 100667994);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr, 100667995);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 143416, RefRangeEnd = 143422, XrefRangeStart = 143415, XrefRangeEnd = 143416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData GetBaseAddData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseAddData_Public_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143461, RefRangeEnd = 143462, XrefRangeStart = 143422, XrefRangeEnd = 143461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetExtraAddName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraAddName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143482, RefRangeEnd = 143483, XrefRangeStart = 143462, XrefRangeEnd = 143482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipmentData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipmentData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EquipmentData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
