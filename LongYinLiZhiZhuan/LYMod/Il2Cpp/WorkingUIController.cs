using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class WorkingUIController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_workingUI;

	private static readonly IntPtr NativeFieldInfoPtr_workName;

	private static readonly IntPtr NativeFieldInfoPtr_workingFuc;

	private static readonly IntPtr NativeFieldInfoPtr_workingFucParam;

	private static readonly IntPtr NativeFieldInfoPtr_finishFuc;

	private static readonly IntPtr NativeFieldInfoPtr_finishFucParam;

	private static readonly IntPtr NativeFieldInfoPtr_working;

	private static readonly IntPtr NativeFieldInfoPtr_leftWorkingDay;

	private static readonly IntPtr NativeFieldInfoPtr_totalWorkingDay;

	private static readonly IntPtr NativeFieldInfoPtr_nextDayTime;

	private static readonly IntPtr NativeFieldInfoPtr_leftPauseTime;

	private static readonly IntPtr NativeFieldInfoPtr_dayTime;

	private static readonly IntPtr NativeFieldInfoPtr_pauseTime;

	private static readonly IntPtr NativeFieldInfoPtr_resourceNum;

	private static readonly IntPtr NativeFieldInfoPtr_workFinished;

	private static readonly IntPtr NativeFieldInfoPtr_noCancel;

	private static readonly IntPtr NativeFieldInfoPtr_skipping;

	private static readonly IntPtr NativeFieldInfoPtr_skipButton;

	private static readonly IntPtr NativeFieldInfoPtr_newObj;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WorkingUIController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryCancelWorking_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_String_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopWorking_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddResourceNum_Public_Void_Int32_Single_Single_WorkResultType_0;

	private static readonly IntPtr NativeMethodInfoPtr_SkipButtonClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkippingState_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject workingUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingUI);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string workName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string workingFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingFuc);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string workingFucParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingFucParam);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingFucParam)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string finishFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFuc);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string finishFucParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFucParam);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishFucParam)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool working
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_working);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_working)) = flag;
		}
	}

	public unsafe int leftWorkingDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWorkingDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWorkingDay)) = num;
		}
	}

	public unsafe int totalWorkingDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalWorkingDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalWorkingDay)) = num;
		}
	}

	public unsafe float nextDayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextDayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextDayTime)) = num;
		}
	}

	public unsafe float leftPauseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPauseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPauseTime)) = num;
		}
	}

	public unsafe static float dayTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dayTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dayTime, (void*)(&num));
		}
	}

	public unsafe static float pauseTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pauseTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pauseTime, (void*)(&num));
		}
	}

	public unsafe float resourceNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceNum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceNum)) = num;
		}
	}

	public unsafe bool workFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workFinished)) = flag;
		}
	}

	public unsafe bool noCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noCancel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noCancel)) = flag;
		}
	}

	public unsafe bool skipping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipping)) = flag;
		}
	}

	public unsafe GameObject skipButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipButton);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject newObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObj);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static WorkingUIController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WorkingUIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workingUIController));
		}
	}

	public unsafe static WorkingUIController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342199, XrefRangeEnd = 342203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_WorkingUIController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WorkingUIController>(intPtr) : null;
		}
	}

	static WorkingUIController()
	{
		Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkingUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr);
		NativeFieldInfoPtr_workingUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "workingUI");
		NativeFieldInfoPtr_workName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "workName");
		NativeFieldInfoPtr_workingFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "workingFuc");
		NativeFieldInfoPtr_workingFucParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "workingFucParam");
		NativeFieldInfoPtr_finishFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "finishFuc");
		NativeFieldInfoPtr_finishFucParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "finishFucParam");
		NativeFieldInfoPtr_working = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "working");
		NativeFieldInfoPtr_leftWorkingDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "leftWorkingDay");
		NativeFieldInfoPtr_totalWorkingDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "totalWorkingDay");
		NativeFieldInfoPtr_nextDayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "nextDayTime");
		NativeFieldInfoPtr_leftPauseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "leftPauseTime");
		NativeFieldInfoPtr_dayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "dayTime");
		NativeFieldInfoPtr_pauseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "pauseTime");
		NativeFieldInfoPtr_resourceNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "resourceNum");
		NativeFieldInfoPtr_workFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "workFinished");
		NativeFieldInfoPtr_noCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "noCancel");
		NativeFieldInfoPtr_skipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "skipping");
		NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "skipButton");
		NativeFieldInfoPtr_newObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "newObj");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_WorkingUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672122);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672123);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672124);
		NativeMethodInfoPtr_TryCancelWorking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672125);
		NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672126);
		NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672127);
		NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672128);
		NativeMethodInfoPtr_StartWorking_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672129);
		NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672130);
		NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672131);
		NativeMethodInfoPtr_StopWorking_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672132);
		NativeMethodInfoPtr_AddResourceNum_Public_Void_Int32_Single_Single_WorkResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672133);
		NativeMethodInfoPtr_SkipButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672134);
		NativeMethodInfoPtr_SetSkippingState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672135);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr, 100672136);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342203, XrefRangeEnd = 342208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342208, XrefRangeEnd = 342327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342327, XrefRangeEnd = 342354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryCancelWorking()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCancelWorking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342359, RefRangeEnd = 342360, XrefRangeStart = 342354, XrefRangeEnd = 342359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(int dayNum, string callFuc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&dayNum);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFuc);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 342363, RefRangeEnd = 342366, XrefRangeStart = 342360, XrefRangeEnd = 342363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&dayNum);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFucParam);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFucParam);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_Int32_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 342369, RefRangeEnd = 342371, XrefRangeStart = 342366, XrefRangeEnd = 342369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(string _workName, int dayNum, string callFuc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_workName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dayNum;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFuc);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342387, RefRangeEnd = 342388, XrefRangeStart = 342371, XrefRangeEnd = 342387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(List<string> paramList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramList);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 342408, RefRangeEnd = 342447, XrefRangeStart = 342388, XrefRangeEnd = 342408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(string _workName, int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_workName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dayNum;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFucParam);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFucParam);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 342467, RefRangeEnd = 342468, XrefRangeStart = 342447, XrefRangeEnd = 342467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartWorking(string _workName, int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam, bool _noCancel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_workName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dayNum;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callFucParam);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFuc);
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finishCallFucParam);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &_noCancel;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartWorking_Public_Void_String_Int32_String_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 342484, RefRangeEnd = 342487, XrefRangeStart = 342468, XrefRangeEnd = 342484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopWorking(bool finished)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&finished);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopWorking_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 342525, RefRangeEnd = 342527, XrefRangeStart = 342487, XrefRangeEnd = 342525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddResourceNum(int resourceID, float num, float iconNum, WorkResultType workResultType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&resourceID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &num;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &iconNum;
		*(WorkResultType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &workResultType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddResourceNum_Public_Void_Int32_Single_Single_WorkResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342527, XrefRangeEnd = 342538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342538, XrefRangeEnd = 342549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkippingState(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkippingState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorkingUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkingUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorkingUIController(IntPtr pointer)
		: base(pointer)
	{
	}
}
