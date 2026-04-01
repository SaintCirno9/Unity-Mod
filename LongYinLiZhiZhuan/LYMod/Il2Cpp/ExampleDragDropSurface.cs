using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class ExampleDragDropSurface : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_rotatePlacedObject;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool rotatePlacedObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatePlacedObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatePlacedObject)) = flag;
		}
	}

	static ExampleDragDropSurface()
	{
		Il2CppClassPointerStore<ExampleDragDropSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExampleDragDropSurface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleDragDropSurface>.NativeClassPtr);
		NativeFieldInfoPtr_rotatePlacedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleDragDropSurface>.NativeClassPtr, "rotatePlacedObject");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleDragDropSurface>.NativeClassPtr, 100663377);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExampleDragDropSurface()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExampleDragDropSurface>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExampleDragDropSurface(IntPtr pointer)
		: base(pointer)
	{
	}
}
