using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class MeditationData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lv;

	private static readonly System.IntPtr NativeFieldInfoPtr_exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthMeditationDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_meditationTreasure;

	private static readonly System.IntPtr NativeFieldInfoPtr_treasureAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_treasureLeftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_meditationFood;

	private static readonly System.IntPtr NativeFieldInfoPtr_foodAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_foodLeftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_meditationMed;

	private static readonly System.IntPtr NativeFieldInfoPtr_medAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_medLeftTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxExp_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeditationExpNum_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeditationExpRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemExpNum_Public_Single_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemExpRate_Public_Single_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeExp_Public_Void_Single_Boolean_0;

	public unsafe int lv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv)) = num;
		}
	}

	public unsafe float exp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp)) = num;
		}
	}

	public unsafe int monthMeditationDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthMeditationDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthMeditationDay)) = num;
		}
	}

	public unsafe ItemData meditationTreasure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationTreasure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationTreasure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe HeroSpeAddData treasureAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe int treasureLeftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLeftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLeftTime)) = num;
		}
	}

	public unsafe ItemData meditationFood
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationFood);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationFood)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe HeroSpeAddData foodAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe int foodLeftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodLeftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodLeftTime)) = num;
		}
	}

	public unsafe ItemData meditationMed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationMed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationMed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe HeroSpeAddData medAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe int medLeftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medLeftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medLeftTime)) = num;
		}
	}

	static MeditationData()
	{
		Il2CppClassPointerStore<MeditationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeditationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeditationData>.NativeClassPtr);
		NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "lv");
		NativeFieldInfoPtr_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "exp");
		NativeFieldInfoPtr_monthMeditationDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "monthMeditationDay");
		NativeFieldInfoPtr_meditationTreasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "meditationTreasure");
		NativeFieldInfoPtr_treasureAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "treasureAddData");
		NativeFieldInfoPtr_treasureLeftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "treasureLeftTime");
		NativeFieldInfoPtr_meditationFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "meditationFood");
		NativeFieldInfoPtr_foodAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "foodAddData");
		NativeFieldInfoPtr_foodLeftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "foodLeftTime");
		NativeFieldInfoPtr_meditationMed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "meditationMed");
		NativeFieldInfoPtr_medAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "medAddData");
		NativeFieldInfoPtr_medLeftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, "medLeftTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667031);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667032);
		NativeMethodInfoPtr_GetMaxExp_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667033);
		NativeMethodInfoPtr_MeditationExpNum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667034);
		NativeMethodInfoPtr_MeditationExpRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667035);
		NativeMethodInfoPtr_GetItemExpNum_Public_Single_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667036);
		NativeMethodInfoPtr_GetItemExpRate_Public_Single_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667037);
		NativeMethodInfoPtr_ChangeExp_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationData>.NativeClassPtr, 100667038);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113813, RefRangeEnd = 113814, XrefRangeStart = 113799, XrefRangeEnd = 113813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeditationData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeditationData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113830, RefRangeEnd = 113831, XrefRangeStart = 113814, XrefRangeEnd = 113830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetMaxExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxExp_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113838, RefRangeEnd = 113839, XrefRangeStart = 113831, XrefRangeEnd = 113838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MeditationExpNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeditationExpNum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 113850, RefRangeEnd = 113853, XrefRangeStart = 113839, XrefRangeEnd = 113850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MeditationExpRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeditationExpRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetItemExpNum(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemExpNum_Public_Single_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetItemExpRate(ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemExpRate_Public_Single_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113911, RefRangeEnd = 113915, XrefRangeStart = 113853, XrefRangeEnd = 113911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeExp(float _exp, bool showInfo = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_exp);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeExp_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MeditationData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
