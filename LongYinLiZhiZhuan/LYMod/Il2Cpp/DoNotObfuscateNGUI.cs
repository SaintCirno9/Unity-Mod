using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class DoNotObfuscateNGUI : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DoNotObfuscateNGUI()
	{
		Il2CppClassPointerStore<DoNotObfuscateNGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoNotObfuscateNGUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoNotObfuscateNGUI>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoNotObfuscateNGUI>.NativeClassPtr, 100664237);
	}

	[CallerCount(325)]
	[CachedScanResults(RefRangeStart = 7745, RefRangeEnd = 8070, XrefRangeStart = 7745, XrefRangeEnd = 8070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoNotObfuscateNGUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoNotObfuscateNGUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoNotObfuscateNGUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
