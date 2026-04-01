using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class SpeGridObjData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_speGridObjType;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_describe;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyAfterTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamID;

	private static readonly System.IntPtr NativeFieldInfoPtr_hp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_abovePlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_onGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_flipX;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe SpeGridObjType speGridObjType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObjType);
			return *(SpeGridObjType*)num;
		}
		set
		{
			*(SpeGridObjType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speGridObjType)) = speGridObjType;
		}
	}

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string describe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_describe)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool destroyAfterTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyAfterTrigger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyAfterTrigger)) = flag;
		}
	}

	public unsafe float valueRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueRate)) = num;
		}
	}

	public unsafe int teamID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID)) = num;
		}
	}

	public unsafe float hp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp)) = num;
		}
	}

	public unsafe float maxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHp)) = num;
		}
	}

	public unsafe bool abovePlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abovePlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abovePlayer)) = flag;
		}
	}

	public unsafe bool onGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGround);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGround)) = flag;
		}
	}

	public unsafe string soundEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffect);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool flipX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipX)) = flag;
		}
	}

	static SpeGridObjData()
	{
		Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpeGridObjData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr);
		NativeFieldInfoPtr_speGridObjType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "speGridObjType");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_describe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "describe");
		NativeFieldInfoPtr_destroyAfterTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "destroyAfterTrigger");
		NativeFieldInfoPtr_valueRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "valueRate");
		NativeFieldInfoPtr_teamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "teamID");
		NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "hp");
		NativeFieldInfoPtr_maxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "maxHp");
		NativeFieldInfoPtr_abovePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "abovePlayer");
		NativeFieldInfoPtr_onGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "onGround");
		NativeFieldInfoPtr_soundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "soundEffect");
		NativeFieldInfoPtr_flipX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, "flipX");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, 100666471);
		NativeMethodInfoPtr_GetValueRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, 100666472);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr, 100666473);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96584, RefRangeEnd = 96586, XrefRangeStart = 96583, XrefRangeEnd = 96584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpeGridObjData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeGridObjData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 96586, RefRangeEnd = 96592, XrefRangeStart = 96586, XrefRangeEnd = 96586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetValueRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96607, RefRangeEnd = 96610, XrefRangeStart = 96592, XrefRangeEnd = 96607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public SpeGridObjData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
