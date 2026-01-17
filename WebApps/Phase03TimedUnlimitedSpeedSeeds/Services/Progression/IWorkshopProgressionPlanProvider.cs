namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface IWorkshopProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}