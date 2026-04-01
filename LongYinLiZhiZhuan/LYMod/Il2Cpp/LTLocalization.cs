using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp;

public class LTLocalization : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_ENGLISH;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_CHINESE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_TCHINESE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_JAPANESE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_GERMAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_RUSSIA;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE_PORTUGUESE;

	private static readonly System.IntPtr NativeFieldInfoPtr_FILE_PATH;

	private static readonly System.IntPtr NativeFieldInfoPtr_textData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mInstance;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNowSystemLanguage_Public_Static_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLanguageAB_Public_Static_String_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguage_Private_Void_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManualSetLanguage_Public_Static_Void_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Public_Static_Void_Text_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddText_Public_Static_Void_Text_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTextFont_Public_Static_Void_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextList_Public_Static_List_1_String_List_1_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_Boolean_0;

	public unsafe static string LANGUAGE_ENGLISH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_ENGLISH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_ENGLISH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_CHINESE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_CHINESE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_CHINESE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_TCHINESE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_TCHINESE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_TCHINESE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_JAPANESE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_JAPANESE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_JAPANESE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_GERMAN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_GERMAN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_GERMAN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_RUSSIA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_RUSSIA, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_RUSSIA, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LANGUAGE_PORTUGUESE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE_PORTUGUESE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE_PORTUGUESE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FILE_PATH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FILE_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FILE_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<string, string> textData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static LTLocalization mInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LTLocalization>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lTLocalization));
		}
	}

	static LTLocalization()
	{
		Il2CppClassPointerStore<LTLocalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LTLocalization");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr);
		NativeFieldInfoPtr_LANGUAGE_ENGLISH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_ENGLISH");
		NativeFieldInfoPtr_LANGUAGE_CHINESE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_CHINESE");
		NativeFieldInfoPtr_LANGUAGE_TCHINESE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_TCHINESE");
		NativeFieldInfoPtr_LANGUAGE_JAPANESE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_JAPANESE");
		NativeFieldInfoPtr_LANGUAGE_GERMAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_GERMAN");
		NativeFieldInfoPtr_LANGUAGE_RUSSIA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_RUSSIA");
		NativeFieldInfoPtr_LANGUAGE_PORTUGUESE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "LANGUAGE_PORTUGUESE");
		NativeFieldInfoPtr_FILE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "FILE_PATH");
		NativeFieldInfoPtr_textData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "textData");
		NativeFieldInfoPtr_mInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, "mInstance");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669449);
		NativeMethodInfoPtr_GetNowSystemLanguage_Public_Static_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669450);
		NativeMethodInfoPtr_GetLanguageAB_Public_Static_String_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669451);
		NativeMethodInfoPtr_ReadData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669452);
		NativeMethodInfoPtr_SetLanguage_Private_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669453);
		NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669454);
		NativeMethodInfoPtr_ManualSetLanguage_Public_Static_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669455);
		NativeMethodInfoPtr_SetText_Public_Static_Void_Text_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669456);
		NativeMethodInfoPtr_AddText_Public_Static_Void_Text_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669457);
		NativeMethodInfoPtr_CheckTextFont_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669458);
		NativeMethodInfoPtr_GetTextList_Public_Static_List_1_String_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669459);
		NativeMethodInfoPtr_GetText_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr, 100669460);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200999, RefRangeEnd = 201001, XrefRangeStart = 200991, XrefRangeEnd = 200999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTLocalization()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTLocalization>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201014, RefRangeEnd = 201015, XrefRangeStart = 201001, XrefRangeEnd = 201014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SystemLanguage GetNowSystemLanguage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNowSystemLanguage_Public_Static_SystemLanguage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SystemLanguage*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201015, XrefRangeEnd = 201019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLanguageAB(SystemLanguage language)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLanguageAB_Public_Static_String_SystemLanguage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201119, RefRangeEnd = 201121, XrefRangeStart = 201019, XrefRangeEnd = 201119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201135, RefRangeEnd = 201137, XrefRangeStart = 201121, XrefRangeEnd = 201135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLanguage(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLanguage_Private_Void_SystemLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201182, RefRangeEnd = 201184, XrefRangeStart = 201137, XrefRangeEnd = 201182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201208, RefRangeEnd = 201209, XrefRangeStart = 201184, XrefRangeEnd = 201208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ManualSetLanguage(SystemLanguage setLanguage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setLanguage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManualSetLanguage_Public_Static_Void_SystemLanguage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(470)]
	[CachedScanResults(RefRangeStart = 201212, RefRangeEnd = 201682, XrefRangeStart = 201209, XrefRangeEnd = 201212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetText(Text targetText, string targetValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetText_Public_Static_Void_Text_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(66)]
	[CachedScanResults(RefRangeStart = 201685, RefRangeEnd = 201751, XrefRangeStart = 201682, XrefRangeEnd = 201685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddText(Text targetText, string targetValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddText_Public_Static_Void_Text_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 201793, RefRangeEnd = 201823, XrefRangeStart = 201751, XrefRangeEnd = 201793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckTextFont(Text targetText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetText);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTextFont_Public_Static_Void_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201823, XrefRangeEnd = 201837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetTextList(List<string> keyList, bool justReplace = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &justReplace;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextList_Public_Static_List_1_String_List_1_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 201863, RefRangeEnd = 201912, XrefRangeStart = 201837, XrefRangeEnd = 201863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string key, bool justReplace = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &justReplace;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_Static_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public LTLocalization(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
