using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class RecruitChooseToggleController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_heroID;

	private static readonly IntPtr NativeMethodInfoPtr_RecruitChooseToggleClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int heroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroID)) = num;
		}
	}

	static RecruitChooseToggleController()
	{
		Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RecruitChooseToggleController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr);
		NativeFieldInfoPtr_heroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr, "heroID");
		NativeMethodInfoPtr_RecruitChooseToggleClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr, 100671355);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr, 100671356);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324017, XrefRangeEnd = 324025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecruitChooseToggleClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecruitChooseToggleClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RecruitChooseToggleController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecruitChooseToggleController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RecruitChooseToggleController(IntPtr pointer)
		: base(pointer)
	{
	}
}
