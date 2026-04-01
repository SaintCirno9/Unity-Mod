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

public class InvDatabase : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_mList;

	private static readonly IntPtr NativeFieldInfoPtr_mIsDirty;

	private static readonly IntPtr NativeFieldInfoPtr_databaseID;

	private static readonly IntPtr NativeFieldInfoPtr_items;

	private static readonly IntPtr NativeFieldInfoPtr_iconAtlas;

	private static readonly IntPtr NativeMethodInfoPtr_get_list_Public_Static_get_Il2CppReferenceArray_1_InvDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItem_Private_InvBaseItem_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDatabase_Private_Static_InvDatabase_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindByID_Public_Static_InvBaseItem_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindByName_Public_Static_InvBaseItem_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindItemID_Public_Static_Int32_InvBaseItem_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppReferenceArray<InvDatabase> mList
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvDatabase>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool mIsDirty
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mIsDirty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mIsDirty, (void*)(&flag));
		}
	}

	public unsafe int databaseID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_databaseID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_databaseID)) = num;
		}
	}

	public unsafe List<InvBaseItem> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InvBaseItem>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe UnityEngine.Object iconAtlas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconAtlas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconAtlas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static Il2CppReferenceArray<InvDatabase> list
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 43620, RefRangeEnd = 43629, XrefRangeStart = 43603, XrefRangeEnd = 43620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_list_Public_Static_get_Il2CppReferenceArray_1_InvDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvDatabase>>(intPtr) : null;
		}
	}

	static InvDatabase()
	{
		Il2CppClassPointerStore<InvDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InvDatabase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr);
		NativeFieldInfoPtr_mList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, "mList");
		NativeFieldInfoPtr_mIsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, "mIsDirty");
		NativeFieldInfoPtr_databaseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, "databaseID");
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, "items");
		NativeFieldInfoPtr_iconAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, "iconAtlas");
		NativeMethodInfoPtr_get_list_Public_Static_get_Il2CppReferenceArray_1_InvDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetItem_Private_InvBaseItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_GetDatabase_Private_Static_InvDatabase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_FindByID_Public_Static_InvBaseItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_FindByName_Public_Static_InvBaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_FindItemID_Public_Static_Int32_InvBaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr, 100663339);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43629, XrefRangeEnd = 43633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43633, XrefRangeEnd = 43637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43637, XrefRangeEnd = 43640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvBaseItem GetItem(int id16)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id16);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Private_InvBaseItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvBaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43640, XrefRangeEnd = 43647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InvDatabase GetDatabase(int dbID)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&dbID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDatabase_Private_Static_InvDatabase_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvDatabase>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43665, RefRangeEnd = 43667, XrefRangeStart = 43647, XrefRangeEnd = 43665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InvBaseItem FindByID(int id32)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id32);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindByID_Public_Static_InvBaseItem_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvBaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43667, XrefRangeEnd = 43679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InvBaseItem FindByName(string exact)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(exact);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindByName_Public_Static_InvBaseItem_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InvBaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43679, XrefRangeEnd = 43689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindItemID(InvBaseItem item)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindItemID_Public_Static_Int32_InvBaseItem_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43689, XrefRangeEnd = 43697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvDatabase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvDatabase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InvDatabase(IntPtr pointer)
		: base(pointer)
	{
	}
}
