using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class HeroTagData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tagID;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceHero;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPermanentTag_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_TagIconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartChooseAble_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_HeroTagDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int tagID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagID)) = num;
		}
	}

	public unsafe float leftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime)) = num;
		}
	}

	public unsafe string sourceHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceHero);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceHero)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static HeroTagData()
	{
		Il2CppClassPointerStore<HeroTagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroTagData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr);
		NativeFieldInfoPtr_tagID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, "tagID");
		NativeFieldInfoPtr_leftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, "leftTime");
		NativeFieldInfoPtr_sourceHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, "sourceHero");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667937);
		NativeMethodInfoPtr_IsPermanentTag_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667938);
		NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_TagIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667939);
		NativeMethodInfoPtr_StartChooseAble_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667940);
		NativeMethodInfoPtr_DataBase_Public_HeroTagDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667941);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr, 100667942);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 141829, RefRangeEnd = 141832, XrefRangeStart = 141827, XrefRangeEnd = 141829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroTagData(int _tagID, float _leftTime = -1f, string _sourceHero = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroTagData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_tagID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_leftTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_sourceHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 141836, RefRangeEnd = 141842, XrefRangeStart = 141832, XrefRangeEnd = 141836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPermanentTag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPermanentTag_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141948, RefRangeEnd = 141949, XrefRangeStart = 141842, XrefRangeEnd = 141948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe(bool showEffectTarget, TagIconType tagIconType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&showEffectTarget);
		*(TagIconType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tagIconType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_TagIconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141950, RefRangeEnd = 141951, XrefRangeStart = 141949, XrefRangeEnd = 141950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartChooseAble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartChooseAble_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(64)]
	[CachedScanResults(RefRangeStart = 141961, RefRangeEnd = 142025, XrefRangeStart = 141951, XrefRangeEnd = 141961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroTagDataBase DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_HeroTagDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroTagDataBase>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142025, XrefRangeEnd = 142040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public HeroTagData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
