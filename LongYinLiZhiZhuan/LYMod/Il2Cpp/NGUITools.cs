using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp;

public static class NGUITools : Il2CppSystem.Object
{
	public sealed class OnInitFunc<T> : Il2CppSystem.MulticastDelegate where T : UIWidget
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnInitFunc()
		{
			Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "OnInitFunc`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr, 100664347);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr, 100664348);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr, 100664349);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr, 100664350);
		}

		[CallerCount(1262)]
		[CachedScanResults(RefRangeStart = 6387, RefRangeEnd = 7649, XrefRangeStart = 6387, XrefRangeEnd = 7649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnInitFunc(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnInitFunc<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 55905, RefRangeEnd = 55924, XrefRangeStart = 55875, XrefRangeEnd = 55905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke(T w)
		{
			//IL_0061->IL0064: Incompatible stack types: I vs Ref
			//IL_0040->IL0064: Incompatible stack types: I vs Ref
			//IL_004d->IL0064: Incompatible stack types: I vs Ref
			//IL_0054->IL0064: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = w;
				if (val is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null));
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref w;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 8102, RefRangeEnd = 8106, XrefRangeStart = 8102, XrefRangeEnd = 8106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(T w, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			//IL_0061->IL0064: Incompatible stack types: I vs Ref
			//IL_0040->IL0064: Incompatible stack types: I vs Ref
			//IL_004d->IL0064: Incompatible stack types: I vs Ref
			//IL_0054->IL0064: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = w;
				if (val is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null));
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref w;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 7678, RefRangeEnd = 7683, XrefRangeStart = 7678, XrefRangeEnd = 7683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OnInitFunc(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnInitFunc<T>(System.Action<T> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnInitFunc<T>>((System.Delegate)P_0);
		}

		public static OnInitFunc<T> operator +(OnInitFunc<T> P_0, OnInitFunc<T> P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnInitFunc<T>>();
		}

		public static OnInitFunc<T> operator -(OnInitFunc<T> P_0, OnInitFunc<T> P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnInitFunc<T>>();
			}
			return (OnInitFunc<T>)obj;
		}
	}

	private sealed class MethodInfoStoreGeneric_FindActive_Public_Static_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindActive_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetTypeName_Public_Static_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetTypeName_Public_Static_String_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddChild_Public_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddChild_Public_Static_T_GameObject_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_Boolean_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddWidget_Public_Static_T_GameObject_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddWidget_Public_Static_T_GameObject_Int32_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindInParents_Public_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindInParents_Public_Static_T_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindInParents_Public_Static_T_Transform_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddMissingComponent_Public_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddMissingComponent_Public_Static_T_GameObject_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Execute_Public_Static_Void_GameObject_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Execute_Public_Static_Void_GameObject_String_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ExecuteAll_Public_Static_Void_GameObject_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ExecuteAll_Public_Static_Void_GameObject_String_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Draw_Public_Static_T_String_OnInitFunc_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Draw_Public_Static_T_String_OnInitFunc_1_T_0, Il2CppClassPointerStore<NGUITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mListener;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_mGlobalVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLastTimestamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLastClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_mTypeNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSides;

	private static readonly System.IntPtr NativeFieldInfoPtr_keys;

	private static readonly System.IntPtr NativeFieldInfoPtr_mWidgets;

	private static readonly System.IntPtr NativeFieldInfoPtr_mRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_mGo;

	private static readonly System.IntPtr NativeFieldInfoPtr_mColorSpace;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_soundVolume_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_soundVolume_Public_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fileAccess_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHierarchy_Public_Static_String_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindActive_Public_Static_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCameraForLayer_Public_Static_Camera_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider2D_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterUndo_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForPrefabStage_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_Transform_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRaycastDepth_Public_Static_Int32_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustDepth_Public_Static_Int32_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BringForward_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushBack_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeDepths_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_Il2CppReferenceArray_1_UIWidget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizePanelDepths_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Transform_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChildLayer_Public_Static_Void_Transform_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWidget_Public_Static_T_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSprite_Public_Static_UISprite_GameObject_INGUIAtlas_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoot_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInParents_Public_Static_T_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChild_Public_Static_Boolean_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Private_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallCreatePanel_Private_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveChildren_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Behaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Public_Static_Boolean_Behaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Public_Static_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveSelf_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayer_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_byref_Bounds_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPMA_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkParentAsChanged_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipboard_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clipboard_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMissingComponent_Public_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFuncName_Public_Static_String_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteAll_Public_Static_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImmediatelyCreateDrawCalls_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenSize_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptionToKey_Public_Static_KeyCode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Static_T_String_OnInitFunc_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIAtlas_INGUIAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_Static_Void_INGUIAtlas_INGUIAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIFont_INGUIFont_0;

	public unsafe static AudioListener mListener
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mListener, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioListener>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mListener, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioListener));
		}
	}

	public unsafe static AudioSource audioSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_audioSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_audioSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static bool mLoaded
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLoaded, (void*)(&flag));
		}
	}

	public unsafe static float mGlobalVolume
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mGlobalVolume, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mGlobalVolume, (void*)(&num));
		}
	}

	public unsafe static float mLastTimestamp
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLastTimestamp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLastTimestamp, (void*)(&num));
		}
	}

	public unsafe static AudioClip mLastClip
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mLastClip, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mLastClip, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, string> mTypeNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mTypeNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mTypeNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Il2CppStructArray<Vector3> mSides
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mSides, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mSides, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<KeyCode> keys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Dictionary<string, UIWidget> mWidgets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mWidgets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, UIWidget>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mWidgets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static UIPanel mRoot
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mRoot, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mRoot, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPanel));
		}
	}

	public unsafe static GameObject mGo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mGo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mGo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static ColorSpace mColorSpace
	{
		get
		{
			Unsafe.SkipInit(out ColorSpace result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mColorSpace, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mColorSpace, (void*)(&colorSpace));
		}
	}

	public unsafe static float soundVolume
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55937, RefRangeEnd = 55938, XrefRangeStart = 55924, XrefRangeEnd = 55937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_soundVolume_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55948, RefRangeEnd = 55949, XrefRangeStart = 55938, XrefRangeEnd = 55948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_soundVolume_Public_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool fileAccess
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55949, XrefRangeEnd = 55950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fileAccess_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static string clipboard
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57627, RefRangeEnd = 57628, XrefRangeStart = 57620, XrefRangeEnd = 57627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipboard_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57636, RefRangeEnd = 57638, XrefRangeStart = 57628, XrefRangeEnd = 57636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipboard_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static Vector2 screenSize
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57852, RefRangeEnd = 57856, XrefRangeStart = 57850, XrefRangeEnd = 57852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenSize_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NGUITools()
	{
		Il2CppClassPointerStore<NGUITools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NGUITools");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NGUITools>.NativeClassPtr);
		NativeFieldInfoPtr_mListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mListener");
		NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "audioSource");
		NativeFieldInfoPtr_mLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mLoaded");
		NativeFieldInfoPtr_mGlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mGlobalVolume");
		NativeFieldInfoPtr_mLastTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mLastTimestamp");
		NativeFieldInfoPtr_mLastClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mLastClip");
		NativeFieldInfoPtr_mTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mTypeNames");
		NativeFieldInfoPtr_mSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mSides");
		NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "keys");
		NativeFieldInfoPtr_mWidgets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mWidgets");
		NativeFieldInfoPtr_mRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mRoot");
		NativeFieldInfoPtr_mGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mGo");
		NativeFieldInfoPtr_mColorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, "mColorSpace");
		NativeMethodInfoPtr_get_soundVolume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_set_soundVolume_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_get_fileAccess_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_GetHierarchy_Public_Static_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_FindActive_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_FindCameraForLayer_Public_Static_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_GetTypeName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_GetTypeName_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_RegisterUndo_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_CheckForPrefabStage_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_CalculateRaycastDepth_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664269);
		NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_AdjustDepth_Public_Static_Int32_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_BringForward_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_PushBack_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_NormalizeDepths_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_Il2CppReferenceArray_1_UIWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_NormalizePanelDepths_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Transform_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_SetChildLayer_Public_Static_Void_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_AddChild_Public_Static_T_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_AddWidget_Public_Static_T_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_AddSprite_Public_Static_UISprite_GameObject_INGUIAtlas_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_GetRoot_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_FindInParents_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_IsChild_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_Deactivate_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_CallCreatePanel_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_SetActiveChildren_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664304);
		NativeMethodInfoPtr_GetActive_Public_Static_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_GetActive_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_SetActiveSelf_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_SetLayer_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_Round_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664313);
		NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_byref_Bounds_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_Save_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664315);
		NativeMethodInfoPtr_Load_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_ApplyPMA_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_MarkParentAsChanged_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_get_clipboard_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_set_clipboard_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_AddMissingComponent_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_GetFuncName_Public_Static_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_Execute_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664334);
		NativeMethodInfoPtr_ExecuteAll_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_ImmediatelyCreateDrawCalls_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_get_screenSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_CaptionToKey_Public_Static_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr_Draw_Public_Static_T_String_OnInitFunc_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIAtlas_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_Replace_Public_Static_Void_INGUIAtlas_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIFont_INGUIFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NGUITools>.NativeClassPtr, 100664345);
	}

	[CallerCount(276)]
	[CachedScanResults(RefRangeStart = 55954, RefRangeEnd = 56230, XrefRangeStart = 55950, XrefRangeEnd = 55954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource PlaySound(AudioClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 56234, RefRangeEnd = 56289, XrefRangeStart = 56230, XrefRangeEnd = 56234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource PlaySound(AudioClip clip, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 56429, RefRangeEnd = 56438, XrefRangeStart = 56289, XrefRangeEnd = 56429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_AudioSource_AudioClip_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56439, RefRangeEnd = 56441, XrefRangeStart = 56438, XrefRangeEnd = 56439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RandomRange(int min, int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomRange_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 56460, RefRangeEnd = 56466, XrefRangeStart = 56441, XrefRangeEnd = 56460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetHierarchy(GameObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHierarchy_Public_Static_String_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 56476, RefRangeEnd = 56488, XrefRangeStart = 56466, XrefRangeEnd = 56476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> FindActive<T>() where T : Component
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindActive_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 56502, RefRangeEnd = 56517, XrefRangeStart = 56488, XrefRangeEnd = 56502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Camera FindCameraForLayer(int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCameraForLayer_Public_Static_Camera_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56521, RefRangeEnd = 56522, XrefRangeStart = 56517, XrefRangeEnd = 56521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddWidgetCollider(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56580, RefRangeEnd = 56581, XrefRangeStart = 56522, XrefRangeEnd = 56580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWidgetCollider_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56604, RefRangeEnd = 56605, XrefRangeStart = 56581, XrefRangeEnd = 56604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56625, RefRangeEnd = 56627, XrefRangeStart = 56605, XrefRangeEnd = 56625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56645, RefRangeEnd = 56646, XrefRangeStart = 56627, XrefRangeEnd = 56645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56646, XrefRangeEnd = 56663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(UIWidget w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56684, RefRangeEnd = 56685, XrefRangeStart = 56663, XrefRangeEnd = 56684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(UIWidget w, BoxCollider box)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56705, RefRangeEnd = 56707, XrefRangeStart = 56685, XrefRangeEnd = 56705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_UIWidget_BoxCollider2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56742, RefRangeEnd = 56745, XrefRangeStart = 56707, XrefRangeEnd = 56742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWidgetCollider_Public_Static_Void_BoxCollider2D_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56745, XrefRangeEnd = 56756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTypeName<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetTypeName_Public_Static_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56756, XrefRangeEnd = 56769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTypeName(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeName_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4532)]
	[CachedScanResults(RefRangeStart = 18, RefRangeEnd = 4550, XrefRangeStart = 18, XrefRangeEnd = 4550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterUndo(UnityEngine.Object obj, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterUndo_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4532)]
	[CachedScanResults(RefRangeStart = 18, RefRangeEnd = 4550, XrefRangeStart = 18, XrefRangeEnd = 4550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDirty(UnityEngine.Object obj, string undoName = "last change")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(undoName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4532)]
	[CachedScanResults(RefRangeStart = 18, RefRangeEnd = 4550, XrefRangeStart = 18, XrefRangeEnd = 4550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckForPrefabStage(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForPrefabStage_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56773, RefRangeEnd = 56774, XrefRangeStart = 56769, XrefRangeEnd = 56773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56774, XrefRangeEnd = 56778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this GameObject parent, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56782, RefRangeEnd = 56783, XrefRangeStart = 56778, XrefRangeEnd = 56782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this GameObject parent, bool undo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &undo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56801, RefRangeEnd = 56804, XrefRangeStart = 56783, XrefRangeEnd = 56801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this GameObject parent, bool undo, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &undo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 56820, RefRangeEnd = 56826, XrefRangeStart = 56804, XrefRangeEnd = 56820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this Transform parent, GameObject prefab)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_Transform_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56830, RefRangeEnd = 56833, XrefRangeStart = 56826, XrefRangeEnd = 56830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this GameObject parent, GameObject prefab)
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
	[CachedScanResults(RefRangeStart = 56857, RefRangeEnd = 56858, XrefRangeStart = 56833, XrefRangeEnd = 56857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject AddChild(this GameObject parent, GameObject prefab, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Static_GameObject_GameObject_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56871, RefRangeEnd = 56873, XrefRangeStart = 56858, XrefRangeEnd = 56871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateRaycastDepth(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRaycastDepth_Public_Static_Int32_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56878, RefRangeEnd = 56880, XrefRangeStart = 56873, XrefRangeEnd = 56878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateNextDepth(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56880, XrefRangeEnd = 56899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreChildrenWithColliders;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateNextDepth_Public_Static_Int32_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56908, RefRangeEnd = 56910, XrefRangeStart = 56899, XrefRangeEnd = 56908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AdjustDepth(GameObject go, int adjustment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustDepth_Public_Static_Int32_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56910, XrefRangeEnd = 56920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BringForward(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BringForward_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56920, XrefRangeEnd = 56930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushBack(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushBack_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56930, XrefRangeEnd = 56942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NormalizeDepths()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeDepths_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56949, RefRangeEnd = 56951, XrefRangeStart = 56942, XrefRangeEnd = 56949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NormalizeWidgetDepths()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56951, XrefRangeEnd = 56959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NormalizeWidgetDepths(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56971, RefRangeEnd = 56974, XrefRangeStart = 56959, XrefRangeEnd = 56971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NormalizeWidgetDepths(Il2CppReferenceArray<UIWidget> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeWidgetDepths_Public_Static_Void_Il2CppReferenceArray_1_UIWidget_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56992, RefRangeEnd = 56995, XrefRangeStart = 56974, XrefRangeEnd = 56992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NormalizePanelDepths()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizePanelDepths_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56995, XrefRangeEnd = 56999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPanel CreateUI(bool advanced3D)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&advanced3D);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPanel>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56999, XrefRangeEnd = 57003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPanel CreateUI(bool advanced3D, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&advanced3D);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPanel>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 57079, RefRangeEnd = 57082, XrefRangeStart = 57003, XrefRangeEnd = 57079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &advanced3D;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUI_Public_Static_UIPanel_Transform_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPanel>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57091, RefRangeEnd = 57092, XrefRangeStart = 57082, XrefRangeEnd = 57091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetChildLayer(this Transform t, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChildLayer_Public_Static_Void_Transform_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57092, XrefRangeEnd = 57114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddChild<T>(this GameObject parent) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddChild_Public_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57114, XrefRangeEnd = 57136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddChild<T>(this GameObject parent, bool undo) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &undo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddChild_Public_Static_T_GameObject_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 57145, RefRangeEnd = 57149, XrefRangeStart = 57136, XrefRangeEnd = 57145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddWidget<T>(this GameObject go, int depth = int.MaxValue) where T : UIWidget
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddWidget_Public_Static_T_GameObject_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57163, RefRangeEnd = 57165, XrefRangeStart = 57149, XrefRangeEnd = 57163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UISprite AddSprite(this GameObject go, INGUIAtlas atlas, string spriteName, int depth = int.MaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atlas);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(spriteName);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSprite_Public_Static_UISprite_GameObject_INGUIAtlas_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UISprite>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57165, XrefRangeEnd = 57174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetRoot(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoot_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57207, XrefRangeStart = 57174, XrefRangeEnd = 57178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindInParents<T>(GameObject go) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindInParents_Public_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 57211, RefRangeEnd = 57224, XrefRangeStart = 57207, XrefRangeEnd = 57211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindInParents<T>(Transform trans) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindInParents_Public_Static_T_Transform_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 57251, RefRangeEnd = 57254, XrefRangeStart = 57224, XrefRangeEnd = 57251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57254, XrefRangeEnd = 57269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildren(this Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 57279, RefRangeEnd = 57285, XrefRangeStart = 57269, XrefRangeEnd = 57279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyImmediate(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57285, XrefRangeEnd = 57299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Broadcast(string funcName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57299, XrefRangeEnd = 57313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Broadcast(string funcName, Il2CppSystem.Object param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Broadcast_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 57315, RefRangeEnd = 57318, XrefRangeStart = 57313, XrefRangeEnd = 57315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsChild(Transform parent, Transform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChild_Public_Static_Boolean_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57318, XrefRangeEnd = 57326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Activate(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57340, RefRangeEnd = 57341, XrefRangeStart = 57326, XrefRangeEnd = 57340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Activate(Transform t, bool compatibilityMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compatibilityMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Private_Static_Void_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57347, RefRangeEnd = 57348, XrefRangeStart = 57341, XrefRangeEnd = 57347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Deactivate(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deactivate_Private_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 57364, RefRangeEnd = 57375, XrefRangeStart = 57348, XrefRangeEnd = 57364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActive(GameObject go, bool state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57388, RefRangeEnd = 57390, XrefRangeStart = 57375, XrefRangeEnd = 57388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compatibilityMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57404, RefRangeEnd = 57405, XrefRangeStart = 57390, XrefRangeEnd = 57404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallCreatePanel(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallCreatePanel_Private_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57405, XrefRangeEnd = 57412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveChildren(GameObject go, bool state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveChildren_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57412, XrefRangeEnd = 57419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsActive(Behaviour mb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mb);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Behaviour_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 57426, RefRangeEnd = 57448, XrefRangeStart = 57419, XrefRangeEnd = 57426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetActive(Behaviour mb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mb);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActive_Public_Static_Boolean_Behaviour_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 57452, RefRangeEnd = 57479, XrefRangeStart = 57448, XrefRangeEnd = 57452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetActive(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActive_Public_Static_Boolean_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57479, XrefRangeEnd = 57481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveSelf(GameObject go, bool state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveSelf_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57490, RefRangeEnd = 57491, XrefRangeStart = 57481, XrefRangeEnd = 57490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayer(GameObject go, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayer_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57491, XrefRangeEnd = 57494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Round(Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57531, RefRangeEnd = 57532, XrefRangeStart = 57494, XrefRangeEnd = 57531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MakePixelPerfect(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePixelPerfect_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57532, XrefRangeEnd = 57545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FitOnScreen(this Camera cam, Transform t, bool considerInactive = false, bool considerChildren = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerChildren;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57545, XrefRangeEnd = 57553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FitOnScreen(this Camera cam, Transform transform, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57553, XrefRangeEnd = 57557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57588, RefRangeEnd = 57590, XrefRangeStart = 57557, XrefRangeEnd = 57588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds, bool considerInactive = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &considerInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FitOnScreen_Public_Static_Void_Camera_Transform_Transform_Vector3_byref_Bounds_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57590, XrefRangeEnd = 57599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Save(string fileName, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57599, XrefRangeEnd = 57609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Load(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 57609, RefRangeEnd = 57615, XrefRangeStart = 57609, XrefRangeEnd = 57609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ApplyPMA(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPMA_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57618, RefRangeEnd = 57620, XrefRangeStart = 57615, XrefRangeEnd = 57618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkParentAsChanged(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkParentAsChanged_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57638, XrefRangeEnd = 57643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeColor(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeColor_Public_Static_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57643, XrefRangeEnd = 57647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ParseColor(string text, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57647, XrefRangeEnd = 57657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StripSymbols(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripSymbols_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57657, XrefRangeEnd = 57661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddMissingComponent_Public_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57661, XrefRangeEnd = 57669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetSides(this Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57673, RefRangeEnd = 57674, XrefRangeStart = 57669, XrefRangeEnd = 57673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetSides(this Camera cam, float depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57682, RefRangeEnd = 57683, XrefRangeStart = 57674, XrefRangeEnd = 57682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetSides(this Camera cam, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 57732, RefRangeEnd = 57735, XrefRangeStart = 57683, XrefRangeEnd = 57732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSides_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57735, XrefRangeEnd = 57743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldCorners(this Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57747, RefRangeEnd = 57748, XrefRangeStart = 57743, XrefRangeEnd = 57747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldCorners(this Camera cam, float depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57748, XrefRangeEnd = 57756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 57799, RefRangeEnd = 57802, XrefRangeStart = 57756, XrefRangeEnd = 57799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldCorners_Public_Static_Il2CppStructArray_1_Vector3_Camera_Single_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57802, XrefRangeEnd = 57808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFuncName(Il2CppSystem.Object obj, string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(method);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFuncName_Public_Static_String_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57808, XrefRangeEnd = 57813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute<T>(GameObject go, string funcName) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(funcName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Execute_Public_Static_Void_GameObject_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 57822, RefRangeEnd = 57827, XrefRangeStart = 57813, XrefRangeEnd = 57822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(funcName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ExecuteAll_Public_Static_Void_GameObject_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57827, XrefRangeEnd = 57850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ImmediatelyCreateDrawCalls(GameObject root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImmediatelyCreateDrawCalls_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 58005, RefRangeEnd = 58008, XrefRangeStart = 57856, XrefRangeEnd = 58005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string KeyToCaption(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58453, RefRangeEnd = 58455, XrefRangeStart = 58008, XrefRangeEnd = 58453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyCode CaptionToKey(string caption)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptionToKey_Public_Static_KeyCode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(KeyCode*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58455, XrefRangeEnd = 58476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Draw<T>(string id, OnInitFunc<T> onInit = null) where T : UIWidget
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onInit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Draw_Public_Static_T_String_OnInitFunc_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58476, XrefRangeEnd = 58487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GammaToLinearSpace(this Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58487, XrefRangeEnd = 58498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color LinearToGammaSpace(this Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 58503, RefRangeEnd = 58511, XrefRangeStart = 58498, XrefRangeEnd = 58503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIfRelated(INGUIAtlas a, INGUIAtlas b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIAtlas_INGUIAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58511, XrefRangeEnd = 58537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Replace(INGUIAtlas before, INGUIAtlas after)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)before);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)after);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_Static_Void_INGUIAtlas_INGUIAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58549, RefRangeEnd = 58551, XrefRangeStart = 58537, XrefRangeEnd = 58549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIfRelated(INGUIFont a, INGUIFont b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfRelated_Public_Static_Boolean_INGUIFont_INGUIFont_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NGUITools(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
