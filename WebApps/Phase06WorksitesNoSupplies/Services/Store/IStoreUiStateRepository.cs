namespace Phase06WorksitesNoSupplies.Services.Store;
public interface IStoreUiStateRepository
{
    Task<EnumCatalogCategory> LoadAsync();
    Task SaveAsync(EnumCatalogCategory category);
}