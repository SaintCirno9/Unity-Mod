using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;

namespace Il2Cpp;

public static class NGUIText : Il2CppSystem.Object
{
	[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
	public enum Alignment
	{
		Automatic,
		Left,
		Center,
		Right,
		Justified
	}

	[OriginalName("Assembly-CSharp.dll", "", "SymbolStyle")]
	public enum SymbolStyle
	{
		None,
		Normal,
		Colored,
		NoOutline
	}

	public class GlyphInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_v0;

		private static readonly System.IntPtr NativeFieldInfoPtr_v1;

		private static readonly System.IntPtr NativeFieldInfoPtr_u0;

		private static readonly System.IntPtr NativeFieldInfoPtr_u1;

		private static readonly System.IntPtr NativeFieldInfoPtr_u2;

		private static readonly System.IntPtr NativeFieldInfoPtr_u3;

		private static readonly System.IntPtr NativeFieldInfoPtr_advance;

		private static readonly System.IntPtr NativeFieldInfoPtr_channel;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 v0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v0);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v0)) = vector;
			}
		}

		public unsafe Vector2 v1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1)) = vector;
			}
		}

		public unsafe Vector2 u0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u0);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u0)) = vector;
			}
		}

		public unsafe Vector2 u1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u1);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u1)) = vector;
			}
		}

		public unsafe Vector2 u2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u2)) = vector;
			}
		}

		public unsafe Vector2 u3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u3);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u3)) = vector;
			}
		}

		public unsafe float advance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advance)) = num;
			}
		}

		public unsafe int channel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channel)) = num;
			}
		}

		static GlyphInfo()
		{
			Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "GlyphInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr);
			NativeFieldInfoPtr_v0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "v0");
			NativeFieldInfoPtr_v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "v1");
			NativeFieldInfoPtr_u0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "u0");
			NativeFieldInfoPtr_u1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "u1");
			NativeFieldInfoPtr_u2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "u2");
			NativeFieldInfoPtr_u3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "u3");
			NativeFieldInfoPtr_advance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "advance");
			NativeFieldInfoPtr_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, "channel");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr, 100664236);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GlyphInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_bitmapFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_glyph;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_tint;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_gradient;

	private static readonly System.IntPtr NativeFieldInfoPtr_gradientBottom;

	private static readonly System.IntPtr NativeFieldInfoPtr_gradientTop;

	private static readonly System.IntPtr NativeFieldInfoPtr_encoding;

	private static readonly System.IntPtr NativeFieldInfoPtr_spacingX;

	private static readonly System.IntPtr NativeFieldInfoPtr_spacingY;

	private static readonly System.IntPtr NativeFieldInfoPtr_premultiply;

	private static readonly System.IntPtr NativeFieldInfoPtr_symbolStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalSpacingX;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalLineHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseline;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSymbols;

	private static readonly System.IntPtr NativeFieldInfoPtr_mInvisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_mColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_mAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_mTempChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSB;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_c0;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_c1;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeShrinkage;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBoldOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDynamic_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSymbol_Public_Static_BMSymbol_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphWidth_Public_Static_Single_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyph_Public_Static_GlyphInfo_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAlpha_Public_Static_Single_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseColor24_Public_Static_Color_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseColor32_Public_Static_Color_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColor_Public_Static_String_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeAlpha_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColor24_Public_Static_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColor32_Public_Static_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHex_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_BetterList_1_Color_Boolean_byref_Int32_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Align_Public_Static_Void_List_1_Vector3_Int32_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExactCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetApproximateCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSpace_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndLine_Public_Static_Void_byref_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceSpaceWithNewline_Private_Static_Void_byref_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePrintedSize_Public_Static_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateOffsetToFit_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEndOfLineThatFits_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Print_Public_Static_Void_String_List_1_Vector3_List_1_Vector2_List_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintApproximateCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintExactCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintCaretAndSelection_Public_Static_Void_String_Int32_Int32_List_1_Vector3_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceLink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertHyperlink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceLinks_Public_Static_Void_byref_String_String_String_0;

	public unsafe static INGUIFont bitmapFont
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bitmapFont, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<INGUIFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bitmapFont, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iNGUIFont));
		}
	}

	public unsafe static Font dynamicFont
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dynamicFont, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dynamicFont, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font));
		}
	}

	public unsafe static GlyphInfo glyph
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_glyph, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GlyphInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_glyph, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphInfo));
		}
	}

	public unsafe static int fontSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontSize, (void*)(&num));
		}
	}

	public unsafe static float fontScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontScale, (void*)(&num));
		}
	}

	public unsafe static float pixelDensity
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pixelDensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pixelDensity, (void*)(&num));
		}
	}

	public unsafe static FontStyle fontStyle
	{
		get
		{
			Unsafe.SkipInit(out FontStyle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontStyle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontStyle, (void*)(&fontStyle));
		}
	}

	public unsafe static Alignment alignment
	{
		get
		{
			Unsafe.SkipInit(out Alignment result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alignment, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alignment, (void*)(&alignment));
		}
	}

	public unsafe static Color tint
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tint, (void*)(&color));
		}
	}

	public unsafe static int rectWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rectWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rectWidth, (void*)(&num));
		}
	}

	public unsafe static int rectHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rectHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rectHeight, (void*)(&num));
		}
	}

	public unsafe static int regionWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionWidth, (void*)(&num));
		}
	}

	public unsafe static int regionHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionHeight, (void*)(&num));
		}
	}

	public unsafe static int maxLines
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxLines, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxLines, (void*)(&num));
		}
	}

	public unsafe static bool gradient
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gradient, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gradient, (void*)(&flag));
		}
	}

	public unsafe static Color gradientBottom
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gradientBottom, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gradientBottom, (void*)(&color));
		}
	}

	public unsafe static Color gradientTop
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gradientTop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gradientTop, (void*)(&color));
		}
	}

	public unsafe static bool encoding
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_encoding, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_encoding, (void*)(&flag));
		}
	}

	public unsafe static float spacingX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spacingX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spacingX, (void*)(&num));
		}
	}

	public unsafe static float spacingY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spacingY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spacingY, (void*)(&num));
		}
	}

	public unsafe static bool premultiply
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_premultiply, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_premultiply, (void*)(&flag));
		}
	}

	public unsafe static SymbolStyle symbolStyle
	{
		get
		{
			Unsafe.SkipInit(out SymbolStyle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_symbolStyle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_symbolStyle, (void*)(&symbolStyle));
		}
	}

	public unsafe static int finalSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finalSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finalSize, (void*)(&num));
		}
	}

	public unsafe static float finalSpacingX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finalSpacingX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finalSpacingX, (void*)(&num));
		}
	}

	public unsafe static float finalLineHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finalLineHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finalLineHeight, (void*)(&num));
		}
	}

	public unsafe static float baseline
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseline, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseline, (void*)(&num));
		}
	}

	public unsafe static bool useSymbols
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useSymbols, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useSymbols, (void*)(&flag));
		}
	}

	public unsafe static Color mInvisible
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mInvisible, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mInvisible, (void*)(&color));
		}
	}

	public unsafe static BetterList<Color> mColors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mColors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BetterList<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mColors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)betterList));
		}
	}

	public unsafe static float mAlpha
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mAlpha, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mAlpha, (void*)(&num));
		}
	}

	public unsafe static CharacterInfo mTempChar
	{
		get
		{
			Unsafe.SkipInit(out CharacterInfo result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mTempChar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mTempChar, (void*)(&characterInfo));
		}
	}

	public unsafe static BetterList<float> mSizes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mSizes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BetterList<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mSizes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)betterList));
		}
	}

	public unsafe static StringBuilder mSB
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mSB, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mSB, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilder));
		}
	}

	public unsafe static Color s_c0
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_c0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_c0, (void*)(&color));
		}
	}

	public unsafe static Color s_c1
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_c1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_c1, (void*)(&color));
		}
	}

	public unsafe static float sizeShrinkage
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sizeShrinkage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sizeShrinkage, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<float> mBoldOffset
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mBoldOffset, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mBoldOffset, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isDynamic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54076, XrefRangeEnd = 54080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDynamic_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NGUIText()
	{
		Il2CppClassPointerStore<NGUIText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NGUIText");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NGUIText>.NativeClassPtr);
		NativeFieldInfoPtr_bitmapFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "bitmapFont");
		NativeFieldInfoPtr_dynamicFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "dynamicFont");
		NativeFieldInfoPtr_glyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "glyph");
		NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "fontSize");
		NativeFieldInfoPtr_fontScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "fontScale");
		NativeFieldInfoPtr_pixelDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "pixelDensity");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "alignment");
		NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "tint");
		NativeFieldInfoPtr_rectWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "rectWidth");
		NativeFieldInfoPtr_rectHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "rectHeight");
		NativeFieldInfoPtr_regionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "regionWidth");
		NativeFieldInfoPtr_regionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "regionHeight");
		NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "maxLines");
		NativeFieldInfoPtr_gradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "gradient");
		NativeFieldInfoPtr_gradientBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "gradientBottom");
		NativeFieldInfoPtr_gradientTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "gradientTop");
		NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "encoding");
		NativeFieldInfoPtr_spacingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "spacingX");
		NativeFieldInfoPtr_spacingY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "spacingY");
		NativeFieldInfoPtr_premultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "premultiply");
		NativeFieldInfoPtr_symbolStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "symbolStyle");
		NativeFieldInfoPtr_finalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "finalSize");
		NativeFieldInfoPtr_finalSpacingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "finalSpacingX");
		NativeFieldInfoPtr_finalLineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "finalLineHeight");
		NativeFieldInfoPtr_baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "baseline");
		NativeFieldInfoPtr_useSymbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "useSymbols");
		NativeFieldInfoPtr_mInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mInvisible");
		NativeFieldInfoPtr_mColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mColors");
		NativeFieldInfoPtr_mAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mAlpha");
		NativeFieldInfoPtr_mTempChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mTempChar");
		NativeFieldInfoPtr_mSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mSizes");
		NativeFieldInfoPtr_mSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mSB");
		NativeFieldInfoPtr_s_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "s_c0");
		NativeFieldInfoPtr_s_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "s_c1");
		NativeFieldInfoPtr_sizeShrinkage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "sizeShrinkage");
		NativeFieldInfoPtr_mBoldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, "mBoldOffset");
		NativeMethodInfoPtr_get_isDynamic_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_Update_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_Prepare_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_GetSymbol_Public_Static_BMSymbol_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_GetGlyphWidth_Public_Static_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_GetGlyph_Public_Static_GlyphInfo_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_ParseAlpha_Public_Static_Single_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_ParseColor24_Public_Static_Color_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_ParseColor32_Public_Static_Color_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_EncodeColor_Public_Static_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_EncodeAlpha_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_EncodeColor24_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_EncodeColor32_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_IsHex_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_BetterList_1_Color_Boolean_byref_Int32_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_Align_Public_Static_Void_List_1_Vector3_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_GetExactCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_GetApproximateCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_IsSpace_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_EndLine_Public_Static_Void_byref_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_ReplaceSpaceWithNewline_Private_Static_Void_byref_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_CalculatePrintedSize_Public_Static_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_CalculateOffsetToFit_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_GetEndOfLineThatFits_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_Print_Public_Static_Void_String_List_1_Vector3_List_1_Vector2_List_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_PrintApproximateCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_PrintExactCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_PrintCaretAndSelection_Public_Static_Void_String_Int32_Int32_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_ReplaceLink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_InsertHyperlink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_ReplaceLinks_Public_Static_Void_byref_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUIText>.NativeClassPtr, 100664234);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54084, RefRangeEnd = 54085, XrefRangeStart = 54080, XrefRangeEnd = 54084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54141, RefRangeEnd = 54143, XrefRangeStart = 54085, XrefRangeEnd = 54141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update(bool request)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&request);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 54159, RefRangeEnd = 54166, XrefRangeStart = 54143, XrefRangeEnd = 54159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Prepare(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 54171, RefRangeEnd = 54178, XrefRangeStart = 54166, XrefRangeEnd = 54171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSymbol_Public_Static_BMSymbol_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BMSymbol>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 54209, RefRangeEnd = 54215, XrefRangeStart = 54178, XrefRangeEnd = 54209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetGlyphWidth(int ch, int prev, float fontScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ch);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prev;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphWidth_Public_Static_Single_Int32_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54308, RefRangeEnd = 54311, XrefRangeStart = 54215, XrefRangeEnd = 54308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GlyphInfo GetGlyph(int ch, int prev, float fontScale = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ch);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prev;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyph_Public_Static_GlyphInfo_Int32_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GlyphInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54311, XrefRangeEnd = 54317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ParseAlpha(string text, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAlpha_Public_Static_Single_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54317, XrefRangeEnd = 54321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ParseColor(string text, int offset = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54334, RefRangeEnd = 54336, XrefRangeStart = 54321, XrefRangeEnd = 54334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ParseColor24(string text, int offset = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseColor24_Public_Static_Color_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54336, XrefRangeEnd = 54353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ParseColor32(string text, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseColor32_Public_Static_Color_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54358, RefRangeEnd = 54359, XrefRangeStart = 54353, XrefRangeEnd = 54358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeColor(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54359, XrefRangeEnd = 54408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeColor(string text, Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeColor_Public_Static_String_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54408, XrefRangeEnd = 54411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeAlpha(float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeAlpha_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54411, XrefRangeEnd = 54413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeColor24(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeColor24_Public_Static_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54413, XrefRangeEnd = 54415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeColor32(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeColor32_Public_Static_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54419, RefRangeEnd = 54420, XrefRangeStart = 54415, XrefRangeEnd = 54419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseSymbol(string text, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsHex(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHex_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 54491, RefRangeEnd = 54501, XrefRangeStart = 54420, XrefRangeEnd = 54491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &premultiply;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sub);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bold);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref italic);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref underline);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref strike);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ignoreColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSymbol_Public_Static_Boolean_String_byref_Int32_BetterList_1_Color_Boolean_byref_Int32_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54508, RefRangeEnd = 54510, XrefRangeStart = 54501, XrefRangeEnd = 54508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StripSymbols(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 54558, RefRangeEnd = 54575, XrefRangeStart = 54510, XrefRangeEnd = 54558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexOffset;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &printedWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &elements;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Align_Public_Static_Void_List_1_Vector3_Int32_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54575, XrefRangeEnd = 54582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetExactCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExactCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54589, RefRangeEnd = 54590, XrefRangeStart = 54582, XrefRangeEnd = 54589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetApproximateCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetApproximateCharacterIndex_Public_Static_Int32_List_1_Vector3_List_1_Int32_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsSpace(int ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSpace_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54598, RefRangeEnd = 54600, XrefRangeStart = 54590, XrefRangeEnd = 54598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndLine(ref StringBuilder s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndLine_Public_Static_Void_byref_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		s = ((intPtr4 == (System.IntPtr)0) ? null : new StringBuilder(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54606, RefRangeEnd = 54608, XrefRangeStart = 54600, XrefRangeEnd = 54606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceSpaceWithNewline_Private_Static_Void_byref_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		s = ((intPtr4 == (System.IntPtr)0) ? null : new StringBuilder(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54675, RefRangeEnd = 54678, XrefRangeStart = 54608, XrefRangeEnd = 54675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 CalculatePrintedSize(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculatePrintedSize_Public_Static_Vector2_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54734, RefRangeEnd = 54736, XrefRangeStart = 54678, XrefRangeEnd = 54734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateOffsetToFit(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateOffsetToFit_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54736, XrefRangeEnd = 54742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEndOfLineThatFits(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEndOfLineThatFits_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54746, RefRangeEnd = 54748, XrefRangeStart = 54742, XrefRangeEnd = 54746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapLineColors;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		finalText = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 55111, RefRangeEnd = 55115, XrefRangeStart = 54748, XrefRangeEnd = 55111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepCharCount;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapLineColors;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useEllipsis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapText_Public_Static_Boolean_String_byref_String_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		finalText = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55438, RefRangeEnd = 55439, XrefRangeStart = 55115, XrefRangeEnd = 55438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cols);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Print_Public_Static_Void_String_List_1_Vector3_List_1_Vector2_List_1_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55526, RefRangeEnd = 55528, XrefRangeStart = 55439, XrefRangeEnd = 55526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintApproximateCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55605, RefRangeEnd = 55606, XrefRangeStart = 55528, XrefRangeEnd = 55605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintExactCharacterPositions_Public_Static_Void_String_List_1_Vector3_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55763, RefRangeEnd = 55765, XrefRangeStart = 55606, XrefRangeEnd = 55763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caret);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)highlight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintCaretAndSelection_Public_Static_Void_String_Int32_Int32_List_1_Vector3_List_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55830, RefRangeEnd = 55833, XrefRangeStart = 55765, XrefRangeEnd = 55830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReplaceLink(ref string text, ref int index, string type, string prefix = null, string suffix = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceLink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		text = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55833, XrefRangeEnd = 55862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InsertHyperlink(ref string text, ref int index, string keyword, string link, string prefix = null, string suffix = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(link);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertHyperlink_Public_Static_Boolean_byref_String_byref_Int32_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		text = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55862, XrefRangeEnd = 55875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceLinks(ref string text, string prefix = null, string suffix = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceLinks_Public_Static_Void_byref_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		text = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public NGUIText(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
