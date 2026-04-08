using System.Text;
using UnityEngine;
using Object = Il2CppSystem.Object;
using HarmonyLib;
using Il2Cpp;
using LYMod.Helpers;

namespace LYMod;


public class GameDataControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameDataController), nameof(GameDataController.GetExternalStorageMaxValue))]
    public static void GetExternalStorageMaxValue_Postfix(GameDataController __instance, ref int __result)
    {
        if (__instance == null || !Plugin.Instance.ExternalStorageFlag.Value) return;
        __result = 100000000;
    }
}

public class TimeDataPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameController), nameof(GameController.ChangeDay), new Type[0])]
    public static bool ChangeDay_Prefix()
    {
        return !Plugin.Instance.TimeFreezeFlag.Value;
    }
}

public class PoisonPatches
{
    private static readonly Dictionary<string, float> _poisonValuesBeforeBattle = new();
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CraftPoisonUIController), nameof(CraftPoisonUIController.GetCostTime))]
    public static void CraftPoisonUIController_GetCostTime_Postfix(CraftPoisonUIController __instance, ref int __result)
    {
        if (__instance != null)
            __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CraftPoisonUIController), nameof(CraftPoisonUIController.GetChangePoisonNum))]
    public static void GetChangePoisonNum_Postfix(ref float __result)
    {
        if (Plugin.Instance.PoisonRate.Value > 1)
        {
            __result *= Plugin.Instance.PoisonRate.Value;
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleController), nameof(BattleController.StartBattleButtonClicked))]
    public static void StartBattleButtonClicked_Prefix(BattleController __instance)
    {
        if (!Plugin.Instance.PoisonNumReduceFlag.Value) return;
        _poisonValuesBeforeBattle.Clear();
        var gc = GameController.Instance;
        if (gc == null) return;
        var player = gc.worldData.Player();
        var items = player.itemListData.allItem;
        if (items == null || items.Count == 0) return;
        foreach (var item in items)
        {
            if (item.Equiped() && item.equipmentData?.equipPoisonData is { poisonNum: > 0 })
            {
                _poisonValuesBeforeBattle[item.name] = item.equipmentData.equipPoisonData.poisonNum;
                Plugin.LOG.Msg($"[Poison] Before Battle - Item: {item.name}, poisonNum: {item.equipmentData.equipPoisonData.poisonNum}");
            }
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleController), nameof(BattleController.BattleRealEnd))]
    public static void BattleRealEnd_Postfix(BattleController __instance)
    {
        if (__instance == null || !Plugin.Instance.PoisonNumReduceFlag.Value) return;
        var gc = GameController.Instance;
        if (gc == null) return;
        var player = gc.worldData.Player();
        var items = player.itemListData.allItem;
        if (items == null || items.Count == 0) return;
        foreach (var item in items)
        {
            if (item.Equiped() && item.equipmentData?.equipPoisonData != null)
            {
                var beforeValue = _poisonValuesBeforeBattle.GetValueOrDefault(item.name, 0);
                var afterValue = item.equipmentData.equipPoisonData.poisonNum;
                var diff = afterValue - beforeValue;
                //Plugin.LOG.Msg($"[Poison] After Battle - Item: {item.name}, Before: {beforeValue}, After: {afterValue}, Diff: {diff}");
                if (beforeValue > 0 && diff < 0)
                {
                    item.equipmentData.equipPoisonData.poisonNum = beforeValue;
                }
            }
        }
    }
}

public class MeditationDataPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MeditationData), nameof(MeditationData.ChangeExp))]
    public static bool MeditationData_ChangeExp_Prefix(MeditationData __instance, ref float _exp, bool showInfo)
    {
        if (__instance != null && Plugin.Instance.ChanDaoRate.Value > 1)
        {
            _exp *= Plugin.Instance.ChanDaoRate.Value;
        }

        return true;
    }
}

#region 抄书和默写获得结果逻辑修改

public class BookWriterDataPatches
{
    private const int TAG_LIAN_WU = 220;
    private const int TAG_WU_CHI = 221;
    private const int TAG_WU_XUE_TIAN_CAI = 222;
    private const int TAG_YI_CHENG_BAI_JIA = 81;
    private const int TAG_WU_XUE_ZONG_SHI = 82;
    private const int TAG_DENG_FENG_ZAO_JI = 83;

    private static float GetTalentBonus(HeroData hero)
    {
        float bonus = 0f;
        
        if (hero.HaveTag(TAG_WU_XUE_TIAN_CAI))
        {
            bonus += 0.3f;
        }
        else if (hero.HaveTag(TAG_WU_CHI))
        {
            bonus += 0.2f;
        }
        else if (hero.HaveTag(TAG_LIAN_WU))
        {
            bonus += 0.1f;
        }
        
        if (hero.HaveTag(TAG_YI_CHENG_BAI_JIA))
        {
            bonus += 0.1f;
        }
        if (hero.HaveTag(TAG_WU_XUE_ZONG_SHI))
        {
            bonus += 0.1f;
        }
        if (hero.HaveTag(TAG_DENG_FENG_ZAO_JI))
        {
            bonus += 0.1f;
        }
        
        return bonus;
    }

    private static int GetMaxAllowedLvBySkillRare(int skillRareLv)
    {
        return skillRareLv switch
        {
            0 => 5,
            1 => 4,
            2 => 3,
            3 => 2,
            4 => 1,
            5 => 0,
            _ => 5
        };
    }

