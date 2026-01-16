namespace Phase01SpeedSeeds.Services.Items;
public interface IItemPlanProvider
{
    Task<BasicList<ItemPlanModel>> GetPlanAsync(FarmKey farm);
}