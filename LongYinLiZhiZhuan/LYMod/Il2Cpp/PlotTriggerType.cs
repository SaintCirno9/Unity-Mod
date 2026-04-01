using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "PlotTriggerType")]
public enum PlotTriggerType
{
	None,
	BigMapRandomEvent,
	AreaRandomEvent,
	EnterArea,
	EnterBuilding,
	InteractHero,
	FinishReadBook,
	FinishStudySkill,
	StayInArea,
	EnterInn
}
