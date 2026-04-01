using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class PointConnection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pointID;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextPoint;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	public unsafe int pointID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointID)) = num;
		}
	}

	public unsafe int nextPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPoint)) = num;
		}
	}

	static PointConnection()
	{
		Il2CppClassPointerStore<PointConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PointConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointConnection>.NativeClassPtr);
		NativeFieldInfoPtr_pointID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointConnection>.NativeClassPtr, "pointID");
		NativeFieldInfoPtr_nextPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointConnection>.NativeClassPtr, "nextPoint");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointConnection>.NativeClassPtr, 100671841);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 121608, RefRangeEnd = 121642, XrefRangeStart = 121608, XrefRangeEnd = 121642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointConnection(int _pointID, int _nextPoint)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointConnection>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_pointID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_nextPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PointConnection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
