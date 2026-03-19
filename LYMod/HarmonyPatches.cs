using UnityEngine;

namespace LYMod;

using HarmonyLib;
using Il2Cpp;

public class StudyUniqueSkillControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyUniqueSkillController), nameof(StudyUniqueSkillController.FinishStudyUniqueSkill))]
    public static void StudyUniqueSkillController_FinishStudyUniqueSkill_Postfix(StudyUniqueSkillController __instance,
        StudySkillResult studyUniqueResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance._studyUniqeRate.Value;
        }
    }
}

public class StudyAttackSkillControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyAttackSkillController), nameof(StudyAttackSkillController.FinishStudyFightSkill))]
    public static void StudyAttackSkillController_FinishStudyFightSkill_Postfix(StudyAttackSkillController __instance,
        StudySkillResult studyDodgeResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance._studyFightRate.Value;
        }
    }
}

public class GameControllerPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameController), nameof(GameController.HeroJoinTeam))]
    public static bool GameController_HeroJoinTeam_Prefix(HeroData teamLeader, HeroData teamMate, ref int autoLeaveDay)
    {
        
        autoLeaveDay = Plugin.Instance._leaveDay.Value;
        return true;
    }
}

public class HeroDataPatch
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetUpgradeForceLvNeedSkillNum))]
    public static void HeroData_GetUpgradeForceLvNeedSkillNum_Prefix(HeroData __instance, ref int __result)
    {
        __result /= Plugin.Instance._maxSkillNum.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.EquipItem))]
    public static bool HeroData_EquipItem_Prefix(ItemData itemData, bool playSound = false, bool showInfo = false)
    {
        itemData.weight *= Plugin.Instance._equipmentWeight.Value;
        return true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxTagNum))]
    public static void HeroData_GetMaxTagNum_Prefix(ref int __result)
    {
        __result = Plugin.Instance._tagMaxNum.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), "ChangeFavor")]
    public static bool HeroData_ChangeFavor_Prefix(ref float num)
    {
        if (Plugin.Instance._hgbj.Value && num < 0f)
        {
            num = 0f;
        }
        return true; 
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), "ChangeBadFame")]
    public static bool HeroData_ChangeBadFame_Prefix(ref float num)
    {
        if (Plugin.Instance._hgbj.Value && num > 0f)
        {
            num = 0f;
        }
        return true; 
    }
}

public class CraftingPatches
{
    [HarmonyPatch(typeof(CraftUIController), "GetCraftRate")]
    [HarmonyPostfix]
    public static void GetCraftRate_Postfix(int costID, ref float __result)
    {
        __result *= Plugin.Instance._pzqh.Value;
    }
    
}

public class PlotControllerPatches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.CheckMeetRequire))]
    public static void PlotController_CheckMeetRequire_Postfix(PlotController __instance,
        ChoiceRequirementType requireType, float requireNum, bool includeTeamMate = true)
    {
        if (__instance != null && Plugin.Instance._interaction.Value)
        {
            var hero = __instance.targetInteractHero;
            if (hero != null)
            {
                hero.playerInteractionTimeData.ResetTime();
            }
        }
    }
    
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.GetStealNpcSkillSuccessRate))]
    [HarmonyPostfix]
    public static void PlotController_GetStealNpcSkillSuccessRate_Postfix(ref float __result)
    {
        if (Plugin.Instance._stealRate.Value)
        {
            __result = 1f;
        }
    }
    
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.GetStealNpcSuccessRate))]
    [HarmonyPostfix]
    public static void PlotController_GetStealNpcSuccessRate_Postfix(ref float __result)
    {
        if (Plugin.Instance._stealRate.Value)
        {
            __result = 1f;
        }
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNewSkillToNPCSure))]
    public static void PlotController_TeachNewSkillToNPCSure_Postfix(PlotController __instance, string skillIDParam)
    {
        if (__instance != null && Plugin.Instance._teachNewSkillToNPC.Value)
        {
            var a = __instance.targetInteractHero;
            var b = a.FindSkill(int.Parse(skillIDParam));
            for (int i = 0; i < 10; i++)
            {
                a.UpgradeSkill(b);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNPCSure))]
    public static void PlotController_TeachNPCSure_Postfix(PlotController __instance, string skillIDParam)
    {
        if (__instance != null && Plugin.Instance._teachNPC.Value)
        {
            var a = __instance.targetInteractHero;
            var b = a.FindSkill(int.Parse(skillIDParam));
            for (int i = 0; i < 10; i++)
            {
                a.UpgradeSkill(b);
            }
        }
    }
}

