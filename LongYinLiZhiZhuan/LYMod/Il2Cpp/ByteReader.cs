using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class ByteReader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mTemp;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_ByteReader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canRead_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadLine_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadLine_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadLine_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadDictionary_Public_Dictionary_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCSV_Public_BetterList_1_String_0;

	public unsafe Il2CppStructArray<byte> mBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int mOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffset)) = num;
		}
	}

	public unsafe static BetterList<string> mTemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mTemp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BetterList<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mTemp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)betterList));
		}
	}

	public unsafe bool canRead
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canRead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ByteReader()
	{
		Il2CppClassPointerStore<ByteReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ByteReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteReader>.NativeClassPtr);
		NativeFieldInfoPtr_mBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, "mBuffer");
		NativeFieldInfoPtr_mOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, "mOffset");
		NativeFieldInfoPtr_mTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, "mTemp");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_Open_Public_Static_ByteReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_get_canRead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_ReadLine_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_ReadLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_ReadLine_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_ReadDictionary_Public_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_ReadCSV_Public_BetterList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteReader>.NativeClassPtr, 100664050);
	}

	[CallerCount(131)]
	[CachedScanResults(RefRangeStart = 51833, RefRangeEnd = 51964, XrefRangeStart = 51831, XrefRangeEnd = 51833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ByteReader(Il2CppStructArray<byte> bytes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51968, RefRangeEnd = 51969, XrefRangeStart = 51964, XrefRangeEnd = 51968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ByteReader(TextAsset asset)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51969, XrefRangeEnd = 51973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ByteReader Open(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_ByteReader_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ByteReader>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51973, XrefRangeEnd = 51974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReadLine(Il2CppStructArray<byte> buffer, int start, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadLine_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51974, XrefRangeEnd = 51975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReadLine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadLine_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51976, RefRangeEnd = 51980, XrefRangeStart = 51975, XrefRangeEnd = 51976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReadLine(bool skipEmptyLines)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skipEmptyLines);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadLine_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52005, RefRangeEnd = 52008, XrefRangeStart = 51980, XrefRangeEnd = 52005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, string> ReadDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDictionary_Public_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52069, RefRangeEnd = 52071, XrefRangeStart = 52008, XrefRangeEnd = 52069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BetterList<string> ReadCSV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCSV_Public_BetterList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BetterList<string>>(intPtr) : null;
	}

	public ByteReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
