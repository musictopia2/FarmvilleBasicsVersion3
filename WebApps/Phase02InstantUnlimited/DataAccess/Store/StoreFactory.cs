
namespace Phase02InstantUnlimited.DataAccess.Store;
public class StoreFactory : IStoreFactory
{
    StoreServicesContext IStoreFactory.GetStoreServices(FarmKey farm)
    {
        return new()
        {
            UiStateRepository = new StoreUiStateDatabase(farm)
        };
    }
}