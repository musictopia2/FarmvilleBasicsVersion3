namespace Phase11MVP3.DataAccess.Catalog;
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