namespace Phase01SpeedSeeds.Services.Store;
public interface IStoreUiStateRepository
{
    Task<EnumCatalogCategory> LoadAsync();
    Task SaveAsync(EnumCatalogCategory category);
}