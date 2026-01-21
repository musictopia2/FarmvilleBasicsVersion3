namespace Phase06WorksitesNoSupplies.Services.Items;
public interface IItemFactory
{
    ItemServicesContext GetItemServices(FarmKey farm);
}