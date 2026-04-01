using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class BattleInfoData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enemyKilled;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemyKillScorePercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_makeDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_takeDamage;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int enemyKilled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyKilled);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyKilled)) = num;
		}
	}

	public unsafe float enemyKillScorePercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyKillScorePercent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyKillScorePercent)) = num;
		}
	}

	public unsafe float makeDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeDamage)) = num;
		}
	}

	public unsafe float takeDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeDamage)) = num;
		}
	}

	static BattleInfoData()
	{
		Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattleInfoData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr);
		NativeFieldInfoPtr_enemyKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr, "enemyKilled");
		NativeFieldInfoPtr_enemyKillScorePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr, "enemyKillScorePercent");
		NativeFieldInfoPtr_makeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr, "makeDamage");
		NativeFieldInfoPtr_takeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr, "takeDamage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr, 100666061);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleInfoData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleInfoData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleInfoData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