    private static int GetCompleteLvByScore(float score, int maxAllowedLv, int originalRareLv)
    {
        int[] thresholds = { 0, 60, 120, 180, 240, 300 };
        
        int targetLv = 0;
        for (int i = thresholds.Length - 1; i >= 0; i--)
        {
            if (score >= thresholds[i])
            {
                targetLv = i;
                break;
            }
        }
        
        targetLv = Math.Min(targetLv, maxAllowedLv);
        targetLv = Math.Min(targetLv, originalRareLv);
        targetLv = Math.Min(targetLv, 4);
        
        return targetLv;
    }

    private static float CalculateCopyScore(HeroData hero, int skillType, int skillRareLv)
    {
        float zhiLi = hero.baseAttri[2];
        float xueShi = hero.totalLivingSkill[2];
        float fightSkill = hero.baseFightSkill[skillType];
        
        float baseScore = zhiLi + xueShi + fightSkill;
        
        float talentBonus = GetTalentBonus(hero);
        float bonusScore = baseScore * talentBonus;
        
        float totalScore = baseScore + bonusScore;
        
        return totalScore;
    }

    private static int GetSkillTypeFromBook(ItemData book)
    {
        if (book?.bookData?.skillID == null) return 0;
        var kungfuSkillLvData = new KungfuSkillLvData(book.bookData.skillID);
        return kungfuSkillLvData.Type();
    }

    private static int GetSkillRareLvFromBook(ItemData book)
    {
        if (book?.bookData?.skillID == null) return 0;
        var kungfuSkillLvData = new KungfuSkillLvData(book.bookData.skillID);
        var skillData = kungfuSkillLvData.DataBase();
        return skillData?.rareLv ?? 0;
    }

    private static readonly string[] RareLvNames = { "残本", "仿本", "善本", "古本", "珍本", "完本" };

    private static int DetermineCopyResult(HeroData hero, ItemData originalBook)
    {
        int skillType = GetSkillTypeFromBook(originalBook);
        int skillRareLv = GetSkillRareLvFromBook(originalBook);
        int originalRareLv = originalBook.rareLv;
        
        float score = CalculateCopyScore(hero, skillType, skillRareLv);
        
        int maxAllowedLv = GetMaxAllowedLvBySkillRare(skillRareLv);
        
        int resultLv = GetCompleteLvByScore(score, maxAllowedLv, originalRareLv);
        
        Plugin.LOG.Msg($"[梯度抄书] 技能类型:{skillType}, 技能稀有度:{skillRareLv}, 原书完整度:{originalRareLv}, 得分:{score}, 最大允许:{maxAllowedLv}, 结果:{resultLv}");
        
        if (resultLv < originalRareLv)
        {
            string reason = "";
            if (resultLv < maxAllowedLv)
            {
                reason = $"属性不足(得分:{score:F0}/需要:{(resultLv + 1) * 60})";
            }
            else
            {
                reason = $"技能稀有度限制(最大:{RareLvNames[maxAllowedLv]})";
            }
            OtherHelper.AddInfoTab($"<color=#FF8C06>[梯度抄书]</color> 完整度降低: {RareLvNames[originalRareLv]} → {RareLvNames[resultLv]}\n原因: {reason}", "UIAtlas", "书本", "Fail", 1f, 5f);
        }
        
        return resultLv;
    }

    private static int DetermineMemoryResult(HeroData hero, KungfuSkillLvData ksld)
    {
        var learnedSkill = hero.FindSkill(ksld.skillID);
        int skillLv = learnedSkill?.lv ?? 0;
        int originalRareLv = ksld.DataBase().rareLv;
        int skillType = ksld.Type();
        
        float zhiLi = hero.baseAttri[2];
        float xueShi = hero.totalLivingSkill[2];
        float fightSkill = hero.totalFightSkill[skillType];
        
        float baseScore = zhiLi + xueShi + fightSkill;
        float talentBonus = GetTalentBonus(hero);
        float bonusScore = baseScore * talentBonus;
        float totalScore = baseScore + bonusScore + skillLv;
        
        int[] thresholds = { 0, 60, 120, 180, 240, 300 };
        int targetLv = 0;
        for (int i = thresholds.Length - 1; i >= 0; i--)
        {
            if (totalScore >= thresholds[i])
            {
                targetLv = i;
                break;
            }
        }
        
        targetLv = Math.Min(targetLv, originalRareLv);
        
        if (skillLv >= 10)
        {
            targetLv = Math.Min(targetLv, 5);
        }
        else
        {
            targetLv = Math.Min(targetLv, 4);
        }
        
        Plugin.LOG.Msg($"[梯度默写] 技能等级:{skillLv}, 技能类型:{skillType}, 得分:{totalScore}, 原书完整度:{originalRareLv}, 结果:{targetLv}");
        
        if (targetLv < originalRareLv)
        {
            string reason = "";
            if (skillLv < 10 && targetLv >= 4)
            {
                reason = $"技能等级不足(当前:{skillLv}/需要:10级才能出完本)";
            }
            else
            {
                reason = $"属性不足(得分:{totalScore:F0}/需要:{(targetLv + 1) * 60})";
            }
            OtherHelper.AddInfoTab($"<color=#9A7CFF>[梯度默写]</color> 完整度降低: {RareLvNames[originalRareLv]} → {RareLvNames[targetLv]}\n原因: {reason}", "UIAtlas", "书本", "Fail", 1f, 5f);
        }
        
        return targetLv;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BookWriterData), nameof(BookWriterData.GetWorkResult))]
    public static void BookWriterData_GetWorkResult_Postfix(BookWriterData __instance, ItemData __result)
    {
        if (__instance == null || __result == null || !Plugin.Instance.BookWriteChangeFlag.Value) return;
        
        var flag = HeroHelper.TryGetHeroByID(__instance.bookWriterHeroID, out var heroData);
        if (!flag) return;
        switch (__instance.bookWriterType)
        {
            case BookWriterType.Copy:
            {
                var targetBook = __instance.targetBookData;
                if (targetBook == null) return;
                __result.rareLv = DetermineCopyResult(heroData, __instance.targetBookData);
                break;
            }
            case BookWriterType.Memory:
            {
                var targetSkillData = __instance.targetSkillData;
                __result.rareLv = DetermineMemoryResult(heroData, targetSkillData);
                break;
            }
        }
    }
}


