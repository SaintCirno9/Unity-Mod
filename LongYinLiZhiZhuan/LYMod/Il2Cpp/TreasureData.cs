using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class TreasureData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fullIdentified;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifyKnowledgeNeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_treasureLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifyDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_identified;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGuessTreasureLv;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool fullIdentified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullIdentified);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullIdentified)) = flag;
		}
	}

	public unsafe float identifyKnowledgeNeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyKnowledgeNeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyKnowledgeNeed)) = num;
		}
	}

	public unsafe List<int> treasureLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLv);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treasureLv)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> identifyDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyDifficulty);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyDifficulty)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<bool> identified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identified);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identified)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> playerGuessTreasureLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGuessTreasureLv);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGuessTreasureLv)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static TreasureData()
	{
		Il2CppClassPointerStore<TreasureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TreasureData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreasureData>.NativeClassPtr);
		NativeFieldInfoPtr_fullIdentified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "fullIdentified");
		NativeFieldInfoPtr_identifyKnowledgeNeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "identifyKnowledgeNeed");
		NativeFieldInfoPtr_treasureLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "treasureLv");
		NativeFieldInfoPtr_identifyDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "identifyDifficulty");
		NativeFieldInfoPtr_identified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "identified");
		NativeFieldInfoPtr_playerGuessTreasureLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, "playerGuessTreasureLv");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreasureData>.NativeClassPtr, 100668002);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 143743, RefRangeEnd = 143744, XrefRangeStart = 143613, XrefRangeEnd = 143743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TreasureData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreasureData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TreasureData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
