namespace LYMod;

using HarmonyLib;
using Il2Cpp;


 public class IdentifyMatchControllerPatches
 {
     [HarmonyPrefix]
     [HarmonyPatch(typeof(IdentifyMatchController), nameof(IdentifyMatchController.SureButtonClicked))]
     public static bool IdentifyMatchController_SureButtonClicked_Prefix(IdentifyMatchController __instance)
     {
         if (__instance != null && __instance.identifyMatchUIPanel != null && Plugin.Instance.AutoJianBaoFlag.Value)
         {
             List<float> list = new List<float>();
             var il2CppArrayBase = __instance.identifyMatchUIPanel.GetComponentsInChildren<ItemIconController>();
             if (il2CppArrayBase != null && il2CppArrayBase.Length > 0)
             {
                 foreach (ItemIconController itemIconController in il2CppArrayBase)
                 {
                     if (itemIconController != null && itemIconController.itemData != null)
                     {
                         list.Add(itemIconController.itemData.GetTreasureRealValue());
                     }
                 }
                 int index = list.IndexOf(list.Max());
                 __instance.SetNowChooseTreasure(il2CppArrayBase[index].gameObject);
             }
         }
         return true;
     }
 }

public class AreaBuildControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildController), nameof(AreaBuildController.BuildModeButtonClicked))]
    public static void AreaBuildController_BuildModeButtonClicked_Postfix(
        AreaBuildController __instance)
    {
        if (__instance != null && Plugin.Instance.MaxSpeBuildingNum.Value > 5)
        {
            AreaBuildController.MaxSpeBuildingNum = Plugin.Instance.MaxSpeBuildingNum.Value;
        }
    }
}

public class LivingSkillPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeLivingSkillExp))]
    public static bool HeroData_ChangeLivingSkillExp_Prefix(HeroData __instance, int id,
        ref float num, bool showText)
    {
        if (__instance != null && num > 0 && Plugin.Instance.LivingSkillExpRate.Value > 0)
        {
            num *= Plugin.Instance.LivingSkillExpRate.Value;
        }
        return true;
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeMaxLivingSkill))]
    public static bool HeroData_ChangeMaxLivingSkill_Prefix(HeroData __instance, int id, 
        ref int num, bool showInfo)
    {
        if (__instance != null && num > 0 && Plugin.Instance.MaxLivingSkillExpTimes.Value > 0)
        {
            num *= Plugin.Instance.MaxLivingSkillExpTimes.Value;
        }
        return true;
    }
}


public class HeroTagIconControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ManageTagController), nameof(ManageTagController.CheckMeetCondition))]
    public static void ManageTagController_CheckMeetCondition_Postfix(ManageTagController __instance,
        HeroData checkHero, HeroTagDataBase targetTag, ref bool __result)
    {
        if (__instance != null && TestElement.AnyTagFlag)
        {
            targetTag.oppositeMeaning = "";
            targetTag.sameMeaning = "";
            __result = true;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ManageTagController), nameof(ManageTagController.CheckMeetOneCondition))]
    public static void ManageTagController_CheckMeetOneCondition_Postfix(ManageTagController __instance,
        HeroData checkHero, string requirement, ref bool __result)
    {
        if (__instance != null && TestElement.AnyTagFlag)
        {
            __result = true;
        }
    }
}
public class CraftPoisonUIControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CraftPoisonUIController), nameof(CraftPoisonUIController.GetCostTime))]
    public static void CraftPoisonUIController_GetCostTime_Postfix(CraftPoisonUIController __instance, ref int __result)
    {
        if (__instance != null)
            __result = 1;
    }
}
public class AreaBuildingDataPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaRoadData), nameof(AreaRoadData.GetUpgradeTime))]
    public static void AreaRoadData_GetUpgradeTime_Postfix(AreaRoadData? __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance._upgradeDay1.Value)
            __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetBuildTime))]
    public static void AreaBuildingData_GetBuildTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance._upgradeDay1.Value)
            __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetUpgradeTime))]
    public static void AreaBuildingData_GetUpgradeTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance._upgradeDay1.Value)
            __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetMoveTime))]
    public static void AreaBuildingData_GetMoveTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance._upgradeDay1.Value)
            __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetDestroyTime))]
    public static void AreaBuildingData_GetDestroyTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance._upgradeDay1.Value)
             __result = 1;
    }
}
// 指定突破加的什么属性
public class BreakThroughChoiceControllerPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(KungfuSkillLvData), nameof(KungfuSkillLvData.GetBreakThroughAvailableChoice))]
    public static void KungfuSkillLvData_GetBreakThroughAvailableChoice_Postfix(KungfuSkillLvData __instance,
        Il2CppSystem.Collections.Generic.List<int> __result)
    {
        if (__instance != null && __result != null && TestElement.BreakChoiceFlag && 
            !string.IsNullOrEmpty(TestElement.BreakChoiceListStr))
        {
            var list = new List<int>(
                TestElement.BreakChoiceListStr
                    .Split(new[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries) // 过滤空字符串
                    .Select(s => int.TryParse(s.Trim(), out int val) ? val : (int?)null) // 去空格 + 安全解析
                    .Where(val => val.HasValue) // 只保留解析成功的值
                    .Select(val => val.Value)
            );
            __result.Clear();
            list.ForEach(__result.Add);
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BreakThroughChoiceController), nameof(BreakThroughChoiceController.OnClick))]
    public static bool BreakThroughChoiceController_OnClick_Postfix(BreakThroughChoiceController __instance)
    {
        if (__instance != null)
        {
            var heroSpeAddData = __instance.extraAddData.heroSpeAddData;
            
            if (TestElement.BreakFlag1)
            {
                heroSpeAddData.Clear();
                heroSpeAddData[int.Parse(TestElement.BreakType)] = float.Parse(TestElement.BreakValue);
                TestElement.BreakFlag1 = false;
            }
        }
        return true;
    }
}

