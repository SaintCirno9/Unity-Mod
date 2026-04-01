using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "AISettingType")]
public enum AISettingType
{
	CureSelf,
	StudyFightSkill,
	StudyLivingSkill,
	CollectResource,
	AddAreaState,
	ReduceAreaState,
	MakeMoneyAndExplore,
	MakeFriendAndStudyFight,
	FinishMissionAndRandomSpeEvent,
	CraftFood,
	CraftMed,
	CraftEquip
}
