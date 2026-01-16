namespace Phase01SpeedSeeds.Services.Items;
public interface IItemFactory
{
    ItemServicesContext GetItemServices(FarmKey farm);
}