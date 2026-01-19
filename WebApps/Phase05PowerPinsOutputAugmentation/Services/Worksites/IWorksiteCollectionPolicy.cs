namespace Phase05PowerPinsOutputAugmentation.Services.Worksites;
public interface IWorksiteCollectionPolicy
{
    Task<bool> CollectAllAsync();
}