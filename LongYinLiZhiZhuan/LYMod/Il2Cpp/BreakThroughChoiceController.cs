using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class BreakThroughChoiceController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_iconSprites;

	private static readonly IntPtr NativeFieldInfoPtr_rareLv;

	private static readonly IntPtr NativeFieldInfoPtr_extraAddData;

	private static readonly IntPtr NativeFieldInfoPtr_injuryType;

	private static readonly IntPtr NativeFieldInfoPtr_injuryCost;

	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<Sprite> iconSprites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSprites);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSprites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int rareLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv)) = num;
		}
	}

	public unsafe HeroSpeAddData extraAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe int injuryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryType)) = num;
		}
	}

	public unsafe int injuryCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryCost)) = num;
		}
	}

	static BreakThroughChoiceController()
	{
		Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BreakThroughChoiceController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr);
		NativeFieldInfoPtr_iconSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, "iconSprites");
		NativeFieldInfoPtr_rareLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, "rareLv");
		NativeFieldInfoPtr_extraAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, "extraAddData");
		NativeFieldInfoPtr_injuryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, "injuryType");
		NativeFieldInfoPtr_injuryCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, "injuryCost");
		NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, 100666710);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr, 100666711);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103561, XrefRangeEnd = 103565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103565, XrefRangeEnd = 103571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BreakThroughChoiceController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BreakThroughChoiceController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BreakThroughChoiceController(IntPtr pointer)
		: base(pointer)
	{
	}
}
