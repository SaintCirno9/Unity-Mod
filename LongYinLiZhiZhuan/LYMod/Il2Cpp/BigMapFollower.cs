using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class BigMapFollower : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_followerGameobj;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_0;

	public unsafe GameObject followerGameobj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followerGameobj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followerGameobj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float range
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range)) = num;
		}
	}

	static BigMapFollower()
	{
		Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BigMapFollower");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr);
		NativeFieldInfoPtr_followerGameobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr, "followerGameobj");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr, "range");
		NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr, 100666606);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 99994, RefRangeEnd = 99996, XrefRangeStart = 99992, XrefRangeEnd = 99994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigMapFollower(GameObject _targetObj, float _range)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigMapFollower>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_targetObj);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_range;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BigMapFollower(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
