using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class WorldPlotEventController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_WorldPlotEventDataBase;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldPlotEventController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartNewWorldPlotEvent_Public_Void_WorldPlotEventStartData_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveWorldPlotEvent_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckWorldPlotEventDataBase_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartNewWorldPlotEventFromDataBase_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_List_1_WorldPlotEventNeedData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_WorldPlotEventNeedData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<WorldPlotEventData> WorldPlotEventDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldPlotEventDataBase);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WorldPlotEventData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldPlotEventDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static WorldPlotEventController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WorldPlotEventController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlotEventController));
		}
	}

	public unsafe static WorldPlotEventController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342904, XrefRangeEnd = 342906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldPlotEventController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WorldPlotEventController>(intPtr) : null;
		}
	}

	static WorldPlotEventController()
	{
		Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldPlotEventController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr);
		NativeFieldInfoPtr_WorldPlotEventDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, "WorldPlotEventDataBase");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldPlotEventController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672153);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672154);
		NativeMethodInfoPtr_StartNewWorldPlotEvent_Public_Void_WorldPlotEventStartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672155);
		NativeMethodInfoPtr_RemoveWorldPlotEvent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672156);
		NativeMethodInfoPtr_CheckWorldPlotEventDataBase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672157);
		NativeMethodInfoPtr_StartNewWorldPlotEventFromDataBase_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672158);
		NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_List_1_WorldPlotEventNeedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672159);
		NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_WorldPlotEventNeedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672160);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr, 100672161);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342906, XrefRangeEnd = 342918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 342983, RefRangeEnd = 342991, XrefRangeStart = 342918, XrefRangeEnd = 342983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartNewWorldPlotEvent(WorldPlotEventStartData targetWorldPlotEventStartData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetWorldPlotEventStartData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartNewWorldPlotEvent_Public_Void_WorldPlotEventStartData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 343031, RefRangeEnd = 343032, XrefRangeStart = 342991, XrefRangeEnd = 343031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveWorldPlotEvent(string plotEventName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(plotEventName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveWorldPlotEvent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 343130, RefRangeEnd = 343131, XrefRangeStart = 343032, XrefRangeEnd = 343130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckWorldPlotEventDataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckWorldPlotEventDataBase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 343238, RefRangeEnd = 343239, XrefRangeStart = 343131, XrefRangeEnd = 343238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartNewWorldPlotEventFromDataBase(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartNewWorldPlotEventFromDataBase_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 343244, RefRangeEnd = 343245, XrefRangeStart = 343239, XrefRangeEnd = 343244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckMeetWorldEventNeed(List<WorldPlotEventNeedData> needDatas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)needDatas);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_List_1_WorldPlotEventNeedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 343333, RefRangeEnd = 343334, XrefRangeStart = 343245, XrefRangeEnd = 343333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckMeetWorldEventNeed(WorldPlotEventNeedData needData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)needData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMeetWorldEventNeed_Public_Boolean_WorldPlotEventNeedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldPlotEventController(IntPtr pointer)
		: base(pointer)
	{
	}
}
