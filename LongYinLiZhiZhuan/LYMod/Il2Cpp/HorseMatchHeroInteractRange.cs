using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class HorseMatchHeroInteractRange : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_targetHorseHero;

	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Public_Void_Collider_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe HorseMatchHeroController targetHorseHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHorseHero);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HorseMatchHeroController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHorseHero)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)horseMatchHeroController));
		}
	}

	static HorseMatchHeroInteractRange()
	{
		Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HorseMatchHeroInteractRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr);
		NativeFieldInfoPtr_targetHorseHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr, "targetHorseHero");
		NativeMethodInfoPtr_OnTriggerStay_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr, 100669332);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr, 100669333);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196867, XrefRangeEnd = 196870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTriggerStay(Collider other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTriggerStay_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorseMatchHeroInteractRange()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorseMatchHeroInteractRange>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HorseMatchHeroInteractRange(IntPtr pointer)
		: base(pointer)
	{
	}
}
