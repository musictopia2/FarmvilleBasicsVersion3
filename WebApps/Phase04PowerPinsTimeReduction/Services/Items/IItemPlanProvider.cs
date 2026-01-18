namespace Phase04PowerPinsTimeReduction.Services.Items;
public interface IItemPlanProvider
{
    Task<BasicList<ItemPlanModel>> GetPlanAsync(FarmKey farm);
}