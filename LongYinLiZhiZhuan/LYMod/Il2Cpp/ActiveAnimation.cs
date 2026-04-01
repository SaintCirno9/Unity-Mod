using System;
using System.Runtime.CompilerServices;
using Il2CppAnimationOrTween;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class ActiveAnimation : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_current;

	private static readonly IntPtr NativeFieldInfoPtr_onFinished;

	private static readonly IntPtr NativeFieldInfoPtr_eventReceiver;

	private static readonly IntPtr NativeFieldInfoPtr_callWhenFinished;

	private static readonly IntPtr NativeFieldInfoPtr_mAnim;

	private static readonly IntPtr NativeFieldInfoPtr_mLastDirection;

	private static readonly IntPtr NativeFieldInfoPtr_mDisableDirection;

	private static readonly IntPtr NativeFieldInfoPtr_mNotify;

	private static readonly IntPtr NativeFieldInfoPtr_mAnimator;

	private static readonly IntPtr NativeFieldInfoPtr_mClip;

	private static readonly IntPtr NativeMethodInfoPtr_get_playbackTime_Private_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_String_Direction_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_EnableCondition_DisableCondition_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_Direction_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animator_String_Direction_EnableCondition_DisableCondition_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ActiveAnimation current
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveAnimation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeAnimation));
		}
	}

	public unsafe List<EventDelegate> onFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinished);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<EventDelegate>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject eventReceiver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventReceiver);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventReceiver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string callWhenFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callWhenFinished);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callWhenFinished)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Animation mAnim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAnim);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animation>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAnim)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animation));
		}
	}

	public unsafe Direction mLastDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLastDirection);
			return *(Direction*)num;
		}
		set
		{
			*(Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLastDirection)) = direction;
		}
	}

	public unsafe Direction mDisableDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDisableDirection);
			return *(Direction*)num;
		}
		set
		{
			*(Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDisableDirection)) = direction;
		}
	}

	public unsafe bool mNotify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNotify);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNotify)) = flag;
		}
	}

	public unsafe Animator mAnimator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAnimator);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAnimator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator));
		}
	}

	public unsafe string mClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mClip);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mClip)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float playbackTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51366, XrefRangeEnd = 51369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playbackTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool isPlaying
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51395, RefRangeEnd = 51396, XrefRangeStart = 51369, XrefRangeEnd = 51395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ActiveAnimation()
	{
		Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActiveAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr);
		NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "current");
		NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "onFinished");
		NativeFieldInfoPtr_eventReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "eventReceiver");
		NativeFieldInfoPtr_callWhenFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "callWhenFinished");
		NativeFieldInfoPtr_mAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mAnim");
		NativeFieldInfoPtr_mLastDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mLastDirection");
		NativeFieldInfoPtr_mDisableDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mDisableDirection");
		NativeFieldInfoPtr_mNotify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mNotify");
		NativeFieldInfoPtr_mAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mAnimator");
		NativeFieldInfoPtr_mClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, "mClip");
		NativeMethodInfoPtr_get_playbackTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_Play_Private_Void_String_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_EnableCondition_DisableCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animator_String_Direction_EnableCondition_DisableCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr, 100663982);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51396, XrefRangeEnd = 51408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Finish()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51432, RefRangeEnd = 51433, XrefRangeStart = 51408, XrefRangeEnd = 51432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51433, XrefRangeEnd = 51443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51443, XrefRangeEnd = 51458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51471, RefRangeEnd = 51473, XrefRangeStart = 51458, XrefRangeEnd = 51471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(string clipName, Direction playDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(clipName);
		*(Direction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &playDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Private_Void_String_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51511, RefRangeEnd = 51514, XrefRangeStart = 51473, XrefRangeEnd = 51511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anim);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clipName);
		*(Direction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &playDirection;
		*(EnableCondition**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &enableBeforePlay;
		*(DisableCondition**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &disableCondition;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_EnableCondition_DisableCondition_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveAnimation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51514, XrefRangeEnd = 51515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anim);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clipName);
		*(Direction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &playDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_String_Direction_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveAnimation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51515, XrefRangeEnd = 51516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anim);
		*(Direction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &playDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animation_Direction_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveAnimation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51554, RefRangeEnd = 51555, XrefRangeStart = 51516, XrefRangeEnd = 51554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anim);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clipName);
		*(Direction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &playDirection;
		*(EnableCondition**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &enableBeforePlay;
		*(DisableCondition**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &disableCondition;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_ActiveAnimation_Animator_String_Direction_EnableCondition_DisableCondition_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveAnimation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51555, XrefRangeEnd = 51566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveAnimation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAnimation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActiveAnimation(IntPtr pointer)
		: base(pointer)
	{
	}
}
