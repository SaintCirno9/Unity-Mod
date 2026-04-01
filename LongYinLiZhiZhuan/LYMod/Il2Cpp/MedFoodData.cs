using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class MedFoodData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enhanceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeHeroState;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSpeAddValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraAddData;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeHeroStateData_Public_ChangeHeroStateData_0;

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

	public unsafe ChangeHeroStateData changeHeroState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeHeroState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeHeroStateData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeHeroState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changeHeroStateData));
		}
	}

	public unsafe int randomSpeAddValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSpeAddValue)) = num;
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

	static MedFoodData()
	{
		Il2CppClassPointerStore<MedFoodData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MedFoodData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr);
		NativeFieldInfoPtr_enhanceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, "enhanceLv");
		NativeFieldInfoPtr_changeHeroState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, "changeHeroState");
		NativeFieldInfoPtr_randomSpeAddValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, "randomSpeAddValue");
		NativeFieldInfoPtr_extraAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, "extraAddData");
		NativeMethodInfoPtr_GetChangeHeroStateData_Public_ChangeHeroStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, 100667996);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr, 100667997);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 143484, RefRangeEnd = 143530, XrefRangeStart = 143483, XrefRangeEnd = 143484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeHeroStateData GetChangeHeroStateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeHeroStateData_Public_ChangeHeroStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeHeroStateData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143541, RefRangeEnd = 143542, XrefRangeStart = 143530, XrefRangeEnd = 143541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MedFoodData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedFoodData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MedFoodData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
