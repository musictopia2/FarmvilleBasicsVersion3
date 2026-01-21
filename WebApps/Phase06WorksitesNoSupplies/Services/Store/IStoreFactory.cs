namespace Phase06WorksitesNoSupplies.Services.Store;
public interface IStoreFactory
{
    StoreServicesContext GetStoreServices(FarmKey farm);
}