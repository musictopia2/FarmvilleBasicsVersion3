namespace Phase11MVP3.DataAccess.Upgrades;
public class InventoryStorageUpgradePlanDocument
{
    required public FarmKey Farm { get; init; }
    public BasicList<UpgradeTier> SiloUpgrades { get; init; } = [];
    public BasicList<UpgradeTier> BarnUpgrades { get; init; } = [];
}