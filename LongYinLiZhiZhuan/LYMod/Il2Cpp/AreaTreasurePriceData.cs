using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AreaTreasurePriceData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_treasureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_expensive;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFullDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int treasureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureType)) = num;
		}
	}

	public unsafe bool expensive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expensive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expensive)) = flag;
		}
	}

	static AreaTreasurePriceData()
	{
		Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaTreasurePriceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr);
		NativeFieldInfoPtr_treasureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, "treasureType");
		NativeFieldInfoPtr_expensive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, "expensive");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, 100667205);
		NativeMethodInfoPtr_GetDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_GetFullDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr, 100667208);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121867, RefRangeEnd = 121868, XrefRangeStart = 121866, XrefRangeEnd = 121867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaTreasurePriceData(int _treasureType, bool _expensive)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaTreasurePriceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_treasureType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_expensive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121887, RefRangeEnd = 121888, XrefRangeStart = 121868, XrefRangeEnd = 121887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121900, RefRangeEnd = 121901, XrefRangeStart = 121888, XrefRangeEnd = 121900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFullDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121901, XrefRangeEnd = 121916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaTreasurePriceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
