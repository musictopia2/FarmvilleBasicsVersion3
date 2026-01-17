namespace Phase03TimedUnlimitedSpeedSeeds.Services.Store;
public interface IStoreUiStateRepository
{
    Task<EnumCatalogCategory> LoadAsync();
    Task SaveAsync(EnumCatalogCategory category);
}