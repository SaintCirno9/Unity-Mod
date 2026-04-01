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
public class EventData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_eventName;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventAvailableAreaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAreaEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourcePointID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaMapTileID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigMapPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearAreaDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_seen;

	private static readonly System.IntPtr NativeFieldInfoPtr_happened;

	private static readonly System.IntPtr NativeFieldInfoPtr_noticed;

	private static readonly System.IntPtr NativeFieldInfoPtr_hovered;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotTargetEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_speTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotData;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventItemList;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaderLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventOutTimeCallFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_seeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_inaccuracyPosText;

	private static readonly System.IntPtr NativeFieldInfoPtr_notImportant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlotData_Public_Void_PlotData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventRareLv_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Name_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string eventName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string eventDescribe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDescribe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDescribe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<EventAvailableAreaType> eventAvailableAreaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAvailableAreaType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventAvailableAreaType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAvailableAreaType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string spriteName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isAreaEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAreaEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAreaEvent)) = flag;
		}
	}

	public unsafe int resourcePointID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointID)) = num;
		}
	}

	public unsafe List<int> areaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> areaMapTileID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaMapTileID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaMapTileID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BigMapPos bigMapPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigMapPos>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigMapPos));
		}
	}

	public unsafe int nearAreaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaID)) = num;
		}
	}

	public unsafe int nearAreaDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaDirection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearAreaDirection)) = num;
		}
	}

	public unsafe bool seen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seen)) = flag;
		}
	}

	public unsafe bool happened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_happened);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_happened)) = flag;
		}
	}

	public unsafe bool noticed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noticed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noticed)) = flag;
		}
	}

	public unsafe bool hovered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hovered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hovered)) = flag;
		}
	}

	public unsafe bool plotTargetEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotTargetEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotTargetEvent)) = flag;
		}
	}

	public unsafe bool missionTargetEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetEvent)) = flag;
		}
	}

	public unsafe bool autoDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDestroy)) = flag;
		}
	}

	public unsafe int leftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime)) = num;
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

	public unsafe float difficultyRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyRate)) = num;
		}
	}

	public unsafe int speTargetID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speTargetID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speTargetID)) = num;
		}
	}

	public unsafe PlotData plotData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlotData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)plotData));
		}
	}

	public unsafe ItemListData eventItemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventItemList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemListData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventItemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemListData));
		}
	}

	public unsafe LeaderLimit leaderLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaderLimit);
			return *(LeaderLimit*)num;
		}
		set
		{
			*(LeaderLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaderLimit)) = leaderLimit;
		}
	}

	public unsafe string eventOutTimeCallFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventOutTimeCallFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventOutTimeCallFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float seeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seeRange)) = num;
		}
	}

	public unsafe int randomSeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSeed)) = num;
		}
	}

	public unsafe bool inaccuracyPosText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inaccuracyPosText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inaccuracyPosText)) = flag;
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

	static EventData()
	{
		Il2CppClassPointerStore<EventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventData>.NativeClassPtr);
		NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "eventName");
		NativeFieldInfoPtr_eventDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "eventDescribe");
		NativeFieldInfoPtr_eventAvailableAreaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "eventAvailableAreaType");
		NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "spriteName");
		NativeFieldInfoPtr_isAreaEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "isAreaEvent");
		NativeFieldInfoPtr_resourcePointID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "resourcePointID");
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_areaMapTileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "areaMapTileID");
		NativeFieldInfoPtr_bigMapPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "bigMapPos");
		NativeFieldInfoPtr_nearAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "nearAreaID");
		NativeFieldInfoPtr_nearAreaDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "nearAreaDirection");
		NativeFieldInfoPtr_seen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "seen");
		NativeFieldInfoPtr_happened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "happened");
		NativeFieldInfoPtr_noticed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "noticed");
		NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "hovered");
		NativeFieldInfoPtr_plotTargetEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "plotTargetEvent");
		NativeFieldInfoPtr_missionTargetEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "missionTargetEvent");
		NativeFieldInfoPtr_autoDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "autoDestroy");
		NativeFieldInfoPtr_leftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "leftTime");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_difficultyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "difficultyRate");
		NativeFieldInfoPtr_speTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "speTargetID");
		NativeFieldInfoPtr_plotData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "plotData");
		NativeFieldInfoPtr_eventItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "eventItemList");
		NativeFieldInfoPtr_leaderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "leaderLimit");
		NativeFieldInfoPtr_eventOutTimeCallFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "eventOutTimeCallFuc");
		NativeFieldInfoPtr_seeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "seeRange");
		NativeFieldInfoPtr_randomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "randomSeed");
		NativeFieldInfoPtr_inaccuracyPosText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "inaccuracyPosText");
		NativeFieldInfoPtr_notImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventData>.NativeClassPtr, "notImportant");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667261);
		NativeMethodInfoPtr_SetPlotData_Public_Void_PlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667262);
		NativeMethodInfoPtr_GetEventRareLv_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667263);
		NativeMethodInfoPtr_Name_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667264);
		NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667265);
		NativeMethodInfoPtr_GetPosText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667266);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventData>.NativeClassPtr, 100667267);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123009, RefRangeEnd = 123010, XrefRangeStart = 122991, XrefRangeEnd = 123009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123010, XrefRangeEnd = 123011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlotData(PlotData _plotData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_plotData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlotData_Public_Void_PlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123012, RefRangeEnd = 123013, XrefRangeStart = 123011, XrefRangeEnd = 123012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetEventRareLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventRareLv_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 123018, RefRangeEnd = 123024, XrefRangeStart = 123013, XrefRangeEnd = 123018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Name()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Name_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123097, RefRangeEnd = 123099, XrefRangeStart = 123024, XrefRangeEnd = 123097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe(bool showDifficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showDifficulty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123140, RefRangeEnd = 123142, XrefRangeStart = 123099, XrefRangeEnd = 123140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPosText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 123157, RefRangeEnd = 123163, XrefRangeStart = 123142, XrefRangeEnd = 123157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public EventData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
