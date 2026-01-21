namespace Phase08AutoCompleteSingle.Services.Upgrades;
public interface IInventoryStorageUpgradePlanProvider
{
    Task<InventoryStorageUpgradePlanModel> GetPlanAsync(FarmKey farm);
}