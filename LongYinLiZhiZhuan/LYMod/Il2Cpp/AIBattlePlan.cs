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
public class AIBattlePlan : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battlePlanType;

	private static readonly System.IntPtr NativeFieldInfoPtr_bestPlanValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_useItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleAttackPlan;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIBattlePlanType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe AIBattlePlanType battlePlanType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlanType);
			return *(AIBattlePlanType*)num;
		}
		set
		{
			*(AIBattlePlanType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlanType)) = aIBattlePlanType;
		}
	}

	public unsafe float bestPlanValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPlanValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPlanValue)) = num;
		}
	}

	public unsafe GridUnitData moveTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gridUnitData));
		}
	}

	public unsafe ItemData useItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe List<AIBattleAttackPlan> battleAttackPlan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAttackPlan);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIBattleAttackPlan>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAttackPlan)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AIBattlePlan()
	{
		Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AIBattlePlan");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr);
		NativeFieldInfoPtr_battlePlanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, "battlePlanType");
		NativeFieldInfoPtr_bestPlanValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, "bestPlanValue");
		NativeFieldInfoPtr_moveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, "moveTarget");
		NativeFieldInfoPtr_useItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, "useItem");
		NativeFieldInfoPtr_battleAttackPlan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, "battleAttackPlan");
		NativeMethodInfoPtr__ctor_Public_Void_AIBattlePlanType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, 100668021);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr, 100668022);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 143996, RefRangeEnd = 144011, XrefRangeStart = 143988, XrefRangeEnd = 143996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIBattlePlan(AIBattlePlanType _battlePlanType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIBattlePlan>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_battlePlanType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AIBattlePlanType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144011, XrefRangeEnd = 144026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AIBattlePlan(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
