namespace Phase01SpeedSeeds.Services.Progression;
public interface IAnimalProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}