using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class UIDragResize : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_target;

	private static readonly IntPtr NativeFieldInfoPtr_pivot;

	private static readonly IntPtr NativeFieldInfoPtr_minWidth;

	private static readonly IntPtr NativeFieldInfoPtr_minHeight;

	private static readonly IntPtr NativeFieldInfoPtr_maxWidth;

	private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

	private static readonly IntPtr NativeFieldInfoPtr_updateAnchors;

	private static readonly IntPtr NativeFieldInfoPtr_mPlane;

	private static readonly IntPtr NativeFieldInfoPtr_mRayPos;

	private static readonly IntPtr NativeFieldInfoPtr_mLocalPos;

	private static readonly IntPtr NativeFieldInfoPtr_mWidth;

	private static readonly IntPtr NativeFieldInfoPtr_mHeight;

	private static readonly IntPtr NativeFieldInfoPtr_mDragging;

	private static readonly IntPtr NativeMethodInfoPtr_OnDragStart_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Private_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UIWidget target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIWidget>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIWidget));
		}
	}

	public unsafe UIWidget.Pivot pivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot);
			return *(UIWidget.Pivot*)num;
		}
		set
		{
			*(UIWidget.Pivot*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot)) = pivot;
		}
	}

	public unsafe int minWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minWidth)) = num;
		}
	}

	public unsafe int minHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeight)) = num;
		}
	}

	public unsafe int maxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWidth)) = num;
		}
	}

	public unsafe int maxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeight)) = num;
		}
	}

	public unsafe bool updateAnchors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAnchors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAnchors)) = flag;
		}
	}

	public unsafe Plane mPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mPlane);
			return *(Plane*)num;
		}
		set
		{
			*(Plane*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mPlane)) = plane;
		}
	}

	public unsafe Vector3 mRayPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRayPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRayPos)) = vector;
		}
	}

	public unsafe Vector3 mLocalPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLocalPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLocalPos)) = vector;
		}
	}

	public unsafe int mWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWidth)) = num;
		}
	}

	public unsafe int mHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHeight)) = num;
		}
	}

	public unsafe bool mDragging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDragging);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDragging)) = flag;
		}
	}

	static UIDragResize()
	{
		Il2CppClassPointerStore<UIDragResize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIDragResize");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "target");
		NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "pivot");
		NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "minWidth");
		NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "minHeight");
		NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "maxWidth");
		NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "maxHeight");
		NativeFieldInfoPtr_updateAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "updateAnchors");
		NativeFieldInfoPtr_mPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mPlane");
		NativeFieldInfoPtr_mRayPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mRayPos");
		NativeFieldInfoPtr_mLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mLocalPos");
		NativeFieldInfoPtr_mWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mWidth");
		NativeFieldInfoPtr_mHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mHeight");
		NativeFieldInfoPtr_mDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, "mDragging");
		NativeMethodInfoPtr_OnDragStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_OnDrag_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_OnDragEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr, 100663587);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46336, XrefRangeEnd = 46349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDragStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDragStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46349, XrefRangeEnd = 46374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrag(Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrag_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnDragEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDragEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46374, XrefRangeEnd = 46375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDragResize()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDragResize>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDragResize(IntPtr pointer)
		: base(pointer)
	{
	}
}
