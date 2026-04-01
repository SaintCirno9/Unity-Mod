using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class UISnapshotPoint : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

	private static readonly IntPtr NativeFieldInfoPtr_nearClip;

	private static readonly IntPtr NativeFieldInfoPtr_farClip;

	private static readonly IntPtr NativeFieldInfoPtr_fieldOfView;

	private static readonly IntPtr NativeFieldInfoPtr_orthoSize;

	private static readonly IntPtr NativeFieldInfoPtr_thumbnail;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isOrthographic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic)) = flag;
		}
	}

	public unsafe float nearClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearClip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearClip)) = num;
		}
	}

	public unsafe float farClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farClip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farClip)) = num;
		}
	}

	public unsafe int fieldOfView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldOfView);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldOfView)) = num;
		}
	}

	public unsafe float orthoSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orthoSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orthoSize)) = num;
		}
	}

	public unsafe Texture2D thumbnail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnail);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	static UISnapshotPoint()
	{
		Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UISnapshotPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr);
		NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "isOrthographic");
		NativeFieldInfoPtr_nearClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "nearClip");
		NativeFieldInfoPtr_farClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "farClip");
		NativeFieldInfoPtr_fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "fieldOfView");
		NativeFieldInfoPtr_orthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "orthoSize");
		NativeFieldInfoPtr_thumbnail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, "thumbnail");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr, 100664584);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61502, XrefRangeEnd = 61507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61507, XrefRangeEnd = 61508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UISnapshotPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISnapshotPoint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UISnapshotPoint(IntPtr pointer)
		: base(pointer)
	{
	}
}
