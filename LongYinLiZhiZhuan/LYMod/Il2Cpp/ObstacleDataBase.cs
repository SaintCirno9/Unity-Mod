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
public class ObstacleDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_availableMapType;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleSpriteIDNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleHpRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_upOcclusionGrid;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraMapTypeRandomWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroySound;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroySpe;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryType;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryNum;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<BattleMapType> availableMapType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableMapType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleMapType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableMapType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe int obstacleSpriteIDNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleSpriteIDNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleSpriteIDNum)) = num;
		}
	}

	public unsafe List<int> obstacleHpRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleHpRange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleHpRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int upOcclusionGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upOcclusionGrid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upOcclusionGrid)) = num;
		}
	}

	public unsafe List<ObstacleMapTypeRandomWeightDataBase> extraMapTypeRandomWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraMapTypeRandomWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleMapTypeRandomWeightDataBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraMapTypeRandomWeight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string hitSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitSound);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitSound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string destroySound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroySound);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroySound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string destroySpe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroySpe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroySpe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float damageRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRate)) = num;
		}
	}

	public unsafe int injuryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryType)) = num;
		}
	}

	public unsafe float injuryNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryNum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryNum)) = num;
		}
	}

	static ObstacleDataBase()
	{
		Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObstacleDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_availableMapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "availableMapType");
		NativeFieldInfoPtr_obstacleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "obstacleName");
		NativeFieldInfoPtr_obstacleSpriteIDNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "obstacleSpriteIDNum");
		NativeFieldInfoPtr_obstacleHpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "obstacleHpRange");
		NativeFieldInfoPtr_upOcclusionGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "upOcclusionGrid");
		NativeFieldInfoPtr_extraMapTypeRandomWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "extraMapTypeRandomWeight");
		NativeFieldInfoPtr_hitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "hitSound");
		NativeFieldInfoPtr_destroySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "destroySound");
		NativeFieldInfoPtr_destroySpe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "destroySpe");
		NativeFieldInfoPtr_damageRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "damageRate");
		NativeFieldInfoPtr_injuryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "injuryType");
		NativeFieldInfoPtr_injuryNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, "injuryNum");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, 100666476);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr, 100666477);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96625, XrefRangeEnd = 96640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96640, XrefRangeEnd = 96654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstacleDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObstacleDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
