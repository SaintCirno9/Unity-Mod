using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class StudyAttackBulletController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_loseHpRate;

	private static readonly IntPtr NativeFieldInfoPtr_speedRate;

	private static readonly IntPtr NativeFieldInfoPtr_spinTime;

	private static readonly IntPtr NativeFieldInfoPtr_faceTarget;

	private static readonly IntPtr NativeFieldInfoPtr_speEffect;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float loseHpRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseHpRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseHpRate)) = num;
		}
	}

	public unsafe float speedRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedRate)) = num;
		}
	}

	public unsafe float spinTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spinTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spinTime)) = num;
		}
	}

	public unsafe bool faceTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTarget)) = flag;
		}
	}

	public unsafe string speEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEffect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEffect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static StudyAttackBulletController()
	{
		Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StudyAttackBulletController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr);
		NativeFieldInfoPtr_loseHpRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, "loseHpRate");
		NativeFieldInfoPtr_speedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, "speedRate");
		NativeFieldInfoPtr_spinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, "spinTime");
		NativeFieldInfoPtr_faceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, "faceTarget");
		NativeFieldInfoPtr_speEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, "speEffect");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr, 100671720);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StudyAttackBulletController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyAttackBulletController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StudyAttackBulletController(IntPtr pointer)
		: base(pointer)
	{
	}
}
