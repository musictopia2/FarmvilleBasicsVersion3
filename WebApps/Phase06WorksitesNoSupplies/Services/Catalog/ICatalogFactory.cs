namespace Phase06WorksitesNoSupplies.Services.Catalog;
public interface ICatalogFactory
{
    CatalogServicesContext GetCatalogServices(FarmKey farm);
}