using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class NewMaterialChange : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_isParticleSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_inputMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_m_objectMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_m_meshRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_m_particleRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_m_timeToReduce;

	private static readonly IntPtr NativeFieldInfoPtr_m_reduceFactor;

	private static readonly IntPtr NativeFieldInfoPtr_m_time;

	private static readonly IntPtr NativeFieldInfoPtr_m_submitReduceFactor;

	private static readonly IntPtr NativeFieldInfoPtr_m_cutOutFactor;

	private static readonly IntPtr NativeFieldInfoPtr_m_upFactor;

	private static readonly IntPtr NativeFieldInfoPtr_upFactor;

	private static readonly IntPtr NativeFieldInfoPtr_isupfactor;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isParticleSystem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isParticleSystem)) = flag;
		}
	}

	public unsafe Material m_inputMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inputMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inputMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material m_objectMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_objectMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_objectMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe MeshRenderer m_meshRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_meshRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_meshRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe ParticleSystemRenderer m_particleRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_particleRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystemRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_particleRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particleSystemRenderer));
		}
	}

	public unsafe float m_timeToReduce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeToReduce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeToReduce)) = num;
		}
	}

	public unsafe float m_reduceFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_reduceFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_reduceFactor)) = num;
		}
	}

	public unsafe float m_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_time)) = num;
		}
	}

	public unsafe float m_submitReduceFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_submitReduceFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_submitReduceFactor)) = num;
		}
	}

	public unsafe float m_cutOutFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cutOutFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cutOutFactor)) = num;
		}
	}

	public unsafe float m_upFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_upFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_upFactor)) = num;
		}
	}

	public unsafe float upFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upFactor)) = num;
		}
	}

	public unsafe bool isupfactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isupfactor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isupfactor)) = flag;
		}
	}

	static NewMaterialChange()
	{
		Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NewMaterialChange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr);
		NativeFieldInfoPtr_isParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "isParticleSystem");
		NativeFieldInfoPtr_m_inputMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_inputMaterial");
		NativeFieldInfoPtr_m_objectMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_objectMaterial");
		NativeFieldInfoPtr_m_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_meshRenderer");
		NativeFieldInfoPtr_m_particleRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_particleRenderer");
		NativeFieldInfoPtr_m_timeToReduce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_timeToReduce");
		NativeFieldInfoPtr_m_reduceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_reduceFactor");
		NativeFieldInfoPtr_m_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_time");
		NativeFieldInfoPtr_m_submitReduceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_submitReduceFactor");
		NativeFieldInfoPtr_m_cutOutFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_cutOutFactor");
		NativeFieldInfoPtr_m_upFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "m_upFactor");
		NativeFieldInfoPtr_upFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "upFactor");
		NativeFieldInfoPtr_isupfactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, "isupfactor");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, 100672271);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, 100672272);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr, 100672273);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344505, XrefRangeEnd = 344520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344520, XrefRangeEnd = 344536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344536, XrefRangeEnd = 344537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewMaterialChange()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMaterialChange>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NewMaterialChange(IntPtr pointer)
		: base(pointer)
	{
	}
}
