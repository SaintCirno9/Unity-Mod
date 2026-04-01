using System.Collections.Generic;

namespace SmartTrade;

public class TableListEntity
{
    public int AreaId { get; set; }
    public string AreaName { get; set; }
    
    public string SpeTreasureType { get; set; }
    
    public string SpeTreasureTypeName { get; set; }
    public float AreaSpePriceRate { get; set; }
    public float Income { get; private set; }
    public bool HasExpensive { get; set; }
    public bool HasCheap { get; set; }
    
    public Dictionary<int, bool> TreasurePriceInfo { get; set; } = new();

    public void CalculateIncome()
    {
        Income = 0;
        if (Plugin.PurchaseItems == null || Plugin.PurchaseItems.Count <= 0) return;
        
        var sellRate = 0.25f + Plugin.KouCai * 0.0025f;
        
        foreach (var purchaseItem in Plugin.PurchaseItems)
        {
            if (purchaseItem?.ItemData == null) continue;
            
            var realValue = purchaseItem.RealValue;
            var price = purchaseItem.PurchasePrice;
            var subType = purchaseItem.SubType;
            
            var finalRate = AreaSpePriceRate;
            if (TreasurePriceInfo.TryGetValue(subType, out var isExpensive))
            {
                if (isExpensive)
                {
                    finalRate += 0.5f;
                }
                else
                {
                    finalRate -= 0.5f;
                }
            }
            
            Income += realValue * sellRate * finalRate - price;
        }
    }
}
