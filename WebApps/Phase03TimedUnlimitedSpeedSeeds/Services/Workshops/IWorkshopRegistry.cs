namespace Phase03TimedUnlimitedSpeedSeeds.Services.Workshops;
public interface IWorkshopRegistry
{
    Task<BasicList<WorkshopRecipe>> GetWorkshopRecipesAsync();
}