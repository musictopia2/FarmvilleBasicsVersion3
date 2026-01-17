namespace Phase14TimedUnlimitedSpeedSeeds.Models;
public class InventoryStockDocument
{
    required public FarmKey Farm { get; set; }
    public Dictionary<string, int> List { get; set; } = [];
}