using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ExploreTileData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteName;

	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteRotateType;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteFlipX;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteFlipY;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallType;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventHappen;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreTileEventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemyDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemyNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreTileGroundType;

	private static readonly System.IntPtr NativeFieldInfoPtr_exploreTileObstacleData;

	private static readonly System.IntPtr NativeFieldInfoPtr_seen;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveAble;

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

	public unsafe SpriteRotateType spriteRotateType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteRotateType);
			return *(SpriteRotateType*)num;
		}
		set
		{
			*(SpriteRotateType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteRotateType)) = spriteRotateType;
		}
	}

	public unsafe bool spriteFlipX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteFlipX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteFlipX)) = flag;
		}
	}

	public unsafe bool spriteFlipY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteFlipY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteFlipY)) = flag;
		}
	}

	public unsafe ExploreTileWallType wallType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallType);
			return *(ExploreTileWallType*)num;
		}
		set
		{
			*(ExploreTileWallType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallType)) = exploreTileWallType;
		}
	}

	public unsafe bool doorOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpen)) = flag;
		}
	}

	public unsafe bool eventHappen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventHappen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventHappen)) = flag;
		}
	}

	public unsafe int exploreTileEventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileEventType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileEventType)) = num;
		}
	}

	public unsafe float enemyDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyDifficulty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyDifficulty)) = num;
		}
	}

	public unsafe int enemyNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyNum)) = num;
		}
	}

	public unsafe int targetResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetResource);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetResource)) = num;
		}
	}

	public unsafe ExploreTileGroundType exploreTileGroundType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileGroundType);
			return *(ExploreTileGroundType*)num;
		}
		set
		{
			*(ExploreTileGroundType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileGroundType)) = exploreTileGroundType;
		}
	}

	public unsafe ExploreTileObstacleData exploreTileObstacleData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileObstacleData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExploreTileObstacleData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exploreTileObstacleData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exploreTileObstacleData));
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

	public unsafe bool moveAble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveAble);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveAble)) = flag;
		}
	}

	static ExploreTileData()
	{
		Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExploreTileData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "spriteName");
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "row");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "column");
		NativeFieldInfoPtr_spriteRotateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "spriteRotateType");
		NativeFieldInfoPtr_spriteFlipX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "spriteFlipX");
		NativeFieldInfoPtr_spriteFlipY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "spriteFlipY");
		NativeFieldInfoPtr_wallType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "wallType");
		NativeFieldInfoPtr_doorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "doorOpen");
		NativeFieldInfoPtr_eventHappen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "eventHappen");
		NativeFieldInfoPtr_exploreTileEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "exploreTileEventType");
		NativeFieldInfoPtr_enemyDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "enemyDifficulty");
		NativeFieldInfoPtr_enemyNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "enemyNum");
		NativeFieldInfoPtr_targetResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "targetResource");
		NativeFieldInfoPtr_exploreTileGroundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "exploreTileGroundType");
		NativeFieldInfoPtr_exploreTileObstacleData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "exploreTileObstacleData");
		NativeFieldInfoPtr_seen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "seen");
		NativeFieldInfoPtr_moveAble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, "moveAble");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, 100668289);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr, 100668290);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151274, RefRangeEnd = 151275, XrefRangeStart = 151273, XrefRangeEnd = 151274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExploreTileData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExploreTileData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151275, XrefRangeEnd = 151290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ExploreTileData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