#endregion

public class ChooseControllerPatches
{
    private static readonly string[] RareColors = { "#00B400", "#78BE00", "#0080FF", "#9A7CFF", "#FF8C06", "#FF0000" };
    private static HeroData? targetHero;
    private static string ColorizeSkillName(string skillName, int rareLv)
    {
        if (rareLv < 0) rareLv = 0;
        if (rareLv > 5) rareLv = 5;
        var color = RareColors[rareLv];
        return $"<color={color}>{skillName}</color>";
    }
    // 金龙生刷新购买情报
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroIconController), nameof(HeroIconController.OnClick))]
    public static void HeroIconController_OnClick_Postfix(HeroIconController __instance)
    {
        if (__instance != null && Plugin.Instance.Interaction.Value)
        {
            var hero = __instance.heroData;
            if (hero != null)
            {
                GameController.Instance.worldData.monthBuyAreaInfoTime = 0;
                targetHero = hero;
            }
        }
    }
    // 无限交互判断
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.CheckMeetRequire))]
    public static void PlotController_CheckMeetRequire_Postfix(PlotController __instance,
        ChoiceRequirementType requireType, float requireNum, bool includeTeamMate = true)
    {
        if (__instance != null && Plugin.Instance.Interaction.Value)
        {
            var hero = __instance.targetInteractHero;
            if (hero != null)
            {
                hero.playerInteractionTimeData.ResetTime();
            }
        }
    }

    #region 任意传授
    // 临时存储交互英雄身份等级
    private static int tempForceLv = -1;
    /// <summary>
    /// 拦截传授技能选择，绕过稀有度限制直接传授给NPC
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNewSkillToNPCChoosen))]
    public static bool PlotController_TeachNewSkillToNPCChoosen_Prefix(PlotController __instance)
    {
        if (__instance != null && Plugin.Instance.TeachAnyNewSkill.Value)
        {
            var targetHero = __instance.targetInteractHero;
            
            if (targetHero == null) return true;
            
            var chooseController = ChooseController.Instance;
            if (chooseController == null) return true;
            
            var chooseResult = chooseController.chooseResult;
            if (chooseResult == null) return true;
            
            var skillIcon = chooseResult.GetComponent<SkillIconController>();
            if (skillIcon == null) return true;
            
            var selectedSkill = skillIcon.skillLvData;
            if (selectedSkill == null) return true;
            
            if (targetHero.FindSkill(selectedSkill.skillID) != null) return false;
            
            var npcSkills = targetHero.kungfuSkills;
            if (npcSkills == null) return false;
            
            var newSkill = new KungfuSkillLvData(selectedSkill.skillID);
            npcSkills.Add(newSkill);
            
            var infoController = InfoController.Instance;
            if (infoController != null)
            {
                string coloredName = ColorizeSkillName(newSkill.Name(false), newSkill.DataBase()?.rareLv ?? 0);
                string infoText = $"{targetHero.heroName}学会了{coloredName}";
                infoController.AddInfoTab(infoText,"IconAtlas",newSkill.GetSkillIcon(),"OpenBook");
                string favorText = $"{targetHero.heroName}对你的<color=#00B400>好感+20</color>(200%)";
                infoController.AddInfoTab(favorText,"UIAtlas","友善度","Success",1,5f,
                    new Color(0f, 0.8f, 0f, 1f));
            }

            if (Plugin.Instance.TeachNewSkillToNpc.Value)
            {
                var skill = targetHero.FindSkill(newSkill.skillID);
                for (int i = 0; i < 10; i++)
                {
                    targetHero.UpgradeSkill(skill);
                }
            }
            targetHero.heroForceLv = tempForceLv;
            tempForceLv = -1;
            return false;
        }

        return true;
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNewSkillToNPC))]
    public static void TeachNewSkillToNPC_Prefix(PlotController __instance)
    {
        if (__instance == null || !Plugin.Instance.TeachAnyNewSkill.Value) return;
        var targetHero = __instance.targetInteractHero;
        if (targetHero == null) return;
        tempForceLv = targetHero.heroForceLv;
        targetHero.heroForceLv = 5;
    }

    /// <summary>
    /// 在技能选择面板显示后，添加被过滤掉技能
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ChooseController), nameof(ChooseController.ShowChoosePanel),
        typeof(ChooseType),
        typeof(Il2CppSystem.Collections.Generic.List<Object>),
        typeof(GameObject), typeof(string), typeof(string),
        typeof(ChooseFilterType), typeof(HeroData), typeof(string))]
    public static void ChooseController_ShowChoosePanel_Postfix(
        ChooseController __instance, ChooseType _chooseType, Il2CppSystem.Collections.Generic.List<Object> param,
        GameObject _sendResultFucTarget, string _sendResultFuc, string _sendResultParam, ChooseFilterType _filterType,
        HeroData targetFavorHero, string _cancelFuc)
    {
        if (_sendResultFuc == "SpeRemoveSkillChoosen" && Plugin.Instance.RemoveAnySkill.Value)
        {
            var player = GameDataController.Instance?.gameSaveData?.WorldData?.Player();
            if (player == null || player.kungfuSkills == null) return;

            var content = __instance.choosePanel?.transform?.Find("ChoosePanelRoot/ChooseItemList/Viewport/Content");
            if (content == null) return;

            var newObj = __instance.newObj;
            if (newObj == null)
            {
                newObj = GameObjectController.Instance?.skillIconPrefab;
            }
            if (newObj == null) return;

            var existingSkillIds = new HashSet<int>();
            for (var i = 0; i < content.childCount; i++)
            {
                var child = content.GetChild(i);
                if (child != null && child.gameObject != null && child.gameObject.activeSelf)
                {
                    var skillIcon = child.GetComponent<SkillIconController>();
                    if (skillIcon?.skillLvData != null) existingSkillIds.Add(skillIcon.skillLvData.skillID);
                }
            }

            foreach (var skill in player.kungfuSkills)
            {
                if (skill == null || existingSkillIds.Contains(skill.skillID)) continue;

                var skillData = skill.DataBase();
                if (skillData == null) continue;

                var newSkillObj = UnityEngine.Object.Instantiate(newObj.gameObject, content);
                if (newSkillObj == null) continue;

                newSkillObj.SetActive(true);
                var newSkillIcon = newSkillObj.GetComponent<SkillIconController>();
                if (newSkillIcon != null)
                {
                    newSkillIcon.skillLvData = skill;
                    newSkillIcon.skillListID = skill.skillID;
                    newSkillIcon.skillIconType = SkillIconType.Choose;
                }
            }
        }
        
        if (_filterType == ChooseFilterType.TeachNpcNewSkill && Plugin.Instance.TeachAnyNewSkill.Value)
        {
            var player = GameDataController.Instance?.gameSaveData?.WorldData?.Player();
            if (player == null || player.kungfuSkills == null) return;
            
            var content = __instance.choosePanel?.transform?.Find("ChoosePanelRoot/ChooseItemList/Viewport/Content");
            if (content == null) return;
            
            var newObj = __instance.newObj;
            if (newObj == null)
            {
                newObj = GameObjectController.Instance?.skillIconPrefab;
            }
            if (newObj == null) return;
            
            var existingSkillIds = new System.Collections.Generic.HashSet<int>();
            for (int i = 0; i < content.childCount; i++)
            {
                var child = content.GetChild(i);
                if (child != null && child.gameObject != null && child.gameObject.activeSelf)
                {
                    var skillIcon = child.GetComponent<SkillIconController>();
                    if (skillIcon?.skillLvData != null)
                    {
                        existingSkillIds.Add(skillIcon.skillLvData.skillID);
                    }
                }
            }
            var npcExistingSkillIds = new System.Collections.Generic.HashSet<int>();
            if (targetHero is { kungfuSkills: not null })
            {
                foreach (var skill in targetHero.kungfuSkills)
                {
                    if (skill != null)
                    {
                       npcExistingSkillIds.Add(skill.skillID);
                    }
                }
            }
            
            foreach (var skill in player.kungfuSkills)
            {
                if (skill == null || existingSkillIds.Contains(skill.skillID)) continue;
                if (npcExistingSkillIds.Contains(skill.skillID)) continue;
            
                var skillData = skill.DataBase();
                if (skillData == null) continue;
            
                var newSkillObj = UnityEngine.Object.Instantiate(newObj.gameObject, content);
                if (newSkillObj == null) continue;
            
                newSkillObj.SetActive(true);
                var newSkillIcon = newSkillObj.GetComponent<SkillIconController>();
                if (newSkillIcon != null)
                {
                    newSkillIcon.skillLvData = skill;
                    newSkillIcon.skillListID = skill.skillID;
                    newSkillIcon.skillIconType = SkillIconType.Choose;
                }
            }
        }
    }
    #endregion
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BuildingUIController), nameof(BuildingUIController.GetSpeRemoveSkillCost))]
    public static void GetSpeRemoveSkillCost_Postfix(BuildingUIController __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance.RemoveAnySkill.Value)
        {
            __result = 1;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroTagDataBase), nameof(HeroTagDataBase.GetCostTime))]
    public static void GetCostTime_Postfix(HeroTagDataBase __instance, ref int __result)
    {
        if (__instance != null && Plugin.Instance.RemoveAnySkill.Value)
        {
            __result = 1;
        }
    }
}
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
             if (il2CppArrayBase is { Length: > 0 })
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



