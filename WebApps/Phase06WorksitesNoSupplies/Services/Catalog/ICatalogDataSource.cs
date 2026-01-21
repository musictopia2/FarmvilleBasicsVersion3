namespace Phase06WorksitesNoSupplies.Services.Catalog;
public interface ICatalogDataSource
{
    Task<BasicList<CatalogOfferModel>> GetCatalogAsync(FarmKey farm);
}