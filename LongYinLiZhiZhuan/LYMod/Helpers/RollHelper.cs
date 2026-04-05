using Il2Cpp;
using Object = UnityEngine.Object;

namespace LYMod.Helpers;

public class RollHelper
{
    public static bool IsHaveAucRoll = true; 
    public static bool IsRecruitReRoll = true;
    // 拍卖会Roll
    public static void TryAuctionRoll()
    {
        if (!IsHaveAucRoll) return;
        var auc = AuctionController.Instance;
        var plot = PlotController.Instance;
        if (auc != null && plot != null && auc.auctionPanel.activeInHierarchy)
        {
            foreach (var gm in auc.auctionItemIconList)
                if (gm != null)
                    Object.Destroy(gm);
            auc.auctionItemIconList.Clear();

            foreach (var gm in auc.heroIconList)
                if (gm != null)
                    Object.Destroy(gm);
            auc.heroIconList.Clear();

            var itemListData = new ItemListData();
            plot.GenerateAuctionItem(itemListData, auc.auctionDifficulty);
            auc.RestartAuction(auc.heroList, itemListData, auc.playerSellItem,
                auc.endMatchCallPlot, auc.auctionDifficulty, auc.havePlayer, auc.auctionKeeper);
        }
    }

    // 突破roll
    public static void TryBreakThoughtRoll()
    {
        var btc = BreakThroughController.Instance;
        if (btc != null && btc.breakThroughPanel != null && btc.breakThroughPanel.activeInHierarchy
            && btc.breakThroughPos != null && btc.breakThroughPos.transform.childCount > 0)
        {
            var componentsInChildren = btc.breakThroughPos
                .GetComponentsInChildren<BreakThroughChoiceController>();
            foreach (var btcc in componentsInChildren)
                if (btcc != null && btcc.gameObject != null)
                    Object.Destroy(btcc.gameObject);

            btc.StartShowBreakChoice();
        }
    }

    // 制造roll
    public static void TryCraftRoll()
    {
        var cuc = CraftUIController.Instance;
        if (cuc == null || cuc.creaftUIPanel == null || !cuc.creaftUIPanel.activeInHierarchy ||
            cuc.craftResultList == null || cuc.craftResultList.Count == 0)
            return;

        var craftType = cuc.craftType;

        var oldList = cuc.craftResultList;
        var newList = new Il2CppSystem.Collections.Generic.List<ItemData>();
        var gc = GameController.Instance;
        var heroData = gc.worldData.Player();

        var baseValue = cuc.GetCraftFinalValue();

        foreach (var itemData in oldList)
        {
            ItemData newItem;

            if (craftType == CraftType.Equipment)
            {
                var subType = itemData.subType;
                var littleType = itemData.equipmentData?.littleType ?? -1;
                var targetWeaponType = cuc.targetWeaponType;

                if (subType == 0)
                    newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                        subType, -1, heroData, targetWeaponType);
                else
                    newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                        subType, littleType, heroData);
            }
            else
            {
                newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                    itemData.subType, -1, heroData);
            }

            newList.Add(newItem);
        }

        cuc.craftResultList = newList;
        cuc.ShowCraftResultChoosePanel();
    }


    // 中元鬼市roll
    public static void TryZhongyuanRoll()
    {
        var tuic = TradeUIController.Instance;
        if (tuic == null || !tuic.tradeUI.activeInHierarchy) return;

        var plotController = PlotController.Instance;
        if (plotController == null || plotController.nowEvent == null) return;

        var currentEvent = plotController.nowEvent;

        if (!currentEvent.eventName.Contains("中元鬼市")) return;

        var tradeUI = TradeUIController.Instance;
        if (tradeUI == null || tradeUI.rightList == null) return;


        var rightItemListData = tradeUI.rightList.targetItemList;
        if (rightItemListData == null) return;

        var oldCount = rightItemListData.allItem?.Count ?? 0;

        var gc = GameController.Instance;
        if (gc == null) return;

        rightItemListData.ClearAllItem();

        gc.GenerateRandomItem(rightItemListData, oldCount, null, Plugin.Instance.ZhongyuanLv.Value, 0f, false);
        tradeUI.rightList.RefreshItemList(rightItemListData, ItemListInteractType.TradeRight, false);
    }

    // roll招募，只有女性角色
    public static void TryRefreshRecruitList()
    {
        if (!IsRecruitReRoll) return;
        var ruic = RecruitUIController.Instance;
        if (ruic == null || ruic.recruitUIPanel == null || !ruic.recruitUIPanel.activeInHierarchy) return;

        var gc = GameController.Instance;
        var gdc = GameDataController.Instance;
        var baseHero = new HeroData
        {
            age = 20,
            isFemale = true,
            talent = 4,
            heroTagPoint = 100
        };
        if (gc != null && gdc != null)
        {
            var tempHeros = gc.worldData.TempHeros;
            tempHeros.Clear();
            var forceLv = gc.worldData.Player()?.GetForce()?.forceLv ?? 0;
            var heroNum = 4;
            for (var i = 0; i < heroNum; i++)
            {
                // 生成女性名称
                var randomName = gdc.GenerateRandomHeroName(true, gdc.GenerateRandomHeroFamilyName(), true);
                // 生成女性hero
                var newHero = gc.GenerateHeroData(randomName, -1, -1, forceLv - 1, baseHero, true,
                    SexLimit.Female);
                gc.worldData.AddTempHero(newHero);
            }

            ruic.HideRecruitUI();
            ruic.ShowRecruitUI(RecruitUIType.Normal, heroNum, forceLv);
        }
    }

    // 刷新特殊事件 没啥意思
    // public static void TryRerollSpeMasterOrStele()
    // {
    //     var pc = PlotController.Instance;
    //     if (pc == null || pc.nowEvent == null) return;
    //
    //     var plotPanel = pc.plotPanel;
    //     if (plotPanel == null || !plotPanel.activeInHierarchy) return;
    //
    //     var eventName = pc.nowEvent.eventName;
    //     if (string.IsNullOrEmpty(eventName)) return;
    //
    //     if (eventName.Contains("世外高人"))
    //     {
    //         pc.FindSpeMasterEvent("");
    //     }
    //     else if (eventName.Contains("失传秘籍") || eventName.Contains("石碑"))
    //     {
    //         pc.FindSpeSteleFight();
    //     }
    // }
}