namespace Phase02InstantUnlimited.DataAccess.Inventory;
public class InventoryStockDocument
{
    required public FarmKey Farm { get; set; }
    public Dictionary<string, int> List { get; set; } = [];
}