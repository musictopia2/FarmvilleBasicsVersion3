namespace Phase03TimedUnlimitedSpeedSeeds.Services.Catalog;
public class CatalogServicesContext
{
    public required ICatalogDataSource CatalogDataSource { get; init; }
}