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
public class WorldEventDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotSignRequirements;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatType;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDayRandomRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_noRandomDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_startCallPlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventRandomArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe List<PlotSignRequirement> plotSignRequirements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotSignRequirements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PlotSignRequirement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotSignRequirements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe WorldEventRepeatType repeatType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatType);
			return *(WorldEventRepeatType*)num;
		}
		set
		{
			*(WorldEventRepeatType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatType)) = worldEventRepeatType;
		}
	}

	public unsafe int repeatDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDay)) = num;
		}
	}

	public unsafe int repeatDayRandomRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDayRandomRange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDayRandomRange)) = num;
		}
	}

	public unsafe int lastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime)) = num;
		}
	}

	public unsafe bool noRandomDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noRandomDifficulty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noRandomDifficulty)) = flag;
		}
	}

	public unsafe int forceDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDifficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDifficulty)) = num;
		}
	}

	public unsafe string startCallPlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCallPlot);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCallPlot)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe WorldEventRandomArea eventRandomArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventRandomArea);
			return *(WorldEventRandomArea*)num;
		}
		set
		{
			*(WorldEventRandomArea*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventRandomArea)) = worldEventRandomArea;
		}
	}

	public unsafe EventData eventData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	static WorldEventDataBase()
	{
		Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldEventDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "name");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_plotSignRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "plotSignRequirements");
		NativeFieldInfoPtr_repeatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "repeatType");
		NativeFieldInfoPtr_repeatDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "repeatDay");
		NativeFieldInfoPtr_repeatDayRandomRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "repeatDayRandomRange");
		NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "lastTime");
		NativeFieldInfoPtr_noRandomDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "noRandomDifficulty");
		NativeFieldInfoPtr_forceDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "forceDifficulty");
		NativeFieldInfoPtr_startCallPlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "startCallPlot");
		NativeFieldInfoPtr_eventRandomArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "eventRandomArea");
		NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, "eventData");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, 100667009);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr, 100667010);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113485, XrefRangeEnd = 113500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113500, XrefRangeEnd = 113501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldEventDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldEventDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldEventDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
