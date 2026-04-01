using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class FreeTradeUIController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_freeTradeUIType;

	private static readonly IntPtr NativeFieldInfoPtr_resourceNum;

	private static readonly IntPtr NativeFieldInfoPtr_resourceValueRateChange;

	private static readonly IntPtr NativeFieldInfoPtr_money;

	private static readonly IntPtr NativeFieldInfoPtr_freeTradeUIPanel;

	private static readonly IntPtr NativeFieldInfoPtr_playerForce;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_FreeTradeUIController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideFreeTradeUI_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowFreeTradeUI_Public_Void_FreeTradeUIType_ForceData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SureButtonClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetResource_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceValueRate_Public_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_FreshFreeTradeUI_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlusMinusButtonClicked_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FreeTradeUIType freeTradeUIType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeTradeUIType);
			return *(FreeTradeUIType*)num;
		}
		set
		{
			*(FreeTradeUIType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeTradeUIType)) = freeTradeUIType;
		}
	}

	public unsafe List<float> resourceNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceNum);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceNum)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> resourceValueRateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateChange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceValueRateChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float money
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money)) = num;
		}
	}

	public unsafe GameObject freeTradeUIPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeTradeUIPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeTradeUIPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe ForceData playerForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerForce);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerForce)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceData));
		}
	}

	public unsafe static FreeTradeUIController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FreeTradeUIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)freeTradeUIController));
		}
	}

	public unsafe static FreeTradeUIController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159018, XrefRangeEnd = 159020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_FreeTradeUIController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FreeTradeUIController>(intPtr) : null;
		}
	}

	static FreeTradeUIController()
	{
		Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FreeTradeUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr);
		NativeFieldInfoPtr_freeTradeUIType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "freeTradeUIType");
		NativeFieldInfoPtr_resourceNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "resourceNum");
		NativeFieldInfoPtr_resourceValueRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "resourceValueRateChange");
		NativeFieldInfoPtr_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "money");
		NativeFieldInfoPtr_freeTradeUIPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "freeTradeUIPanel");
		NativeFieldInfoPtr_playerForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "playerForce");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_FreeTradeUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668510);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668511);
		NativeMethodInfoPtr_HideFreeTradeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668512);
		NativeMethodInfoPtr_ShowFreeTradeUI_Public_Void_FreeTradeUIType_ForceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668513);
		NativeMethodInfoPtr_SureButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668514);
		NativeMethodInfoPtr_ResetResource_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668515);
		NativeMethodInfoPtr_GetResourceValueRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668516);
		NativeMethodInfoPtr_FreshFreeTradeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668517);
		NativeMethodInfoPtr_PlusMinusButtonClicked_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668518);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr, 100668519);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159020, XrefRangeEnd = 159023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159023, XrefRangeEnd = 159026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideFreeTradeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideFreeTradeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159049, RefRangeEnd = 159050, XrefRangeStart = 159026, XrefRangeEnd = 159049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowFreeTradeUI(FreeTradeUIType targetType, ForceData targetForce)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&targetType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetForce);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowFreeTradeUI_Public_Void_FreeTradeUIType_ForceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159050, XrefRangeEnd = 159084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SureButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SureButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159093, RefRangeEnd = 159094, XrefRangeStart = 159084, XrefRangeEnd = 159093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetResource_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 159127, RefRangeEnd = 159132, XrefRangeStart = 159094, XrefRangeEnd = 159127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetResourceValueRate(int resourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&resourceID);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceValueRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 159179, RefRangeEnd = 159182, XrefRangeStart = 159132, XrefRangeEnd = 159179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreshFreeTradeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreshFreeTradeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159182, XrefRangeEnd = 159262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlusMinusButtonClicked(GameObject buttonClicked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttonClicked);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlusMinusButtonClicked_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159262, XrefRangeEnd = 159301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FreeTradeUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeTradeUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FreeTradeUIController(IntPtr pointer)
		: base(pointer)
	{
	}
}
