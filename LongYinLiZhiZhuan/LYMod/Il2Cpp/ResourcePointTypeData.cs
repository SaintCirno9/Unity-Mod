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
public class ResourcePointTypeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_resourcePointTypeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourcePointTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceSpeAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_defenceSpeAddData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int resourcePointTypeID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeID)) = num;
		}
	}

	public unsafe string resourcePointTypeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourcePointTypeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<float> changeResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeResource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeResource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForceSpeAddData resourceSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceSpeAddData));
		}
	}

	public unsafe HeroSpeAddData defenceSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenceSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenceSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	static ResourcePointTypeData()
	{
		Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResourcePointTypeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr);
		NativeFieldInfoPtr_resourcePointTypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, "resourcePointTypeID");
		NativeFieldInfoPtr_resourcePointTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, "resourcePointTypeName");
		NativeFieldInfoPtr_changeResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, "changeResource");
		NativeFieldInfoPtr_resourceSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, "resourceSpeAddData");
		NativeFieldInfoPtr_defenceSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, "defenceSpeAddData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, 100667192);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr, 100667193);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121723, RefRangeEnd = 121724, XrefRangeStart = 121691, XrefRangeEnd = 121723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourcePointTypeData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePointTypeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121724, XrefRangeEnd = 121739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ResourcePointTypeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
