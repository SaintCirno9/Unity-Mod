using System;
using Il2CppInterop.Common.Attributes;

namespace Il2Cpp;

[Serializable]
[OriginalName("Assembly-CSharp.dll", "", "AuctionStep")]
public enum AuctionStep
{
	None,
	Start,
	Offer,
	Wait,
	Deal,
	End
}
