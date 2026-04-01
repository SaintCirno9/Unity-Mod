using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class MapNavigator : Il2CppSystem.Object
{
	public class NavigationData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_open;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeFieldInfoPtr_G;

		private static readonly System.IntPtr NativeFieldInfoPtr_H;

		private static readonly System.IntPtr NativeFieldInfoPtr_thisGrid;

		private static readonly System.IntPtr NativeFieldInfoPtr_preGrid;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		public unsafe bool open
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_open);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_open)) = flag;
			}
		}

		public unsafe int F
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F)) = num;
			}
		}

		public unsafe int G
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_G);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_G)) = num;
			}
		}

		public unsafe int H
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_H);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_H)) = num;
			}
		}

		public unsafe GridUnitData thisGrid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisGrid);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisGrid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gridUnitData));
			}
		}

		public unsafe NavigationData preGrid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preGrid);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavigationData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preGrid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navigationData));
			}
		}

		static NavigationData()
		{
			Il2CppClassPointerStore<NavigationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, "NavigationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationData>.NativeClassPtr);
			NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "open");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "F");
			NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "G");
			NativeFieldInfoPtr_H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "H");
			NativeFieldInfoPtr_thisGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "thisGrid");
			NativeFieldInfoPtr_preGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, "preGrid");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, 100666500);
			NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationData>.NativeClassPtr, 100666501);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96853, RefRangeEnd = 96856, XrefRangeStart = 96849, XrefRangeEnd = 96853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96859, RefRangeEnd = 96861, XrefRangeStart = 96856, XrefRangeEnd = 96859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NavigationData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_curUsedIdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_navigationDataPool;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MapNavigator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEmptyNavigationData_Private_NavigationData_GridUnitData_NavigationData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPool_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Navigate_Public_Boolean_BattleMapData_GridUnitData_GridUnitData_List_1_GridUnitData_List_1_GridUnitData_Int32_Int32_0;

	public unsafe static MapNavigator instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapNavigator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapNavigator));
		}
	}

	public unsafe int curUsedIdx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curUsedIdx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curUsedIdx)) = num;
		}
	}

	public unsafe List<NavigationData> navigationDataPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navigationDataPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NavigationData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navigationDataPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static MapNavigator Instance
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 96883, RefRangeEnd = 96888, XrefRangeStart = 96861, XrefRangeEnd = 96883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MapNavigator_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapNavigator>(intPtr) : null;
		}
	}

	static MapNavigator()
	{
		Il2CppClassPointerStore<MapNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MapNavigator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_curUsedIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, "curUsedIdx");
		NativeFieldInfoPtr_navigationDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, "navigationDataPool");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666494);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MapNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666495);
		NativeMethodInfoPtr_GetEmptyNavigationData_Private_NavigationData_GridUnitData_NavigationData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666496);
		NativeMethodInfoPtr_ResetPool_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666497);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666498);
		NativeMethodInfoPtr_Navigate_Public_Boolean_BattleMapData_GridUnitData_GridUnitData_List_1_GridUnitData_List_1_GridUnitData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr, 100666499);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapNavigator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNavigator>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96902, RefRangeEnd = 96904, XrefRangeStart = 96888, XrefRangeEnd = 96902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavigationData GetEmptyNavigationData(GridUnitData _thisGrid, NavigationData _preGrid, int _G, int _H)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_thisGrid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_preGrid);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_G;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_H;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEmptyNavigationData_Private_NavigationData_GridUnitData_NavigationData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavigationData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96904, XrefRangeEnd = 96907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPool_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96907, XrefRangeEnd = 96921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 96991, RefRangeEnd = 96996, XrefRangeStart = 96921, XrefRangeEnd = 96991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Navigate(BattleMapData battleMap, GridUnitData from, GridUnitData to, List<GridUnitData> path, List<GridUnitData> searched, int stepLimit, int selfTeamID = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)searched);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepLimit;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &selfTeamID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Navigate_Public_Boolean_BattleMapData_GridUnitData_GridUnitData_List_1_GridUnitData_List_1_GridUnitData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public MapNavigator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
