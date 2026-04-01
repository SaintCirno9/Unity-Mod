using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class MaterialData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_extraAddData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	static MaterialData()
	{
		Il2CppClassPointerStore<MaterialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialData>.NativeClassPtr);
		NativeFieldInfoPtr_extraAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "extraAddData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, 100668003);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143750, RefRangeEnd = 143751, XrefRangeStart = 143744, XrefRangeEnd = 143750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
