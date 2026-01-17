namespace Phase03TimedUnlimitedSpeedSeeds.Services.Worksites;
public interface IWorksiteRegistry
{
    Task<BasicList<WorksiteRecipe>> GetWorksitesAsync();
}