public class LivingSkillPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeLivingSkillExp))]
    public static bool HeroData_ChangeLivingSkillExp_Prefix(HeroData __instance, int id,
        ref float num, bool showText)
    {
        if (__instance != null && num > 0 && Plugin.Instance.LivingSkillExpRate.Value > 1)
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
        if (__instance != null && num > 0 && Plugin.Instance.MaxLivingSkillExpTimes.Value > 1)
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
        if (__instance != null && Plugin.Instance.AnyTagFlag.Value)
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
        if (__instance != null && Plugin.Instance.AnyTagFlag.Value)
        {
            __result = true;
        }
    }
}

public class AreaBuildingDataPatches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetBuildingSpeAddData))]
    public static void GetBuildingSpeAddData_Postfix(AreaBuildingData __instance, ref ForceSpeAddData __result)
    {
        if (__instance == null || Plugin.Instance.BuildingSpeTimes.Value == 1) return;
        var db = __instance.DataBase();
        if (db == null) return;
        
        var area = __instance.GetArea();
        var flag = HeroHelper.TryReadPlayer(out var player);
        if (area == null || !flag || area.belongForceID != player.belongForceID) return;
        
        if (UIBuilderExtensions.EnabledBuildingIDs.Contains(__instance.buildingID))
        {
            var dict = db.GetBuildingSpeAddData(__instance.lv).forceSpeAddData;
            foreach (var ky in dict)
            {
                __result.Set(ky.Key, __result.Get(ky.Key) * Plugin.Instance.BuildingSpeTimes.Value);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetTotalChangeResource))]
    public static void GetTotalChangeResource_Postfix(AreaBuildingData __instance, 
        Il2CppSystem.Collections.Generic.List<float> __result)
    {
        if (__instance == null || Plugin.Instance.BuildingSpeTimes.Value == 1) return;
        if (UIBuilderExtensions.EnabledBuildingIDs.Contains(__instance.buildingID))
        {
            for (int i = 0; i < __result.Count; i++)
            {
                if (__result[i] > 0)
                {
                    __result[i] *= Plugin.Instance.BuildingSpeTimes.Value;
                }
            }
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameDataController), nameof(GameDataController.GameDataIntoGame))]
    public static bool GameDataController_GameDataIntoGame_Prefix(GameDataController __instance)
    {
        if (__instance == null || !Plugin.Instance.UpgradeDay1.Value) return true;
        var list = __instance.buildingDataBase;
        foreach (var b in list)
        {
            b.buildCostTime = 2f;
        }
        
        return true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaRoadData), nameof(AreaRoadData.GetUpgradeTime))]
    public static void AreaRoadData_GetUpgradeTime_Postfix(AreaRoadData? __instance, ref int __result)
    {
        if (__instance == null || !Plugin.Instance.UpgradeDay1.Value) return;
        __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetUpgradeTime))]
    public static void AreaBuildingData_GetUpgradeTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance == null || !Plugin.Instance.UpgradeDay1.Value) return;
        __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetMoveTime))]
    public static void AreaBuildingData_GetMoveTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance == null || !Plugin.Instance.UpgradeDay1.Value) return;
        __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildingData), nameof(AreaBuildingData.GetDestroyTime))]
    public static void AreaBuildingData_GetDestroyTime_Postfix(AreaBuildingData? __instance, ref int __result)
    {
        if (__instance == null || !Plugin.Instance.UpgradeDay1.Value) return;
        __result = 1;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AreaBuildController), nameof(AreaBuildController.BuildModeButtonClicked))]
    public static void AreaBuildController_BuildModeButtonClicked_Postfix(
        AreaBuildController __instance)
    {
        if (__instance == null || Plugin.Instance.MaxSpeBuildingNum.Value == 5) return;
        AreaBuildController.MaxSpeBuildingNum = Plugin.Instance.MaxSpeBuildingNum.Value;
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
        if (__instance != null && __result != null && Plugin.Instance.BreakChoiceFlag && 
            !string.IsNullOrEmpty(Plugin.Instance.BreakChoiceListStr))
        {
            var list = new List<int>(
                Plugin.Instance.BreakChoiceListStr
                    .Split(new[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries) // 过滤空字符串
                    .Select(s => int.TryParse(s.Trim(), out int val) ? val : (int?)null) // 去空格 + 安全解析
                    .Where(val => val.HasValue) // 只保留解析成功的值
                    .Select(val => val.Value)
            );
            __result.Clear();
            list.ForEach(__result.Add);
            Plugin.Instance.BreakChoiceFlag = false;
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BreakThroughChoiceController), nameof(BreakThroughChoiceController.OnClick))]
    public static bool BreakThroughChoiceController_OnClick_Postfix(BreakThroughChoiceController __instance)
    {
        if (__instance != null)
        {
            var heroSpeAddData = __instance.extraAddData.heroSpeAddData;
            
            if (Plugin.Instance.BreakFlag)
            {
                heroSpeAddData.Clear();
                heroSpeAddData[int.Parse(Plugin.Instance.BreakType)] = float.Parse(Plugin.Instance.BreakValue);
                Plugin.Instance.BreakFlag = false;
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
        if (__instance != null && Plugin.Instance.CopyBookFlag.Value)
        {
            var list = __instance.targetBookWriterList;
            foreach (var bwd in list)
            {
                if (bwd != null && bwd.workPercent < 0.99)
                    bwd.workPercent = 0.99999f;
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
        if (__instance != null && Plugin.Instance.StudyUniqeRate.Value > 1)
        {
            __instance.totalExp *= Plugin.Instance.StudyUniqeRate.Value;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyInternalSkillController), nameof(StudyInternalSkillController.FinishStudyInternalSkill))]
    public static void StudyInternalSkillController_FinishStudyInternalSkill_Postfix(StudyInternalSkillController __instance,
        StudyInternalResult studyInternalResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance.StudyUniqeRate.Value;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyUniqueSkillController), nameof(StudyUniqueSkillController.FinishStudyUniqueSkill))]
    public static void StudyUniqueSkillController_FinishStudyUniqueSkill_Postfix(StudyUniqueSkillController __instance,
        StudySkillResult studyUniqueResult)
    {
        if (__instance != null)
        {
            __instance.totalExp *= Plugin.Instance.StudyUniqeRate.Value;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StudyAttackSkillController), nameof(StudyAttackSkillController.FinishStudyFightSkill))]
    public static void StudyAttackSkillController_FinishStudyFightSkill_Postfix(StudyAttackSkillController __instance,
        StudySkillResult studyDodgeResult)
    {
        if (__instance != null && Plugin.Instance.StudyFightRate.Value > 1)
        {
            __instance.totalExp *= Plugin.Instance.StudyFightRate.Value;
        }
    }
}


