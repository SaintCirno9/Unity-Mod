using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SkinDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skinID;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinName;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinSpeAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLC;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinSpeAdd_Public_HeroSpeAddData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0;

	public unsafe int skinID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinID)) = num;
		}
	}

	public unsafe string skinName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe HeroSpeAddData skinSpeAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinSpeAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinSpeAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe int DLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC)) = num;
		}
	}

	static SkinDataBase()
	{
		Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkinDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_skinID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, "skinID");
		NativeFieldInfoPtr_skinName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, "skinName");
		NativeFieldInfoPtr_skinSpeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, "skinSpeAdd");
		NativeFieldInfoPtr_DLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, "DLC");
		NativeMethodInfoPtr_GetSkinSpeAdd_Public_HeroSpeAddData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, 100667014);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, 100667015);
		NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr, 100667016);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113564, RefRangeEnd = 113568, XrefRangeStart = 113562, XrefRangeEnd = 113564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData GetSkinSpeAdd(int lv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinSpeAdd_Public_HeroSpeAddData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113569, RefRangeEnd = 113570, XrefRangeStart = 113568, XrefRangeEnd = 113569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113608, RefRangeEnd = 113612, XrefRangeStart = 113570, XrefRangeEnd = 113608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_skinLv);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeLine;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinFullName_Public_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public SkinDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
