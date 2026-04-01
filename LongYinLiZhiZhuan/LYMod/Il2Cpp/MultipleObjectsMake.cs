using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class MultipleObjectsMake : _ObjectsMakeBase
{
	private static readonly IntPtr NativeFieldInfoPtr_m_startDelay;

	private static readonly IntPtr NativeFieldInfoPtr_m_makeCount;

	private static readonly IntPtr NativeFieldInfoPtr_m_makeDelay;

	private static readonly IntPtr NativeFieldInfoPtr_m_randomPos;

	private static readonly IntPtr NativeFieldInfoPtr_m_randomRot;

	private static readonly IntPtr NativeFieldInfoPtr_m_randomScale;

	private static readonly IntPtr NativeFieldInfoPtr_m_Time;

	private static readonly IntPtr NativeFieldInfoPtr_m_Time2;

	private static readonly IntPtr NativeFieldInfoPtr_m_delayTime;

	private static readonly IntPtr NativeFieldInfoPtr_m_count;

	private static readonly IntPtr NativeFieldInfoPtr_m_scalefactor;

	private static readonly IntPtr NativeFieldInfoPtr_setObjVolumn;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float m_startDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startDelay)) = num;
		}
	}

	public unsafe int m_makeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_makeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_makeCount)) = num;
		}
	}

	public unsafe float m_makeDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_makeDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_makeDelay)) = num;
		}
	}

	public unsafe Vector3 m_randomPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomPos)) = vector;
		}
	}

	public unsafe Vector3 m_randomRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomRot)) = vector;
		}
	}

	public unsafe Vector3 m_randomScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_randomScale)) = vector;
		}
	}

	public unsafe float m_Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time)) = num;
		}
	}

	public unsafe float m_Time2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time2)) = num;
		}
	}

	public unsafe float m_delayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_delayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_delayTime)) = num;
		}
	}

	public unsafe float m_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count)) = num;
		}
	}

	public unsafe float m_scalefactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scalefactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scalefactor)) = num;
		}
	}

	public unsafe float setObjVolumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setObjVolumn);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setObjVolumn)) = num;
		}
	}

	static MultipleObjectsMake()
	{
		Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MultipleObjectsMake");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr);
		NativeFieldInfoPtr_m_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_startDelay");
		NativeFieldInfoPtr_m_makeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_makeCount");
		NativeFieldInfoPtr_m_makeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_makeDelay");
		NativeFieldInfoPtr_m_randomPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_randomPos");
		NativeFieldInfoPtr_m_randomRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_randomRot");
		NativeFieldInfoPtr_m_randomScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_randomScale");
		NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_Time");
		NativeFieldInfoPtr_m_Time2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_Time2");
		NativeFieldInfoPtr_m_delayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_delayTime");
		NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_count");
		NativeFieldInfoPtr_m_scalefactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "m_scalefactor");
		NativeFieldInfoPtr_setObjVolumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, "setObjVolumn");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, 100672244);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, 100672245);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr, 100672246);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344210, XrefRangeEnd = 344215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344215, XrefRangeEnd = 344248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344248, XrefRangeEnd = 344249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultipleObjectsMake()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleObjectsMake>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultipleObjectsMake(IntPtr pointer)
		: base(pointer)
	{
	}
}
