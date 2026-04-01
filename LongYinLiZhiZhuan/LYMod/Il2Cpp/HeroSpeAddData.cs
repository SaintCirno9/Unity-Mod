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
public class HeroSpeAddData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heroSpeAddData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverWriteHeroSpeAddData_Public_Void_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_HeroSpeAddData_HeroSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_HeroSpeAddData_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_HeroSpeAddDataType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_HeroSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMulti_Public_Void_HeroSpeAddDataType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMulti_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multi_Public_HeroSpeAddData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMergeSpeAdd_Public_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescribe_Public_String_Int32_Int32_Boolean_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LimitMaxNum_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe Dictionary<int, float> heroSpeAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroSpeAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroSpeAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static HeroSpeAddData()
	{
		Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroSpeAddData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr);
		NativeFieldInfoPtr_heroSpeAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, "heroSpeAddData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667820);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667821);
		NativeMethodInfoPtr_OverWriteHeroSpeAddData_Public_Void_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667822);
		NativeMethodInfoPtr_Set_Public_HeroSpeAddData_HeroSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667823);
		NativeMethodInfoPtr_Set_Public_HeroSpeAddData_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667824);
		NativeMethodInfoPtr_Get_Public_Single_HeroSpeAddDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667825);
		NativeMethodInfoPtr_Get_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667826);
		NativeMethodInfoPtr_Change_Public_Void_HeroSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667827);
		NativeMethodInfoPtr_Change_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667828);
		NativeMethodInfoPtr_ChangeMulti_Public_Void_HeroSpeAddDataType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667829);
		NativeMethodInfoPtr_ChangeMulti_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667830);
		NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667831);
		NativeMethodInfoPtr_isEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667832);
		NativeMethodInfoPtr_op_Addition_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667833);
		NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667834);
		NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667835);
		NativeMethodInfoPtr_Multi_Public_HeroSpeAddData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667836);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667837);
		NativeMethodInfoPtr_GetValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667838);
		NativeMethodInfoPtr_GetMergeSpeAdd_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667839);
		NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667840);
		NativeMethodInfoPtr_GetDescribe_Public_String_Int32_Int32_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667841);
		NativeMethodInfoPtr_LimitMaxNum_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667842);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr, 100667843);
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 138378, RefRangeEnd = 138449, XrefRangeStart = 138370, XrefRangeEnd = 138378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroSpeAddData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 138459, RefRangeEnd = 138469, XrefRangeStart = 138449, XrefRangeEnd = 138459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 138497, RefRangeEnd = 138499, XrefRangeStart = 138469, XrefRangeEnd = 138497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OverWriteHeroSpeAddData(HeroSpeAddData overWriteData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overWriteData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverWriteHeroSpeAddData_Public_Void_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 138500, RefRangeEnd = 138511, XrefRangeStart = 138499, XrefRangeEnd = 138500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData Set(HeroSpeAddDataType speAddDataType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_HeroSpeAddData_HeroSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 138519, RefRangeEnd = 138551, XrefRangeStart = 138511, XrefRangeEnd = 138519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData Set(int speAddDataType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_HeroSpeAddData_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(182)]
	[CachedScanResults(RefRangeStart = 138552, RefRangeEnd = 138734, XrefRangeStart = 138551, XrefRangeEnd = 138552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Get(HeroSpeAddDataType speAddDataType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speAddDataType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Single_HeroSpeAddDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(73)]
	[CachedScanResults(RefRangeStart = 138738, RefRangeEnd = 138811, XrefRangeStart = 138734, XrefRangeEnd = 138738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(101)]
	[CachedScanResults(RefRangeStart = 138813, RefRangeEnd = 138914, XrefRangeStart = 138811, XrefRangeEnd = 138813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(HeroSpeAddDataType speAddDataType, float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_HeroSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(101)]
	[CachedScanResults(RefRangeStart = 138813, RefRangeEnd = 138914, XrefRangeStart = 138813, XrefRangeEnd = 138914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 138916, RefRangeEnd = 138922, XrefRangeStart = 138914, XrefRangeEnd = 138916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMulti(HeroSpeAddDataType speAddDataType, float multi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speAddDataType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multi;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMulti_Public_Void_HeroSpeAddDataType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 138916, RefRangeEnd = 138922, XrefRangeStart = 138916, XrefRangeEnd = 138922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 138929, RefRangeEnd = 138937, XrefRangeStart = 138922, XrefRangeEnd = 138929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 138959, RefRangeEnd = 138972, XrefRangeStart = 138937, XrefRangeEnd = 138959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(52)]
	[CachedScanResults(RefRangeStart = 139022, RefRangeEnd = 139074, XrefRangeStart = 138972, XrefRangeEnd = 139022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HeroSpeAddData operator +(HeroSpeAddData a, HeroSpeAddData b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 139075, RefRangeEnd = 139083, XrefRangeStart = 139074, XrefRangeEnd = 139075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HeroSpeAddData operator *(HeroSpeAddData a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 139112, RefRangeEnd = 139125, XrefRangeStart = 139083, XrefRangeEnd = 139112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HeroSpeAddData operator *(HeroSpeAddData a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_HeroSpeAddData_HeroSpeAddData_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 139154, RefRangeEnd = 139159, XrefRangeStart = 139125, XrefRangeEnd = 139154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData Multi(float b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multi_Public_HeroSpeAddData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139159, XrefRangeEnd = 139195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HeroSpeAddData operator -(HeroSpeAddData a, HeroSpeAddData b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_HeroSpeAddData_HeroSpeAddData_HeroSpeAddData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139222, RefRangeEnd = 139224, XrefRangeStart = 139195, XrefRangeEnd = 139222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 139237, RefRangeEnd = 139240, XrefRangeStart = 139224, XrefRangeEnd = 139237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMergeSpeAdd(int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMergeSpeAdd_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 139241, RefRangeEnd = 139269, XrefRangeStart = 139240, XrefRangeEnd = 139241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe(bool useColor = true, bool newLine = true, int digits = 1, bool merge = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&useColor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLine;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 139431, RefRangeEnd = 139435, XrefRangeStart = 139269, XrefRangeEnd = 139431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDescribe(int startID, int endID, bool useColor = true, bool newLine = true, int digits = 1, bool merge = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&startID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endID;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useColor;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLine;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &merge;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescribe_Public_String_Int32_Int32_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 139457, RefRangeEnd = 139461, XrefRangeStart = 139435, XrefRangeEnd = 139457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LimitMaxNum(int maxNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LimitMaxNum_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 139476, RefRangeEnd = 139487, XrefRangeStart = 139461, XrefRangeEnd = 139476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public HeroSpeAddData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
