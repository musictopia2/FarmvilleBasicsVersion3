namespace Phase06WorksitesNoSupplies.Services.Items;
public interface IItemPlanProvider
{
    Task<BasicList<ItemPlanModel>> GetPlanAsync(FarmKey farm);
}