using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class BigMapSpeEffectController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_bigMapSpeEffectType;

	private static readonly IntPtr NativeFieldInfoPtr_bigMapSpeEffectTypeName;

	private static readonly IntPtr NativeFieldInfoPtr_bigMapSpeEffectTypeDescribe;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BigMapSpeEffectType bigMapSpeEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapSpeEffectType);
			return *(BigMapSpeEffectType*)num;
		}
		set
		{
			*(BigMapSpeEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapSpeEffectType)) = bigMapSpeEffectType;
		}
	}

	public unsafe static List<string> bigMapSpeEffectTypeName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigMapSpeEffectTypeName, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigMapSpeEffectTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> bigMapSpeEffectTypeDescribe
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigMapSpeEffectTypeDescribe, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigMapSpeEffectTypeDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BigMapSpeEffectController()
	{
		Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BigMapSpeEffectController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr);
		NativeFieldInfoPtr_bigMapSpeEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr, "bigMapSpeEffectType");
		NativeFieldInfoPtr_bigMapSpeEffectTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr, "bigMapSpeEffectTypeName");
		NativeFieldInfoPtr_bigMapSpeEffectTypeDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr, "bigMapSpeEffectTypeDescribe");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr, 100666597);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigMapSpeEffectController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigMapSpeEffectController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BigMapSpeEffectController(IntPtr pointer)
		: base(pointer)
	{
	}
}
