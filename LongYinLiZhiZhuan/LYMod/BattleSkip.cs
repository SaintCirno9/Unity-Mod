using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace LYMod;

public static class BattleSkip
{
    private static int _storedEnemyCount;
    private static float _storedEnemyTotalHp;

    [HarmonyPatch(typeof(BattleController), nameof(BattleController.StartBattleButtonClicked))]
    public static class StartBattleButtonClickedPatch
    {
        public static void Postfix(BattleController __instance)
        {
            if (!Plugin.Instance.BattleSkipFlag.Value) return;
            var skipButton = __instance.battleSkipButton;
            if (__instance != null && !skipButton.activeSelf)
            {
                skipButton.SetActive(true);
                MelonLogger.Msg("[BattleTest] [StartBattleButtonClicked] 显示跳过按钮");
            }
        }
    }

    [HarmonyPatch(typeof(BattleController), nameof(BattleController.SureSkipBattle))]
    public static class SureSkipBattlePatch
    {
        public static void Prefix(BattleController __instance)
        {
            MelonLogger.Msg("[BattleTest] [SureSkipBattle] 跳过战斗开始");

            var playerTeamID = __instance.GetPlayerControlTeamID();

            var playerScore = 0f;

            GetEnemyInfo(__instance, playerTeamID, out var enemyCount, out var enemyTotalHP);
            _storedEnemyCount = enemyCount;
            _storedEnemyTotalHp = enemyTotalHP;

            MelonLogger.Msg($"[BattleTest] [SureSkipBattle] 玩家队伍ID: {playerTeamID}, 战力: {playerScore}");
            MelonLogger.Msg($"[BattleTest] [SureSkipBattle] 敌人数量: {enemyCount}, 敌人总血量: {enemyTotalHP}");

            __instance.winTeamID = playerTeamID;
            __instance.winTeamLeftFightScore = playerScore;
            __instance.fightCounted = true;
            __instance.randomTrophy = true;

            var playerUnit = __instance.playerBattleUnit;
            if (playerUnit != null)
            {
                if (playerUnit.battleInfo == null) playerUnit.battleInfo = new BattleInfoData();
                playerUnit.battleInfo.makeDamage = _storedEnemyTotalHp;
                playerUnit.battleInfo.takeDamage = 0f;
                playerUnit.battleInfo.enemyKilled = _storedEnemyCount;
                playerUnit.battleInfo.enemyKillScorePercent = _storedEnemyTotalHp;

                MelonLogger.Msg(
                    $"[BattleTest] [SureSkipBattle] 设置 playerBattleUnit.battleInfo: makeDamage={_storedEnemyTotalHp}, enemyKilled={_storedEnemyCount}");
            }
            else
            {
                MelonLogger.Warning("[BattleTest] [SureSkipBattle] playerBattleUnit 为空");
            }
        }
    }

    private static void GetEnemyInfo(BattleController bc, int playerTeamID, out int enemyCount, out float enemyTotalHP)
    {
        enemyCount = 0;
        enemyTotalHP = 0f;

        var teams = bc.teams;
        if (teams == null)
        {
            MelonLogger.Warning("[BattleTest] teams 为空");
            return;
        }

        foreach (var team in teams)
        {
            if (team == null || team.ID == playerTeamID) continue;

            var units = team.battleUnits;
            if (units == null) continue;

            foreach (var unit in units)
            {
                if (unit == null || unit.heroData == null) continue;
                enemyCount++;
                enemyTotalHP += unit.heroData.maxhp;
            }
        }
    }

    [HarmonyPatch(typeof(BattleController), nameof(BattleController.CountPlayerBattleScore))]
    public static class CountPlayerBattleScorePatch
    {
        public static void Postfix(BattleController __instance, float enemyTotalScore, ref bool heroWin, ref float __result)
        {
            if (!Plugin.Instance.BattleSkipFlag.Value) return;

            MelonLogger.Msg(
                $"[BattleTest] [CountPlayerBattleScore] enemyTotalScore={enemyTotalScore}, heroWin={heroWin}, 原始返回值={__result}");
            __instance.winTeamID = __instance.GetPlayerControlTeamID();
            if (heroWin) __result = 100f;

        }
    }

    [HarmonyPatch(typeof(BattleController), nameof(BattleController.CountHeroBattleContribution))]
    public static class CountHeroBattleContributionPatch
    {
        public static void Prefix(BattleController __instance, BattleUnit targetUnit, bool win)
        {
            if (!Plugin.Instance.BattleSkipFlag.Value) return;
            
            if (targetUnit == null || targetUnit.battleInfo == null) return;
            if (targetUnit.heroData == null || targetUnit.heroData.heroID != 0) return;

            targetUnit.battleInfo.makeDamage = _storedEnemyTotalHp;
            targetUnit.battleInfo.takeDamage = 0f;
            targetUnit.battleInfo.enemyKilled = _storedEnemyCount;
            targetUnit.battleInfo.enemyKillScorePercent = _storedEnemyTotalHp;
        }
    }
}