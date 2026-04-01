using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPigeonCoopToolkit.Effects.Trails;
using UnityEngine;

namespace Il2Cpp;

public class Orbiter : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_TankCollisionOrbitRadius;

	private static readonly IntPtr NativeFieldInfoPtr_TankCollisionRotationSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_Trail;

	private static readonly IntPtr NativeFieldInfoPtr__tankBeingController;

	private static readonly IntPtr NativeFieldInfoPtr__pos;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float TankCollisionOrbitRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TankCollisionOrbitRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TankCollisionOrbitRadius)) = num;
		}
	}

	public unsafe float TankCollisionRotationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TankCollisionRotationSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TankCollisionRotationSpeed)) = num;
		}
	}

	public unsafe Trail Trail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trail);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Trail>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trail));
		}
	}

	public unsafe TankController _tankBeingController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tankBeingController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TankController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tankBeingController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tankController));
		}
	}

	public unsafe Vector3 _pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pos)) = vector;
		}
	}

	static Orbiter()
	{
		Il2CppClassPointerStore<Orbiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Orbiter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Orbiter>.NativeClassPtr);
		NativeFieldInfoPtr_TankCollisionOrbitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, "TankCollisionOrbitRadius");
		NativeFieldInfoPtr_TankCollisionRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, "TankCollisionRotationSpeed");
		NativeFieldInfoPtr_Trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, "Trail");
		NativeFieldInfoPtr__tankBeingController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, "_tankBeingController");
		NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, "_pos");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, 100665755);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, 100665756);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Orbiter>.NativeClassPtr, 100665757);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73582, XrefRangeEnd = 73583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73583, XrefRangeEnd = 73616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73616, XrefRangeEnd = 73617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Orbiter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Orbiter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Orbiter(IntPtr pointer)
		: base(pointer)
	{
	}
}
