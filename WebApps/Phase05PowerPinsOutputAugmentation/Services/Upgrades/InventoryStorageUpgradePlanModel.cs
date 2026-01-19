namespace Phase05PowerPinsOutputAugmentation.Services.Upgrades;
public class InventoryStorageUpgradePlanModel
{
    public BasicList<UpgradeTier> SiloUpgrades { get; init; } = [];
    public BasicList<UpgradeTier> BarnUpgrades { get; init; } = [];
}