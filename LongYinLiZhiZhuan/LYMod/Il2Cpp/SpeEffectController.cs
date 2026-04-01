using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class SpeEffectController : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_SmoothStart_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SmoothEnd_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SpeEffectController()
	{
		Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpeEffectController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr);
		NativeMethodInfoPtr_SmoothStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr, 100671535);
		NativeMethodInfoPtr_SmoothEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr, 100671536);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr, 100671537);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 328112, RefRangeEnd = 328113, XrefRangeStart = 328101, XrefRangeEnd = 328112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 328124, RefRangeEnd = 328125, XrefRangeStart = 328113, XrefRangeEnd = 328124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpeEffectController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeEffectController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SpeEffectController(IntPtr pointer)
		: base(pointer)
	{
	}
}
