using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class RealTime : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float time
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 58842, RefRangeEnd = 58863, XrefRangeStart = 58841, XrefRangeEnd = 58842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static float deltaTime
	{
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 58864, RefRangeEnd = 58915, XrefRangeStart = 58863, XrefRangeEnd = 58864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static RealTime()
	{
		Il2CppClassPointerStore<RealTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RealTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealTime>.NativeClassPtr);
		NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTime>.NativeClassPtr, 100664382);
		NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTime>.NativeClassPtr, 100664383);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTime>.NativeClassPtr, 100664384);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RealTime()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealTime>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RealTime(IntPtr pointer)
		: base(pointer)
	{
	}
}