public class HeroDataPatch
{
    #region 新档相关
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartGameSettingController), nameof(StartGameSettingController.Update))]
    public static void StartGameSettingController_Update_Postfix(StartGameSettingController __instance)
    {
        if (__instance != null && Plugin.Instance.NewGameTagNumFlag.Value) __instance.Player.heroTagPoint = 999;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.CheckMeetCondition))]
    public static void StartMenuController_CheckMeetCondition_Postfix(StartMenuController __instance, HeroData checkHero, 
        HeroTagDataBase targetTag, ref bool __result)
    {
        if (__instance != null && Plugin.Instance.NewGameAnyTagFlag.Value)
        { 
            targetTag.oppositeMeaning = "";
            targetTag.sameMeaning = "";
            __result = true;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.CheckMeetOneCondition))]
    public static void StartMenuController_CheckMeetOneCondition_Postfix(StartMenuController __instance, HeroData checkHero, 
        string requirement, ref bool __result)
    {
        if (__instance != null && Plugin.Instance.NewGameAnyTagFlag.Value)
        { 
            __result = true;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroTagData), nameof(HeroTagData.StartChooseAble))]
    public static void HeroTagData_StartChooseAble_Postfix(ref bool __result)
    {
        if (Plugin.Instance.NewGameAnyTagFlag.Value)
        { 
            __result = true;
        }
    }
    #endregion
    
    # region 人物潜力限制开关

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeAttri))]
    public static void HeroData_ChangeAttri_Postfix(HeroData __instance, int id, float num, 
        bool showText, bool skillUpgrade)
    {
        if (__instance == null || !skillUpgrade || num <= 0 || __instance.heroID != 0 
            || !Plugin.Instance.BreakMaxLimitFlag.Value) return;
        
        var baseAttri = __instance.baseAttri;
        var maxAttri = __instance.maxAttri;
        if (baseAttri == null || maxAttri == null) return;
        if (id < 0 || id >= baseAttri.Count || id >= maxAttri.Count) return;
        
        var currentVal = baseAttri[id];
        var maxVal = maxAttri[id];
        if (currentVal > maxVal)
        {
            maxAttri[id] = currentVal;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeFightSkill))]
    public static void HeroData_ChangeFightSkill_Postfix(HeroData __instance, int id, float num, 
        bool showText, bool skillUpgrade)
    {
        if (__instance == null || !skillUpgrade || num <= 0 || __instance.heroID != 0
            || !Plugin.Instance.BreakMaxLimitFlag.Value) return;
        
        var baseFightSkill = __instance.baseFightSkill;
        var maxFightSkill = __instance.maxFightSkill;
        if (baseFightSkill == null || maxFightSkill == null) return;
        if (id < 0 || id >= baseFightSkill.Count || id >= maxFightSkill.Count) return;
        
        var currentVal = baseFightSkill[id];
        var maxVal = maxFightSkill[id];
        if (currentVal > maxVal)
        {
            maxFightSkill[id] = currentVal;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeLivingSkill))]
    public static void HeroData_ChangeLivingSkill_Postfix(HeroData __instance, int id, float num, 
        bool showText, bool skillUpgrade)
    {
        if (__instance == null || !skillUpgrade || num <= 0 || __instance.heroID != 0
            || !Plugin.Instance.BreakMaxLimitFlag.Value) return;
        
        var baseLivingSkill = __instance.baseLivingSkill;
        var maxLivingSkill = __instance.maxLivingSkill;
        if (baseLivingSkill == null || maxLivingSkill == null) return;
        if (id < 0 || id >= baseLivingSkill.Count || id >= maxLivingSkill.Count) return;
        
        var currentVal = baseLivingSkill[id];
        var maxVal = maxLivingSkill[id];
        if (currentVal > maxVal)
        {
            maxLivingSkill[id] = currentVal;
        }
    }
    
    
    #endregion
    
    
    /// <summary>
    /// 游戏难度倍率默认最高难度1.6
    /// </summary>
    /// <param name="__instance"></param>
    /// <param name="__result"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetGameDifficultyExpRate))]
    public static void Postfix(HeroData __instance, ref float __result)
    {
        if (__instance == null) return;
        if (Mathf.Approximately(Plugin.Instance.ExpRateMultiplier.Value, 1)) return;
        __result = Plugin.Instance.ExpRateMultiplier.Value;
    }
    /// <summary>
    /// 门派功绩倍率
    /// </summary>
    /// <param name="__instance"></param>
    /// <param name="num"></param>
    /// <param name="showInfo"></param>
    /// <param name="targetForce"></param>
    /// <returns></returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeForceContribution))]
    public static bool HeroData_ChangeForceContribution_Prefix(HeroData __instance, ref float num, 
        bool showInfo, int targetForce = -1)
    {
        if (__instance == null) return true;
        var gc = GameController.Instance;
        if (gc == null) return true;
        var forceId = gc.worldData.Player()?.belongForceID ?? -1;
        if (forceId == -1) return true;
        if (forceId != targetForce && Plugin.Instance.ForceContributionRate.Value > 1 && num > 0)
        {
            num *= Plugin.Instance.ForceContributionRate.Value;
        }
        return true;
    }
    
    // 所有门派特性生效
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.HaveForceFunction))]
    public static void HeroData_HaveForceFunction_Postfix(HeroData __instance,int forceID, ref bool __result)
    {
        if (__instance is { heroID: 0 })
        {
            if (UIBuilderExtensions.EnabledForceIDs.Count == 0)
            {
                UIBuilderExtensions.RefreshForceList();
            }
            if (UIBuilderExtensions.EnabledForceIDs.Contains(forceID)) 
                __result = true;
        }
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.BattleChangeSkillFightExp))]
    public static bool HeroData_BattleChangeSkillFightExp_Prefix(HeroData __instance, ref float num, 
        KungfuSkillLvData targetSkill, bool showInfo)
    {
        if (__instance is { heroID: 0 } && Plugin.Instance.BattleChangeSkillFightRate.Value > 1)
        {
            num *= Plugin.Instance.BattleChangeSkillFightRate.Value;
        }
        
        return true;
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetMaxFavor))]
    public static void HeroData_GetMaxFavor_Postfix(HeroData __instance, float maxFavor, 
        ref float __result)
    {
        if (__instance != null && Mathf.Approximately(__result, 100) && Plugin.Instance.FavorMax.Value > 100) 
            __result = Plugin.Instance.FavorMax.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.ChangeMoney))]
    public static bool HeroData_ChangeMoney_Prefix(HeroData __instance, ref int num, bool showInfo)
    {
        if (__instance != null && num > 0 && __instance.heroID == 0 && Plugin.Instance.MoneyTimes.Value > 1)
        {
            num *= Plugin.Instance.MoneyTimes.Value;
        }
        return true;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.EquipItem))]
    public static bool HeroData_EquipItem_Prefix(ItemData itemData, bool playSound = false, bool showInfo = false)
    {
        if (Plugin.Instance.EquipmentWeight.Value < 1)
            itemData.weight *= Plugin.Instance.EquipmentWeight.Value;
        return true;
    }

    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), "ChangeFavor")]
    public static bool HeroData_ChangeFavor_Prefix(ref float num)
    {
        if (Plugin.Instance.Hgbj.Value && num < 0f)
        {
            num = 0f;
        }

        if (num > 0 && Plugin.Instance.FavorTimes.Value > 1)
        {
            num *= Plugin.Instance.FavorTimes.Value;
        }

        return true; 
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroData), "ChangeBadFame")]
    public static bool HeroData_ChangeBadFame_Prefix(ref float num)
    {
        if (Plugin.Instance.Hgbj.Value && num > 0f)
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
        if (Plugin.Instance.Pzqh.Value > 1)
            __result *= Plugin.Instance.Pzqh.Value;
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
            if (Plugin.Instance.ShopLvRate.Value > 1)
            {
                if (shopLv < 1)
                    shopLv = 1;
                shopLv *= Plugin.Instance.ShopLvRate.Value;
                
            }
            if (Plugin.Instance.ItemNum.Value > -1)
                itemNum = Plugin.Instance.ItemNum.Value;
        }
        return true;
    }
    
    
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.GetStealNpcSkillSuccessRate))]
    [HarmonyPostfix]
    public static void PlotController_GetStealNpcSkillSuccessRate_Postfix(PlotController __instance,
        ref float __result)
    {
        if (__instance != null && Plugin.Instance.StealRate.Value 
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
        if (__instance != null && Plugin.Instance.StealRate.Value 
                               && __instance.targetInteractHero.heroID != 0)
        {
            __result = 1f;
        }
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.TeachNewSkillToNPCSure))]
    public static void PlotController_TeachNewSkillToNPCSure_Postfix(PlotController __instance, string skillIDParam)
    {
        if (__instance != null && Plugin.Instance.TeachNewSkillToNpc.Value)
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
        if (__instance != null && Plugin.Instance.TeachNpc.Value)
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
        if (__instance != null && Plugin.Instance.TeachNpc.Value)
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
        if (__instance != null && Plugin.Instance.TeachNpc.Value)
        {
            var a = __instance.targetInteractHero;
            var b = a.FindSkill(int.Parse(skillIDParam));
            for (int i = 0; i < 10; i++)
            {
                a.UpgradeSkill(b);
            }
            if (Plugin.Instance.Interaction.Value) 
                a.playerInteractionTimeData.ResetTime();
        }
    }
}

