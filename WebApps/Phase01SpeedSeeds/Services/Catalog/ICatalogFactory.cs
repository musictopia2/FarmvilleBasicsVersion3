namespace Phase01SpeedSeeds.Services.Catalog;
public interface ICatalogFactory
{
    CatalogServicesContext GetCatalogServices(FarmKey farm);
}