namespace Phase03TimedUnlimitedSpeedSeeds.Services.Catalog;
public interface ICatalogDataSource
{
    Task<BasicList<CatalogOfferModel>> GetCatalogAsync(FarmKey farm);
}