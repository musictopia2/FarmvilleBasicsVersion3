namespace Phase05PowerPinsOutputAugmentation.Services.Store;
public interface IStoreFactory
{
    StoreServicesContext GetStoreServices(FarmKey farm);
}