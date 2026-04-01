using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ForceInteractionTimeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_addFavorTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_reduceFavorTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealResourceTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_giveGiftTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int addFavorTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addFavorTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addFavorTime)) = num;
		}
	}

	public unsafe int reduceFavorTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reduceFavorTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reduceFavorTime)) = num;
		}
	}

	public unsafe int stealResourceTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealResourceTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealResourceTime)) = num;
		}
	}

	public unsafe int giveGiftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveGiftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveGiftTime)) = num;
		}
	}

	static ForceInteractionTimeData()
	{
		Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceInteractionTimeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr);
		NativeFieldInfoPtr_addFavorTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, "addFavorTime");
		NativeFieldInfoPtr_reduceFavorTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, "reduceFavorTime");
		NativeFieldInfoPtr_stealResourceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, "stealResourceTime");
		NativeFieldInfoPtr_giveGiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, "giveGiftTime");
		NativeMethodInfoPtr_ResetTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, 100667405);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, 100667406);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr, 100667407);
	}

	[CallerCount(0)]
	public unsafe void ResetTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126270, RefRangeEnd = 126271, XrefRangeStart = 126269, XrefRangeEnd = 126270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceInteractionTimeData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceInteractionTimeData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126271, XrefRangeEnd = 126286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ForceInteractionTimeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
