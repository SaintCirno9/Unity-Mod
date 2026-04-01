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
public class KungfuSkillLvData : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("KungfuSkillLvData+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__56_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBreakThroughAvailableChoice_b__56_0_Internal_Boolean_Int32_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<int> __9__56_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__56_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__56_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667897);
			NativeMethodInfoPtr__GetBreakThroughAvailableChoice_b__56_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667898);
		}

		[CallerCount(1513)]
		[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139970, XrefRangeEnd = 139984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetBreakThroughAvailableChoice_b__56_0(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBreakThroughAvailableChoice_b__56_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_skillID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lv;

	private static readonly System.IntPtr NativeFieldInfoPtr_fightExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_equiped;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_speEquipData;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipUseSpeAddValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_speUseData;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageUseSpeAddValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfUseSpeAddValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemyUseSpeAddValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraAddData;

	private static readonly System.IntPtr NativeFieldInfoPtr_cdTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeTimeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_power;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleDamageCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillIconDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxManaChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkillMeetObstacleLv_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillIcon_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillExpExchangeRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StudyMoneyCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StudyDayCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BreakThroughDayCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePower_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxPower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeExtraAddData_Public_Void_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageCdTimeLeft_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FightReset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillNeedExpRate_Public_Single_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CDTimeTotal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Name_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Type_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAtkPartPosture_Public_PartPostureData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefPartPosture_Public_PartPostureData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLvSpeDamageChange_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseDamage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetManaCost_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Upgrade_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeEquipData_Public_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraAddData_Public_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSpeEquipData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSpeUseData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeUseData_Public_HeroSpeAddData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkillGetMaxExp_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BookExpFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FightExpFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullFillExp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExpDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBreakThroughAvailableChoice_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoManageBreakThrough_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountDamageRatio_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBelongHero_Public_HeroData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillFightScore_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillBattleCountDescribe_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillDescribe_Public_String_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe int skillID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillID)) = num;
		}
	}

	public unsafe int lv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lv)) = num;
		}
	}

	public unsafe float fightExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightExp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fightExp)) = num;
		}
	}

	public unsafe float bookExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookExp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookExp)) = num;
		}
	}

	public unsafe bool equiped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equiped)) = flag;
		}
	}

	public unsafe bool isNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNew);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNew)) = flag;
		}
	}

	public unsafe int belongHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongHeroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongHeroID)) = num;
		}
	}

	public unsafe HeroSpeAddData speEquipData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEquipData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speEquipData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe float equipUseSpeAddValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipUseSpeAddValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipUseSpeAddValue)) = num;
		}
	}

	public unsafe HeroSpeAddData speUseData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speUseData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speUseData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe float damageUseSpeAddValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageUseSpeAddValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageUseSpeAddValue)) = num;
		}
	}

	public unsafe float selfUseSpeAddValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfUseSpeAddValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfUseSpeAddValue)) = num;
		}
	}

	public unsafe float enemyUseSpeAddValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyUseSpeAddValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enemyUseSpeAddValue)) = num;
		}
	}

	public unsafe HeroSpeAddData extraAddData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAddData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroSpeAddData));
		}
	}

	public unsafe float cdTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdTimeLeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdTimeLeft)) = num;
		}
	}

	public unsafe int useTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTime)) = num;
		}
	}

	public unsafe float activeTimeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTimeLeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTimeLeft)) = num;
		}
	}

	public unsafe float power
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_power)) = num;
		}
	}

	public unsafe float battleDamageCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleDamageCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleDamageCount)) = num;
		}
	}

	public unsafe bool skillIconDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillIconDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillIconDirty)) = flag;
		}
	}

	public unsafe bool maxManaChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxManaChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxManaChanged)) = flag;
		}
	}

	static KungfuSkillLvData()
	{
		Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "KungfuSkillLvData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr);
		NativeFieldInfoPtr_skillID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "skillID");
		NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "lv");
		NativeFieldInfoPtr_fightExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "fightExp");
		NativeFieldInfoPtr_bookExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "bookExp");
		NativeFieldInfoPtr_equiped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "equiped");
		NativeFieldInfoPtr_isNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "isNew");
		NativeFieldInfoPtr_belongHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "belongHeroID");
		NativeFieldInfoPtr_speEquipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "speEquipData");
		NativeFieldInfoPtr_equipUseSpeAddValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "equipUseSpeAddValue");
		NativeFieldInfoPtr_speUseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "speUseData");
		NativeFieldInfoPtr_damageUseSpeAddValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "damageUseSpeAddValue");
		NativeFieldInfoPtr_selfUseSpeAddValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "selfUseSpeAddValue");
		NativeFieldInfoPtr_enemyUseSpeAddValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "enemyUseSpeAddValue");
		NativeFieldInfoPtr_extraAddData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "extraAddData");
		NativeFieldInfoPtr_cdTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "cdTimeLeft");
		NativeFieldInfoPtr_useTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "useTime");
		NativeFieldInfoPtr_activeTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "activeTimeLeft");
		NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "power");
		NativeFieldInfoPtr_battleDamageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "battleDamageCount");
		NativeFieldInfoPtr_skillIconDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "skillIconDirty");
		NativeFieldInfoPtr_maxManaChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, "maxManaChanged");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_SkillMeetObstacleLv_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_GetSkillIcon_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667855);
		NativeMethodInfoPtr_GetSkillExpExchangeRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_StudyMoneyCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_StudyDayCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_BreakThroughDayCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_ChangePower_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_MaxPower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_ChangeExtraAddData_Public_Void_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr_ManageCdTimeLeft_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_FightReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_GetSkillNeedExpRate_Public_Single_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_CDTimeTotal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_GetActiveTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr_Name_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667868);
		NativeMethodInfoPtr_Type_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667869);
		NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr_GetAtkPartPosture_Public_PartPostureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667871);
		NativeMethodInfoPtr_GetDefPartPosture_Public_PartPostureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667872);
		NativeMethodInfoPtr_GetLvSpeDamageChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_GetBaseDamage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667874);
		NativeMethodInfoPtr_GetManaCost_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667875);
		NativeMethodInfoPtr_Upgrade_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667876);
		NativeMethodInfoPtr_GetSpeEquipData_Public_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667877);
		NativeMethodInfoPtr_GetExtraAddData_Public_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667878);
		NativeMethodInfoPtr_ResetSpeEquipData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667879);
		NativeMethodInfoPtr_ResetSpeUseData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667880);
		NativeMethodInfoPtr_GetSpeUseData_Public_HeroSpeAddData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667881);
		NativeMethodInfoPtr_SkillGetMaxExp_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667882);
		NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667883);
		NativeMethodInfoPtr_BookExpFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667884);
		NativeMethodInfoPtr_FightExpFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667885);
		NativeMethodInfoPtr_FullFillExp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667886);
		NativeMethodInfoPtr_GetExpDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667887);
		NativeMethodInfoPtr_GetBreakThroughAvailableChoice_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667888);
		NativeMethodInfoPtr_AutoManageBreakThrough_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667889);
		NativeMethodInfoPtr_CountDamageRatio_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667890);
		NativeMethodInfoPtr_GetBelongHero_Public_HeroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667891);
		NativeMethodInfoPtr_GetSkillFightScore_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667892);
		NativeMethodInfoPtr_GetSkillBattleCountDescribe_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667893);
		NativeMethodInfoPtr_GetSkillDescribe_Public_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667894);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr, 100667895);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 140000, RefRangeEnd = 140036, XrefRangeStart = 139984, XrefRangeEnd = 140000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillLvData(int _skillID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KungfuSkillLvData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_skillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 140047, RefRangeEnd = 140056, XrefRangeStart = 140036, XrefRangeEnd = 140047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SkillMeetObstacleLv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkillMeetObstacleLv_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 140063, RefRangeEnd = 140074, XrefRangeStart = 140056, XrefRangeEnd = 140063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkillIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillIcon_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140077, RefRangeEnd = 140080, XrefRangeStart = 140074, XrefRangeEnd = 140077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillExpExchangeRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillExpExchangeRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140090, RefRangeEnd = 140093, XrefRangeStart = 140080, XrefRangeEnd = 140090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int StudyMoneyCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StudyMoneyCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140103, RefRangeEnd = 140105, XrefRangeStart = 140093, XrefRangeEnd = 140103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int StudyDayCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StudyDayCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 140112, RefRangeEnd = 140120, XrefRangeStart = 140105, XrefRangeEnd = 140112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int BreakThroughDayCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BreakThroughDayCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140124, RefRangeEnd = 140127, XrefRangeStart = 140120, XrefRangeEnd = 140124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePower(float deltaPower)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaPower);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePower_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 140129, RefRangeEnd = 140138, XrefRangeStart = 140127, XrefRangeEnd = 140129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MaxPower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxPower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140142, RefRangeEnd = 140143, XrefRangeStart = 140138, XrefRangeEnd = 140142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeExtraAddData(HeroSpeAddData deltaAddData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaAddData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeExtraAddData_Public_Void_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140144, RefRangeEnd = 140148, XrefRangeStart = 140143, XrefRangeEnd = 140144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageCdTimeLeft(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageCdTimeLeft_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140148, RefRangeEnd = 140152, XrefRangeStart = 140148, XrefRangeEnd = 140148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FightReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FightReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 140153, RefRangeEnd = 140158, XrefRangeStart = 140152, XrefRangeEnd = 140153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillNeedExpRate(HeroData targetHero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetHero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillNeedExpRate_Public_Single_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140160, RefRangeEnd = 140161, XrefRangeStart = 140158, XrefRangeEnd = 140160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CDTimeTotal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CDTimeTotal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129681, RefRangeEnd = 129682, XrefRangeStart = 129681, XrefRangeEnd = 129682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetActiveTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 140166, RefRangeEnd = 140221, XrefRangeStart = 140161, XrefRangeEnd = 140166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Name(bool colored = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&colored);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Name_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 140222, RefRangeEnd = 140243, XrefRangeStart = 140221, XrefRangeEnd = 140222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Type()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Type_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(339)]
	[CachedScanResults(RefRangeStart = 140253, RefRangeEnd = 140592, XrefRangeStart = 140243, XrefRangeEnd = 140253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuSkillData DataBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataBase_Public_KungfuSkillData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuSkillData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140592, XrefRangeEnd = 140593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartPostureData GetAtkPartPosture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAtkPartPosture_Public_PartPostureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PartPostureData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140593, XrefRangeEnd = 140594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartPostureData GetDefPartPosture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefPartPosture_Public_PartPostureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PartPostureData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140595, RefRangeEnd = 140596, XrefRangeStart = 140594, XrefRangeEnd = 140595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLvSpeDamageChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLvSpeDamageChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140597, RefRangeEnd = 140599, XrefRangeStart = 140596, XrefRangeEnd = 140597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBaseDamage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseDamage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140602, XrefRangeStart = 140599, XrefRangeEnd = 140600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetManaCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetManaCost_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140604, RefRangeEnd = 140605, XrefRangeStart = 140602, XrefRangeEnd = 140604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Upgrade(int upgradeLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&upgradeLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Upgrade_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140606, RefRangeEnd = 140610, XrefRangeStart = 140605, XrefRangeEnd = 140606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData GetSpeEquipData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeEquipData_Public_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140611, RefRangeEnd = 140615, XrefRangeStart = 140610, XrefRangeEnd = 140611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData GetExtraAddData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraAddData_Public_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140651, RefRangeEnd = 140655, XrefRangeStart = 140615, XrefRangeEnd = 140651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetSpeEquipData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSpeEquipData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140719, RefRangeEnd = 140723, XrefRangeStart = 140655, XrefRangeEnd = 140719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetSpeUseData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSpeUseData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 45391, RefRangeEnd = 45397, XrefRangeStart = 45391, XrefRangeEnd = 45397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroSpeAddData GetSpeUseData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeUseData_Public_HeroSpeAddData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroSpeAddData>(intPtr) : null;
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 140726, RefRangeEnd = 140750, XrefRangeStart = 140723, XrefRangeEnd = 140726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float SkillGetMaxExp(int expType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkillGetMaxExp_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 140756, RefRangeEnd = 140760, XrefRangeStart = 140750, XrefRangeEnd = 140756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUpgrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUpgrade_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 140763, RefRangeEnd = 140768, XrefRangeStart = 140760, XrefRangeEnd = 140763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BookExpFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BookExpFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 140771, RefRangeEnd = 140776, XrefRangeStart = 140768, XrefRangeEnd = 140771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FightExpFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FightExpFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140782, RefRangeEnd = 140784, XrefRangeStart = 140776, XrefRangeEnd = 140782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FullFillExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullFillExp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140811, RefRangeEnd = 140813, XrefRangeStart = 140784, XrefRangeEnd = 140811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetExpDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExpDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140947, RefRangeEnd = 140949, XrefRangeStart = 140813, XrefRangeEnd = 140947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetBreakThroughAvailableChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBreakThroughAvailableChoice_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140949, XrefRangeEnd = 140979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoManageBreakThrough()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoManageBreakThrough_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float CountDamageRatio(float sourceNum, float addRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sourceNum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addRatio;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountDamageRatio_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 141035, RefRangeEnd = 141038, XrefRangeStart = 140979, XrefRangeEnd = 141035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeroData GetBelongHero()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBelongHero_Public_HeroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141071, RefRangeEnd = 141072, XrefRangeStart = 141038, XrefRangeEnd = 141071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSkillFightScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillFightScore_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 141098, RefRangeEnd = 141102, XrefRangeStart = 141072, XrefRangeEnd = 141098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkillBattleCountDescribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillBattleCountDescribe_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 141358, RefRangeEnd = 141360, XrefRangeStart = 141102, XrefRangeEnd = 141358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSkillDescribe(bool fullDetail, bool showDamage, bool bookDescribe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&fullDetail);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showDamage;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bookDescribe;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillDescribe_Public_String_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141360, XrefRangeEnd = 141375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public KungfuSkillLvData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
