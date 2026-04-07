using Il2Cpp;

namespace LYMod.Helpers;

public class ForceHelper
{
    /**
     * 重置自门派月限制
     */
    public static void ResetForceLimits()
    {
        if (!HeroHelper.TryReadPlayer(out var player)) return;
        var force = player?.GetForce();
        if (force == null) return;
        force.thisMonthAttack = false;
        force.thisMonthAttackResourcePoint = 0;
        force.thisMonthGetResource = 0;
        force.thisMonthAddOtherForceFavor = 0;
        force.thisMonthReduceOtherForceFavor = 0;
        force.thisMonthGetHero = 0;
        force.thisMonthManaged = 0;
    }
}