using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "ForceLimit")]
public enum ForceLimit
{
	None,
	SameWithPlayer,
	DifferentWithPlayer,
	EnemyWithPlayer,
	ForceID,
	NotEnemyWithPlayer
}
