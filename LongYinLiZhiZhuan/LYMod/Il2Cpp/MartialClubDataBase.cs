using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class MartialClubDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_areaName;

	private static readonly System.IntPtr NativeFieldInfoPtr_goodAtSkillName;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMartialClub_Public_Static_MartialClubDataBase_String_0;

	public unsafe string areaName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string goodAtSkillName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goodAtSkillName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goodAtSkillName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<int> skillID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MartialClubDataBase()
	{
		Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MartialClubDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_areaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr, "areaName");
		NativeFieldInfoPtr_goodAtSkillName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr, "goodAtSkillName");
		NativeFieldInfoPtr_skillID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr, "skillID");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr, 100667018);
		NativeMethodInfoPtr_FindMartialClub_Public_Static_MartialClubDataBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr, 100667019);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113626, RefRangeEnd = 113627, XrefRangeStart = 113618, XrefRangeEnd = 113626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MartialClubDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MartialClubDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113648, RefRangeEnd = 113649, XrefRangeStart = 113627, XrefRangeEnd = 113648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MartialClubDataBase FindMartialClub(string areaName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(areaName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMartialClub_Public_Static_MartialClubDataBase_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MartialClubDataBase>(intPtr) : null;
	}

	public MartialClubDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
