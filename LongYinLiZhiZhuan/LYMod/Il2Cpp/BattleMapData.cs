using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class BattleMapData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mapID;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleMapTypeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallColumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapGrids;

	private static readonly System.IntPtr NativeFieldInfoPtr_mustEmptyGrids;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalGrids;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleGrids;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefenceTrapID;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GridCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Void_BattleMapTypeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMapObjs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateObstacleData_Private_ObstacleData_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateWallData_Private_ObstacleData_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBuildingObstacle_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalGridAllConnected_Public_Boolean_Il2CppObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaDefenceLv_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaWallSkinLv_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSpeGridObj_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TidyGridList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridData_Public_GridUnitData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridDataByDir_Public_GridUnitData_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AroundGridHaveEnemy_Public_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEmptyGrid_Public_GridUnitData_GridUnitData_GridUnitData_List_1_GridUnitData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMoveRangeGrids_Public_Void_Int32_Int32_Int32_Int32_List_1_GridUnitData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectionObliqueGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectionCrossGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectionSectorGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectionLineGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObliqueLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStraightLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSquareGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBornGrid_Public_GridUnitData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe BattleMapTypeData battleMapTypeData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapTypeData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleMapTypeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapTypeData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleMapTypeData));
		}
	}

	public unsafe int mapWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapWidth)) = num;
		}
	}

	public unsafe int mapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapHeight)) = num;
		}
	}

	public unsafe int wallColumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallColumn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallColumn)) = num;
		}
	}

	public unsafe Il2CppObjectBase mapGrids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapGrids);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapGrids)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe List<GridUnitData> mustEmptyGrids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustEmptyGrids);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GridUnitData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustEmptyGrids)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GridUnitData> normalGrids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalGrids);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GridUnitData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalGrids)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GridUnitData> obstacleGrids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleGrids);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GridUnitData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleGrids)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> DefenceTrapID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefenceTrapID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefenceTrapID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int GridCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93074, RefRangeEnd = 93075, XrefRangeStart = 93074, XrefRangeEnd = 93074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GridCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BattleMapData()
	{
		Il2CppClassPointerStore<BattleMapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattleMapData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr);
		NativeFieldInfoPtr_mapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "mapID");
		NativeFieldInfoPtr_battleMapTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "battleMapTypeData");
		NativeFieldInfoPtr_mapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "mapWidth");
		NativeFieldInfoPtr_mapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "mapHeight");
		NativeFieldInfoPtr_wallColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "wallColumn");
		NativeFieldInfoPtr_mapGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "mapGrids");
		NativeFieldInfoPtr_mustEmptyGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "mustEmptyGrids");
		NativeFieldInfoPtr_normalGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "normalGrids");
		NativeFieldInfoPtr_obstacleGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "obstacleGrids");
		NativeFieldInfoPtr_DefenceTrapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, "DefenceTrapID");
		NativeMethodInfoPtr_get_GridCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_Generate_Public_Void_BattleMapTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_GenerateMapObjs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_GenerateObstacleData_Private_ObstacleData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_GenerateWallData_Private_ObstacleData_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_GenerateBuildingObstacle_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_NormalGridAllConnected_Public_Boolean_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_GetAreaDefenceLv_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_GetAreaWallSkinLv_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_GenerateSpeGridObj_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_TidyGridList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_GetGridData_Public_GridUnitData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_GetGridDataByDir_Public_GridUnitData_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_AroundGridHaveEnemy_Public_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_GetEmptyGrid_Public_GridUnitData_GridUnitData_GridUnitData_List_1_GridUnitData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_GetMoveRangeGrids_Public_Void_Int32_Int32_Int32_Int32_List_1_GridUnitData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_GetDirectionObliqueGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666358);
		NativeMethodInfoPtr_GetDirectionCrossGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666359);
		NativeMethodInfoPtr_GetDirectionSectorGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666360);
		NativeMethodInfoPtr_GetDirectionLineGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666361);
		NativeMethodInfoPtr_GetObliqueLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666362);
		NativeMethodInfoPtr_GetStraightLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666363);
		NativeMethodInfoPtr_GetSquareGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666364);
		NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666365);
		NativeMethodInfoPtr_GetRandomBornGrid_Public_GridUnitData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666366);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666367);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr, 100666368);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93086, RefRangeEnd = 93087, XrefRangeStart = 93075, XrefRangeEnd = 93086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Generate(BattleMapTypeData _battleMapTypeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_battleMapTypeData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate_Public_Void_BattleMapTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93119, RefRangeEnd = 93120, XrefRangeStart = 93087, XrefRangeEnd = 93119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateMapObjs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMapObjs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93158, RefRangeEnd = 93160, XrefRangeStart = 93120, XrefRangeEnd = 93158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleData GenerateObstacleData(int obstacleID, bool bigObstacle = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obstacleID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bigObstacle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateObstacleData_Private_ObstacleData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93166, RefRangeEnd = 93168, XrefRangeStart = 93160, XrefRangeEnd = 93166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleData GenerateWallData(int hp, int maxhp, int teamID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hp);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxhp;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &teamID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateWallData_Private_ObstacleData_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93647, RefRangeEnd = 93648, XrefRangeStart = 93168, XrefRangeEnd = 93647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBuildingObstacle(int obstacleCount, int gap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obstacleCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBuildingObstacle_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93648, XrefRangeEnd = 93650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NormalGridAllConnected(Il2CppObjectBase vis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vis);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalGridAllConnected_Public_Boolean_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 93653, RefRangeEnd = 93660, XrefRangeStart = 93650, XrefRangeEnd = 93653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAreaDefenceLv(int defenceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&defenceType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaDefenceLv_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93662, RefRangeEnd = 93663, XrefRangeStart = 93660, XrefRangeEnd = 93662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAreaWallSkinLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaWallSkinLv_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93711, RefRangeEnd = 93712, XrefRangeStart = 93663, XrefRangeEnd = 93711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateSpeGridObj(int speGridObjNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speGridObjNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSpeGridObj_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93712, XrefRangeEnd = 93726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TidyGridList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TidyGridList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 93727, RefRangeEnd = 93742, XrefRangeStart = 93726, XrefRangeEnd = 93727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData GetGridData(int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridData_Public_GridUnitData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 93746, RefRangeEnd = 93761, XrefRangeStart = 93742, XrefRangeEnd = 93746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData GetGridDataByDir(int row, int column, int dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridDataByDir_Public_GridUnitData_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93770, RefRangeEnd = 93771, XrefRangeStart = 93761, XrefRangeEnd = 93770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AroundGridHaveEnemy(int row, int column, int selfTeamID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selfTeamID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AroundGridHaveEnemy_Public_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93774, RefRangeEnd = 93777, XrefRangeStart = 93771, XrefRangeEnd = 93774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindConnectedGrid(Il2CppObjectBase vis, GridUnitData targetGrid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vis);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetGrid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93777, XrefRangeEnd = 93791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData GetEmptyGrid(GridUnitData from, GridUnitData to, List<GridUnitData> path, int mobility)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mobility;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEmptyGrid_Public_GridUnitData_GridUnitData_GridUnitData_List_1_GridUnitData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93849, RefRangeEnd = 93852, XrefRangeStart = 93791, XrefRangeEnd = 93849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMoveRangeGrids(int row, int column, int minRange, int maxRange, List<GridUnitData> grids, int selfTeamID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minRange;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &selfTeamID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMoveRangeGrids_Public_Void_Int32_Int32_Int32_Int32_List_1_GridUnitData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93859, RefRangeEnd = 93860, XrefRangeStart = 93852, XrefRangeEnd = 93859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDirectionObliqueGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&direction);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerRow;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectionObliqueGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93876, RefRangeEnd = 93877, XrefRangeStart = 93860, XrefRangeEnd = 93876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDirectionCrossGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&direction);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerRow;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectionCrossGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93893, RefRangeEnd = 93894, XrefRangeStart = 93877, XrefRangeEnd = 93893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDirectionSectorGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&direction);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerRow;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectionSectorGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93904, RefRangeEnd = 93905, XrefRangeStart = 93894, XrefRangeEnd = 93904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDirectionLineGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&direction);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerRow;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectionLineGrids_Public_Void_Int32_Int32_Int32_Int32_Int32_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93924, RefRangeEnd = 93929, XrefRangeStart = 93905, XrefRangeEnd = 93924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetObliqueLineGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&centerRow);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &containCenter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObliqueLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93947, RefRangeEnd = 93952, XrefRangeStart = 93929, XrefRangeEnd = 93947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetStraightLineGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&centerRow);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &containCenter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStraightLineGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93977, RefRangeEnd = 93982, XrefRangeStart = 93952, XrefRangeEnd = 93977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSquareGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&centerRow);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &containCenter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSquareGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 94002, RefRangeEnd = 94009, XrefRangeStart = 93982, XrefRangeEnd = 94002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRangeGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&centerRow);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRange;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerRange;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &containCenter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)grids);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94030, RefRangeEnd = 94032, XrefRangeStart = 94009, XrefRangeEnd = 94030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData GetRandomBornGrid(int teamID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&teamID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomBornGrid_Public_GridUnitData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94032, XrefRangeEnd = 94034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94052, RefRangeEnd = 94053, XrefRangeStart = 94034, XrefRangeEnd = 94052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleMapData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMapData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleMapData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
