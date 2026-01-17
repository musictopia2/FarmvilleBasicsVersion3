namespace Phase03TimedUnlimitedSpeedSeeds.Services.Inventory;
public interface IInventoryProfile
{
    Task<InventoryStorageProfileModel> LoadAsync();
    Task SaveAsync(InventoryStorageProfileModel profile);
}