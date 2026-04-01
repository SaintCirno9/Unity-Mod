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
public class ExplorePanelData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_exploreType;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreMapType;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreTileMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishParam;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_showFinal;

	private static readonly System.IntPtr NativeFieldInfoPtr_startDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_endDistance;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTileID_Public_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateWildGround_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMazeGround_Public_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileCanBecomeObstacle_Public_Boolean_ExploreTileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileCanBecomeDoor_Public_Boolean_ExploreTileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_ExploreTileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_ExploreTileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindConnectedGridDistance_Private_Void_Il2CppObjectBase_Int32_ExploreTileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridDataByDir_Public_ExploreTileData_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridData_Public_ExploreTileData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe ExploreType exploreType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreType);
			return *(ExploreType*)num;
		}
		set
		{
			*(ExploreType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreType)) = exploreType;
		}
	}

	public unsafe int exploreMapType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreMapType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreMapType)) = num;
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

	public unsafe List<ExploreTileData> exploreTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExploreTileData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppObjectBase exploreTileMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileMap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe int maxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower)) = num;
		}
	}

	public unsafe ExploreTileData startTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExploreTileData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exploreTileData));
		}
	}

	public unsafe string finishFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string finishParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishParam);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishParam)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int keyNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyNum)) = num;
		}
	}

	public unsafe bool showFinal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showFinal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showFinal)) = flag;
		}
	}

	public unsafe Il2CppObjectBase startDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startDistance)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase endDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endDistance)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	static ExplorePanelData()
	{
		Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExplorePanelData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr);
		NativeFieldInfoPtr_exploreType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "exploreType");
		NativeFieldInfoPtr_exploreMapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "exploreMapType");
		NativeFieldInfoPtr_mapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "mapWidth");
		NativeFieldInfoPtr_mapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "mapHeight");
		NativeFieldInfoPtr_exploreTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "exploreTiles");
		NativeFieldInfoPtr_exploreTileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "exploreTileMap");
		NativeFieldInfoPtr_maxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "maxPower");
		NativeFieldInfoPtr_startTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "startTile");
		NativeFieldInfoPtr_finishFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "finishFuc");
		NativeFieldInfoPtr_finishParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "finishParam");
		NativeFieldInfoPtr_keyNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "keyNum");
		NativeFieldInfoPtr_showFinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "showFinal");
		NativeFieldInfoPtr_startDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "startDistance");
		NativeFieldInfoPtr_endDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, "endDistance");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668271);
		NativeMethodInfoPtr_GetTileID_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668272);
		NativeMethodInfoPtr_GenerateWildGround_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668273);
		NativeMethodInfoPtr_GenerateMazeGround_Public_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668274);
		NativeMethodInfoPtr_TileCanBecomeObstacle_Public_Boolean_ExploreTileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668275);
		NativeMethodInfoPtr_TileCanBecomeDoor_Public_Boolean_ExploreTileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668276);
		NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_ExploreTileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668277);
		NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_ExploreTileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668278);
		NativeMethodInfoPtr_FindConnectedGridDistance_Private_Void_Il2CppObjectBase_Int32_ExploreTileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668279);
		NativeMethodInfoPtr_GetGridDataByDir_Public_ExploreTileData_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668280);
		NativeMethodInfoPtr_GetGridData_Public_ExploreTileData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668281);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr, 100668282);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 150922, RefRangeEnd = 150923, XrefRangeStart = 150914, XrefRangeEnd = 150922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExplorePanelData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExplorePanelData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 150923, RefRangeEnd = 150924, XrefRangeStart = 150923, XrefRangeEnd = 150923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTileID(int c, int r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTileID_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151034, RefRangeEnd = 151035, XrefRangeStart = 150924, XrefRangeEnd = 151034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateWildGround(int roadNum, float difficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&roadNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &difficulty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateWildGround_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151156, RefRangeEnd = 151157, XrefRangeStart = 151035, XrefRangeEnd = 151156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateMazeGround(int obstacleCount, int gap, float difficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obstacleCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gap;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &difficulty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMazeGround_Public_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151157, XrefRangeEnd = 151158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TileCanBecomeObstacle(ExploreTileData targetTile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetTile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileCanBecomeObstacle_Public_Boolean_ExploreTileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151182, RefRangeEnd = 151183, XrefRangeStart = 151158, XrefRangeEnd = 151182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TileCanBecomeDoor(ExploreTileData targetTile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetTile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileCanBecomeDoor_Public_Boolean_ExploreTileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151203, RefRangeEnd = 151204, XrefRangeStart = 151183, XrefRangeEnd = 151203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRangeGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<ExploreTileData> grids)
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRangeGrids_Public_Void_Int32_Int32_Int32_Int32_Boolean_List_1_ExploreTileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 151207, RefRangeEnd = 151209, XrefRangeStart = 151204, XrefRangeEnd = 151207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindConnectedGrid(Il2CppObjectBase vis, ExploreTileData targetGrid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vis);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetGrid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindConnectedGrid_Private_Void_Il2CppObjectBase_ExploreTileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 151213, RefRangeEnd = 151216, XrefRangeStart = 151209, XrefRangeEnd = 151213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindConnectedGridDistance(Il2CppObjectBase distance, int targetDistance, ExploreTileData targetGrid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(distance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetDistance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetGrid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindConnectedGridDistance_Private_Void_Il2CppObjectBase_Int32_ExploreTileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 151220, RefRangeEnd = 151227, XrefRangeStart = 151216, XrefRangeEnd = 151220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExploreTileData GetGridDataByDir(int row, int column, int dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridDataByDir_Public_ExploreTileData_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExploreTileData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151227, XrefRangeEnd = 151228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExploreTileData GetGridData(int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridData_Public_ExploreTileData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExploreTileData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151228, XrefRangeEnd = 151243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ExplorePanelData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
