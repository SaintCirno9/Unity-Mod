using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using UnityEngine;

namespace Il2Cpp;

public class SteamStatsAndAchievements : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateTime;

	private static readonly IntPtr NativeFieldInfoPtr_gameSetuped;

	private static readonly IntPtr NativeFieldInfoPtr_userID;

	private static readonly IntPtr NativeFieldInfoPtr_m_GameID;

	private static readonly IntPtr NativeFieldInfoPtr_m_bRequestedStats;

	private static readonly IntPtr NativeFieldInfoPtr_m_bStatsValid;

	private static readonly IntPtr NativeFieldInfoPtr_m_bStoreStats;

	private static readonly IntPtr NativeFieldInfoPtr_lastStoreTimeCount;

	private static readonly IntPtr NativeFieldInfoPtr_m_UserStatsReceived;

	private static readonly IntPtr NativeFieldInfoPtr_m_UserStatsStored;

	private static readonly IntPtr NativeFieldInfoPtr_m_UserAchievementStored;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SteamStatsAndAchievements_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SteamStatsReady_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckDLCState_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SteamStatsAndAchievements s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SteamStatsAndAchievements>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamStatsAndAchievements));
		}
	}

	public unsafe float UpdateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateTime)) = num;
		}
	}

	public unsafe bool gameSetuped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSetuped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSetuped)) = flag;
		}
	}

	public unsafe ulong userID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userID);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userID)) = num;
		}
	}

	public unsafe CGameID m_GameID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GameID);
			return *(CGameID*)num;
		}
		set
		{
			*(CGameID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GameID)) = cGameID;
		}
	}

	public unsafe bool m_bRequestedStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bRequestedStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bRequestedStats)) = flag;
		}
	}

	public unsafe bool m_bStatsValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bStatsValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bStatsValid)) = flag;
		}
	}

	public unsafe bool m_bStoreStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bStoreStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bStoreStats)) = flag;
		}
	}

	public unsafe float lastStoreTimeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStoreTimeCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStoreTimeCount)) = num;
		}
	}

	public unsafe Callback<UserStatsReceived_t> m_UserStatsReceived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserStatsReceived);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Callback<UserStatsReceived_t>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserStatsReceived)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback));
		}
	}

	public unsafe Callback<UserStatsStored_t> m_UserStatsStored
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserStatsStored);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Callback<UserStatsStored_t>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserStatsStored)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback));
		}
	}

	public unsafe Callback<UserAchievementStored_t> m_UserAchievementStored
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserAchievementStored);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Callback<UserAchievementStored_t>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserAchievementStored)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback));
		}
	}

	public unsafe static SteamStatsAndAchievements Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332480, RefRangeEnd = 332482, XrefRangeStart = 332470, XrefRangeEnd = 332480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SteamStatsAndAchievements_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SteamStatsAndAchievements>(intPtr) : null;
		}
	}

	static SteamStatsAndAchievements()
	{
		Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamStatsAndAchievements");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr);
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_UpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "UpdateTime");
		NativeFieldInfoPtr_gameSetuped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "gameSetuped");
		NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "userID");
		NativeFieldInfoPtr_m_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_GameID");
		NativeFieldInfoPtr_m_bRequestedStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_bRequestedStats");
		NativeFieldInfoPtr_m_bStatsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_bStatsValid");
		NativeFieldInfoPtr_m_bStoreStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_bStoreStats");
		NativeFieldInfoPtr_lastStoreTimeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "lastStoreTimeCount");
		NativeFieldInfoPtr_m_UserStatsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_UserStatsReceived");
		NativeFieldInfoPtr_m_UserStatsStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_UserStatsStored");
		NativeFieldInfoPtr_m_UserAchievementStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, "m_UserAchievementStored");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SteamStatsAndAchievements_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671710);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671711);
		NativeMethodInfoPtr_SteamStatsReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671712);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671713);
		NativeMethodInfoPtr_CheckDLCState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671714);
		NativeMethodInfoPtr_UnlockAchievement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671715);
		NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671716);
		NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671717);
		NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671718);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr, 100671719);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332482, XrefRangeEnd = 332545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 332549, RefRangeEnd = 332550, XrefRangeStart = 332545, XrefRangeEnd = 332549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SteamStatsReady()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamStatsReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332550, XrefRangeEnd = 332564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332564, XrefRangeEnd = 332613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDLCState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDLCState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332613, XrefRangeEnd = 332629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332629, XrefRangeEnd = 332654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserStatsReceived(UserStatsReceived_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pCallback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUserStatsReceived_Private_Void_UserStatsReceived_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332654, XrefRangeEnd = 332666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserStatsStored(UserStatsStored_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pCallback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUserStatsStored_Private_Void_UserStatsStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332666, XrefRangeEnd = 332704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementStored(UserAchievementStored_t pCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pCallback));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAchievementStored_Private_Void_UserAchievementStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamStatsAndAchievements()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamStatsAndAchievements>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SteamStatsAndAchievements(IntPtr pointer)
		: base(pointer)
	{
	}
}
