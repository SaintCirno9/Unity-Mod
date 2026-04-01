using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class HudResourceShowData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_num;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe float num
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_num);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_num)) = num;
		}
	}

	static HudResourceShowData()
	{
		Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HudResourceShowData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr, "id");
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr, "num");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr, 100669334);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 113338, RefRangeEnd = 113353, XrefRangeStart = 113338, XrefRangeEnd = 113353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HudResourceShowData(int _id, float _num)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HudResourceShowData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HudResourceShowData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
