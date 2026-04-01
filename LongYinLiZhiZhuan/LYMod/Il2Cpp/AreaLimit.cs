using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "AreaLimit")]
public enum AreaLimit
{
	None,
	SameWithPlayer,
	SameWithOrNearPlayer,
	AreaID,
	SameWithEvent,
	SameWithOrNearEvent
}
