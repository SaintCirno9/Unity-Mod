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
public class InfoTabData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_infoText;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlasName;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoPic;

	private static readonly System.IntPtr NativeFieldInfoPtr_picColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundName;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Single_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string infoText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string atlasName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string infoPic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoPic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoPic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color picColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_picColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_picColor)) = color;
		}
	}

	public unsafe string soundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float volumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumn);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumn)) = num;
		}
	}

	public unsafe float lastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime)) = num;
		}
	}

	static InfoTabData()
	{
		Il2CppClassPointerStore<InfoTabData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InfoTabData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr);
		NativeFieldInfoPtr_infoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "infoText");
		NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "atlasName");
		NativeFieldInfoPtr_infoPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "infoPic");
		NativeFieldInfoPtr_picColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "picColor");
		NativeFieldInfoPtr_soundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "soundName");
		NativeFieldInfoPtr_volumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "volumn");
		NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, "lastTime");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, 100666994);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr, 100666995);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113308, XrefRangeEnd = 113322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoTabData(string _infoText, string _atlasName = "UIAtlas", string _infoPic = null, string _soundName = "Woosh", float _volumn = 1f, float _lastTime = 5f, Color _picColor = default(Color))
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfoTabData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_infoText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_atlasName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_infoPic);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_soundName);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_volumn;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &_lastTime;
		*(Color**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &_picColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Single_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113322, XrefRangeEnd = 113337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public InfoTabData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
