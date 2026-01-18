namespace Phase04PowerPinsTimeReduction.Services.Items;
public interface IItemFactory
{
    ItemServicesContext GetItemServices(FarmKey farm);
}