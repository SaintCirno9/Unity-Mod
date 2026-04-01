using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class MinMaxRangeAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_minLimit;

	private static readonly IntPtr NativeFieldInfoPtr_maxLimit;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	public unsafe float minLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLimit)) = num;
		}
	}

	public unsafe float maxLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLimit)) = num;
		}
	}

	static MinMaxRangeAttribute()
	{
		Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MinMaxRangeAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_minLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "minLimit");
		NativeFieldInfoPtr_maxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "maxLimit");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664133);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53277, XrefRangeEnd = 53278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MinMaxRangeAttribute(float minLimit, float maxLimit)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&minLimit);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxLimit;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MinMaxRangeAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
