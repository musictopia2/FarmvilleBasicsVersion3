namespace Phase03TimedUnlimitedSpeedSeeds.Services.Store;
public interface IStoreFactory
{
    StoreServicesContext GetStoreServices(FarmKey farm);
}