// 写书1天
public class BookWriterUIControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BookWriterUIController), nameof(BookWriterUIController.ShowBookWriterUI))]
    public static void BookWriterUIController_ShowBookWriterUI_Postfix(BookWriterUIController __instance)
    {
        if (__instance != null && Plugin.Instance._copyBookFlag.Value)
        {
            var list = __instance.targetBookWriterList;
            foreach (var bwd in list)
            {
                if (bwd != null && bwd.workPercent < 0.99)
                    bwd.workPercent = 0.99f;
            }
        }
    }
}

public class StudySkillPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyDodgeSkillController), nameof(StudyDodgeSkillController.FinishStudyDodgeSkill))]
    public static void StudyDodgeSkillController_FinishStudyDodgeSkill_Postfix(StudyDodgeSkillController __instance,
        StudySkillResult studyDodgeResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance._studyUniqeRate.Value;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyInternalSkillController), nameof(StudyInternalSkillController.FinishStudyInternalSkill))]
    public static void StudyInternalSkillController_FinishStudyInternalSkill_Postfix(StudyInternalSkillController __instance,
        StudyInternalResult studyInternalResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance._studyUniqeRate.Value;
        }
    }
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
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxFavor))]
    public static void HeroData_GetMaxFavor_Postfix(HeroData __instance, float maxFavor, 
        ref float __result)
    {
        if (__instance != null) 
            __result = Plugin.Instance.FavorMax.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeMoney))]
    public static bool HeroData_ChangeMoney_Prefix(HeroData __instance, ref int num, bool showInfo)
    {
        if (__instance != null && num > 0 && __instance.heroID == 0)
        {
            num *= Plugin.Instance.MoneyTimes.Value;
        }
        return true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetUpgradeForceLvNeedSkillNum))]
    public static void HeroData_GetUpgradeForceLvNeedSkillNum_Postfix(HeroData __instance, ref int __result)
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

        if (num > 0 && Plugin.Instance._favorTimes.Value > 1)
        {
            num *= Plugin.Instance._favorTimes.Value;
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
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxAttri))]
    public static void HeroData_GetMaxAttri_Postfix(HeroData __instance, int id, ref float __result)
    {
        if (__instance != null)
        {
            if (Plugin.Instance.MaxBreak.Value && __instance.heroID == 0)
            {
                __result = Plugin.Instance.MaxBreakValue.Value;
            }
            if (Plugin.Instance.NpcMaxBreak.Value && __instance.heroID != 0)
            {
                __result = Plugin.Instance.NpcMaxBreakValue.Value;
            }
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxFightSkill))]
    public static void HeroData_GetMaxFightSkill_Postfix(HeroData __instance, int id, ref float __result)
    {
        if (__instance != null)
        {
            if (Plugin.Instance.MaxBreak.Value && __instance.heroID == 0)
            {
                __result = Plugin.Instance.MaxBreakValue.Value;
            }
            if (Plugin.Instance.NpcMaxBreak.Value && __instance.heroID != 0)
            {
                __result = Plugin.Instance.NpcMaxBreakValue.Value;
            }
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxLivingSkill))]
    public static void HeroData_GetMaxLivingSkill_Postfix(HeroData __instance, int id, ref float __result)
    {
        if (__instance != null)
        {
            if (Plugin.Instance.MaxBreak.Value && __instance.heroID == 0)
            {
                __result = Plugin.Instance.MaxBreakValue.Value;
            }
            if (Plugin.Instance.NpcMaxBreak.Value && __instance.heroID != 0)
            {
                __result = Plugin.Instance.NpcMaxBreakValue.Value;
            }
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.RefreshMaxAttriAndSkill))]
    public static void HeroData_RefreshMaxAttriAndSkill_Postfix(HeroData __instance)
    {
        
        if (__instance != null)
        {
            bool isPlayerBreakEnabled = Plugin.Instance.MaxBreak.Value;
            bool isNpcBreakEnabled = Plugin.Instance.NpcMaxBreak.Value;
            float playerBreakValue = Plugin.Instance.MaxBreakValue.Value;
            float npcBreakValue = Plugin.Instance.NpcMaxBreakValue.Value;
            
            for (int i = 0; i < __instance.maxAttri.Count; i++)
            {
                if (isPlayerBreakEnabled && __instance.heroID == 0)
                {
                    __instance.maxAttri[i] = playerBreakValue;
                    __instance.maxFightSkill[i] = playerBreakValue;
                    __instance.maxLivingSkill[i] = playerBreakValue;
                }
                if (isNpcBreakEnabled && __instance.heroID != 0)
                {
                    __instance.maxAttri[i] = npcBreakValue;
                    __instance.maxFightSkill[i] = npcBreakValue;
                    __instance.maxLivingSkill[i] = npcBreakValue;
                }
            }
        }
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
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.GenerateAuctionItem))]
    public static bool PlotController_GenerateAuctionItem_Prefix(PlotController __instance,ItemListData targetItemList, 
        ref float shopLv, List<int> itemTypeLimit, ref int itemNum)
    {
        if (__instance != null)
        {
            if (shopLv < 1)
                shopLv = 1;
            shopLv *= Plugin.Instance._shopLvRate.Value;
            itemNum = Plugin.Instance._itemNum.Value;
        }
        return true;
    }
    
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
    public static void PlotController_GetStealNpcSkillSuccessRate_Postfix(PlotController __instance,
        ref float __result)
    {
        if (__instance != null && Plugin.Instance._stealRate.Value 
                               && __instance.targetInteractHero.heroID != 0)
        {
            __result = 1f;
        }
    }
    
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.GetStealNpcSuccessRate))]
    [HarmonyPostfix]
    public static void PlotController_GetStealNpcSuccessRate_Postfix(PlotController __instance,
        ref float __result)
    {
        if (__instance != null && Plugin.Instance._stealRate.Value 
                               && __instance.targetInteractHero.heroID != 0)
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
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.ForceTeachNPCSure))]
    public static void PlotController_ForceTeachNPCSure_Postfix(PlotController __instance, string skillIDParam)
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
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.ForceTeachNewSkillToNPCSure))]
    public static void PlotController_ForceTeachNewSkillToNPCSure_Postfix(PlotController __instance, string skillIDParam)
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
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.GetForceFavor))]
    public static void ForceData_GetForceFavor_Postfix(ForceData? __instance, int forceID)
    {
        if (__instance != null && Plugin.Instance._playerOutForceContribution.Value)
        {
            __instance.playerOutForceContribution = 9999;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.GetNowResearchTech))]
    public static void ForceData_GetNowResearchTech_Postfix(ForceData? __instance, ForceTechLvData __result)
    {
        if (__instance != null && __result != null && Plugin.Instance._reasearchFlag.Value)
        {
            __result.researchPercent = 1f;
        }
    }
    
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
    [HarmonyPatch(typeof(ItemIconController), nameof(ItemIconController.Update))]
    public static bool ItemIconController_Update_Prefix(ItemIconController __instance)
    {
        if (__instance != null && __instance.itemData.type == ItemType.Treasure 
                               && Plugin.Instance.JianBaoFlag.Value)
        {
            var list = __instance.itemData.treasureData.treasureLv;
            var list1 =  __instance.itemData.treasureData.playerGuessTreasureLv;
            for (int i = 0; i < 4; i++)
            {
                list1[i].Clear();
                list1[i].Add(list[i]);
            }
            // __instance.itemData.value = __instance.itemData.GetTreasureRealValue();
        }
        return true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ItemListData), nameof(ItemListData.GetItem), typeof(ItemData), typeof(bool))]
    public static void ItemListData_GetItem_Postfix(ItemListData? __instance, ItemData targetItem, bool showPopInfo = false)
    {
        if (__instance?.GetHero() != null && __instance.GetHero().heroID == 0)
        {
            __instance.weight *= Plugin.Instance._weightRatio.Value;

            if (targetItem.type == ItemType.Book && Plugin.Instance._redBook.Value)
            {
                targetItem = targetItem.SetBookData(targetItem.bookData.skillID, 5);
            }

            if (targetItem.type == ItemType.Material && TestElement.RedMaterial)
            {
                targetItem.itemLv = 5;
                targetItem.rareLv = 5;
                
                var inputBox = ParseInputBox(TestElement.MaterialAttr);
                if (inputBox == null)
                    return;
                var il2CppDictionary = ToIl2CppDictionary(inputBox);
                if (il2CppDictionary == null)
                    return;
                targetItem.materialData.extraAddData.heroSpeAddData = il2CppDictionary; 
            }
               
            if (targetItem.type == ItemType.Treasure && Plugin.Instance._redTreasure.Value)
            {
                var list = targetItem.treasureData.treasureLv;
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = 5;
                }
                targetItem.itemLv = 5;
                targetItem.rareLv = 5;
                targetItem.value = targetItem.GetTreasureRealValue();
            }
        }
    }
    
    // 输入框文本转字典
    private static Dictionary<int, float>? ParseInputBox(string inputText)
    {
        if (string.IsNullOrWhiteSpace(inputText)) 
            return null;

        return inputText
            // 先替换所有空格
            .Replace(" ", "")
            // 按分号分割键值对
            .Split(';', StringSplitOptions.RemoveEmptyEntries)
            // 按等号分割key/value
            .Select(pair => pair.Split('='))
            // 过滤无效格式（必须是key=value）
            .Where(kv => kv.Length == 2)
            // 安全转换类型（避免输错数字导致崩溃）
            .Where(kv => int.TryParse(kv[0], out _) && float.TryParse(kv[1], out _))
            // 转字典
            .ToDictionary(
                kv => int.Parse(kv[0]),
                kv => float.Parse(kv[1])
            );
    }
    private static Il2CppSystem.Collections.Generic.Dictionary<int, float>? ToIl2CppDictionary(Dictionary<int, float>? systemDict)
    {
        // 初始化 IL2CPP 字典
        var il2CPPDict = new Il2CppSystem.Collections.Generic.Dictionary<int, float>();

        // 空值判断，避免崩溃
        if (systemDict == null || systemDict.Count == 0)
        {
           return null;
        }

        // 遍历原生字典，逐个添加到 IL2CPP 字典
        foreach (var kvp in systemDict)
        {
            // 避免重复key（IL2CPP字典添加重复key会抛异常）
            if (!il2CPPDict.ContainsKey(kvp.Key))
            {
                il2CPPDict.Add(kvp.Key, kvp.Value);
            }
        }

        return il2CPPDict;
    }
}

public class BreakThroughControllerPatches
{
    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.GetScoreRate))]
    [HarmonyPostfix]
    public static void BreakThroughController_GetScoreRate_Postfix(BreakThroughController __instance,
        ref float __result)
    {
        if (__instance != null)
        {
            __result *= Plugin.Instance._redBreak.Value;
        }
    }
}

