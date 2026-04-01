using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class BigmapNpcController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_heroData;

	private static readonly IntPtr NativeFieldInfoPtr_CircleObj;

	private static readonly IntPtr NativeFieldInfoPtr_SafeSprite;

	private static readonly IntPtr NativeFieldInfoPtr_heroFollowTarget;

	private static readonly IntPtr NativeFieldInfoPtr_heroFollowType;

	private static readonly IntPtr NativeFieldInfoPtr_heroChaseTime;

	private static readonly IntPtr NativeFieldInfoPtr_followRangeRate;

	private static readonly IntPtr NativeFieldInfoPtr_heroStopChaseTime;

	private static readonly IntPtr NativeFieldInfoPtr_selfSkeleton;

	private static readonly IntPtr NativeFieldInfoPtr_heroSimpleSprite;

	private static readonly IntPtr NativeFieldInfoPtr_heroMissionTarget;

	private static readonly IntPtr NativeFieldInfoPtr_followers;

	private static readonly IntPtr NativeFieldInfoPtr_plotData;

	private static readonly IntPtr NativeFieldInfoPtr_hoverRangeCollider;

	private static readonly IntPtr NativeFieldInfoPtr_interactRangeCollider;

	private static readonly IntPtr NativeFieldInfoPtr_seeRangeCollider;

	private static readonly IntPtr NativeFieldInfoPtr_angle;

	private static readonly IntPtr NativeFieldInfoPtr_finalAngle;

	private static readonly IntPtr NativeFieldInfoPtr_finalRotation;

	private static readonly IntPtr NativeFieldInfoPtr_newObj;

	private static readonly IntPtr NativeFieldInfoPtr_needRefresh;

	private static readonly IntPtr NativeFieldInfoPtr_HeroFollowTypeText;

	private static readonly IntPtr NativeFieldInfoPtr_areaSafeRangeBuffer;

	private static readonly IntPtr NativeFieldInfoPtr_areaSafeRange;

	private static readonly IntPtr NativeFieldInfoPtr_areaSafeRangeRefreshTime;

	private static readonly IntPtr NativeFieldInfoPtr_leavingAreaSafeRange;

	private static readonly IntPtr NativeFieldInfoPtr_BigMapFightIcon;

	private static readonly IntPtr NativeFieldInfoPtr_BigMapFightIconPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_originSimpleSpriteScale;

	private static readonly IntPtr NativeFieldInfoPtr_originCapsuleColliderRadius;

	private static readonly IntPtr NativeFieldInfoPtr_originCapsuleColliderHeight;

	private static readonly IntPtr NativeFieldInfoPtr_originCapsuleColliderCenter;

	private static readonly IntPtr NativeFieldInfoPtr_inBigMapSpeEffectType;

	private static readonly IntPtr NativeFieldInfoPtr_inBigMapSpeEffectBuff;

	private static readonly IntPtr NativeFieldInfoPtr_inWaterBuff;

	private static readonly IntPtr NativeFieldInfoPtr_inMountainBuff;

	private static readonly IntPtr NativeFieldInfoPtr_inHillBuff;

	private static readonly IntPtr NativeFieldInfoPtr_checkBigMapColliderTime;

	private static readonly IntPtr NativeFieldInfoPtr_inited;

	private static readonly IntPtr NativeFieldInfoPtr_selfShowing;

	private static readonly IntPtr NativeFieldInfoPtr_selfDestroying;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsMoving_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshSkeletonAnim_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBigMapExtraScale_Public_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAllSkeletonActive_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HeroCanFollow_Public_Boolean_BigmapNpcController_HeroFollowType_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHeroTargetPos_Public_BigMapPos_0;

	private static readonly IntPtr NativeMethodInfoPtr_ConsiderHeroFollowType_Public_HeroFollowType_BigmapNpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_HeroData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkeletonRunAnim_Public_Void_GameObject_HeroData_Vector3_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_ManageFollowerMove_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkeletonIdleAnim_Public_Void_GameObject_HeroData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkeletonAttackAnim_Public_Void_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartSelfShow_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartSelfDestroy_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_InteractRangeObjStay_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearHeroFollowTarget_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetHeroIsEnemy_Public_Boolean_HeroData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SeeRangeObjStay_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__StartSelfShow_b__59_0_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__StartSelfDestroy_b__61_0_Private_Void_0;

	public unsafe HeroData heroData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroData));
		}
	}

	public unsafe GameObject CircleObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CircleObj);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CircleObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe SpriteRenderer SafeSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeSprite);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe GameObject heroFollowTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFollowTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFollowTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe HeroFollowType heroFollowType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFollowType);
			return *(HeroFollowType*)num;
		}
		set
		{
			*(HeroFollowType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFollowType)) = heroFollowType;
		}
	}

	public unsafe float heroChaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroChaseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroChaseTime)) = num;
		}
	}

	public unsafe float followRangeRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followRangeRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followRangeRate)) = num;
		}
	}

	public unsafe float heroStopChaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroStopChaseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroStopChaseTime)) = num;
		}
	}

	public unsafe GameObject selfSkeleton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfSkeleton);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfSkeleton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject heroSimpleSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroSimpleSprite);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroSimpleSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject heroMissionTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroMissionTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroMissionTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<BigMapFollower> followers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BigMapFollower>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SinglePlotData plotData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SinglePlotData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)singlePlotData));
		}
	}

	public unsafe CapsuleCollider hoverRangeCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoverRangeCollider);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoverRangeCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capsuleCollider));
		}
	}

	public unsafe CapsuleCollider interactRangeCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactRangeCollider);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactRangeCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capsuleCollider));
		}
	}

	public unsafe SphereCollider seeRangeCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seeRangeCollider);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seeRangeCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sphereCollider));
		}
	}

	public unsafe float angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
		}
	}

	public unsafe float finalAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalAngle)) = num;
		}
	}

	public unsafe Quaternion finalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRotation)) = quaternion;
		}
	}

	public unsafe GameObject newObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObj);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool needRefresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefresh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needRefresh)) = flag;
		}
	}

	public unsafe static List<string> HeroFollowTypeText
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroFollowTypeText, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroFollowTypeText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject areaSafeRangeBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRangeBuffer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRangeBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject areaSafeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float areaSafeRangeRefreshTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRangeRefreshTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaSafeRangeRefreshTime)) = num;
		}
	}

	public unsafe GameObject leavingAreaSafeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leavingAreaSafeRange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leavingAreaSafeRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject BigMapFightIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapFightIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapFightIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject BigMapFightIconPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapFightIconPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapFightIconPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float originSimpleSpriteScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originSimpleSpriteScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originSimpleSpriteScale)) = num;
		}
	}

	public unsafe float originCapsuleColliderRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderRadius)) = num;
		}
	}

	public unsafe float originCapsuleColliderHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderHeight)) = num;
		}
	}

	public unsafe Vector3 originCapsuleColliderCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderCenter);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originCapsuleColliderCenter)) = vector;
		}
	}

	public unsafe BigMapSpeEffectType inBigMapSpeEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBigMapSpeEffectType);
			return *(BigMapSpeEffectType*)num;
		}
		set
		{
			*(BigMapSpeEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBigMapSpeEffectType)) = bigMapSpeEffectType;
		}
	}

	public unsafe bool inBigMapSpeEffectBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBigMapSpeEffectBuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBigMapSpeEffectBuff)) = flag;
		}
	}

	public unsafe bool inWaterBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inWaterBuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inWaterBuff)) = flag;
		}
	}

	public unsafe bool inMountainBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inMountainBuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inMountainBuff)) = flag;
		}
	}

	public unsafe bool inHillBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inHillBuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inHillBuff)) = flag;
		}
	}

	public unsafe float checkBigMapColliderTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkBigMapColliderTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkBigMapColliderTime)) = num;
		}
	}

	public unsafe bool inited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited)) = flag;
		}
	}

	public unsafe bool selfShowing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfShowing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfShowing)) = flag;
		}
	}

	public unsafe bool selfDestroying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfDestroying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfDestroying)) = flag;
		}
	}

	static BigmapNpcController()
	{
		Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BigmapNpcController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr);
		NativeFieldInfoPtr_heroData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroData");
		NativeFieldInfoPtr_CircleObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "CircleObj");
		NativeFieldInfoPtr_SafeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "SafeSprite");
		NativeFieldInfoPtr_heroFollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroFollowTarget");
		NativeFieldInfoPtr_heroFollowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroFollowType");
		NativeFieldInfoPtr_heroChaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroChaseTime");
		NativeFieldInfoPtr_followRangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "followRangeRate");
		NativeFieldInfoPtr_heroStopChaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroStopChaseTime");
		NativeFieldInfoPtr_selfSkeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "selfSkeleton");
		NativeFieldInfoPtr_heroSimpleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroSimpleSprite");
		NativeFieldInfoPtr_heroMissionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "heroMissionTarget");
		NativeFieldInfoPtr_followers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "followers");
		NativeFieldInfoPtr_plotData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "plotData");
		NativeFieldInfoPtr_hoverRangeCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "hoverRangeCollider");
		NativeFieldInfoPtr_interactRangeCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "interactRangeCollider");
		NativeFieldInfoPtr_seeRangeCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "seeRangeCollider");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_finalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "finalAngle");
		NativeFieldInfoPtr_finalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "finalRotation");
		NativeFieldInfoPtr_newObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "newObj");
		NativeFieldInfoPtr_needRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "needRefresh");
		NativeFieldInfoPtr_HeroFollowTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "HeroFollowTypeText");
		NativeFieldInfoPtr_areaSafeRangeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "areaSafeRangeBuffer");
		NativeFieldInfoPtr_areaSafeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "areaSafeRange");
		NativeFieldInfoPtr_areaSafeRangeRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "areaSafeRangeRefreshTime");
		NativeFieldInfoPtr_leavingAreaSafeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "leavingAreaSafeRange");
		NativeFieldInfoPtr_BigMapFightIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "BigMapFightIcon");
		NativeFieldInfoPtr_BigMapFightIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "BigMapFightIconPrefab");
		NativeFieldInfoPtr_originSimpleSpriteScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "originSimpleSpriteScale");
		NativeFieldInfoPtr_originCapsuleColliderRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "originCapsuleColliderRadius");
		NativeFieldInfoPtr_originCapsuleColliderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "originCapsuleColliderHeight");
		NativeFieldInfoPtr_originCapsuleColliderCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "originCapsuleColliderCenter");
		NativeFieldInfoPtr_inBigMapSpeEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inBigMapSpeEffectType");
		NativeFieldInfoPtr_inBigMapSpeEffectBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inBigMapSpeEffectBuff");
		NativeFieldInfoPtr_inWaterBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inWaterBuff");
		NativeFieldInfoPtr_inMountainBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inMountainBuff");
		NativeFieldInfoPtr_inHillBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inHillBuff");
		NativeFieldInfoPtr_checkBigMapColliderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "checkBigMapColliderTime");
		NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "inited");
		NativeFieldInfoPtr_selfShowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "selfShowing");
		NativeFieldInfoPtr_selfDestroying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, "selfDestroying");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666607);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_IsMoving_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_RefreshSkeletonAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666611);
		NativeMethodInfoPtr_GetBigMapExtraScale_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_SetAllSkeletonActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_HeroCanFollow_Public_Boolean_BigmapNpcController_HeroFollowType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_GetHeroTargetPos_Public_BigMapPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_ConsiderHeroFollowType_Public_HeroFollowType_BigmapNpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_SetSkeletonRunAnim_Public_Void_GameObject_HeroData_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_ManageFollowerMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_SetSkeletonIdleAnim_Public_Void_GameObject_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_SetSkeletonAttackAnim_Public_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_StartSelfShow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_StartSelfDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_OnScroll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_InteractRangeObjStay_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_ClearHeroFollowTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_TargetHeroIsEnemy_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_SeeRangeObjStay_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr__StartSelfShow_b__59_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr__StartSelfDestroy_b__61_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr, 100666638);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99996, XrefRangeEnd = 100024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100024, XrefRangeEnd = 100047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100047, XrefRangeEnd = 100276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100276, RefRangeEnd = 100277, XrefRangeStart = 100276, XrefRangeEnd = 100276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMoving()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMoving_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100277, XrefRangeEnd = 100280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSkeletonAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSkeletonAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 100296, RefRangeEnd = 100301, XrefRangeStart = 100280, XrefRangeEnd = 100296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBigMapExtraScale(float extraScale = 2f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&extraScale);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBigMapExtraScale_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 100311, RefRangeEnd = 100313, XrefRangeStart = 100301, XrefRangeEnd = 100311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAllSkeletonActive(bool isActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isActive);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllSkeletonActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100332, RefRangeEnd = 100333, XrefRangeStart = 100313, XrefRangeEnd = 100332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HeroCanFollow(BigmapNpcController targetHero, HeroFollowType followType, float rangeRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(HeroFollowType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &followType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &rangeRate;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroCanFollow_Public_Boolean_BigmapNpcController_HeroFollowType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 100342, RefRangeEnd = 100349, XrefRangeStart = 100333, XrefRangeEnd = 100342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigMapPos GetHeroTargetPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroTargetPos_Public_BigMapPos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BigMapPos>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100349, XrefRangeEnd = 100359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroFollowType ConsiderHeroFollowType(BigmapNpcController target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsiderHeroFollowType_Public_HeroFollowType_BigmapNpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(HeroFollowType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 100361, RefRangeEnd = 100363, XrefRangeStart = 100359, XrefRangeEnd = 100361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBigMapTravelSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100363, XrefRangeEnd = 100365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBigMapTravelSpeed(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBigMapTravelSpeed_Public_Single_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 100408, RefRangeEnd = 100411, XrefRangeStart = 100365, XrefRangeEnd = 100408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonRunAnim(GameObject targetSkeleton, HeroData targetHero, Vector3 originPos, Vector2 nextPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &originPos;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &nextPos;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonRunAnim_Public_Void_GameObject_HeroData_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100511, RefRangeEnd = 100512, XrefRangeStart = 100411, XrefRangeEnd = 100511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageFollowerMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageFollowerMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 100538, RefRangeEnd = 100541, XrefRangeStart = 100512, XrefRangeEnd = 100538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonIdleAnim(GameObject targetSkeleton, HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonIdleAnim_Public_Void_GameObject_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 100565, RefRangeEnd = 100567, XrefRangeStart = 100541, XrefRangeEnd = 100565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkeletonAttackAnim(GameObject targetSkeleton, string targetAnim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetAnim);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonAttackAnim_Public_Void_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100668, RefRangeEnd = 100669, XrefRangeStart = 100567, XrefRangeEnd = 100668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHeroSkeleton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHeroSkeleton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100669, XrefRangeEnd = 100682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100682, XrefRangeEnd = 100700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSelfShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSelfShow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100719, RefRangeEnd = 100720, XrefRangeStart = 100700, XrefRangeEnd = 100719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSelfDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSelfDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100720, XrefRangeEnd = 100738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrag(Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScroll(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScroll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100798, RefRangeEnd = 100799, XrefRangeStart = 100738, XrefRangeEnd = 100798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InteractRangeObjStay(GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InteractRangeObjStay_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100800, RefRangeEnd = 100801, XrefRangeStart = 100799, XrefRangeEnd = 100800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearHeroFollowTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearHeroFollowTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100801, XrefRangeEnd = 100806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TargetHeroIsEnemy(HeroData targetHeroData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHeroData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetHeroIsEnemy_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100816, RefRangeEnd = 100817, XrefRangeStart = 100806, XrefRangeEnd = 100816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SeeRangeObjStay(GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SeeRangeObjStay_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100817, XrefRangeEnd = 100825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigmapNpcController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigmapNpcController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _StartSelfShow_b__59_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartSelfShow_b__59_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100825, XrefRangeEnd = 100830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _StartSelfDestroy_b__61_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartSelfDestroy_b__61_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BigmapNpcController(IntPtr pointer)
		: base(pointer)
	{
	}
}
