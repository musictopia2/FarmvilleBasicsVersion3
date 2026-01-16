namespace Phase01SpeedSeeds.Services.Store;
public interface IStoreFactory
{
    StoreServicesContext GetStoreServices(FarmKey farm);
}