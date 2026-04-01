using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class PrisonData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_guardAlert;

	private static readonly System.IntPtr NativeFieldInfoPtr_guardFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_prisonItemKeep;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyGuardCd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float guardAlert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardAlert);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardAlert)) = num;
		}
	}

	public unsafe float guardFavor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardFavor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardFavor)) = num;
		}
	}

	public unsafe ItemListData prisonItemKeep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prisonItemKeep);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prisonItemKeep)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe float buyGuardCd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGuardCd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGuardCd)) = num;
		}
	}

	static PrisonData()
	{
		Il2CppClassPointerStore<PrisonData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PrisonData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonData>.NativeClassPtr);
		NativeFieldInfoPtr_guardAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonData>.NativeClassPtr, "guardAlert");
		NativeFieldInfoPtr_guardFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonData>.NativeClassPtr, "guardFavor");
		NativeFieldInfoPtr_prisonItemKeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonData>.NativeClassPtr, "prisonItemKeep");
		NativeFieldInfoPtr_buyGuardCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonData>.NativeClassPtr, "buyGuardCd");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonData>.NativeClassPtr, 100667017);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113612, XrefRangeEnd = 113618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrisonData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PrisonData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
