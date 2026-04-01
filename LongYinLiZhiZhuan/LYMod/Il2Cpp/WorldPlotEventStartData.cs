using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class WorldPlotEventStartData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotID;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerType;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_startLeftDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetEventSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAutoDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_outtimeCallSpeFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_notImportant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_PlotTriggerType_String_Int32_String_Single_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WorldPlotEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty)) = num;
		}
	}

	public unsafe int plotID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotID)) = num;
		}
	}

	public unsafe PlotTriggerType triggerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerType);
			return *(PlotTriggerType*)num;
		}
		set
		{
			*(PlotTriggerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerType)) = plotTriggerType;
		}
	}

	public unsafe string triggerTargetID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerTargetID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerTargetID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int startLeftDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startLeftDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startLeftDay)) = num;
		}
	}

	public unsafe int targetEventSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEventSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEventSaveRecord)) = num;
		}
	}

	public unsafe EventData targetEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	public unsafe bool noAutoDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoDestroy)) = flag;
		}
	}

	public unsafe string outtimeCallSpeFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outtimeCallSpeFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outtimeCallSpeFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool notImportant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notImportant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notImportant)) = flag;
		}
	}

	static WorldPlotEventStartData()
	{
		Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldPlotEventStartData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_plotID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "plotID");
		NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "triggerType");
		NativeFieldInfoPtr_triggerTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "triggerTargetID");
		NativeFieldInfoPtr_startLeftDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "startLeftDay");
		NativeFieldInfoPtr_targetEventSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "targetEventSaveRecord");
		NativeFieldInfoPtr_targetEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "targetEvent");
		NativeFieldInfoPtr_noAutoDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "noAutoDestroy");
		NativeFieldInfoPtr_outtimeCallSpeFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "outtimeCallSpeFuc");
		NativeFieldInfoPtr_notImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, "notImportant");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, 100667276);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_PlotTriggerType_String_Int32_String_Single_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, 100667277);
		NativeMethodInfoPtr__ctor_Public_Void_WorldPlotEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, 100667278);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr, 100667279);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventStartData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 123439, RefRangeEnd = 123446, XrefRangeStart = 123435, XrefRangeEnd = 123439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventStartData(int _plotID, PlotTriggerType _triggerType, string _triggerTargetID, int _startLeftDay = 0, string _name = null, float _difficulty = -1f, EventData _targetEvent = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&_plotID);
		*(PlotTriggerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_triggerType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_triggerTargetID);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_startLeftDay;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &_difficulty;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_targetEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_PlotTriggerType_String_Int32_String_Single_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123446, XrefRangeEnd = 123450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventStartData(WorldPlotEventData worldPlotEventData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventStartData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlotEventData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_WorldPlotEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123450, XrefRangeEnd = 123465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public WorldPlotEventStartData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
