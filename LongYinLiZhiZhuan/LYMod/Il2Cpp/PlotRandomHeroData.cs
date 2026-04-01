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
public class PlotRandomHeroData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_speHeroLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaID;

	private static readonly System.IntPtr NativeFieldInfoPtr_favorRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_sexLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLvLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaderLimit;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpeHeroLimit_AreaLimit_List_1_Int32_List_1_Int32_SexLimit_ForceLimit_List_1_Int32_ForceLvLimit_Single_LeaderLimit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe SpeHeroLimit speHeroLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speHeroLimit);
			return *(SpeHeroLimit*)num;
		}
		set
		{
			*(SpeHeroLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speHeroLimit)) = speHeroLimit;
		}
	}

	public unsafe AreaLimit areaLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLimit);
			return *(AreaLimit*)num;
		}
		set
		{
			*(AreaLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLimit)) = areaLimit;
		}
	}

	public unsafe List<int> areaID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> favorRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorRange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favorRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SexLimit sexLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexLimit);
			return *(SexLimit*)num;
		}
		set
		{
			*(SexLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexLimit)) = sexLimit;
		}
	}

	public unsafe ForceLimit forceLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLimit);
			return *(ForceLimit*)num;
		}
		set
		{
			*(ForceLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLimit)) = forceLimit;
		}
	}

	public unsafe List<int> forceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForceLvLimit forceLvLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLvLimit);
			return *(ForceLvLimit*)num;
		}
		set
		{
			*(ForceLvLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLvLimit)) = forceLvLimit;
		}
	}

	public unsafe float forceLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLv);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLv)) = num;
		}
	}

	public unsafe LeaderLimit leaderLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaderLimit);
			return *(LeaderLimit*)num;
		}
		set
		{
			*(LeaderLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaderLimit)) = leaderLimit;
		}
	}

	static PlotRandomHeroData()
	{
		Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlotRandomHeroData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr);
		NativeFieldInfoPtr_speHeroLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "speHeroLimit");
		NativeFieldInfoPtr_areaLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "areaLimit");
		NativeFieldInfoPtr_areaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "areaID");
		NativeFieldInfoPtr_favorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "favorRange");
		NativeFieldInfoPtr_sexLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "sexLimit");
		NativeFieldInfoPtr_forceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "forceLimit");
		NativeFieldInfoPtr_forceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "forceID");
		NativeFieldInfoPtr_forceLvLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "forceLvLimit");
		NativeFieldInfoPtr_forceLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "forceLv");
		NativeFieldInfoPtr_leaderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, "leaderLimit");
		NativeMethodInfoPtr__ctor_Public_Void_SpeHeroLimit_AreaLimit_List_1_Int32_List_1_Int32_SexLimit_ForceLimit_List_1_Int32_ForceLvLimit_Single_LeaderLimit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, 100667268);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr, 100667269);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 123167, RefRangeEnd = 123191, XrefRangeStart = 123163, XrefRangeEnd = 123167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlotRandomHeroData(SpeHeroLimit _speHeroLimit = SpeHeroLimit.None, AreaLimit _areaLimit = AreaLimit.None, List<int> _areaID = null, List<int> _favorRange = null, SexLimit _sexLimit = SexLimit.None, ForceLimit _forceLimit = ForceLimit.None, List<int> _forceID = null, ForceLvLimit _forceLvLimit = ForceLvLimit.None, float _forceLv = 0f, LeaderLimit _leaderLimit = LeaderLimit.None)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlotRandomHeroData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&_speHeroLimit);
		*(AreaLimit**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_areaLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_areaID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_favorRange);
		*(SexLimit**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_sexLimit;
		*(ForceLimit**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_forceID);
		*(ForceLvLimit**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLvLimit;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &_forceLv;
		*(LeaderLimit**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &_leaderLimit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SpeHeroLimit_AreaLimit_List_1_Int32_List_1_Int32_SexLimit_ForceLimit_List_1_Int32_ForceLvLimit_Single_LeaderLimit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123191, XrefRangeEnd = 123206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public PlotRandomHeroData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
