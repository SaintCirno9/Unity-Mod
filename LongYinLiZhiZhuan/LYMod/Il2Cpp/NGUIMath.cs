using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public static class NGUIMath : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampIndex_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RepeatIndex_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapAngle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wrap01_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToHexChar_Public_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToHex8_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToHex24_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToHex32_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorToInt_Public_Static_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToBinary_Public_Static_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToColor_Public_Static_Color_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToTexCoords_Public_Static_Rect_Rect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToPixels_Public_Static_Rect_Rect_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstrainRect_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAbsoluteWidgetBounds_Public_Static_Bounds_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Private_Static_Void_Transform_Boolean_Boolean_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringDampen_Public_Static_Vector3_byref_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringDampen_Public_Static_Vector2_byref_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringLerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringLerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpringLerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistancePointToLineSegment_Private_Static_Single_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector3_Vector2_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPivotOffset_Public_Static_Vector2_Pivot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPivot_Public_Static_Pivot_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveWidget_Public_Static_Void_UIRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRect_Public_Static_Void_UIRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustByDPI_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToPixels_Public_Static_Vector2_Vector2_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToParentPixels_Public_Static_Vector2_Vector2_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToLocalPoint_Public_Static_Vector3_Vector3_Camera_Camera_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Transform_0;

	static NGUIMath()
	{
		Il2CppClassPointerStore<NGUIMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NGUIMath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr);
		NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_ClampIndex_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_RepeatIndex_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_WrapAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_Wrap01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_DecimalToHexChar_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_DecimalToHex8_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_DecimalToHex24_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_DecimalToHex32_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_ColorToInt_Public_Static_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_IntToBinary_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_HexToColor_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_ConvertToTexCoords_Public_Static_Rect_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_ConvertToPixels_Public_Static_Rect_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_ConstrainRect_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_CalculateAbsoluteWidgetBounds_Public_Static_Bounds_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Private_Static_Void_Transform_Boolean_Boolean_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_SpringDampen_Public_Static_Vector3_byref_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr_SpringDampen_Public_Static_Vector2_byref_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_SpringLerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_SpringLerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_SpringLerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_RotateTowards_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_DistancePointToLineSegment_Private_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664178);
		NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector3_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_GetPivotOffset_Public_Static_Vector2_Pivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_GetPivot_Public_Static_Pivot_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr_MoveWidget_Public_Static_Void_UIRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr_MoveRect_Public_Static_Void_UIRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_AdjustByDPI_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_ScreenToPixels_Public_Static_Vector2_Vector2_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_ScreenToParentPixels_Public_Static_Vector2_Vector2_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_WorldToLocalPoint_Public_Static_Vector3_Vector3_Camera_Camera_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIMath>.NativeClassPtr, 100664196);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 53563, RefRangeEnd = 53578, XrefRangeStart = 53563, XrefRangeEnd = 53563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Lerp(float from, float to, float factor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &factor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int ClampIndex(int val, int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampIndex_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 53578, RefRangeEnd = 53585, XrefRangeStart = 53578, XrefRangeEnd = 53578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RepeatIndex(int val, int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepeatIndex_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float WrapAngle(float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapAngle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53585, XrefRangeEnd = 53586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Wrap01(float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wrap01_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 53586, RefRangeEnd = 53605, XrefRangeStart = 53586, XrefRangeEnd = 53586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HexToDecimal(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static char DecimalToHexChar(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToHexChar_Public_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53608, RefRangeEnd = 53609, XrefRangeStart = 53605, XrefRangeEnd = 53608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecimalToHex8(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToHex8_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53612, RefRangeEnd = 53620, XrefRangeStart = 53609, XrefRangeEnd = 53612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecimalToHex24(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToHex24_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53623, RefRangeEnd = 53624, XrefRangeStart = 53620, XrefRangeEnd = 53623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecimalToHex32(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToHex32_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 53628, RefRangeEnd = 53637, XrefRangeStart = 53624, XrefRangeEnd = 53628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ColorToInt(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorToInt_Public_Static_Int32_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53637, XrefRangeEnd = 53638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color IntToColor(int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53638, XrefRangeEnd = 53645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IntToBinary(int val, int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToBinary_Public_Static_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53645, XrefRangeEnd = 53646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color HexToColor(uint val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToColor_Public_Static_Color_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 53654, RefRangeEnd = 53660, XrefRangeStart = 53646, XrefRangeEnd = 53654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToTexCoords_Public_Static_Rect_Rect_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53679, RefRangeEnd = 53680, XrefRangeStart = 53660, XrefRangeEnd = 53679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &round;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToPixels_Public_Static_Rect_Rect_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53680, XrefRangeEnd = 53692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect MakePixelPerfect(Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53692, XrefRangeEnd = 53724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Rect_Rect_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53725, RefRangeEnd = 53727, XrefRangeStart = 53724, XrefRangeEnd = 53725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minArea;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxArea;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstrainRect_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53742, RefRangeEnd = 53744, XrefRangeStart = 53727, XrefRangeEnd = 53742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAbsoluteWidgetBounds_Public_Static_Bounds_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53747, RefRangeEnd = 53750, XrefRangeStart = 53744, XrefRangeEnd = 53747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53751, RefRangeEnd = 53754, XrefRangeStart = 53750, XrefRangeEnd = 53751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53757, RefRangeEnd = 53762, XrefRangeStart = 53754, XrefRangeEnd = 53757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 53778, RefRangeEnd = 53785, XrefRangeStart = 53762, XrefRangeEnd = 53778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerChildren;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Public_Static_Bounds_Transform_Transform_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53807, RefRangeEnd = 53808, XrefRangeStart = 53785, XrefRangeEnd = 53807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRoot;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref toLocal);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vMin);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vMax);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isSet);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerChildren;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeWidgetBounds_Private_Static_Void_Transform_Boolean_Boolean_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53811, RefRangeEnd = 53816, XrefRangeStart = 53808, XrefRangeEnd = 53811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref velocity);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringDampen_Public_Static_Vector3_byref_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53819, RefRangeEnd = 53821, XrefRangeStart = 53816, XrefRangeEnd = 53819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref velocity);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringDampen_Public_Static_Vector2_byref_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53823, RefRangeEnd = 53826, XrefRangeStart = 53821, XrefRangeEnd = 53823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SpringLerp(float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&strength);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53829, RefRangeEnd = 53831, XrefRangeStart = 53826, XrefRangeEnd = 53829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringLerp_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53831, XrefRangeEnd = 53833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringLerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53835, RefRangeEnd = 53839, XrefRangeStart = 53833, XrefRangeEnd = 53835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringLerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53839, XrefRangeEnd = 53841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpringLerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53841, XrefRangeEnd = 53842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RotateTowards(float from, float to, float maxAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAngle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateTowards_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53842, XrefRangeEnd = 53847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&point);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistancePointToLineSegment_Private_Static_Single_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53853, RefRangeEnd = 53854, XrefRangeStart = 53847, XrefRangeEnd = 53853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistanceToRectangle(Il2CppStructArray<Vector2> screenPoints, Vector2 mousePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenPoints);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mousePos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53854, XrefRangeEnd = 53864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistanceToRectangle(Il2CppStructArray<Vector3> worldPoints, Vector2 mousePos, Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPoints);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mousePos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceToRectangle_Public_Static_Single_Il2CppStructArray_1_Vector3_Vector2_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 53867, RefRangeEnd = 53881, XrefRangeStart = 53864, XrefRangeEnd = 53867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPivotOffset_Public_Static_Vector2_Pivot_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53881, RefRangeEnd = 53882, XrefRangeStart = 53881, XrefRangeEnd = 53881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPivot_Public_Static_Pivot_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(UIWidget.Pivot*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53882, XrefRangeEnd = 53883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveWidget(UIRect w, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveWidget_Public_Static_Void_UIRect_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53902, RefRangeEnd = 53904, XrefRangeStart = 53883, XrefRangeEnd = 53902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveRect(UIRect rect, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRect_Public_Static_Void_UIRect_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53904, XrefRangeEnd = 53905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(UIWidget.Pivot**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53914, RefRangeEnd = 53916, XrefRangeStart = 53905, XrefRangeEnd = 53914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(UIWidget.Pivot**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeWidget_Public_Static_Void_UIWidget_Pivot_Single_Single_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53917, RefRangeEnd = 53919, XrefRangeStart = 53916, XrefRangeEnd = 53917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53919, XrefRangeEnd = 53920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53977, RefRangeEnd = 53980, XrefRangeStart = 53920, XrefRangeEnd = 53977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustWidget_Public_Static_Void_UIWidget_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53980, XrefRangeEnd = 53984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AdjustByDPI(float height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&height);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustByDPI_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53984, XrefRangeEnd = 53998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToPixels_Public_Static_Vector2_Vector2_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53998, XrefRangeEnd = 54021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToParentPixels_Public_Static_Vector2_Vector2_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54021, XrefRangeEnd = 54032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&worldPos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldCam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uiCam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToLocalPoint_Public_Static_Vector3_Vector3_Camera_Camera_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54042, RefRangeEnd = 54044, XrefRangeStart = 54032, XrefRangeEnd = 54042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldCam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myCam);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54055, RefRangeEnd = 54058, XrefRangeStart = 54044, XrefRangeEnd = 54055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldCam);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Vector3_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54058, XrefRangeEnd = 54076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OverlayPosition(this Transform trans, Transform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverlayPosition_Public_Static_Void_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NGUIMath(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
