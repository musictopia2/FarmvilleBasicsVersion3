namespace Phase09AutoCompleteAll.Services.Upgrades;
public interface IInventoryStorageUpgradePlanProvider
{
    Task<InventoryStorageUpgradePlanModel> GetPlanAsync(FarmKey farm);
}