using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "HorseMatchState")]
public enum HorseMatchState
{
	None,
	Prepare,
	CountDown,
	Start,
	End
}