public class ReadBookControllerPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ReadBookController), nameof(ReadBookController.FinishRead))]
    public static void ReadBookController_FinishRead_Prefix(ReadBookController __instance)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance._readBook.Value;
        }
    }
}

public class ExploreControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ExploreController), nameof(ExploreController.PlayerFinishMove))]
    public static void ExploreController_PlayerFinishMove_Postfix(ExploreController __instance)
    {
        if (__instance != null &&  Plugin.Instance._explore.Value)
        {
            __instance.leftPower = 1000;
        }
    }
}

public class ForceDataPatches
{
// 0钱1粮2木3矿4药5威望

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource),
        typeof(Il2CppSystem.Collections.Generic.List<float>), typeof(bool))]
    public static bool ForceData_CostResource_Prefix(Il2CppSystem.Collections.Generic.List<float> resourceList,
        bool showInfo = false)
    {
        if (Plugin.Instance._cost0.Value)
        {
            for (var i = 0; i < resourceList.Count; i++) resourceList[i] = 0f;
        }
       
        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource),
        typeof(Il2CppSystem.Collections.Generic.List<ResourceData>), typeof(bool))]
    public static bool ForceData_CostResource_Prefix1(Il2CppSystem.Collections.Generic.List<ResourceData> resourceList,
        bool showInfo = false)
    {
        if (Plugin.Instance._cost0.Value)
        {
            var list = new Il2CppSystem.Collections.Generic.List<ResourceData>();
            foreach (var t in resourceList) list.Add(new ResourceData(t.resourceType, 0));
            resourceList = list;
        }
        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource), typeof(ResourceData), typeof(bool))]
    public static bool ForceData_CostResource_Prefix2(ref ResourceData resource, bool showInfo = false)
    {
        if (Plugin.Instance._cost0.Value)
        {
            resource = new ResourceData(resource.resourceType, 0);
        }
        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource), typeof(int), typeof(float), typeof(bool))]
    public static bool ForceData_CostResource_Prefix3(int id, ref float num, bool showInfo = false)
    {
        if (Plugin.Instance._cost0.Value)
        {
            num = 0;
        }
        return true;
    }
}



public class ItemListDataPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ItemListData), nameof(ItemListData.GetItem), typeof(ItemData), typeof(bool))]
    public static bool ItemListData_GetItem_Prefix(ItemListData __instance, ItemData targetItem, bool showPopInfo = false)
    {
        
        __instance.weight *= Plugin.Instance._weightRatio.Value;
        
        if (targetItem.type == ItemType.Book && Plugin.Instance._redBook.Value) 
            targetItem = targetItem.SetBookData(targetItem.bookData.skillID, 5);
        if (targetItem.type == ItemType.Material && Plugin.Instance._redMaterial.Value) 
            targetItem = targetItem.SetMaterialData(targetItem.subType, 5, 5);
        if (targetItem.type == ItemType.Treasure && Plugin.Instance._redTreasure.Value)
        {
            var item = targetItem;
            try
            {
                targetItem.SetTreasureData(targetItem.subType, 5, 5);
            }
            catch (Exception e)
            {
                targetItem = item;
            }
        }
        return true;
    }
}

public class BreakThroughControllerPatches
{
    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.BreakBookChoose))]
    [HarmonyPostfix]
    public static void BreakThroughController_BreakBookChoose_Postfix(BreakThroughController __instance)
    {
        if (__instance != null ) 
            __instance.baseScoreRate *= Plugin.Instance._redBreak.Value;
    }

    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.BreakFoodChoose))]
    [HarmonyPostfix]
    public static void BreakThroughController_BreakFoodChoose_Postfix(BreakThroughController __instance)
    {
        if (__instance != null)
        {
            __instance.baseScoreRate *= Plugin.Instance._redBreak.Value;
            Plugin.LOG.Msg(Plugin.Instance._redBreak.Value);
            Plugin.LOG.Msg(__instance.baseScoreRate);
            
        }
    }

    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.BreakMedChoose))]
    [HarmonyPostfix]
    public static void BreakThroughController_BreakMedChoose_Postfix(BreakThroughController __instance)
    {
        if (__instance != null) 
            __instance.baseScoreRate *= Plugin.Instance._redBreak.Value;
    }
}
