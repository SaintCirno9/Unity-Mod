using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class TeamMemPrepareData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_teamID;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroData;

	private static readonly System.IntPtr NativeFieldInfoPtr_enterBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_enterBattleTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareControlable_Public_Boolean_0;

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

	public unsafe HeroData heroData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroData));
		}
	}

	public unsafe bool enterBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterBattle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterBattle)) = flag;
		}
	}

	public unsafe float enterBattleTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterBattleTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterBattleTime)) = num;
		}
	}

	static TeamMemPrepareData()
	{
		Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TeamMemPrepareData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr);
		NativeFieldInfoPtr_teamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, "teamID");
		NativeFieldInfoPtr_heroData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, "heroData");
		NativeFieldInfoPtr_enterBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, "enterBattle");
		NativeFieldInfoPtr_enterBattleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, "enterBattleTime");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, 100666057);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, 100666058);
		NativeMethodInfoPtr_PrepareControlable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr, 100666059);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 83592, RefRangeEnd = 83595, XrefRangeStart = 83590, XrefRangeEnd = 83592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TeamMemPrepareData(int _teamID, HeroData _heroData, bool _enterBattle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_teamID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_heroData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_enterBattle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83597, RefRangeEnd = 83599, XrefRangeStart = 83595, XrefRangeEnd = 83597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TeamMemPrepareData(int _teamID, HeroData _heroData, bool _enterBattle, float _enterBattleTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeamMemPrepareData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_teamID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_heroData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_enterBattle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_enterBattleTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_HeroData_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83634, RefRangeEnd = 83636, XrefRangeStart = 83599, XrefRangeEnd = 83634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PrepareControlable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareControlable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public TeamMemPrepareData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
