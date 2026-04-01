using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class RePlayerPrefData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PlayerPrefDictionary playerPrefData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrefData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPrefDictionary>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrefData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerPrefDictionary));
		}
	}

	static RePlayerPrefData()
	{
		Il2CppClassPointerStore<RePlayerPrefData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RePlayerPrefData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RePlayerPrefData>.NativeClassPtr);
		NativeFieldInfoPtr_playerPrefData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RePlayerPrefData>.NativeClassPtr, "playerPrefData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RePlayerPrefData>.NativeClassPtr, 100666979);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113153, RefRangeEnd = 113154, XrefRangeStart = 113147, XrefRangeEnd = 113153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RePlayerPrefData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RePlayerPrefData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RePlayerPrefData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
