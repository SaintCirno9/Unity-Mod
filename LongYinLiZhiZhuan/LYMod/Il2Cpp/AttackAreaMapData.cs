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
public class AttackAreaMapData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mapWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_towerRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeroNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraHpRate;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe List<int> towerRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_towerRow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_towerRow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int maxHeroNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeroNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeroNum)) = num;
		}
	}

	public unsafe float extraHpRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHpRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHpRate)) = num;
		}
	}

	static AttackAreaMapData()
	{
		Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AttackAreaMapData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr);
		NativeFieldInfoPtr_mapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, "mapWidth");
		NativeFieldInfoPtr_mapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, "mapHeight");
		NativeFieldInfoPtr_towerRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, "towerRow");
		NativeFieldInfoPtr_maxHeroNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, "maxHeroNum");
		NativeFieldInfoPtr_extraHpRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, "extraHpRate");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr, 100666060);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttackAreaMapData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackAreaMapData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AttackAreaMapData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
