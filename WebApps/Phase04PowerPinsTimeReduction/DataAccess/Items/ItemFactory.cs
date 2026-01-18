namespace Phase04PowerPinsTimeReduction.DataAccess.Items;
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