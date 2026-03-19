using HarmonyLib;

namespace LYMod1;


public class CraftingPatches
{
    [HarmonyPatch(typeof(CraftUIController), "GetCraftRate")]
    [HarmonyPostfix]
    public static void GetCraftRate_Postfix(int costID, ref float __result)
    {
        __result *= 100f;
    }
    
}

public class PlotControllerPatches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNewSkillToNPCSure))]
    public static void PlotController_TeachNewSkillToNPCSure_Postfix(PlotController __instance, string skillIDParam)
    {
        if (__instance != null)
        {
            if (Plugin.Instance._teachNewSkillToNPC.Value)
            {
                for (int i = 0; i < 5; i++)
                {
                    __instance.TeachNPCSure(skillIDParam);
                }
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNPCSure))]
    public static void PlotController_TeachNPCSure_Postfix(PlotController __instance)
    {
        if (__instance != null)
        {
            if (Plugin.Instance._interaction.Value)
            {
                __instance.targetInteractHero.playerInteractionTimeData.ResetTime();
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
        if (__instance != null && Plugin.Instance._readBook.Value)
        {
            __instance.totalExp = 500000f;
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
    public static bool ItemListData_GetItem_Prefix(ref ItemData targetItem, bool showPopInfo = false)
    {
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
        if (__instance != null && Plugin.Instance._redBreak.Value) 
            __instance.baseScore = 100000000f;
    }

    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.BreakFoodChoose))]
    [HarmonyPostfix]
    public static void BreakThroughController_BreakFoodChoose_Postfix(BreakThroughController __instance)
    {
        if (__instance != null && Plugin.Instance._redBreak.Value) 
            __instance.baseScore = 100000000f;
    }

    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.BreakMedChoose))]
    [HarmonyPostfix]
    public static void BreakThroughController_BreakMedChoose_Postfix(BreakThroughController __instance)
    {
        if (__instance != null && Plugin.Instance._redBreak.Value) 
            __instance.baseScore = 100000000f;
    }
}
