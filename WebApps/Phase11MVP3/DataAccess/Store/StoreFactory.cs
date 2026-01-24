
namespace Phase11MVP3.DataAccess.Store;
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