using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class SlowTimeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_slowTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowTimeScale;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	public unsafe float slowTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowTime)) = num;
		}
	}

	public unsafe float slowTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowTimeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowTimeScale)) = num;
		}
	}

	static SlowTimeData()
	{
		Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SlowTimeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr);
		NativeFieldInfoPtr_slowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr, "slowTime");
		NativeFieldInfoPtr_slowTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr, "slowTimeScale");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr, 100671952);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 338066, RefRangeEnd = 338067, XrefRangeStart = 338065, XrefRangeEnd = 338066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlowTimeData(float _slowTime, float _slowTimeScale)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlowTimeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_slowTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_slowTimeScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlowTimeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
