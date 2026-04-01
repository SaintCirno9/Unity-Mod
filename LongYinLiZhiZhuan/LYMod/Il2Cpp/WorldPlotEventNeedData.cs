using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class WorldPlotEventNeedData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_needType;

	private static readonly System.IntPtr NativeFieldInfoPtr_needTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_needResult;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe WorldPlotEventNeedType needType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needType);
			return *(WorldPlotEventNeedType*)num;
		}
		set
		{
			*(WorldPlotEventNeedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needType)) = worldPlotEventNeedType;
		}
	}

	public unsafe string needTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needTarget);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needTarget)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string needResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needResult);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needResult)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static WorldPlotEventNeedData()
	{
		Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldPlotEventNeedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr);
		NativeFieldInfoPtr_needType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr, "needType");
		NativeFieldInfoPtr_needTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr, "needTarget");
		NativeFieldInfoPtr_needResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr, "needResult");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr, 100667272);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr, 100667273);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123405, XrefRangeEnd = 123420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlotEventNeedData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldPlotEventNeedData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldPlotEventNeedData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
