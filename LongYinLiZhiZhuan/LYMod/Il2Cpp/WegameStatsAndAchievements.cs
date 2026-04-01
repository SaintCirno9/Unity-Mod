using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2Cpprail;
using UnityEngine;

namespace Il2Cpp;

public class WegameStatsAndAchievements : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_achievement_helper_;

	private static readonly IntPtr NativeFieldInfoPtr_global_achievement_;

	private static readonly IntPtr NativeFieldInfoPtr_player_achievement_;

	private static readonly IntPtr NativeFieldInfoPtr_rail_util_;

	private static readonly IntPtr NativeFieldInfoPtr_instance_;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WegameStatsAndAchievements_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckDLCState_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerID_Private_RailID_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRailEvent_Public_Void_RAILEventID_EventBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitGlobalAchivement_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitPlayerAchivement_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllAchievement_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_QueryPlayerAchievement_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeAchievement_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_AsyncTriggerAchievementProgress_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetPlayerAchievement_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearPlayerAchievement_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IRailAchievementHelper achievement_helper_
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievement_helper_);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRailAchievementHelper>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievement_helper_)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)railAchievementHelper));
		}
	}

	public unsafe IRailGlobalAchievement global_achievement_
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_global_achievement_);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRailGlobalAchievement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_global_achievement_)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)railGlobalAchievement));
		}
	}

	public unsafe IRailPlayerAchievement player_achievement_
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player_achievement_);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRailPlayerAchievement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player_achievement_)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)railPlayerAchievement));
		}
	}

	public unsafe IRailUtils rail_util_
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rail_util_);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRailUtils>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rail_util_)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)railUtils));
		}
	}

	public unsafe static WegameStatsAndAchievements instance_
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance_, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WegameStatsAndAchievements>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance_, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wegameStatsAndAchievements));
		}
	}

	public unsafe static WegameStatsAndAchievements Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341626, RefRangeEnd = 341628, XrefRangeStart = 341616, XrefRangeEnd = 341626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_WegameStatsAndAchievements_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WegameStatsAndAchievements>(intPtr) : null;
		}
	}

	static WegameStatsAndAchievements()
	{
		Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WegameStatsAndAchievements");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr);
		NativeFieldInfoPtr_achievement_helper_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, "achievement_helper_");
		NativeFieldInfoPtr_global_achievement_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, "global_achievement_");
		NativeFieldInfoPtr_player_achievement_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, "player_achievement_");
		NativeFieldInfoPtr_rail_util_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, "rail_util_");
		NativeFieldInfoPtr_instance_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, "instance_");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_WegameStatsAndAchievements_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672106);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672107);
		NativeMethodInfoPtr_CheckDLCState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672108);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672109);
		NativeMethodInfoPtr_GetPlayerID_Private_RailID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672110);
		NativeMethodInfoPtr_OnRailEvent_Public_Void_RAILEventID_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672111);
		NativeMethodInfoPtr_InitGlobalAchivement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672112);
		NativeMethodInfoPtr_InitPlayerAchivement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672113);
		NativeMethodInfoPtr_GetAllAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672114);
		NativeMethodInfoPtr_QueryPlayerAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672115);
		NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672116);
		NativeMethodInfoPtr_MakeAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672117);
		NativeMethodInfoPtr_AsyncTriggerAchievementProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672118);
		NativeMethodInfoPtr_ResetPlayerAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672119);
		NativeMethodInfoPtr_ClearPlayerAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672120);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr, 100672121);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341628, XrefRangeEnd = 341690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 341763, RefRangeEnd = 341764, XrefRangeStart = 341690, XrefRangeEnd = 341763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDLCState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDLCState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341764, XrefRangeEnd = 341772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341772, XrefRangeEnd = 341786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RailID GetPlayerID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerID_Private_RailID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RailID>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341786, XrefRangeEnd = 341885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRailEvent(RAILEventID id, EventBase data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&id);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRailEvent_Public_Void_RAILEventID_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341885, XrefRangeEnd = 341921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGlobalAchivement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGlobalAchivement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 341973, RefRangeEnd = 341974, XrefRangeStart = 341921, XrefRangeEnd = 341973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPlayerAchivement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPlayerAchivement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342013, RefRangeEnd = 342014, XrefRangeStart = 341974, XrefRangeEnd = 342013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAllAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 342059, RefRangeEnd = 342061, XrefRangeStart = 342014, XrefRangeEnd = 342059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueryPlayerAchievement(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryPlayerAchievement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342061, XrefRangeEnd = 342096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAchievement(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342096, XrefRangeEnd = 342120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeAchievement(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeAchievement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342154, RefRangeEnd = 342155, XrefRangeStart = 342120, XrefRangeEnd = 342154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AsyncTriggerAchievementProgress(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsyncTriggerAchievementProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342155, XrefRangeEnd = 342175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPlayerAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPlayerAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342175, XrefRangeEnd = 342199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearPlayerAchievement(int achID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&achID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPlayerAchievement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WegameStatsAndAchievements()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WegameStatsAndAchievements>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WegameStatsAndAchievements(IntPtr pointer)
		: base(pointer)
	{
	}
}
