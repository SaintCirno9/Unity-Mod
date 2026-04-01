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
public class ObstacleData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_obstalceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleID;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleSpriteID;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleMaxHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigObstacle;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetGridUnit;

	private static readonly System.IntPtr NativeFieldInfoPtr_needRefreshOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_explodeObstacle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObstacleDataBase_Public_ObstacleDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseGridUnitData_Public_GridUnitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraExplodeRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObstacleType_Int32_String_Int32_Single_Single_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe ObstacleType obstalceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstalceType);
			return *(ObstacleType*)num;
		}
		set
		{
			*(ObstacleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstalceType)) = obstacleType;
		}
	}

	public unsafe int obstacleID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleID)) = num;
		}
	}

	public unsafe string obstacleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int obstacleSpriteID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleSpriteID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleSpriteID)) = num;
		}
	}

	public unsafe float obstacleHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleHp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleHp)) = num;
		}
	}

	public unsafe float obstacleMaxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleMaxHp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleMaxHp)) = num;
		}
	}

	public unsafe int teamID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID)) = num;
		}
	}

	public unsafe bool bigObstacle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigObstacle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigObstacle)) = flag;
		}
	}

	public unsafe List<GridUnitData> targetGridUnit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGridUnit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GridUnitData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGridUnit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool needRefreshOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefreshOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefreshOcclusion)) = flag;
		}
	}

	public unsafe bool occlusionState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionState)) = flag;
		}
	}

	public unsafe bool explodeObstacle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explodeObstacle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explodeObstacle)) = flag;
		}
	}

	static ObstacleData()
	{
		Il2CppClassPointerStore<ObstacleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObstacleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr);
		NativeFieldInfoPtr_obstalceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstalceType");
		NativeFieldInfoPtr_obstacleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstacleID");
		NativeFieldInfoPtr_obstacleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstacleName");
		NativeFieldInfoPtr_obstacleSpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstacleSpriteID");
		NativeFieldInfoPtr_obstacleHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstacleHp");
		NativeFieldInfoPtr_obstacleMaxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "obstacleMaxHp");
		NativeFieldInfoPtr_teamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "teamID");
		NativeFieldInfoPtr_bigObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "bigObstacle");
		NativeFieldInfoPtr_targetGridUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "targetGridUnit");
		NativeFieldInfoPtr_needRefreshOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "needRefreshOcclusion");
		NativeFieldInfoPtr_occlusionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "occlusionState");
		NativeFieldInfoPtr_explodeObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, "explodeObstacle");
		NativeMethodInfoPtr_GetObstacleDataBase_Public_ObstacleDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, 100666478);
		NativeMethodInfoPtr_GetBaseGridUnitData_Public_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, 100666479);
		NativeMethodInfoPtr_GetExtraExplodeRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, 100666480);
		NativeMethodInfoPtr__ctor_Public_Void_ObstacleType_Int32_String_Int32_Single_Single_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, 100666481);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr, 100666482);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 96671, RefRangeEnd = 96688, XrefRangeStart = 96654, XrefRangeEnd = 96671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleDataBase GetObstacleDataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObstacleDataBase_Public_ObstacleDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleDataBase>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96696, RefRangeEnd = 96697, XrefRangeStart = 96688, XrefRangeEnd = 96696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitData GetBaseGridUnitData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseGridUnitData_Public_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 96697, RefRangeEnd = 96703, XrefRangeStart = 96697, XrefRangeEnd = 96697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetExtraExplodeRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraExplodeRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96712, RefRangeEnd = 96714, XrefRangeStart = 96703, XrefRangeEnd = 96712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleData(ObstacleType _obstalceType, int _obstacleID, string _name, int _obstacleSpriteID, float _hp, float _maxhp, int _teamID = -1, bool _bigObstacle = false, bool _explodeObstacle = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstacleData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&_obstalceType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_obstacleID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_obstacleSpriteID;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_hp;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &_maxhp;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &_teamID;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &_bigObstacle;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &_explodeObstacle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ObstacleType_Int32_String_Int32_Single_Single_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96714, XrefRangeEnd = 96729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ObstacleData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
