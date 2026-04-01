using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AISettingData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_priorityLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_speFocusID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	public unsafe int priorityLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityLv)) = num;
		}
	}

	public unsafe int speFocusID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speFocusID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speFocusID)) = num;
		}
	}

	static AISettingData()
	{
		Il2CppClassPointerStore<AISettingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AISettingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AISettingData>.NativeClassPtr);
		NativeFieldInfoPtr_priorityLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISettingData>.NativeClassPtr, "priorityLv");
		NativeFieldInfoPtr_speFocusID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISettingData>.NativeClassPtr, "speFocusID");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AISettingData>.NativeClassPtr, 100665777);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 73761, RefRangeEnd = 73765, XrefRangeStart = 73760, XrefRangeEnd = 73761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AISettingData(int _priorityLv)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AISettingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_priorityLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AISettingData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
