using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class BattlePlotData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battlePlotTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_battlePlotTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_battlePlotID;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAutoDestroy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattlePlotTrigger_String_Int32_Boolean_0;

	public unsafe BattlePlotTrigger battlePlotTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotTrigger);
			return *(BattlePlotTrigger*)num;
		}
		set
		{
			*(BattlePlotTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotTrigger)) = battlePlotTrigger;
		}
	}

	public unsafe string battlePlotTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotTarget);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotTarget)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int battlePlotID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePlotID)) = num;
		}
	}

	public unsafe bool noAutoDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoDestroy)) = flag;
		}
	}

	static BattlePlotData()
	{
		Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattlePlotData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr);
		NativeFieldInfoPtr_battlePlotTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr, "battlePlotTrigger");
		NativeFieldInfoPtr_battlePlotTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr, "battlePlotTarget");
		NativeFieldInfoPtr_battlePlotID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr, "battlePlotID");
		NativeFieldInfoPtr_noAutoDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr, "noAutoDestroy");
		NativeMethodInfoPtr__ctor_Public_Void_BattlePlotTrigger_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr, 100666056);
	}

	[CallerCount(195)]
	[CachedScanResults(RefRangeStart = 83395, RefRangeEnd = 83590, XrefRangeStart = 83393, XrefRangeEnd = 83395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattlePlotData(BattlePlotTrigger _battlePlotTrigger, string _battlePlotTarget, int _battlePlotID, bool _noAutoDestroy = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattlePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_battlePlotTrigger);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_battlePlotTarget);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_battlePlotID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_noAutoDestroy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattlePlotTrigger_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattlePlotData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
