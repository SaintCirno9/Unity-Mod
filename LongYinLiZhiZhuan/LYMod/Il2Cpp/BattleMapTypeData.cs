using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class BattleMapTypeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battleMapType;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackAreaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_defenceHpRate;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeMapScaleRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttackAreaType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_Int32_Int32_0;

	public unsafe BattleMapType battleMapType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapType);
			return *(BattleMapType*)num;
		}
		set
		{
			*(BattleMapType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapType)) = battleMapType;
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

	public unsafe AttackAreaType attackAreaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAreaType);
			return *(AttackAreaType*)num;
		}
		set
		{
			*(AttackAreaType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAreaType)) = attackAreaType;
		}
	}

	public unsafe AreaData targetArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaData));
		}
	}

	public unsafe int difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty)) = num;
		}
	}

	public unsafe float defenceHpRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenceHpRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenceHpRate)) = num;
		}
	}

	static BattleMapTypeData()
	{
		Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattleMapTypeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr);
		NativeFieldInfoPtr_battleMapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "battleMapType");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "column");
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "row");
		NativeFieldInfoPtr_attackAreaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "attackAreaType");
		NativeFieldInfoPtr_targetArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "targetArea");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_defenceHpRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, "defenceHpRate");
		NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, 100666062);
		NativeMethodInfoPtr_GetTimeMapScaleRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, 100666063);
		NativeMethodInfoPtr__ctor_Public_Void_AttackAreaType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, 100666064);
		NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr, 100666065);
	}

	[CallerCount(68)]
	[CachedScanResults(RefRangeStart = 83658, RefRangeEnd = 83726, XrefRangeStart = 83636, XrefRangeEnd = 83658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleMapTypeData(BattleMapType _battleMapType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_battleMapType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83726, XrefRangeEnd = 83736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTimeMapScaleRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeMapScaleRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 83752, RefRangeEnd = 83762, XrefRangeStart = 83736, XrefRangeEnd = 83752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleMapTypeData(AttackAreaType _attackAreaType, int _difficulty)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_attackAreaType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_difficulty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AttackAreaType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83763, RefRangeEnd = 83764, XrefRangeStart = 83762, XrefRangeEnd = 83763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleMapTypeData(BattleMapType _battleMapType, int _column, int _row)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMapTypeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_battleMapType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_row;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleMapType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleMapTypeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
