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
public class AreaRoadData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeTimeLeft;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArea_Public_AreaData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProduceRateChange_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoadDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int areaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID)) = num;
		}
	}

	public unsafe int roadLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadLv)) = num;
		}
	}

	public unsafe int upgradeTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeTimeLeft);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeTimeLeft)) = num;
		}
	}

	static AreaRoadData()
	{
		Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaRoadData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr);
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_roadLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, "roadLv");
		NativeFieldInfoPtr_upgradeTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, "upgradeTimeLeft");
		NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667180);
		NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667181);
		NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667182);
		NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667183);
		NativeMethodInfoPtr_GetArea_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667184);
		NativeMethodInfoPtr_GetProduceRateChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_GetRoadDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr, 100667188);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121508, RefRangeEnd = 121509, XrefRangeStart = 121468, XrefRangeEnd = 121508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUpgradeCostText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeCostText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 121533, RefRangeEnd = 121535, XrefRangeStart = 121509, XrefRangeEnd = 121533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<float> GetUpgradeCostResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeCostResource_Public_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121543, RefRangeEnd = 121544, XrefRangeStart = 121535, XrefRangeEnd = 121543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeTime_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121544, XrefRangeEnd = 121550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBuildSpeedRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildSpeedRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 121560, RefRangeEnd = 121570, XrefRangeStart = 121550, XrefRangeEnd = 121560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData GetArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArea_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 121570, RefRangeEnd = 121572, XrefRangeStart = 121570, XrefRangeEnd = 121570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetProduceRateChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProduceRateChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121572, XrefRangeEnd = 121607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRoadDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoadDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 121608, RefRangeEnd = 121642, XrefRangeStart = 121607, XrefRangeEnd = 121608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaRoadData(int _areaID, int _roadLv)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaRoadData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_areaID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_roadLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121642, XrefRangeEnd = 121657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaRoadData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
