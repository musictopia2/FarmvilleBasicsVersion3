namespace Phase01SpeedSeeds.DataAccess.Items;
public class ItemFactory : IItemFactory
{
    ItemServicesContext IItemFactory.GetItemServices(FarmKey farm)
    {
        return new()
        {
            ItemPlanProvider = new ItemPlanDatabase()
        };
    }
}