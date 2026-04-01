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
public class MissionTargetData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_describe;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionEventDataSaveRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionEventData;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTriggerType;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetAreaTypeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_tirggerTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNeedDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionRequirementTypeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionRequirementType;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionRequirementNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetFinishCallPlotID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MissionNumMeetRequire_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string describe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int missionEventDataSaveRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionEventDataSaveRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionEventDataSaveRecord)) = num;
		}
	}

	public unsafe EventData missionEventData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionEventData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionEventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData));
		}
	}

	public unsafe MissionTriggerType missionTriggerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTriggerType);
			return *(MissionTriggerType*)num;
		}
		set
		{
			*(MissionTriggerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTriggerType)) = missionTriggerType;
		}
	}

	public unsafe MissionTargetAreaTypeLimit missionTargetAreaTypeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetAreaTypeLimit);
			return *(MissionTargetAreaTypeLimit*)num;
		}
		set
		{
			*(MissionTargetAreaTypeLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetAreaTypeLimit)) = missionTargetAreaTypeLimit;
		}
	}

	public unsafe string tirggerTargetID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tirggerTargetID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tirggerTargetID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<MissionNeedData> missionNeedDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNeedDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionNeedData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNeedDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ChoiceRequirementType> missionRequirementTypeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementTypeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChoiceRequirementType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementTypeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ChoiceRequirementType missionRequirementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementType);
			return *(ChoiceRequirementType*)num;
		}
		set
		{
			*(ChoiceRequirementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementType)) = choiceRequirementType;
		}
	}

	public unsafe float missionRequirementNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementNum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionRequirementNum)) = num;
		}
	}

	public unsafe int missionTargetFinishCallPlotID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetFinishCallPlotID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetFinishCallPlotID)) = num;
		}
	}

	static MissionTargetData()
	{
		Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MissionTargetData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr);
		NativeFieldInfoPtr_describe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "describe");
		NativeFieldInfoPtr_missionEventDataSaveRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionEventDataSaveRecord");
		NativeFieldInfoPtr_missionEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionEventData");
		NativeFieldInfoPtr_missionTriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionTriggerType");
		NativeFieldInfoPtr_missionTargetAreaTypeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionTargetAreaTypeLimit");
		NativeFieldInfoPtr_tirggerTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "tirggerTargetID");
		NativeFieldInfoPtr_missionNeedDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionNeedDatas");
		NativeFieldInfoPtr_missionRequirementTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionRequirementTypeList");
		NativeFieldInfoPtr_missionRequirementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionRequirementType");
		NativeFieldInfoPtr_missionRequirementNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionRequirementNum");
		NativeFieldInfoPtr_missionTargetFinishCallPlotID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, "missionTargetFinishCallPlotID");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, 100668027);
		NativeMethodInfoPtr_MissionNumMeetRequire_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, 100668028);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr, 100668029);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144056, XrefRangeEnd = 144072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionTargetData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionTargetData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 144080, RefRangeEnd = 144081, XrefRangeStart = 144072, XrefRangeEnd = 144080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MissionNumMeetRequire()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MissionNumMeetRequire_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144081, XrefRangeEnd = 144096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public MissionTargetData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
