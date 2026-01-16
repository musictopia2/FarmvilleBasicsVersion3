namespace Phase01SpeedSeeds.Services.Worksites;
public interface IWorksiteCollectionPolicy
{
    Task<bool> CollectAllAsync();
}