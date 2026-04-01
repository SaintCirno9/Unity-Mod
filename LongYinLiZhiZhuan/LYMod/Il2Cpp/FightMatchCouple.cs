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
public class FightMatchCouple : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroList0;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroList1;

	private static readonly System.IntPtr NativeFieldInfoPtr_winTeam;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeroData_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_HeroData_List_1_HeroData_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe List<HeroData> heroList0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroList0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroList0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HeroData> heroList1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroList1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroList1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int winTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winTeam);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winTeam)) = num;
		}
	}

	static FightMatchCouple()
	{
		Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FightMatchCouple");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, "id");
		NativeFieldInfoPtr_heroList0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, "heroList0");
		NativeFieldInfoPtr_heroList1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, "heroList1");
		NativeFieldInfoPtr_winTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, "winTeam");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, 100668361);
		NativeMethodInfoPtr__ctor_Public_Void_HeroData_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, 100668362);
		NativeMethodInfoPtr__ctor_Public_Void_List_1_HeroData_List_1_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr, 100668363);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154701, RefRangeEnd = 154702, XrefRangeStart = 154688, XrefRangeEnd = 154701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FightMatchCouple()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 154721, RefRangeEnd = 154725, XrefRangeStart = 154702, XrefRangeEnd = 154721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FightMatchCouple(HeroData hero0, HeroData hero1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hero1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HeroData_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 154740, RefRangeEnd = 154742, XrefRangeStart = 154725, XrefRangeEnd = 154740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FightMatchCouple(List<HeroData> _heroLise0, List<HeroData> _heroLise1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FightMatchCouple>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_heroLise0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_heroLise1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_HeroData_List_1_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FightMatchCouple(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
