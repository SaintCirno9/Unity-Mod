using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class ForceSpeAddData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_forceSpeAddData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_ForceSpeAddData_ForceSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_ForceSpeAddData_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_ForceSpeAddDataType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_ForceSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMulti_Public_Void_ForceSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMulti_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe Dictionary<int, float> forceSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static ForceSpeAddData()
	{
		Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ForceSpeAddData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr);
		NativeFieldInfoPtr_forceSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, "forceSpeAddData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667103);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667104);
		NativeMethodInfoPtr_Set_Public_ForceSpeAddData_ForceSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667105);
		NativeMethodInfoPtr_Set_Public_ForceSpeAddData_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667106);
		NativeMethodInfoPtr_Get_Public_Single_ForceSpeAddDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667107);
		NativeMethodInfoPtr_Get_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667108);
		NativeMethodInfoPtr_Change_Public_Void_ForceSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667109);
		NativeMethodInfoPtr_Change_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667110);
		NativeMethodInfoPtr_ChangeMulti_Public_Void_ForceSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667111);
		NativeMethodInfoPtr_ChangeMulti_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667112);
		NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667113);
		NativeMethodInfoPtr_isEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667114);
		NativeMethodInfoPtr_op_Addition_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667115);
		NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667116);
		NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667117);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667118);
		NativeMethodInfoPtr_GetDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667119);
		NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667120);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr, 100667121);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 119827, RefRangeEnd = 119832, XrefRangeStart = 119819, XrefRangeEnd = 119827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceSpeAddData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceSpeAddData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119832, XrefRangeEnd = 119842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119842, XrefRangeEnd = 119843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceSpeAddData Set(ForceSpeAddDataType speAddDataType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_ForceSpeAddData_ForceSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 119851, RefRangeEnd = 119864, XrefRangeStart = 119843, XrefRangeEnd = 119851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForceSpeAddData Set(int speAddDataType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_ForceSpeAddData_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 119865, RefRangeEnd = 119895, XrefRangeStart = 119864, XrefRangeEnd = 119865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Get(ForceSpeAddDataType speAddDataType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speAddDataType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Single_ForceSpeAddDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 119899, RefRangeEnd = 119932, XrefRangeStart = 119895, XrefRangeEnd = 119899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Get(int speAddDataType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speAddDataType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119934, RefRangeEnd = 119935, XrefRangeStart = 119932, XrefRangeEnd = 119934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(ForceSpeAddDataType speAddDataType, float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_ForceSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119934, RefRangeEnd = 119935, XrefRangeStart = 119934, XrefRangeEnd = 119935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(int speAddDataType, float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119935, XrefRangeEnd = 119937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMulti(ForceSpeAddDataType speAddDataType, float multi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multi;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMulti_Public_Void_ForceSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMulti(int speAddDataType, float multi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multi;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMulti_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119937, XrefRangeEnd = 119944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119944, XrefRangeEnd = 119966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120002, RefRangeEnd = 120005, XrefRangeStart = 119966, XrefRangeEnd = 120002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceSpeAddData operator +(ForceSpeAddData a, ForceSpeAddData b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120005, XrefRangeEnd = 120006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceSpeAddData operator *(ForceSpeAddData a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120035, RefRangeEnd = 120037, XrefRangeStart = 120006, XrefRangeEnd = 120035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceSpeAddData operator *(ForceSpeAddData a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_ForceSpeAddData_ForceSpeAddData_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120037, XrefRangeEnd = 120073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceSpeAddData operator -(ForceSpeAddData a, ForceSpeAddData b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_ForceSpeAddData_ForceSpeAddData_ForceSpeAddData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceSpeAddData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120074, RefRangeEnd = 120076, XrefRangeStart = 120073, XrefRangeEnd = 120074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120155, RefRangeEnd = 120157, XrefRangeStart = 120076, XrefRangeEnd = 120155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe(bool noLocal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&noLocal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 120172, RefRangeEnd = 120176, XrefRangeStart = 120157, XrefRangeEnd = 120172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ForceSpeAddData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
