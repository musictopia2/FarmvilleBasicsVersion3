namespace Phase05PowerPinsOutputAugmentation.Services.Items;
public interface IItemFactory
{
    ItemServicesContext GetItemServices(FarmKey farm);
}