namespace Phase01SpeedSeeds.Services.Catalog;
public interface ICatalogDataSource
{
    Task<BasicList<CatalogOfferModel>> GetCatalogAsync(FarmKey farm);
}