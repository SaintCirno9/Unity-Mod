using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class BMSymbol : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sequence;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteName;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_mIsValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_mWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_mAdvance;

	private static readonly System.IntPtr NativeFieldInfoPtr_mUV;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_advance_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_Boolean_INGUIAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string sequence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sequence);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sequence)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spriteName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe UISpriteData mSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UISpriteData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uISpriteData));
		}
	}

	public unsafe bool mIsValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mIsValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mIsValid)) = flag;
		}
	}

	public unsafe int mLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLength)) = num;
		}
	}

	public unsafe int mOffsetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffsetX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffsetX)) = num;
		}
	}

	public unsafe int mOffsetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffsetY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffsetY)) = num;
		}
	}

	public unsafe int mWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWidth)) = num;
		}
	}

	public unsafe int mHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHeight)) = num;
		}
	}

	public unsafe int mAdvance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAdvance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAdvance)) = num;
		}
	}

	public unsafe Rect mUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mUV);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mUV)) = rect;
		}
	}

	public unsafe int length
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 51653, RefRangeEnd = 51658, XrefRangeStart = 51653, XrefRangeEnd = 51653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int offsetX
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51658, RefRangeEnd = 51659, XrefRangeStart = 51658, XrefRangeEnd = 51658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int offsetY
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51659, RefRangeEnd = 51660, XrefRangeStart = 51659, XrefRangeEnd = 51659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int height
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int advance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_advance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Rect uvRect
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BMSymbol()
	{
		Il2CppClassPointerStore<BMSymbol>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BMSymbol");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr);
		NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "sequence");
		NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "spriteName");
		NativeFieldInfoPtr_mSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mSprite");
		NativeFieldInfoPtr_mIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mIsValid");
		NativeFieldInfoPtr_mLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mLength");
		NativeFieldInfoPtr_mOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mOffsetX");
		NativeFieldInfoPtr_mOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mOffsetY");
		NativeFieldInfoPtr_mWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mWidth");
		NativeFieldInfoPtr_mHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mHeight");
		NativeFieldInfoPtr_mAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mAdvance");
		NativeFieldInfoPtr_mUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, "mUV");
		NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_get_advance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_MarkAsChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_Validate_Public_Boolean_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr, 100664014);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 51660, RefRangeEnd = 51665, XrefRangeStart = 51660, XrefRangeEnd = 51660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51683, RefRangeEnd = 51685, XrefRangeStart = 51665, XrefRangeEnd = 51683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Validate(INGUIAtlas atlas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atlas);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_Boolean_INGUIAtlas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMSymbol()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BMSymbol>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BMSymbol(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
