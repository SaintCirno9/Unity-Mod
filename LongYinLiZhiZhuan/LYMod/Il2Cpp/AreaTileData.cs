using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AreaTileData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteName;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteRotateType;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteFlipX;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteFlipY;

	private static readonly System.IntPtr NativeFieldInfoPtr_building;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileType;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaRoadData;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AreaTileType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArea_Public_AreaData_0;

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

	public unsafe AreaBuildingData building
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaBuildingData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaBuildingData));
		}
	}

	public unsafe AreaTileType tileType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileType);
			return *(AreaTileType*)num;
		}
		set
		{
			*(AreaTileType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileType)) = areaTileType;
		}
	}

	public unsafe AreaRoadData areaRoadData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaRoadData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaRoadData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaRoadData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaRoadData));
		}
	}

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

	static AreaTileData()
	{
		Il2CppClassPointerStore<AreaTileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaTileData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "spriteName");
		NativeFieldInfoPtr_spriteRotateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "spriteRotateType");
		NativeFieldInfoPtr_spriteFlipX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "spriteFlipX");
		NativeFieldInfoPtr_spriteFlipY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "spriteFlipY");
		NativeFieldInfoPtr_building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "building");
		NativeFieldInfoPtr_tileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "tileType");
		NativeFieldInfoPtr_areaRoadData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "areaRoadData");
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "row");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, "column");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_AreaTileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr_GetArea_Public_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr, 100667191);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121658, RefRangeEnd = 121659, XrefRangeStart = 121657, XrefRangeEnd = 121658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaTileData(int _areaID, AreaTileType _tileType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaTileData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_areaID);
		*(AreaTileType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_tileType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_AreaTileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 121669, RefRangeEnd = 121676, XrefRangeStart = 121659, XrefRangeEnd = 121669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaData GetArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArea_Public_AreaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121676, XrefRangeEnd = 121691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaTileData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
