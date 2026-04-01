using Il2Cpp;
using System;
using System.Collections.Generic;

namespace SmartTrade;

public static class ShopMoneyHelper
{
    private static Dictionary<int, int> _areaTotalMoney = new();
    private static Dictionary<int, bool> _areaHasChange = new();
    
    private const int CityBaseMoney = 30000;
    private const int VillageBaseMoney = 10000;
    private const int VillageShopCount = 2;
    private const int CityShopCount = 6;
    
    private static int CalculateShopMoney(int fame, int areaType)
    {
        double fameFactor;
        if (fame <= 5000)
        {
            fameFactor = 1 + fame / 2150.0;
        }
        else
        {
            fameFactor = 3.33 + Math.Log10((fame - 5000) / 10000.0 + 1) * 0.1;
        }
        
        int baseMoney = areaType == 0 ? CityBaseMoney : VillageBaseMoney;
        int totalMoney = (int)(baseMoney * fameFactor);
        
        int shopCount = areaType == 0 ? CityShopCount : VillageShopCount;
        int shopMoney = totalMoney / shopCount;
        
        int rounded = (int)Math.Floor(shopMoney / 1000.0) * 1000 + 1000;
        
        return rounded;
    }

    private static int CalculateFameBonusByPlayer(int areaType)
    {
        var gc = GameController.Instance;
        if (gc == null) return 0;

        var player = gc.worldData?.Player();
        if (player == null) return 0;

        return CalculateShopMoney((int)player.fame, areaType);
    }
    
    public static void OnMonthChanged()
    {
        var gc = GameController.Instance;
        if (gc == null) return;
        var areas = gc.worldData.Areas;
        foreach (var area in areas)
        {
            if (area.areaType is not (0 or 1)) continue;
            _areaTotalMoney[area.areaID] = CalculateFameBonusByPlayer(area.areaType);
            _areaHasChange[area.areaID] = false;
            Plugin.LOG.Msg($"[SmartTrade] {(area.areaType == 0 ? "城市" : "村庄")} {area.areaName}: 商店金钱 = {_areaTotalMoney[area.areaID]}");
        }
    }

    public static int OpenChanged()
    {
        var gc = GameController.Instance;
        if (gc == null) return -1;
        var player = gc.worldData?.Player();
        var areaId = player?.atAreaID ?? -1;
        if (areaId == -1) return -1;
        
        if (_areaTotalMoney.Count == 0)
        {
            OnMonthChanged();
        }
        
        if (!_areaTotalMoney.TryGetValue(areaId, out int money))
        {
            return -1;
        }
        
        if (!_areaHasChange.TryGetValue(areaId, out bool hasChanged) || !hasChanged)
        {
            _areaHasChange[areaId] = true;
        }
        
        return money;
    }

    public static void OnAreaChanged(int money)
    {
        var gc = GameController.Instance;
        if (gc == null) return;
        var player = gc.worldData?.Player();
        var areaId = player?.atAreaID ?? -1;
        if (areaId == -1) return;
        _areaTotalMoney[areaId] = money;
    }
}
