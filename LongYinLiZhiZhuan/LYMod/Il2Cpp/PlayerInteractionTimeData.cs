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
public class PlayerInteractionTimeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerInteractTimeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfBountyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfBountyMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_releaseHateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackPlayerTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_givePlayerGiftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_teachPlayerSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_invitePlayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_invitePlayType;

	private static readonly System.IntPtr NativeFieldInfoPtr_askItemTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_releasePlayerHateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_speMailMissionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_speMailMissionTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_loverUnhappy;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckGameUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe List<int> playerInteractTimeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractTimeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractTimeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int selfBountyType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfBountyType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfBountyType)) = num;
		}
	}

	public unsafe MissionData selfBountyMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfBountyMission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfBountyMission)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)missionData));
		}
	}

	public unsafe int releaseHateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseHateTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseHateTime)) = num;
		}
	}

	public unsafe int attackPlayerTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackPlayerTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackPlayerTime)) = num;
		}
	}

	public unsafe int givePlayerGiftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givePlayerGiftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givePlayerGiftTime)) = num;
		}
	}

	public unsafe bool teachPlayerSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teachPlayerSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teachPlayerSkill)) = flag;
		}
	}

	public unsafe int invitePlayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invitePlayTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invitePlayTime)) = num;
		}
	}

	public unsafe int invitePlayType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invitePlayType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invitePlayType)) = num;
		}
	}

	public unsafe int askItemTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askItemTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askItemTime)) = num;
		}
	}

	public unsafe int releasePlayerHateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releasePlayerHateTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releasePlayerHateTime)) = num;
		}
	}

	public unsafe int speMailMissionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMailMissionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMailMissionID)) = num;
		}
	}

	public unsafe string speMailMissionTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMailMissionTarget);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speMailMissionTarget)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool loverUnhappy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loverUnhappy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loverUnhappy)) = flag;
		}
	}

	static PlayerInteractionTimeData()
	{
		Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerInteractionTimeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr);
		NativeFieldInfoPtr_playerInteractTimeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "playerInteractTimeList");
		NativeFieldInfoPtr_selfBountyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "selfBountyType");
		NativeFieldInfoPtr_selfBountyMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "selfBountyMission");
		NativeFieldInfoPtr_releaseHateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "releaseHateTime");
		NativeFieldInfoPtr_attackPlayerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "attackPlayerTime");
		NativeFieldInfoPtr_givePlayerGiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "givePlayerGiftTime");
		NativeFieldInfoPtr_teachPlayerSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "teachPlayerSkill");
		NativeFieldInfoPtr_invitePlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "invitePlayTime");
		NativeFieldInfoPtr_invitePlayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "invitePlayType");
		NativeFieldInfoPtr_askItemTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "askItemTime");
		NativeFieldInfoPtr_releasePlayerHateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "releasePlayerHateTime");
		NativeFieldInfoPtr_speMailMissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "speMailMissionID");
		NativeFieldInfoPtr_speMailMissionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "speMailMissionTarget");
		NativeFieldInfoPtr_loverUnhappy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, "loverUnhappy");
		NativeMethodInfoPtr_ResetTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, 100667401);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, 100667402);
		NativeMethodInfoPtr_CheckGameUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, 100667403);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr, 100667404);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126202, RefRangeEnd = 126203, XrefRangeStart = 126191, XrefRangeEnd = 126202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126236, RefRangeEnd = 126237, XrefRangeStart = 126203, XrefRangeEnd = 126236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInteractionTimeData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInteractionTimeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126253, RefRangeEnd = 126254, XrefRangeStart = 126237, XrefRangeEnd = 126253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckGameUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126254, XrefRangeEnd = 126269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public PlayerInteractionTimeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
