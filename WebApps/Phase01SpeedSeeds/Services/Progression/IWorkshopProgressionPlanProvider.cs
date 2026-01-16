namespace Phase01SpeedSeeds.Services.Progression;
public interface IWorkshopProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}