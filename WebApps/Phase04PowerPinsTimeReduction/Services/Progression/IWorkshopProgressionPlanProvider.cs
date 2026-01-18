namespace Phase04PowerPinsTimeReduction.Services.Progression;
public interface IWorkshopProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}