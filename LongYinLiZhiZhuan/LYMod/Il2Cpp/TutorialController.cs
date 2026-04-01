using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class TutorialController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_tutorialPanel;

	private static readonly IntPtr NativeFieldInfoPtr_highLightRect;

	private static readonly IntPtr NativeFieldInfoPtr_arrow;

	private static readonly IntPtr NativeFieldInfoPtr_tutorialTextUI;

	private static readonly IntPtr NativeFieldInfoPtr_inTutorial;

	private static readonly IntPtr NativeFieldInfoPtr_nowTutorial;

	private static readonly IntPtr NativeFieldInfoPtr_nowTutorialPlotCount;

	private static readonly IntPtr NativeFieldInfoPtr_tutorialDatas;

	private static readonly IntPtr NativeFieldInfoPtr_textShowing;

	private static readonly IntPtr NativeFieldInfoPtr_tutorialNoLeaveBuilding;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TutorialController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartTutorial_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowNextTutorialPlot_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialCallPlot_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_HightLightRectClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_BlackBackClicked_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialSkillPowerSpeFuc_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFindBuildingButton_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFindBuildingChoiceButton_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTutorialNoLeaveBuilding_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartReadBookFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartLeaderFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartReadBookFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartReadSelfBookFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartWriteBookFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartReadBookFindBook_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyFightFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyFightFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyFightFindPlotChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyFightFindSkillChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialForceMissionFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialForceMissionFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartBreakThroughFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartBreakThroughFindPlotChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartBreakThroughFindSkillChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyInternalFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyInternalFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialQuickShowPlot_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnMazePlayer_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnMazeEnd_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnAreaCenter_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialShowHeroDetailItem_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialShowMission_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialShowWorldNews_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialHideMission_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnArea_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialSetMoveTargetArea_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFindMissionButton_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartBigMapFindMission_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartCureInjuryFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartRestFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartRestFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartRestFindPlotChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartSelfStorageFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartStudyPracticeFightFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialAskForItemFindPlotChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialAskForSkillFindPlotChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFindPlotChoice_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_HighLightPlotChoiceIncludeText_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindPlotChoiceIncludeText_Public_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartManageForceFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartManageForceFindBuildingChoice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartFreeModeFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnBattleUnit_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialFocusOnNowActive_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowComboUI_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnshowComboUI_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TutorialStartGovernFindBuilding_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ShowNextTutorialPlot_b__15_0_Private_Void_0;

	public unsafe GameObject tutorialPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe RectTransform highLightRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightRect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe GameObject arrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject tutorialTextUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialTextUI);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialTextUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool inTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inTutorial)) = flag;
		}
	}

	public unsafe TutorialData nowTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowTutorial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TutorialData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowTutorial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tutorialData));
		}
	}

	public unsafe int nowTutorialPlotCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowTutorialPlotCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nowTutorialPlotCount)) = num;
		}
	}

	public unsafe List<TutorialData> tutorialDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialDatas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TutorialData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool textShowing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textShowing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textShowing)) = flag;
		}
	}

	public unsafe bool tutorialNoLeaveBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialNoLeaveBuilding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialNoLeaveBuilding)) = flag;
		}
	}

	public unsafe static TutorialController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TutorialController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tutorialController));
		}
	}

	public unsafe static TutorialController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339099, XrefRangeEnd = 339101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_TutorialController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TutorialController>(intPtr) : null;
		}
	}

	static TutorialController()
	{
		Il2CppClassPointerStore<TutorialController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialController>.NativeClassPtr);
		NativeFieldInfoPtr_tutorialPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "tutorialPanel");
		NativeFieldInfoPtr_highLightRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "highLightRect");
		NativeFieldInfoPtr_arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "arrow");
		NativeFieldInfoPtr_tutorialTextUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "tutorialTextUI");
		NativeFieldInfoPtr_inTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "inTutorial");
		NativeFieldInfoPtr_nowTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "nowTutorial");
		NativeFieldInfoPtr_nowTutorialPlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "nowTutorialPlotCount");
		NativeFieldInfoPtr_tutorialDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "tutorialDatas");
		NativeFieldInfoPtr_textShowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "textShowing");
		NativeFieldInfoPtr_tutorialNoLeaveBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "tutorialNoLeaveBuilding");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_TutorialController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671992);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671993);
		NativeMethodInfoPtr_StartTutorial_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671994);
		NativeMethodInfoPtr_ShowNextTutorialPlot_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671995);
		NativeMethodInfoPtr_TutorialCallPlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671996);
		NativeMethodInfoPtr_HightLightRectClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671997);
		NativeMethodInfoPtr_BlackBackClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671998);
		NativeMethodInfoPtr_TutorialSkillPowerSpeFuc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100671999);
		NativeMethodInfoPtr_TutorialFindBuildingButton_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672000);
		NativeMethodInfoPtr_TutorialFindBuildingChoiceButton_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672001);
		NativeMethodInfoPtr_SetTutorialNoLeaveBuilding_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672002);
		NativeMethodInfoPtr_TutorialStartReadBookFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672003);
		NativeMethodInfoPtr_TutorialStartLeaderFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672004);
		NativeMethodInfoPtr_TutorialStartReadBookFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672005);
		NativeMethodInfoPtr_TutorialStartReadSelfBookFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672006);
		NativeMethodInfoPtr_TutorialStartWriteBookFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672007);
		NativeMethodInfoPtr_TutorialStartReadBookFindBook_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672008);
		NativeMethodInfoPtr_TutorialStartStudyFightFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672009);
		NativeMethodInfoPtr_TutorialStartStudyFightFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672010);
		NativeMethodInfoPtr_TutorialStartStudyFightFindPlotChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672011);
		NativeMethodInfoPtr_TutorialStartStudyFightFindSkillChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672012);
		NativeMethodInfoPtr_TutorialForceMissionFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672013);
		NativeMethodInfoPtr_TutorialForceMissionFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672014);
		NativeMethodInfoPtr_TutorialStartBreakThroughFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672015);
		NativeMethodInfoPtr_TutorialStartBreakThroughFindPlotChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672016);
		NativeMethodInfoPtr_TutorialStartBreakThroughFindSkillChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672017);
		NativeMethodInfoPtr_TutorialStartStudyInternalFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672018);
		NativeMethodInfoPtr_TutorialStartStudyInternalFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672019);
		NativeMethodInfoPtr_TutorialQuickShowPlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672020);
		NativeMethodInfoPtr_TutorialFocusOnMazePlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672021);
		NativeMethodInfoPtr_TutorialFocusOnMazeEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672022);
		NativeMethodInfoPtr_TutorialFocusOnAreaCenter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672023);
		NativeMethodInfoPtr_TutorialShowHeroDetailItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672024);
		NativeMethodInfoPtr_TutorialShowMission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672025);
		NativeMethodInfoPtr_TutorialShowWorldNews_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672026);
		NativeMethodInfoPtr_TutorialHideMission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672027);
		NativeMethodInfoPtr_TutorialFocusOnArea_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672028);
		NativeMethodInfoPtr_TutorialSetMoveTargetArea_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672029);
		NativeMethodInfoPtr_TutorialFindMissionButton_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672030);
		NativeMethodInfoPtr_TutorialStartBigMapFindMission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672031);
		NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672032);
		NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672033);
		NativeMethodInfoPtr_TutorialStartCureInjuryFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672034);
		NativeMethodInfoPtr_TutorialStartRestFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672035);
		NativeMethodInfoPtr_TutorialStartRestFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672036);
		NativeMethodInfoPtr_TutorialStartRestFindPlotChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672037);
		NativeMethodInfoPtr_TutorialStartSelfStorageFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672038);
		NativeMethodInfoPtr_TutorialStartStudyPracticeFightFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672039);
		NativeMethodInfoPtr_TutorialAskForItemFindPlotChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672040);
		NativeMethodInfoPtr_TutorialAskForSkillFindPlotChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672041);
		NativeMethodInfoPtr_TutorialFindPlotChoice_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672042);
		NativeMethodInfoPtr_HighLightPlotChoiceIncludeText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672043);
		NativeMethodInfoPtr_FindPlotChoiceIncludeText_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672044);
		NativeMethodInfoPtr_TutorialStartManageForceFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672045);
		NativeMethodInfoPtr_TutorialStartManageForceFindBuildingChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672046);
		NativeMethodInfoPtr_TutorialStartFreeModeFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672047);
		NativeMethodInfoPtr_TutorialFocusOnBattleUnit_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672048);
		NativeMethodInfoPtr_TutorialFocusOnNowActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672049);
		NativeMethodInfoPtr_ShowComboUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672050);
		NativeMethodInfoPtr_UnshowComboUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672051);
		NativeMethodInfoPtr_TutorialStartGovernFindBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672052);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672053);
		NativeMethodInfoPtr__ShowNextTutorialPlot_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialController>.NativeClassPtr, 100672054);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339101, XrefRangeEnd = 339104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 339150, RefRangeEnd = 339191, XrefRangeStart = 339104, XrefRangeEnd = 339150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTutorial(string tutorialName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tutorialName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartTutorial_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 339371, RefRangeEnd = 339373, XrefRangeStart = 339191, XrefRangeEnd = 339371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowNextTutorialPlot(bool firstPlot = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&firstPlot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowNextTutorialPlot_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 339386, RefRangeEnd = 339388, XrefRangeStart = 339373, XrefRangeEnd = 339386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialCallPlot(string fucText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fucText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialCallPlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339388, XrefRangeEnd = 339389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HightLightRectClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HightLightRectClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339389, XrefRangeEnd = 339392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlackBackClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlackBackClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339392, XrefRangeEnd = 339509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialSkillPowerSpeFuc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialSkillPowerSpeFuc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 339546, RefRangeEnd = 339557, XrefRangeStart = 339509, XrefRangeEnd = 339546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject TutorialFindBuildingButton(string targetBuilding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetBuilding);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFindBuildingButton_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 339587, RefRangeEnd = 339599, XrefRangeStart = 339557, XrefRangeEnd = 339587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject TutorialFindBuildingChoiceButton(string targetBuilding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetBuilding);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFindBuildingChoiceButton_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 339602, RefRangeEnd = 339603, XrefRangeStart = 339599, XrefRangeEnd = 339602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTutorialNoLeaveBuilding(string param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTutorialNoLeaveBuilding_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339603, XrefRangeEnd = 339616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartReadBookFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartReadBookFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339616, XrefRangeEnd = 339626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartLeaderFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartLeaderFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339626, XrefRangeEnd = 339639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartReadBookFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartReadBookFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339639, XrefRangeEnd = 339652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartReadSelfBookFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartReadSelfBookFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339652, XrefRangeEnd = 339665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartWriteBookFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartWriteBookFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339665, XrefRangeEnd = 339736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartReadBookFindBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartReadBookFindBook_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339736, XrefRangeEnd = 339749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyFightFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyFightFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339749, XrefRangeEnd = 339762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyFightFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyFightFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339762, XrefRangeEnd = 339782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyFightFindPlotChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyFightFindPlotChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339782, XrefRangeEnd = 339836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyFightFindSkillChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyFightFindSkillChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339836, XrefRangeEnd = 339846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialForceMissionFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialForceMissionFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339846, XrefRangeEnd = 339857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialForceMissionFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialForceMissionFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339857, XrefRangeEnd = 339868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartBreakThroughFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartBreakThroughFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339868, XrefRangeEnd = 339888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartBreakThroughFindPlotChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartBreakThroughFindPlotChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339888, XrefRangeEnd = 339963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartBreakThroughFindSkillChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartBreakThroughFindSkillChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339963, XrefRangeEnd = 339976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyInternalFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyInternalFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339976, XrefRangeEnd = 339987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyInternalFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyInternalFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 339996, RefRangeEnd = 339999, XrefRangeStart = 339987, XrefRangeEnd = 339996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialQuickShowPlot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialQuickShowPlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339999, XrefRangeEnd = 340013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnMazePlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnMazePlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340013, XrefRangeEnd = 340027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnMazeEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnMazeEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340027, XrefRangeEnd = 340047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnAreaCenter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnAreaCenter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340047, XrefRangeEnd = 340061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialShowHeroDetailItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialShowHeroDetailItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340061, XrefRangeEnd = 340073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialShowMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialShowMission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340073, XrefRangeEnd = 340085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialShowWorldNews()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialShowWorldNews_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340085, XrefRangeEnd = 340089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialHideMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialHideMission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340089, XrefRangeEnd = 340116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnArea(string _areaName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_areaName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnArea_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340116, XrefRangeEnd = 340140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialSetMoveTargetArea(string _areaName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_areaName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialSetMoveTargetArea_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 340157, RefRangeEnd = 340158, XrefRangeStart = 340140, XrefRangeEnd = 340157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject TutorialFindMissionButton(string missionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(missionName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFindMissionButton_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340158, XrefRangeEnd = 340169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartBigMapFindMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartBigMapFindMission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340169, XrefRangeEnd = 340182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartUpgradeForceLvFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340182, XrefRangeEnd = 340193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartUpgradeForceLvFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartUpgradeForceLvFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340193, XrefRangeEnd = 340206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartCureInjuryFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartCureInjuryFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340206, XrefRangeEnd = 340219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartRestFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartRestFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340219, XrefRangeEnd = 340230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartRestFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartRestFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340230, XrefRangeEnd = 340250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartRestFindPlotChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartRestFindPlotChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340250, XrefRangeEnd = 340261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartSelfStorageFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartSelfStorageFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340261, XrefRangeEnd = 340272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartStudyPracticeFightFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartStudyPracticeFightFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340272, XrefRangeEnd = 340308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialAskForItemFindPlotChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialAskForItemFindPlotChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340308, XrefRangeEnd = 340344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialAskForSkillFindPlotChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialAskForSkillFindPlotChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340344, XrefRangeEnd = 340377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFindPlotChoice(string choiceString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceString);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFindPlotChoice_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340377, XrefRangeEnd = 340396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HighLightPlotChoiceIncludeText(string targetString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetString);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighLightPlotChoiceIncludeText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 340412, RefRangeEnd = 340419, XrefRangeStart = 340396, XrefRangeEnd = 340412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindPlotChoiceIncludeText(string targetString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetString);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPlotChoiceIncludeText_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340419, XrefRangeEnd = 340432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartManageForceFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartManageForceFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340432, XrefRangeEnd = 340443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartManageForceFindBuildingChoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartManageForceFindBuildingChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340443, XrefRangeEnd = 340453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartFreeModeFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartFreeModeFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340453, XrefRangeEnd = 340495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnBattleUnit(string _targetName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_targetName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnBattleUnit_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340495, XrefRangeEnd = 340510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialFocusOnNowActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialFocusOnNowActive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340510, XrefRangeEnd = 340522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowComboUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowComboUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340522, XrefRangeEnd = 340534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnshowComboUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnshowComboUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340534, XrefRangeEnd = 340547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialStartGovernFindBuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialStartGovernFindBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43155, XrefRangeStart = 43122, XrefRangeEnd = 43155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _ShowNextTutorialPlot_b__15_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowNextTutorialPlot_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TutorialController(IntPtr pointer)
		: base(pointer)
	{
	}
}
