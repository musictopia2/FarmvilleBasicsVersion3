namespace Phase03TimedUnlimitedSpeedSeeds.Services.Worksites;
public interface IWorksiteCollectionPolicy
{
    Task<bool> CollectAllAsync();
}