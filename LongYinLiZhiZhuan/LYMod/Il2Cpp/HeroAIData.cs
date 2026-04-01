using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class HeroAIData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_aiStuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPassiveTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiStuffTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_keepWorkingTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_keepWorkingTimeContine;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveForceTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_needCheckEquipment;

	private static readonly System.IntPtr NativeFieldInfoPtr_needCheckSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_needCheckSpeMed;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigMapTargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigMapTargetPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigmapWaitTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBigmapTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WandererLoseTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBigmapWaitTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe AIStuffType aiStuffType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiStuffType);
			return *(AIStuffType*)num;
		}
		set
		{
			*(AIStuffType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiStuffType)) = aIStuffType;
		}
	}

	public unsafe bool isPassiveTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPassiveTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPassiveTarget)) = flag;
		}
	}

	public unsafe string aiStuffTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiStuffTarget);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiStuffTarget)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int keepWorkingTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepWorkingTimeLeft);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepWorkingTimeLeft)) = num;
		}
	}

	public unsafe int keepWorkingTimeContine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepWorkingTimeContine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepWorkingTimeContine)) = num;
		}
	}

	public unsafe float leaveForceTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveForceTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveForceTime)) = num;
		}
	}

	public unsafe bool needCheckEquipment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckEquipment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckEquipment)) = flag;
		}
	}

	public unsafe bool needCheckSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckSkill)) = flag;
		}
	}

	public unsafe bool needCheckSpeMed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckSpeMed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needCheckSpeMed)) = flag;
		}
	}

	public unsafe int bigMapTargetID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapTargetID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapTargetID)) = num;
		}
	}

	public unsafe BigMapPos bigMapTargetPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapTargetPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigMapPos>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMapTargetPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigMapPos));
		}
	}

	public unsafe float bigmapWaitTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigmapWaitTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigmapWaitTime)) = num;
		}
	}

	static HeroAIData()
	{
		Il2CppClassPointerStore<HeroAIData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroAIData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr);
		NativeFieldInfoPtr_aiStuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "aiStuffType");
		NativeFieldInfoPtr_isPassiveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "isPassiveTarget");
		NativeFieldInfoPtr_aiStuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "aiStuffTarget");
		NativeFieldInfoPtr_keepWorkingTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "keepWorkingTimeLeft");
		NativeFieldInfoPtr_keepWorkingTimeContine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "keepWorkingTimeContine");
		NativeFieldInfoPtr_leaveForceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "leaveForceTime");
		NativeFieldInfoPtr_needCheckEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "needCheckEquipment");
		NativeFieldInfoPtr_needCheckSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "needCheckSkill");
		NativeFieldInfoPtr_needCheckSpeMed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "needCheckSpeMed");
		NativeFieldInfoPtr_bigMapTargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "bigMapTargetID");
		NativeFieldInfoPtr_bigMapTargetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "bigMapTargetPos");
		NativeFieldInfoPtr_bigmapWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, "bigmapWaitTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665781);
		NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665782);
		NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665783);
		NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665784);
		NativeMethodInfoPtr_ResetBigmapTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665785);
		NativeMethodInfoPtr_GetDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665786);
		NativeMethodInfoPtr_WandererLoseTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665787);
		NativeMethodInfoPtr_ResetBigmapWaitTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665788);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr, 100665789);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73822, XrefRangeEnd = 73828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroAIData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 73834, RefRangeEnd = 73846, XrefRangeStart = 73828, XrefRangeEnd = 73834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroAIData(AIStuffType _aiStuffType, int _keepWorkingTimeLeft)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_aiStuffType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_keepWorkingTimeLeft;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 73864, RefRangeEnd = 73872, XrefRangeStart = 73846, XrefRangeEnd = 73864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroAIData(AIStuffType _aiStuffType, string _aiStuffTarget, int _keepWorkingTimeLeft)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_aiStuffType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_aiStuffTarget);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_keepWorkingTimeLeft;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73890, RefRangeEnd = 73891, XrefRangeStart = 73872, XrefRangeEnd = 73890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroAIData(AIStuffType _aiStuffType, string _aiStuffTarget, int _keepWorkingTimeLeft, bool _isPassiveTarget)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroAIData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_aiStuffType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_aiStuffTarget);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_keepWorkingTimeLeft;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_isPassiveTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AIStuffType_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73893, RefRangeEnd = 73894, XrefRangeStart = 73891, XrefRangeEnd = 73893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBigmapTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBigmapTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73951, RefRangeEnd = 73952, XrefRangeStart = 73894, XrefRangeEnd = 73951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 73962, RefRangeEnd = 73966, XrefRangeStart = 73952, XrefRangeEnd = 73962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WandererLoseTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WandererLoseTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73970, RefRangeEnd = 73972, XrefRangeStart = 73966, XrefRangeEnd = 73970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBigmapWaitTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBigmapWaitTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73987, RefRangeEnd = 73988, XrefRangeStart = 73972, XrefRangeEnd = 73987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public HeroAIData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
