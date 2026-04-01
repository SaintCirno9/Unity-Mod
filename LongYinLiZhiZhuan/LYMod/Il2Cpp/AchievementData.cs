using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AchievementData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_achName;

	private static readonly System.IntPtr NativeFieldInfoPtr_achDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataType;

	private static readonly System.IntPtr NativeFieldInfoPtr_goal;

	private static readonly System.IntPtr NativeFieldInfoPtr_tips;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string achName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string achDescribe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achDescribe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achDescribe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe AchDataType dataType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataType);
			return *(AchDataType*)num;
		}
		set
		{
			*(AchDataType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataType)) = achDataType;
		}
	}

	public unsafe float goal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goal)) = num;
		}
	}

	public unsafe string tips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tips);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tips)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static AchievementData()
	{
		Il2CppClassPointerStore<AchievementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AchievementData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementData>.NativeClassPtr);
		NativeFieldInfoPtr_achName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "achName");
		NativeFieldInfoPtr_achDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "achDescribe");
		NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "dataType");
		NativeFieldInfoPtr_goal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "goal");
		NativeFieldInfoPtr_tips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "tips");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, 100666960);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AchievementData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AchievementData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
