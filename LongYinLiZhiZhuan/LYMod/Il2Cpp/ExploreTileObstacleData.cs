using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ExploreTileObstacleData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_needNum;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	public unsafe int obstacleType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleType)) = num;
		}
	}

	public unsafe int needNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needNum)) = num;
		}
	}

	static ExploreTileObstacleData()
	{
		Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExploreTileObstacleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr);
		NativeFieldInfoPtr_obstacleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr, "obstacleType");
		NativeFieldInfoPtr_needNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr, "needNum");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr, 100668288);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 121608, RefRangeEnd = 121642, XrefRangeStart = 121608, XrefRangeEnd = 121642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExploreTileObstacleData(int _obstacleType, int _needNum)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExploreTileObstacleData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_obstacleType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_needNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExploreTileObstacleData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
