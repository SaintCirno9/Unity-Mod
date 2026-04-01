using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class NGUIDebug : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mRayDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_mInstance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugRaycast_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_debugRaycast_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogString_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool mRayDebug
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mRayDebug, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mRayDebug, (void*)(&flag));
		}
	}

	public unsafe static List<string> mLines
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLines, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLines, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static NGUIDebug mInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NGUIDebug>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nGUIDebug));
		}
	}

	public unsafe static bool debugRaycast
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53278, XrefRangeEnd = 53282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugRaycast_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53290, RefRangeEnd = 53291, XrefRangeStart = 53282, XrefRangeEnd = 53290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_debugRaycast_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static NGUIDebug()
	{
		Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NGUIDebug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr);
		NativeFieldInfoPtr_mRayDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, "mRayDebug");
		NativeFieldInfoPtr_mLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, "mLines");
		NativeFieldInfoPtr_mInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, "mInstance");
		NativeMethodInfoPtr_get_debugRaycast_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_set_debugRaycast_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_LogString_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_Log_Public_Static_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr, 100664143);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53315, RefRangeEnd = 53317, XrefRangeStart = 53291, XrefRangeEnd = 53315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53340, RefRangeEnd = 53342, XrefRangeStart = 53317, XrefRangeEnd = 53340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogString(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogString_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53342, XrefRangeEnd = 53359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log([Optional] Il2CppReferenceArray<Il2CppSystem.Object> objs)
	{
		if (objs == null)
		{
			objs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53359, XrefRangeEnd = 53369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53369, XrefRangeEnd = 53377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53377, XrefRangeEnd = 53393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawBounds(Bounds b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53393, XrefRangeEnd = 53563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NGUIDebug()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NGUIDebug>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public static void Log(params Il2CppSystem.Object[] objs)
	{
		Log(new Il2CppReferenceArray<Il2CppSystem.Object>(objs));
	}

	public NGUIDebug(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
