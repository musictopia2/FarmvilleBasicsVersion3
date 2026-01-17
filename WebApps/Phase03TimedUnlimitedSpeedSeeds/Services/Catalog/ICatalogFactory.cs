namespace Phase03TimedUnlimitedSpeedSeeds.Services.Catalog;
public interface ICatalogFactory
{
    CatalogServicesContext GetCatalogServices(FarmKey farm);
}