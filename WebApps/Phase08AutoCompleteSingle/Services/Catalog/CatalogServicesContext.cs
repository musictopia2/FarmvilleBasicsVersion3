namespace Phase08AutoCompleteSingle.Services.Catalog;
public class CatalogServicesContext
{
    public required ICatalogDataSource CatalogDataSource { get; init; }
}