using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class WorldPlotEventData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotID;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerType;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_needDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTimeRandomDayRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_startContinueTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatType;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_endTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startRemindType;

	private static readonly System.IntPtr NativeFieldInfoPtr_startRemindSouce;

	private static readonly System.IntPtr NativeFieldInfoPtr_startRemindText;

	private static readonly System.IntPtr NativeFieldInfoPtr_startCallSpeFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_outtimeCallSpeFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAutoDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_notImportant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe AvailableGameMode availableMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableMode);
			return *(AvailableGameMode*)num;
		}
		set
		{
			*(AvailableGameMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableMode)) = availableGameMode;
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

	public unsafe List<WorldPlotEventNeedData> needDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldPlotEventNeedData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TimeData startTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeData));
		}
	}

	public unsafe int startTimeRandomDayRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTimeRandomDayRange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTimeRandomDayRange)) = num;
		}
	}

	public unsafe int startContinueTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startContinueTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startContinueTime)) = num;
		}
	}

	public unsafe WorldPlotEventRepeatType repeatType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatType);
			return *(WorldPlotEventRepeatType*)num;
		}
		set
		{
			*(WorldPlotEventRepeatType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatType)) = worldPlotEventRepeatType;
		}
	}

	public unsafe int repeatTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatTime)) = num;
		}
	}

	public unsafe TimeData endTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeData));
		}
	}

	public unsafe WorldPlotEventStartRemindType startRemindType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindType);
			return *(WorldPlotEventStartRemindType*)num;
		}
		set
		{
			*(WorldPlotEventStartRemindType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindType)) = worldPlotEventStartRemindType;
		}
	}

	public unsafe string startRemindSouce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindSouce);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindSouce)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startRemindText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRemindText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startCallSpeFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCallSpeFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCallSpeFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	static WorldPlotEventData()
	{
		Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldPlotEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_availableMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "availableMode");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_plotID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "plotID");
		NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "triggerType");
		NativeFieldInfoPtr_triggerTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "triggerTargetID");
		NativeFieldInfoPtr_needDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "needDatas");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_startTimeRandomDayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startTimeRandomDayRange");
		NativeFieldInfoPtr_startContinueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startContinueTime");
		NativeFieldInfoPtr_repeatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "repeatType");
		NativeFieldInfoPtr_repeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "repeatTime");
		NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "endTime");
		NativeFieldInfoPtr_startRemindType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startRemindType");
		NativeFieldInfoPtr_startRemindSouce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startRemindSouce");
		NativeFieldInfoPtr_startRemindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startRemindText");
		NativeFieldInfoPtr_startCallSpeFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "startCallSpeFuc");
		NativeFieldInfoPtr_outtimeCallSpeFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "outtimeCallSpeFuc");
		NativeFieldInfoPtr_noAutoDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "noAutoDestroy");
		NativeFieldInfoPtr_notImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, "notImportant");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, 100667274);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr, 100667275);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123420, XrefRangeEnd = 123435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public WorldPlotEventData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
