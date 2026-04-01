using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SkillBulletData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bulletName;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletMoveType;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletRotationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletRotateSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletScale;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string bulletName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe SkillBulletMoveType bulletMoveType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletMoveType);
			return *(SkillBulletMoveType*)num;
		}
		set
		{
			*(SkillBulletMoveType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletMoveType)) = skillBulletMoveType;
		}
	}

	public unsafe float bulletSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletSpeed)) = num;
		}
	}

	public unsafe SkillBulletRotationType bulletRotationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRotationType);
			return *(SkillBulletRotationType*)num;
		}
		set
		{
			*(SkillBulletRotationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRotationType)) = skillBulletRotationType;
		}
	}

	public unsafe float bulletRotateSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRotateSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRotateSpeed)) = num;
		}
	}

	public unsafe float bulletScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletScale)) = num;
		}
	}

	static SkillBulletData()
	{
		Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillBulletData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr);
		NativeFieldInfoPtr_bulletName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletName");
		NativeFieldInfoPtr_bulletMoveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletMoveType");
		NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletSpeed");
		NativeFieldInfoPtr_bulletRotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletRotationType");
		NativeFieldInfoPtr_bulletRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletRotateSpeed");
		NativeFieldInfoPtr_bulletScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, "bulletScale");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, 100667914);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr, 100667915);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141630, RefRangeEnd = 141631, XrefRangeStart = 141615, XrefRangeEnd = 141630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141631, XrefRangeEnd = 141632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillBulletData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillBulletData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillBulletData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
