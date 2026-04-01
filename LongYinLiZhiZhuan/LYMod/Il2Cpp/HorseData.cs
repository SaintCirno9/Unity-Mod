using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class HorseData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_equiped;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_power;

	private static readonly System.IntPtr NativeFieldInfoPtr_sprint;

	private static readonly System.IntPtr NativeFieldInfoPtr_resist;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_powerAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_sprintAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_resistAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWeightAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_nowPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_favorRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_sprintTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_sprintTimeCd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartSprint_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFavorRate_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Speed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Power_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sprint_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resist_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxPower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullFillPower_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNowPower_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_HorseData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHorseArmor_Public_Void_HorseData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHorseArmor_Public_Void_HorseData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorseStateSpeAdd_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_0;

	public unsafe bool equiped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped)) = flag;
		}
	}

	public unsafe float speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
		}
	}

	public unsafe float power
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power)) = num;
		}
	}

	public unsafe float sprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprint)) = num;
		}
	}

	public unsafe float resist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resist)) = num;
		}
	}

	public unsafe float speedAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAdd)) = num;
		}
	}

	public unsafe float powerAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerAdd)) = num;
		}
	}

	public unsafe float sprintAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintAdd)) = num;
		}
	}

	public unsafe float resistAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resistAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resistAdd)) = num;
		}
	}

	public unsafe float maxWeightAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeightAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeightAdd)) = num;
		}
	}

	public unsafe float nowPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowPower)) = num;
		}
	}

	public unsafe float favorRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorRate)) = num;
		}
	}

	public unsafe float sprintTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintTimeLeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintTimeLeft)) = num;
		}
	}

	public unsafe float sprintTimeCd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintTimeCd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintTimeCd)) = num;
		}
	}

	static HorseData()
	{
		Il2CppClassPointerStore<HorseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HorseData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorseData>.NativeClassPtr);
		NativeFieldInfoPtr_equiped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "equiped");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "power");
		NativeFieldInfoPtr_sprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "sprint");
		NativeFieldInfoPtr_resist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "resist");
		NativeFieldInfoPtr_speedAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "speedAdd");
		NativeFieldInfoPtr_powerAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "powerAdd");
		NativeFieldInfoPtr_sprintAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "sprintAdd");
		NativeFieldInfoPtr_resistAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "resistAdd");
		NativeFieldInfoPtr_maxWeightAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "maxWeightAdd");
		NativeFieldInfoPtr_nowPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "nowPower");
		NativeFieldInfoPtr_favorRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "favorRate");
		NativeFieldInfoPtr_sprintTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "sprintTimeLeft");
		NativeFieldInfoPtr_sprintTimeCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseData>.NativeClassPtr, "sprintTimeCd");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668004);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668005);
		NativeMethodInfoPtr_StartSprint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668006);
		NativeMethodInfoPtr_ChangeFavorRate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668007);
		NativeMethodInfoPtr_Speed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668008);
		NativeMethodInfoPtr_Power_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668009);
		NativeMethodInfoPtr_Sprint_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668010);
		NativeMethodInfoPtr_Resist_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668011);
		NativeMethodInfoPtr_MaxPower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668012);
		NativeMethodInfoPtr_FullFillPower_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668013);
		NativeMethodInfoPtr_RefreshState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668014);
		NativeMethodInfoPtr_ChangeNowPower_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668015);
		NativeMethodInfoPtr_Add_Public_Void_HorseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668016);
		NativeMethodInfoPtr_AddHorseArmor_Public_Void_HorseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668017);
		NativeMethodInfoPtr_RemoveHorseArmor_Public_Void_HorseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668018);
		NativeMethodInfoPtr_GetHorseStateSpeAdd_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668019);
		NativeMethodInfoPtr_GetDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseData>.NativeClassPtr, 100668020);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorseData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorseData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 143775, RefRangeEnd = 143778, XrefRangeStart = 143751, XrefRangeEnd = 143775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorseData(int totalNum)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorseData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&totalNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143783, RefRangeEnd = 143785, XrefRangeStart = 143778, XrefRangeEnd = 143783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSprint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSprint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 143786, RefRangeEnd = 143790, XrefRangeStart = 143785, XrefRangeEnd = 143786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFavorRate(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFavorRate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143791, RefRangeEnd = 143793, XrefRangeStart = 143790, XrefRangeEnd = 143791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Speed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Speed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143794, RefRangeEnd = 143796, XrefRangeStart = 143793, XrefRangeEnd = 143794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Power()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Power_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143797, RefRangeEnd = 143799, XrefRangeStart = 143796, XrefRangeEnd = 143797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Sprint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sprint_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 143800, RefRangeEnd = 143806, XrefRangeStart = 143799, XrefRangeEnd = 143800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Resist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resist_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 143807, RefRangeEnd = 143813, XrefRangeStart = 143806, XrefRangeEnd = 143807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MaxPower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxPower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143814, RefRangeEnd = 143815, XrefRangeStart = 143813, XrefRangeEnd = 143814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FullFillPower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullFillPower_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143817, XrefRangeStart = 143815, XrefRangeEnd = 143816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 143819, RefRangeEnd = 143823, XrefRangeStart = 143817, XrefRangeEnd = 143819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeNowPower(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNowPower_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 143823, RefRangeEnd = 143825, XrefRangeStart = 143823, XrefRangeEnd = 143823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(HorseData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_HorseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void AddHorseArmor(HorseData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHorseArmor_Public_Void_HorseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void RemoveHorseArmor(HorseData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHorseArmor_Public_Void_HorseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 143843, RefRangeEnd = 143859, XrefRangeStart = 143825, XrefRangeEnd = 143843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHorseStateSpeAdd(float originState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&originState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorseStateSpeAdd_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143987, RefRangeEnd = 143988, XrefRangeStart = 143859, XrefRangeEnd = 143987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public HorseData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
