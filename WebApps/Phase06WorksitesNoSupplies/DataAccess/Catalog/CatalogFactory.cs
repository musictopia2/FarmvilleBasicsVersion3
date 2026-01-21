namespace Phase06WorksitesNoSupplies.DataAccess.Catalog;
public class CatalogFactory : ICatalogFactory
{
    CatalogServicesContext ICatalogFactory.GetCatalogServices(FarmKey farm)
    {
        return new()
        {
            CatalogDataSource = new CatalogOfferDatabase()
        };
    }
}