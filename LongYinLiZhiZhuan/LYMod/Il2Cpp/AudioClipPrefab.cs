using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class AudioClipPrefab : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_audioClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_volume;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigMapBGM;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaBGM;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaTypeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_FightBGM;

	private static readonly System.IntPtr NativeFieldInfoPtr_BossBGM;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string audioClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClip);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClip)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float volume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume)) = num;
		}
	}

	public unsafe bool BigMapBGM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapBGM);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigMapBGM)) = flag;
		}
	}

	public unsafe bool AreaBGM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaBGM);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaBGM)) = flag;
		}
	}

	public unsafe int areaTypeID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTypeID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTypeID)) = num;
		}
	}

	public unsafe int areaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID)) = num;
		}
	}

	public unsafe bool FightBGM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FightBGM);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FightBGM)) = flag;
		}
	}

	public unsafe bool BossBGM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BossBGM);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BossBGM)) = flag;
		}
	}

	static AudioClipPrefab()
	{
		Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioClipPrefab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr);
		NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "audioClip");
		NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "volume");
		NativeFieldInfoPtr_BigMapBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "BigMapBGM");
		NativeFieldInfoPtr_AreaBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "AreaBGM");
		NativeFieldInfoPtr_areaTypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "areaTypeID");
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_FightBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "FightBGM");
		NativeFieldInfoPtr_BossBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, "BossBGM");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr, 100666035);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83058, XrefRangeEnd = 83059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClipPrefab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClipPrefab>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioClipPrefab(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
