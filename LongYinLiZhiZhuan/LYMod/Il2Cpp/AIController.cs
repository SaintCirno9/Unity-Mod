using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class AIController : MonoBehaviour
{
	[ObfuscatedName("AIController+<>c__DisplayClass24_0")]
	public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_targetStuffType;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__8;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__0_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__1_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__2_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__3_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__7_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__8_Internal_Boolean_AIStuffType_0;

		public unsafe AIStuffType targetStuffType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetStuffType);
				return *(AIStuffType*)num;
			}
			set
			{
				*(AIStuffType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetStuffType)) = aIStuffType;
			}
		}

		public unsafe Il2CppSystem.Predicate<AIStuffType> __9__8
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__8);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AIStuffType>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__8)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass24_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIController>.NativeClassPtr, "<>c__DisplayClass24_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr);
			NativeFieldInfoPtr_targetStuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "targetStuffType");
			NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "<>9__8");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665824);
			NativeMethodInfoPtr__ManageAIStuff_b__0_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665825);
			NativeMethodInfoPtr__ManageAIStuff_b__1_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665826);
			NativeMethodInfoPtr__ManageAIStuff_b__2_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665827);
			NativeMethodInfoPtr__ManageAIStuff_b__3_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665828);
			NativeMethodInfoPtr__ManageAIStuff_b__7_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665829);
			NativeMethodInfoPtr__ManageAIStuff_b__8_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100665830);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass24_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__0(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__0_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__1(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__1_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__2(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__2_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__3(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__3_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__7(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__7_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__8(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__8_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass24_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("AIController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_5;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_6;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__24_4_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__24_5_Internal_Boolean_AIStuffType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ManageAIStuff_b__24_6_Internal_Int32_Int32_Int32_0;

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

		public unsafe static Il2CppSystem.Predicate<AIStuffType> __9__24_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AIStuffType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<AIStuffType> __9__24_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AIStuffType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<int> __9__24_6
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_6, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_6, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__24_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_4");
			NativeFieldInfoPtr___9__24_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_5");
			NativeFieldInfoPtr___9__24_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_6");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665832);
			NativeMethodInfoPtr__ManageAIStuff_b__24_4_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665833);
			NativeMethodInfoPtr__ManageAIStuff_b__24_5_Internal_Boolean_AIStuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665834);
			NativeMethodInfoPtr__ManageAIStuff_b__24_6_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665835);
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
		public unsafe bool _ManageAIStuff_b__24_4(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__24_4_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ManageAIStuff_b__24_5(AIStuffType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__24_5_Internal_Boolean_AIStuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73988, XrefRangeEnd = 74006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _ManageAIStuff_b__24_6(int h1, int h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&h1);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ManageAIStuff_b__24_6_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("AIController+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_targetArea;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FinishAIStuff_b__0_Internal_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FinishAIStuff_b__1_Internal_Int32_Int32_Int32_0;

		public unsafe AreaData targetArea
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetArea);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaData));
			}
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIController>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_targetArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "targetArea");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100665836);
			NativeMethodInfoPtr__FinishAIStuff_b__0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100665837);
			NativeMethodInfoPtr__FinishAIStuff_b__1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100665838);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74006, XrefRangeEnd = 74009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _FinishAIStuff_b__0(int h1, int h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&h1);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FinishAIStuff_b__0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74009, XrefRangeEnd = 74012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _FinishAIStuff_b__1(int h1, int h2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&h1);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FinishAIStuff_b__1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AIStuffTypeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteractOtherHeroAiStuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_NeedBigMapMoveAiStuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_FightHeroAiStuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExtraFocusAISettingType;

	private static readonly System.IntPtr NativeFieldInfoPtr_needLeaveHero;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_speSkillIDList;

	private static readonly System.IntPtr NativeFieldInfoPtr_availablePoisonItemType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AIController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AICheckSpeMed_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AICheckEquipment_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillScore_Public_Single_HeroData_KungfuSkillLvData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AICheckSkill_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageAIOneDay_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckInteractTarget_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomMoveTargetArea_Public_Int32_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanLeaveArea_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageAIUsePoison_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroNeedMove_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceHaveResourceRateLessThan_Public_Boolean_HeroData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageAIStuff_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAvailableStuffType_Public_Void_List_1_AIStuffType_AIStuffType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAIStuff_Public_Void_HeroData_HeroAIData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishAIStuff_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AICheckRemoveFriend_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AICheckRemoveHater_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NPCGoInPrison_Public_Void_HeroData_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroLoseFightOnBigMap_Public_Void_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroMoneyBiggerThanMin_Public_Boolean_HeroData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroMoneyRate_Public_Single_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroItemWeightBiggerThanMax_Public_Boolean_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeroItemNumBiggerThanMax_Public_Boolean_HeroData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroDonateItemToForceStorage_Public_Void_HeroData_ItemData_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroBuyItemFromForceStorage_Public_Void_HeroData_ItemData_ItemListData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroBuyItem_Public_Void_HeroData_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroSellItem_Public_Void_HeroData_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeroManageEquipmentTrade_Public_ItemData_HeroData_ItemListData_ItemData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartMoveToAnotherArea_Public_Void_HeroData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static List<string> AIStuffTypeName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AIStuffTypeName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AIStuffTypeName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<AIStuffType> InteractOtherHeroAiStuffType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InteractOtherHeroAiStuffType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIStuffType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InteractOtherHeroAiStuffType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<AIStuffType> NeedBigMapMoveAiStuffType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NeedBigMapMoveAiStuffType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIStuffType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NeedBigMapMoveAiStuffType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<AIStuffType> FightHeroAiStuffType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FightHeroAiStuffType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIStuffType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FightHeroAiStuffType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<AISettingType> ExtraFocusAISettingType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExtraFocusAISettingType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AISettingType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExtraFocusAISettingType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroData> needLeaveHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needLeaveHero);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needLeaveHero)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static AIController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIController));
		}
	}

	public unsafe List<int> speSkillIDList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSkillIDList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speSkillIDList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ItemType> availablePoisonItemType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_availablePoisonItemType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_availablePoisonItemType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static AIController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74012, XrefRangeEnd = 74016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_AIController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIController>(intPtr) : null;
		}
	}

	static AIController()
	{
		Il2CppClassPointerStore<AIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIController>.NativeClassPtr);
		NativeFieldInfoPtr_AIStuffTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "AIStuffTypeName");
		NativeFieldInfoPtr_InteractOtherHeroAiStuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "InteractOtherHeroAiStuffType");
		NativeFieldInfoPtr_NeedBigMapMoveAiStuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "NeedBigMapMoveAiStuffType");
		NativeFieldInfoPtr_FightHeroAiStuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "FightHeroAiStuffType");
		NativeFieldInfoPtr_ExtraFocusAISettingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "ExtraFocusAISettingType");
		NativeFieldInfoPtr_needLeaveHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "needLeaveHero");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_speSkillIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "speSkillIDList");
		NativeFieldInfoPtr_availablePoisonItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIController>.NativeClassPtr, "availablePoisonItemType");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_AIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665790);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665792);
		NativeMethodInfoPtr_AICheckSpeMed_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665793);
		NativeMethodInfoPtr_AICheckEquipment_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_GetSkillScore_Public_Single_HeroData_KungfuSkillLvData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_AICheckSkill_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_ManageAIOneDay_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_CheckInteractTarget_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr_GetRandomMoveTargetArea_Public_Int32_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665799);
		NativeMethodInfoPtr_CanLeaveArea_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_ManageAIUsePoison_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr_CheckHeroNeedMove_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665802);
		NativeMethodInfoPtr_ForceHaveResourceRateLessThan_Public_Boolean_HeroData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665803);
		NativeMethodInfoPtr_ManageAIStuff_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr_AddAvailableStuffType_Public_Void_List_1_AIStuffType_AIStuffType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_SetAIStuff_Public_Void_HeroData_HeroAIData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_FinishAIStuff_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_AICheckRemoveFriend_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_AICheckRemoveHater_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_NPCGoInPrison_Public_Void_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr_HeroLoseFightOnBigMap_Public_Void_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665811);
		NativeMethodInfoPtr_CheckHeroMoneyBiggerThanMin_Public_Boolean_HeroData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_GetHeroMoneyRate_Public_Single_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_CheckHeroItemWeightBiggerThanMax_Public_Boolean_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_CheckHeroItemNumBiggerThanMax_Public_Boolean_HeroData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_HeroDonateItemToForceStorage_Public_Void_HeroData_ItemData_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_HeroBuyItemFromForceStorage_Public_Void_HeroData_ItemData_ItemListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_HeroBuyItem_Public_Void_HeroData_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_HeroSellItem_Public_Void_HeroData_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_HeroManageEquipmentTrade_Public_ItemData_HeroData_ItemListData_ItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_StartMoveToAnotherArea_Public_Void_HeroData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIController>.NativeClassPtr, 100665822);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74016, XrefRangeEnd = 74032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74032, XrefRangeEnd = 74070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74097, RefRangeEnd = 74098, XrefRangeStart = 74070, XrefRangeEnd = 74097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AICheckSpeMed(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AICheckSpeMed_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 74201, RefRangeEnd = 74210, XrefRangeStart = 74098, XrefRangeEnd = 74201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AICheckEquipment(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AICheckEquipment_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74225, RefRangeEnd = 74229, XrefRangeStart = 74210, XrefRangeEnd = 74225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillScore(HeroData targetHero, KungfuSkillLvData targetSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillScore_Public_Single_HeroData_KungfuSkillLvData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 74351, RefRangeEnd = 74361, XrefRangeStart = 74229, XrefRangeEnd = 74351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AICheckSkill(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AICheckSkill_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74448, RefRangeEnd = 74449, XrefRangeStart = 74361, XrefRangeEnd = 74448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageAIOneDay(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageAIOneDay_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74472, RefRangeEnd = 74474, XrefRangeStart = 74449, XrefRangeEnd = 74472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckInteractTarget(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInteractTarget_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74504, RefRangeEnd = 74505, XrefRangeStart = 74474, XrefRangeEnd = 74504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRandomMoveTargetArea(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomMoveTargetArea_Public_Int32_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74513, RefRangeEnd = 74515, XrefRangeStart = 74505, XrefRangeEnd = 74513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanLeaveArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanLeaveArea_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74583, RefRangeEnd = 74584, XrefRangeStart = 74515, XrefRangeEnd = 74583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageAIUsePoison(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageAIUsePoison_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74590, RefRangeEnd = 74592, XrefRangeStart = 74584, XrefRangeEnd = 74590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckHeroNeedMove(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroNeedMove_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74600, RefRangeEnd = 74602, XrefRangeStart = 74592, XrefRangeEnd = 74600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ForceHaveResourceRateLessThan(HeroData hero, float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceHaveResourceRateLessThan_Public_Boolean_HeroData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 75146, RefRangeEnd = 75147, XrefRangeStart = 74602, XrefRangeEnd = 75146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageAIStuff(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageAIStuff_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75147, XrefRangeEnd = 75150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAvailableStuffType(List<AIStuffType> availableStuffType, AIStuffType newAIStuffType, int num = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)availableStuffType);
		*(AIStuffType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newAIStuffType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAvailableStuffType_Public_Void_List_1_AIStuffType_AIStuffType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 75210, RefRangeEnd = 75217, XrefRangeStart = 75150, XrefRangeEnd = 75210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAIStuff(HeroData hero, HeroAIData aiData, bool setInteractTarget = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInteractTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAIStuff_Public_Void_HeroData_HeroAIData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 76625, RefRangeEnd = 76630, XrefRangeStart = 75217, XrefRangeEnd = 76625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FinishAIStuff(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishAIStuff_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 76680, RefRangeEnd = 76684, XrefRangeStart = 76630, XrefRangeEnd = 76680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AICheckRemoveFriend(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AICheckRemoveFriend_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 76734, RefRangeEnd = 76738, XrefRangeStart = 76684, XrefRangeEnd = 76734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AICheckRemoveHater(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AICheckRemoveHater_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 76768, RefRangeEnd = 76770, XrefRangeStart = 76738, XrefRangeEnd = 76768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NPCGoInPrison(HeroData targetHero, HeroData sourceHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NPCGoInPrison_Public_Void_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 76796, RefRangeEnd = 76802, XrefRangeStart = 76770, XrefRangeEnd = 76796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeroLoseFightOnBigMap(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroLoseFightOnBigMap_Public_Void_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76802, XrefRangeEnd = 76803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckHeroMoneyBiggerThanMin(HeroData hero, float rate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroMoneyBiggerThanMin_Public_Boolean_HeroData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76803, XrefRangeEnd = 76804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeroMoneyRate(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroMoneyRate_Public_Single_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CheckHeroItemWeightBiggerThanMax(HeroData hero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroItemWeightBiggerThanMax_Public_Boolean_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 76814, RefRangeEnd = 76817, XrefRangeStart = 76804, XrefRangeEnd = 76814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckHeroItemNumBiggerThanMax(HeroData hero, float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeroItemNumBiggerThanMax_Public_Boolean_HeroData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 76844, RefRangeEnd = 76845, XrefRangeStart = 76817, XrefRangeEnd = 76844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeroDonateItemToForceStorage(HeroData hero, ItemData targetItem, ItemListData targetStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroDonateItemToForceStorage_Public_Void_HeroData_ItemData_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 76875, RefRangeEnd = 76880, XrefRangeStart = 76845, XrefRangeEnd = 76875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeroBuyItemFromForceStorage(HeroData hero, ItemData targetItem, ItemListData targetStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroBuyItemFromForceStorage_Public_Void_HeroData_ItemData_ItemListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 76884, RefRangeEnd = 76885, XrefRangeStart = 76880, XrefRangeEnd = 76884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeroBuyItem(HeroData hero, ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroBuyItem_Public_Void_HeroData_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 76889, RefRangeEnd = 76890, XrefRangeStart = 76885, XrefRangeEnd = 76889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeroSellItem(HeroData hero, ItemData targetItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroSellItem_Public_Void_HeroData_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 76907, RefRangeEnd = 76912, XrefRangeStart = 76890, XrefRangeEnd = 76907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData HeroManageEquipmentTrade(HeroData hero, ItemListData targetForceStorage, ItemData nowEquip, int subType, int littleType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetForceStorage);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nowEquip);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &subType;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &littleType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeroManageEquipmentTrade_Public_ItemData_HeroData_ItemListData_ItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 76921, RefRangeEnd = 76924, XrefRangeStart = 76912, XrefRangeEnd = 76921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMoveToAnotherArea(HeroData hero, int targetID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMoveToAnotherArea_Public_Void_HeroData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76924, XrefRangeEnd = 76949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
