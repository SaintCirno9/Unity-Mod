using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class BookData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skillID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadDayCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMoneyCost_Public_Int32_0;

	public unsafe int skillID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID)) = num;
		}
	}

	static BookData()
	{
		Il2CppClassPointerStore<BookData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BookData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BookData>.NativeClassPtr);
		NativeFieldInfoPtr_skillID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookData>.NativeClassPtr, "skillID");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookData>.NativeClassPtr, 100667998);
		NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookData>.NativeClassPtr, 100667999);
		NativeMethodInfoPtr_ReadDayCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookData>.NativeClassPtr, 100668000);
		NativeMethodInfoPtr_ReadMoneyCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookData>.NativeClassPtr, 100668001);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BookData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BookData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 143552, RefRangeEnd = 143590, XrefRangeStart = 143542, XrefRangeEnd = 143552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillData DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143600, RefRangeEnd = 143601, XrefRangeStart = 143590, XrefRangeEnd = 143600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ReadDayCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDayCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143611, RefRangeEnd = 143613, XrefRangeStart = 143601, XrefRangeEnd = 143611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ReadMoneyCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMoneyCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BookData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
