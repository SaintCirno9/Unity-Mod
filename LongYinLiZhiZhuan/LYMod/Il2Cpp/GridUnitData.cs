using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class GridUnitData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mapID;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridType;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleUnit;

	private static readonly System.IntPtr NativeFieldInfoPtr_passes;

	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstale;

	private static readonly System.IntPtr NativeFieldInfoPtr_speGridObjData;

	private static readonly System.IntPtr NativeFieldInfoPtr_tempRef;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GridType_Public_get_GridType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_GridType_Public_set_Void_GridType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GridObj_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GridUnitController_Public_get_GridUnitController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Int32_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnter_Public_Void_BattleUnit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLeave_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isEmpty_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	public unsafe int mapID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID)) = num;
		}
	}

	public unsafe GridType gridType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridType);
			return *(GridType*)num;
		}
		set
		{
			*(GridType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridType)) = gridType;
		}
	}

	public unsafe BattleUnit battleUnit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleUnit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleUnit>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleUnit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleUnit));
		}
	}

	public unsafe int passes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passes)) = num;
		}
	}

	public unsafe int row
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row)) = num;
		}
	}

	public unsafe int column
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_column);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_column)) = num;
		}
	}

	public unsafe ObstacleData obstale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obstacleData));
		}
	}

	public unsafe SpeGridObjData speGridObjData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObjData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpeGridObjData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObjData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)speGridObjData));
		}
	}

	public unsafe Il2CppSystem.Object tempRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe GridType GridType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GridType_Public_get_GridType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(GridType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 96736, RefRangeEnd = 96743, XrefRangeStart = 96736, XrefRangeEnd = 96736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GridType_Public_set_Void_GridType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GameObject GridObj
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 96751, RefRangeEnd = 96783, XrefRangeStart = 96743, XrefRangeEnd = 96751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GridObj_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	public unsafe GridUnitController GridUnitController
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96799, RefRangeEnd = 96802, XrefRangeStart = 96783, XrefRangeEnd = 96799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GridUnitController_Public_get_GridUnitController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitController>(intPtr) : null;
		}
	}

	static GridUnitData()
	{
		Il2CppClassPointerStore<GridUnitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GridUnitData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr);
		NativeFieldInfoPtr_mapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "mapID");
		NativeFieldInfoPtr_gridType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "gridType");
		NativeFieldInfoPtr_battleUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "battleUnit");
		NativeFieldInfoPtr_passes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "passes");
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "row");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "column");
		NativeFieldInfoPtr_obstale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "obstale");
		NativeFieldInfoPtr_speGridObjData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "speGridObjData");
		NativeFieldInfoPtr_tempRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, "tempRef");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666483);
		NativeMethodInfoPtr_get_GridType_Public_get_GridType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666484);
		NativeMethodInfoPtr_set_GridType_Public_set_Void_GridType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666485);
		NativeMethodInfoPtr_get_GridObj_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666486);
		NativeMethodInfoPtr_get_GridUnitController_Public_get_GridUnitController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666487);
		NativeMethodInfoPtr_Distance_Public_Int32_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666488);
		NativeMethodInfoPtr_OnEnter_Public_Void_BattleUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666489);
		NativeMethodInfoPtr_OnLeave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666490);
		NativeMethodInfoPtr_isEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666491);
		NativeMethodInfoPtr_isEmpty_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666492);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr, 100666493);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96735, RefRangeEnd = 96736, XrefRangeStart = 96729, XrefRangeEnd = 96735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData(int mapID, int row, int column)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridUnitData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mapID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 96804, RefRangeEnd = 96818, XrefRangeStart = 96802, XrefRangeEnd = 96804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Distance(GridUnitData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance_Public_Int32_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96822, RefRangeEnd = 96823, XrefRangeStart = 96818, XrefRangeEnd = 96822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnter(BattleUnit battleUnit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleUnit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnter_Public_Void_BattleUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96827, RefRangeEnd = 96830, XrefRangeStart = 96823, XrefRangeEnd = 96827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLeave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 96834, RefRangeEnd = 96840, XrefRangeStart = 96830, XrefRangeEnd = 96834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96844, RefRangeEnd = 96847, XrefRangeStart = 96840, XrefRangeEnd = 96844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isEmpty(bool includeSpeObj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeSpeObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEmpty_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96847, XrefRangeEnd = 96849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GridUnitData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
