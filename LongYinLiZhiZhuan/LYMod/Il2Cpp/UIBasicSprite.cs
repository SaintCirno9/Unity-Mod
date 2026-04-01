using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class UIBasicSprite : UIWidget
{
	[OriginalName("Assembly-CSharp.dll", "", "Type")]
	public enum Type
	{
		Simple,
		Sliced,
		Tiled,
		Filled,
		Advanced
	}

	[OriginalName("Assembly-CSharp.dll", "", "FillDirection")]
	public enum FillDirection
	{
		Horizontal,
		Vertical,
		Radial90,
		Radial180,
		Radial360
	}

	[OriginalName("Assembly-CSharp.dll", "", "AdvancedType")]
	public enum AdvancedType
	{
		Invisible,
		Sliced,
		Tiled
	}

	[OriginalName("Assembly-CSharp.dll", "", "Flip")]
	public enum Flip
	{
		Nothing,
		Horizontally,
		Vertically,
		Both
	}

	private static readonly IntPtr NativeFieldInfoPtr_mType;

	private static readonly IntPtr NativeFieldInfoPtr_mFillDirection;

	private static readonly IntPtr NativeFieldInfoPtr_mFillAmount;

	private static readonly IntPtr NativeFieldInfoPtr_mInvert;

	private static readonly IntPtr NativeFieldInfoPtr_mFlip;

	private static readonly IntPtr NativeFieldInfoPtr_mApplyGradient;

	private static readonly IntPtr NativeFieldInfoPtr_mGradientTop;

	private static readonly IntPtr NativeFieldInfoPtr_mGradientBottom;

	private static readonly IntPtr NativeFieldInfoPtr_mInnerUV;

	private static readonly IntPtr NativeFieldInfoPtr_mOuterUV;

	private static readonly IntPtr NativeFieldInfoPtr_centerType;

	private static readonly IntPtr NativeFieldInfoPtr_leftType;

	private static readonly IntPtr NativeFieldInfoPtr_rightType;

	private static readonly IntPtr NativeFieldInfoPtr_bottomType;

	private static readonly IntPtr NativeFieldInfoPtr_topType;

	private static readonly IntPtr NativeFieldInfoPtr_mTempPos;

	private static readonly IntPtr NativeFieldInfoPtr_mTempUVs;

	private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_Virtual_New_get_Type_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_Virtual_New_set_Void_Type_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_flip_Public_get_Flip_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_flip_Public_set_Void_Flip_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_fillDirection_Public_get_FillDirection_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_fillDirection_Public_set_Void_FillDirection_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_premultipliedAlpha_Public_Virtual_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_pixelSize_Public_Virtual_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_padding_Protected_Virtual_New_get_Vector4_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_drawingUVs_Protected_get_Vector4_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_drawingColor_Protected_get_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_Fill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Rect_Rect_0;

	private static readonly IntPtr NativeMethodInfoPtr_SimpleFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_SlicedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddVertexColours_Private_Void_List_1_Color_byref_Color_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_TiledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_FilledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_AdvancedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Single_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector2_Single_Single_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Fill_Private_Static_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Single_Single_Single_Single_Single_Single_Single_Single_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe Type mType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mType);
			return *(Type*)num;
		}
		set
		{
			*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mType)) = type;
		}
	}

	public unsafe FillDirection mFillDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFillDirection);
			return *(FillDirection*)num;
		}
		set
		{
			*(FillDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFillDirection)) = fillDirection;
		}
	}

	public unsafe float mFillAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFillAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFillAmount)) = num;
		}
	}

	public unsafe bool mInvert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInvert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInvert)) = flag;
		}
	}

	public unsafe Flip mFlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFlip);
			return *(Flip*)num;
		}
		set
		{
			*(Flip*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFlip)) = flip;
		}
	}

	public unsafe bool mApplyGradient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mApplyGradient);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mApplyGradient)) = flag;
		}
	}

	public unsafe Color mGradientTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGradientTop);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGradientTop)) = color;
		}
	}

	public unsafe Color mGradientBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGradientBottom);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGradientBottom)) = color;
		}
	}

	public unsafe Rect mInnerUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInnerUV);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInnerUV)) = rect;
		}
	}

	public unsafe Rect mOuterUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOuterUV);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOuterUV)) = rect;
		}
	}

	public unsafe AdvancedType centerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerType);
			return *(AdvancedType*)num;
		}
		set
		{
			*(AdvancedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerType)) = advancedType;
		}
	}

	public unsafe AdvancedType leftType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftType);
			return *(AdvancedType*)num;
		}
		set
		{
			*(AdvancedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftType)) = advancedType;
		}
	}

	public unsafe AdvancedType rightType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightType);
			return *(AdvancedType*)num;
		}
		set
		{
			*(AdvancedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightType)) = advancedType;
		}
	}

	public unsafe AdvancedType bottomType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomType);
			return *(AdvancedType*)num;
		}
		set
		{
			*(AdvancedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomType)) = advancedType;
		}
	}

	public unsafe AdvancedType topType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topType);
			return *(AdvancedType*)num;
		}
		set
		{
			*(AdvancedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topType)) = advancedType;
		}
	}

	public unsafe static Il2CppStructArray<Vector2> mTempPos
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mTempPos, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mTempPos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<Vector2> mTempUVs
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mTempUVs, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mTempUVs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe virtual Type type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_type_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Type*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_type_Public_Virtual_New_set_Void_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Flip flip
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_flip_Public_get_Flip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Flip*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_flip_Public_set_Void_Flip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe FillDirection fillDirection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillDirection_Public_get_FillDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(FillDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58974, RefRangeEnd = 58976, XrefRangeStart = 58974, XrefRangeEnd = 58974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fillDirection_Public_set_Void_FillDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float fillAmount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58977, RefRangeEnd = 58978, XrefRangeStart = 58976, XrefRangeEnd = 58977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe override int minWidth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58983, RefRangeEnd = 58985, XrefRangeStart = 58978, XrefRangeEnd = 58983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override int minHeight
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58990, RefRangeEnd = 58992, XrefRangeStart = 58985, XrefRangeEnd = 58990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool invert
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58992, RefRangeEnd = 58993, XrefRangeStart = 58992, XrefRangeEnd = 58992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool hasBorder
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58993, RefRangeEnd = 58995, XrefRangeStart = 58993, XrefRangeEnd = 58993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual bool premultipliedAlpha
	{
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 58995, RefRangeEnd = 59068, XrefRangeStart = 58995, XrefRangeEnd = 58995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_premultipliedAlpha_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual float pixelSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_pixelSize_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual Vector4 padding
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59068, XrefRangeEnd = 59069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_padding_Protected_Virtual_New_get_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector4 drawingUVs
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59088, RefRangeEnd = 59091, XrefRangeStart = 59069, XrefRangeEnd = 59088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawingUVs_Protected_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Color drawingColor
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59091, XrefRangeEnd = 59095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawingColor_Protected_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIBasicSprite()
	{
		Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIBasicSprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr);
		NativeFieldInfoPtr_mType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mType");
		NativeFieldInfoPtr_mFillDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mFillDirection");
		NativeFieldInfoPtr_mFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mFillAmount");
		NativeFieldInfoPtr_mInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mInvert");
		NativeFieldInfoPtr_mFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mFlip");
		NativeFieldInfoPtr_mApplyGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mApplyGradient");
		NativeFieldInfoPtr_mGradientTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mGradientTop");
		NativeFieldInfoPtr_mGradientBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mGradientBottom");
		NativeFieldInfoPtr_mInnerUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mInnerUV");
		NativeFieldInfoPtr_mOuterUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mOuterUV");
		NativeFieldInfoPtr_centerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "centerType");
		NativeFieldInfoPtr_leftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "leftType");
		NativeFieldInfoPtr_rightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "rightType");
		NativeFieldInfoPtr_bottomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "bottomType");
		NativeFieldInfoPtr_topType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "topType");
		NativeFieldInfoPtr_mTempPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mTempPos");
		NativeFieldInfoPtr_mTempUVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, "mTempUVs");
		NativeMethodInfoPtr_get_type_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_set_type_Public_Virtual_New_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664396);
		NativeMethodInfoPtr_get_flip_Public_get_Flip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_set_flip_Public_set_Void_Flip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664398);
		NativeMethodInfoPtr_get_fillDirection_Public_get_FillDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_set_fillDirection_Public_set_Void_FillDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664401);
		NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664402);
		NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664403);
		NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664404);
		NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664405);
		NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664406);
		NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr_get_premultipliedAlpha_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr_get_pixelSize_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664409);
		NativeMethodInfoPtr_get_padding_Protected_Virtual_New_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_get_drawingUVs_Protected_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_get_drawingColor_Protected_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_Fill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_SimpleFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_SlicedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_AddVertexColours_Private_Void_List_1_Color_byref_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_TiledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_FilledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_AdvancedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector2_Single_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_Fill_Private_Static_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Single_Single_Single_Single_Single_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr, 100664423);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59110, RefRangeEnd = 59112, XrefRangeStart = 59095, XrefRangeEnd = 59110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &outer;
		*(Rect**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &inner;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 59159, RefRangeEnd = 59164, XrefRangeStart = 59112, XrefRangeEnd = 59159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref v);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref u);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimpleFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59264, RefRangeEnd = 59267, XrefRangeStart = 59164, XrefRangeEnd = 59264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color gc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref v);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref u);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref gc);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlicedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 59277, RefRangeEnd = 59281, XrefRangeStart = 59267, XrefRangeEnd = 59277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddVertexColours(List<Color> cols, ref Color color, int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref color);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVertexColours_Private_Void_List_1_Color_byref_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59326, RefRangeEnd = 59329, XrefRangeStart = 59281, XrefRangeEnd = 59326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref v);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TiledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59453, RefRangeEnd = 59456, XrefRangeStart = 59329, XrefRangeEnd = 59453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref v);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref u);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilledFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59576, RefRangeEnd = 59579, XrefRangeStart = 59456, XrefRangeEnd = 59576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref v);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref u);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvancedFill_Protected_Void_List_1_Vector3_List_1_Vector2_List_1_Color_byref_Vector4_byref_Vector4_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59580, RefRangeEnd = 59583, XrefRangeStart = 59579, XrefRangeEnd = 59580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RadialCut(Il2CppStructArray<Vector2> xy, Il2CppStructArray<Vector2> uv, float fill, bool invert, int corner)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xy);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uv);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &fill;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &invert;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &corner;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Single_Boolean_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59583, XrefRangeEnd = 59591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RadialCut(Il2CppStructArray<Vector2> xy, float cos, float sin, bool invert, int corner)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xy);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &cos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sin;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &invert;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &corner;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector2_Single_Single_Boolean_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 59618, RefRangeEnd = 59622, XrefRangeStart = 59591, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
		IntPtr* ptr = stackalloc IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &v0x;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &v1x;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &v0y;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &v1y;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &u0x;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &u1x;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &u0y;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)))) = &u1y;
		*(Color**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(IntPtr)))) = &col;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fill_Private_Static_Void_List_1_Vector3_List_1_Vector2_List_1_Color_Single_Single_Single_Single_Single_Single_Single_Single_Color_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59625, RefRangeEnd = 59628, XrefRangeStart = 59622, XrefRangeEnd = 59625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIBasicSprite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBasicSprite>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIBasicSprite(IntPtr pointer)
		: base(pointer)
	{
	}
}
