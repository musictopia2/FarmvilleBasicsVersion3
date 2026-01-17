namespace Phase03TimedUnlimitedSpeedSeeds.Services.Items;
public interface IItemFactory
{
    ItemServicesContext GetItemServices(FarmKey farm);
}