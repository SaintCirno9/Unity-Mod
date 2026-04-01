using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class GridUnitController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_gridData;

	private static readonly IntPtr NativeFieldInfoPtr_obstacleObj;

	private static readonly IntPtr NativeFieldInfoPtr_wallSprite;

	private static readonly IntPtr NativeFieldInfoPtr_decorations;

	private static readonly IntPtr NativeFieldInfoPtr_speGridObj;

	private static readonly IntPtr NativeFieldInfoPtr_gridRenderType;

	private static readonly IntPtr NativeFieldInfoPtr_highLightRenderType;

	private static readonly IntPtr NativeFieldInfoPtr_tileRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_backRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_lineRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_coverRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_highlightRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_NearEnemyMoveRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_MoveRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_PathColor;

	private static readonly IntPtr NativeFieldInfoPtr_ObstacleBackColor;

	private static readonly IntPtr NativeFieldInfoPtr_AttackRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_AttackHitRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_CureRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_CureHitRangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_HoverHighlightColor;

	private static readonly IntPtr NativeFieldInfoPtr_AttackChooseHighlightColor;

	private static readonly IntPtr NativeFieldInfoPtr_CureChooseHighlightColor;

	private static readonly IntPtr NativeFieldInfoPtr_AttackDirectionColor;

	private static readonly IntPtr NativeFieldInfoPtr_showAttackDirectionRange;

	private static readonly IntPtr NativeMethodInfoPtr_set_GridRenderType_Public_set_Void_GridRenderType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GridRenderType_Public_get_GridRenderType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TriggerSpeObj_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshSpeObj_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DestroyObstacle_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitObstacle_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReinitDecoration_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnHit_Public_Void_BattleUnit_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnter_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLeave_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySpeObjHitAnim_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetWallBroken_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HitObstacle_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAroundObstacleGrid_Public_List_1_GridUnitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetObstacleDestroyed_Public_Void_GridUnitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetHighLightType_Public_Void_HighLightRenderType_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnHover_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GridUnitData gridData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GridUnitData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gridUnitData));
		}
	}

	public unsafe GameObject obstacleObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleObj);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject wallSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallSprite);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<GameObject> decorations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorations);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject speGridObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObj);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GridRenderType gridRenderType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridRenderType);
			return *(GridRenderType*)num;
		}
		set
		{
			*(GridRenderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridRenderType)) = gridRenderType;
		}
	}

	public unsafe HighLightRenderType highLightRenderType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightRenderType);
			return *(HighLightRenderType*)num;
		}
		set
		{
			*(HighLightRenderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightRenderType)) = highLightRenderType;
		}
	}

	public unsafe SpriteRenderer tileRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe SpriteRenderer backRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe SpriteRenderer lineRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe SpriteRenderer coverRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe SpriteRenderer highlightRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer));
		}
	}

	public unsafe static Color NearEnemyMoveRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NearEnemyMoveRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NearEnemyMoveRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color MoveRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoveRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoveRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color PathColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PathColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PathColor, (void*)(&color));
		}
	}

	public unsafe static Color ObstacleBackColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ObstacleBackColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ObstacleBackColor, (void*)(&color));
		}
	}

	public unsafe static Color AttackRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color AttackHitRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackHitRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackHitRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color CureRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CureRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CureRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color CureHitRangeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CureHitRangeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CureHitRangeColor, (void*)(&color));
		}
	}

	public unsafe static Color HoverHighlightColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HoverHighlightColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HoverHighlightColor, (void*)(&color));
		}
	}

	public unsafe static Color AttackChooseHighlightColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackChooseHighlightColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackChooseHighlightColor, (void*)(&color));
		}
	}

	public unsafe static Color CureChooseHighlightColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CureChooseHighlightColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CureChooseHighlightColor, (void*)(&color));
		}
	}

	public unsafe static List<Color> AttackDirectionColor
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackDirectionColor, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackDirectionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject showAttackDirectionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAttackDirectionRange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAttackDirectionRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GridRenderType GridRenderType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GridRenderType_Public_get_GridRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(GridRenderType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95701, RefRangeEnd = 95707, XrefRangeStart = 95700, XrefRangeEnd = 95701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GridRenderType_Public_set_Void_GridRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GridUnitController()
	{
		Il2CppClassPointerStore<GridUnitController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GridUnitController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr);
		NativeFieldInfoPtr_gridData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "gridData");
		NativeFieldInfoPtr_obstacleObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "obstacleObj");
		NativeFieldInfoPtr_wallSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "wallSprite");
		NativeFieldInfoPtr_decorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "decorations");
		NativeFieldInfoPtr_speGridObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "speGridObj");
		NativeFieldInfoPtr_gridRenderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "gridRenderType");
		NativeFieldInfoPtr_highLightRenderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "highLightRenderType");
		NativeFieldInfoPtr_tileRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "tileRenderer");
		NativeFieldInfoPtr_backRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "backRenderer");
		NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "lineRenderer");
		NativeFieldInfoPtr_coverRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "coverRenderer");
		NativeFieldInfoPtr_highlightRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "highlightRenderer");
		NativeFieldInfoPtr_NearEnemyMoveRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "NearEnemyMoveRangeColor");
		NativeFieldInfoPtr_MoveRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "MoveRangeColor");
		NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "PathColor");
		NativeFieldInfoPtr_ObstacleBackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "ObstacleBackColor");
		NativeFieldInfoPtr_AttackRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "AttackRangeColor");
		NativeFieldInfoPtr_AttackHitRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "AttackHitRangeColor");
		NativeFieldInfoPtr_CureRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "CureRangeColor");
		NativeFieldInfoPtr_CureHitRangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "CureHitRangeColor");
		NativeFieldInfoPtr_HoverHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "HoverHighlightColor");
		NativeFieldInfoPtr_AttackChooseHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "AttackChooseHighlightColor");
		NativeFieldInfoPtr_CureChooseHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "CureChooseHighlightColor");
		NativeFieldInfoPtr_AttackDirectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "AttackDirectionColor");
		NativeFieldInfoPtr_showAttackDirectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, "showAttackDirectionRange");
		NativeMethodInfoPtr_set_GridRenderType_Public_set_Void_GridRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666447);
		NativeMethodInfoPtr_get_GridRenderType_Public_get_GridRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666448);
		NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666449);
		NativeMethodInfoPtr_TriggerSpeObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666450);
		NativeMethodInfoPtr_RefreshSpeObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666451);
		NativeMethodInfoPtr_DestroyObstacle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666452);
		NativeMethodInfoPtr_InitObstacle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666453);
		NativeMethodInfoPtr_ReinitDecoration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666454);
		NativeMethodInfoPtr_OnHit_Public_Void_BattleUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666455);
		NativeMethodInfoPtr_OnEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666456);
		NativeMethodInfoPtr_OnLeave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666457);
		NativeMethodInfoPtr_PlaySpeObjHitAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666458);
		NativeMethodInfoPtr_SetWallBroken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666459);
		NativeMethodInfoPtr_HitObstacle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666460);
		NativeMethodInfoPtr_GetAroundObstacleGrid_Public_List_1_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666461);
		NativeMethodInfoPtr_SetObstacleDestroyed_Public_Void_GridUnitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666462);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666463);
		NativeMethodInfoPtr_SetHighLightType_Public_Void_HighLightRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666464);
		NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666465);
		NativeMethodInfoPtr_OnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666466);
		NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666467);
		NativeMethodInfoPtr_OnScroll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666468);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr, 100666469);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 95793, RefRangeEnd = 95798, XrefRangeStart = 95707, XrefRangeEnd = 95793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95863, RefRangeEnd = 95864, XrefRangeStart = 95798, XrefRangeEnd = 95863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerSpeObj()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerSpeObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95918, RefRangeEnd = 95919, XrefRangeStart = 95864, XrefRangeEnd = 95918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSpeObj()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSpeObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95926, RefRangeEnd = 95927, XrefRangeStart = 95919, XrefRangeEnd = 95926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyObstacle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyObstacle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96000, RefRangeEnd = 96001, XrefRangeStart = 95927, XrefRangeEnd = 96000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitObstacle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitObstacle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96051, RefRangeEnd = 96052, XrefRangeStart = 96001, XrefRangeEnd = 96051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReinitDecoration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitDecoration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96071, RefRangeEnd = 96072, XrefRangeStart = 96052, XrefRangeEnd = 96071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHit(BattleUnit nowActiveUnit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nowActiveUnit);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHit_Public_Void_BattleUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96072, XrefRangeEnd = 96073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLeave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 96106, RefRangeEnd = 96111, XrefRangeStart = 96073, XrefRangeEnd = 96106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySpeObjHitAnim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySpeObjHitAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96135, RefRangeEnd = 96138, XrefRangeStart = 96111, XrefRangeEnd = 96135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWallBroken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWallBroken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96348, RefRangeEnd = 96349, XrefRangeStart = 96138, XrefRangeEnd = 96348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HitObstacle(float damage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&damage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HitObstacle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96375, RefRangeEnd = 96376, XrefRangeStart = 96349, XrefRangeEnd = 96375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GridUnitData> GetAroundObstacleGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAroundObstacleGrid_Public_List_1_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GridUnitData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96376, XrefRangeEnd = 96400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetObstacleDestroyed(GridUnitData targetGrid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetGrid);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetObstacleDestroyed_Public_Void_GridUnitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96400, XrefRangeEnd = 96535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 96548, RefRangeEnd = 96552, XrefRangeStart = 96535, XrefRangeEnd = 96548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHighLightType(HighLightRenderType targetType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&targetType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHighLightType_Public_Void_HighLightRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96552, XrefRangeEnd = 96563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4532)]
	[CachedScanResults(RefRangeStart = 18, RefRangeEnd = 4550, XrefRangeStart = 18, XrefRangeEnd = 4550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHover()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96563, XrefRangeEnd = 96573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96573, XrefRangeEnd = 96583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScroll(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScroll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridUnitController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridUnitController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GridUnitController(IntPtr pointer)
		: base(pointer)
	{
	}
}
