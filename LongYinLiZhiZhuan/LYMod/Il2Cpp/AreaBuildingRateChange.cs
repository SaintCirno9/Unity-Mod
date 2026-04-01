using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AreaBuildingRateChange : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_targetBuildingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_rateChange;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string targetBuildingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetBuildingName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetBuildingName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float rateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rateChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rateChange)) = num;
		}
	}

	static AreaBuildingRateChange()
	{
		Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaBuildingRateChange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr);
		NativeFieldInfoPtr_targetBuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr, "targetBuildingName");
		NativeFieldInfoPtr_rateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr, "rateChange");
		NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr, 100667087);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 99994, RefRangeEnd = 99996, XrefRangeStart = 99994, XrefRangeEnd = 99996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaBuildingRateChange(string _Name, float _rateChange)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaBuildingRateChange>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_Name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_rateChange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119655, XrefRangeEnd = 119670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public AreaBuildingRateChange(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
