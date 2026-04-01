using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class WorldNewsData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_newsText;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

	public unsafe string newsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newsText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newsText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int leftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTime)) = num;
		}
	}

	static WorldNewsData()
	{
		Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorldNewsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr);
		NativeFieldInfoPtr_newsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr, "newsText");
		NativeFieldInfoPtr_leftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr, "leftTime");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr, 100667011);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 113503, RefRangeEnd = 113526, XrefRangeStart = 113501, XrefRangeEnd = 113503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldNewsData(string _newsText, int _leftTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldNewsData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_newsText);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_leftTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldNewsData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
