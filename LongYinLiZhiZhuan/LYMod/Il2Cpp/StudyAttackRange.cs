using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class StudyAttackRange : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StudyAttackRange()
	{
		Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StudyAttackRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr);
		NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr, 100671732);
		NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr, 100671733);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr, 100671734);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332986, XrefRangeEnd = 333004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTriggerEnter2D(Collider2D other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333004, XrefRangeEnd = 333016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTriggerExit2D(Collider2D other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StudyAttackRange()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyAttackRange>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StudyAttackRange(IntPtr pointer)
		: base(pointer)
	{
	}
}
