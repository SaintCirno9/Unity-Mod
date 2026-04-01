using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[OriginalName("Assembly-CSharp.dll", "", "ActiveUnitBattleState")]
public enum ActiveUnitBattleState
{
	None,
	WaitAIPlan,
	WaitPlayerInput,
	Rest,
	ChooseUseItemTarget,
	UseItem,
	ShowMovingRage,
	WaitMoving,
	Moving,
	ShowAttackingRage,
	WaitAttacking,
	Attacking,
	Finish,
	Finishing
}
