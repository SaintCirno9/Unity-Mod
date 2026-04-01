using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public static class Localization : Il2CppSystem.Object
{
	public sealed class LoadFunction : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0;

		static LoadFunction()
		{
			Il2CppClassPointerStore<LoadFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Localization>.NativeClassPtr, "LoadFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFunction>.NativeClassPtr, 100664125);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFunction>.NativeClassPtr, 100664126);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFunction>.NativeClassPtr, 100664127);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFunction>.NativeClassPtr, 100664128);
		}

		[CallerCount(1262)]
		[CachedScanResults(RefRangeStart = 6387, RefRangeEnd = 7649, XrefRangeStart = 6387, XrefRangeEnd = 7649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadFunction(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8506, RefRangeEnd = 8519, XrefRangeStart = 8506, XrefRangeEnd = 8519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> Invoke(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 8102, RefRangeEnd = 8106, XrefRangeStart = 8102, XrefRangeEnd = 8106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(string path, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 7678, RefRangeEnd = 7683, XrefRangeStart = 7678, XrefRangeEnd = 7683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}

		public LoadFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator LoadFunction(System.Func<string, Il2CppStructArray<byte>> P_0)
		{
			return DelegateSupport.ConvertDelegate<LoadFunction>((System.Delegate)P_0);
		}

		public static LoadFunction operator +(LoadFunction P_0, LoadFunction P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<LoadFunction>();
		}

		public static LoadFunction operator -(LoadFunction P_0, LoadFunction P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<LoadFunction>();
			}
			return (LoadFunction)obj;
		}
	}

	public sealed class OnLocalizeNotification : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnLocalizeNotification()
		{
			Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Localization>.NativeClassPtr, "OnLocalizeNotification");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr, 100664129);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr, 100664130);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr, 100664131);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr, 100664132);
		}

		[CallerCount(1262)]
		[CachedScanResults(RefRangeStart = 6387, RefRangeEnd = 7649, XrefRangeStart = 6387, XrefRangeEnd = 7649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnLocalizeNotification(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnLocalizeNotification>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 46925, RefRangeEnd = 46959, XrefRangeStart = 46925, XrefRangeEnd = 46959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 7678, RefRangeEnd = 7683, XrefRangeStart = 7678, XrefRangeEnd = 7683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OnLocalizeNotification(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnLocalizeNotification(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnLocalizeNotification>((System.Delegate)P_0);
		}

		public static OnLocalizeNotification operator +(OnLocalizeNotification P_0, OnLocalizeNotification P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnLocalizeNotification>();
		}

		public static OnLocalizeNotification operator -(OnLocalizeNotification P_0, OnLocalizeNotification P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnLocalizeNotification>();
			}
			return (OnLocalizeNotification)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_loadFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_onLocalize;

	private static readonly System.IntPtr NativeFieldInfoPtr_localizationHasBeenSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLanguages;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOldDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_mDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_mReplacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLanguageIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLanguage;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMerging;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dictionary_Public_Static_get_Dictionary_2_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dictionary_Public_Static_set_Void_Dictionary_2_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_knownLanguages_Public_Static_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_language_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_language_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reload_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDictionary_Private_Static_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAndSelect_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Void_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceKey_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearReplacements_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_TextAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasLanguage_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCSV_Private_Static_Boolean_Il2CppStructArray_1_Byte_TextAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCSV_Private_Static_Void_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStrings_Private_Static_Il2CppStringArray_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectLanguage_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_String_Dictionary_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isActive_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_String_String_String_0;

	public unsafe static LoadFunction loadFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loadFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoadFunction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loadFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadFunction));
		}
	}

	public unsafe static OnLocalizeNotification onLocalize
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onLocalize, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnLocalizeNotification>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onLocalize, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onLocalizeNotification));
		}
	}

	public unsafe static bool localizationHasBeenSet
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localizationHasBeenSet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localizationHasBeenSet, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStringArray mLanguages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLanguages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLanguages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Dictionary<string, string> mOldDictionary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mOldDictionary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mOldDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, Il2CppStringArray> mDictionary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mDictionary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, string> mReplacement
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mReplacement, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mReplacement, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static int mLanguageIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLanguageIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLanguageIndex, (void*)(&num));
		}
	}

	public unsafe static string mLanguage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLanguage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLanguage, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool mMerging
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mMerging, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mMerging, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<string, Il2CppStringArray> dictionary
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52389, XrefRangeEnd = 52404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dictionary_Public_Static_get_Dictionary_2_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStringArray>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52404, XrefRangeEnd = 52410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dictionary_Public_Static_set_Void_Dictionary_2_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static Il2CppStringArray knownLanguages
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 52425, RefRangeEnd = 52429, XrefRangeStart = 52410, XrefRangeEnd = 52425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_knownLanguages_Public_Static_get_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
	}

	public unsafe static string language
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52448, RefRangeEnd = 52451, XrefRangeStart = 52429, XrefRangeEnd = 52448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_language_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52461, RefRangeEnd = 52462, XrefRangeStart = 52451, XrefRangeEnd = 52461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_language_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool isActive
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 53176, RefRangeEnd = 53191, XrefRangeStart = 53176, XrefRangeEnd = 53176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActive_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Localization()
	{
		Il2CppClassPointerStore<Localization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Localization");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Localization>.NativeClassPtr);
		NativeFieldInfoPtr_loadFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "loadFunction");
		NativeFieldInfoPtr_onLocalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "onLocalize");
		NativeFieldInfoPtr_localizationHasBeenSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "localizationHasBeenSet");
		NativeFieldInfoPtr_mLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mLanguages");
		NativeFieldInfoPtr_mOldDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mOldDictionary");
		NativeFieldInfoPtr_mDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mDictionary");
		NativeFieldInfoPtr_mReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mReplacement");
		NativeFieldInfoPtr_mLanguageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mLanguageIndex");
		NativeFieldInfoPtr_mLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mLanguage");
		NativeFieldInfoPtr_mMerging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "mMerging");
		NativeMethodInfoPtr_get_dictionary_Public_Static_get_Dictionary_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr_set_dictionary_Public_Static_set_Void_Dictionary_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664094);
		NativeMethodInfoPtr_get_knownLanguages_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_get_language_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_set_language_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_Reload_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_LoadDictionary_Private_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_LoadAndSelect_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_Load_Public_Static_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_Set_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_ReplaceKey_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_ClearReplacements_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_TextAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_HasLanguage_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_LoadCSV_Private_Static_Boolean_Il2CppStructArray_1_Byte_TextAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_AddCSV_Private_Static_Void_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_ExtractStrings_Private_Static_Il2CppStringArray_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_SelectLanguage_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_Set_Public_Static_Void_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_Set_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr_Get_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_get_isActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_Localize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr_Set_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100664123);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52462, XrefRangeEnd = 52480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Reload()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reload_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 52540, RefRangeEnd = 52546, XrefRangeStart = 52480, XrefRangeEnd = 52540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadDictionary(string value, bool merge = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDictionary_Private_Static_Boolean_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52580, RefRangeEnd = 52583, XrefRangeStart = 52546, XrefRangeEnd = 52580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadAndSelect(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAndSelect_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52583, XrefRangeEnd = 52594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Load(TextAsset asset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Void_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52594, XrefRangeEnd = 52632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(string languageName, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(languageName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52632, XrefRangeEnd = 52646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceKey(string key, string val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceKey_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52646, XrefRangeEnd = 52654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearReplacements()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearReplacements_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52654, XrefRangeEnd = 52660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadCSV(TextAsset asset, bool merge = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_TextAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52660, XrefRangeEnd = 52664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadCSV(Il2CppStructArray<byte> bytes, bool merge = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCSV_Public_Static_Boolean_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52673, RefRangeEnd = 52674, XrefRangeStart = 52664, XrefRangeEnd = 52673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasLanguage(string languageName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(languageName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLanguage_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52827, RefRangeEnd = 52830, XrefRangeStart = 52674, XrefRangeEnd = 52827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadCSV(Il2CppStructArray<byte> bytes, TextAsset asset, bool merge = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCSV_Private_Static_Boolean_Il2CppStructArray_1_Byte_TextAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52858, RefRangeEnd = 52859, XrefRangeStart = 52830, XrefRangeEnd = 52858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCSV(BetterList<string> newValues, Il2CppStringArray newLanguages, Dictionary<string, int> languageIndices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newValues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLanguages);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)languageIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCSV_Private_Static_Void_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52877, RefRangeEnd = 52878, XrefRangeStart = 52859, XrefRangeEnd = 52877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray ExtractStrings(BetterList<string> added, Il2CppStringArray newLanguages, Dictionary<string, int> languageIndices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)added);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLanguages);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)languageIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractStrings_Private_Static_Il2CppStringArray_BetterList_1_String_Il2CppStringArray_Dictionary_2_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52917, RefRangeEnd = 52918, XrefRangeStart = 52878, XrefRangeEnd = 52917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectLanguage(string language)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectLanguage_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52953, RefRangeEnd = 52956, XrefRangeStart = 52918, XrefRangeEnd = 52953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(string languageName, Dictionary<string, string> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(languageName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Static_Void_String_Dictionary_2_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52956, XrefRangeEnd = 52975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(string key, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52975, XrefRangeEnd = 53038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Has(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53114, RefRangeEnd = 53122, XrefRangeStart = 53038, XrefRangeEnd = 53114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Get(string key, bool warnIfMissing = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &warnIfMissing;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53122, XrefRangeEnd = 53135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string key, Il2CppSystem.Object parameter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53135, XrefRangeEnd = 53148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string key, Il2CppSystem.Object arg0, Il2CppSystem.Object arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53148, XrefRangeEnd = 53161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string key, Il2CppSystem.Object arg0, Il2CppSystem.Object arg1, Il2CppSystem.Object arg2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53161, XrefRangeEnd = 53176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string key, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> parameters)
	{
		if (parameters == null)
		{
			parameters = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53191, XrefRangeEnd = 53195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Localize(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Localize_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53195, XrefRangeEnd = 53224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Exists(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53224, XrefRangeEnd = 53277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(string language, string key, string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public static string Format(string key, params Il2CppSystem.Object[] parameters)
	{
		return Format(key, new Il2CppReferenceArray<Il2CppSystem.Object>(parameters));
	}

	public Localization(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
