using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class HeroLittleTalkUIController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_followTarget;

	private static readonly IntPtr NativeFieldInfoPtr_offSet;

	private static readonly IntPtr NativeFieldInfoPtr_posType;

	private static readonly IntPtr NativeFieldInfoPtr_lifeTime;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Update_b__4_0_Private_Void_0;

	public unsafe GameObject followTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 offSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offSet);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offSet)) = vector;
		}
	}

	public unsafe TalkTextPosType posType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posType);
			return *(TalkTextPosType*)num;
		}
		set
		{
			*(TalkTextPosType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posType)) = talkTextPosType;
		}
	}

	public unsafe float lifeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTime)) = num;
		}
	}

	static HeroLittleTalkUIController()
	{
		Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeroLittleTalkUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr);
		NativeFieldInfoPtr_followTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, "followTarget");
		NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, "offSet");
		NativeFieldInfoPtr_posType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, "posType");
		NativeFieldInfoPtr_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, "lifeTime");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, 100669265);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, 100669266);
		NativeMethodInfoPtr__Update_b__4_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr, 100669267);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194955, XrefRangeEnd = 195006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195006, XrefRangeEnd = 195007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroLittleTalkUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeroLittleTalkUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195007, XrefRangeEnd = 195012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Update_b__4_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__4_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HeroLittleTalkUIController(IntPtr pointer)
		: base(pointer)
	{
	}
}
