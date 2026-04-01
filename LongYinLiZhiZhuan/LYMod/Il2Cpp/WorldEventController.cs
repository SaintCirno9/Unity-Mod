using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class WorldEventController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_worldEventDataBase;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeFieldInfoPtr_tutorialWorldEventName;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldEventController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ManageWorldEvent_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRandomWorldEvent_Public_EventData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_WorldEventDataBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWorldEventRandomDifficulty_Public_Single_WorldEventDataBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_ResourcePointData_Int32_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_List_1_Int32_Int32_Single_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddNewWorldEvent_Public_Void_EventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_HaveTutorialWorldEvent_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<WorldEventDataBase> worldEventDataBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEventDataBase);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WorldEventDataBase>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEventDataBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static WorldEventController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WorldEventController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldEventController));
		}
	}

	public unsafe static List<string> tutorialWorldEventName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tutorialWorldEventName, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tutorialWorldEventName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static WorldEventController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342549, XrefRangeEnd = 342553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldEventController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WorldEventController>(intPtr) : null;
		}
	}

	static WorldEventController()
	{
		Il2CppClassPointerStore<WorldEventController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldEventController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr);
		NativeFieldInfoPtr_worldEventDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, "worldEventDataBase");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_tutorialWorldEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, "tutorialWorldEventName");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_WorldEventController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672138);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672139);
		NativeMethodInfoPtr_ManageWorldEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672140);
		NativeMethodInfoPtr_CreateRandomWorldEvent_Public_EventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672141);
		NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_WorldEventDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672142);
		NativeMethodInfoPtr_GetWorldEventRandomDifficulty_Public_Single_WorldEventDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672143);
		NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_ResourcePointData_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672144);
		NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_List_1_Int32_Int32_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672145);
		NativeMethodInfoPtr_AddNewWorldEvent_Public_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672146);
		NativeMethodInfoPtr_HaveTutorialWorldEvent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672147);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr, 100672148);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342553, XrefRangeEnd = 342565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342622, RefRangeEnd = 342623, XrefRangeStart = 342565, XrefRangeEnd = 342622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageWorldEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageWorldEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342652, RefRangeEnd = 342653, XrefRangeStart = 342623, XrefRangeEnd = 342652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData CreateRandomWorldEvent(bool limitStartTime = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&limitStartTime);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRandomWorldEvent_Public_EventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 342670, RefRangeEnd = 342673, XrefRangeStart = 342653, XrefRangeEnd = 342670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData CreateWorldEvent(WorldEventDataBase targetWorldEventDataBase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetWorldEventDataBase);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_WorldEventDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342673, XrefRangeEnd = 342674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldEventRandomDifficulty(WorldEventDataBase targetWorldEventDataBase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetWorldEventDataBase);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldEventRandomDifficulty_Public_Single_WorldEventDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342687, RefRangeEnd = 342688, XrefRangeStart = 342674, XrefRangeEnd = 342687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData CreateWorldEvent(EventData targetEvent, ResourcePointData targetResourcePoint, int lastTime, float difficulty, int speTargetID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetResourcePoint);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &lastTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &difficulty;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &speTargetID;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_ResourcePointData_Int32_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 342709, RefRangeEnd = 342711, XrefRangeStart = 342688, XrefRangeEnd = 342709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData CreateWorldEvent(EventData targetEvent, List<int> targetAreaIDList, int lastTime, float difficulty, int speTargetID, bool isBigMapEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetAreaIDList);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &lastTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &difficulty;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &speTargetID;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &isBigMapEvent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorldEvent_Public_EventData_EventData_List_1_Int32_Int32_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 342737, RefRangeEnd = 342740, XrefRangeStart = 342711, XrefRangeEnd = 342737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewWorldEvent(EventData newRandomEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRandomEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewWorldEvent_Public_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342767, RefRangeEnd = 342768, XrefRangeStart = 342740, XrefRangeEnd = 342767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveTutorialWorldEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTutorialWorldEvent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldEventController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldEventController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldEventController(IntPtr pointer)
		: base(pointer)
	{
	}
}
