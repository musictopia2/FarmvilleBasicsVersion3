namespace Phase08AutoCompleteSingle.Services.Worksites;
public class WorksiteManualCollectionPolicy : IWorksiteCollectionPolicy
{
    Task<bool> IWorksiteCollectionPolicy.CollectAllAsync()
    {
        return Task.FromResult(false);
    }

}