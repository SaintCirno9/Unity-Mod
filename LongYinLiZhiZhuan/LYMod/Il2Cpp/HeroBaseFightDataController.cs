using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class HeroBaseFightDataController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_heroBaseFightData;

	private static readonly IntPtr NativeFieldInfoPtr_targetHero;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe HeroBaseFightData heroBaseFightData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBaseFightData);
			return *(HeroBaseFightData*)num;
		}
		set
		{
			*(HeroBaseFightData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroBaseFightData)) = heroBaseFightData;
		}
	}

	public unsafe HeroData targetHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHero);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHero)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroData));
		}
	}

	static HeroBaseFightDataController()
	{
		Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroBaseFightDataController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr);
		NativeFieldInfoPtr_heroBaseFightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr, "heroBaseFightData");
		NativeFieldInfoPtr_targetHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr, "targetHero");
		NativeMethodInfoPtr_RefreshData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr, 100669137);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr, 100669138);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 189278, RefRangeEnd = 189279, XrefRangeStart = 188880, XrefRangeEnd = 189278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroBaseFightDataController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroBaseFightDataController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HeroBaseFightDataController(IntPtr pointer)
		: base(pointer)
	{
	}
}
