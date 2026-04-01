using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class UIWidgetContainer : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static UIWidgetContainer()
	{
		Il2CppClassPointerStore<UIWidgetContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIWidgetContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIWidgetContainer>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIWidgetContainer>.NativeClassPtr, 100663956);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIWidgetContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIWidgetContainer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIWidgetContainer(IntPtr pointer)
		: base(pointer)
	{
	}
}
