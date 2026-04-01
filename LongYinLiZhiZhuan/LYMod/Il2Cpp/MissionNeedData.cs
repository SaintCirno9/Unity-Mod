using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class MissionNeedData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetType;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionResourceNeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumNeed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MissionTargetType missionTargetType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetType);
			return *(MissionTargetType*)num;
		}
		set
		{
			*(MissionTargetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetType)) = missionTargetType;
		}
	}

	public unsafe string missionTargetID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionTargetID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int missionResourceNeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionResourceNeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionResourceNeed)) = num;
		}
	}

	public unsafe float missionNumCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumCount)) = num;
		}
	}

	public unsafe float missionNumNeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumNeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumNeed)) = num;
		}
	}

	static MissionNeedData()
	{
		Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MissionNeedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr);
		NativeFieldInfoPtr_missionTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, "missionTargetType");
		NativeFieldInfoPtr_missionTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, "missionTargetID");
		NativeFieldInfoPtr_missionResourceNeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, "missionResourceNeed");
		NativeFieldInfoPtr_missionNumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, "missionNumCount");
		NativeFieldInfoPtr_missionNumNeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, "missionNumNeed");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, 100668025);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr, 100668026);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144041, XrefRangeEnd = 144056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionNeedData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNeedData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MissionNeedData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
