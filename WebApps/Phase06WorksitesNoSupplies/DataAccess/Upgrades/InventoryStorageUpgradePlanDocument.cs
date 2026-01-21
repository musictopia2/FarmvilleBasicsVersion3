namespace Phase06WorksitesNoSupplies.DataAccess.Upgrades;
public class InventoryStorageUpgradePlanDocument
{
    required public FarmKey Farm { get; init; }
    public BasicList<UpgradeTier> SiloUpgrades { get; init; } = [];
    public BasicList<UpgradeTier> BarnUpgrades { get; init; } = [];
}