using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "SkillTargetType")]
public enum SkillTargetType
{
	Enemy,
	SelfTeam,
	Self,
	TeamMate,
	EmptyGridSummon,
	EmptyGridJump
}
