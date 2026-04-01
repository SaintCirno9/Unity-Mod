using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSpine.Unity;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp;

public class GlobalData : Il2CppSystem.Object
{
	[ObfuscatedName("GlobalData+<>c__DisplayClass262_0")]
	public sealed class __c__DisplayClass262_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_temp;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateFlyIcon_b__0_Internal_Void_0;

		public unsafe GameObject temp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		static __c__DisplayClass262_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass262_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr);
			NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, "temp");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, 100669105);
			NativeMethodInfoPtr__GenerateFlyIcon_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, 100669106);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass262_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184724, XrefRangeEnd = 184728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GenerateFlyIcon_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateFlyIcon_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass262_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("GlobalData+<>c__DisplayClass277_0")]
	public sealed class __c__DisplayClass277_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ListFather;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ListContain_b__0_Internal_Boolean_Int32_0;

		public unsafe List<int> ListFather
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListFather);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListFather)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static __c__DisplayClass277_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass277_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr);
			NativeFieldInfoPtr_ListFather = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, "ListFather");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, 100669107);
			NativeMethodInfoPtr__ListContain_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, 100669108);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass277_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184728, XrefRangeEnd = 184732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ListContain_b__0(int item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ListContain_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass277_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("GlobalData+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__291_5;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__295_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_0_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_1_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_2_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_3_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_4_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortHeroList_b__291_5_Internal_Int32_HeroData_HeroData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConvertNumToChinese_b__295_0_Internal_List_1_List_1_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__333_0_Internal_Random_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<HeroData> __9__291_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__291_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HeroData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__291_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Func<int, List<List<int>>> __9__295_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__295_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int, List<List<int>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__295_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__291_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_0");
			NativeFieldInfoPtr___9__291_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_1");
			NativeFieldInfoPtr___9__291_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_2");
			NativeFieldInfoPtr___9__291_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_3");
			NativeFieldInfoPtr___9__291_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_4");
			NativeFieldInfoPtr___9__291_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__291_5");
			NativeFieldInfoPtr___9__295_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__295_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669110);
			NativeMethodInfoPtr__SortHeroList_b__291_0_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669111);
			NativeMethodInfoPtr__SortHeroList_b__291_1_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669112);
			NativeMethodInfoPtr__SortHeroList_b__291_2_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669113);
			NativeMethodInfoPtr__SortHeroList_b__291_3_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669114);
			NativeMethodInfoPtr__SortHeroList_b__291_4_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669115);
			NativeMethodInfoPtr__SortHeroList_b__291_5_Internal_Int32_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669116);
			NativeMethodInfoPtr__ConvertNumToChinese_b__295_0_Internal_List_1_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669117);
			NativeMethodInfoPtr___cctor_b__333_0_Internal_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669118);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184732, XrefRangeEnd = 184733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_0(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_0_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184733, XrefRangeEnd = 184734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_1(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_1_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_2(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_2_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184734, XrefRangeEnd = 184736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_3(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_3_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_4(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_4_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184736, XrefRangeEnd = 184738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortHeroList_b__291_5(HeroData h1, HeroData h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortHeroList_b__291_5_Internal_Int32_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184738, XrefRangeEnd = 184767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<List<int>> _ConvertNumToChinese_b__295_0(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConvertNumToChinese_b__295_0_Internal_List_1_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184767, XrefRangeEnd = 184776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Random __cctor_b__333_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__333_0_Internal_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("GlobalData+<>c__DisplayClass295_0")]
	public sealed class __c__DisplayClass295_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_unit;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConvertNumToChinese_b__1_Internal_String_List_1_List_1_Int32_0;

		public unsafe string unit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass295_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass295_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr);
			NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, "unit");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, 100669119);
			NativeMethodInfoPtr__ConvertNumToChinese_b__1_Internal_String_List_1_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, 100669120);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass295_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184776, XrefRangeEnd = 184849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ConvertNumToChinese_b__1(List<List<int>> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConvertNumToChinese_b__1_Internal_String_List_1_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public __c__DisplayClass295_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("GlobalData+<>c__DisplayClass320_0")]
	public sealed class __c__DisplayClass320_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_targetText;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DoTweenTextValue_b__0_Internal_Void_Single_0;

		public unsafe Text targetText
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetText);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text));
			}
		}

		static __c__DisplayClass320_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass320_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr);
			NativeFieldInfoPtr_targetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr, "targetText");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr, 100669121);
			NativeMethodInfoPtr__DoTweenTextValue_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr, 100669122);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass320_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass320_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184849, XrefRangeEnd = 184852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DoTweenTextValue_b__0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoTweenTextValue_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass320_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("GlobalData+<>c__DisplayClass321_0")]
	public sealed class __c__DisplayClass321_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_targetSkeleton;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DoTweenSkeletonAlpha_b__0_Internal_Void_Single_0;

		public unsafe SkeletonAnimation targetSkeleton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSkeleton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonAnimation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSkeleton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonAnimation));
			}
		}

		static __c__DisplayClass321_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass321_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr);
			NativeFieldInfoPtr_targetSkeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr, "targetSkeleton");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr, 100669123);
			NativeMethodInfoPtr__DoTweenSkeletonAlpha_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr, 100669124);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass321_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass321_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184852, XrefRangeEnd = 184853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DoTweenSkeletonAlpha_b__0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoTweenSkeletonAlpha_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass321_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("GlobalData+<>c__DisplayClass330_0")]
	public struct __c__DisplayClass330_0
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		[FieldOffset(0)]
		public float height;

		static __c__DisplayClass330_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass330_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass330_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass330_0>.NativeClassPtr);
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass330_0>.NativeClassPtr, "height");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__c__DisplayClass330_0>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("GlobalData+<>c__DisplayClass331_0")]
	public struct __c__DisplayClass331_0
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		[FieldOffset(0)]
		public float height;

		static __c__DisplayClass331_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass331_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "<>c__DisplayClass331_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass331_0>.NativeClassPtr);
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass331_0>.NativeClassPtr, "height");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__c__DisplayClass331_0>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_GameVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_DemoVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuildVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableAutoSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTestAvailableAreaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTestAvailableForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTestAvailableInnID;

	private static readonly System.IntPtr NativeFieldInfoPtr_SteamAppID;

	private static readonly System.IntPtr NativeFieldInfoPtr_WegameAppID;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SteamDLCIDList;

	private static readonly System.IntPtr NativeFieldInfoPtr_WegameDLCIDList;

	private static readonly System.IntPtr NativeFieldInfoPtr_SteamDLCUrlList;

	private static readonly System.IntPtr NativeFieldInfoPtr_WegameDLCUrlList;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTestMaxLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTestMaxFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_VersionNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_Use_Full_Dirty_Words;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAreaStateDefenceRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttackAreaFightScoreRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAttackSkillNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxFriendNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLoverNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxBrotherNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeroNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_RecommendHeroNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MapBorderWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_MapBorderHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResulotionChoice;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameModeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameDifficultName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameDifficultDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_NumText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChineseNumText;

	private static readonly System.IntPtr NativeFieldInfoPtr_TraditionalChineseReplaceFontName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLogNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroBaseHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroBaseMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroMaxAttriNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroMaxFightSkillNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroMaxLivingSkillNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigMapWidthHalf;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigMapHeightHalf;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigMapVectorScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempHeroIDStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_SummonSkillIDStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameObjScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaMapTileSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldMapMaxTryTimes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Infinity;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseTravelSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseTravelTimeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIMoveThinkTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIAttackThinkTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuildingUpgradeAddProduceRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrimeBadFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_RestBaseRecoverRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalBaseRecoverRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSkillAttriNeedNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxSkillNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_CureInjuryToFavorRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_FlipXScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoPracticeExpRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxInternalSkillSelfStudyLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxFightSkillSelfStudyLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoFemaleForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeWeakHeroName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeMasterName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeNoRandomName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeTeammateName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeSkeletonName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAutoSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftFootStepEventName;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftFootBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightFootStepEventName;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightFootBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseFootStepEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseFootStepTargetBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_FacePartName;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceSlotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseSlotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillWeaponTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_StealItemBadFameValueRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_RobItemBadFameValueRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleMapCol;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleMapRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAreaMapCol;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAreaMapRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxExploreMapCol;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxExploreMapRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseSprintLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseSprintCd;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourcePointFightMaxHeroNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxInfoCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxFightMovePower;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBrightOriginColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBrightBlueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBlueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBrightYellowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelDarkYellowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBrightPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelDarkPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BrightPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_PositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DarkPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeepDarkPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_MostDarkPositiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelBrightNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelDarkNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BrightNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DarkNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeepDarkNegativeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightBlueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeepDarkBlueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LabelZeroColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisactiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DarkestSkinColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighLightYellowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DarkYellowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonDarkYellowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockedForceSpeFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_HaveSpeInteractWithNPCForceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_InjuryName;

	private static readonly System.IntPtr NativeFieldInfoPtr_InjuryColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeasonName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroForceLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroServantForceLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroGovernLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroHornorLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroGovernLvType;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroGovernUpgradeNeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroFreeForceLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroBadForceLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MartialClubLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextType;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaSafeRangeRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourceLivingSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourceValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleTypeDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionSourceTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttackRangeTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DamageRangeTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttackDirectionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttackDirectionDamageRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttackDirectionExtraAccRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttriName;

	private static readonly System.IntPtr NativeFieldInfoPtr_FightSkillName;

	private static readonly System.IntPtr NativeFieldInfoPtr_FightSkillUpgradeBuildingDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_LivingSkillName;

	private static readonly System.IntPtr NativeFieldInfoPtr_LivingSkillUpgradeBuildingDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceLvDetailDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLvMulti;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecorationTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_FoodTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BookRareLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureRareLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureValueLvTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureValueLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TreasureRareLvTalkText;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaterialTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorseTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnemyRobberTalkText;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyPointName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveRangeNeedAttriNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttriRatioString;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttriLvNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaLabelFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CraftTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnhanceTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CraftPoisonTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BookWriterTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChaosText;

	private static readonly System.IntPtr NativeFieldInfoPtr_EvilText;

	private static readonly System.IntPtr NativeFieldInfoPtr_NatureText;

	private static readonly System.IntPtr NativeFieldInfoPtr_TalentText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceFocusTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleScoreText;

	private static readonly System.IntPtr NativeFieldInfoPtr_BranchDefenceTypeText;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipTotalWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipBaseWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentWeightLvName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipWeightLvSpeedMulti;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartPostureName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartPostureChangeSpeAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartPostureEmptySpeAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaStateName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddAreaStateLivingSkillType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReduceAreaStateLivingSkillType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillChangePowerRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaObstacleNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_BookStorageRateLvAddRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillBreakThroughDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillObstacleLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_BreakThroughRareRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_AvailableBeardID;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoRandomMaleFaceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoRandomFemaleFaceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CheckReplaceSpeEffectList;

	private static readonly System.IntPtr NativeFieldInfoPtr_FavorLvText;

	private static readonly System.IntPtr NativeFieldInfoPtr_CenterBuildingUpgradePeopleLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_CenterBuildingUpgradeHeroLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_StudyNewSkillCostFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_TeachNewSkillAddFavor;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleTypeAutoGetExpRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleTypeGetFameRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroSoundAudioSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_threadRandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_CheckSpeForceIcon;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChineseNumText_Public_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInjuryIconName_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttriLv_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBreakThroughRateLv_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFavorText_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumText_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringReplace_Public_Static_String_String_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEvilText_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChaosText_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListAddTo_Public_Static_Void_List_1_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListMinusTo_Public_Static_Void_List_1_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListAdd_Public_Static_List_1_Single_List_1_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListMinus_Public_Static_List_1_Single_List_1_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListMulti_Public_Static_List_1_Single_List_1_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListEqual_Public_Static_Boolean_List_1_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteAllChild_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAll_Public_Static_Void_List_1_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteAllNull_Public_Static_Void_List_1_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceSpeString_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRareLvColorText_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_ResourceDescribeType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_ResourceDescribeType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountArmorDamageRate_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertEnter_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertFormat_Public_Static_String_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceFavorLvText_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceFavorLvColor_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSprite_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddImage_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateFlyIcon_Public_Static_Void_Sprite_Vector3_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortByName_Public_Static_Int32_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortChild_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorAlpha_Public_Static_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeUIPixelPerfect_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZToZero_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_ResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_String_Vector3_String_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_String_Vector3_String_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDifficultyColor_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDifficultyStarString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListContain_Public_Static_Boolean_List_1_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_HeroData_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaculateWinTeam_Public_Static_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalFightScore_Public_Static_Single_List_1_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonAnimation_Int32_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonGraphic_Int32_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LimitHeroList_Public_Static_Void_List_1_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortHeroList_Public_Static_List_1_HeroData_List_1_HeroData_HeroListSortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFullScreen_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoSetWindowResolution_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertNumToChinese_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGovernSalary_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayHeroSound_Public_Static_AudioSource_AudioClip_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChinese_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRequireTypeText_Public_Static_String_ChoiceRequirementType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHobbyString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_ItemType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListRandomRemove_Public_Static_Void_List_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseAttriName_Public_Static_String_BaseAttriType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParticleColor_Public_Static_Void_GameObject_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountColor_Public_Static_Color_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThreadRandom_Public_Static_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomRange_Public_Static_Single_Single_Single_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomRangeDouble_Public_Static_Double_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformScreenDeltaToLocalDelta_Public_Static_Vector3_Vector2_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTweenTextValue_Public_Static_Void_Text_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTweenSkeletonAlpha_Public_Static_Void_SkeletonAnimation_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadVector2_Public_Static_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceIconName_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEmptyString_Public_Static_List_1_String_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInputing_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parabola_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parabola_Public_Static_Vector2_Vector2_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass330_0_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass331_0_PDM_0;

	public unsafe static Version GameVersion
	{
		get
		{
			Unsafe.SkipInit(out Version result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameVersion, (void*)(&version));
		}
	}

	public unsafe static DemoVersion DemoVersion
	{
		get
		{
			Unsafe.SkipInit(out DemoVersion result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DemoVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DemoVersion, (void*)(&demoVersion));
		}
	}

	public unsafe static BuildVersion BuildVersion
	{
		get
		{
			Unsafe.SkipInit(out BuildVersion result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BuildVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BuildVersion, (void*)(&buildVersion));
		}
	}

	public unsafe static bool DisableAutoSave
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableAutoSave, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableAutoSave, (void*)(&flag));
		}
	}

	public unsafe static List<int> PlayTestAvailableAreaID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayTestAvailableAreaID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayTestAvailableAreaID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> PlayTestAvailableForceID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayTestAvailableForceID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayTestAvailableForceID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> PlayTestAvailableInnID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayTestAvailableInnID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayTestAvailableInnID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static ulong SteamAppID
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SteamAppID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SteamAppID, (void*)(&num));
		}
	}

	public unsafe static ulong WegameAppID
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WegameAppID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WegameAppID, (void*)(&num));
		}
	}

	public unsafe static List<string> DLCName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DLCName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DLCName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> SteamDLCIDList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SteamDLCIDList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SteamDLCIDList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> WegameDLCIDList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WegameDLCIDList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WegameDLCIDList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SteamDLCUrlList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SteamDLCUrlList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SteamDLCUrlList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> WegameDLCUrlList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WegameDLCUrlList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WegameDLCUrlList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int PlayTestMaxLv
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayTestMaxLv, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayTestMaxLv, (void*)(&num));
		}
	}

	public unsafe static int PlayTestMaxFavor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayTestMaxFavor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayTestMaxFavor, (void*)(&num));
		}
	}

	public unsafe static string VersionNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VersionNum, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VersionNum, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FixNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FixNum, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FixNum, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool Use_Full_Dirty_Words
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Use_Full_Dirty_Words, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Use_Full_Dirty_Words, (void*)(&flag));
		}
	}

	public unsafe static float MaxAreaStateDefenceRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAreaStateDefenceRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAreaStateDefenceRate, (void*)(&num));
		}
	}

	public unsafe static float AttackAreaFightScoreRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackAreaFightScoreRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackAreaFightScoreRate, (void*)(&num));
		}
	}

	public unsafe static int MaxAttackSkillNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAttackSkillNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAttackSkillNum, (void*)(&num));
		}
	}

	public unsafe static int MaxFriendNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxFriendNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxFriendNum, (void*)(&num));
		}
	}

	public unsafe static int MaxLoverNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLoverNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLoverNum, (void*)(&num));
		}
	}

	public unsafe static int MaxBrotherNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxBrotherNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxBrotherNum, (void*)(&num));
		}
	}

	public unsafe static int MaxHeroNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxHeroNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxHeroNum, (void*)(&num));
		}
	}

	public unsafe static int RecommendHeroNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RecommendHeroNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RecommendHeroNum, (void*)(&num));
		}
	}

	public unsafe static float MapBorderWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MapBorderWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MapBorderWidth, (void*)(&num));
		}
	}

	public unsafe static float MapBorderHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MapBorderHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MapBorderHeight, (void*)(&num));
		}
	}

	public unsafe static List<string> ResulotionChoice
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResulotionChoice, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResulotionChoice, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> GameModeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameModeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameModeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> GameDifficultName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameDifficultName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameDifficultName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> GameDifficultDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameDifficultDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameDifficultDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string NumText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NumText, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NumText, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ChineseNumText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChineseNumText, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChineseNumText, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<List<string>> TraditionalChineseReplaceFontName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TraditionalChineseReplaceFontName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TraditionalChineseReplaceFontName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int MaxLogNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLogNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLogNum, (void*)(&num));
		}
	}

	public unsafe static int PlayerForceID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerForceID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerForceID, (void*)(&num));
		}
	}

	public unsafe static float HeroBaseHp
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroBaseHp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroBaseHp, (void*)(&num));
		}
	}

	public unsafe static float HeroBaseMp
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroBaseMp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroBaseMp, (void*)(&num));
		}
	}

	public unsafe static int HeroMaxAttriNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroMaxAttriNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroMaxAttriNum, (void*)(&num));
		}
	}

	public unsafe static int HeroMaxFightSkillNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroMaxFightSkillNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroMaxFightSkillNum, (void*)(&num));
		}
	}

	public unsafe static int HeroMaxLivingSkillNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroMaxLivingSkillNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroMaxLivingSkillNum, (void*)(&num));
		}
	}

	public unsafe static float BigMapWidthHalf
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BigMapWidthHalf, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BigMapWidthHalf, (void*)(&num));
		}
	}

	public unsafe static float BigMapHeightHalf
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BigMapHeightHalf, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BigMapHeightHalf, (void*)(&num));
		}
	}

	public unsafe static float BigMapVectorScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BigMapVectorScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BigMapVectorScale, (void*)(&num));
		}
	}

	public unsafe static int TempHeroIDStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempHeroIDStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempHeroIDStart, (void*)(&num));
		}
	}

	public unsafe static int SummonSkillIDStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SummonSkillIDStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SummonSkillIDStart, (void*)(&num));
		}
	}

	public unsafe static float GameObjScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameObjScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameObjScale, (void*)(&num));
		}
	}

	public unsafe static float areaMapTileSize
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_areaMapTileSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_areaMapTileSize, (void*)(&num));
		}
	}

	public unsafe static int WorldMapMaxTryTimes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldMapMaxTryTimes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldMapMaxTryTimes, (void*)(&num));
		}
	}

	public unsafe static int Infinity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Infinity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Infinity, (void*)(&num));
		}
	}

	public unsafe static float BaseTravelSpeed
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseTravelSpeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseTravelSpeed, (void*)(&num));
		}
	}

	public unsafe static float BaseTravelTimeScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseTravelTimeScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseTravelTimeScale, (void*)(&num));
		}
	}

	public unsafe static float AIMoveThinkTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AIMoveThinkTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AIMoveThinkTime, (void*)(&num));
		}
	}

	public unsafe static float AIAttackThinkTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AIAttackThinkTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AIAttackThinkTime, (void*)(&num));
		}
	}

	public unsafe static float BuildingUpgradeAddProduceRatio
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BuildingUpgradeAddProduceRatio, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BuildingUpgradeAddProduceRatio, (void*)(&num));
		}
	}

	public unsafe static float CrimeBadFame
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CrimeBadFame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CrimeBadFame, (void*)(&num));
		}
	}

	public unsafe static float RestBaseRecoverRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RestBaseRecoverRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RestBaseRecoverRate, (void*)(&num));
		}
	}

	public unsafe static float NormalBaseRecoverRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NormalBaseRecoverRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NormalBaseRecoverRate, (void*)(&num));
		}
	}

	public unsafe static List<int> AutoSkillAttriNeedNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoSkillAttriNeedNum, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoSkillAttriNeedNum, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> MaxSkillNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSkillNum, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSkillNum, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static float CureInjuryToFavorRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CureInjuryToFavorRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CureInjuryToFavorRate, (void*)(&num));
		}
	}

	public unsafe static Vector3 FlipXScale
	{
		get
		{
			Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FlipXScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FlipXScale, (void*)(&vector));
		}
	}

	public unsafe static float AutoPracticeExpRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoPracticeExpRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoPracticeExpRate, (void*)(&num));
		}
	}

	public unsafe static int MaxInternalSkillSelfStudyLv
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxInternalSkillSelfStudyLv, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxInternalSkillSelfStudyLv, (void*)(&num));
		}
	}

	public unsafe static int MaxFightSkillSelfStudyLv
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxFightSkillSelfStudyLv, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxFightSkillSelfStudyLv, (void*)(&num));
		}
	}

	public unsafe static List<int> NoFemaleForce
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoFemaleForce, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoFemaleForce, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeWeakHeroName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeWeakHeroName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeWeakHeroName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeMasterName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeMasterName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeMasterName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeNoRandomName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeNoRandomName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeNoRandomName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeTeammateName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeTeammateName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeTeammateName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeSkeletonName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeSkeletonName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeSkeletonName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<int>> AutoSaveData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoSaveData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoSaveData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> DefaultAutoSetting
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultAutoSetting, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultAutoSetting, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string leftFootStepEventName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leftFootStepEventName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leftFootStepEventName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string leftFootBone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leftFootBone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leftFootBone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string rightFootStepEventName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rightFootStepEventName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rightFootStepEventName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string rightFootBone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rightFootBone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rightFootBone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> HorseFootStepEvent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseFootStepEvent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseFootStepEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HorseFootStepTargetBone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseFootStepTargetBone, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseFootStepTargetBone, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FacePartName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FacePartName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FacePartName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FaceSlotName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FaceSlotName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FaceSlotName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HorseSlotName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseSlotName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseSlotName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<string>> SkillWeaponTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillWeaponTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillWeaponTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static float StealItemBadFameValueRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StealItemBadFameValueRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StealItemBadFameValueRate, (void*)(&num));
		}
	}

	public unsafe static float RobItemBadFameValueRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RobItemBadFameValueRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RobItemBadFameValueRate, (void*)(&num));
		}
	}

	public unsafe static int BattleMapCol
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleMapCol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleMapCol, (void*)(&num));
		}
	}

	public unsafe static int BattleMapRow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleMapRow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleMapRow, (void*)(&num));
		}
	}

	public unsafe static int MaxAreaMapCol
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAreaMapCol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAreaMapCol, (void*)(&num));
		}
	}

	public unsafe static int MaxAreaMapRow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAreaMapRow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAreaMapRow, (void*)(&num));
		}
	}

	public unsafe static int MaxExploreMapCol
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxExploreMapCol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxExploreMapCol, (void*)(&num));
		}
	}

	public unsafe static int MaxExploreMapRow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxExploreMapRow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxExploreMapRow, (void*)(&num));
		}
	}

	public unsafe static float HorseSprintLast
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseSprintLast, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseSprintLast, (void*)(&num));
		}
	}

	public unsafe static float HorseSprintCd
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseSprintCd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseSprintCd, (void*)(&num));
		}
	}

	public unsafe static int ResourcePointFightMaxHeroNum
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResourcePointFightMaxHeroNum, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResourcePointFightMaxHeroNum, (void*)(&num));
		}
	}

	public unsafe static int MaxInfoCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxInfoCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxInfoCount, (void*)(&num));
		}
	}

	public unsafe static float MaxFightMovePower
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxFightMovePower, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxFightMovePower, (void*)(&num));
		}
	}

	public unsafe static string LabelBrightOriginColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBrightOriginColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBrightOriginColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelBrightBlueColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBrightBlueColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBrightBlueColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelBlueColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBlueColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBlueColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelBrightYellowColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBrightYellowColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBrightYellowColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelDarkYellowColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelDarkYellowColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelDarkYellowColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelBrightPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBrightPositiveColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBrightPositiveColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelPositiveColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelPositiveColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelDarkPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelDarkPositiveColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelDarkPositiveColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Color BrightPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BrightPositiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BrightPositiveColor, (void*)(&color));
		}
	}

	public unsafe static Color PositiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PositiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PositiveColor, (void*)(&color));
		}
	}

	public unsafe static Color DarkPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DarkPositiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DarkPositiveColor, (void*)(&color));
		}
	}

	public unsafe static Color DeepDarkPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeepDarkPositiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeepDarkPositiveColor, (void*)(&color));
		}
	}

	public unsafe static Color MostDarkPositiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MostDarkPositiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MostDarkPositiveColor, (void*)(&color));
		}
	}

	public unsafe static string LabelBrightNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelBrightNegativeColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelBrightNegativeColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelNegativeColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelNegativeColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LabelDarkNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelDarkNegativeColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelDarkNegativeColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Color BrightNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BrightNegativeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BrightNegativeColor, (void*)(&color));
		}
	}

	public unsafe static Color NegativeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NegativeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NegativeColor, (void*)(&color));
		}
	}

	public unsafe static Color DarkNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DarkNegativeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DarkNegativeColor, (void*)(&color));
		}
	}

	public unsafe static Color DeepDarkNegativeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeepDarkNegativeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeepDarkNegativeColor, (void*)(&color));
		}
	}

	public unsafe static Color LightBlueColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightBlueColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightBlueColor, (void*)(&color));
		}
	}

	public unsafe static Color DeepDarkBlueColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeepDarkBlueColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeepDarkBlueColor, (void*)(&color));
		}
	}

	public unsafe static string LabelZeroColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LabelZeroColor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LabelZeroColor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Color ActiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActiveColor, (void*)(&color));
		}
	}

	public unsafe static Color DisactiveColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisactiveColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisactiveColor, (void*)(&color));
		}
	}

	public unsafe static Color DarkestSkinColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DarkestSkinColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DarkestSkinColor, (void*)(&color));
		}
	}

	public unsafe static Color HighLightYellowColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HighLightYellowColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HighLightYellowColor, (void*)(&color));
		}
	}

	public unsafe static Color DarkYellowColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DarkYellowColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DarkYellowColor, (void*)(&color));
		}
	}

	public unsafe static Color ButtonDarkYellowColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonDarkYellowColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonDarkYellowColor, (void*)(&color));
		}
	}

	public unsafe static List<int> LockedForceSpeFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LockedForceSpeFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LockedForceSpeFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> HaveSpeInteractWithNPCForceID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HaveSpeInteractWithNPCForceID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HaveSpeInteractWithNPCForceID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> InjuryName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InjuryName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InjuryName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<Color> InjuryColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InjuryColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InjuryColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> DirectionName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DirectionName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DirectionName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SeasonName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SeasonName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SeasonName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroForceLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroForceLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroForceLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroServantForceLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroServantForceLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroServantForceLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroGovernLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroGovernLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroGovernLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroHornorLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroHornorLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroHornorLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroGovernLvType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroGovernLvType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroGovernLvType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> HeroGovernUpgradeNeed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroGovernUpgradeNeed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroGovernUpgradeNeed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroFreeForceLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroFreeForceLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroFreeForceLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HeroBadForceLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeroBadForceLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeroBadForceLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> MartialClubLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MartialClubLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MartialClubLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TextType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> AreaTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> AreaSafeRangeRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaSafeRangeRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaSafeRangeRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ResourceName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResourceName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResourceName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<LivingSkillType> ResourceLivingSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResourceLivingSkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LivingSkillType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResourceLivingSkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> ResourceValue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResourceValue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResourceValue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BattleTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BattleTypeDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleTypeDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleTypeDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> MissionSourceTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionSourceTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionSourceTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Il2CppStructArray<Color> MissionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static List<string> AttackRangeTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackRangeTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackRangeTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> DamageRangeTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DamageRangeTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DamageRangeTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> AttackDirectionName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackDirectionName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackDirectionName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> AttackDirectionDamageRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackDirectionDamageRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackDirectionDamageRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> AttackDirectionExtraAccRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttackDirectionExtraAccRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttackDirectionExtraAccRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> AttriName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttriName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttriName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FightSkillName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FightSkillName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FightSkillName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FightSkillUpgradeBuildingDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FightSkillUpgradeBuildingDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FightSkillUpgradeBuildingDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> LivingSkillName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LivingSkillName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LivingSkillName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> LivingSkillUpgradeBuildingDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LivingSkillUpgradeBuildingDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LivingSkillUpgradeBuildingDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ForceLvDetailDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForceLvDetailDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForceLvDetailDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> WeaponLvMulti
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WeaponLvMulti, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WeaponLvMulti, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ItemTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ItemTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ItemTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EquipmentTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipmentTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipmentTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> DecorationTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecorationTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecorationTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FoodTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FoodTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FoodTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EquipLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SkillLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BookRareLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BookRareLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BookRareLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TreasureRareLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureRareLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureRareLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TreasureTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Il2CppObjectBase TreasureItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureItemName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureItemName, (void*)IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe static List<string> TreasureValueLvTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureValueLvTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureValueLvTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TreasureValueLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureValueLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureValueLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TreasureRareLvTalkText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TreasureRareLvTalkText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TreasureRareLvTalkText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> MaterialTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaterialTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaterialTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> HorseTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorseTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorseTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EnemyRobberTalkText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnemyRobberTalkText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnemyRobberTalkText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BodyPointName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BodyPointName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BodyPointName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> MoveRangeNeedAttriNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoveRangeNeedAttriNum, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoveRangeNeedAttriNum, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> AttriRatioString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttriRatioString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttriRatioString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> AttriLvNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttriLvNum, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttriLvNum, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> AreaLabelFontSize
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaLabelFontSize, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaLabelFontSize, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> CraftTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CraftTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CraftTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EnhanceTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnhanceTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnhanceTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> CraftPoisonTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CraftPoisonTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CraftPoisonTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BookWriterTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BookWriterTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BookWriterTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ChaosText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChaosText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChaosText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EvilText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EvilText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EvilText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> NatureText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NatureText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NatureText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> TalentText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TalentText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TalentText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ForceFocusTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForceFocusTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForceFocusTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BattleScoreText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleScoreText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleScoreText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> BranchDefenceTypeText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BranchDefenceTypeText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BranchDefenceTypeText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static float EquipTotalWeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipTotalWeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipTotalWeight, (void*)(&num));
		}
	}

	public unsafe static List<float> EquipBaseWeight
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipBaseWeight, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipBaseWeight, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> EquipmentWeightLvName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipmentWeightLvName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipmentWeightLvName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> EquipWeightLvSpeedMulti
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EquipWeightLvSpeedMulti, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EquipWeightLvSpeedMulti, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> PartPostureName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PartPostureName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PartPostureName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<HeroSpeAddDataType> PartPostureChangeSpeAdd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PartPostureChangeSpeAdd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroSpeAddDataType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PartPostureChangeSpeAdd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<HeroSpeAddDataType>> PartPostureEmptySpeAdd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PartPostureEmptySpeAdd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<HeroSpeAddDataType>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PartPostureEmptySpeAdd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> AreaStateName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaStateName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaStateName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<LivingSkillType> AddAreaStateLivingSkillType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddAreaStateLivingSkillType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LivingSkillType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddAreaStateLivingSkillType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<LivingSkillType> ReduceAreaStateLivingSkillType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReduceAreaStateLivingSkillType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LivingSkillType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReduceAreaStateLivingSkillType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<float>> SkillChangePowerRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillChangePowerRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<float>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillChangePowerRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<int>> AreaObstacleNum
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaObstacleNum, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaObstacleNum, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> BookStorageRateLvAddRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BookStorageRateLvAddRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BookStorageRateLvAddRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> SkillBreakThroughDay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillBreakThroughDay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillBreakThroughDay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<int>> SkillObstacleLv
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillObstacleLv, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillObstacleLv, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> BreakThroughRareRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BreakThroughRareRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BreakThroughRareRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> AvailableBeardID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AvailableBeardID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AvailableBeardID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<int>> NoRandomMaleFaceID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoRandomMaleFaceID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoRandomMaleFaceID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<int>> NoRandomFemaleFaceID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoRandomFemaleFaceID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoRandomFemaleFaceID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<string>> CheckReplaceSpeEffectList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CheckReplaceSpeEffectList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CheckReplaceSpeEffectList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> FavorLvText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FavorLvText, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FavorLvText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> CenterBuildingUpgradePeopleLimit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CenterBuildingUpgradePeopleLimit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CenterBuildingUpgradePeopleLimit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> CenterBuildingUpgradeHeroLimit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CenterBuildingUpgradeHeroLimit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CenterBuildingUpgradeHeroLimit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> StudyNewSkillCostFavor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StudyNewSkillCostFavor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StudyNewSkillCostFavor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> TeachNewSkillAddFavor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TeachNewSkillAddFavor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TeachNewSkillAddFavor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Quaternion leftRotation
	{
		get
		{
			Unsafe.SkipInit(out Quaternion result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leftRotation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leftRotation, (void*)(&quaternion));
		}
	}

	public unsafe static List<float> BattleTypeAutoGetExpRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleTypeAutoGetExpRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleTypeAutoGetExpRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<float> BattleTypeGetFameRate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleTypeGetFameRate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleTypeGetFameRate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static AudioSource heroSoundAudioSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_heroSoundAudioSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_heroSoundAudioSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static Il2CppStructArray<Color> amountColors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_amountColors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_amountColors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int randomSeed
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_randomSeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_randomSeed, (void*)(&num));
		}
	}

	public unsafe static ThreadLocal<Il2CppSystem.Random> threadRandom
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_threadRandom, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ThreadLocal<Il2CppSystem.Random>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_threadRandom, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)threadLocal));
		}
	}

	public unsafe static List<int> CheckSpeForceIcon
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CheckSpeForceIcon, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CheckSpeForceIcon, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GlobalData()
	{
		Il2CppClassPointerStore<GlobalData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GlobalData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalData>.NativeClassPtr);
		NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameVersion");
		NativeFieldInfoPtr_DemoVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DemoVersion");
		NativeFieldInfoPtr_BuildVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BuildVersion");
		NativeFieldInfoPtr_DisableAutoSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DisableAutoSave");
		NativeFieldInfoPtr_PlayTestAvailableAreaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayTestAvailableAreaID");
		NativeFieldInfoPtr_PlayTestAvailableForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayTestAvailableForceID");
		NativeFieldInfoPtr_PlayTestAvailableInnID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayTestAvailableInnID");
		NativeFieldInfoPtr_SteamAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SteamAppID");
		NativeFieldInfoPtr_WegameAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WegameAppID");
		NativeFieldInfoPtr_DLCName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DLCName");
		NativeFieldInfoPtr_SteamDLCIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SteamDLCIDList");
		NativeFieldInfoPtr_WegameDLCIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WegameDLCIDList");
		NativeFieldInfoPtr_SteamDLCUrlList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SteamDLCUrlList");
		NativeFieldInfoPtr_WegameDLCUrlList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WegameDLCUrlList");
		NativeFieldInfoPtr_PlayTestMaxLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayTestMaxLv");
		NativeFieldInfoPtr_PlayTestMaxFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayTestMaxFavor");
		NativeFieldInfoPtr_VersionNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "VersionNum");
		NativeFieldInfoPtr_FixNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FixNum");
		NativeFieldInfoPtr_Use_Full_Dirty_Words = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Use_Full_Dirty_Words");
		NativeFieldInfoPtr_MaxAreaStateDefenceRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxAreaStateDefenceRate");
		NativeFieldInfoPtr_AttackAreaFightScoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttackAreaFightScoreRate");
		NativeFieldInfoPtr_MaxAttackSkillNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxAttackSkillNum");
		NativeFieldInfoPtr_MaxFriendNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxFriendNum");
		NativeFieldInfoPtr_MaxLoverNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxLoverNum");
		NativeFieldInfoPtr_MaxBrotherNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxBrotherNum");
		NativeFieldInfoPtr_MaxHeroNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxHeroNum");
		NativeFieldInfoPtr_RecommendHeroNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "RecommendHeroNum");
		NativeFieldInfoPtr_MapBorderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MapBorderWidth");
		NativeFieldInfoPtr_MapBorderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MapBorderHeight");
		NativeFieldInfoPtr_ResulotionChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ResulotionChoice");
		NativeFieldInfoPtr_GameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameModeName");
		NativeFieldInfoPtr_GameDifficultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameDifficultName");
		NativeFieldInfoPtr_GameDifficultDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameDifficultDescribe");
		NativeFieldInfoPtr_NumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NumText");
		NativeFieldInfoPtr_ChineseNumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ChineseNumText");
		NativeFieldInfoPtr_TraditionalChineseReplaceFontName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TraditionalChineseReplaceFontName");
		NativeFieldInfoPtr_MaxLogNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxLogNum");
		NativeFieldInfoPtr_PlayerForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayerForceID");
		NativeFieldInfoPtr_HeroBaseHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroBaseHp");
		NativeFieldInfoPtr_HeroBaseMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroBaseMp");
		NativeFieldInfoPtr_HeroMaxAttriNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroMaxAttriNum");
		NativeFieldInfoPtr_HeroMaxFightSkillNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroMaxFightSkillNum");
		NativeFieldInfoPtr_HeroMaxLivingSkillNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroMaxLivingSkillNum");
		NativeFieldInfoPtr_BigMapWidthHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BigMapWidthHalf");
		NativeFieldInfoPtr_BigMapHeightHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BigMapHeightHalf");
		NativeFieldInfoPtr_BigMapVectorScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BigMapVectorScale");
		NativeFieldInfoPtr_TempHeroIDStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempHeroIDStart");
		NativeFieldInfoPtr_SummonSkillIDStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SummonSkillIDStart");
		NativeFieldInfoPtr_GameObjScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameObjScale");
		NativeFieldInfoPtr_areaMapTileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "areaMapTileSize");
		NativeFieldInfoPtr_WorldMapMaxTryTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WorldMapMaxTryTimes");
		NativeFieldInfoPtr_Infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Infinity");
		NativeFieldInfoPtr_BaseTravelSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BaseTravelSpeed");
		NativeFieldInfoPtr_BaseTravelTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BaseTravelTimeScale");
		NativeFieldInfoPtr_AIMoveThinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AIMoveThinkTime");
		NativeFieldInfoPtr_AIAttackThinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AIAttackThinkTime");
		NativeFieldInfoPtr_BuildingUpgradeAddProduceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BuildingUpgradeAddProduceRatio");
		NativeFieldInfoPtr_CrimeBadFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CrimeBadFame");
		NativeFieldInfoPtr_RestBaseRecoverRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "RestBaseRecoverRate");
		NativeFieldInfoPtr_NormalBaseRecoverRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NormalBaseRecoverRate");
		NativeFieldInfoPtr_AutoSkillAttriNeedNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AutoSkillAttriNeedNum");
		NativeFieldInfoPtr_MaxSkillNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxSkillNum");
		NativeFieldInfoPtr_CureInjuryToFavorRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CureInjuryToFavorRate");
		NativeFieldInfoPtr_FlipXScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FlipXScale");
		NativeFieldInfoPtr_AutoPracticeExpRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AutoPracticeExpRate");
		NativeFieldInfoPtr_MaxInternalSkillSelfStudyLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxInternalSkillSelfStudyLv");
		NativeFieldInfoPtr_MaxFightSkillSelfStudyLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxFightSkillSelfStudyLv");
		NativeFieldInfoPtr_NoFemaleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NoFemaleForce");
		NativeFieldInfoPtr_SpeWeakHeroName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SpeWeakHeroName");
		NativeFieldInfoPtr_SpeMasterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SpeMasterName");
		NativeFieldInfoPtr_SpeNoRandomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SpeNoRandomName");
		NativeFieldInfoPtr_SpeTeammateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SpeTeammateName");
		NativeFieldInfoPtr_SpeSkeletonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SpeSkeletonName");
		NativeFieldInfoPtr_AutoSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AutoSaveData");
		NativeFieldInfoPtr_DefaultAutoSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DefaultAutoSetting");
		NativeFieldInfoPtr_leftFootStepEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "leftFootStepEventName");
		NativeFieldInfoPtr_leftFootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "leftFootBone");
		NativeFieldInfoPtr_rightFootStepEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "rightFootStepEventName");
		NativeFieldInfoPtr_rightFootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "rightFootBone");
		NativeFieldInfoPtr_HorseFootStepEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseFootStepEvent");
		NativeFieldInfoPtr_HorseFootStepTargetBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseFootStepTargetBone");
		NativeFieldInfoPtr_FacePartName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FacePartName");
		NativeFieldInfoPtr_FaceSlotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FaceSlotName");
		NativeFieldInfoPtr_HorseSlotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseSlotName");
		NativeFieldInfoPtr_SkillWeaponTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SkillWeaponTypeName");
		NativeFieldInfoPtr_StealItemBadFameValueRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "StealItemBadFameValueRate");
		NativeFieldInfoPtr_RobItemBadFameValueRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "RobItemBadFameValueRate");
		NativeFieldInfoPtr_BattleMapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleMapCol");
		NativeFieldInfoPtr_BattleMapRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleMapRow");
		NativeFieldInfoPtr_MaxAreaMapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxAreaMapCol");
		NativeFieldInfoPtr_MaxAreaMapRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxAreaMapRow");
		NativeFieldInfoPtr_MaxExploreMapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxExploreMapCol");
		NativeFieldInfoPtr_MaxExploreMapRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxExploreMapRow");
		NativeFieldInfoPtr_HorseSprintLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseSprintLast");
		NativeFieldInfoPtr_HorseSprintCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseSprintCd");
		NativeFieldInfoPtr_ResourcePointFightMaxHeroNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ResourcePointFightMaxHeroNum");
		NativeFieldInfoPtr_MaxInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxInfoCount");
		NativeFieldInfoPtr_MaxFightMovePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxFightMovePower");
		NativeFieldInfoPtr_LabelBrightOriginColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBrightOriginColor");
		NativeFieldInfoPtr_LabelBrightBlueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBrightBlueColor");
		NativeFieldInfoPtr_LabelBlueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBlueColor");
		NativeFieldInfoPtr_LabelBrightYellowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBrightYellowColor");
		NativeFieldInfoPtr_LabelDarkYellowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelDarkYellowColor");
		NativeFieldInfoPtr_LabelBrightPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBrightPositiveColor");
		NativeFieldInfoPtr_LabelPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelPositiveColor");
		NativeFieldInfoPtr_LabelDarkPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelDarkPositiveColor");
		NativeFieldInfoPtr_BrightPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BrightPositiveColor");
		NativeFieldInfoPtr_PositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PositiveColor");
		NativeFieldInfoPtr_DarkPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DarkPositiveColor");
		NativeFieldInfoPtr_DeepDarkPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DeepDarkPositiveColor");
		NativeFieldInfoPtr_MostDarkPositiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MostDarkPositiveColor");
		NativeFieldInfoPtr_LabelBrightNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelBrightNegativeColor");
		NativeFieldInfoPtr_LabelNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelNegativeColor");
		NativeFieldInfoPtr_LabelDarkNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelDarkNegativeColor");
		NativeFieldInfoPtr_BrightNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BrightNegativeColor");
		NativeFieldInfoPtr_NegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NegativeColor");
		NativeFieldInfoPtr_DarkNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DarkNegativeColor");
		NativeFieldInfoPtr_DeepDarkNegativeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DeepDarkNegativeColor");
		NativeFieldInfoPtr_LightBlueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LightBlueColor");
		NativeFieldInfoPtr_DeepDarkBlueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DeepDarkBlueColor");
		NativeFieldInfoPtr_LabelZeroColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LabelZeroColor");
		NativeFieldInfoPtr_ActiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ActiveColor");
		NativeFieldInfoPtr_DisactiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DisactiveColor");
		NativeFieldInfoPtr_DarkestSkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DarkestSkinColor");
		NativeFieldInfoPtr_HighLightYellowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HighLightYellowColor");
		NativeFieldInfoPtr_DarkYellowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DarkYellowColor");
		NativeFieldInfoPtr_ButtonDarkYellowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ButtonDarkYellowColor");
		NativeFieldInfoPtr_LockedForceSpeFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LockedForceSpeFunction");
		NativeFieldInfoPtr_HaveSpeInteractWithNPCForceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HaveSpeInteractWithNPCForceID");
		NativeFieldInfoPtr_InjuryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "InjuryName");
		NativeFieldInfoPtr_InjuryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "InjuryColor");
		NativeFieldInfoPtr_DirectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DirectionName");
		NativeFieldInfoPtr_SeasonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SeasonName");
		NativeFieldInfoPtr_HeroForceLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroForceLvName");
		NativeFieldInfoPtr_HeroServantForceLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroServantForceLvName");
		NativeFieldInfoPtr_HeroGovernLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroGovernLvName");
		NativeFieldInfoPtr_HeroHornorLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroHornorLvName");
		NativeFieldInfoPtr_HeroGovernLvType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroGovernLvType");
		NativeFieldInfoPtr_HeroGovernUpgradeNeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroGovernUpgradeNeed");
		NativeFieldInfoPtr_HeroFreeForceLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroFreeForceLvName");
		NativeFieldInfoPtr_HeroBadForceLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HeroBadForceLvName");
		NativeFieldInfoPtr_MartialClubLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MartialClubLvName");
		NativeFieldInfoPtr_TextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TextType");
		NativeFieldInfoPtr_AreaTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AreaTypeName");
		NativeFieldInfoPtr_AreaSafeRangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AreaSafeRangeRate");
		NativeFieldInfoPtr_ResourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ResourceName");
		NativeFieldInfoPtr_ResourceLivingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ResourceLivingSkill");
		NativeFieldInfoPtr_ResourceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ResourceValue");
		NativeFieldInfoPtr_BattleTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleTypeName");
		NativeFieldInfoPtr_BattleTypeDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleTypeDescribe");
		NativeFieldInfoPtr_MissionSourceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissionSourceTypeName");
		NativeFieldInfoPtr_MissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissionColor");
		NativeFieldInfoPtr_AttackRangeTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttackRangeTypeName");
		NativeFieldInfoPtr_DamageRangeTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DamageRangeTypeName");
		NativeFieldInfoPtr_AttackDirectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttackDirectionName");
		NativeFieldInfoPtr_AttackDirectionDamageRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttackDirectionDamageRate");
		NativeFieldInfoPtr_AttackDirectionExtraAccRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttackDirectionExtraAccRate");
		NativeFieldInfoPtr_AttriName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttriName");
		NativeFieldInfoPtr_FightSkillName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FightSkillName");
		NativeFieldInfoPtr_FightSkillUpgradeBuildingDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FightSkillUpgradeBuildingDescribe");
		NativeFieldInfoPtr_LivingSkillName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LivingSkillName");
		NativeFieldInfoPtr_LivingSkillUpgradeBuildingDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LivingSkillUpgradeBuildingDescribe");
		NativeFieldInfoPtr_ForceLvDetailDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ForceLvDetailDescribe");
		NativeFieldInfoPtr_WeaponLvMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WeaponLvMulti");
		NativeFieldInfoPtr_ItemTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ItemTypeName");
		NativeFieldInfoPtr_EquipmentTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipmentTypeName");
		NativeFieldInfoPtr_DecorationTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DecorationTypeName");
		NativeFieldInfoPtr_FoodTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FoodTypeName");
		NativeFieldInfoPtr_EquipLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipLvName");
		NativeFieldInfoPtr_SkillLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SkillLvName");
		NativeFieldInfoPtr_BookRareLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BookRareLvName");
		NativeFieldInfoPtr_TreasureRareLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureRareLvName");
		NativeFieldInfoPtr_TreasureTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureTypeName");
		NativeFieldInfoPtr_TreasureItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureItemName");
		NativeFieldInfoPtr_TreasureValueLvTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureValueLvTypeName");
		NativeFieldInfoPtr_TreasureValueLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureValueLvName");
		NativeFieldInfoPtr_TreasureRareLvTalkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TreasureRareLvTalkText");
		NativeFieldInfoPtr_MaterialTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaterialTypeName");
		NativeFieldInfoPtr_HorseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "HorseTypeName");
		NativeFieldInfoPtr_EnemyRobberTalkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EnemyRobberTalkText");
		NativeFieldInfoPtr_BodyPointName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BodyPointName");
		NativeFieldInfoPtr_MoveRangeNeedAttriNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MoveRangeNeedAttriNum");
		NativeFieldInfoPtr_AttriRatioString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttriRatioString");
		NativeFieldInfoPtr_AttriLvNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AttriLvNum");
		NativeFieldInfoPtr_AreaLabelFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AreaLabelFontSize");
		NativeFieldInfoPtr_CraftTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CraftTypeName");
		NativeFieldInfoPtr_EnhanceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EnhanceTypeName");
		NativeFieldInfoPtr_CraftPoisonTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CraftPoisonTypeName");
		NativeFieldInfoPtr_BookWriterTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BookWriterTypeName");
		NativeFieldInfoPtr_ChaosText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ChaosText");
		NativeFieldInfoPtr_EvilText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EvilText");
		NativeFieldInfoPtr_NatureText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NatureText");
		NativeFieldInfoPtr_TalentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TalentText");
		NativeFieldInfoPtr_ForceFocusTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ForceFocusTypeName");
		NativeFieldInfoPtr_BattleScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleScoreText");
		NativeFieldInfoPtr_BranchDefenceTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BranchDefenceTypeText");
		NativeFieldInfoPtr_EquipTotalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipTotalWeight");
		NativeFieldInfoPtr_EquipBaseWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipBaseWeight");
		NativeFieldInfoPtr_EquipmentWeightLvName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipmentWeightLvName");
		NativeFieldInfoPtr_EquipWeightLvSpeedMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EquipWeightLvSpeedMulti");
		NativeFieldInfoPtr_PartPostureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PartPostureName");
		NativeFieldInfoPtr_PartPostureChangeSpeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PartPostureChangeSpeAdd");
		NativeFieldInfoPtr_PartPostureEmptySpeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PartPostureEmptySpeAdd");
		NativeFieldInfoPtr_AreaStateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AreaStateName");
		NativeFieldInfoPtr_AddAreaStateLivingSkillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AddAreaStateLivingSkillType");
		NativeFieldInfoPtr_ReduceAreaStateLivingSkillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ReduceAreaStateLivingSkillType");
		NativeFieldInfoPtr_SkillChangePowerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SkillChangePowerRate");
		NativeFieldInfoPtr_AreaObstacleNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AreaObstacleNum");
		NativeFieldInfoPtr_BookStorageRateLvAddRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BookStorageRateLvAddRate");
		NativeFieldInfoPtr_SkillBreakThroughDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SkillBreakThroughDay");
		NativeFieldInfoPtr_SkillObstacleLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SkillObstacleLv");
		NativeFieldInfoPtr_BreakThroughRareRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BreakThroughRareRate");
		NativeFieldInfoPtr_AvailableBeardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AvailableBeardID");
		NativeFieldInfoPtr_NoRandomMaleFaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NoRandomMaleFaceID");
		NativeFieldInfoPtr_NoRandomFemaleFaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NoRandomFemaleFaceID");
		NativeFieldInfoPtr_CheckReplaceSpeEffectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CheckReplaceSpeEffectList");
		NativeFieldInfoPtr_FavorLvText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "FavorLvText");
		NativeFieldInfoPtr_CenterBuildingUpgradePeopleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CenterBuildingUpgradePeopleLimit");
		NativeFieldInfoPtr_CenterBuildingUpgradeHeroLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CenterBuildingUpgradeHeroLimit");
		NativeFieldInfoPtr_StudyNewSkillCostFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "StudyNewSkillCostFavor");
		NativeFieldInfoPtr_TeachNewSkillAddFavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TeachNewSkillAddFavor");
		NativeFieldInfoPtr_leftRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "leftRotation");
		NativeFieldInfoPtr_BattleTypeAutoGetExpRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleTypeAutoGetExpRate");
		NativeFieldInfoPtr_BattleTypeGetFameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BattleTypeGetFameRate");
		NativeFieldInfoPtr_heroSoundAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "heroSoundAudioSource");
		NativeFieldInfoPtr_amountColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "amountColors");
		NativeFieldInfoPtr_randomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "randomSeed");
		NativeFieldInfoPtr_threadRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "threadRandom");
		NativeFieldInfoPtr_CheckSpeForceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CheckSpeForceIcon");
		NativeMethodInfoPtr_GetChineseNumText_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100668998);
		NativeMethodInfoPtr_GetInjuryIconName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100668999);
		NativeMethodInfoPtr_GetAttriLv_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669000);
		NativeMethodInfoPtr_GetRandomBreakThroughRateLv_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669001);
		NativeMethodInfoPtr_GetFavorText_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669002);
		NativeMethodInfoPtr_GetNumText_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669003);
		NativeMethodInfoPtr_StringReplace_Public_Static_String_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669004);
		NativeMethodInfoPtr_GetEvilText_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669005);
		NativeMethodInfoPtr_GetChaosText_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669006);
		NativeMethodInfoPtr_ListAddTo_Public_Static_Void_List_1_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669007);
		NativeMethodInfoPtr_ListMinusTo_Public_Static_Void_List_1_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669008);
		NativeMethodInfoPtr_ListAdd_Public_Static_List_1_Single_List_1_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669009);
		NativeMethodInfoPtr_ListMinus_Public_Static_List_1_Single_List_1_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669010);
		NativeMethodInfoPtr_ListMulti_Public_Static_List_1_Single_List_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669011);
		NativeMethodInfoPtr_ListEqual_Public_Static_Boolean_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669012);
		NativeMethodInfoPtr_DeleteAllChild_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669013);
		NativeMethodInfoPtr_DestroyAll_Public_Static_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669014);
		NativeMethodInfoPtr_DeleteAllNull_Public_Static_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669015);
		NativeMethodInfoPtr_ReplaceSpeString_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669016);
		NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669017);
		NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669018);
		NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669019);
		NativeMethodInfoPtr_GenerateRareLvColorText_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669020);
		NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_ResourceDescribeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669021);
		NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669022);
		NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_ResourceDescribeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669023);
		NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669024);
		NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669025);
		NativeMethodInfoPtr_CountArmorDamageRate_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669026);
		NativeMethodInfoPtr_InsertEnter_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669027);
		NativeMethodInfoPtr_InsertFormat_Public_Static_String_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669028);
		NativeMethodInfoPtr_GetForceFavorLvText_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669029);
		NativeMethodInfoPtr_GetForceFavorLvColor_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669030);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669031);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669032);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669033);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669034);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669035);
		NativeMethodInfoPtr_AddSprite_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669036);
		NativeMethodInfoPtr_AddImage_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669037);
		NativeMethodInfoPtr_GenerateFlyIcon_Public_Static_Void_Sprite_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669038);
		NativeMethodInfoPtr_SortByName_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669039);
		NativeMethodInfoPtr_SortChild_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669040);
		NativeMethodInfoPtr_SetColorAlpha_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669041);
		NativeMethodInfoPtr_MakeUIPixelPerfect_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669042);
		NativeMethodInfoPtr_SetZToZero_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669043);
		NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669044);
		NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_ResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669045);
		NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669046);
		NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_String_Vector3_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669047);
		NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669048);
		NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_String_Vector3_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669049);
		NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669050);
		NativeMethodInfoPtr_GetDifficultyColor_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669051);
		NativeMethodInfoPtr_GetDifficultyStarString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669052);
		NativeMethodInfoPtr_ListContain_Public_Static_Boolean_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669053);
		NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_HeroData_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669054);
		NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669055);
		NativeMethodInfoPtr_CaculateWinTeam_Public_Static_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669056);
		NativeMethodInfoPtr_GetTotalFightScore_Public_Static_Single_List_1_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669057);
		NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669058);
		NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669059);
		NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonAnimation_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669060);
		NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonGraphic_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669061);
		NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669062);
		NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669063);
		NativeMethodInfoPtr_LimitHeroList_Public_Static_Void_List_1_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669064);
		NativeMethodInfoPtr_SortHeroList_Public_Static_List_1_HeroData_List_1_HeroData_HeroListSortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669065);
		NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669066);
		NativeMethodInfoPtr_SetFullScreen_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669067);
		NativeMethodInfoPtr_AutoSetWindowResolution_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669068);
		NativeMethodInfoPtr_ConvertNumToChinese_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669069);
		NativeMethodInfoPtr_GetGovernSalary_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669070);
		NativeMethodInfoPtr_PlayHeroSound_Public_Static_AudioSource_AudioClip_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669071);
		NativeMethodInfoPtr_GetChinese_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669072);
		NativeMethodInfoPtr_GetRequireTypeText_Public_Static_String_ChoiceRequirementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669073);
		NativeMethodInfoPtr_GetHobbyString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669074);
		NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669075);
		NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_ItemType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669076);
		NativeMethodInfoPtr_ListRandomRemove_Public_Static_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669077);
		NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669078);
		NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669079);
		NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669080);
		NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669081);
		NativeMethodInfoPtr_GetBaseAttriName_Public_Static_String_BaseAttriType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669082);
		NativeMethodInfoPtr_SetParticleColor_Public_Static_Void_GameObject_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669083);
		NativeMethodInfoPtr_GetAmountColor_Public_Static_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669084);
		NativeMethodInfoPtr_GetThreadRandom_Public_Static_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669085);
		NativeMethodInfoPtr_RandomRange_Public_Static_Single_Single_Single_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669086);
		NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669087);
		NativeMethodInfoPtr_RandomRangeDouble_Public_Static_Double_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669088);
		NativeMethodInfoPtr_TransformScreenDeltaToLocalDelta_Public_Static_Vector3_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669089);
		NativeMethodInfoPtr_DoTweenTextValue_Public_Static_Void_Text_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669090);
		NativeMethodInfoPtr_DoTweenSkeletonAlpha_Public_Static_Void_SkeletonAnimation_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669091);
		NativeMethodInfoPtr_LoadVector2_Public_Static_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669092);
		NativeMethodInfoPtr_GetForceIconName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669093);
		NativeMethodInfoPtr_RemoveEmptyString_Public_Static_List_1_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669094);
		NativeMethodInfoPtr_IsInputing_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669095);
		NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669096);
		NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669097);
		NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669098);
		NativeMethodInfoPtr_Parabola_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669099);
		NativeMethodInfoPtr_Parabola_Public_Static_Vector2_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669100);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669101);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass330_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669103);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass331_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100669104);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 184859, RefRangeEnd = 184863, XrefRangeStart = 184853, XrefRangeEnd = 184859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char GetChineseNumText(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChineseNumText_Public_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 184869, RefRangeEnd = 184877, XrefRangeStart = 184863, XrefRangeEnd = 184869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInjuryIconName(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInjuryIconName_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 184889, RefRangeEnd = 184897, XrefRangeStart = 184877, XrefRangeEnd = 184889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAttriLv(float targetNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttriLv_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 184910, RefRangeEnd = 184911, XrefRangeStart = 184897, XrefRangeEnd = 184910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRandomBreakThroughRateLv(int skillRareLv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillRareLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomBreakThroughRateLv_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 184916, RefRangeEnd = 184918, XrefRangeStart = 184911, XrefRangeEnd = 184916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFavorText(float favor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&favor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFavorText_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 184937, RefRangeEnd = 184991, XrefRangeStart = 184918, XrefRangeEnd = 184937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNumText(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumText_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 184996, RefRangeEnd = 184998, XrefRangeStart = 184991, XrefRangeEnd = 184996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringReplace(string origin, int index, char replaceChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(origin);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &replaceChar;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringReplace_Public_Static_String_String_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185005, RefRangeEnd = 185008, XrefRangeStart = 184998, XrefRangeEnd = 185005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEvilText(float evil)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&evil);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEvilText_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185015, RefRangeEnd = 185018, XrefRangeStart = 185008, XrefRangeEnd = 185015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetChaosText(float chaos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chaos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChaosText_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185032, RefRangeEnd = 185035, XrefRangeStart = 185018, XrefRangeEnd = 185032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ListAddTo(List<float> a, List<float> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListAddTo_Public_Static_Void_List_1_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185035, XrefRangeEnd = 185049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ListMinusTo(List<float> a, List<float> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListMinusTo_Public_Static_Void_List_1_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185049, XrefRangeEnd = 185065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<float> ListAdd(List<float> a, List<float> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListAdd_Public_Static_List_1_Single_List_1_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185065, XrefRangeEnd = 185081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<float> ListMinus(List<float> a, List<float> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListMinus_Public_Static_List_1_Single_List_1_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 185094, RefRangeEnd = 185103, XrefRangeStart = 185081, XrefRangeEnd = 185094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<float> ListMulti(List<float> a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListMulti_Public_Static_List_1_Single_List_1_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185107, RefRangeEnd = 185110, XrefRangeStart = 185103, XrefRangeEnd = 185107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ListEqual(List<int> list1, List<int> list2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListEqual_Public_Static_Boolean_List_1_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(141)]
	[CachedScanResults(RefRangeStart = 185122, RefRangeEnd = 185263, XrefRangeStart = 185110, XrefRangeEnd = 185122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteAllChild(GameObject targetObj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteAllChild_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 185273, RefRangeEnd = 185290, XrefRangeStart = 185263, XrefRangeEnd = 185273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyAll(List<GameObject> targetObj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAll_Public_Static_Void_List_1_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185290, XrefRangeEnd = 185300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteAllNull(List<GameObject> targetObj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteAllNull_Public_Static_Void_List_1_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 185759, RefRangeEnd = 185767, XrefRangeStart = 185300, XrefRangeEnd = 185759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceSpeString(string targetText, int sourceHeroID = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetText);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceHeroID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceSpeString_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 185787, RefRangeEnd = 185824, XrefRangeStart = 185767, XrefRangeEnd = 185787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateChangeColorText(string name, float num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185843, RefRangeEnd = 185846, XrefRangeStart = 185824, XrefRangeEnd = 185843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateChangeColorText(string name, float num, bool reverse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &reverse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 185856, RefRangeEnd = 185863, XrefRangeStart = 185846, XrefRangeEnd = 185856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateChangeColorText(string name, bool positive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChangeColorText_Public_Static_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(83)]
	[CachedScanResults(RefRangeStart = 185884, RefRangeEnd = 185967, XrefRangeStart = 185863, XrefRangeEnd = 185884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateRareLvColorText(string text, int rareLv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rareLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRareLvColorText_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 186023, RefRangeEnd = 186027, XrefRangeStart = 185967, XrefRangeEnd = 186023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceDescribe(List<ResourceData> resourceDatas, ResourceDescribeType describeType, bool newLine = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceDatas);
		*(ResourceDescribeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &describeType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLine;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_ResourceDescribeType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186031, RefRangeEnd = 186032, XrefRangeStart = 186027, XrefRangeEnd = 186031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceDescribe(List<ResourceData> resourceDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_ResourceData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186057, RefRangeEnd = 186059, XrefRangeStart = 186032, XrefRangeEnd = 186057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceDescribe(List<float> resourceDatas, ResourceDescribeType describeType, bool newLine = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceDatas);
		*(ResourceDescribeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &describeType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLine;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_ResourceDescribeType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 186087, RefRangeEnd = 186091, XrefRangeStart = 186059, XrefRangeEnd = 186087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceDescribe(List<float> resourceDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186109, RefRangeEnd = 186110, XrefRangeStart = 186091, XrefRangeEnd = 186109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceDescribe(ResourceData resourceData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceDescribe_Public_Static_String_ResourceData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186111, RefRangeEnd = 186113, XrefRangeStart = 186110, XrefRangeEnd = 186111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CountArmorDamageRate(float armor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&armor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountArmorDamageRate_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186113, XrefRangeEnd = 186120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InsertEnter(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertEnter_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186120, XrefRangeEnd = 186122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InsertFormat(string input, int interval, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interval;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertFormat_Public_Static_String_String_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186131, RefRangeEnd = 186132, XrefRangeStart = 186122, XrefRangeEnd = 186131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetForceFavorLvText(float favorNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&favorNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceFavorLvText_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186133, RefRangeEnd = 186134, XrefRangeStart = 186132, XrefRangeEnd = 186133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetForceFavorLvColor(float favorNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&favorNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceFavorLvColor_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 186143, RefRangeEnd = 186358, XrefRangeStart = 186134, XrefRangeEnd = 186143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186370, RefRangeEnd = 186371, XrefRangeStart = 186358, XrefRangeEnd = 186370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab, bool autoAbove)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoAbove;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186379, RefRangeEnd = 186380, XrefRangeStart = 186371, XrefRangeEnd = 186379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab, Vector3 localScale, bool autoAbove)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localScale;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoAbove;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186385, RefRangeEnd = 186387, XrefRangeStart = 186380, XrefRangeEnd = 186385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab, Vector3 localPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 186400, RefRangeEnd = 186415, XrefRangeStart = 186387, XrefRangeEnd = 186400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab, Vector3 localPosition, Vector3 localScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &localScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 186452, RefRangeEnd = 186458, XrefRangeStart = 186415, XrefRangeEnd = 186452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddSprite(GameObject parent, string objName = null, Sprite sprite = null, Il2CppSystem.Nullable<Vector3> localPosition = null, Il2CppSystem.Nullable<Vector3> localScale = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localPosition));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localScale));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSprite_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 186495, RefRangeEnd = 186498, XrefRangeStart = 186458, XrefRangeEnd = 186495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddImage(GameObject parent, string objName = null, Sprite sprite = null, Il2CppSystem.Nullable<Vector3> localPosition = null, Il2CppSystem.Nullable<Vector3> localScale = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localPosition));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localScale));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddImage_Public_Static_GameObject_GameObject_String_Sprite_Nullable_1_Vector3_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186548, RefRangeEnd = 186549, XrefRangeStart = 186498, XrefRangeEnd = 186548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenerateFlyIcon(Sprite targetSprite, Vector3 startPos, Vector3 endPos, int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSprite);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endPos;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateFlyIcon_Public_Static_Void_Sprite_Vector3_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SortByName(Transform a, Transform b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortByName_Public_Static_Int32_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 186593, RefRangeEnd = 186608, XrefRangeStart = 186549, XrefRangeEnd = 186593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortChild(GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortChild_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 186609, RefRangeEnd = 186638, XrefRangeStart = 186608, XrefRangeEnd = 186609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color SetColorAlpha(Color target, float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&target);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorAlpha_Public_Static_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186638, XrefRangeEnd = 186651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MakeUIPixelPerfect(GameObject target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeUIPixelPerfect_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 186654, RefRangeEnd = 186669, XrefRangeStart = 186651, XrefRangeEnd = 186654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SetZToZero(Vector3 target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZToZero_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 186669, RefRangeEnd = 186676, XrefRangeStart = 186669, XrefRangeEnd = 186669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SetZ(Vector3 target, float zPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&target);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &zPos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186690, RefRangeEnd = 186692, XrefRangeStart = 186676, XrefRangeEnd = 186690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetResourceTotalValue(List<ResourceData> resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_ResourceData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186692, XrefRangeEnd = 186705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetResourceTotalValue(List<float> resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceTotalValue_Public_Static_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 186729, RefRangeEnd = 186745, XrefRangeStart = 186705, XrefRangeEnd = 186729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkeletonAnimation GenerateSkeletonAnimation(GameObject _parent, string _resourceName, Vector3 _scale, string _anim, bool _loop, string _skin = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_resourceName);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_anim);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_loop;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_skin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_String_Vector3_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonAnimation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186745, XrefRangeEnd = 186756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkeletonAnimation GenerateSkeletonAnimation(GameObject _parent, SkeletonDataAsset _skeletonDataAsset, Vector3 _scale, string _anim, bool _loop, string _skin = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_skeletonDataAsset);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_anim);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_loop;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_skin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSkeletonAnimation_Public_Static_SkeletonAnimation_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonAnimation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186784, RefRangeEnd = 186785, XrefRangeStart = 186756, XrefRangeEnd = 186784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkeletonGraphic GenerateSkeletonGraphic(GameObject _parent, string _resourceName, Vector3 _scale, string _anim, bool _loop, string _skin = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_resourceName);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_anim);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_loop;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_skin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_String_Vector3_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonGraphic>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186785, XrefRangeEnd = 186800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkeletonGraphic GenerateSkeletonGraphic(GameObject _parent, SkeletonDataAsset _skeletonDataAsset, Vector3 _scale, string _anim, bool _loop, string _skin = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_skeletonDataAsset);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_anim);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_loop;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_skin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSkeletonGraphic_Public_Static_SkeletonGraphic_GameObject_SkeletonDataAsset_Vector3_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkeletonGraphic>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186817, RefRangeEnd = 186819, XrefRangeStart = 186800, XrefRangeEnd = 186817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetDifficultyColor(float difficulty)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficulty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDifficultyColor_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 186853, RefRangeEnd = 186859, XrefRangeStart = 186819, XrefRangeEnd = 186853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDifficultyStarString(float difficulty)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficulty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDifficultyStarString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186859, XrefRangeEnd = 186875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ListContain(List<int> ListFather, List<int> ListSon)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ListFather);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ListSon);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListContain_Public_Static_Boolean_List_1_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186881, RefRangeEnd = 186882, XrefRangeStart = 186875, XrefRangeEnd = 186881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CaculateWinRate(HeroData hero0, HeroData hero1, bool includeTeamMate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero1);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeTeamMate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_HeroData_HeroData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186882, XrefRangeEnd = 186883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CaculateWinRate(float team0FightScore, float team1FightScore)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&team0FightScore);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &team1FightScore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaculateWinRate_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186892, RefRangeEnd = 186893, XrefRangeStart = 186883, XrefRangeEnd = 186892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CaculateWinTeam(float team0FightScore, float team1FightScore)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&team0FightScore);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &team1FightScore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaculateWinTeam_Public_Static_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 186898, RefRangeEnd = 186900, XrefRangeStart = 186893, XrefRangeEnd = 186898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetTotalFightScore(List<HeroData> heroList, bool includeTeamMate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeTeamMate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalFightScore_Public_Static_Single_List_1_HeroData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 186904, RefRangeEnd = 186911, XrefRangeStart = 186900, XrefRangeEnd = 186904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ManageHeroAutoFight(FightMatchCouple fightMatchCouple, BattleType battleType, float attackTeamScoreRate = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fightMatchCouple);
		*(BattleType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &battleType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &attackTeamScoreRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186964, RefRangeEnd = 186965, XrefRangeStart = 186911, XrefRangeEnd = 186964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ManageHeroAutoFight(FightMatchCouple fightMatchCouple, BattleType battleType, bool includeTeamMate, float attackTeamScoreRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fightMatchCouple);
		*(BattleType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &battleType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeTeamMate;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &attackTeamScoreRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageHeroAutoFight_Public_Static_Int32_FightMatchCouple_BattleType_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186977, RefRangeEnd = 186978, XrefRangeStart = 186965, XrefRangeEnd = 186977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSkeletonAnimationFromRandomStart(SkeletonAnimation skeletonAnimation, int trackID, string animationName, bool loop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonAnimation);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(animationName);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &loop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonAnimation_Int32_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186990, RefRangeEnd = 186991, XrefRangeStart = 186978, XrefRangeEnd = 186990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSkeletonAnimationFromRandomStart(SkeletonGraphic skeletonAnimation, int trackID, string animationName, bool loop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonAnimation);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(animationName);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &loop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkeletonAnimationFromRandomStart_Public_Static_Void_SkeletonGraphic_Int32_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 187017, RefRangeEnd = 187031, XrefRangeStart = 186991, XrefRangeEnd = 187017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<HeroData> GetMaxForceLvHero(List<HeroData> source, int maxNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187054, RefRangeEnd = 187055, XrefRangeStart = 187031, XrefRangeEnd = 187054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<HeroData> GetMaxForceLvHero(List<HeroData> source, int maxNum, int maxLv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxNum;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxForceLvHero_Public_Static_List_1_HeroData_List_1_HeroData_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187060, RefRangeEnd = 187061, XrefRangeStart = 187055, XrefRangeEnd = 187060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LimitHeroList(List<HeroData> source, int maxNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LimitHeroList_Public_Static_Void_List_1_HeroData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 187106, RefRangeEnd = 187117, XrefRangeStart = 187061, XrefRangeEnd = 187106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<HeroData> SortHeroList(List<HeroData> source, HeroListSortType sortType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(HeroListSortType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortHeroList_Public_Static_List_1_HeroData_List_1_HeroData_HeroListSortType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 187134, RefRangeEnd = 187138, XrefRangeStart = 187117, XrefRangeEnd = 187134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetResolution(int width, int height, bool fullScreen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullScreen;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187147, RefRangeEnd = 187148, XrefRangeStart = 187138, XrefRangeEnd = 187147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFullScreen(bool fullScreen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fullScreen);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFullScreen_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187293, RefRangeEnd = 187294, XrefRangeStart = 187148, XrefRangeEnd = 187293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoSetWindowResolution()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoSetWindowResolution_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187294, XrefRangeEnd = 187345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ConvertNumToChinese(int input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertNumToChinese_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187346, RefRangeEnd = 187349, XrefRangeStart = 187345, XrefRangeEnd = 187346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGovernSalary(int lv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGovernSalary_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187388, RefRangeEnd = 187390, XrefRangeStart = 187349, XrefRangeEnd = 187388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource PlayHeroSound(AudioClip clip, float volume, float pitch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayHeroSound_Public_Static_AudioSource_AudioClip_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187398, RefRangeEnd = 187400, XrefRangeStart = 187390, XrefRangeEnd = 187398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetChinese(string targetText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetText);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChinese_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 187463, RefRangeEnd = 187469, XrefRangeStart = 187400, XrefRangeEnd = 187463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRequireTypeText(ChoiceRequirementType targetType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRequireTypeText_Public_Static_String_ChoiceRequirementType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 187477, RefRangeEnd = 187482, XrefRangeStart = 187469, XrefRangeEnd = 187477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetHobbyString(int hobby)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hobby);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHobbyString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187486, RefRangeEnd = 187488, XrefRangeStart = 187482, XrefRangeEnd = 187486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetItemTypeString(int type, int littleType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &littleType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187511, RefRangeEnd = 187513, XrefRangeStart = 187488, XrefRangeEnd = 187511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetItemTypeString(ItemType type, int littleType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &littleType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemTypeString_Public_Static_String_ItemType_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187521, RefRangeEnd = 187524, XrefRangeStart = 187513, XrefRangeEnd = 187521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ListRandomRemove(List<int> targetList, int num = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListRandomRemove_Public_Static_Void_List_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187532, RefRangeEnd = 187533, XrefRangeStart = 187524, XrefRangeEnd = 187532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ListAverage(List<int> targetList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187533, XrefRangeEnd = 187541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ListAverage(List<float> targetList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListAverage_Public_Static_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187541, XrefRangeEnd = 187545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ListTotal(List<int> targetList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187545, XrefRangeEnd = 187549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ListTotal(List<float> targetList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListTotal_Public_Static_Single_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 187563, RefRangeEnd = 187568, XrefRangeStart = 187549, XrefRangeEnd = 187563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBaseAttriName(BaseAttriType targetAttri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetAttri);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseAttriName_Public_Static_String_BaseAttriType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187580, RefRangeEnd = 187583, XrefRangeStart = 187568, XrefRangeEnd = 187580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetParticleColor(GameObject particle, Color targetColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParticleColor_Public_Static_Void_GameObject_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187602, RefRangeEnd = 187604, XrefRangeStart = 187583, XrefRangeEnd = 187602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetAmountColor(float val, float alpha = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAmountColor_Public_Static_Color_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 187612, RefRangeEnd = 187621, XrefRangeStart = 187604, XrefRangeEnd = 187612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Random GetThreadRandom()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThreadRandom_Public_Static_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr) : null;
	}

	[CallerCount(152)]
	[CachedScanResults(RefRangeStart = 187625, RefRangeEnd = 187777, XrefRangeStart = 187621, XrefRangeEnd = 187625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RandomRange(float minValue, float maxValue, Il2CppSystem.Random randomTarget = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&minValue);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)randomTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomRange_Public_Static_Single_Single_Single_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(352)]
	[CachedScanResults(RefRangeStart = 187783, RefRangeEnd = 188135, XrefRangeStart = 187777, XrefRangeEnd = 187783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RandomRange(int minValue, int maxValue, Il2CppSystem.Random randomTarget = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&minValue);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)randomTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(102)]
	[CachedScanResults(RefRangeStart = 188140, RefRangeEnd = 188242, XrefRangeStart = 188135, XrefRangeEnd = 188140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double RandomRangeDouble(Il2CppSystem.Random randomTarget = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)randomTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomRangeDouble_Public_Static_Double_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 188249, RefRangeEnd = 188254, XrefRangeStart = 188242, XrefRangeEnd = 188249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 TransformScreenDeltaToLocalDelta(Vector2 delta, GameObject targetObj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delta);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformScreenDeltaToLocalDelta_Public_Static_Vector3_Vector2_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 188272, RefRangeEnd = 188278, XrefRangeStart = 188254, XrefRangeEnd = 188272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoTweenTextValue(Text targetText, float targetValue, float time = 0.2f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetText);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetValue;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTweenTextValue_Public_Static_Void_Text_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 188299, RefRangeEnd = 188303, XrefRangeStart = 188278, XrefRangeEnd = 188299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoTweenSkeletonAlpha(SkeletonAnimation targetSkeleton, float startAlpha, float targetAlpha, float time = 0.2f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkeleton);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startAlpha;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetAlpha;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTweenSkeletonAlpha_Public_Static_Void_SkeletonAnimation_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188309, RefRangeEnd = 188310, XrefRangeStart = 188303, XrefRangeEnd = 188309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 LoadVector2(string vector2String)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(vector2String);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadVector2_Public_Static_Vector2_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 188314, RefRangeEnd = 188344, XrefRangeStart = 188310, XrefRangeEnd = 188314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetForceIconName(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceIconName_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188351, RefRangeEnd = 188352, XrefRangeStart = 188344, XrefRangeEnd = 188351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> RemoveEmptyString(List<string> targetList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEmptyString_Public_Static_List_1_String_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 188380, RefRangeEnd = 188384, XrefRangeStart = 188352, XrefRangeEnd = 188380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInputing()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInputing_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 188388, RefRangeEnd = 188413, XrefRangeStart = 188384, XrefRangeEnd = 188388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyDown(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 188417, RefRangeEnd = 188421, XrefRangeStart = 188413, XrefRangeEnd = 188417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKey(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188425, RefRangeEnd = 188426, XrefRangeStart = 188421, XrefRangeEnd = 188425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyUp(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188431, RefRangeEnd = 188432, XrefRangeStart = 188426, XrefRangeEnd = 188431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parabola_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188432, XrefRangeEnd = 188437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Parabola(Vector2 start, Vector2 end, float height, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parabola_Public_Static_Vector2_Vector2_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Method_Internal_Static_Single_Single_byref___c__DisplayClass330_0_PDM_0(float x, ref __c__DisplayClass330_0 A_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass330_0_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float Method_Internal_Static_Single_Single_byref___c__DisplayClass331_0_PDM_0(float x, ref __c__DisplayClass331_0 A_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Single_byref___c__DisplayClass331_0_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GlobalData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
