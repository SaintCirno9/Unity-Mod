using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2Cpp;

public class MouseController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mRayHitObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_mHover;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_controller;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_mInputFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLastPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_mNextRaycast;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDragging;

	private static readonly System.IntPtr NativeFieldInfoPtr_hoveredUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTouchID;

	private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastWorldPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastWorldRay;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_mNotifying;

	private static readonly System.IntPtr NativeFieldInfoPtr_mRayHits;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOverlap;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventDataCurrentPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseDragThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseClickThreshold;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouse0_Public_Static_get_MouseOrTouch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouse1_Public_Static_get_MouseOrTouch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouse2_Public_Static_get_MouseOrTouch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hoveredObject_Public_Static_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hoveredObject_Public_Static_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentKey_Public_Static_get_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentKey_Public_Static_set_Void_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Notify_Public_Static_Void_GameObject_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Void_MouseOrTouch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverGameUI_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMouse_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMouse_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouch_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPress_Private_Void_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRelease_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCollider_Private_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static GameObject mRayHitObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mRayHitObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mRayHitObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static GameObject mHover
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mHover, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mHover, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static GameObject mSelected
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mSelected, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mSelected, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static Camera currentCamera
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentCamera, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentCamera, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe static Il2CppReferenceArray<UICamera.MouseOrTouch> mMouse
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mMouse, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UICamera.MouseOrTouch>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mMouse, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static UICamera.MouseOrTouch controller
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controller, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UICamera.MouseOrTouch>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controller, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseOrTouch));
		}
	}

	public unsafe static UICamera.MouseOrTouch currentTouch
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentTouch, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UICamera.MouseOrTouch>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentTouch, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseOrTouch));
		}
	}

	public unsafe static bool mInputFocus
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mInputFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mInputFocus, (void*)(&flag));
		}
	}

	public unsafe static Vector2 mLastPos
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLastPos, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLastPos, (void*)(&vector));
		}
	}

	public unsafe float mNextRaycast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNextRaycast);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNextRaycast)) = num;
		}
	}

	public unsafe static bool isDragging
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDragging, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDragging, (void*)(&flag));
		}
	}

	public unsafe static GameObject hoveredUI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hoveredUI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hoveredUI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static int currentTouchID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentTouchID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentTouchID, (void*)(&num));
		}
	}

	public unsafe static KeyCode mCurrentKey
	{
		get
		{
			Unsafe.SkipInit(out KeyCode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mCurrentKey, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mCurrentKey, (void*)(&keyCode));
		}
	}

	public unsafe static Vector3 lastWorldPosition
	{
		get
		{
			Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastWorldPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastWorldPosition, (void*)(&vector));
		}
	}

	public unsafe static Ray lastWorldRay
	{
		get
		{
			Unsafe.SkipInit(out Ray result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastWorldRay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastWorldRay, (void*)(&ray));
		}
	}

	public unsafe static RaycastHit lastHit
	{
		get
		{
			Unsafe.SkipInit(out RaycastHit result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastHit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastHit, (void*)(&raycastHit));
		}
	}

	public unsafe static int mNotifying
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mNotifying, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mNotifying, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<RaycastHit> mRayHits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mRayHits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mRayHits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Collider2D> mOverlap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mOverlap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mOverlap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe PointerEventData eventDataCurrentPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDataCurrentPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDataCurrentPosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerEventData));
		}
	}

	public unsafe float mouseDragThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseDragThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseDragThreshold)) = num;
		}
	}

	public unsafe float mouseClickThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseClickThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseClickThreshold)) = num;
		}
	}

	public unsafe static UICamera.MouseOrTouch mouse0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206751, XrefRangeEnd = 206755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouse0_Public_Static_get_MouseOrTouch_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UICamera.MouseOrTouch>(intPtr) : null;
		}
	}

	public unsafe static UICamera.MouseOrTouch mouse1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206755, XrefRangeEnd = 206759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouse1_Public_Static_get_MouseOrTouch_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UICamera.MouseOrTouch>(intPtr) : null;
		}
	}

	public unsafe static UICamera.MouseOrTouch mouse2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206759, XrefRangeEnd = 206763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouse2_Public_Static_get_MouseOrTouch_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UICamera.MouseOrTouch>(intPtr) : null;
		}
	}

	public unsafe static GameObject hoveredObject
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 206778, RefRangeEnd = 206813, XrefRangeStart = 206763, XrefRangeEnd = 206778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hoveredObject_Public_Static_get_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206851, RefRangeEnd = 206856, XrefRangeStart = 206813, XrefRangeEnd = 206851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hoveredObject_Public_Static_set_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static KeyCode currentKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206856, XrefRangeEnd = 206860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentKey_Public_Static_get_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(KeyCode*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 206866, RefRangeEnd = 206872, XrefRangeStart = 206860, XrefRangeEnd = 206866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentKey_Public_Static_set_Void_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static MouseController()
	{
		Il2CppClassPointerStore<MouseController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MouseController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseController>.NativeClassPtr);
		NativeFieldInfoPtr_mRayHitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mRayHitObject");
		NativeFieldInfoPtr_mHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mHover");
		NativeFieldInfoPtr_mSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mSelected");
		NativeFieldInfoPtr_currentCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "currentCamera");
		NativeFieldInfoPtr_mMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mMouse");
		NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "controller");
		NativeFieldInfoPtr_currentTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "currentTouch");
		NativeFieldInfoPtr_mInputFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mInputFocus");
		NativeFieldInfoPtr_mLastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mLastPos");
		NativeFieldInfoPtr_mNextRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mNextRaycast");
		NativeFieldInfoPtr_isDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "isDragging");
		NativeFieldInfoPtr_hoveredUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "hoveredUI");
		NativeFieldInfoPtr_currentTouchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "currentTouchID");
		NativeFieldInfoPtr_mCurrentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mCurrentKey");
		NativeFieldInfoPtr_lastWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "lastWorldPosition");
		NativeFieldInfoPtr_lastWorldRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "lastWorldRay");
		NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "lastHit");
		NativeFieldInfoPtr_mNotifying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mNotifying");
		NativeFieldInfoPtr_mRayHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mRayHits");
		NativeFieldInfoPtr_mOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mOverlap");
		NativeFieldInfoPtr_eventDataCurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "eventDataCurrentPosition");
		NativeFieldInfoPtr_mouseDragThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mouseDragThreshold");
		NativeFieldInfoPtr_mouseClickThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "mouseClickThreshold");
		NativeMethodInfoPtr_get_mouse0_Public_Static_get_MouseOrTouch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669579);
		NativeMethodInfoPtr_get_mouse1_Public_Static_get_MouseOrTouch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669580);
		NativeMethodInfoPtr_get_mouse2_Public_Static_get_MouseOrTouch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669581);
		NativeMethodInfoPtr_get_hoveredObject_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669582);
		NativeMethodInfoPtr_set_hoveredObject_Public_Static_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669583);
		NativeMethodInfoPtr_get_currentKey_Public_Static_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669584);
		NativeMethodInfoPtr_set_currentKey_Public_Static_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669585);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669586);
		NativeMethodInfoPtr_Notify_Public_Static_Void_GameObject_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669587);
		NativeMethodInfoPtr_Raycast_Public_Static_Void_MouseOrTouch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669588);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669589);
		NativeMethodInfoPtr_IsPointerOverGameUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669590);
		NativeMethodInfoPtr_ProcessEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669591);
		NativeMethodInfoPtr_ClearMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669592);
		NativeMethodInfoPtr_ProcessMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669593);
		NativeMethodInfoPtr_ProcessTouch_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669594);
		NativeMethodInfoPtr_ProcessPress_Private_Void_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669595);
		NativeMethodInfoPtr_ProcessRelease_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669596);
		NativeMethodInfoPtr_HasCollider_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669597);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100669598);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206872, XrefRangeEnd = 206874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 206888, RefRangeEnd = 206899, XrefRangeStart = 206874, XrefRangeEnd = 206888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Notify(GameObject go, string funcName, Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(funcName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Notify_Public_Static_Void_GameObject_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206899, XrefRangeEnd = 206913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Raycast(UICamera.MouseOrTouch touch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Void_MouseOrTouch_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 206941, RefRangeEnd = 206943, XrefRangeStart = 206913, XrefRangeEnd = 206941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 inPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inPos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206943, XrefRangeEnd = 206968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPointerOverGameUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPointerOverGameUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207026, RefRangeEnd = 207027, XrefRangeStart = 206968, XrefRangeEnd = 207026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207027, XrefRangeEnd = 207037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearMouse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207037, XrefRangeEnd = 207182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMouse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207193, RefRangeEnd = 207194, XrefRangeStart = 207182, XrefRangeEnd = 207193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessTouch(bool pressed, bool released)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pressed);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &released;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTouch_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207291, RefRangeEnd = 207292, XrefRangeStart = 207194, XrefRangeEnd = 207291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessPress(bool pressed, float click, float drag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pressed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &click;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &drag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessPress_Private_Void_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207384, RefRangeEnd = 207385, XrefRangeStart = 207292, XrefRangeEnd = 207384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessRelease(float drag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&drag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRelease_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207385, XrefRangeEnd = 207401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCollider(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCollider_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207401, XrefRangeEnd = 207402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MouseController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MouseController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
