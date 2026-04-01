using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class FavorData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_favorDregee;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

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

	public unsafe float favorDregee
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorDregee);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorDregee)) = num;
		}
	}

	static FavorData()
	{
		Il2CppClassPointerStore<FavorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FavorData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavorData>.NativeClassPtr);
		NativeFieldInfoPtr_heroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavorData>.NativeClassPtr, "heroID");
		NativeFieldInfoPtr_favorDregee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavorData>.NativeClassPtr, "favorDregee");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavorData>.NativeClassPtr, 100667399);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavorData>.NativeClassPtr, 100667400);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 113338, RefRangeEnd = 113353, XrefRangeStart = 113338, XrefRangeEnd = 113353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FavorData(int _heroID, float _favorDregee)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FavorData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_heroID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_favorDregee;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126176, XrefRangeEnd = 126191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public FavorData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