public class ReadBookControllerPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ReadBookController), nameof(ReadBookController.FinishRead))]
    public static void ReadBookController_FinishRead_Prefix(ReadBookController __instance)
    {
        if (__instance != null && Plugin.Instance.ReadBook.Value > 1)
        {
            __instance.totalExp *= Plugin.Instance.ReadBook.Value;
        }
    }
}

public class ExploreControllerPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ExploreController), nameof(ExploreController.PlayerFinishMove))]
    public static void ExploreController_PlayerFinishMove_Postfix(ExploreController __instance)
    {
        if (__instance != null &&  Plugin.Instance.Explore.Value)
        {
            __instance.leftPower = 1000;
        }
    }
}

public class ForceDataPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.GetNowResearchTech))]
    public static void ForceData_GetNowResearchTech_Postfix(ForceData? __instance, ForceTechLvData? __result)
    {
        if (__instance != null && __result != null && Plugin.Instance.ReasearchFlag.Value)
        {
            var heroData = GameDataController.Instance.gameSaveData.WorldData.Player();
            if (__instance.forceID == heroData.GetForce()?.forceID)
            {
                __result.researchPercent = 1f;
            }
        }
    }
    
    // 0钱1粮2木3矿4药5威望
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource),
        typeof(Il2CppSystem.Collections.Generic.List<float>), typeof(bool))]
    public static bool ForceData_CostResource_Prefix(Il2CppSystem.Collections.Generic.List<float> resourceList,
        bool showInfo = false)
    {
        if (Plugin.Instance.Cost0.Value)
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
        if (Plugin.Instance.Cost0.Value)
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
        if (Plugin.Instance.Cost0.Value)
        {
            resource = new ResourceData(resource.resourceType, 0);
        }
        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceData), nameof(ForceData.CostResource), typeof(int), typeof(float), typeof(bool))]
    public static bool ForceData_CostResource_Prefix3(int id, ref float num, bool showInfo = false)
    {
        if (Plugin.Instance.Cost0.Value)
        {
            num = 0;
        }
        return true;
    }
    // 门派特性显示在门派总览的信息里
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceDetailController), nameof(ForceDetailController.ShowForceDetail))]
    public static void ShowForceDetail_Postfix(ForceDetailController __instance, int targetForceID)
    {
        var worldData = GameController.Instance?.worldData;
        if (worldData == null || __instance.baseDetailText == null) return;
        
        var playerForceID = GlobalData.PlayerForceID;
        var originalText = __instance.baseDetailText.text;
        
        if (worldData.gameMode == GameMode.Plot)
        {
            if (targetForceID == playerForceID)
            {
                var sb = new StringBuilder();
                foreach (var forceId in UIBuilderExtensions.EnabledForceIDs)
                {
                    var forceData = GetForceDataById(forceId);
                    if (forceData != null)
                    {
                        var speFunc = forceData.speFunctionDescribe;
                        if (!string.IsNullOrEmpty(speFunc))
                        {
                            sb.Append($"<color=#BE8100>{speFunc}</color>\n\n");
                        }
                    }
                }
                
                if (sb.Length > 0)
                {
                    __instance.baseDetailText.text = originalText + "\n\n<color=#BE8100><b>门派特性</b></color>\n" + sb.ToString();
                }
            }
            else
            {
                var forceData = GetForceDataById(targetForceID);
                if (forceData != null)
                {
                    var speFunc = forceData.speFunctionDescribe;
                    if (!string.IsNullOrEmpty(speFunc))
                    {
                        __instance.baseDetailText.text = originalText + "\n\n<color=#BE8100><b>门派特性</b>\n" + speFunc + "</color>";
                    }
                }
            }
        }
        else if (worldData.gameMode == GameMode.Free)
        {
            if (targetForceID != playerForceID) return;
            
            var featureIndex = originalText.IndexOf("<b>门派特性</b>");
            if (featureIndex < 0) return;
            
            var sb = new StringBuilder();
            foreach (var forceId in UIBuilderExtensions.EnabledForceIDs)
            {
                var forceData = GetForceDataById(forceId);
                if (forceData != null)
                {
                    var speFunc = forceData.speFunctionDescribe;
                    if (!string.IsNullOrEmpty(speFunc))
                    {
                        sb.Append($"<color=#BE8100>{speFunc}</color>\n\n");
                    }
                }
            }
            
            if (sb.Length > 0)
            {
                var newText = originalText.Substring(0, featureIndex) + "<color=#BE8100><b>门派特性</b></color>\n" + sb.ToString();
                __instance.baseDetailText.text = newText;
            }
        }
    }
    private static ForceData GetForceDataById(int forceId)
    {
        var worldData = GameController.Instance?.worldData;
        if (worldData == null || worldData.Forces == null) return null;
            
        foreach (var force in worldData.Forces)
        {
            if (force.forceID == forceId)
                return force;
        }
        return null;
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
        }
        return true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ItemListData), nameof(ItemListData.GetItem), typeof(ItemData), typeof(bool))]
    public static void ItemListData_GetItem_Postfix(ItemListData? __instance, ItemData targetItem, bool showPopInfo = false)
    {
        if (__instance?.GetHero() != null && __instance.GetHero().heroID == 0)
        {
            if (Plugin.Instance.WeightRatio.Value < 1)
                __instance.weight *= Plugin.Instance.WeightRatio.Value;

            // 所以是红品质
            if (Plugin.Instance.RedQuality.Value)
            {
                if (targetItem.type == ItemType.Book)
                {
                    targetItem = targetItem.SetBookData(targetItem.bookData.skillID, 5);
                }
                else if (targetItem.type == ItemType.Treasure)
                {
                    var list = targetItem.treasureData.treasureLv;
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = 5;
                    }
                }
                else
                {
                    targetItem.rareLv = 5;
                }
            }
            
            if (targetItem.type == ItemType.Book && Plugin.Instance.RedBook.Value)
            {
                targetItem = targetItem.SetBookData(targetItem.bookData.skillID, 5);
            }

            if (targetItem.type == ItemType.Material && Plugin.Instance.RedMaterial)
            {
                targetItem.itemLv = 5;
                targetItem.rareLv = 5;
                
                var inputBox = OtherHelper.ParseInputBox(Plugin.Instance.MaterialAttr);
                if (inputBox == null)
                    return;
                var il2CppDictionary = OtherHelper.ToIl2CppDictionary(inputBox);
                if (il2CppDictionary == null)
                    return;
                targetItem.materialData.extraAddData.heroSpeAddData = il2CppDictionary; 
            }
               
            if (targetItem.type == ItemType.Treasure)
            {
                if (Plugin.Instance.RedTreasure.Value)
                {
                    var list = targetItem.treasureData.treasureLv;
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = 5;
                    }
                    targetItem.itemLv = 5;
                    targetItem.value = targetItem.GetTreasureRealValue();
                    targetItem.rareLv = 5;
                }
                if (Plugin.Instance.GoodTreasure.Value)
                {
                    var list = targetItem.treasureData.treasureLv;
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = 5;
                    }
                }
                    
            }
        }
    }
    
   
}

public class BreakThroughControllerPatches
{
    [HarmonyPatch(typeof(BreakThroughController), nameof(BreakThroughController.GetScoreRate))]
    [HarmonyPostfix]
    public static void BreakThroughController_GetScoreRate_Postfix(BreakThroughController __instance,
        ref float __result)
    {
        if (__instance != null && Plugin.Instance.RedBreak.Value > 1)
        {
            __result *= Plugin.Instance.RedBreak.Value;
        }
    }
}

