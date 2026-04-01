using System;
using Il2Cpp;

namespace SmartTrade;

public class PurchaseItem : IEquatable<PurchaseItem>
{
    public ItemData ItemData { get; }
    public int PurchasePrice { get; set; }
    public float RealValue { get; }
    public int SubType { get; }

    public PurchaseItem(ItemData itemData, int purchasePrice)
    {
        ItemData = itemData;
        PurchasePrice = purchasePrice;
        SubType = itemData?.subType ?? 0;
        
        try
        {
            RealValue = itemData?.GetTreasureRealValue() ?? 0;
        }
        catch
        {
            RealValue = 0;
        }
    }

    public bool Equals(PurchaseItem other)
    {
        if (other == null) return false;
        if (ItemData == null || other.ItemData == null) return false;
        return ReferenceEquals(ItemData, other.ItemData);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as PurchaseItem);
    }

    public override int GetHashCode()
    {
        return ItemData?.GetHashCode() ?? 0;
    }
}
