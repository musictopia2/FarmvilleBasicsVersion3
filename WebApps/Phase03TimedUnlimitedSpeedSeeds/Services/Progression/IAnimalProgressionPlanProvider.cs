namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface IAnimalProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}