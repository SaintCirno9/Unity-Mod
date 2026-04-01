using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class TextReplaceData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ReplaceTexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_MustReplaceTexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecialReplaceTexts;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> ReplaceTexts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReplaceTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReplaceTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> MustReplaceTexts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MustReplaceTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MustReplaceTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> SpecialReplaceTexts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpecialReplaceTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpecialReplaceTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static TextReplaceData()
	{
		Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TextReplaceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr);
		NativeFieldInfoPtr_ReplaceTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr, "ReplaceTexts");
		NativeFieldInfoPtr_MustReplaceTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr, "MustReplaceTexts");
		NativeFieldInfoPtr_SpecialReplaceTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr, "SpecialReplaceTexts");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr, 100669447);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextReplaceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReplaceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextReplaceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
