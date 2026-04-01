using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class BookTypeIconData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bookType;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillType;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookTypeIconPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_useBlackIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookTypeIconColor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int bookType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookType)) = num;
		}
	}

	public unsafe int skillType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType)) = num;
		}
	}

	public unsafe Vector2 bookTypeIconPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconPos)) = vector;
		}
	}

	public unsafe bool useBlackIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBlackIcon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBlackIcon)) = flag;
		}
	}

	public unsafe Color bookTypeIconColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookTypeIconColor)) = color;
		}
	}

	static BookTypeIconData()
	{
		Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BookTypeIconData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr);
		NativeFieldInfoPtr_bookType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, "bookType");
		NativeFieldInfoPtr_skillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, "skillType");
		NativeFieldInfoPtr_bookTypeIconPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, "bookTypeIconPos");
		NativeFieldInfoPtr_useBlackIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, "useBlackIcon");
		NativeFieldInfoPtr_bookTypeIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, "bookTypeIconColor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr, 100667959);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BookTypeIconData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BookTypeIconData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BookTypeIconData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
